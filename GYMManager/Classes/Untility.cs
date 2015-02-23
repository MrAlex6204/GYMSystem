using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data.SQLTransac.OleDb;

static class Utility {
    public static DataBase Db = new DataBase(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\dbGYM.mdb;Persist Security Info=True;");

    public static string GetConfigValue(string ConfigName) {
        string Qry = "SELECT TOP 1 CONFIG_VALUE FROM TBL_CONFIG WHERE CONFIG_NAME = @ConfigName";
        Db.AddSqlVar("@ConfigName", ConfigName);
        return Db.SqlExecScalar(Qry).ToString();
    }

    public static byte[] GetPictureStream(string FilePath) {
        byte[] FsImg = null;
        using (System.IO.FileStream FsPicture = new System.IO.FileStream(FilePath, System.IO.FileMode.Open,System.IO.FileAccess.Read)) {
            FsImg = new byte[FsPicture.Length];
            FsPicture.Read(FsImg, 0, (int)FsPicture.Length);
        }

        return FsImg;
    }

}

