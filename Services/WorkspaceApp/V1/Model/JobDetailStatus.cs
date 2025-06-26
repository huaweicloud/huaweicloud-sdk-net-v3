using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// job详情的状态 * &#x60;WAITING&#x60; - 等待 * &#x60;RUNNING&#x60; - 运行中 * &#x60;SUCCESS&#x60; - 成功 * &#x60;FAILED&#x60; - 失败 * &#x60;ABNORMAL&#x60; - 异常 * &#x60;ROLLBACK&#x60; - 回滚中 * &#x60;ABORTING&#x60; - 终止中
    /// </summary>
    /// <value>job详情的状态 * &#x60;WAITING&#x60; - 等待 * &#x60;RUNNING&#x60; - 运行中 * &#x60;SUCCESS&#x60; - 成功 * &#x60;FAILED&#x60; - 失败 * &#x60;ABNORMAL&#x60; - 异常 * &#x60;ROLLBACK&#x60; - 回滚中 * &#x60;ABORTING&#x60; - 终止中</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum JobDetailStatus
    {
        /// <summary>
        /// Enum WAITING for value: WAITING
        /// </summary>
        [EnumMember(Value = "WAITING")]
        WAITING = 1,

        /// <summary>
        /// Enum RUNNING for value: RUNNING
        /// </summary>
        [EnumMember(Value = "RUNNING")]
        RUNNING = 2,

        /// <summary>
        /// Enum SUCCESS for value: SUCCESS
        /// </summary>
        [EnumMember(Value = "SUCCESS")]
        SUCCESS = 3,

        /// <summary>
        /// Enum FAILED for value: FAILED
        /// </summary>
        [EnumMember(Value = "FAILED")]
        FAILED = 4,

        /// <summary>
        /// Enum ABNORMAL for value: ABNORMAL
        /// </summary>
        [EnumMember(Value = "ABNORMAL")]
        ABNORMAL = 5,

        /// <summary>
        /// Enum ROLLBACK for value: ROLLBACK
        /// </summary>
        [EnumMember(Value = "ROLLBACK")]
        ROLLBACK = 6,

        /// <summary>
        /// Enum ABORTING for value: ABORTING
        /// </summary>
        [EnumMember(Value = "ABORTING")]
        ABORTING = 7

    }

}
