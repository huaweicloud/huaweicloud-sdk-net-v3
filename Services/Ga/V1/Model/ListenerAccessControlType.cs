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
    /// 访问控制策略类型,即黑名单还是白名单, 取值： - BLACK：黑名单 - WHITE：白名单
    /// </summary>
    /// <value>访问控制策略类型,即黑名单还是白名单, 取值： - BLACK：黑名单 - WHITE：白名单</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ListenerAccessControlType
    {
        /// <summary>
        /// Enum BLACK for value: BLACK
        /// </summary>
        [EnumMember(Value = "BLACK")]
        BLACK = 1,

        /// <summary>
        /// Enum WHITE for value: WHITE
        /// </summary>
        [EnumMember(Value = "WHITE")]
        WHITE = 2

    }

}
