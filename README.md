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
   ## 登录
1. **增删改->使用存储过程**
2. **连接查询->使用存储过程**
3. **账号验证正则规则:**
   - *账号必须为数字字符*
   - *账号必须在10-15（包含10,15）之间*
   - **^ [0-9]{10,15}$**
4. **密码必须包含数字+字符**
    ## 主界面
#### 导航菜单
1. **信息管理**
   - **学生信息管理**
     - *学信息基本信息管理*
     - *学生详细信息管理*
     - *学生分数管理*
   - **班级信息管理**
     - *班级信息基本模块*
     - *班级相关开课分数*
   - **课程信息管理**
     - *新增课程管理*
   - **教师信息管理**
2. **权限管理**
3. **学院管理**
4. **账户管理**
#### 问题解决
1. **因控件菜单选项NavigationMenuItem类型并未设置点击事件**
   ###### 解决方法
   - **创建ExpandNavigationMenuItem类型继承NavigationMenuItem**
   - **定义Click事件字段**
   - **触发事件方法**
    ```/// <summary>
    /// 扩展导航菜单控件Click事件
    /// </summary>
    public class ExpandNavigationMenuItem: NavigationMenuItem
    {
        /// <summary>
        /// 扩展事件
        /// </summary>
        public event EventHandler Click;
        
        /// <summary>
        /// 触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void Start(object sender,EventArgs args) {
            Click(sender,args);
        }
    }
2. **垂直导航栏**
   - **使用TreeViewEx控件**
   - **为每个具有功能模块的跳转项添加Tag标签**
   - **使用AfterSelect事件，获取当前点击的树上的节点**
    ## 信息管理模块
    ### 学生信息管理
    #### 导航栏设置
    - **查询信息,更新信息，插入信息，删除信息，上一页，下一页**
      - *查询信息:查询所有、模糊查询*
    - **查询输出信息一律按照降序给出，因为最新加入的数据，越是容易查看**
    - **垂直树:学院->班级->学生**
    ### 代码注释
    - **curIndex:当前数据页**
    - **classID=-1:表示加载所有学生**
    - **使用子窗体完成数据的更新**
#存储过程
+ **分页**
  - *主要功能*
    -  *连接查询T_StudentBasicInfomation,T_Class，T_College*
    -  学生基本信息+学生所在班级+学生所在学院
    -  次功能主要用户在用户登录，即加载该部分内容
  >基本关键字使用
  >>使用子查询，得到一个可进行分页的ID
  >>使用Row_Number Over(order by ………………)
  >>>存储过程名为:SelectStudent_Pagiation
  该存储过程如果传递的classid值为-1；即表示分页查询所有数据
如果传入的classsid!=-1即表示根据classid进行分页查询

+ **StudentBasicInformationInsert 插入学生基本信息的存储过程**
+ **使用事务，当返回1时表示插入成功，当返回0时表示插入失败**

+ **ModifyIntoStudentBasicInformation：更新学生基本信息的存储过程**

+ **DeleteIntoStudentBasicInformation删除学生基本信息的存储过程**




# 任务完成情况
##### 1. **数据库(学院,班级,学生)数据已录入完毕**
##### 2. **数据库(教师表,课程表)数据已录入完毕**
##### 3. **数据库(成绩表)数据已录入完毕**

# 美化控件使用方法
### 表单控件的验证
1. **设置自定义的正则表达式验证**
>    `verCon1.SetVerificationErrorMsg(绑定控件, 提示信息);`
>    `verCon1.SetVerificationRequired(绑定控件, true);`
>    `verCon1.SetVerificationModel(绑定控件, VerificationModel.Custom(使用用户自定义验证模式));`
>    `verCon1.SetVerificationCustomRegex(绑定控件, 正则表达式);`