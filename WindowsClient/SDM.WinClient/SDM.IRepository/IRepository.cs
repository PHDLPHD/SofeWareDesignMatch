using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SDM.IRepository
{
    /// <summary>
    /// 工程仓库接口
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// 新增一条数据
        /// </summary>
        /// <param name="entity"></param>
        void Add(T entity);
        /// <summary>
        /// 新增一组数据
        /// </summary>
        /// <param name="entities"></param>
        void Add(IEnumerable<T> entities);
        /// <summary>
        /// 快速增加一组数据
        /// </summary>
        /// <param name="entities"></param>
        void BulkInsert(IEnumerable<T> entities);
        /// <summary>
        /// 更新一条数据
        /// </summary>
        /// <param name="entity"></param>
        void Update(T entity);
        /// <summary>
        /// 更新一组数据
        /// </summary>
        /// <param name="entities"></param>
        void Update(IEnumerable<T> entities);
        /// <summary>
        /// 批量更新一组数据
        /// </summary>
        /// <param name="where"></param>
        /// <param name="entity"></param>
        void Update(Expression<Func<T, bool>> where, Expression<Func<T, T>> entity);
        /// <summary>
        /// 根据ID删除一条数据
        /// </summary>
        /// <param name="ID"></param>
        void Delete(object ID);
        /// <summary>
        /// 删除一条数据库
        /// </summary>
        /// <param name="entity"></param>
        void Delete(T entity);
        /// <summary>
        /// 删除一组数据库
        /// </summary>
        /// <param name="entitse"></param>
        void Delete(IEnumerable<T> entitse);
        /// <summary>
        /// 根据条件删除数据库
        /// </summary>
        /// <param name="where"></param>
        void Delete(Expression<Func<T, bool>> where);
        /// <summary>
        ///根据主键拿到一条数据
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        T GetById(object ID);
        /// <summary>
        /// 根据条件数据
        /// </summary>
        /// <param name="where">条件</param>
        /// <param name="orderByExpression">排序条件（）</param>
        /// <param name="IsDESC">是否倒序</param>
        /// <param name="NoTracking">是否跟踪</param>
        /// <returns></returns>
        IEnumerable<T> Get(Expression<Func<T, bool>> where, Expression<Func<T, bool>> orderByExpression = null, bool IsDESC = true, bool NoTracking = false);
        /// <summary>
        /// 按条件拿数据
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="where"></param>
        /// <param name="orderByExpression"></param>
        /// <param name="IsDESC"></param>
        /// <param name="NoTracking"></param>
        /// <returns></returns>
        IEnumerable<T> Get<TKey>(Expression<Func<T, bool>> where, Expression<Func<T, TKey>> orderByExpression = null, bool IsDESC = true, bool NoTracking = false);
        /// <summary>
        /// 获取全部数据库
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> GetAll();
        /// <summary>
        /// 提交到数据库
        /// </summary>
        void Commit();
    }
}
