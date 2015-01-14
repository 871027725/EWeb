<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="updatePwd.aspx.cs" Inherits="EWeb.Admin.updatePwd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
    <link href="../common/style.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="../js/jquery-1.7.1.min.js"></script>
</head>
<body runat="server">
    <form id="form1" runat="server">
     <input type="hidden" runat="server" name="txtMid" id="txtMid" value="0" />
    <table width="100%" border="0" cellspacing="0" cellpadding="0" class="tablethree" style=" line-height:40px;">
        <tr>
            <td width="10%">
                <strong>原始密码</strong>
            </td>
            <td width="90%">
                <input name="txtPwd" id="txtPwd" runat="server" type="text" size="40" />
            </td>
        </tr>
        <tr>
            <td>
                <strong>新密码</strong>
            </td>
            <td>
                <input name="txtNewPwd" id="txtNewPwd" runat="server" type="text" size="40" />
            </td>
        </tr>       
         <tr>
            <td>
                <strong>确认密码</strong>
            </td>
            <td>
               <input type="text" runat="server" name="txtConfirmPwd" id="txtConfirmPwd" size="40"/>&nbsp;&nbsp;
            </td>
        </tr>

        <tr>
            <td colspan="2">
                <asp:Button ID="btnSave" runat="server" Text="提 交" CssClass="btn2" onclick="btnSave_Click"/>&nbsp;&nbsp;
                <input name="reset" type="reset" class="btn2" value="取 消" onclick="javascript:window.location.reload();" />
            </td>
        </tr>
    </table>
    </form>
</body>
</html>

