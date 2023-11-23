using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dds.V3.Model
{
    /// <summary>
    /// LTS日志类型，不能为空，具有以下日志类型。 - audit_log
    /// </summary>
    /// <value>LTS日志类型，不能为空，具有以下日志类型。 - audit_log</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum LtsLogType
    {
        /// <summary>
        /// Enum AUDIT_LOG for value: audit_log
        /// </summary>
        [EnumMember(Value = "audit_log")]
        AUDIT_LOG = 1

    }

}
