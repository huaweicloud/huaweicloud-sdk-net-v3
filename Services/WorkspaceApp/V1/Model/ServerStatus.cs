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
    /// 实例的状态： * &#x60;UNREGISTER&#x60; - 未就绪 * &#x60;REGISTERED&#x60; - 就绪状态 * &#x60;MAINTAINING&#x60; - 维护中 * &#x60;FREEZE&#x60; - 冻结 * &#x60;STOPPED&#x60; - 停止 * &#x60;NONE&#x60; - 异常状态
    /// </summary>
    /// <value>实例的状态： * &#x60;UNREGISTER&#x60; - 未就绪 * &#x60;REGISTERED&#x60; - 就绪状态 * &#x60;MAINTAINING&#x60; - 维护中 * &#x60;FREEZE&#x60; - 冻结 * &#x60;STOPPED&#x60; - 停止 * &#x60;NONE&#x60; - 异常状态</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ServerStatus
    {
        /// <summary>
        /// Enum UNREGISTER for value: UNREGISTER
        /// </summary>
        [EnumMember(Value = "UNREGISTER")]
        UNREGISTER = 1,

        /// <summary>
        /// Enum REGISTERED for value: REGISTERED
        /// </summary>
        [EnumMember(Value = "REGISTERED")]
        REGISTERED = 2,

        /// <summary>
        /// Enum MAINTAINING for value: MAINTAINING
        /// </summary>
        [EnumMember(Value = "MAINTAINING")]
        MAINTAINING = 3,

        /// <summary>
        /// Enum FREEZE for value: FREEZE
        /// </summary>
        [EnumMember(Value = "FREEZE")]
        FREEZE = 4,

        /// <summary>
        /// Enum STOPPED for value: STOPPED
        /// </summary>
        [EnumMember(Value = "STOPPED")]
        STOPPED = 5,

        /// <summary>
        /// Enum NONE for value: NONE
        /// </summary>
        [EnumMember(Value = "NONE")]
        NONE = 6

    }

}
