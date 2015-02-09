using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel;

namespace Data.SQLTransac
{

    public abstract class SQLTransactions
    {
        private List<SQLVariable> _lstSqlVariables = new List<SQLVariable>();
        private string _ConnectionString = "";

        public class SQLVariable
        {
            public static int Counter = -1;
            public int Index;
            public string Name;
            public object Value;

            public SQLVariable(string Name, object Value)
            {
                Counter++;
                this.Name = Name;
                this.Value = Value;
                this.Index = SQLVariable.Counter;

            }
            public static void Reset()
            {
                Counter = -1;
            }
        }

        public string ConnectionString
        {
            get
            {
                return _ConnectionString;
            }
        }
        public List<SQLVariable> SqlVariables
        {
            set
            {
                _lstSqlVariables = value;
            }
            get
            {
                return _lstSqlVariables;
            }
        }
        public SQLTransactions(string ConnectionString)
        {
            _ConnectionString = ConnectionString;
        }
        public void AddSqlVar(string Name, object Value)
        {
            _lstSqlVariables.Add(new SQLVariable(Name, Value));
        }

        public void ClearSqlVars()
        {
            _lstSqlVariables.Clear();
            SQLVariable.Reset();
        }
        public abstract bool FillTbl(ref DataTable Tbl, string Qry, string TblName = "TblResult");
        [Description("Fill a DataSet")]
        public abstract bool FillDs(ref DataSet Ds, string Qry, string[] TblNames = null);
        [Description("Excute a Qry and return the count of the affected rows.")]
        public abstract int SqlExec(string Qry);
        [Description("Execute a Qry and returns the first column of the first column.")]
        public abstract object SqlExecScalar(string Qry);
        [Description("Returns a prepared Commansd object.This function will add each sql variable added before.")]
        public abstract object SqlPrepareCmd(string Qry);
        [Description("Close the database connection")]        
        public abstract void Close();

    }
    
    namespace OleDb
    {

        public class DataBase : SQLTransac.SQLTransactions, IDisposable
        {
            private System.Data.OleDb.OleDbConnection _objConn = null;
            
            public DataBase(String ConnectionString) : base(ConnectionString)
            {

                try
                {
                    _objConn = new System.Data.OleDb.OleDbConnection(this.ConnectionString);
                    _objConn.Open();

                }
                catch (System.Data.OleDb.OleDbException ex)
                {
                    throw ex;
                }
            }

            ~DataBase()
            {
                Dispose();
            }

            public void Dispose()
            {
                try
                {
                    _objConn.Dispose();
                }
                catch
                {

                }

            }

            public override bool FillTbl(ref DataTable Tbl, string Qry, string TblName = "TblResult")
            {
                System.Data.OleDb.OleDbDataReader rd;
                using (System.Data.OleDb.OleDbCommand cmd = (System.Data.OleDb.OleDbCommand)SqlPrepareCmd(Qry))
                {

                    rd = cmd.ExecuteReader();
                    using (rd)
                    {
                        Tbl.Load(rd, LoadOption.OverwriteChanges);
                    }
                }

                Tbl.TableName = TblName;

                ClearSqlVars();
                return (Tbl.Rows.Count > 0);
            }

            public override bool FillDs(ref DataSet Ds, string Qry, string[] TblNames = null)
            {
                using (System.Data.OleDb.OleDbDataAdapter adapter = new System.Data.OleDb.OleDbDataAdapter())
                {
                    int counter = 0;
                    foreach (string iQry in Qry.Split(';'))
                    {
                        if (iQry.Trim() != "")
                        {
                            using (System.Data.OleDb.OleDbCommand cmd = (System.Data.OleDb.OleDbCommand)SqlPrepareCmd(iQry))
                            {
                                adapter.SelectCommand = cmd;
                                adapter.Fill(Ds, counter.ToString());
                            }
                            counter++;
                        }
                    }
                }

                if (TblNames != null & Ds.Tables.Count > 0)
                {
                    for (int Idx = 0; Idx < TblNames.Length - 1; Idx++)
                    {
                        Ds.Tables[Idx].TableName = TblNames[Idx];
                    }
                }

                ClearSqlVars();
                return (Ds.Tables.Count > 0);
            }

            public override int SqlExec(string Qry)
            {

                using (System.Data.OleDb.OleDbCommand cmd = (System.Data.OleDb.OleDbCommand)SqlPrepareCmd(Qry))
                {
                    return cmd.ExecuteNonQuery();
                }
            }

            public override object SqlExecScalar(string Qry)
            {
                using (System.Data.OleDb.OleDbCommand cmd = (System.Data.OleDb.OleDbCommand)SqlPrepareCmd(Qry))
                {
                    return cmd.ExecuteScalar();
                }
            }

            public override object SqlPrepareCmd(string Qry)
            {
                System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand();
                SQLVariable[] OledbVariables = _GetPreparedOledbVariables(ref Qry);
                foreach (SQLVariable iSqlVariable in OledbVariables)
                {
                    cmd.Parameters.Add(new System.Data.OleDb.OleDbParameter("?", iSqlVariable.Value));
                }

                if (_objConn == null)
                {
                    _objConn = new System.Data.OleDb.OleDbConnection(ConnectionString);
                }

                cmd.CommandText = Qry;
                cmd.Connection = _objConn;
                return cmd;
            }

            private SQLVariable[] _GetPreparedOledbVariables(ref string Qry)
            {
                List<SQLVariable> LstOledbVariables = new List<SQLVariable>();
                SQLVariable[] SortedVariables = null;
                bool bNeedReSort = true;

                foreach (SQLVariable iSql in SqlVariables)
                {
                    int Index = -1;
                    do
                    {
                        Index++;
                        Index = Qry.ToUpper().IndexOf(iSql.Name.ToUpper(), Index);
                        if (Index > -1)
                        {
                            SQLVariable iTemp = new SQLVariable("?", iSql.Value);
                            iTemp.Index = Index;
                            LstOledbVariables.Add(iTemp);
                        }

                    } while (Index > -1);

                    Qry = Qry.Replace(iSql.Name, "?");
                }

                SortedVariables = LstOledbVariables.ToArray();

                while (bNeedReSort)
                {
                    bNeedReSort = false;
                    for (int Index = 0; Index < SortedVariables.Length - 1; Index++)
                    {
                        if (SortedVariables[Index].Index > SortedVariables[Index + 1].Index)
                        {
                            SQLVariable temp = SortedVariables[Index + 1];
                            SortedVariables[Index + 1] = SortedVariables[Index];
                            SortedVariables[Index] = temp;
                            bNeedReSort = true;
                        }
                    }
                }
                return SortedVariables;
            }

            public override void Close()
            {
                if (_objConn.State != ConnectionState.Closed)
                {
                    _objConn.Close();
                }

            }
        }

    }

}
