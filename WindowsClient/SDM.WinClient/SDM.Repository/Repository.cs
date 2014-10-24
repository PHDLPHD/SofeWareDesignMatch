using EntityFramework.Extensions;
using SDM.DTO;
using SDM.IRepository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
namespace SDM.Repository
{
    public class Repository<T> : IRepository<T> where T : Entity, new()
    {
        private readonly DbContext context;

        public DbContext Context { get { return context; } }

        private readonly DbSet<T> dbset;

        public DbSet<T> DbSet { get { return dbset; } }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="dbContext">DbContext</param>
        public Repository(DbContext dbContext)
        {
            this.context = dbContext;
            this.dbset = this.context.Set<T>();
        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity">实体</param>
        public virtual void Add(T entity)
        {
            dbset.Add(entity);
        }

        /// <summary>
        /// 新增数据集
        /// </summary>
        /// <param name="entities">实体集</param>
        public virtual void Add(IEnumerable<T> entities)
        {
            dbset.AddRange(entities);
        }

        /// <summary>
        /// 大批量插入数据(无需再Commit,只支持sqlserver并且属性名与数据库表、列名称一致)
        /// </summary>
        /// <param name="entities">实体集</param>
        public virtual void BulkInsert(IEnumerable<T> entities)
        {
            SqlConnection sqlConn = this.Context.Database.Connection as SqlConnection;
            SqlBulkCopy sbc = new SqlBulkCopy(sqlConn);
            sbc.DestinationTableName = typeof(T).Name;
            sbc.BatchSize = entities.Count();
            PropertyInfo[] propertys = typeof(T).GetProperties();

            #region 构建DataTable
            System.Data.DataTable dt = new System.Data.DataTable();
            foreach (PropertyInfo pi in propertys)
            {
                if (pi.Name != "Check")
                {
                    if (pi.PropertyType.IsGenericType && pi.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                    {
                        dt.Columns.Add(pi.Name, pi.PropertyType.GetGenericArguments()[0]);
                    }
                    else
                    {
                        dt.Columns.Add(pi.Name, pi.PropertyType);
                    }
                    sbc.ColumnMappings.Add(pi.Name, pi.Name);
                }
            }
            foreach (var item in entities)
            {
                System.Collections.ArrayList tempList = new System.Collections.ArrayList();
                foreach (PropertyInfo pi in propertys)
                {
                    object obj = pi.GetValue(item, null);
                    if (pi.Name != "Check")
                        tempList.Add(obj);
                }
                object[] array = tempList.ToArray();
                dt.LoadDataRow(array, true);
            }
            #endregion
            if (sqlConn.State != System.Data.ConnectionState.Open)
                sqlConn.Open();
            sbc.WriteToServer(dt);
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="entity">实体</param>
        public virtual void Update(T entity)
        {
            DbEntityEntry<T> entry = Context.Entry(entity);
            try
            {
                if (entry.State == EntityState.Detached)
                {
                    dbset.Attach(entity);
                    Context.Entry(entity).State = EntityState.Modified;
                }
            }
            catch
            {
                T oldEntity = dbset.Find(entity.ID);
                context.Entry(oldEntity).CurrentValues.SetValues(entity);
            }

        }

        /// <summary>
        /// 更新实体集
        /// </summary>
        /// <param name="entity">实体</param>
        public virtual void Update(IEnumerable<T> entities)
        {
            foreach (T entity in entities)
            {
                DbEntityEntry<T> entry = Context.Entry(entity);
                try
                {
                    if (entry.State == EntityState.Detached)
                    {
                        dbset.Attach(entity);
                        context.Entry(entity).State = EntityState.Modified;
                    }
                }
                catch
                {
                    T oldEntity = dbset.Find(entity.ID);
                    context.Entry(oldEntity).CurrentValues.SetValues(entity);
                }
            }
        }
        /// <summary>
        /// 批量更新
        /// </summary>
        /// <param name="entity"></param>
        public void Update(Expression<Func<T, bool>> where, Expression<Func<T, T>> entity)
        {
            this.dbset.Where(where).Update(entity);                                     
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id">主键</param>
        public virtual void Delete(object id)
        {
            if (id != null)
            {
                dbset.Remove(this.GetById(id));
            }
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="entity">实体</param>
        public virtual void Delete(T entity)
        {

            DbEntityEntry<T> entry = Context.Entry(entity);
            if (entry.State == EntityState.Detached)
            {
                dbset.Attach(entity);
            }
            dbset.Remove(entity);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="entities">实例集</param>
        public virtual void Delete(IEnumerable<T> entities)
        {
            foreach (T entity in entities)
            {
                DbEntityEntry<T> entry = Context.Entry(entity);
                if (entry.State == EntityState.Detached)
                {
                    dbset.Attach(entity);
                }
                dbset.Remove(entity);
            }
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="where">条件</param>
        public virtual void Delete(Expression<Func<T, bool>> where)
        {
            this.dbset.Where(where).Delete();
        }

        /// <summary>
        /// 通过ID获取实例
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        public virtual T GetById(object id)
        {
            return dbset.Find(id);
        }

        /// <summary>
        /// 获取所有数据
        /// </summary>
        /// <returns>IEnumerable<T></returns>
        public virtual IEnumerable<T> GetAll()
        {
            return dbset;
        }

        /// <summary>
        /// 获取实体集
        /// </summary>
        /// <param name="where">条件</param>
        /// <param name="orderByExpression">排序</param>
        /// <param name="IsDESC">是否倒序</param>
        /// <param name="NoTracking">是否跟踪</param>
        /// <returns>实体集</returns>
        public virtual IEnumerable<T> Get(Expression<Func<T, bool>> where, Expression<Func<T, bool>> orderByExpression = null, bool IsDESC = true, bool NoTracking = false)
        {

            var entities = where != null ? dbset.Where(where) : dbset;

            if (orderByExpression != null)
            {
                if (IsDESC)
                {
                    entities = entities.OrderByDescending(orderByExpression);
                }
                else
                {
                    entities = entities.OrderBy(orderByExpression);
                }
            }
            if (NoTracking)
            {
                entities = entities.AsNoTracking();
            }
            return entities;
        }



        public virtual IEnumerable<T> Get<TKey>(Expression<Func<T, bool>> where, Expression<Func<T, TKey>> orderByExpression = null, bool IsDESC = true, bool NoTracking = false)
        {

            var entities = where != null ? dbset.Where(where) : dbset;

            if (orderByExpression != null)
            {
                if (IsDESC)
                {
                    entities = entities.OrderByDescending(orderByExpression);
                }
                else
                {
                    entities = entities.OrderBy(orderByExpression);
                }
            }
            if (NoTracking)
            {
                entities = entities.AsNoTracking();
            }
            return entities;
        }
        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="where">条件</param>
        /// <param name="pageSize">条数</param>
        /// <param name="pageIndex">第几页</param>
        /// <returns>IEnumerable<T></returns>
        /// <remarks>
        ///     页数从1开始
        /// </remarks>
        public virtual Page<T> GetByPage(Expression<Func<T, bool>> where, int pageSize, int pageIndex)
        {
            Page<T> pageList = new Page<T>();
            pageList.TotalCount = dbset.Where(where).Count();
            pageList.PageSize = pageSize;
            pageList.PageIndex = pageIndex;
            pageList.Data = dbset.Where(where).OrderBy(P => P.ID).Skip((pageIndex - 1) * pageSize).Take(pageSize);
            pageList.PageCount = pageList.Data.Count();
            return pageList;
        }

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <typeparam name="TKey">排序类型</typeparam>
        /// <param name="where">查询条件</param>
        /// <param name="pageSize">每页条数</param>
        /// <param name="pageIndex">第几页</param>
        /// <param name="orderByExpression">排序</param>
        /// <param name="IsDESC">倒序</param>
        /// <param name="NoTracking">跟踪</param>
        /// <returns></returns>
        public virtual Page<T> GetByPage<TKey>(Expression<Func<T, bool>> where, int pageSize, int pageIndex, Expression<Func<T, TKey>> orderByExpression = null, bool IsDESC = true, bool NoTracking = false)
        {
            Page<T> pageList = new Page<T>();

            var entities = where != null ? dbset.Where(where) : dbset;

            if (orderByExpression != null)
            {
                if (IsDESC)
                {
                    entities = entities.OrderByDescending(orderByExpression);
                }
                else
                {
                    entities = entities.OrderBy(orderByExpression);
                }
            }
            if (NoTracking)
            {
                entities = entities.AsNoTracking();
            }
            var q1 = entities.FutureCount();
            var q2 = entities.Skip((pageIndex - 1) * pageSize).Take(pageSize).Future();


            pageList.TotalCount = q1.Value;
            pageList.PageSize = pageSize;
            pageList.PageIndex = pageIndex;
            pageList.Data = q2.ToList();
            pageList.PageCount = pageList.Data.Count();
            return pageList;
        }
        public void Commit()
        {
            try
            {
                this.context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {

            }

        }
    }
}
