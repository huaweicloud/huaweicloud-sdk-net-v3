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
    /// 中心网络策略状态。 - AVAILABLE (可用) - CANCELING (取消中) - APPLYING (应用中) - FAILED (失败) - DELETED (已刪除)
    /// </summary>
    /// <value>中心网络策略状态。 - AVAILABLE (可用) - CANCELING (取消中) - APPLYING (应用中) - FAILED (失败) - DELETED (已刪除)</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum CentralNetworkPolicyStateEnum
    {
        /// <summary>
        /// Enum AVAILABLE for value: AVAILABLE
        /// </summary>
        [EnumMember(Value = "AVAILABLE")]
        AVAILABLE = 1,

        /// <summary>
        /// Enum CANCELING for value: CANCELING
        /// </summary>
        [EnumMember(Value = "CANCELING")]
        CANCELING = 2,

        /// <summary>
        /// Enum APPLYING for value: APPLYING
        /// </summary>
        [EnumMember(Value = "APPLYING")]
        APPLYING = 3,

        /// <summary>
        /// Enum FAILED for value: FAILED
        /// </summary>
        [EnumMember(Value = "FAILED")]
        FAILED = 4,

        /// <summary>
        /// Enum DELETED for value: DELETED
        /// </summary>
        [EnumMember(Value = "DELETED")]
        DELETED = 5

    }

}
