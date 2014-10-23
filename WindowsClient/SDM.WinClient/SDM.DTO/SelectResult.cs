using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDM.DTO
{
    public class SelectResult<T>:EventArgs where T:class,new()
    {
        public T entity { get; set; }
        public List<T> entities { get; set; }
        public SelectResult()
        {
            entities = new List<T>();
            entity = new T();
        }
    }
}
