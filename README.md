#学生信息管理系统
+ **利用插件美化**
+ **利用正则表达式，过滤敏感词和验证**
+ *使用内存机制暂存验证码(暂不考虑多线程重置验证码)*
+ **必须弄清楚下载数据库的设计思路**

+ **登录完毕后限制用户可已使用的功能**
+ **如果是以管理员身份登录，可以修改已存在账户人员的权限级别**
1.  **级别**
    * 1:具有所有操作权限
    * 2:具有插入删除修查询权限
    * 3:具有查询权限
#数据库设计
+ **用户表(ID,PWD,Authoration)**
  - *用户名，密码，权限级别*
+ **学生详细表(StuID,IDCard,Phone,Address)**
  - *学号，身份证,手机号，住址*
+ **学生基本信息表(StuID,Name,Birthday,Sex,ClassID,CollegeID)**
  - *学号，姓名，出生日期，性别，班级ID，学院ID* 
+ **班级(ClassID,ClassName,CollegeID)**
  - *班级号，班级名，学院ID*
+ **学院(CollegeID,CollegeName,ShortName)**
  - *学院号,学院名称,短名称*
+ **教师表(TeacherID,TeacherName,Sex,BirthDay)**
  - *教师ID，教师名，性别，年龄*
+ **课程(CourseID,CourseName,CollegeID,ClassID,TeachID)**
  - *课程ID，课程名，学院ID，班级ID，教师ID*
  - 因每个班可能相同的课程，但不是同一位老师
+ **成绩(StuID,CourseID,Grade)**
  - *学号,课程号,成绩*
# 程序设计
1. **增删改->使用存储过程**
2. **连接查询->使用存储过程**




#存储过程
+ **分页**
  - *主要功能*
    -  *连接查询T_StudentBasicInfomation,T_Class，T_College*
    -  学生基本信息+学生所在班级+学生所在学院
    -  次功能主要用户在用户登录，即加载该部分内容
  >基本关键字使用
  >>使用子查询，得到一个可进行分页的ID
  >>使用Row_Number Over(order by ………………)








# 任务完成情况
##### 1. **数据库(学院,班级,学生)数据已录入完毕**
##### 2. **数据库(教师表,课程表)数据已录入完毕**
##### 3. **数据库(成绩表)数据已录入完毕**
