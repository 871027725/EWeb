<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="main.aspx.cs" Inherits="EWeb.Admin.main" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Frameset//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-frameset.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
<title>杭州尚家达后台系统首页</title>
</head>
<frameset rows="97,*" cols="*" frameborder="no" border="0" framespacing="0">
  <frame src="top.aspx" name="topFrame" scrolling="No" noresize="noresize" id="topFrame" />
  <frameset rows="*" cols="160,10,*" framespacing="0" frameborder="no" border="0" id="leftmenu">
      <frame src="left.aspx" name="leftFrame" scrolling="No" noresize="noresize" id="leftFrame" />
      <frame src="btn.aspx" name="btnFrame" scrolling="No" noresize="noresize" id="btnFrame" />
      <frame src="right.aspx" name="mainFrame" scrolling="auto" noresize="noresize" id="mainFrame" />
  </frameset>
</frameset>
<noframes><body>
</body>
</noframes></html>

