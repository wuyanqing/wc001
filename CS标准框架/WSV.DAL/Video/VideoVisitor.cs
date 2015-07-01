using System;
using System.Collections.Generic;
using System.Text;

namespace WSV.DAL.Video
{
    public class VideoVisitor : DataBaseVisitor
    {
        /// <summary>
        /// 主数据
        /// </summary>
        public override string ExecSql(string sqlCommand)
        {
            string sql = "";//返回查询结果集
            if ((sql = CommonSql(sqlCommand)) != "")
                return sql;
            return sql;
        }
        private static string CommonSql(string sqlCommand)
        {
            string sql = "";
            switch (sqlCommand)
            {
                //查询视频设置的信息
                case "Select_D_Video":
                    sql = "select VIDEO_name,VIDEO_table,VIDEO_Standard,VIDEO_Source,VIDEO_Brightness,VIDEO_Contrast,VIDEO_Hue,VIDEO_Saturation,VIDEO_Suality from D_Video where VIDEO_name=@VIDEO_name and VIDEO_table=VIDEO_table";
                    break;
                case "Set_Video":
                    sql = "execute pro_videoconfig @VIDEOname,@VIDEOtable,@VIDEOStandard,@VIDEOSource,@VIDEOBrightness,@VIDEOContrast ,@VIDEOHue,@VIDEOSaturation,@VIDEOSuality";
                    break;
            }
            return sql;
        }
    }
}
