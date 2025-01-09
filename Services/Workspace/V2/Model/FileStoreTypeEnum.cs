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
    /// 存储方式： * &#x60;OBS&#x60; -  OBS桶存储。 * &#x60;LINK&#x60; - 外部存储,使用的可访问下载链接。
    /// </summary>
    /// <value>存储方式： * &#x60;OBS&#x60; -  OBS桶存储。 * &#x60;LINK&#x60; - 外部存储,使用的可访问下载链接。</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum FileStoreTypeEnum
    {
        /// <summary>
        /// Enum OBS for value: OBS
        /// </summary>
        [EnumMember(Value = "OBS")]
        OBS = 1,

        /// <summary>
        /// Enum LINK for value: LINK
        /// </summary>
        [EnumMember(Value = "LINK")]
        LINK = 2

    }

}
