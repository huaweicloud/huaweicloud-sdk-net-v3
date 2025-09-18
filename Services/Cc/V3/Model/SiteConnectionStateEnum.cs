using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cc.V3.Model
{
    /// <summary>
    /// 分支网络连接状态。 - AVAILABLE （可用） - CREATING （创建中） - UPDATING （更新中） - DELETING （删除中） - FREEZING （冻结中） - UNFREEZING （解冻中） - RECOVERING （恢复中） - FAILED （失败） - FREEZED （冻结） - DELETED （已删除）
    /// </summary>
    /// <value>分支网络连接状态。 - AVAILABLE （可用） - CREATING （创建中） - UPDATING （更新中） - DELETING （删除中） - FREEZING （冻结中） - UNFREEZING （解冻中） - RECOVERING （恢复中） - FAILED （失败） - FREEZED （冻结） - DELETED （已删除）</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum SiteConnectionStateEnum
    {
        /// <summary>
        /// Enum AVAILABLE for value: AVAILABLE
        /// </summary>
        [EnumMember(Value = "AVAILABLE")]
        AVAILABLE = 1,

        /// <summary>
        /// Enum CREATING for value: CREATING
        /// </summary>
        [EnumMember(Value = "CREATING")]
        CREATING = 2,

        /// <summary>
        /// Enum UPDATING for value: UPDATING
        /// </summary>
        [EnumMember(Value = "UPDATING")]
        UPDATING = 3,

        /// <summary>
        /// Enum DELETING for value: DELETING
        /// </summary>
        [EnumMember(Value = "DELETING")]
        DELETING = 4,

        /// <summary>
        /// Enum FREEZING for value: FREEZING
        /// </summary>
        [EnumMember(Value = "FREEZING")]
        FREEZING = 5,

        /// <summary>
        /// Enum UNFREEZING for value: UNFREEZING
        /// </summary>
        [EnumMember(Value = "UNFREEZING")]
        UNFREEZING = 6,

        /// <summary>
        /// Enum RECOVERING for value: RECOVERING
        /// </summary>
        [EnumMember(Value = "RECOVERING")]
        RECOVERING = 7,

        /// <summary>
        /// Enum FAILED for value: FAILED
        /// </summary>
        [EnumMember(Value = "FAILED")]
        FAILED = 8,

        /// <summary>
        /// Enum FREEZED for value: FREEZED
        /// </summary>
        [EnumMember(Value = "FREEZED")]
        FREEZED = 9,

        /// <summary>
        /// Enum DELETED for value: DELETED
        /// </summary>
        [EnumMember(Value = "DELETED")]
        DELETED = 10

    }

}
