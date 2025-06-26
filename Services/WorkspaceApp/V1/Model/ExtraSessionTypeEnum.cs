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
    /// 付费会话类型 * &#x60;GPU&#x60; - GPU规格会话 * &#x60;CPU&#x60; - 普通CPU规格会话
    /// </summary>
    /// <value>付费会话类型 * &#x60;GPU&#x60; - GPU规格会话 * &#x60;CPU&#x60; - 普通CPU规格会话</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ExtraSessionTypeEnum
    {
        /// <summary>
        /// Enum GPU for value: GPU
        /// </summary>
        [EnumMember(Value = "GPU")]
        GPU = 1,

        /// <summary>
        /// Enum CPU for value: CPU
        /// </summary>
        [EnumMember(Value = "CPU")]
        CPU = 2

    }

}
