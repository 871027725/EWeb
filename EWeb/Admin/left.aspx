<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="left.aspx.cs" Inherits="EWeb.Admin.left" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
<link href="common/style.css" rel="stylesheet" type="text/css" />
<script language="JavaScript" type="text/javascript">

    window.onload = function () { showdd(0); }

    function showdd(mydl) {
        var alldl = document.getElementsByTagName("dl");
        var thedt = alldl[mydl].getElementsByTagName("dt");
        thedt[0].className = "dtjian";
        var thedd = alldl[mydl].getElementsByTagName("dd");
        for (ii = 0; ii < thedd.length; ii++) {
            thedd[ii].style.display = "block";
        }
    }

    function hidd() {
        var alldd = document.getElementsByTagName("dd");
        for (i = 0; i < alldd.length; i++) {
            alldd[i].style.display = "none";
        }
    }

    function show(strtype) {
        if (strtype.className == "dtjian") {
            strtype.className = ""; hidd();
        }else {
            hidd(); 
            var alldt = document.getElementsByTagName("dt");
            for (i = 0; i < alldt.length; i++) {
                alldt[i].className = "";
            }
            strtype.className = "dtjian";

            for (i = 0; i < alldt.length; i++) {

                if (strtype == alldt[i]) { showdd(i); } 
            }
        }
    }
</script>
</head>

<body id="left">
<div class="ttitle">
<h1>控制菜单</h1>
</div>

<dl>
<dt onclick="javascript:show(this);">管理员管理</dt>
<dd><a href="employee/list.aspx" target="mainFrame">账号管理</a></dd>
<dd><a href="employeeModule/list.aspx" target="mainFrame">自定义模块</a></dd>
</dl>


<dl>
<dt onclick="javascript:show(this);">资料下载管理</dt>
<dd><a href="down/DownTypeList.aspx" target="mainFrame">下载类型</a></dd>
<dd><a href="down/list.aspx" target="mainFrame">资料下载</a></dd>
</dl>


<dl>
<dt onclick="javascript:show(this);">产品类别管理</dt>
<dd><a href="productType/list.aspx" target="mainFrame">产品类别列表</a></dd>
<dd><a href="productType/type_img_list.aspx" target="mainFrame">类别图片</a></dd>
</dl>

<dl>
<dt onclick="javascript:show(this);">产品管理</dt>
<dd><a href="product/product_list.aspx" target="mainFrame">产品列表</a></dd>
<dd><a href="product/product_list_img.aspx" target="mainFrame">产品图片</a></dd>
</dl>

<dl>
<dt onclick="javascript:show(this);">导航模块管理</dt>
<dd><a href="pageUrl/list.aspx" target="mainFrame">访问路径配置</a></dd>
<dd><a href="navmodule/type.aspx" target="mainFrame">导航模块配置</a></dd>
<dd><a href="navmodule/list.aspx" target="mainFrame">导航数据</a></dd>
<dd><a href="navmodule/siteDataImg.aspx" target="mainFrame">导航图片数据</a></dd>
</dl>

<dl>
<dt onclick="javascript:show(this);">基础数据管理</dt>
<dd><a href="company/list.aspx" target="mainFrame">基础数据</a></dd>
</dl>
</body>
</html>
