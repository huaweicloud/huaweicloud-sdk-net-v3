using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 交互对接类型 * LIVE:直播交互 * CHAT:智能交互
    /// </summary>
    /// <value>交互对接类型 * LIVE:直播交互 * CHAT:智能交互</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum RobotTypeEnum
    {
        /// <summary>
        /// Enum LIVE for value: LIVE
        /// </summary>
        [EnumMember(Value = "LIVE")]
        LIVE = 1,

        /// <summary>
        /// Enum CHAT for value: CHAT
        /// </summary>
        [EnumMember(Value = "CHAT")]
        CHAT = 2

    }

}
