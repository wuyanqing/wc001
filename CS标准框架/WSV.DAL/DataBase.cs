using System;
using System.Collections.Generic;
using System.Text;
//using System.Data.SqlClient;
using System.Data.SqlClient;
using System.Data;

namespace WSV.DAL
{
    /// <summary>
    /// 功   能: 封装了访问数据库的各种操作
    /// 创建时间：2007年4月9日
    /// 修改时间：2007年4月9日
    /// 作   者 ：
    /// </summary>
    public class DataBase
    {

        private SqlConnection m_sqlCon;// 连接数据源

        public DataBase()
        {

        }

        #region 用ExecuteNonQuery执行SQL语句
        /// <summary>
        /// 用ExecuteNonQuery执行SQL语句
        /// </summary>
        /// <param name="dbVistor">访问类</param>
        /// <param name="procName">查询命令</param>
        /// <param name="prams">命令参数</param>
        /// <returns>执行是否成功</returns>
        public bool TransactSql(DataBaseVisitor dbVistor, string sqlCommand, SqlParameter[] param)
        {
            if ((false == Open()) || (null == dbVistor))
                return false;

            SqlCommand cmd = new SqlCommand(dbVistor.ExecSql(sqlCommand), m_sqlCon);

            if (param != null)
            {
                foreach (SqlParameter parameter in param)
                    cmd.Parameters.Add(parameter);

            }

            try
            {
                cmd.ExecuteNonQuery();
                Close();
                return true;
            }
            catch (SqlException ex)
            {
                Close();
                throw new Exception(ex.Message);
                return false;
            }

        }
        #endregion

        #region 用ExecuteNonQuery执行SQL语句(重载2)
        /// <summary>
        /// 用ExecuteNonQuery执行SQL语句(重载2)
        /// </summary>
        /// <param name="dbVistor">访问类</param>
        /// <param name="procName">查询命令</param>
        /// <param name="prams">命令参数</param>
        /// <returns>执行是否成功</returns>
        public bool TransactSql(DataBaseVisitor dbVistor, string sqlCommand, SqlParameter[] param, out int nReturnRows)
        {
            nReturnRows = 0;
            if ((false == Open()) || (null == dbVistor))
                return false;

            SqlCommand cmd = new SqlCommand(dbVistor.ExecSql(sqlCommand), m_sqlCon);

            if (param != null)
            {
                foreach (SqlParameter parameter in param)
                    cmd.Parameters.Add(parameter);
            }

            try
            {
                nReturnRows = cmd.ExecuteNonQuery();
                Close();
                return true;
            }
            catch (SqlException ex)
            {
                Close();
                throw new Exception(ex.Message);
                return false;
            }

        }
        #endregion

        #region 用ExecuteNonQuery执行SQL语句(重载3)
        /// <summary>
        /// 用ExecuteNonQuery执行SQL语句(重载2)
        /// </summary>
        /// <param name="dbVistor">访问类</param>
        /// <param name="procName">查询命令</param>
        /// <param name="prams">命令参数</param>
        /// <returns>执行是否成功</returns>
        public bool PortTransactSql1(DataBaseVisitor dbVistor, string sqlCommand, SqlParameter[] param, out int nReturnRows)
        {
            nReturnRows = 0;
            if ((false == PortOpen1()) || (null == dbVistor))
                return false;

            SqlCommand cmd = new SqlCommand(dbVistor.ExecSql(sqlCommand), m_sqlCon);

            if (param != null)
            {
                foreach (SqlParameter parameter in param)
                    cmd.Parameters.Add(parameter);
            }
            try
            {
                nReturnRows = cmd.ExecuteNonQuery();
                Close();
                return true;
            }
            catch (SqlException ex)
            {
                Close();
                throw new Exception(ex.Message);
                return false;
            }
        }
        #endregion

        #region 用ExecuteNonQuery执行SQL语句(重载4)
        /// <summary>
        /// 用ExecuteNonQuery执行SQL语句(重载2)
        /// </summary>
        /// <param name="dbVistor">访问类</param>
        /// <param name="procName">查询命令</param>
        /// <param name="prams">命令参数</param>
        /// <returns>执行是否成功</returns>
        public bool PortTransactSql2(DataBaseVisitor dbVistor, string sqlCommand, SqlParameter[] param, out int nReturnRows)
        {
            nReturnRows = 0;
            if ((false == PortOpen2()) || (null == dbVistor))
                return false;

            SqlCommand cmd = new SqlCommand(dbVistor.ExecSql(sqlCommand), m_sqlCon);

            if (param != null)
            {
                foreach (SqlParameter parameter in param)
                    cmd.Parameters.Add(parameter);
            }

            try
            {
                nReturnRows = cmd.ExecuteNonQuery();
                Close();
                return true;
            }
            catch (SqlException ex)
            {
                Close();
                throw new Exception(ex.Message);
                return false;
            }
        }
        #endregion

