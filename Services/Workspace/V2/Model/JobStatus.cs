using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 实例类型： * &#x60;INIT&#x60; - 初始化中 * &#x60;WAITING&#x60; - 等待安装结束 * &#x60;SUCCESS&#x60; - 成功 * &#x60;FAIL&#x60; - 失败
    /// </summary>
    /// <value>实例类型： * &#x60;INIT&#x60; - 初始化中 * &#x60;WAITING&#x60; - 等待安装结束 * &#x60;SUCCESS&#x60; - 成功 * &#x60;FAIL&#x60; - 失败</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum JobStatus
    {
        /// <summary>
        /// Enum INIT for value: INIT
        /// </summary>
        [EnumMember(Value = "INIT")]
        INIT = 1,

        /// <summary>
        /// Enum WAITING for value: WAITING
        /// </summary>
        [EnumMember(Value = "WAITING")]
        WAITING = 2,

        /// <summary>
        /// Enum SUCCESS for value: SUCCESS
        /// </summary>
        [EnumMember(Value = "SUCCESS")]
        SUCCESS = 3,

        /// <summary>
        /// Enum FAIL for value: FAIL
        /// </summary>
        [EnumMember(Value = "FAIL")]
        FAIL = 4

    }

}
