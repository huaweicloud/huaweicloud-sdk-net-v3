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
    /// 集群升级状态： Init: 任务初始状态 Queuing: 任务已进入执行队列 Running: 任务开始执行 Success: 任务执行成功 Failed: 任务执行失败 
    /// </summary>
    /// <value>集群升级状态： Init: 任务初始状态 Queuing: 任务已进入执行队列 Running: 任务开始执行 Success: 任务执行成功 Failed: 任务执行失败 </value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum UpgradeWorkflowTaskStatus
    {
        /// <summary>
        /// Enum INIT for value: Init
        /// </summary>
        [EnumMember(Value = "Init")]
        INIT = 1,

        /// <summary>
        /// Enum QUEUING for value: Queuing
        /// </summary>
        [EnumMember(Value = "Queuing")]
        QUEUING = 2,

        /// <summary>
        /// Enum RUNNING for value: Running
        /// </summary>
        [EnumMember(Value = "Running")]
        RUNNING = 3,

        /// <summary>
        /// Enum SUCCESS for value: Success
        /// </summary>
        [EnumMember(Value = "Success")]
        SUCCESS = 4,

        /// <summary>
        /// Enum FAILED for value: Failed
        /// </summary>
        [EnumMember(Value = "Failed")]
        FAILED = 5

    }

}