        #region 用ExecuteNonQuery执行SQL语句(重载1)
        /// <summary>
        /// 用ExecuteNonQuery执行SQL语句(重载1)
        /// </summary>
        /// <param name="cmdText">sql语句</param>
        /// <returns>执行是否成功</returns>
        public bool TransactSql(string cmdText)
        {
            bool Flag = false;
            int n = 0;
            if (!Open()){return false;}
            try
            {
                SqlCommand cmd = new SqlCommand(cmdText,m_sqlCon);
                n = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.Close();
            }
            if (n > 0) { Flag = true; }
            return Flag;

        }
        #endregion

        #region 返回查询命令的DataDet
        /// <summary>
        /// 返回查询命令的DataDet
        /// </summary> 
        /// <param name="dbVistor">访问类</param>
        /// <param name="prams">命令参数</param>
        /// <param name="sqlCommand">查询命令</param>
        /// <returns>查询的数据集</returns>
       
        public DataSet ReturnDataSet(DataBaseVisitor dbVistor, SqlParameter[] param, string sqlCommand)
        {

            if ((false == Open()) || (null == dbVistor))
                return null;

            try
            {
                SqlCommand comm = new SqlCommand(dbVistor.ExecSql(sqlCommand), m_sqlCon);
                if (param != null)
                {
                    foreach (SqlParameter parameter in param)
                        comm.Parameters.Add(parameter);
                }
                SqlDataAdapter sqlDA = new SqlDataAdapter();
                sqlDA.SelectCommand = comm;
                DataSet sqlDS = new DataSet();
                sqlDA.Fill(sqlDS, "EastTable");
                return sqlDS;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                return null;
            }

        }
        #endregion

        #region 返回查询命令的DataDet
        /// <summary>
        /// 返回查询命令的DataDet
        /// </summary> 
        /// <param name="dbVistor">访问类</param>
        /// <param name="prams">命令参数</param>
        /// <param name="sqlCommand">查询命令</param>
        /// <param name="nEffectRows">返回查询行数</param>
        /// <returns>查询的数据集</returns>
        public DataSet ReturnDataSet(DataBaseVisitor dbVistor, SqlParameter[] param, string sqlCommand, out int nEffectRows)
        {
            nEffectRows = 0;
            if ((false == Open()) || (null == dbVistor))
                return null;

            try
            {
                SqlCommand comm = new SqlCommand(dbVistor.ExecSql(sqlCommand), m_sqlCon);
                if (param != null)
                {
                    foreach (SqlParameter parameter in param)
                        comm.Parameters.Add(parameter);
                }
                SqlDataAdapter sqlDA = new SqlDataAdapter();
                sqlDA.SelectCommand = comm;
                DataSet sqlDS = new DataSet();
                nEffectRows = sqlDA.Fill(sqlDS, "EastTable");
                return sqlDS;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                return null;
            }

        }
        #endregion

        #region 返回查询命令的DataDet重载1
        /// <summary>
        /// 返回查询命令的DataDet
        /// </summary>
        /// <param name="dbVistor">访问类</param>
        /// <param name="prams">命令参数</param>
        /// <param name="sqlCommand">查询命令</param>
        /// <param name="tableName">返回TableName</param>       
        /// <returns>查询的数据集</returns>
        public DataSet ReturnDataSet(DataBaseVisitor dbVistor, SqlParameter[] param, string sqlCommand, string tableName)
        {
            try
            {
                if ((false == Open()) || (null == dbVistor))
                    return null;


                SqlCommand comm = new SqlCommand(dbVistor.ExecSql(sqlCommand), m_sqlCon);
                if (param != null)
                {
                    foreach (SqlParameter parameter in param)
                        comm.Parameters.Add(parameter);
                }
                else
                {
                    Close();
                    return null;
                }
                SqlDataAdapter sqlDA = new SqlDataAdapter();
                sqlDA.SelectCommand = comm;
                DataSet sqlDS = new DataSet();
                sqlDA.Fill(sqlDS, tableName);
                return sqlDS;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                return null;
            }
        }
        #endregion

