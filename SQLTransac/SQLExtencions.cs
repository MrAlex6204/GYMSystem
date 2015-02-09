using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
public static class SQLExtension
{
    [Description("Gets Data Table Column value and prevents DBNull value.")]
    public static object GetColumnValue(this System.Data.DataTable Tbl, object ColumnName, int RowIndex = 0)
    {
        object value = null;
        try
        {
            if (Tbl.Rows.Count > 0)
            {
                if (ColumnName is string)
                {
                    value = Tbl.Rows[RowIndex][(string)ColumnName];
                }
                else if (ColumnName is int)
                {
                    value = Tbl.Rows[RowIndex][(int)ColumnName];
                }

                if (value is System.DBNull)
                {
                    value = null;
                }
            }
        }
        catch (System.Data.DataException ex)
        {
            throw ex;
        }

        return value;
    }


}
