<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="edit.aspx.cs" Inherits="EWeb.Admin.employee.edit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
    <title>�˺ű༭</title>
    <link href="../common/style.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="../js/jquery-1.7.1.min.js"></script>
    <script type="text/javascript"  src="../js/common.js"></script>
    <script type="text/javascript"  src="../js/SelectAll.js"></script>
</head>
<body runat="server">
    <form id="form1" runat="server">
        <input type="hidden" runat="server" name="txtEid" id="txtEid" value="0" />
        <table width="100%" border="0" cellspacing="0" cellpadding="0" class="tablethree">
            <tr>
                <td width="10%" style="text-align:center;">
                    <strong>�� ��</strong>
                </td>
                <td width="90%">
                    <input id="txtUserName" name="txtUserName" type="text" size="30" runat="server" />
                </td>
            </tr>
            <tr>
                <td style="text-align:center;">
                    <strong>�� ��</strong>
                </td>
                <td>
                    <input id="txtPassword" name="txtPassword" type="text" size="30" runat="server"/>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:Button ID="empBtn" runat="server" CssClass="btn2" Text=" �� �� " 
                        onclick="empBtn_Click" OnClientClick="return validateAdd();" />&nbsp;&nbsp;
                    <input name="reset" type="reset" class="btn2" value="ȡ ��" onclick="javascript:window.location.reload();" />
                &nbsp;&nbsp; <input name="reset" type="reset" class="btn2" value="�� ��" onclick="javascript:window.history.back()" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
<script type="text/javascript" language="javascript">
    function validateAdd() {
        var uname = $("#txtUserName").val();
        var pwd = $("#txtPassword").val();
        if (uname == null || uname.length == 0) {
            alert("�������˺�!");
            $("#txtUserName").focus();
            return false;
        }
        if (pwd == null || pwd.length == 0) {
            alert("����������!");
            $("#txtPassword").focus();
            return false;
        }
        return true;
    }

</script>
