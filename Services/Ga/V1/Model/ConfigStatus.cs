using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ga.V1.Model
{
    /// <summary>
    /// 配置状态，取值： - ACTIVE：运行中 - PENDING：待定 - ERROR：错误 - DELETING：正在删除
    /// </summary>
    /// <value>配置状态，取值： - ACTIVE：运行中 - PENDING：待定 - ERROR：错误 - DELETING：正在删除</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ConfigStatus
    {
        /// <summary>
        /// Enum ACTIVE for value: ACTIVE
        /// </summary>
        [EnumMember(Value = "ACTIVE")]
        ACTIVE = 1,

        /// <summary>
        /// Enum PENDING for value: PENDING
        /// </summary>
        [EnumMember(Value = "PENDING")]
        PENDING = 2,

        /// <summary>
        /// Enum ERROR for value: ERROR
        /// </summary>
        [EnumMember(Value = "ERROR")]
        ERROR = 3,

        /// <summary>
        /// Enum DELETING for value: DELETING
        /// </summary>
        [EnumMember(Value = "DELETING")]
        DELETING = 4

    }

}
