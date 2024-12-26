using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using UDI_AgentUI.Handel.DeviceHandel;


namespace UDI_AgentUI.Service
{
    public class DBConn : IDBConn
    {

        public DataSet SqlQuery(string strDB, string strSql, Hashtable prm)
        {
            DataSet dataSet = new DataSet();
            DeviceHandel deviceContext = new();
            string connectionStr = ConfigurationManager.ConnectionStrings[strDB].ConnectionString;
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionStr))
                using (SqlCommand sqlCommand = new SqlCommand())
                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter())
                {
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = strSql;

                    foreach (DictionaryEntry item in prm)
                    {
                        string prmName = item.Key.ToString();
                        string prmType = item.Value.GetType().Name.ToUpper();
                        SqlParameter sqlParameter;


                        switch (prmType)
                        {
                            case "BYTE[]":
                                sqlParameter = new SqlParameter(prmName, SqlDbType.Binary);
                                break;
                            case "DATATIME":
                                sqlParameter = new SqlParameter(prmName, SqlDbType.DateTime);
                                break;
                            default:
                                sqlParameter = new SqlParameter(prmName, SqlDbType.VarChar);
                                break;
                        }

                        sqlParameter.Value = item.Value;
                        sqlCommand.Parameters.Add(sqlParameter);
                    }

                    sqlConnection.Open();
                    sqlDataAdapter.SelectCommand = sqlCommand;
                    sqlDataAdapter.Fill(dataSet);
                }
            }
            catch (Exception ex)
            {

                deviceContext.Agent_WriteLog(ex.Message);
            }

            return dataSet;
        }



        public async Task<DataSet> SqlSp(string strDB, string spName, Hashtable prm)
        {
            DataSet dataSet = new DataSet();
            DeviceHandel deviceContext = new();
            string connectionStr = ConfigurationManager.ConnectionStrings[strDB].ConnectionString;

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionStr))
                using (SqlCommand sqlCommand = new SqlCommand(spName, sqlConnection))
                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter())
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    foreach (DictionaryEntry item in prm)
                    {
                        string prmName = item.Key.ToString();
                        sqlCommand.Parameters.Add(prmName, SqlDbType.VarChar);
                        sqlCommand.Parameters[prmName].Value = item.Value;
                    }

                    await sqlConnection.OpenAsync();
                    sqlDataAdapter.SelectCommand = sqlCommand;

                    // 异步填充 DataSet
                    await Task.Run(() => sqlDataAdapter.Fill(dataSet));
                }
            }
            catch (Exception ex)
            {
                 deviceContext.Agent_WriteLog(ex.Message);
            }

            return dataSet;
        }

        public bool SqlUpDate(string strDB, string strSql, Hashtable prm)
        {
            bool result = false;
            DeviceHandel deviceContext = new();
            string connectionStr = ConfigurationManager.ConnectionStrings["UDI"].ConnectionString;

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionStr))
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = strSql;
                    SqlParameter sqlParameter;
                    foreach (DictionaryEntry item in prm)
                    {
                        string prmName = item.Key.ToString();
                        string prmType = item.Value.GetType().Name.ToUpper();


                        switch (prmType)
                        {
                            case "BYTE[]":
                                sqlParameter = new SqlParameter(prmName, SqlDbType.Binary);
                                break;
                            case "DATETIME":
                                sqlParameter = new SqlParameter(prmName, SqlDbType.DateTime);
                                break;
                            default:
                                sqlParameter = new SqlParameter(prmName, SqlDbType.VarChar);
                                break;
                        }
                        sqlParameter.Value = item.Value;
                        sqlCommand.Parameters.Add(sqlParameter);
                    }
                    sqlConnection.Open();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                result = false;
                deviceContext.Agent_WriteLog(ex.Message);
            }


            return result;

        }
    }
}
