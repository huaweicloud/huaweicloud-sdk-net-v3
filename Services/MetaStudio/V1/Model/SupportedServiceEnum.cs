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
    /// 支持的业务类型。： * VIDEO_2D：分身数字人视频制作 * LIVE_2D：分身数字人直播 * CHAT_2D：分身数字人智能交互
    /// </summary>
    /// <value>支持的业务类型。： * VIDEO_2D：分身数字人视频制作 * LIVE_2D：分身数字人直播 * CHAT_2D：分身数字人智能交互</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum SupportedServiceEnum
    {
        /// <summary>
        /// Enum VIDEO_2D for value: VIDEO_2D
        /// </summary>
        [EnumMember(Value = "VIDEO_2D")]
        VIDEO_2D = 1,

        /// <summary>
        /// Enum LIVE_2D for value: LIVE_2D
        /// </summary>
        [EnumMember(Value = "LIVE_2D")]
        LIVE_2D = 2,

        /// <summary>
        /// Enum CHAT_2D for value: CHAT_2D
        /// </summary>
        [EnumMember(Value = "CHAT_2D")]
        CHAT_2D = 3

    }

}
