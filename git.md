# git 指令
## 初始化本地目录仓库
``` git
    //创建项目    
    git init
    git user.name ''
    git user.email ''
```
### git推送流程是
- 1. 本地目录(实际文件)
- 2. 暂存区 (使用 git add '') 暂时提交带暂存区
- 3. Head 提交结果(对暂存区最后一次提交的修改，进行提交)
- 4. 