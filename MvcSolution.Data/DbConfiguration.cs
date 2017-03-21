/*******************************************************************************
* Copyright (C) wubo.pro
* 
* Author: dj.wong
* Create Date: 09/04/2015 11:47:14
* Description: Automated building by service@wubo.pro 
* 
* Revision History:
* Date         Author               Description
*
*********************************************************************************/

using System;
using System.Data.Entity.Migrations;

namespace MvcSolution.Data
{
    /// <summary>
    /// 数据库初始化
    /// </summary>
    internal sealed class DbConfiguration : DbMigrationsConfiguration<MvcSolutionDbContext>
    {
        private readonly DateTime _now = new DateTime(2015, 5, 1, 23, 59, 59);

        public DbConfiguration()
        {
            AutomaticMigrationsEnabled = true;//启用自动迁移
            AutomaticMigrationDataLossAllowed = true;//是否允许接受数据丢失的情况，false=不允许，会抛异常；true=允许，有可能数据会丢失

            //解决数据迁移时，ef 对 mysql 语句添加 dbo 报错的问题
            //SetSqlGenerator("MySql.Data.MySqlClient", new MyCodeGenerator());
        }

        protected override void Seed(MvcSolutionDbContext context)
        {
            base.Seed(context);
        }
    }
}
