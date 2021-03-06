﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Util.Applications.Dtos;
using Util.Biz.Enums;
using Util.Ui.Attributes;

namespace Donau.Services.Dtos.Customers {
    /// <summary>
    /// 客户数据传输对象
    /// </summary>
    [DataContract]
    [Model("model")]
    public class CustomersDto : DtoBase {
        /// <summary>
        /// 客户名称
        /// </summary>
        [Required(ErrorMessage = "客户名称不能为空")]
        [StringLength( 20, ErrorMessage = "客户名称输入过长，不能超过20位" )]
        [Display( Name = "客户名称" )]
        [DataMember]
        public string Name { get; set; }
        
        /// <summary>
        /// 昵称
        /// </summary>
        [StringLength( 30, ErrorMessage = "昵称输入过长，不能超过30位" )]
        [Display( Name = "昵称" )]
        [DataMember]
        public string Nickname { get; set; }
        
        /// <summary>
        /// 余额
        /// </summary>
        [DataMember]
        public string Balance { get; set; }
        
        /// <summary>
        /// 性别
        /// </summary>
        [Display( Name = "性别" )]
        [DataMember]
        public Gender Gender { get; set; }


        /// <summary>
        /// 性别
        /// </summary>
        [Display( Name = "性别" )]
        [DataMember]
        public bool IsGender { get; set; }

        /// <summary>
        /// 民族
        /// </summary>
        [Display( Name = "民族" )]
        [Required(ErrorMessage = "必须选择一个民族" )]
        [DataMember]
        public Nation Nation { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [StringLength( 20, ErrorMessage = "联系电话输入过长，不能超过20位" )]
        [Display( Name = "联系电话" )]
        [DataMember]
        public string Tel { get; set; }
        
        /// <summary>
        /// 手机号
        /// </summary>
        [StringLength( 20, ErrorMessage = "手机号输入过长，不能超过20位" )]
        [Display( Name = "手机号" )]
        [DataMember]
        public string Mobile { get; set; }
        
        /// <summary>
        /// 电子邮件
        /// </summary>
        [StringLength( 100, ErrorMessage = "电子邮件输入过长，不能超过100位" )]
        [Display( Name = "电子邮件" )]
        [DataMember]
        public string Email { get; set; }
        
        /// <summary>
        /// 创建时间
        /// </summary>
        [Display( Name = "创建时间" )]
        [DataMember]
        public DateTime? CreationTime { get; set; }
        
        /// <summary>
        /// 创建人
        /// </summary>
        [Display( Name = "创建人" )]
        [DataMember]
        public Guid? CreatorId { get; set; }
        
        /// <summary>
        /// 最后修改时间
        /// </summary>
        [Display( Name = "最后修改时间" )]
        [DataMember]
        public DateTime? LastModificationTime { get; set; }
        
        /// <summary>
        /// 最后修改人
        /// </summary>
        [Display( Name = "最后修改人" )]
        [DataMember]
        public Guid? LastModifierId { get; set; }
        
        /// <summary>
        /// 版本号
        /// </summary>
        [Display( Name = "版本号" )]
        [DataMember]
        public Byte[] Version { get; set; }
        
    }
}
