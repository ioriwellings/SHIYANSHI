//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Langben.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class FILE_UPLOADER
    {
        public string ID { get; set; }
        public string NAME { get; set; }
        public string PATH { get; set; }
        public string FULLPATH { get; set; }
        public string SUFFIX { get; set; }
        public Nullable<decimal> SIZE { get; set; }
        public string REMARK { get; set; }
        public string NAME2 { get; set; }
        public string PATH2 { get; set; }
        public string FULLPATH2 { get; set; }
        public string SUFFIX2 { get; set; }
        public Nullable<decimal> SIZE2 { get; set; }
        public string REMARK2 { get; set; }
        public string STATE2 { get; set; }
        public string STATE { get; set; }
        public Nullable<System.DateTime> CREATETIME { get; set; }
        public string CREATEPERSON { get; set; }
        public string CONCLUSION { get; set; }
        public string PREPARE_SCHEMEID { get; set; }
        public Nullable<System.DateTime> UPDATETIME { get; set; }
        public string UPDATEPERSON { get; set; }
    
        public virtual PREPARE_SCHEME PREPARE_SCHEME { get; set; }

        /// <summary>
        /// 批准人行号
        /// </summary>
        public int Row_PiZhunRen
        {
            get
            {
                int index = -1;
                if(!string.IsNullOrWhiteSpace(REMARK) && REMARK.Trim()!="" && REMARK.Split('_').Length>=2)
                {                   
                    try
                    {
                        index = Convert.ToInt32(REMARK.Split('|')[0].Split('_')[0]);
                    }
                    catch
                    {

                    }
                }
                return index;
            }
        }
        /// <summary>
        /// 核验员行号
        /// </summary>
        public int Row_HeYanYuan
        {
            get
            {
                int index = -1;
                if (!string.IsNullOrWhiteSpace(REMARK) && REMARK.Trim() != "" && REMARK.Split('|').Length>=2)
                {
                    try
                    {
                        index = Convert.ToInt32(REMARK.Split('|')[1].Split('_')[0]);
                    }
                    catch
                    {

                    }
                }
                if (index == -1 && Row_PiZhunRen != -1)
                {
                    index = Row_PiZhunRen + 2;
                }
                return index;
            }
        }
        /// <summary>
        /// 检定员/校准员行号
        /// </summary>
        public int Row_JianDingYuan
        {
            get
            {
                int index = -1;
                if (!string.IsNullOrWhiteSpace(REMARK) && REMARK.Trim() != "" && REMARK.Split('|').Length >= 3 && REMARK.Split('|')[2].Split('_').Length >= 2)
                {
                    try
                    {
                        index = Convert.ToInt32(REMARK.Split('|')[2].Split('_')[0]);
                    }
                    catch
                    {

                    }
                }
                if (index == -1 && Row_HeYanYuan != -1)
                {
                    index = Row_HeYanYuan + 2;
                }
                return index;
            }
        }
        /// <summary>
        /// 批准人列号
        /// </summary>
        public int Col_PiZhunRen
        {
            get
            {
                int index = -1;
                if (!string.IsNullOrWhiteSpace(REMARK) && REMARK.Trim() != "" && REMARK.Split('_').Length >= 2 && REMARK.Split('|')[1].Split('_').Length >= 2)
                {
                    try
                    {
                        index = Convert.ToInt32(REMARK.Split('|')[0].Split('_')[1]);
                    }
                    catch
                    {

                    }
                }
                return index;
            }
        }
        /// <summary>
        /// 核验员列号
        /// </summary>
        public int Col_HeYanYuan
        {
            get
            {
                int index = -1;
                if (!string.IsNullOrWhiteSpace(REMARK) && REMARK.Trim() != "" && REMARK.Split('|').Length >= 2 && REMARK.Split('|')[1].Split('_').Length>=2)
                {
                    try
                    {
                        index = Convert.ToInt32(REMARK.Split('|')[1].Split('_')[1]);
                    }
                    catch
                    {

                    }
                }
                if (index == -1 && Col_PiZhunRen != -1)
                {
                    index = Col_PiZhunRen + 2;
                }
                return index;
            }
        }
        /// <summary>
        /// 检定员/校准员列号
        /// </summary>
        public int Col_JianDingYuan
        {
            get
            {
                int index = -1;
                if (!string.IsNullOrWhiteSpace(REMARK) && REMARK.Trim() != "" && REMARK.Split('|').Length >= 3 && REMARK.Split('|')[2].Split('_').Length>=2)
                {
                    try
                    {
                        index = Convert.ToInt32(REMARK.Split('|')[2].Split('_')[1]);
                    }
                    catch
                    {

                    }
                }
                if (index == -1 && Col_HeYanYuan != -1)
                {
                    index = Col_HeYanYuan + 2;
                }
                return index;
            }
        }

    }
}
