<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="btn.aspx.cs" Inherits="EWeb.Admin.btn" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
<title>无标题文档</title>
<link href="common/style.css" rel="stylesheet" type="text/css" />
</head>

<body id="btnm">
<script type="text/javascript" language="javascript">
<!--
    function ExpandContents(controller) {
        mainFrame = parent.document.getElementById("leftmenu");
        if (mainFrame.cols == "160,10,*") {
            //已经展开，收缩之，并更换控制指示
            mainFrame.cols = "0,10,*";
            // controller.src = "controller_expand.gif";
            controller.title = "展开";
            controller.className = "link2";
        }
        else {
            //已经收缩，展开之，并更换控制指示
            mainFrame.cols = "160,10,*";
            // controller.src = "controller_collapse.gif";
            controller.title = "折叠";
            controller.className = "link1";
        }
    }
-->
</script>
<div id="middle"><a href="#" title="折叠" id="controller" onclick="javascript:ExpandContents(this);" class="link1"></a></div>
</body>
</html>
