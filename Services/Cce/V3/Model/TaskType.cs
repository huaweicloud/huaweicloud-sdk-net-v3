using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// **参数解释：** 集群升级任务类型 **约束限制：** 不涉及 **取值范围：** - Cluster：集群升级任务 - PreCheck：集群升级预检查任务 - Rollback：集群升级回归任务 - Snapshot：集群升级快照任务 - PostCheck：集群升级后检查任务  **默认取值：** 不涉及 
    /// </summary>
    /// <value>**参数解释：** 集群升级任务类型 **约束限制：** 不涉及 **取值范围：** - Cluster：集群升级任务 - PreCheck：集群升级预检查任务 - Rollback：集群升级回归任务 - Snapshot：集群升级快照任务 - PostCheck：集群升级后检查任务  **默认取值：** 不涉及 </value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum TaskType
    {
        /// <summary>
        /// Enum CLUSTER for value: Cluster
        /// </summary>
        [EnumMember(Value = "Cluster")]
        CLUSTER = 1,

        /// <summary>
        /// Enum PRECHECK for value: PreCheck
        /// </summary>
        [EnumMember(Value = "PreCheck")]
        PRECHECK = 2,

        /// <summary>
        /// Enum ROLLBACK for value: Rollback
        /// </summary>
        [EnumMember(Value = "Rollback")]
        ROLLBACK = 3,

        /// <summary>
        /// Enum SNAPSHOT for value: Snapshot
        /// </summary>
        [EnumMember(Value = "Snapshot")]
        SNAPSHOT = 4,

        /// <summary>
        /// Enum POSTCHECK for value: PostCheck
        /// </summary>
        [EnumMember(Value = "PostCheck")]
        POSTCHECK = 5

    }

}