        #region 返回查询命令的DataDet重载1
        /// <summary>
        /// 返回查询命令的DataDet
        /// </summary>
        /// <param name="dbVistor">访问类</param>
        /// <param name="prams">命令参数</param>
        /// <param name="sqlCommand">查询命令</param>
        /// <param name="tableName">返回TableName</param>
        /// <param name="nEffectRows">返回查询行数</param>
        /// <returns>查询的数据集</returns>
        public DataSet ReturnDataSet(DataBaseVisitor dbVistor, SqlParameter[] param, string sqlCommand, string tableName, out int nEffectRows)
        {
            try
            {
                nEffectRows = 0;
                if ((false == Open()) || (null == dbVistor))
                    return null;


                SqlCommand comm = new SqlCommand(dbVistor.ExecSql(sqlCommand), m_sqlCon);
                if (param != null)
                {
                    foreach (SqlParameter parameter in param)
                        comm.Parameters.Add(parameter);
                }
                else
                {
                    Close();
                    nEffectRows = 0;
                    return null;
                }
                SqlDataAdapter sqlDA = new SqlDataAdapter();
                sqlDA.SelectCommand = comm;
                DataSet sqlDS = new DataSet();
                nEffectRows = sqlDA.Fill(sqlDS, tableName);
                return sqlDS;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                return null;
            }

        }
        #endregion

        #region 报表查询
        /// <summary>
        /// 返回查询命令的DataDet
        /// </summary>
        /// <param name="dbVistor">访问类</param>
        /// <param name="prams">命令参数</param>
        /// <param name="sqlCommand">查询命令</param>
        /// <param name="tableName">返回TableName</param>
        /// <param name="nEffectRows">返回查询行数</param>
        /// <returns>查询的数据集</returns>
        public DataSet ReturnDataSet(DataBaseVisitor dbVistor, string sqlCommand, string TableName, string WhereSql)
        {
            try
            {

                if ((false == Open()) || (null == dbVistor))
                    return null;


                SqlCommand comm = new SqlCommand(dbVistor.ExecSql(sqlCommand) + WhereSql, m_sqlCon);
                SqlDataAdapter sqlDA = new SqlDataAdapter();
                sqlDA.SelectCommand = comm;
                DataSet sqlDS = new DataSet();
                sqlDA.Fill(sqlDS, TableName);
                return sqlDS;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                return null;
            }

        }
        #endregion

        #region 返回查询命令的DataDet重载2
        /// <summary>
        ///  返回查询命令的DataDet
        /// </summary>
        /// <param name="dbVistor">访问类</param>
        /// <param name="sqlCommand">查询命令</param>
        /// <param name="tableName">返回TableName</param>
        /// <returns></returns>
        public DataSet ReturnDataSet(DataBaseVisitor dbVistor, string sqlCommand, string tableName)
        {
            try
            {
                if ((false == Open()) || (null == dbVistor))
                    return null;

                SqlCommand comm = new SqlCommand(dbVistor.ExecSql(sqlCommand), m_sqlCon);
                SqlDataAdapter sqlDA = new SqlDataAdapter();
                sqlDA.SelectCommand = comm;
                DataSet sqlDS = new DataSet();
                sqlDA.Fill(sqlDS, tableName);
                return sqlDS;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                return null;
            }

        }
        #endregion

