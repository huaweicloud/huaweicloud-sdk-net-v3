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
    /// 使用的插件来源 * PLUGIN_CONFIG：插件配置 * DEFAULT：默认
    /// </summary>
    /// <value>使用的插件来源 * PLUGIN_CONFIG：插件配置 * DEFAULT：默认</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum PluginSourceEnum
    {
        /// <summary>
        /// Enum PLUGIN_CONFIG for value: PLUGIN_CONFIG
        /// </summary>
        [EnumMember(Value = "PLUGIN_CONFIG")]
        PLUGIN_CONFIG = 1,

        /// <summary>
        /// Enum DEFAULT for value: DEFAULT
        /// </summary>
        [EnumMember(Value = "DEFAULT")]
        DEFAULT = 2

    }

}
