using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

public class SocioInfo {

    #region Class Constructor

    public SocioInfo() {

        this.SocioImg = new ImgInfo();//===>Initilize structure

    }

    #endregion

    #region Structures

    public class ImgInfo {
        public object FSImage;
        public string FileName;
        public System.Drawing.Image Image {
            get {
                if (FSImage != null) {
                    System.IO.MemoryStream ImgStream = new System.IO.MemoryStream((byte[])FSImage);
                    return System.Drawing.Image.FromStream(ImgStream);
                } else {
                    return null;
                }
            }
        }


    }

    #endregion

    #region Properties

    public string Id {
        get;
        set;
    }

    public ImgInfo SocioImg {
        get;
        set;
    }

    public string Nombres {
        get;
        set;
    }
    public string Apellidos {
        get;
        set;
    }
    public string Tel {
        get;
        set;
    }
    public string Movil {
        get;
        set;
    }
    public string Sexo {
        get;
        set;
    }
    public string Domicilio {
        get;
        set;
    }
    public string Email {
        get;
        set;
    }
    public string Edad {
        get;
        set;
    }
    public string Notas {
        get;
        set;
    }
    #endregion

    #region Function

    public bool Save() {
        string GetIdQry = "Select @@Identity";
        string SavePictureQry =
        " INSERT INTO TBL_FOTOS (CLIENTE_ID,FOTO,FILE_NAME) VALUES(@ID,@FOTO,@FILE_NAME)";
        string InsertQry =
        " INSERT INTO TBL_SOCIOS " +
        " (NOMBRES,APELLIDOS,TEL,MOVIL,SEXO,DOMICILIO,EMAIL,EDAD,NOTAS)" +
        " VALUES (@NOMBRES,@APELLIDOS,@TEL,@MOVIL,@SEXO,@DOMICILIO,@EMAIL,@EDAD,@NOTAS)";

        Utility.Db.ClearSqlVars();
        Utility.Db.AddSqlVar("@NOMBRES", this.Nombres);
        Utility.Db.AddSqlVar("@APELLIDOS", this.Apellidos);
        Utility.Db.AddSqlVar("@TEL", this.Tel);
        Utility.Db.AddSqlVar("@MOVIL", this.Movil);
        Utility.Db.AddSqlVar("@SEXO", this.Sexo);
        Utility.Db.AddSqlVar("@DOMICILIO", this.Domicilio);
        Utility.Db.AddSqlVar("@EMAIL", this.Email);
        Utility.Db.AddSqlVar("@EDAD", this.Edad);
        Utility.Db.AddSqlVar("@NOTAS", this.Notas);

        if (Utility.Db.SqlExec(InsertQry) > 0) {
            this.Id = Utility.Db.SqlExecScalar(GetIdQry).ToString();

            if (this.SocioImg.FSImage != null) {
                Utility.Db.ClearSqlVars();
                Utility.Db.AddSqlVar("@ID", this.Id);
                Utility.Db.AddSqlVar("@FILE_NAME", this.SocioImg.FileName);
                Utility.Db.AddSqlVar("@FOTO", this.SocioImg.FSImage);

                if (Utility.Db.SqlExec(SavePictureQry) > 0) {
                    return true;
                } else {
                    return false;
                }

            } else {
                return true;
            }

        } else {
            return false;

        }
    }
    public bool Update() {
        string UpdatePictureQry =
        " UPDATE TBL_FOTOS SET " +
        " FOTO=@FOTO,FILE_NAME=@FILE_NAME WHERE CLIENTE_ID = @ID";

        string UpdateInfoQry =
        " UPDATE TBL_SOCIOS SET " +
        " NOMBRES = @NOMBRES,APELLIDOS = @APELLIDOS,TEL = @TEL,MOVIL = @MOVIL,SEXO = @SEXO," +
        " DOMICILIO = @DOMICILIO,EMAIL = @EMAIL,EDAD = @EDAD,NOTAS = @NOTAS" +
        " WHERE CLIENTE_ID = @ID";

        Utility.Db.ClearSqlVars();
        Utility.Db.AddSqlVar("@CLIENTE_ID", this.Id);
        Utility.Db.AddSqlVar("@NOMBRES", this.Nombres);
        Utility.Db.AddSqlVar("@APELLIDOS", this.Apellidos);
        Utility.Db.AddSqlVar("@TEL", this.Tel);
        Utility.Db.AddSqlVar("@MOVIL", this.Movil);
        Utility.Db.AddSqlVar("@SEXO", this.Sexo);
        Utility.Db.AddSqlVar("@DOMICILIO", this.Domicilio);
        Utility.Db.AddSqlVar("@EMAIL", this.Email);
        Utility.Db.AddSqlVar("@EDAD", this.Edad);
        Utility.Db.AddSqlVar("@NOTAS", this.Notas);

        if (Utility.Db.SqlExec(UpdateInfoQry) > 0) {
            if (SocioImg.FSImage != null) {
                Utility.Db.ClearSqlVars();
                Utility.Db.AddSqlVar("@ID", this.Id);
                Utility.Db.AddSqlVar("@FILE_NAME", this.SocioImg.FileName);
                Utility.Db.AddSqlVar("@FOTO", this.SocioImg.FSImage);

                if (Utility.Db.SqlExec(UpdatePictureQry) > 0) {
                    return true;
                } else {
                    return false;
                }

            } else {
                return true;
            }
        } else {
            return true;
        }
    }
    public bool Delete() {
        string DeleteFoto =
        "DELETE FROM TBL_FOTOS WHERE CLIENTE_ID = @ID";

        string DeleteInfoQry =
        "DELETE FROM TBL_SOCIOS WHERE CLIENTE_ID = @ID";

        Utility.Db.ClearSqlVars();
        Utility.Db.AddSqlVar("@ID", this.Id);
        if (Utility.Db.SqlExec(DeleteInfoQry) > 0) {
            Utility.Db.ClearSqlVars();
            Utility.Db.AddSqlVar("@ID", this.Id);

            Utility.Db.SqlExec(DeleteFoto);
            return true;            

        } else {
            return false;
        }
    }

