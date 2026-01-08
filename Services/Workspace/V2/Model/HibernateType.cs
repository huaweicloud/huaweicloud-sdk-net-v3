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
    /// ECS休眠类型 - SUSPEND: 带外冷休眠 - PAUSE: 带外热休眠
    /// </summary>
    /// <value>ECS休眠类型 - SUSPEND: 带外冷休眠 - PAUSE: 带外热休眠</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum HibernateType
    {
        /// <summary>
        /// Enum SUSPEND for value: SUSPEND
        /// </summary>
        [EnumMember(Value = "SUSPEND")]
        SUSPEND = 1,

        /// <summary>
        /// Enum PAUSE for value: PAUSE
        /// </summary>
        [EnumMember(Value = "PAUSE")]
        PAUSE = 2

    }

}
