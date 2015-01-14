<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Sagetta.login" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
<title>后台登录管理系统</title>
<style type="text/css">
html { overflow-x: hidden; overflow-y: auto; } 
body {font-family: "", Arial, sans-serif;font-size: 12px;line-height: 20px;color: #000000;margin: 0px;padding: 0px;border:0;background-color: #FFFFFF;}
ul,li,p,h1,h2,h3,h4,form,img,a {margin:0;padding:0;list-style-type: none;}
.margina{margin-left:auto;margin-right:auto;}
.btn {width:71px;height:23px;background-image: url(/loginImg/abtn_bg.gif);border:none;color:#0067CA;font-weight:bold;float:left;cursor:hand;text-align:center;font-size: 12px;}
.btn1 {border:none;height:19px;width:57px;background-image: url(/loginImg/sousuo.gif);cursor:pointer;background-color:#fff;}
.btn2 {border:1px #C5C5C5 solid;height:20px;line-height:18px;background-image: url(/loginImg/btn_bg2.gif);cursor:pointer;font-size:12px;background-color:#FFFFFF;}
#login {background:#0077C3 url(/loginImg/bg.gif) repeat-x center top;}
#login .top {height:194px;}
#login .conter {width:737px;height:304px;margin:0 auto;background:url(/loginImg/conter_bg.gif);}
#login .conter .input1 {background:url(/loginImg/input_bg.gif);width:165px;height:16px;border:none;padding:2px 4px 2px 4px;}
#login .conter .input2 {background:url(/loginImg/yzm_bg.gif);width:58px;height:16px;border:none;padding:2px 4px 2px 4px;}
#login .conter .table {margin:32px 0 0 428px;}
#login .conter .btn {background:url(/loginImg/btn_bg.gif);width:88px;height:24px;border:none;font-size:14px;line-height:24px;color:#000000;}
</style>
</head>
<body id="login">
<form runat="server">
<div class="top"></div>
<div class="conter">
<table width="233" height="143" border="0" cellpadding="0" cellspacing="0" class="table">
  <tr>
    <td width="54">帐　号：</td>
    <td width="179"><input type="text" name="txtUsername" id="txtUsername" runat="server" class="input1" /></td>
  </tr>
  <tr>
    <td>密　码：</td>
    <td><input type="text" name="txtPassword" id="txtPassword" runat="server" class="input1" /></td>
  </tr>
  <tr>
    <td colspan="2"><table width="100%" border="0" cellpadding="0" cellspacing="0">
      <tr>
        <td width="58%" align="center">
         <asp:Button ID="btnLogin" runat="server" Text="登  录" CssClass="btn" onclick="btnLogin_Click" OnClientClick="return chkLogin();"/>
        </td>
        <td width="42%" align="center"><input name="reset" type="reset" value="取  消" class="btn" runat="server" /></td>
      </tr>
    </table></td>
    </tr>
</table>
</div>
</form>
</body>
</html>
<script type="text/javascript">
    function chkLogin() {
        var name = document.getElementById("txtUsername").value;
        if (name == null || name.length == 0) {
            alert("请输入用户名!");
            document.getElementById("txtUsername").focus();
            return false;
        }
        var pwd = document.getElementById("txtPassword").value;
        if (pwd == null || pwd.length == 0) {
            alert("请输入密码!");
            document.getElementById("txtPassword").focus();
            return false;
        }
        return true;
    }
</script>