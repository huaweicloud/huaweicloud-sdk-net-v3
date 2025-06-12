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
    /// **参数解释**： 声音语言。 **约束限制**： 不涉及。 **取值范围**： * UNKNOW：未知 * CN：中文 * EN：英文 * GER：德语 * fr：法语 * Kr：韩语 * por：葡萄牙语 * JPN：日语 * Ita：意大利语 * ESP：西班牙语 * DBH：东北话 * GT：港台 * GXH：广西话 * HBH：湖北话 * SXH：陕西话 * SCH：四川话 * YY：粤语 * Russian: 俄罗斯语 * Filipino: 菲律宾语 * Dutch: 荷兰语 * Indonesian: 印尼语 * Vietnamese: 越南语 * Arabic: 阿拉伯语 * Turkish: 土耳其语 * Malay: 马来语 * Thai: 泰语 * Finnish: 芬兰语
    /// </summary>
    /// <value>**参数解释**： 声音语言。 **约束限制**： 不涉及。 **取值范围**： * UNKNOW：未知 * CN：中文 * EN：英文 * GER：德语 * fr：法语 * Kr：韩语 * por：葡萄牙语 * JPN：日语 * Ita：意大利语 * ESP：西班牙语 * DBH：东北话 * GT：港台 * GXH：广西话 * HBH：湖北话 * SXH：陕西话 * SCH：四川话 * YY：粤语 * Russian: 俄罗斯语 * Filipino: 菲律宾语 * Dutch: 荷兰语 * Indonesian: 印尼语 * Vietnamese: 越南语 * Arabic: 阿拉伯语 * Turkish: 土耳其语 * Malay: 马来语 * Thai: 泰语 * Finnish: 芬兰语</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum VoiceLanguage
    {
        /// <summary>
        /// Enum UNKNOW for value: UNKNOW
        /// </summary>
        [EnumMember(Value = "UNKNOW")]
        UNKNOW = 1,

        /// <summary>
        /// Enum CN for value: CN
        /// </summary>
        [EnumMember(Value = "CN")]
        CN = 2,

        /// <summary>
        /// Enum EN for value: EN
        /// </summary>
        [EnumMember(Value = "EN")]
        EN = 3,

        /// <summary>
        /// Enum GER for value: GER
        /// </summary>
        [EnumMember(Value = "GER")]
        GER = 4,

        /// <summary>
        /// Enum FR for value: fr
        /// </summary>
        [EnumMember(Value = "fr")]
        FR = 5,

        /// <summary>
        /// Enum KR for value: Kr
        /// </summary>
        [EnumMember(Value = "Kr")]
        KR = 6,

        /// <summary>
        /// Enum POR for value: por
        /// </summary>
        [EnumMember(Value = "por")]
        POR = 7,

        /// <summary>
        /// Enum JPN for value: JPN
        /// </summary>
        [EnumMember(Value = "JPN")]
        JPN = 8,

        /// <summary>
        /// Enum ITA for value: Ita
        /// </summary>
        [EnumMember(Value = "Ita")]
        ITA = 9,

        /// <summary>
        /// Enum ESP for value: ESP
        /// </summary>
        [EnumMember(Value = "ESP")]
        ESP = 10,

        /// <summary>
        /// Enum DBH for value: DBH
        /// </summary>
        [EnumMember(Value = "DBH")]
        DBH = 11,

        /// <summary>
        /// Enum GT for value: GT
        /// </summary>
        [EnumMember(Value = "GT")]
        GT = 12,

        /// <summary>
        /// Enum GXH for value: GXH
        /// </summary>
        [EnumMember(Value = "GXH")]
        GXH = 13,

        /// <summary>
        /// Enum HBH for value: HBH
        /// </summary>
        [EnumMember(Value = "HBH")]
        HBH = 14,

        /// <summary>
        /// Enum SXH for value: SXH
        /// </summary>
        [EnumMember(Value = "SXH")]
        SXH = 15,

        /// <summary>
        /// Enum SCH for value: SCH
        /// </summary>
        [EnumMember(Value = "SCH")]
        SCH = 16,

        /// <summary>
        /// Enum YY for value: YY
        /// </summary>
        [EnumMember(Value = "YY")]
        YY = 17,

        /// <summary>
        /// Enum RUSSIAN for value: Russian
        /// </summary>
        [EnumMember(Value = "Russian")]
        RUSSIAN = 18,

        /// <summary>
        /// Enum FILIPINO for value: Filipino
        /// </summary>
        [EnumMember(Value = "Filipino")]
        FILIPINO = 19,

        /// <summary>
        /// Enum DUTCH for value: Dutch
        /// </summary>
        [EnumMember(Value = "Dutch")]
        DUTCH = 20,

        /// <summary>
        /// Enum INDONESIAN for value: Indonesian
        /// </summary>
        [EnumMember(Value = "Indonesian")]
        INDONESIAN = 21,

        /// <summary>
        /// Enum VIETNAMESE for value: Vietnamese
        /// </summary>
        [EnumMember(Value = "Vietnamese")]
        VIETNAMESE = 22,

        /// <summary>
        /// Enum ARABIC for value: Arabic
        /// </summary>
        [EnumMember(Value = "Arabic")]
        ARABIC = 23,

        /// <summary>
        /// Enum TURKISH for value: Turkish
        /// </summary>
        [EnumMember(Value = "Turkish")]
        TURKISH = 24,

        /// <summary>
        /// Enum MALAY for value: Malay
        /// </summary>
        [EnumMember(Value = "Malay")]
        MALAY = 25,

        /// <summary>
        /// Enum THAI for value: Thai
        /// </summary>
        [EnumMember(Value = "Thai")]
        THAI = 26,

        /// <summary>
        /// Enum FINNISH for value: Finnish
        /// </summary>
        [EnumMember(Value = "Finnish")]
        FINNISH = 27

    }

}
