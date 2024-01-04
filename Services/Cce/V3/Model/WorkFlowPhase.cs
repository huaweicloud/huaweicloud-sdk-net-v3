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
    /// 集群升级流程的执行状态： Init: 表示该升级流程中还未有任何任务开始运行 Running: 表示该升级流程中已有任务开始执行 Pending: 表示该升级流程中有任务执行失败 Success: 表示该升级流程中所有任务都已执行成功 Cancel: 表示该升级流程已被取消 
    /// </summary>
    /// <value>集群升级流程的执行状态： Init: 表示该升级流程中还未有任何任务开始运行 Running: 表示该升级流程中已有任务开始执行 Pending: 表示该升级流程中有任务执行失败 Success: 表示该升级流程中所有任务都已执行成功 Cancel: 表示该升级流程已被取消 </value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum WorkFlowPhase
    {
        /// <summary>
        /// Enum INIT for value: Init
        /// </summary>
        [EnumMember(Value = "Init")]
        INIT = 1,

        /// <summary>
        /// Enum RUNNING for value: Running
        /// </summary>
        [EnumMember(Value = "Running")]
        RUNNING = 2,

        /// <summary>
        /// Enum PENDING for value: Pending
        /// </summary>
        [EnumMember(Value = "Pending")]
        PENDING = 3,

        /// <summary>
        /// Enum SUCCESS for value: Success
        /// </summary>
        [EnumMember(Value = "Success")]
        SUCCESS = 4,

        /// <summary>
        /// Enum CANCEL for value: Cancel
        /// </summary>
        [EnumMember(Value = "Cancel")]
        CANCEL = 5

    }

}
