using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using WSV.DAL;

namespace WSV.BLL.Video
{
    public class Video
    {
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="Item"> model</param>
        public static void DataShow(ref Model.Video.D_Video Item)
        {
            SqlDataReader dr = null;
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new DAL.Video.VideoVisitor();
            SqlParameter[] prams ={
                db.MakeInParam("@VIDEO_name", SqlDbType.VarChar, 50, Item.VIDEO_name),
                db.MakeInParam("@table", SqlDbType.VarChar, 50, Item.VIDEO_table),
                };
            try
            {
                db.GetDataReader(visitor, prams, out dr, "Select_D_Video");
                if (dr.Read())
                {
                    Item.VIDEO_Standard = int.Parse(dr["VIDEO_Standard"].ToString());
                    Item.VIDEO_Brightness = int.Parse(dr["VIDEO_Brightness"].ToString());
                    Item.VIDEO_Contrast = int.Parse(dr["VIDEO_Contrast"].ToString());
                    Item.VIDEO_Hue = int.Parse(dr["VIDEO_Hue"].ToString());
                    Item.VIDEO_Saturation = int.Parse(dr["VIDEO_Saturation"].ToString());
                    Item.VIDEO_Suality = int.Parse(dr["VIDEO_Suality"].ToString());
                }
                else
                {
                    Item.VIDEO_Standard = 2;
                    Item.VIDEO_Brightness = 80;
                    Item.VIDEO_Contrast = 44;
                    Item.VIDEO_Hue = 0;
                    Item.VIDEO_Saturation = 40;
                    Item.VIDEO_Suality = 0;
                }
            }
            catch (Exception ex)
            { throw new Exception(ex.Message); }
            finally
            {
                dr.Close();
                db.Dispose();
            }
        }
        public static string Update(Model.Video.D_Video Item)
        {
            DataBase db = new DataBase();
            DataBaseVisitor visitor = new DAL.Video.VideoVisitor();
            bool bSuc = false;
            int nEffectRows = 0;
            SqlParameter[] prams ={
                        db.MakeInParam("@VIDEOname",SqlDbType .Char ,10,Item.VIDEO_name),
                        db.MakeInParam("@VIDEOtable",SqlDbType .VarChar ,50,Item.VIDEO_table ),
                        db.MakeInParam("@VIDEOStandard",SqlDbType.Int ,4,Item.VIDEO_Standard ),
                        db.MakeInParam("@VIDEOSource",SqlDbType.Int,4,Item.VIDEO_Source ),
                        db.MakeInParam("@VIDEOBrightness",SqlDbType.Int,4,Item.VIDEO_Brightness ),
                        db.MakeInParam("@VIDEOContrast",SqlDbType.Int,4,Item.VIDEO_Contrast ),
                        db.MakeInParam("@VIDEOHue",SqlDbType.Int,4,Item.VIDEO_Hue ),
                        db.MakeInParam("@VIDEOSaturation",SqlDbType.Int,4,Item.VIDEO_Saturation ),
                        db.MakeInParam("@VIDEOSuality",SqlDbType.Int,4,Item.VIDEO_Suality)
                    };
            try
            {
                bSuc = db.TransactSql(visitor, "Set_Video", prams, out nEffectRows);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally
            {
                db.Dispose();
            }
            if (bSuc && nEffectRows > 0)
                return "0101";
            else
                return "0";
        }
    }
}
