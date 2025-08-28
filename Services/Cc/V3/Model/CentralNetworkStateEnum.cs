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
    /// 中心网络状态。 - AVAILABLE (可用) - UPDATING (处理中) - FAILED (失败) - CREATING (创建中) - DELETING (删除中) - DELETED (已刪除) - RESTORING (恢复中)
    /// </summary>
    /// <value>中心网络状态。 - AVAILABLE (可用) - UPDATING (处理中) - FAILED (失败) - CREATING (创建中) - DELETING (删除中) - DELETED (已刪除) - RESTORING (恢复中)</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum CentralNetworkStateEnum
    {
        /// <summary>
        /// Enum AVAILABLE for value: AVAILABLE
        /// </summary>
        [EnumMember(Value = "AVAILABLE")]
        AVAILABLE = 1,

        /// <summary>
        /// Enum UPDATING for value: UPDATING
        /// </summary>
        [EnumMember(Value = "UPDATING")]
        UPDATING = 2,

        /// <summary>
        /// Enum FAILED for value: FAILED
        /// </summary>
        [EnumMember(Value = "FAILED")]
        FAILED = 3,

        /// <summary>
        /// Enum CREATING for value: CREATING
        /// </summary>
        [EnumMember(Value = "CREATING")]
        CREATING = 4,

        /// <summary>
        /// Enum DELETING for value: DELETING
        /// </summary>
        [EnumMember(Value = "DELETING")]
        DELETING = 5,

        /// <summary>
        /// Enum DELETED for value: DELETED
        /// </summary>
        [EnumMember(Value = "DELETED")]
        DELETED = 6,

        /// <summary>
        /// Enum RESTORING for value: RESTORING
        /// </summary>
        [EnumMember(Value = "RESTORING")]
        RESTORING = 7

    }

}
