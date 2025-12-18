using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V5.Model
{
    /// <summary>
    /// 删除任务状态。
    /// </summary>
    /// <value>删除任务状态。</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum DeletionTaskStatus
    {
        /// <summary>
        /// Enum SUCCEEDED for value: succeeded
        /// </summary>
        [EnumMember(Value = "succeeded")]
        SUCCEEDED = 1,

        /// <summary>
        /// Enum IN_PROGRESS for value: in_progress
        /// </summary>
        [EnumMember(Value = "in_progress")]
        IN_PROGRESS = 2,

        /// <summary>
        /// Enum FAILED for value: failed
        /// </summary>
        [EnumMember(Value = "failed")]
        FAILED = 3,

        /// <summary>
        /// Enum NOT_STARTED for value: not_started
        /// </summary>
        [EnumMember(Value = "not_started")]
        NOT_STARTED = 4

    }

}
