using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dal
{
    //抽象访问类
    public abstract class DataBaseVisitor
    {
        //获得sql命令对应的sql语句
        abstract public string ExecSql(string sqlCommand);
    }
}
