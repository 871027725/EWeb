using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
namespace Tools
{
    /// <summary>
    /// 图片上传 返回json 
    /// ywx
    /// </summary>
    public class Upload
    {
        //设置可上传图片数量
        public const int ImgCount = 8;

        private static Object _obj = new Object();
        /// <summary>
        /// 图片h
        /// </summary>
        /// <param name="postFile">上传文件对象</param>
        /// <param name="imgUrl">原始图片路径</param>
        /// <param name="lan">语言</param>
        /// <param name="dirPath">上传文件</param>
        /// <returns></returns>
        public static string uploadImg(System.Web.UI.WebControls.FileUpload postFile, string lan, string dirPath,string imgUrl)
        {
            lock (_obj) {
                string returnStr = "";
                if (!postFile.HasFile)
                {
                    returnStr = "{\"status\":\"2\",\"msg\":\"没有选择图片!\"}";
                }
                else
                {
                    //文件扩展名
                    string fileExt = System.IO.Path.GetExtension(postFile.PostedFile.FileName).ToString().ToLower();
                    //文件大小
                    int fileMain = postFile.PostedFile.ContentLength;
                    double fileSize = fileMain / 1024.0 / 1024.0;
                    if (fileSize > 10)
                    {
                        returnStr = "{\"status\":\"-3\",\"msg\":\"上传失败,图片大小超过10M\"}";
                        return returnStr;
                    }
                    if (isChkImageExtension(fileExt))
                    {
                        try
                        {
                            string filePath = Tools.StringDispose.SetStrLength(Guid.NewGuid().ToString().Replace("-", ""), 15, 0) + "" + DateTime.Now.ToString("yyyyMMddHHmmss") + new Random().Next(1, 1000) + fileExt;
                            if (!string.IsNullOrEmpty(imgUrl))
                            {
                                DeleteByImg(imgUrl);
                            }
                            string newPath = "/Upload/" + lan + "/" + dirPath + "/";
                            string path = System.Web.HttpContext.Current.Server.MapPath(newPath);
                            if (!Directory.Exists(path))
                            {
                                Directory.CreateDirectory(path);
                            }
                            string newFile = path + filePath;
                            postFile.PostedFile.SaveAs(newFile);
                            returnStr = "{\"status\":\"1\",\"msg\":\"上传成功\",\"path\":\"" + newPath + filePath + "\"}";
                        }
                        catch (Exception e)
                        {
                            Console.Write(e.Message);
                            returnStr = "{\"status\":\"-1\",\"msg\":\"上传程序异常!\"}";
                        }
                    }
                    else
                    {
                        returnStr = "{\"status\":\"-2\",\"msg\":\"文件格式不正确\"}";
                    }
                }
                return returnStr;
            }
        }

        /// <summary>
        /// 图片 htmlinputFile 上传
        /// </summary>
        /// <param name="postFile">上传文件对象</param>
        /// <param name="imgUrl">原始图片路径</param>
        /// <param name="lan">语言</param>
        /// <param name="dirPath">上传文件</param>
        /// <returns></returns>
        public static string uploadImg2(System.Web.HttpPostedFile htmlfile, string lan, string dirPath, string imgUrl)
        {
            string returnStr = "";
            //文件扩展名
            string fileExt = System.IO.Path.GetExtension(htmlfile.FileName).ToString().ToLower();
            //文件大小
            int fileMain = htmlfile.ContentLength;
            double fileSize = Math.Round(fileMain / 1024.0 / 1024.0);
            if (fileSize > 10) {
                returnStr = "{\"status\":\"-3\",\"msg\":\"上传失败,图片大小超过10M\"}";
                return returnStr;
            }
            if (isChkImageExtension(fileExt))
            {
                try
                {
                    string filePath = Tools.StringDispose.SetStrLength(Guid.NewGuid().ToString().Replace("-",""),15,0) + "" + DateTime.Now.ToString("yyyyMMddHHmmss") + new Random().Next(1, 1000) + fileExt;
                    if (!string.IsNullOrEmpty(imgUrl))
                    {
                        DeleteByImg(imgUrl);
                    }
                    string newPath = "/Upload/" + lan + "/" + dirPath + "/";
                    string path = System.Web.HttpContext.Current.Server.MapPath(newPath);
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    string newFile = path + filePath;
                    htmlfile.SaveAs(newFile);
                    returnStr = "{\"status\":\"1\",\"msg\":\"上传成功\",\"path\":\"" + newPath + filePath + "\"}";
                }
                catch (Exception e)
                {
                    Console.Write(e.Message);
                    returnStr = "{\"status\":\"-1\",\"msg\":\"上传程序异常!\"}";
                }
            }
            else
            {
                returnStr = "{\"status\":\"-2\",\"msg\":\"文件格式不正确\"}";
            }
            
            return returnStr;
        }


