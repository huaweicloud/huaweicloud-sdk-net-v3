using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CloudPond.V1.Model
{
    /// <summary>
    /// 资源运营功能： DELETABLE：可删除 UNDELETABLE：不可删除
    /// </summary>
    /// <value>资源运营功能： DELETABLE：可删除 UNDELETABLE：不可删除</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum Effect
    {
        /// <summary>
        /// Enum DELETABLE for value: DELETABLE
        /// </summary>
        [EnumMember(Value = "DELETABLE")]
        DELETABLE = 1,

        /// <summary>
        /// Enum UNDELETABLE for value: UNDELETABLE
        /// </summary>
        [EnumMember(Value = "UNDELETABLE")]
        UNDELETABLE = 2

    }

}
