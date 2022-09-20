using Common;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DBUtility
{
    public class DPHelper
    {
        private static string connStr = GetConnStr();
        public static string GetConnStr()
        {
            string Sql = new Encryptions().DESDecrypt(ConfigurationManager.ConnectionStrings["MSSQLCONN"].ToString(), "87506200", "87506200");
            return Sql;
        }
        //写数据库
        public static int WriteDB(string sql)
        {
            try
            {
                using (IDbConnection conn = new SqlConnection(connStr))
                {

                    return conn.Execute(sql);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int WriteDB(string sql, object obj)
        {
            try
            {
                using (IDbConnection conn = new SqlConnection(connStr))
                {

                    return conn.Execute(sql, obj);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //读数据库
        public static List<T> ReadDB<T>(string sql)
        {
            try
            {
                using (IDbConnection conn = new SqlConnection(connStr))
                {
                    return conn.Query<T>(sql).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<T> ReadDB<T>(string sql, object obj)
        {
            try
            {
                using (IDbConnection conn = new SqlConnection(connStr))
                {
                    return conn.Query<T>(sql, obj).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //读取单一结果
        public static object RedDBSingle(String sql, object obj)
        {
            try
            {
                using (IDbConnection conn = new SqlConnection(connStr))
                {
                    return conn.Query<object>(sql, obj).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static object RedDBSingle(String sql)
        {
            try
            {
                using (IDbConnection conn = new SqlConnection(connStr))
                {
                    return conn.Query<object>(sql).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
