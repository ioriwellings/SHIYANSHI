﻿using System;
using System.Collections.Generic;
using System.Linq;

using Common;
using Langben.DAL;
using Langben.BLL;
using System.Web.Mvc;
using System.Text;
using System.EnterpriseServices;
using System.Configuration;
using Models;

namespace Langben.App.Controllers
{
    /// <summary>
    /// 报告打印
    /// </summary>
    public class VBAOGAODAYINController : BaseController
    {

        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        [SupportFilter]
        public ActionResult Index()
        {
        
            return View();
        }
           
        /// <summary>
        /// 异步加载数据
        /// </summary>
        /// <param name="page">页码</param>
        /// <param name="rows">每页显示的行数</param>
        /// <param name="order">排序字段</param>
        /// <param name="sort">升序asc（默认）还是降序desc</param>
        /// <param name="search">查询条件</param>
        /// <returns></returns>
        [HttpPost]
        [SupportFilter]
        public JsonResult GetData(string id, int page, int rows, string order, string sort, string search)
        {

            int total = 0;
            List<VBAOGAODAYIN> queryData = m_BLL.GetByParam(id, page, rows, order, sort, search, ref total);
            return Json(new datagrid
            {
                total = total,
                rows = queryData.Select(s => new
                {
                    ID = s.ID
					,REPORTNUMBER = s.REPORTNUMBER
					,ORDER_NUMBER = s.ORDER_NUMBER
					,APPLIANCE_NAME = s.APPLIANCE_NAME
					,MODEL = s.MODEL
					,FACTORY_NUM = s.FACTORY_NUM
					,CERTIFICATE_ENTERPRISE = s.CERTIFICATE_ENTERPRISE
					,CUSTOMER_SPECIFIC_REQUIREMENTS = s.CUSTOMER_SPECIFIC_REQUIREMENTS
					,CERTIFICATE_CATEGORY = s.CERTIFICATE_CATEGORY
					,QUALIFICATIONS = s.QUALIFICATIONS
					,CONCLUSION_EXPLAIN = s.CONCLUSION_EXPLAIN
					,CONCLUSION = s.CONCLUSION
					,UNDERTAKE_LABORATORYID = s.UNDERTAKE_LABORATORYID
					,APPROVALDATE = s.APPROVALDATE
					,BAR_CODE_NUM = s.BAR_CODE_NUM
					,PRINTSTATUS = s.PRINTSTATUS
					
                }

                    )
            });
        }


        IBLL.IVBAOGAODAYINBLL m_BLL;

        ValidationErrors validationErrors = new ValidationErrors();

        public VBAOGAODAYINController()
            : this(new VBAOGAODAYINBLL()) { }

        public VBAOGAODAYINController(VBAOGAODAYINBLL bll)
        {
            m_BLL = bll;
        }
      
    }
}


