using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CloudPond.V2.Model
{
    /// <summary>
    /// 服务器类型。 COMPUTE: 计算服务器 NETWORK: 网络服务器 BLOCK_STORAGE: 硬盘存储服务器
    /// </summary>
    /// <value>服务器类型。 COMPUTE: 计算服务器 NETWORK: 网络服务器 BLOCK_STORAGE: 硬盘存储服务器</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ServerType
    {
        /// <summary>
        /// Enum COMPUTE for value: COMPUTE
        /// </summary>
        [EnumMember(Value = "COMPUTE")]
        COMPUTE = 1,

        /// <summary>
        /// Enum NETWORK for value: NETWORK
        /// </summary>
        [EnumMember(Value = "NETWORK")]
        NETWORK = 2,

        /// <summary>
        /// Enum BLOCK_STORAGE for value: BLOCK_STORAGE
        /// </summary>
        [EnumMember(Value = "BLOCK_STORAGE")]
        BLOCK_STORAGE = 3

    }

}
