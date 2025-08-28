using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cc.V3.Model
{
    /// <summary>
    /// 冻结效果。 - RELEASABLE（冻结可释放） - UNRELEASABLE（冻结不可释放）
    /// </summary>
    /// <value>冻结效果。 - RELEASABLE（冻结可释放） - UNRELEASABLE（冻结不可释放）</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum FrozenEffectEnum
    {
        /// <summary>
        /// Enum RELEASABLE for value: RELEASABLE
        /// </summary>
        [EnumMember(Value = "RELEASABLE")]
        RELEASABLE = 1,

        /// <summary>
        /// Enum UNRELEASABLE for value: UNRELEASABLE
        /// </summary>
        [EnumMember(Value = "UNRELEASABLE")]
        UNRELEASABLE = 2

    }

}
