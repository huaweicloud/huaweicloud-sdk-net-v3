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
    /// 使用的大语言模型来源 * LLM_CONFIG：大语言模型配置 * DEEP_SEEK：内置的DEEPSEEK
    /// </summary>
    /// <value>使用的大语言模型来源 * LLM_CONFIG：大语言模型配置 * DEEP_SEEK：内置的DEEPSEEK</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum LlmSourceEnum
    {
        /// <summary>
        /// Enum LLM_CONFIG for value: LLM_CONFIG
        /// </summary>
        [EnumMember(Value = "LLM_CONFIG")]
        LLM_CONFIG = 1,

        /// <summary>
        /// Enum DEEP_SEEK for value: DEEP_SEEK
        /// </summary>
        [EnumMember(Value = "DEEP_SEEK")]
        DEEP_SEEK = 2

    }

}
