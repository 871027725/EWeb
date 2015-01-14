<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="top.aspx.cs" Inherits="EWeb.Admin.top" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
    <title>top</title>
    <link href="common/style.css" rel="stylesheet" type="text/css" />
</head>
<body id="top">
    <div class="top_bg">
        <div class="logo"></div>
        <div class="top_line"><span class="right"><a href="../product/product_use.aspx" target="_blank" title="访问首页">跳转首页</a> | <a href="updatePwd.aspx" target="mainFrame">修改密码</a> | <a href="logout.aspx" target="_top">退出</a></span><%=sessionEmp.Username%>&nbsp;&nbsp;欢迎登录   <span style="color:Red;">尚佳达中文版后台系统</span>  您上一次登陆时间是<%=sessionEmp.Lastlogin%></div>
     </div>
</body>
</html>