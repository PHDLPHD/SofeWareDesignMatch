using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDM.Common
{
    /// <summary>
    /// 分页类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Page<T>
    {
        /// <summary>
        /// 总页数
        /// </summary>
        public int TotalCount { get; set; }
        /// <summary>
        /// 当前页码
        /// </summary>
        public int PageIndex { get; set; }
        /// <summary>
        /// 每页的大小
        /// </summary>
        public int PageSize { get; set; }
        /// <summary>
        /// 每页总数
        /// </summary>
        public int PageCount { get; set; }
        /// <summary>
        /// 真实数据
        /// </summary>
        public IEnumerable<T> Data { get; set; }
    }
}
