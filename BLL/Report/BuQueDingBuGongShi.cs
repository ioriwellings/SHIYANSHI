﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Langben.BLL.Report
{
    /// <summary>
    /// 自动计算不确定度公式
    /// </summary>
    public class BuQueDingBuGongShi
    {
        /// <summary>
        /// 获取计算不确定度
        /// </summary>
        /// <param name="RuleID">检测项ID</param>
        /// <param name="ShuChuShiJiZhi">输出实际值、显示值</param>
        /// <param name="ShuChuShiJiZhiDanWei">输出实际值单位、显示值单位</param>
        /// <param name="LiangCheng">量程</param>
        /// <param name="K"></param>
        /// <param name="XuanYongDianZu">选用电阻</param>
        /// <returns></returns>
        public static string GetBuQueDingDu(string RuleID, string ShuChuShiJiZhi, string ShuChuShiJiZhiDanWei, string LiangCheng, string K, string XuanYongDianZu)
        {
            if (!string.IsNullOrWhiteSpace(ShuChuShiJiZhi))
            {
                return "10.123";
            }
            else
            {
                return "";
            }
        }
    }
}