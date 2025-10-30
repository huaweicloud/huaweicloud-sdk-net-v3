using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CloudPond.V2.Model
{
    /// <summary>
    /// 运维状态说明： - FREEZE - 已冻结
    /// </summary>
    /// <value>运维状态说明： - FREEZE - 已冻结</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum OperationStatus
    {
        /// <summary>
        /// Enum FREEZE for value: FREEZE
        /// </summary>
        [EnumMember(Value = "FREEZE")]
        FREEZE = 1

    }

}
