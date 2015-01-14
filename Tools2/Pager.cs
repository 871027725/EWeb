/********************************************************************************
** 作者： ywx
** 创始时间： 2011-3-15
** 修改人：无
** 描述：分页
**********************************************************************************/

using System;
using System.Web;
using System.Web.UI;
using System.Text.RegularExpressions;
using System.Text;

namespace Tools
{ 
    /// <summary>
    /// 分页显示类
    /// </summary>
    public class Pager
    {
        #region 对齐方式 enum
        /// <summary>
        /// 对齐方式
        /// </summary>
        public enum Align { 
            /// <summary>
            /// 左对齐
            /// </summary>
            Left = 0, 
            /// <summary>
            /// 居中
            /// </summary>
            Center, 
            /// <summary>
            /// 右对齐
            /// </summary>
            Right
        }
        #endregion

        #region 私有成员
        private string _Url;
        private int _PageIndex;
        private int _TotalPage;
        private int _PageSize;
        private int _TotalRecord;
        private string _StyleName;
        private Align _Align;
        private int _Index=1;
        private StringBuilder sbData = new StringBuilder();
        #endregion

        #region 属性
        /// <summary>
        /// URL
        /// </summary>
        public string Url { set { _Url = value; } }
        /// <summary>
        /// 当前页
        /// </summary>
        public int PageIndex { set { _PageIndex = value; } }
        /// <summary>
        /// 总页
        /// </summary>
        public int TotalPage { set { _TotalPage = value; } }
        /// <summary>
        /// 页大小
        /// </summary>
        public int PageSize { set { _PageSize = value; } }
        /// <summary>
        /// 总记录
        /// </summary>
        public int TotalRecord { set {  _TotalRecord = value; } }
        /// <summary>
        /// 样式
        /// </summary>
        public string StyleName { set { _StyleName = value; } }
        /// <summary>
        /// 对齐方式
        /// </summary>
        public Align HAlign { set { _Align = value; } }
        /// <summary>
        /// 索引
        /// </summary>
        public int Index { set { _Index = value; } }
        #endregion

        #region 构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        public Pager()
        {
            this._Url = "";
            this._PageIndex = 1;
            this._TotalPage = 1;
            this._PageSize = 20;
            this._TotalRecord = 0;
            this._StyleName = "BasePager";
            this._Align = Align.Left;
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="Url">URL</param>
        /// <param name="PageIndex">当前页</param>
        /// <param name="TotalPage">总页</param>
        /// <param name="PageSize">页大小</param>
        /// <param name="TotalRecord">总记录数</param>
        /// <param name="StyleName">样式 默认BasePager</param>
        public Pager(string Url, int PageIndex, int TotalPage, int PageSize, int TotalRecord, string StyleName)
        {
            this._Url = Url;
            this._PageIndex = PageIndex;
            this._TotalPage = TotalPage;
            this._PageSize = PageSize;
            this._TotalRecord = TotalRecord;
            this._StyleName = StyleName;
        }
        #endregion

        #region 填充Html代码 生成分页代码

        /// <summary>
        /// 后台分页函数
        /// </summary>
        /// <param name="curPage">当前页码</param>
        /// <param name="count">记录数</param>
        /// <param name="url">页面url</param>
        /// <param name="pagesize">每页条数</param>
        /// <returns></returns>
        public static string GetPage(int curPage, int count, string url, int pagesize)
        {
            int pageCount;
            pageCount = (count % pagesize == 0) ? count / pagesize : pageCount = count / pagesize + 1;
            return GetPager(curPage, pageCount, url, 10);

        }

        /// <summary>
        /// 生成分页HTML代码
        /// </summary>
        /// <param name="curPage">当前页</param>
        /// <param name="countPage">总页数</param>
        /// <param name="url">URL</param>
        /// <param name="extendPage">输出页数</param>
        /// <returns></returns>
        public static string GetPager(int curPage, int countPage, string url, int extendPage) {
            if (countPage<=1) return "";
			
            int startPage = 1;
			int endPage = 1;
			string t1 = "<a href=\"" + string.Format(url,1) + "\">&laquo;</a>&nbsp;";
			string t2 = "<a href=\"" + string.Format(url,countPage) + "\">&raquo;</a>&nbsp;";
			if(countPage < 1) countPage = 1;
			if(extendPage < 3) extendPage = 2;
			if(countPage > extendPage) {
				if(curPage - (extendPage / 2) > 0) {
					if(curPage + (extendPage / 2) < countPage) {
						startPage = curPage - (extendPage / 2);
						endPage = startPage + extendPage - 1;
					} else {
						endPage = countPage;
						startPage = endPage - extendPage + 1;
						t2 = "";
					}
				} else {
					endPage = extendPage;
					t1 = "";
				}
			} else {
				startPage = 1;
				endPage = countPage;
				t1 = "";
				t2 = "";
			}
			System.Text.StringBuilder s = new System.Text.StringBuilder("");
			s.Append(t1);
			for (int i = startPage; i <= endPage; i++) {
				if (i == curPage) {
					s.Append("&nbsp;<a style=\"color:red;\">");
					s.Append(i);
					s.Append("</a>&nbsp;");
				} else {
					s.Append("&nbsp;<a href=\"");
					s.Append(string.Format(url,i));
					s.Append("\">");
					s.Append(i);
					s.Append("</a>&nbsp;");
				}
			}
			s.Append(t2);
            s.Append("<span>共" + countPage + "页</span>");
			return s.ToString();
        }
        #endregion
    }
}
