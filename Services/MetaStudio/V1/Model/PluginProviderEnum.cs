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
    /// 插件供应商 * AMAP_WEATHER：高德天气 * BOCHA：博查
    /// </summary>
    /// <value>插件供应商 * AMAP_WEATHER：高德天气 * BOCHA：博查</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum PluginProviderEnum
    {
        /// <summary>
        /// Enum AMAP_WEATHER for value: AMAP_WEATHER
        /// </summary>
        [EnumMember(Value = "AMAP_WEATHER")]
        AMAP_WEATHER = 1,

        /// <summary>
        /// Enum BOCHA for value: BOCHA
        /// </summary>
        [EnumMember(Value = "BOCHA")]
        BOCHA = 2

    }

}
