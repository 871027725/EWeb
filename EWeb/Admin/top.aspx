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
        <div class="top_line"><span class="right"><a href="../product/product_use.aspx" target="_blank" title="������ҳ">��ת��ҳ</a> | <a href="updatePwd.aspx" target="mainFrame">�޸�����</a> | <a href="logout.aspx" target="_top">�˳�</a></span><%=sessionEmp.Username%>&nbsp;&nbsp;��ӭ��¼   <span style="color:Red;">�мѴ����İ��̨ϵͳ</span>  ����һ�ε�½ʱ����<%=sessionEmp.Lastlogin%></div>
     </div>
</body>
</html>