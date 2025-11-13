using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CloudPond.V1.Model
{
    /// <summary>
    /// 存储类型。 - SAS：高IO - SSD：超高IO - SAS_SD：高IO(软件定义型专用) - SSD_SD：超高IO(软件定义型专用) - SAS_ARM：高IO（鲲鹏） - SSD_ARM：超高IO（鲲鹏） [- VS_SMALL_CAP：视图存储-小容量型](tag:cmcc) [- VS_MEDIUM_CAP：视图存储-中容量型](tag:cmcc) [- VS_LARGE_CAP：视图存储-大容量型](tag:cmcc) [- VS_SMALL_CAP：边缘对象存储-小容量型](tag:hws) [- VS_MEDIUM_CAP：边缘对象存储-中容量型](tag:hws) [- VS_LARGE_CAP：边缘对象存储-大容量型](tag:hws) [- CBR_STANDARD_SMALL_CAP:云备份(基础版)-小容量型](tag:hws) [- CBR_STANDARD_MEDIUM_CAP:云备份(基础版)-中容量型](tag:hws) [- CBR_STANDARD_LARGE_CAP:云备份(基础版)-大容量型](tag:hws) [- CBR_PROFESSIONAL_SMALL_CAP:云备份(专业版)-小容量型](tag:hws) [- CBR_PROFESSIONAL_MEDIUM_CAP:云备份(专业版)-中容量型](tag:hws) [- CBR_PROFESSIONAL_LARGE_CAP:云备份(专业版)-大容量型](tag:hws)
    /// </summary>
    /// <value>存储类型。 - SAS：高IO - SSD：超高IO - SAS_SD：高IO(软件定义型专用) - SSD_SD：超高IO(软件定义型专用) - SAS_ARM：高IO（鲲鹏） - SSD_ARM：超高IO（鲲鹏） [- VS_SMALL_CAP：视图存储-小容量型](tag:cmcc) [- VS_MEDIUM_CAP：视图存储-中容量型](tag:cmcc) [- VS_LARGE_CAP：视图存储-大容量型](tag:cmcc) [- VS_SMALL_CAP：边缘对象存储-小容量型](tag:hws) [- VS_MEDIUM_CAP：边缘对象存储-中容量型](tag:hws) [- VS_LARGE_CAP：边缘对象存储-大容量型](tag:hws) [- CBR_STANDARD_SMALL_CAP:云备份(基础版)-小容量型](tag:hws) [- CBR_STANDARD_MEDIUM_CAP:云备份(基础版)-中容量型](tag:hws) [- CBR_STANDARD_LARGE_CAP:云备份(基础版)-大容量型](tag:hws) [- CBR_PROFESSIONAL_SMALL_CAP:云备份(专业版)-小容量型](tag:hws) [- CBR_PROFESSIONAL_MEDIUM_CAP:云备份(专业版)-中容量型](tag:hws) [- CBR_PROFESSIONAL_LARGE_CAP:云备份(专业版)-大容量型](tag:hws)</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum StorageType
    {
        /// <summary>
        /// Enum SAS for value: SAS
        /// </summary>
        [EnumMember(Value = "SAS")]
        SAS = 1,

        /// <summary>
        /// Enum SSD for value: SSD
        /// </summary>
        [EnumMember(Value = "SSD")]
        SSD = 2,

        /// <summary>
        /// Enum SAS_SD for value: SAS_SD
        /// </summary>
        [EnumMember(Value = "SAS_SD")]
        SAS_SD = 3,

        /// <summary>
        /// Enum SSD_SD for value: SSD_SD
        /// </summary>
        [EnumMember(Value = "SSD_SD")]
        SSD_SD = 4,

        /// <summary>
        /// Enum SAS_ARM for value: SAS_ARM
        /// </summary>
        [EnumMember(Value = "SAS_ARM")]
        SAS_ARM = 5,

        /// <summary>
        /// Enum SSD_ARM for value: SSD_ARM
        /// </summary>
        [EnumMember(Value = "SSD_ARM")]
        SSD_ARM = 6,

        /// <summary>
        /// Enum VS_SMALL_CAP for value: VS_SMALL_CAP
        /// </summary>
        [EnumMember(Value = "VS_SMALL_CAP")]
        VS_SMALL_CAP = 7,

        /// <summary>
        /// Enum VS_MEDIUM_CAP for value: VS_MEDIUM_CAP
        /// </summary>
        [EnumMember(Value = "VS_MEDIUM_CAP")]
        VS_MEDIUM_CAP = 8,

        /// <summary>
        /// Enum VS_LARGE_CAP for value: VS_LARGE_CAP
        /// </summary>
        [EnumMember(Value = "VS_LARGE_CAP")]
        VS_LARGE_CAP = 9,

        /// <summary>
        /// Enum CBR_STANDARD_SMALL_CAP for value: CBR_STANDARD_SMALL_CAP
        /// </summary>
        [EnumMember(Value = "CBR_STANDARD_SMALL_CAP")]
        CBR_STANDARD_SMALL_CAP = 10,

        /// <summary>
        /// Enum CBR_STANDARD_MEDIUM_CAP for value: CBR_STANDARD_MEDIUM_CAP
        /// </summary>
        [EnumMember(Value = "CBR_STANDARD_MEDIUM_CAP")]
        CBR_STANDARD_MEDIUM_CAP = 11,

        /// <summary>
        /// Enum CBR_STANDARD_LARGE_CAP for value: CBR_STANDARD_LARGE_CAP
        /// </summary>
        [EnumMember(Value = "CBR_STANDARD_LARGE_CAP")]
        CBR_STANDARD_LARGE_CAP = 12,

        /// <summary>
        /// Enum CBR_PROFESSIONAL_SMALL_CAP for value: CBR_PROFESSIONAL_SMALL_CAP
        /// </summary>
        [EnumMember(Value = "CBR_PROFESSIONAL_SMALL_CAP")]
        CBR_PROFESSIONAL_SMALL_CAP = 13,

        /// <summary>
        /// Enum CBR_PROFESSIONAL_MEDIUM_CAP for value: CBR_PROFESSIONAL_MEDIUM_CAP
        /// </summary>
        [EnumMember(Value = "CBR_PROFESSIONAL_MEDIUM_CAP")]
        CBR_PROFESSIONAL_MEDIUM_CAP = 14,

        /// <summary>
        /// Enum CBR_PROFESSIONAL_LARGE_CAP for value: CBR_PROFESSIONAL_LARGE_CAP
        /// </summary>
        [EnumMember(Value = "CBR_PROFESSIONAL_LARGE_CAP")]
        CBR_PROFESSIONAL_LARGE_CAP = 15

    }

}
