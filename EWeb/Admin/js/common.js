/****************************** 通用js ******************************/
$(function () {
    var node = $(".title").nextAll("tr");
    $.each(node, function () {
        var $this = $(this);
        $this.hover(function () {
            $this.find("td").css({ "background-color": "#DEE8F4", "cursor": "pointer" });
        }, function () {
            $this.find("td").css("background-color", "");
        });
    });
});




/*文本编辑器通用提取*/

/**
* a 输入框对象   'textarea[name="txtContent"]'
* b 是否支持图片上传
* w 初始化宽度
* h 初始化高度
* u 填写URL ,可以不填  
* r 是否支持拉伸 0 否  1 是
*/
function show_kindeditor(a, b, w, h,u,r) {
    var editor;
    u = u || u != "" ? u : "";
    r = r || r != "" ? r : 0;
    KindEditor.ready(function (K) {
        editor = K.create(a, {
            uploadJson: u,
            width: w,
            height: h,
            resizeType: r,
            allowPreviewEmoticons: true,
            allowImageUpload: b,
            themeType: 'simple',
            items: [
				'source', 'fontname', 'fontsize', '|', 'forecolor', 'hilitecolor', 'bold', 'italic', 'underline',
				'removeformat', '|', 'justifyleft', 'justifycenter', 'justifyright', 'insertorderedlist',
				'insertunorderedlist', '|', 'image', 'link', '|', 'unlink', '|', 'table', 'baidumap']
        });
    });
}

