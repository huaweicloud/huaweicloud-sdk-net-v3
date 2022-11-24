using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V2.Model
{
    /// <summary>
    /// 模板类型(custom代表默认自定义模板，system代表系统模板)
    /// </summary>
    /// <value>模板类型(custom代表默认自定义模板，system代表系统模板)</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum TemplateType
    {
        /// <summary>
        /// Enum SYSTEM for value: system
        /// </summary>
        [EnumMember(Value = "system")]
        SYSTEM = 1,

        /// <summary>
        /// Enum CUSTOM for value: custom
        /// </summary>
        [EnumMember(Value = "custom")]
        CUSTOM = 2

    }

}
