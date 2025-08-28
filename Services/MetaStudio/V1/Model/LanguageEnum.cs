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
    /// 智能交互语言 * CN：中文 * EN：英文
    /// </summary>
    /// <value>智能交互语言 * CN：中文 * EN：英文</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum LanguageEnum
    {
        /// <summary>
        /// Enum CN for value: CN
        /// </summary>
        [EnumMember(Value = "CN")]
        CN = 1,

        /// <summary>
        /// Enum EN for value: EN
        /// </summary>
        [EnumMember(Value = "EN")]
        EN = 2

    }

}
