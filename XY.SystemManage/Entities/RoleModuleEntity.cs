﻿
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace XY.SystemManage.Entities
{
    /// <summary>
    /// Copyright (c) 2018 . 
    /// 作者：lk
    /// 时间：2018/9/16 0:32:34 
    /// 版本：v1.0.0
    /// 描述：UserRoleEntity
    /// </summary>
    [SugarTable("Base_RoleModule")]
    public class RoleModuleEntity 
    {

        #region 实体成员
        /// <summary>
        /// 用户关系主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public string CRowId { get; set; }
        /// <summary>
        /// 模块主键
        /// </summary>		
        public string ModuleId { get; set; }
        /// <summary>
        /// 机构ID
        /// </summary>		
        public string RoleId { get; set; }
        /// <summary>
        /// 创建日期
        /// </summary>		
        public DateTime? CreateDate { get; set; }
        /// <summary>
        /// 创建用户主键
        /// </summary>		
        public string CreateUserId { get; set; }
        /// <summary>
        /// 创建用户
        /// </summary>		
        public string CreateUserName { get; set; }

        #endregion

    }
}
