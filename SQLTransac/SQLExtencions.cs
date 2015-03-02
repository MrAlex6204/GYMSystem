using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
public static class SQLExtension {
    [Description("Gets Data Row Column value and prevents DBNull value.")]
    public static object GetColumnValue(this System.Data.DataRow Row, object ColumnName) {
        object value = null;
        string ColName = "";
        try {

            if (ColumnName is string) {
                value = Row[(string)ColumnName];
                ColName = Row.Table.Columns[(string)ColumnName].ColumnName;
            } else if (ColumnName is int) {
                value = Row[(int)ColumnName];
                ColName = Row.Table.Columns[(int)ColumnName].ColumnName;
            }

            if (value is System.DBNull) {
                if (Row.Table.Columns[ColName].DataType.FullName == "System.Int32") {
                    return 0;
                } else if (Row.Table.Columns[ColName].DataType.FullName == "System.Double") {
                    return 0;
                } else if (Row.Table.Columns[ColName].DataType.FullName == "System.String") {
                    return "";
                } else if (Row.Table.Columns[ColName].DataType.FullName == "System.Byte") {
                    return null;
                } else {
                    return null;
                }
            }

            


        } catch (System.Data.DataException ex) {
            throw ex;
        }

        return value;
    }
    [Description("Gets Data Table Column value and prevents DBNull value.")]
    public static object GetColumnValue(this System.Data.DataTable Tbl, object ColumnName, int RowIndex = 0) {
        object value = null;
        try {
            if (Tbl.Rows.Count > 0) {
                if (ColumnName is string) {
                    value = Tbl.Rows[RowIndex][(string)ColumnName];
                } else if (ColumnName is int) {
                    value = Tbl.Rows[RowIndex][(int)ColumnName];
                }

                if (value is System.DBNull) {
                    value = null;
                }
            }
        } catch (System.Data.DataException ex) {
            throw ex;
        }

        return value;
    }




}
