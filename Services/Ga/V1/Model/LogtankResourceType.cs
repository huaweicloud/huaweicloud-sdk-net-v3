using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ga.V1.Model
{
    /// <summary>
    /// 云日志的资源类型。
    /// </summary>
    /// <value>云日志的资源类型。</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum LogtankResourceType
    {
        /// <summary>
        /// Enum LISTENER for value: LISTENER
        /// </summary>
        [EnumMember(Value = "LISTENER")]
        LISTENER = 1

    }

}
