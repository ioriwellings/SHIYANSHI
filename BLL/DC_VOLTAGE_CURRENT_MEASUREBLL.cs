﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Transactions;
using Langben.DAL;
using Common;

namespace Langben.BLL
{
    /// <summary>
    /// 直流电压电流测量 
    /// </summary>
    public partial class DC_VOLTAGE_CURRENT_MEASUREBLL :  IBLL.IDC_VOLTAGE_CURRENT_MEASUREBLL, IDisposable
    {
        /// <summary>
        /// 私有的数据访问上下文
        /// </summary>
        protected SysEntities db;
        /// <summary>
        /// 直流电压电流测量的数据库访问对象
        /// </summary>
        DC_VOLTAGE_CURRENT_MEASURERepository repository = new DC_VOLTAGE_CURRENT_MEASURERepository();
        /// <summary>
        /// 构造函数，默认加载数据访问上下文
        /// </summary>
        public DC_VOLTAGE_CURRENT_MEASUREBLL()
        {
            db = new SysEntities();
        }
        /// <summary>
        /// 已有数据访问上下文的方法中调用
        /// </summary>
        /// <param name="entities">数据访问上下文</param>
        public DC_VOLTAGE_CURRENT_MEASUREBLL(SysEntities entities)
        {
            db = entities;
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
        public List<DC_VOLTAGE_CURRENT_MEASURE> GetByParam(string id, int page, int rows, string order, string sort, string search, ref int total)
        {
            IQueryable<DC_VOLTAGE_CURRENT_MEASURE> queryData = repository.GetData(db, order, sort, search);
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
                        if (item.OVERALL_TABLEID != null && item.OVERALL_TABLE != null)
                        { 
                                item.OVERALL_TABLEIDOld = item.OVERALL_TABLE.NAME.GetString();//                            
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
        public List<DC_VOLTAGE_CURRENT_MEASURE> GetByParam(string id, string order, string sort, string search)
        {
            IQueryable<DC_VOLTAGE_CURRENT_MEASURE> queryData = repository.GetData(db, order, sort, search);
            
            return queryData.ToList();
        }
        /// <summary>
        /// 创建一个直流电压电流测量
        /// </summary>
        /// <param name="validationErrors">返回的错误信息</param>
        /// <param name="db">数据库上下文</param>
        /// <param name="entity">一个直流电压电流测量</param>
        /// <returns></returns>
        public bool Create(ref ValidationErrors validationErrors, DC_VOLTAGE_CURRENT_MEASURE entity)
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
        ///  创建直流电压电流测量集合
        /// </summary>
        /// <param name="validationErrors">返回的错误信息</param>
        /// <param name="entitys">直流电压电流测量集合</param>
        /// <returns></returns>
        public bool CreateCollection(ref ValidationErrors validationErrors, IQueryable<DC_VOLTAGE_CURRENT_MEASURE> entitys)
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
        /// 删除一个直流电压电流测量
        /// </summary>
        /// <param name="validationErrors">返回的错误信息</param>
        /// <param name="id">一直流电压电流测量的主键</param>
        /// <returns></returns>  
        public bool Delete(ref ValidationErrors validationErrors, string id)
        {
            try
            {
                return repository.Delete(id) == 1;
            }
            catch (Exception ex)
            {
                validationErrors.Add(ex.Message);
                ExceptionsHander.WriteExceptions(ex);                
            }
            return false;
        }
        /// <summary>
        /// 删除直流电压电流测量集合
        /// </summary>
        /// <param name="validationErrors">返回的错误信息</param>
        /// <param name="deleteCollection">直流电压电流测量的集合</param>
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
        ///  创建直流电压电流测量集合
        /// </summary>
        /// <param name="validationErrors">返回的错误信息</param>
        /// <param name="entitys">直流电压电流测量集合</param>
        /// <returns></returns>
        public bool EditCollection(ref ValidationErrors validationErrors, IQueryable<DC_VOLTAGE_CURRENT_MEASURE> entitys)
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
        /// 编辑一个直流电压电流测量
        /// </summary>
        /// <param name="validationErrors">返回的错误信息</param>
        /// <param name="entity">一个直流电压电流测量</param>
        /// <returns></returns>
        public bool Edit(ref ValidationErrors validationErrors, DC_VOLTAGE_CURRENT_MEASURE entity)
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
      
        public List<DC_VOLTAGE_CURRENT_MEASURE> GetAll()
        {           
            return repository.GetAll(db).ToList();          
        }   
        
        /// <summary>
        /// 根据主键获取一个直流电压电流测量
        /// </summary>
        /// <param name="id">直流电压电流测量的主键</param>
        /// <returns>一个直流电压电流测量</returns>
        public DC_VOLTAGE_CURRENT_MEASURE GetById(string id)
        {           
            return repository.GetById(db, id);           
        }


        /// <summary>
        /// 根据OVERALL_TABLEIDId，获取所有直流电压电流测量数据
        /// </summary>
        /// <param name="id">外键的主键</param>
        /// <returns></returns>
        public List<DC_VOLTAGE_CURRENT_MEASURE> GetByRefOVERALL_TABLEID(string id)
        {
            return repository.GetByRefOVERALL_TABLEID(db, id).ToList();                      
        }

        public void Dispose()
        {
           
        }
    }
}

