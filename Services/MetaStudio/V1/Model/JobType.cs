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
    /// 训练类型。 * BASIC: 基础版(20句话) * MIDDLE: 进阶版(100句话) * ADVANCE: 高级版 * THIRD_PARTY: 第三方出门问问训练版 * THIRD_PARTY_LJZN: 第三方逻辑智能训练版 * FLEXUS: Flexus版- --用的是大模型特征提取
    /// </summary>
    /// <value>训练类型。 * BASIC: 基础版(20句话) * MIDDLE: 进阶版(100句话) * ADVANCE: 高级版 * THIRD_PARTY: 第三方出门问问训练版 * THIRD_PARTY_LJZN: 第三方逻辑智能训练版 * FLEXUS: Flexus版- --用的是大模型特征提取</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum JobType
    {
        /// <summary>
        /// Enum BASIC for value: BASIC
        /// </summary>
        [EnumMember(Value = "BASIC")]
        BASIC = 1,

        /// <summary>
        /// Enum MIDDLE for value: MIDDLE
        /// </summary>
        [EnumMember(Value = "MIDDLE")]
        MIDDLE = 2,

        /// <summary>
        /// Enum ADVANCE for value: ADVANCE
        /// </summary>
        [EnumMember(Value = "ADVANCE")]
        ADVANCE = 3,

        /// <summary>
        /// Enum THIRD_PARTY for value: THIRD_PARTY
        /// </summary>
        [EnumMember(Value = "THIRD_PARTY")]
        THIRD_PARTY = 4,

        /// <summary>
        /// Enum THIRD_PARTY_LJZN for value: THIRD_PARTY_LJZN
        /// </summary>
        [EnumMember(Value = "THIRD_PARTY_LJZN")]
        THIRD_PARTY_LJZN = 5,

        /// <summary>
        /// Enum FLEXUS for value: FLEXUS
        /// </summary>
        [EnumMember(Value = "FLEXUS")]
        FLEXUS = 6

    }

}
