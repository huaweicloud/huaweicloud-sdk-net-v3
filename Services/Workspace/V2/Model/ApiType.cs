using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// API协议类型（OpenAI/Anthropic）。
    /// </summary>
    /// <value>API协议类型（OpenAI/Anthropic）。</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ApiType
    {
        /// <summary>
        /// Enum OPENAI for value: OpenAI
        /// </summary>
        [EnumMember(Value = "OpenAI")]
        OPENAI = 1,

        /// <summary>
        /// Enum ANTHROPIC for value: Anthropic
        /// </summary>
        [EnumMember(Value = "Anthropic")]
        ANTHROPIC = 2

    }

}
