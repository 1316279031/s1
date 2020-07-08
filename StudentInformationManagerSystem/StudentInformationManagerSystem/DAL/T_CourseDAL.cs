﻿using StudentInformationManagerSystem.DAL.BaseClass;
using StudentInformationManagerSystem.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationManagerSystem.DAL
{
    public class T_CourseDAL
    {
        public List<T_CourseName> ExecuteListCourseName()
        {
            string t_sql = "select CourseID,CourseName from T_Course";
            SqlHelper helper = new SqlHelper();
            List<T_CourseName> res = null;
            using (SqlDataReader reader = helper.ExecuteReader(t_sql, CommandType.Text))
            {
                if (reader.HasRows)
                {
                    res = new List<T_CourseName>();
                    while (reader.Read())
                    {
                        T_CourseName cs = new T_CourseName();
                        cs.CourseID = reader.GetInt32(0);
                        cs.CourseName = reader.GetString(1);
                        res.Add(cs);
                    }
                }
            }
            return res;
        }
        public List<T_CourseName> ExecuteListCourseName(int curIndex,int dataLength,string courseName="")
        {
            string t_sql = "SelectCourseName";
            SqlParameter[] pars = new SqlParameter[] {
                new SqlParameter("@curIndex",SqlDbType.Int){Value=curIndex},
                new SqlParameter("@dataLength",SqlDbType.Int){Value=dataLength},
                new SqlParameter("@courseName",SqlDbType.VarChar){Value="%"+courseName+"%"},
            };
            SqlHelper helper = new SqlHelper();
            List<T_CourseName> res = null;
            using (SqlDataReader reader = helper.ExecuteReader(t_sql,CommandType.StoredProcedure, pars)) {
                if (reader.HasRows) {
                    res = new List<T_CourseName>();
                    while (reader.Read()) {
                        T_CourseName cs = new T_CourseName();
                        cs.CourseID = reader.GetInt32(0);
                        cs.CourseName = reader.GetString(1);
                        res.Add(cs);
                    }
                }
            }
            return res;
        }
        public List<T_Course> ExecuteT_Course(int curIndex,int dataLength,string courseName,string className,string teachName) {
            string t_sql = "SelectT_ClassCourse";
            SqlParameter[] pars = new SqlParameter[] {
                new SqlParameter("@curIndex",SqlDbType.Int){ Value=curIndex},
                new SqlParameter("@dataLength",SqlDbType.Int){ Value=dataLength},
                new SqlParameter("@courseName",SqlDbType.VarChar){ Value="%"+courseName+"%"},
                new SqlParameter("@className",SqlDbType.VarChar){ Value="%"+className+"%"},
                new SqlParameter("@teachName",SqlDbType.VarChar){ Value="%"+teachName+"%"}
            };
            SqlHelper helper = new SqlHelper();
            List<T_Course> res = null;
            using (SqlDataReader reader = helper.ExecuteReader(t_sql, CommandType.StoredProcedure, pars)) {
                if (reader.HasRows) {
                    res = new List<T_Course>();
                    while (reader.Read())
                    {
                        //select s3.CourseID,s3.ClassID,s3.ClassName,s3.CourseName,s3.TeacherName
                        T_Course course = new T_Course();
                        course.CourseID = reader.GetInt32(0);
                        course.classID = reader.GetInt32(1);
                        course.ClassName = reader.GetString(2);
                        course.CourseName = reader.GetString(3);
                        course.teachID = reader.GetInt32(4);
                        course.TeachName = reader.GetString(5);
                        res.Add(course);
                    }
                }
            }
            return res;
        }

        internal object ExecuteT_CourseFaction(int curIndex, int dataLength, string stuID, string stuName, string courseName, string teachName)
        {
            string t_sql = "SelectT_CourseFaction";
            SqlParameter[] pars = new SqlParameter[] {
                new SqlParameter("@curIndex",SqlDbType.Int){Value=curIndex},
                new SqlParameter("@dataLength",SqlDbType.Int){Value=dataLength},
                new SqlParameter("@stuID",SqlDbType.VarChar){Value="%"+stuID+"%"},
                new SqlParameter("@stuName",SqlDbType.VarChar){Value="%"+stuName+"%"},
                new SqlParameter("@courseName",SqlDbType.VarChar){Value="%"+courseName+"%"},
                new SqlParameter("@teachName",SqlDbType.VarChar){Value="%"+teachName+"%"}
            };
            SqlHelper sql = new SqlHelper();
            List<T_CourseFaction> factions = null;
            using (SqlDataReader reader = sql.ExecuteReader(t_sql, CommandType.StoredProcedure, pars)) {
                if (reader.HasRows)
                {
                    factions = new List<T_CourseFaction>();
                    while (reader.Read())
                    {
                        T_CourseFaction faction = new T_CourseFaction();
                        faction.ID = reader.GetInt32(0);
                        faction.StuID = reader.GetInt32(1);
                        faction.StuName = reader.GetString(2);
                        faction.CourseName = reader.GetString(3);
                        faction.TeacherName = reader.GetString(4);
                        faction.Faction = reader.IsDBNull(5)?0:float.Parse(reader.GetValue(5).ToString());
                        factions.Add(faction);
                    }
                }
            }
            return factions;
        }
        public object ExecuteScalar(string t_sql, CommandType cmdType, params SqlParameter[] pars) {
            SqlHelper sql = new SqlHelper();
            return sql.ExecuteScalar(t_sql, cmdType, pars);
        }

        public object ExecuteNonQuery(string t_sql, CommandType cmdType, params SqlParameter[] pars)
        {
            SqlHelper sql = new SqlHelper();
            return sql.ExecuteScalar(t_sql, cmdType, pars);
        }
        public List<T_InsertedFactionModel> ExecuteT_ClassSetUpCourseTeach(int classID)
        {
            string t_sql = "SelectClassSetUpCourse";
            SqlParameter par = new SqlParameter("@classID",SqlDbType.Int) { Value = classID };
            SqlHelper helper = new SqlHelper();
            List<T_InsertedFactionModel> res = null;
            using (SqlDataReader reader = helper.ExecuteReader(t_sql, CommandType.StoredProcedure, par))
            {
                if (reader.HasRows)
                {
                    res = new List<T_InsertedFactionModel>();
                    while (reader.Read())
                    {
                        //select s3.CourseID,s3.ClassID,s3.ClassName,s3.CourseName,s3.TeacherName
                        T_InsertedFactionModel course = new T_InsertedFactionModel();
                        course.CourseID = reader.GetInt32(0);
                        course.CourseName = reader.GetString(1);
                        course.TeacherID = reader.GetInt32(2);
                        course.TeacherName = reader.GetString(3);
                        res.Add(course);
                    }
                }
            }
            return res;
        }

    }
}
