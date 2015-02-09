using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data.SQLTransac.OleDb;

  static  class Definitions
    {
      public static DataBase Db = new DataBase(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\dbGYM.mdb;Persist Security Info=True;");
      public static string GetConfigValue(string ConfigName) {
          string Qry = "SELECT TOP 1 CONFIG_VALUE FROM TBL_CONFIG WHERE CONFIG_NAME = @ConfigName";
          Db.AddSqlVar("@ConfigName", ConfigName);
          return Db.SqlExecScalar(Qry).ToString();
      }
    }

