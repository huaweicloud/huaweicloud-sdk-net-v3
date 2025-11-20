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
    /// 资源类型。 当前支持的形象资源类型如下： * 2D_DIGITAL_HUMAN_BASIC：形象制作基础版 * 2D_DIGITAL_HUMAN_ADVANCED：形象制作高级版 * 2D_DIGITAL_HUMAN_FLEXUS：形象制作FLEXUS版  当前支持的声音资源类型如下： * VOICE_BASIC: 声音制作基础版 * VOICE_MIDDLE: 声音制作进阶版 * VOICE_ADVANCE：声音制作高级版 * VOICE_THIRD_PARTY：声音制作第三方出门问问 * VOICE_THIRD_PARTY_LJZN: 声音制作第三方逻辑智能 * VOICE_FLEXUS: 声音制作Flexus版资源
    /// </summary>
    /// <value>资源类型。 当前支持的形象资源类型如下： * 2D_DIGITAL_HUMAN_BASIC：形象制作基础版 * 2D_DIGITAL_HUMAN_ADVANCED：形象制作高级版 * 2D_DIGITAL_HUMAN_FLEXUS：形象制作FLEXUS版  当前支持的声音资源类型如下： * VOICE_BASIC: 声音制作基础版 * VOICE_MIDDLE: 声音制作进阶版 * VOICE_ADVANCE：声音制作高级版 * VOICE_THIRD_PARTY：声音制作第三方出门问问 * VOICE_THIRD_PARTY_LJZN: 声音制作第三方逻辑智能 * VOICE_FLEXUS: 声音制作Flexus版资源</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum BillResourceType
    {
        /// <summary>
        /// Enum _2D_DIGITAL_HUMAN_BASIC for value: 2D_DIGITAL_HUMAN_BASIC
        /// </summary>
        [EnumMember(Value = "2D_DIGITAL_HUMAN_BASIC")]
        _2D_DIGITAL_HUMAN_BASIC = 1,

        /// <summary>
        /// Enum _2D_DIGITAL_HUMAN_ADVANCED for value: 2D_DIGITAL_HUMAN_ADVANCED
        /// </summary>
        [EnumMember(Value = "2D_DIGITAL_HUMAN_ADVANCED")]
        _2D_DIGITAL_HUMAN_ADVANCED = 2,

        /// <summary>
        /// Enum _2D_DIGITAL_HUMAN_FLEXUS for value: 2D_DIGITAL_HUMAN_FLEXUS
        /// </summary>
        [EnumMember(Value = "2D_DIGITAL_HUMAN_FLEXUS")]
        _2D_DIGITAL_HUMAN_FLEXUS = 3,

        /// <summary>
        /// Enum VOICE_BASIC for value: VOICE_BASIC
        /// </summary>
        [EnumMember(Value = "VOICE_BASIC")]
        VOICE_BASIC = 4,

        /// <summary>
        /// Enum VOICE_MIDDLE for value: VOICE_MIDDLE
        /// </summary>
        [EnumMember(Value = "VOICE_MIDDLE")]
        VOICE_MIDDLE = 5,

        /// <summary>
        /// Enum VOICE_ADVANCE for value: VOICE_ADVANCE
        /// </summary>
        [EnumMember(Value = "VOICE_ADVANCE")]
        VOICE_ADVANCE = 6,

        /// <summary>
        /// Enum VOICE_THIRD_PARTY for value: VOICE_THIRD_PARTY
        /// </summary>
        [EnumMember(Value = "VOICE_THIRD_PARTY")]
        VOICE_THIRD_PARTY = 7,

        /// <summary>
        /// Enum VOICE_THIRD_PARTY_LJZN for value: VOICE_THIRD_PARTY_LJZN
        /// </summary>
        [EnumMember(Value = "VOICE_THIRD_PARTY_LJZN")]
        VOICE_THIRD_PARTY_LJZN = 8,

        /// <summary>
        /// Enum VOICE_FLEXUS for value: VOICE_FLEXUS
        /// </summary>
        [EnumMember(Value = "VOICE_FLEXUS")]
        VOICE_FLEXUS = 9

    }

}
