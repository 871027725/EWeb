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
<h1>���Ʋ˵�</h1>
</div>

<dl>
<dt onclick="javascript:show(this);">����Ա����</dt>
<dd><a href="employee/list.aspx" target="mainFrame">�˺Ź���</a></dd>
<dd><a href="employeeModule/list.aspx" target="mainFrame">�Զ���ģ��</a></dd>
</dl>


<dl>
<dt onclick="javascript:show(this);">�������ع���</dt>
<dd><a href="down/DownTypeList.aspx" target="mainFrame">��������</a></dd>
<dd><a href="down/list.aspx" target="mainFrame">��������</a></dd>
</dl>


<dl>
<dt onclick="javascript:show(this);">��Ʒ������</dt>
<dd><a href="productType/list.aspx" target="mainFrame">��Ʒ����б�</a></dd>
<dd><a href="productType/type_img_list.aspx" target="mainFrame">���ͼƬ</a></dd>
</dl>

<dl>
<dt onclick="javascript:show(this);">��Ʒ����</dt>
<dd><a href="product/product_list.aspx" target="mainFrame">��Ʒ�б�</a></dd>
<dd><a href="product/product_list_img.aspx" target="mainFrame">��ƷͼƬ</a></dd>
</dl>

<dl>
<dt onclick="javascript:show(this);">����ģ�����</dt>
<dd><a href="pageUrl/list.aspx" target="mainFrame">����·������</a></dd>
<dd><a href="navmodule/type.aspx" target="mainFrame">����ģ������</a></dd>
<dd><a href="navmodule/list.aspx" target="mainFrame">��������</a></dd>
<dd><a href="navmodule/siteDataImg.aspx" target="mainFrame">����ͼƬ����</a></dd>
</dl>

<dl>
<dt onclick="javascript:show(this);">�������ݹ���</dt>
<dd><a href="company/list.aspx" target="mainFrame">��������</a></dd>
</dl>
</body>
</html>
