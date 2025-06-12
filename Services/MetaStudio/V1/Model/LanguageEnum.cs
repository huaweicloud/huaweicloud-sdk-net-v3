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
    /// 智能交互语言 * zh_CN：简体中文（已下线，请使用CN） * en_US：英语（已下线，请使用EN） * CN：中文 * EN：英文 * ESP：西班牙语（仅海外站点支持） * por：葡萄牙语（仅海外站点支持） * Arabic：阿拉伯语（仅海外站点支持） * Thai：泰语（仅海外站点支持）
    /// </summary>
    /// <value>智能交互语言 * zh_CN：简体中文（已下线，请使用CN） * en_US：英语（已下线，请使用EN） * CN：中文 * EN：英文 * ESP：西班牙语（仅海外站点支持） * por：葡萄牙语（仅海外站点支持） * Arabic：阿拉伯语（仅海外站点支持） * Thai：泰语（仅海外站点支持）</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum LanguageEnum
    {
        /// <summary>
        /// Enum ZH_CN for value: zh_CN
        /// </summary>
        [EnumMember(Value = "zh_CN")]
        ZH_CN = 1,

        /// <summary>
        /// Enum EN_US for value: en_US
        /// </summary>
        [EnumMember(Value = "en_US")]
        EN_US = 2,

        /// <summary>
        /// Enum CN for value: CN
        /// </summary>
        [EnumMember(Value = "CN")]
        CN = 3,

        /// <summary>
        /// Enum EN for value: EN
        /// </summary>
        [EnumMember(Value = "EN")]
        EN = 4,

        /// <summary>
        /// Enum ESP for value: ESP
        /// </summary>
        [EnumMember(Value = "ESP")]
        ESP = 5,

        /// <summary>
        /// Enum POR for value: por
        /// </summary>
        [EnumMember(Value = "por")]
        POR = 6,

        /// <summary>
        /// Enum ARABIC for value: Arabic
        /// </summary>
        [EnumMember(Value = "Arabic")]
        ARABIC = 7,

        /// <summary>
        /// Enum THAI for value: Thai
        /// </summary>
        [EnumMember(Value = "Thai")]
        THAI = 8

    }

}