        /// <summary>
        /// 图片上传 原图压缩为 指定大小 判断是否要生存缩略图  返回压缩后的图片  原图需要替换 sagettayasou_
        /// </summary> 
        /// <param name="postFile">上传文件对象</param>
        /// <param name="imgUrl">原始图片路径</param>
        /// <param name="lan">语言</param>
        /// <param name="dirPath">上传文件</param>
        /// <param name="width">上传文件压缩宽度</param>
        /// <param name="height">上传文件压缩高度</param>
        /// <param name="thumbnails">是否生产缩略图  格式为m_原图 缩略图不记录数据库只存在硬盘</param>
        /// <param name="thuWidth">缩略图压缩宽度</param>
        /// <param name="thumHeigh">缩略图压缩高度</param>
        /// <returns></returns>
        public static string uploadImg3(System.Web.UI.WebControls.FileUpload postFile, string lan, string dirPath, string imgUrl, int width, int height, bool thumbnails, int thuWidth, int thumHeigh)
        {
            string returnStr = "";
            if (!postFile.HasFile)
            {
                returnStr = "{\"status\":\"2\",\"msg\":\"没有选择图片!\"}";
            }
            else
            {
                //文件扩展名
                string fileExt = System.IO.Path.GetExtension(postFile.PostedFile.FileName).ToString().ToLower();
                //文件大小
                int fileMain = postFile.PostedFile.ContentLength;
                double fileSize = fileMain / 1024.0 / 1024.0;
                if (fileSize > 10)
                {
                    returnStr = "{\"status\":\"-3\",\"msg\":\"上传失败,图片大小超过10M\"}";
                    return returnStr;
                }
                if (isChkImageExtension(fileExt))
                {
                    try
                    {
                        string filePath = Tools.StringDispose.SetStrLength(Guid.NewGuid().ToString().Replace("-", ""), 15, 0) + "" + DateTime.Now.ToString("yyyyMMddHHmmss") + new Random().Next(1, 1000) + fileExt;
                        if (!string.IsNullOrEmpty(imgUrl))
                        {
                            DeleteByImg(imgUrl);
                            string newUrls = imgUrl.Substring(0, imgUrl.LastIndexOf("/") + 1) + ("m_" + imgUrl.Substring(imgUrl.LastIndexOf("/") + 1));
                            DeleteByImg(newUrls);
                        }
                        string newPath = "/Upload/" + lan + "/" + dirPath + "/";
                        string path = System.Web.HttpContext.Current.Server.MapPath(newPath);
                        if (!Directory.Exists(path))
                        {
                            Directory.CreateDirectory(path);
                        }
                        string newFile  = path + filePath; //新的目录 + 文件

                        postFile.PostedFile.SaveAs(newFile);
                        postFile.Dispose();
                        //上传原图进行压缩
                        if (width > 0 && height > 0)
                        {
                            Tools.ImagesUtil imgUtil = new ImagesUtil(newFile);
                            imgUtil.GetReducedImage(width, height, System.Web.HttpContext.Current.Server.MapPath(newPath) + "sagettayasou_" + filePath);
                        }
                        if (thumbnails)
                        {
                            if (thuWidth > 0 && thumHeigh > 0)
                            {
                                //生成缩略图
                                Tools.ImagesUtil imgUtil = new ImagesUtil(newFile);
                                imgUtil.GetReducedImage(thuWidth, thumHeigh, path + ("m_" + filePath));
                            }
                        }
                        returnStr = "{\"status\":\"1\",\"msg\":\"上传成功\",\"path\":\"" + newPath + "sagettayasou_" + filePath + "\"}";
                    }
                    catch (Exception e)
                    {
                        Console.Write(e.Message);
                        returnStr = "{\"status\":\"-1\",\"msg\":\"上传程序异常!\"}";
                    }
                }
                else
                {
                    returnStr = "{\"status\":\"-2\",\"msg\":\"文件格式不正确\"}";
                }
            }
            return returnStr;
        }


