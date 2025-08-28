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
    /// 插件类型 * WEATHER_QUERY：天气查询 * WEB_SEARCH：网络搜索
    /// </summary>
    /// <value>插件类型 * WEATHER_QUERY：天气查询 * WEB_SEARCH：网络搜索</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum PluginTypeEnum
    {
        /// <summary>
        /// Enum WEATHER_QUERY for value: WEATHER_QUERY
        /// </summary>
        [EnumMember(Value = "WEATHER_QUERY")]
        WEATHER_QUERY = 1,

        /// <summary>
        /// Enum WEB_SEARCH for value: WEB_SEARCH
        /// </summary>
        [EnumMember(Value = "WEB_SEARCH")]
        WEB_SEARCH = 2

    }

}
