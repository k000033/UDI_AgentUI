using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDI_AgentUI.Service
{
    internal interface IDBConn
    {
        public DataSet SqlQuery(string strDB, string strSql, Hashtable prm);
        public bool SqlUpDate(string strDB, string strSql, Hashtable prm);

        public Task<DataSet> SqlSp(string strDB, string spName, Hashtable prm);
    }
}
