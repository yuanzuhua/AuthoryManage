﻿using AuthoryManage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AuthoryManage.InterfaceRepository {
    public interface IEmpRepository:IBaseRepository<Models.Emp> {
        #region 修改用户登录信息 bool UpdateLoginInfo
        /// <summary>
        /// 修改用户登录信息
        /// </summary>
        /// <param name="empInfo">用户信息</param>
        /// <param name="logInfo">登录记录信息</param>
        /// <returns></returns>
        bool UpdateLoginInfo(Emp empInfo, LoginLog logInfo);
        #endregion
        #region 修改员工是否可登录信息 bool UpdateLimitLogin
        /// <summary>
        /// 修改员工是否可登录信息
        /// </summary>
        /// <param name="empInfo">员工信息</param>
        /// <param name="operateLog">操作记录</param>
        /// <returns></returns>
        bool UpdateLimitLogin(Emp empInfo,EmpOperateLog operateLog);
        #endregion
    }
}
