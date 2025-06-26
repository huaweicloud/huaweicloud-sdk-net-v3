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
    /// job状态。 * &#x60;WAITING&#x60; - 等待 * &#x60;RUNNING&#x60; - 运行中 * &#x60;SUCCESS - 完成 * &#x60;FAILED&#x60; - 失败
    /// </summary>
    /// <value>job状态。 * &#x60;WAITING&#x60; - 等待 * &#x60;RUNNING&#x60; - 运行中 * &#x60;SUCCESS - 完成 * &#x60;FAILED&#x60; - 失败</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ImageJobStatus
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
        FAILED = 4

    }

}