    public static List<SocioInfo> GetSocios() {
        List<SocioInfo> LstSocios = new List<SocioInfo>();
        DataTable TblSocios = new DataTable();
        string Qry = "SELECT A.*,B.FOTO,B.FILE_NAME FROM TBL_SOCIOS AS [A] LEFT JOIN TBL_FOTOS AS [B] ON A.CLIENTE_ID = B.CLIENTE_ID";

        Utility.Db.FillTbl(ref TblSocios, Qry);

        foreach (DataRow iRow in TblSocios.Rows) {
            SocioInfo Item = new SocioInfo() {
                Id = iRow.GetColumnValue("CLIENTE_ID").ToString(),
                Nombres = iRow.GetColumnValue("NOMBRES").ToString(),
                Apellidos = iRow.GetColumnValue("APELLIDOS").ToString(),
                Tel = iRow.GetColumnValue("TEL").ToString(),
                Movil = iRow.GetColumnValue("MOVIL").ToString(),
                Sexo = iRow.GetColumnValue("SEXO").ToString(),
                Domicilio = iRow.GetColumnValue("DOMICILIO").ToString(),
                Email = iRow.GetColumnValue("EMAIL").ToString(),
                Edad = iRow.GetColumnValue("EDAD").ToString(),
                Notas = iRow.GetColumnValue("NOTAS").ToString()
            };

            Item.SocioImg.FileName = iRow.GetColumnValue("FILE_NAME").ToString();
            Item.SocioImg.FSImage = iRow.GetColumnValue("FOTO");


            LstSocios.Add(Item);

        }

        return LstSocios;
    }

    #endregion

}

