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
    /// 本端大区。云连接支持的大区有： - Chinese-Mainland（中国大陆） - Asia-Pacific（亚太） - Africa（非洲） - Western-Latin-America（拉美西） - Eastern-Latin-America（拉美东） - Northern-Latin-America（拉美北）
    /// </summary>
    /// <value>本端大区。云连接支持的大区有： - Chinese-Mainland（中国大陆） - Asia-Pacific（亚太） - Africa（非洲） - Western-Latin-America（拉美西） - Eastern-Latin-America（拉美东） - Northern-Latin-America（拉美北）</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum LocalAreaIdDef
    {
        /// <summary>
        /// Enum CHINESE_MAINLAND for value: Chinese-Mainland
        /// </summary>
        [EnumMember(Value = "Chinese-Mainland")]
        CHINESE_MAINLAND = 1,

        /// <summary>
        /// Enum ASIA_PACIFIC for value: Asia-Pacific
        /// </summary>
        [EnumMember(Value = "Asia-Pacific")]
        ASIA_PACIFIC = 2,

        /// <summary>
        /// Enum AFRICA for value: Africa
        /// </summary>
        [EnumMember(Value = "Africa")]
        AFRICA = 3,

        /// <summary>
        /// Enum WESTERN_LATIN_AMERICA for value: Western-Latin-America
        /// </summary>
        [EnumMember(Value = "Western-Latin-America")]
        WESTERN_LATIN_AMERICA = 4,

        /// <summary>
        /// Enum EASTERN_LATIN_AMERICA for value: Eastern-Latin-America
        /// </summary>
        [EnumMember(Value = "Eastern-Latin-America")]
        EASTERN_LATIN_AMERICA = 5,

        /// <summary>
        /// Enum NORTHERN_LATIN_AMERICA for value: Northern-Latin-America
        /// </summary>
        [EnumMember(Value = "Northern-Latin-America")]
        NORTHERN_LATIN_AMERICA = 6

    }

}