        /// <summary>
        /// 文件上传  控制上传20M
        /// </summary>
        /// <param name="postFile"></param>
        /// <param name="lan"></param>
        /// <param name="dirPath"></param>
        /// <param name="imgUrl"></param>
        /// <returns></returns>
        public static string uploadFile(System.Web.UI.WebControls.FileUpload postFile, string lan, string dirPath, string imgUrl)
        {
            string returnStr = "";
            if (!postFile.HasFile)
            {
                returnStr = "{\"status\":\"2\",\"msg\":\"没有选择文件!\"}";
            }
            else
            {
                //文件扩展名
                string fileExt = System.IO.Path.GetExtension(postFile.PostedFile.FileName).ToString().ToLower();
                //文件大小
                int fileMain = postFile.PostedFile.ContentLength;
                double fileSize = fileMain / 1024.0 / 1024.0;
                if ( fileSize > 20 )
                {
                    returnStr = "{\"status\":\"-3\",\"msg\":\"上传失败,图片大小超过20M\"}";
                    return returnStr;
                }
                if (isChkFileExtension(fileExt))
                {
                    try
                    {
                        string filePath = Tools.StringDispose.SetStrLength(Guid.NewGuid().ToString().Replace("-",""),15,0) + "" + DateTime.Now.ToString("yyyyMMddHHmmss") + new Random().Next(1, 1000) + fileExt;
                        if (!string.IsNullOrEmpty(imgUrl))
                        {
                            DeleteByImg(imgUrl);
                        }
                        string newPath = "/Upload/" + lan + "/" + dirPath + "/";
                        string path = System.Web.HttpContext.Current.Server.MapPath(newPath);
                        if (!Directory.Exists(path))
                        {
                            Directory.CreateDirectory(path);
                        }
                        string newFile = path + filePath;
                        postFile.PostedFile.SaveAs(newFile);
                        returnStr = "{\"status\":\"1\",\"msg\":\"上传成功\",\"path\":\"" + newPath + filePath + "\",\"fileSize\":\"" + fileSize + "\",\"format\":\"" + fileExt + "\"}";
                    }
                    catch (Exception e)
                    {
                        Console.Write(e.Message);
                        returnStr = "{\"status\":\"-1\",\"msg\":\"上传程序异常!\"}";
                    }
                }
                else
                {
                    returnStr = "{\"status\":\"-2\",\"msg\":\"文件格式不正确\"}";
                }
            }
            return returnStr;
        }



        /// <summary>
        /// 批量删除图片
        /// </summary>
        /// <param name="imgList"></param>
        public static void DeleteByBatchImg(List<string> imgList) {
            if (imgList != null && imgList.Count > 0)
            {
                foreach (string str in imgList)
                {
                    if (!DeleteByImg(str))
                    {
                        continue;
                    }
                }
            }
        }

        /// <summary>
        /// 单张删除图片
        /// </summary>
        /// <param name="str"></param>
        public static bool DeleteByImg(string str) {
            try
            {
                if (!string.IsNullOrEmpty(str)) {
                    string path = System.Web.HttpContext.Current.Server.MapPath(str);
                    if (File.Exists(path))
                    {
                        System.IO.File.Delete(path);
                    }
                }
                return true;
            }
            catch (Exception ex) {
                throw new IOException(ex.Message);
               
            }
        }

        /// <summary>
        /// 判断图片格式
        /// </summary>
        /// <returns></returns>
        public static bool isChkImageExtension(string exts) {
            string[] s = {".jpg",".gif",".jpeg",".png",".ico"};
            if( s.Contains(exts.ToLower())){
                return true; 
            }
            return false;
        }
        /// <summary>
        /// 判断文件上传格式
        /// </summary>
        /// <returns></returns>
        public static bool isChkFileExtension(string exts)
        {
            string[] s = { ".jpg", ".gif", ".jpeg", ".png", ".ico" ,".rar",".txt",".log",".zip",".pdf",".doc",".xls",".ppt",".jar"};
            if (s.Contains(exts.ToLower()))
            {
                return true;
            }
            return false;
        }

    }
}
