<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="btn.aspx.cs" Inherits="EWeb.Admin.btn" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
<title>�ޱ����ĵ�</title>
<link href="common/style.css" rel="stylesheet" type="text/css" />
</head>

<body id="btnm">
<script type="text/javascript" language="javascript">
<!--
    function ExpandContents(controller) {
        mainFrame = parent.document.getElementById("leftmenu");
        if (mainFrame.cols == "160,10,*") {
            //�Ѿ�չ��������֮������������ָʾ
            mainFrame.cols = "0,10,*";
            // controller.src = "controller_expand.gif";
            controller.title = "չ��";
            controller.className = "link2";
        }
        else {
            //�Ѿ�������չ��֮������������ָʾ
            mainFrame.cols = "160,10,*";
            // controller.src = "controller_collapse.gif";
            controller.title = "�۵�";
            controller.className = "link1";
        }
    }
-->
</script>
<div id="middle"><a href="#" title="�۵�" id="controller" onclick="javascript:ExpandContents(this);" class="link1"></a></div>
</body>
</html>