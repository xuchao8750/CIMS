using System;
using System.Collections.Generic;
using System.Reflection;

namespace Common
{
    //使用反射获取类的主键，属性，用以拼接SQL语句
    //INSERT TO
    //SELECT 
    //UPDATE
    //DELETE

    //主键
    //select 当中必要属性
    //insert 当中必要属性 和@符合参数
    //update 当中的 列名=@值
    public class MyReflector
    {
        public static string GetPK(Type type)
        {
            //获取所有属性
            PropertyInfo[] properties = type.GetProperties();
            string pk = "";
            foreach (PropertyInfo property in properties)
            {
                foreach (Attribute attribute in property.GetCustomAttributes())
                {
                    if (attribute.ToString().Contains("PKAttribute"))//获取主键
                    {
                        pk = property.Name;
                    }
                }
            }
            return pk;
        }

        public static string GetSelectProp(Type type)
        {
            //获取所有属性
            PropertyInfo[] properties = type.GetProperties();
            List<string> listProp = new List<string>();
            foreach (PropertyInfo property in properties)
            {
                listProp.Add(property.Name);
            }
            return string.Join(",", listProp);
        }
        public static string GetSelectProp(Type type, string[] needToRemove)
        {
            //获取所有属性
            PropertyInfo[] properties = type.GetProperties();
            List<string> listProp = new List<string>();
            foreach (PropertyInfo property in properties)
            {
                listProp.Add(property.Name);
            }
            if (needToRemove != null && needToRemove.Length > 0)
            {
                foreach (string field in needToRemove)
                {
                    listProp.Remove(field);
                }
            }
            return string.Join(",", listProp);
        }

        public static string GetUpdateProp(Type type)
        {
            //获取所有属性
            PropertyInfo[] properties = type.GetProperties();
            List<string> listProp = new List<string>();
            foreach (PropertyInfo property in properties)
            {
                listProp.Add(property.Name + "=@" + property.Name);
            }
            return string.Join(",", listProp);
        }

        public static string GetUpdateProp(Type type, string[] needToRemove)
        {
            PropertyInfo[] properties = type.GetProperties();
            List<string> listProp = new List<string>();
            foreach (PropertyInfo propertyInfo in properties)
            {
                listProp.Add(propertyInfo.Name);
            }
            foreach (string str in needToRemove)
            {
                listProp.Remove(str);
            }
            List<string> listStr = new List<string>();
            foreach (string str in listProp)
            {
                listStr.Add(str + "=@" + str);
            }
            return string.Join(",", listStr);
        }

        public static List<string> GetInsterProp(Type type)
        {
            PropertyInfo[] properties = type.GetProperties();
            List<string> insterStr1 = new List<string>();
            List<string> insterStr2 = new List<string>();
            foreach (PropertyInfo propertyInfo in properties)
            {
                insterStr1.Add(propertyInfo.Name);
                insterStr2.Add("@" + propertyInfo.Name);
            }
            string s1 = string.Join(",", insterStr1);
            string s2 = string.Join(",", insterStr2);
            List<string> listStr = new List<string>();
            listStr.Add(s1);
            listStr.Add(s2);
            return listStr;
        }

        public static List<string> GetInsterProp(Type type, string[] needToRemove)
        {
            //获取所有属性
            PropertyInfo[] properties = type.GetProperties();
            List<string> listProp = new List<string>();
            foreach (PropertyInfo propertyInfo in properties)
            {
                listProp.Add(propertyInfo.Name);
            }
            if (needToRemove != null && needToRemove.Length > 0)
            {
                foreach (string str in needToRemove)
                {
                    listProp.Remove(str);
                }
            }
            List<string> insterStr1 = new List<string>();
            List<string> insterStr2 = new List<string>();
            foreach (string prop in listProp)
            {
                insterStr1.Add(prop);
                insterStr2.Add("@" + prop);
            }
            List<string> listStr = new List<string>();
            string s1 = string.Join(",", insterStr1);
            string s2 = string.Join(",", insterStr2);
            listStr.Add(s1);
            listStr.Add(s2);
            return listStr;
        }
    }
}