        #region 返回查询命令的DataDet重载2
        /// <summary>
        ///  返回查询命令的DataDet
        /// </summary>
        /// <param name="dbVistor">访问类</param>
        /// <param name="sqlCommand">查询命令</param>
        /// <param name="tableName">返回TableName</param>
        /// <param name="nEffectRows">返回查询行数</param>
        /// <returns></returns>
        public DataSet ReturnDataSet(DataBaseVisitor dbVistor, string sqlCommand, string tableName, out int nEffectRows)
        {
            try
            {
                nEffectRows = 0;
                if ((false == Open()) || (null == dbVistor))
                    return null;

                SqlCommand comm = new SqlCommand(dbVistor.ExecSql(sqlCommand), m_sqlCon);
                SqlDataAdapter sqlDA = new SqlDataAdapter();
                sqlDA.SelectCommand = comm;
                DataSet sqlDS = new DataSet();
                nEffectRows = sqlDA.Fill(sqlDS, tableName);
                return sqlDS;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }
        #endregion

        #region 返回DataReader
        /// <summary>
        /// 返回DataReader
        /// </summary>
        /// <param name="dbVistor">访问类</param>
        /// <param name="prams">命令参数</param>
        /// <param name="GetReader">返回DataReader</param>
        /// <param name="sqlCommand">查询命令</param>
        public void GetDataReader(DataBaseVisitor dbVistor, SqlParameter[] prams, out SqlDataReader getReader, string sqlCommand)
        {
            try
            {
                if (false == Open() || null == dbVistor)
                {
                    getReader = null;
                    return;
                }

                SqlCommand comm = new SqlCommand(dbVistor.ExecSql(sqlCommand), m_sqlCon);
                if (prams != null)
                {
                    foreach (SqlParameter parameter in prams)
                        comm.Parameters.Add(parameter);
                }

                getReader = comm.ExecuteReader();
                comm.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        #endregion

        #region 打开数据库联接
        /// <summary>
        /// 打开数据库联接
        /// </summary>
        /// <returns>是否连接成功</returns>
        public bool Open()
        {
            // 打开数据库连接
            if (m_sqlCon == null)
            {
                try
                {
                    m_sqlCon = new SqlConnection(ConnString.Conn);
                }
                catch
                {
                    return false;
                }
            }
            try
            {
                if (m_sqlCon.State == System.Data.ConnectionState.Closed)
                    m_sqlCon.Open();
            }
            catch (Exception ex)
            {
                Dispose();
                throw new Exception(ex.Message);
                return false;
            }
            return true;
        }
        #endregion

        #region 关闭数据库连接
        /// <summary>
        /// 关闭数据库连接
        /// </summary>
        public void Close()
        {
            if (m_sqlCon != null)
                m_sqlCon.Close();
            m_sqlCon.Dispose();
        }
        #endregion

        #region 打开接口数据库联接1
        /// <summary>
        /// 打开数据库联接
        /// </summary>
        /// <returns>是否连接成功</returns>
        public bool PortOpen1()
        {
            // 打开数据库连接
            if (m_sqlCon == null)
            {
                try
                {
                    m_sqlCon = new SqlConnection(ConnString.Conn1);
                }
                catch
                {
                    return false;
                }
            }
            try
            {
                if (m_sqlCon.State == System.Data.ConnectionState.Closed)
                    m_sqlCon.Open();
            }
            catch (Exception ex)
            {
                Dispose();
                throw new Exception(ex.Message);
                return false;
            }
            return true;
        }
           #endregion

        #region 打开接口数据库联接2
        /// <summary>
        /// 打开数据库联接
        /// </summary>
        /// <returns>是否连接成功</returns>
        public bool PortOpen2()
        {
            // 打开数据库连接
            if (m_sqlCon == null)
            {
                try
                {
                    m_sqlCon = new SqlConnection(ConnString.Conn2);
                }
                catch
                {
                    return false;
                }
            }
            try
            {
                if (m_sqlCon.State == System.Data.ConnectionState.Closed)
                    m_sqlCon.Open();
            }
            catch (Exception ex)
            {
                Dispose();
                throw new Exception(ex.Message);
                return false;
            }
            return true;
        }
        #endregion

        #region 释放数据库连接资源
        /// <summary>
        /// 释放资源
        /// </summary>
        public void Dispose()
        {
            // 确认连接是否已经关闭
            if (m_sqlCon != null)
            {
                m_sqlCon.Close();
                m_sqlCon.Dispose();

            }
        }
        #endregion

        #region 传入输入参数
        /// <summary>
        /// 传入输入参数
        /// </summary>
        /// <param name="ParamName">执行SQL语句名称</param>
        /// <param name="DbType">参数类型</param></param>
        /// <param name="Size">参数大小</param>
        /// <param name="Value">参数值</param>
        /// <returns>新的 parameter 对象</returns>
        public SqlParameter MakeInParam(string ParamName, SqlDbType DbType, int Size, object Value)
        {
            return MakeParam(ParamName, DbType, Size, ParameterDirection.Input, Value);
        }
        #endregion

        #region 生成Sql参数
        /// <summary>
        /// 生成参数
        /// </summary>
        /// <param name="ParamName">执行SQL语句名称</param>
        /// <param name="DbType">参数类型</param>
        /// <param name="Size">参数大小</param>
        /// <param name="Direction">参数方向</param>
        /// <param name="Value">参数值</param>
        /// <returns>新的 parameter 对象</returns>
        public SqlParameter MakeParam(string ParamName,SqlDbType DbType, Int32 Size, ParameterDirection Direction, object Value)
        {
            SqlParameter param;

            if (Size > 0)
                param = new SqlParameter(ParamName, DbType, Size);
            else
                param = new SqlParameter(ParamName, DbType);

            param.Direction = Direction;
            if (!(Direction == ParameterDirection.Output && Value == null))
                param.Value = Value;

            return param;
        }
        #endregion

        #region 返回首行首列
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbVistor"></param>
        /// <param name="sqlCommand"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public string FirstRow(DataBaseVisitor dbVistor, string sqlCommand, SqlParameter[] param)
        {
            DataBase DB = new DataBase();
            if (false == DB.Open())
                DB.Open();
            SqlCommand cmd = new SqlCommand(dbVistor.ExecSql(sqlCommand), DB.m_sqlCon);
            if (param != null)
            {
                foreach (SqlParameter parameter in param)
                    cmd.Parameters.Add(parameter);
            }
            try
            {
                string DeptName = cmd.ExecuteScalar().ToString();
                return DeptName;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                return null;
            }
        }
        #endregion

        #region 返回DataReader
        /// <summary>
        /// 返回DataReader,
        /// </summary>
        /// <param name="getReader"></param>
        /// <param name="sqlCommandText">传入要执行的sql语句</param>
        public void GetDataReader(out SqlDataReader getReader, string sqlCommandText)
        {
            try
            {
                if (false == Open() )
                {
                    getReader = null;
                    return;
                }

                SqlCommand comm = new SqlCommand();
                comm.Connection = m_sqlCon;
                comm.CommandText = sqlCommandText;

                getReader = comm.ExecuteReader();
                comm.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        #endregion

        #region 返回查询命令的DataDet
        /// <summary>
        /// 返回ds
        /// </summary>
        /// <param name="sqlCommandText">查询语句</param>
        /// <returns></returns>
        public DataSet ReturnDataSet( string sqlCommandText)
        {

            if ((false == Open()) )
                return null;

            try
            {
                SqlCommand comm = new SqlCommand();
                comm.Connection = m_sqlCon;
                comm.CommandText = sqlCommandText;
                SqlDataAdapter sqlDA = new SqlDataAdapter();
                sqlDA.SelectCommand = comm;
                DataSet sqlDS = new DataSet();
                sqlDA.Fill(sqlDS, "EastTable");
                return sqlDS;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                return null;
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sqlCommandText"></param>
        /// <param name="TableName">表名</param>
        /// <returns></returns>
        public DataSet ReturnDataSet(string sqlCommandText,string TableName)
        {

            if ((false == Open()))
                return null;

            try
            {
                SqlCommand comm = new SqlCommand();
                comm.Connection = m_sqlCon;
                comm.CommandText = sqlCommandText;
                SqlDataAdapter sqlDA = new SqlDataAdapter();
                sqlDA.SelectCommand = comm;
                DataSet sqlDS = new DataSet();
                sqlDA.Fill(sqlDS, TableName);
                return sqlDS;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                return null;
            }

        }
        #endregion

        //        #region 
        //        public string MaxRow(DataBaseVisitor dbVistor,string sqlCommand)
        //        {
        //            DataBase DB = new DataBase();
        //            if (false == DB.Open())
        //                DB.Open();
        //            SqlCommand cmd = new SqlCommand(dbVistor.ExecSql(sqlCommand), DB.m_sqlCon);
        //            try
        //            {
        //                string strMax = cmd.ExecuteScalar().ToString();
        //                return strMax;
        //            }
        //            catch (Exception ex)
        //            {
        //                throw new Exception(ex.Message);
        //                return null;
        //            } 
        //        }
        //        #endregion

        //        #region 求表中记录数
        //        public int IntCount(DataBaseVisitor dbVistor, string sqlCommand, SqlParameter[] param)
        //        {
        //            DataBase DB = new DataBase();
        //            if (false == DB.Open())
        //                DB.Open();
        //            SqlCommand cmd = new SqlCommand(dbVistor.ExecSql(sqlCommand), DB.m_sqlCon);
        //            if (param != null)
        //            {
        //                foreach (SqlParameter parameter in param)
        //                    cmd.Parameters.Add(parameter);
        //            }
        //            try
        //            {
        //                int count = (int)cmd.ExecuteScalar();
        //                return count;
        //            }
        //            catch (Exception ex)
        //            {
        //                throw new Exception(ex.Message);
        //                return 0;
        //            }
        //        }
        //#endregion
    }
}
