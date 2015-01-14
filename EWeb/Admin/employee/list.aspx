<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="list.aspx.cs" Inherits="EWeb.Admin.employee.list" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
    <title>管理员账号</title>
    <link href="../common/style.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="../js/jquery-1.7.1.min.js"></script>
    <script type="text/javascript"  src="../js/common.js"></script>
    <script type="text/javascript"  src="../js/SelectAll.js"></script>
</head>
<body id="right" class="main1" runat="server">
    <div class="ttitle">
        <h1>【帐号管理】</h1>
    </div>
    <form method="get" id="searchForm" name="searchForm" action="">
        <div class="linebox botm01">
            <strong>帐号检索</strong>：&nbsp;
            <input name="username" type="text" value="<%=username%>" />
            <input type="submit" value="" class="btn1" />
        </div>
    </form>
    <form id="list_form" runat="server">
     <div class="botm01">
            <input type="button" class="btn2" value="添加管理员帐户" onclick="javascript:window.location.href='edit.aspx'" />
            <asp:LinkButton runat="server" ID="btnDel"  OnClientClick="return CheckSelect();"  onclick="btnDel_Click">多选删除</asp:LinkButton>
     </div>
    <table width="100%" border="0" cellpadding="0" cellspacing="1" bgcolor="#BBC0C6" class="tableone botm01">
        <tr class="title">
            <td width="3%"><input type="checkbox" name="chkAll" id="chkAll" onclick="OperateSelect(this)" /></td>
            <td width="10%">账 号</td>
            <td width="13%">密 码</td>
            <td width="3%">登陆次数</td>
            <td width="5%">创建时间</td>
            <td width="5%">状态</td>
            <td width="5%">最后登录时间</td>
            <td width="3%">类型</td>
            <td width="3%">操作</td>
        </tr>
        <%
            if ( dt != null && dt.Rows.Count > 0 )
            {
                Model.ModEmployee emps = (Model.ModEmployee)Session[Tools.SessionUtil.SessionKey];
                foreach(System.Data.DataRow drs in dt.Rows){
         %>
        <tr>
            <td align="center"><%if(emps.Eid != Convert.ToInt32(drs["eid"])){ %><input type="checkbox" name="checkboxid" id="id" value="<%=drs["eid"]%>" /><%} %></td>
            <td><a href="edit.aspx?eid=<%=drs["eid"]%>" title="编辑"><%=drs["username"]%></a></td>
            <td><%=GetName(drs["password"].ToString())%></td>
            <td align="center"><%=drs["logincount"]%></td>
            <td align="center"><%=drs["createtime"]%></td>
            <td align="center"><%=drs["status"]%></td>
            <td align="center"><%=DateTime.Parse(drs["lastLogin"].ToString()).ToShortDateString().ToString()%></td>
            <td align="center"><%=drs["type"]%></td>
            <td align="center"><a href="edit.aspx?eid=<%=drs["eid"]%>" title="编辑"><img src="../images/left_menu_bg4.gif" /></a></td>
        </tr>
        <%} }%>
    </table>
    <div class="linebox botm01">
        <webdiyer:AspNetPager ID="AspNetPager1" runat="server" AlwaysShow="True" FirstPageText="首页"
            Height="24px" LastPageText="尾页" NextPageText="下一页" NumericButtonCount="7" 
            PrevPageText="上一页" UrlPaging="True" CssClass="paginator"
            CurrentPageButtonClass="cpb" CustomInfoSectionWidth="10%" 
            ShowPageIndexBox="Auto" CurrentPageButtonPosition="Center" 
            CurrentPageButtonTextFormatString="{0}" 
            PageIndexBoxType="TextBox" SubmitButtonText="Go"  
            CustomInfoHTML="共%PageCount%页，当前为第%CurrentPageIndex%页" 
            ShowCustomInfoSection="Never"  >
        </webdiyer:AspNetPager>
    </div>
    </form>
</body>
</html>
<script type="text/javascript">
    function OperateSelect(obj) {
        SelectAll(obj.checked);
    }
</script>
