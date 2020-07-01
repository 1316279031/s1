﻿using StudentInformationManagerSystem.DAL.BaseClass;
using StudentInformationManagerSystem.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationManagerSystem
{
    public class T_StudentDal
    {
        public List<T_Student> LoadStudents(int curIndex,int dataLength,int classid) {
            string t_sql = "SelectStudent_Pagiation";
            SqlParameter[] pars = new SqlParameter[] {
                new SqlParameter("@curIndex",System.Data.SqlDbType.Int){Value=curIndex },
                new SqlParameter("@pagiation",System.Data.SqlDbType.Int){ Value=dataLength},
                new SqlParameter("@classid",System.Data.SqlDbType.Int){ Value=classid},
            };
            SqlHelper helper = new SqlHelper();
            List<T_Student> stu = null;
            using (SqlDataReader reader = helper.ExecuteReader(t_sql,System.Data.CommandType.StoredProcedure, pars)) {
                if (reader.HasRows) {
                    stu = new List<T_Student>();
                    while (reader.Read()){
                        T_Student temp= new T_Student();
                        temp.StuID = reader.GetInt32(0);
                        temp.StuName = reader.GetString(1);
                        temp.StuBirthday = reader.GetDateTime(2).ToString( "yyyy-MM-dd");
                        temp.StuSex_filed = reader.GetBoolean(3);
                        temp.ClassID = reader.GetInt32(4);
                        stu.Add(temp);
                    }
                }
            }
            return stu;
        }
        public List<T_Student> LoadStudents(string t_sql, CommandType cmdType, params SqlParameter[] pars) {
            List<T_Student> stu = null;
            using (SqlDataReader reader = new SqlHelper().ExecuteReader(t_sql, cmdType, pars)) {
                if (reader.HasRows) {
                    stu = new List<T_Student>();
                    while (reader.Read()) {
                        T_Student temp = new T_Student();
                        temp.StuID = reader.GetInt32(0);
                        temp.StuName = reader.GetString(1);
                        temp.StuBirthday = reader.GetDateTime(2).ToString("yyyy-MM-dd");
                        temp.StuSex_filed = reader.GetBoolean(3);
                        temp.ClassID = reader.GetInt32(4);
                        stu.Add(temp);
                    }
                }
            }
            return stu;
        }
    }
}
