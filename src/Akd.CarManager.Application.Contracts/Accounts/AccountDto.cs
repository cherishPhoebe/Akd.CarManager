using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Akd.CarManager.Accounts
{
    public class AccountDto : AuditedEntityDto<Guid>
    {

        /// <summary>
        /// 账户类型(0：个人，1：公司)
        /// </summary>
        public byte AccountType { get; set; }

        /// <summary>
        /// E签宝平台个人帐号ID
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// E签宝平台企业帐号ID
        /// </summary>
        public string OrgId { get; set; }

        /// <summary>
        /// 企业帐号创建人个人AccountId
        /// </summary>
        public string Creator { get; set; }

        /// <summary>
        /// 名称（个人名称/公司企业名称）
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 证件类型（个人/公司）
        /// </summary>
        public string IdType { get; set; }

        /// <summary>
        /// 证件号码(个人/公司)
        /// </summary>
        public string IdNumber { get; set; }

        /// <summary>
        /// 个人电话
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 个人邮箱
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 机构法人名称
        /// </summary>
        public string OrgLegalName { get; set; }

        /// <summary>
        /// 机构法人证件号码
        /// </summary>
        public string OrgLegalIdNumber { get; set; }

        /// <summary>
        /// 实名认证状态 0：未实名，1：已实名
        /// </summary>
        public bool? Status { get; set; } = false;

        /// <summary>
        /// 性别
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// 个人出生日期
        /// </summary>
        public DateTime? BirthDay { get; set; }

        /// <summary>
        /// 民族
        /// </summary>
        public string Nation { get; set; }

        /// <summary>
        /// 地址（个人：身份证地址，公司：注册地址）
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 营业执照类型
        /// </summary>
        public string CertType { get; set; }

        /// <summary>
        /// 企业成立日期
        /// </summary>
        public DateTime? EstablishDate { get; set; }

        /// <summary>
        /// 营业期限
        /// </summary>
        public string ValidTerm { get; set; }

        /// <summary>
        /// 经营范围
        /// </summary>
        public string Scope { get; set; }

        /// <summary>
        /// 是否公司员工(默认否)
        /// </summary>
        public bool? IsStaff { get; set; } = false;

        /// <summary>
        /// 是否在E签宝平台注销
        /// </summary>
        public bool? IsCancel { get; set; } = false;

        /// <summary>
        /// CancelTime
        /// </summary>
        public DateTime? CancelTime { get; set; }

        /// <summary>
        /// 注销人
        /// </summary>
        public string CancelBy { get; set; }

        /// <summary>
        /// 是否删除
        /// </summary>
        public bool? IsDelete { get; set; } = false;

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public string CreateBy { get; set; }

        /// <summary>
        /// 最后更新时间
        /// </summary>
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// 最后更新人
        /// </summary>
        public string UpdateBy { get; set; }

        /// <summary>
        /// 创建E签宝帐号时间
        /// </summary>
        public DateTime? SyncESignTime { get; set; }

        /// <summary>
        /// 客户拥有人
        /// </summary>
        public string OwnerUserID { get; set; }

        /// <summary>
        /// 业务系统对应用户Id
        /// </summary>
        public string AkdDbUserID { get; set; }
    }
}
