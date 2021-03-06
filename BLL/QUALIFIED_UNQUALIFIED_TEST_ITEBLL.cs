﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Transactions;
using Langben.DAL;
using Common;
using Langben.DAL.shiyanshi;

namespace Langben.BLL
{
    /// <summary>
    /// 合格不合格检定项目 
    /// </summary>
    public partial class QUALIFIED_UNQUALIFIED_TEST_ITEBLL :  IBLL.IQUALIFIED_UNQUALIFIED_TEST_ITEBLL, IDisposable
    {
        /// <summary>
        /// 私有的数据访问上下文
        /// </summary>
        protected SysEntities db;
        /// <summary>
        /// 合格不合格检定项目的数据库访问对象
        /// </summary>
        QUALIFIED_UNQUALIFIED_TEST_ITERepository repository = new QUALIFIED_UNQUALIFIED_TEST_ITERepository();
        /// <summary>
        /// 构造函数，默认加载数据访问上下文
        /// </summary>
        public QUALIFIED_UNQUALIFIED_TEST_ITEBLL()
        {
            db = new SysEntities();
        }
        /// <summary>
        /// 已有数据访问上下文的方法中调用
        /// </summary>
        /// <param name="entities">数据访问上下文</param>
        public QUALIFIED_UNQUALIFIED_TEST_ITEBLL(SysEntities entities)
        {
            db = entities;
        }
        /// <summary>
        /// 根据预备方案ID获取检测项信息
        /// </summary>
        /// <param name="PREPARE_SCHEMEID">预备方案ID</param>
        /// <param name="RULEID">检测项ID</param>
        /// <returns></returns>
        public QUALIFIED_UNQUALIFIED_TEST_ITE GetByPREPARE_SCHEMEID_RULEID(string PREPARE_SCHEMEID = "", string RULEID = "")
        {
            StringBuilder sb = new StringBuilder();
            if (PREPARE_SCHEMEID != null && PREPARE_SCHEMEID.Trim() != "")
            {
                sb.AppendFormat("PREPARE_SCHEMEID{0}&{1}^", ArgEnums.DDL_String, PREPARE_SCHEMEID);
            }
            if(RULEID!=null && RULEID.Trim()!="")
            {
                sb.AppendFormat("RULEID{0}&{1}^", ArgEnums.DDL_String, RULEID);
            }
            if (sb.ToString().Trim() != "")
            {
                sb = sb.Remove(sb.ToString().Length - 1, 1);
            }
            List<DAL.QUALIFIED_UNQUALIFIED_TEST_ITE> list = repository.GetData(db, "asc", "SORT", sb.ToString()).ToList();
            if(list!=null && list.Count>0)
            {
                return list[0];
            }
            return null;

        }
        /// <summary>
        /// 查询的数据
        /// </summary>
        /// <param name="id">额外的参数</param>
        /// <param name="page">页码</param>
        /// <param name="rows">每页显示的行数</param>
        /// <param name="order">升序asc（默认）还是降序desc</param>
        /// <param name="sort">排序字段</param>
        /// <param name="search">查询条件</param>
        /// <param name="total">结果集的总数</param>
        /// <returns>结果集</returns>
        public List<QUALIFIED_UNQUALIFIED_TEST_ITE> GetByParam(string id, int page, int rows, string order, string sort, string search, ref int total)
        {
            IQueryable<QUALIFIED_UNQUALIFIED_TEST_ITE> queryData = repository.GetData(db, order, sort, search);
            total = queryData.Count();
            if (total > 0)
            {
                if (page <= 1)
                {
                    queryData = queryData.Take(rows);
                }
                else
                {
                    queryData = queryData.Skip((page - 1) * rows).Take(rows);
                }
                
                    foreach (var item in queryData)
                    {
                        if (item.PREPARE_SCHEMEID != null && item.PREPARE_SCHEME != null)
                        { 
                                item.PREPARE_SCHEMEIDOld = item.PREPARE_SCHEME.REPORT_CATEGORY.GetString();//                            
                        }                  

                    }
 
            }
            return queryData.ToList();
        }
        /// <summary>
        /// 查询的数据 /*在6.0版本中 新增*/
        /// </summary>
        /// <param name="id">额外的参数</param>
        /// <param name="page">页码</param>
        /// <param name="rows">每页显示的行数</param>
        /// <param name="order">升序asc（默认）还是降序desc</param>
        /// <param name="sort">排序字段</param>
        /// <param name="search">查询条件</param>
        /// <param name="total">结果集的总数</param>
        /// <returns>结果集</returns>
        public List<QUALIFIED_UNQUALIFIED_TEST_ITE> GetByParam(string id, string order, string sort, string search)
        {
            IQueryable<QUALIFIED_UNQUALIFIED_TEST_ITE> queryData = repository.GetData(db, order, sort, search);
            
            return queryData.ToList();
        }
        /// <summary>
        /// 创建一个合格不合格检定项目
        /// </summary>
        /// <param name="validationErrors">返回的错误信息</param>
        /// <param name="db">数据库上下文</param>
        /// <param name="entity">一个合格不合格检定项目</param>
        /// <returns></returns>
        public bool Create(ref ValidationErrors validationErrors, QUALIFIED_UNQUALIFIED_TEST_ITE entity)
        {
            try
            {
                repository.Create(entity);
                return true;
            }
            catch (Exception ex)
            {
                validationErrors.Add(ex.Message);
                ExceptionsHander.WriteExceptions(ex);                
            }
            return false;
        }
        /// <summary>
        ///  创建合格不合格检定项目集合
        /// </summary>
        /// <param name="validationErrors">返回的错误信息</param>
        /// <param name="entitys">合格不合格检定项目集合</param>
        /// <returns></returns>
        public bool CreateCollection(ref ValidationErrors validationErrors, IQueryable<QUALIFIED_UNQUALIFIED_TEST_ITE> entitys)
        {
            try
            {
                if (entitys != null)
                {
                    int count = entitys.Count();
                    if (count == 1)
                    {
                        return this.Create(ref validationErrors, entitys.FirstOrDefault());
                    }
                    else if (count > 1)
                    {
                        //using (TransactionScope transactionScope = new TransactionScope())
                        { 
                            repository.Create(db, entitys);
                            if (count == repository.Save(db))
                            {
                                //transactionScope.Complete();
                                return true;
                            }
                            else
                            {
                                //Transaction.Current.Rollback();
                            }                          
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                validationErrors.Add(ex.Message);
                ExceptionsHander.WriteExceptions(ex);                
            }
            return false;
        }
        /// <summary>
        /// 删除一个合格不合格检定项目
        /// </summary>
        /// <param name="validationErrors">返回的错误信息</param>
        /// <param name="id">一合格不合格检定项目的主键</param>
        /// <returns></returns>  
        public bool Delete(ref ValidationErrors validationErrors, string id)
        {
            try
            {
                //return repository.Delete(id) == 1;
                repository.Delete(id);
                return true;
            }
            catch (Exception ex)
            {
                validationErrors.Add(ex.Message);
                ExceptionsHander.WriteExceptions(ex);                
            }
            return false;
        }
        /// <summary>
        /// 删除合格不合格检定项目集合
        /// </summary>
        /// <param name="validationErrors">返回的错误信息</param>
        /// <param name="deleteCollection">合格不合格检定项目的集合</param>
        /// <returns></returns>    
        public bool DeleteCollection(ref ValidationErrors validationErrors, string[] deleteCollection)
        {
            try
            {
                if (deleteCollection != null)
                { 
                        //using (TransactionScope transactionScope = new TransactionScope())
                        { 
                            repository.Delete(db, deleteCollection);
                            if (deleteCollection.Length == repository.Save(db))
                            {
                                //transactionScope.Complete();
                                return true;
                            }
                            else
                            {
                                //Transaction.Current.Rollback();
                            }
                        }
                    }
             
            }
            catch (Exception ex)
            {
                validationErrors.Add(ex.Message);
                ExceptionsHander.WriteExceptions(ex);                
            }
            return false;
        }
        /// <summary>
        ///  创建合格不合格检定项目集合
        /// </summary>
        /// <param name="validationErrors">返回的错误信息</param>
        /// <param name="entitys">合格不合格检定项目集合</param>
        /// <returns></returns>
        public bool EditCollection(ref ValidationErrors validationErrors, IQueryable<QUALIFIED_UNQUALIFIED_TEST_ITE> entitys)
        {
            try
            {
                if (entitys != null)
                {
                    int count = entitys.Count();
                    if (count == 1)
                    {
                        return this.Edit(ref validationErrors, entitys.FirstOrDefault());
                    }
                    else if (count > 1)
                    {
                        //using (TransactionScope transactionScope = new TransactionScope())
                        { 
                            repository.Edit(db, entitys);
                            if (count == repository.Save(db))
                            {
                                //transactionScope.Complete();
                                return true;
                            }
                            else
                            {
                                //Transaction.Current.Rollback();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                validationErrors.Add(ex.Message);
                ExceptionsHander.WriteExceptions(ex);                
            }
            return false;
        }
         /// <summary>
        /// 编辑一个合格不合格检定项目
        /// </summary>
        /// <param name="validationErrors">返回的错误信息</param>
        /// <param name="entity">一个合格不合格检定项目</param>
        /// <returns></returns>
        public bool Edit(ref ValidationErrors validationErrors, QUALIFIED_UNQUALIFIED_TEST_ITE entity)
        {
            try
            { 
                repository.Edit(db, entity);
                repository.Save(db);
                return true;
            }
            catch (Exception ex)
            {
                validationErrors.Add(ex.Message);
                ExceptionsHander.WriteExceptions(ex);                
            }
            return false;
        }
      
        public List<QUALIFIED_UNQUALIFIED_TEST_ITE> GetAll()
        {           
            return repository.GetAll(db).ToList();          
        }   
        
        /// <summary>
        /// 根据主键获取一个合格不合格检定项目
        /// </summary>
        /// <param name="id">合格不合格检定项目的主键</param>
        /// <returns>一个合格不合格检定项目</returns>
        public QUALIFIED_UNQUALIFIED_TEST_ITE GetById(string id)
        {           
            return repository.GetById(db, id);           
        }


        /// <summary>
        /// 根据PREPARE_SCHEMEIDId，获取所有合格不合格检定项目数据
        /// </summary>
        /// <param name="id">外键的主键</param>
        /// <returns></returns>
        public List<QUALIFIED_UNQUALIFIED_TEST_ITE> GetByRefPREPARE_SCHEMEID(string id)
        {
            return repository.GetByRefPREPARE_SCHEMEID(db, id).ToList();                      
        }

        public void Dispose()
        {
           
        }
    }
}

