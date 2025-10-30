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
    /// 资源运营状态场景： ARREAR：欠费场景 POLICE：公安场景 ILLEGAL：违规场景 VERIFY：客户未实名认证冻结场景
    /// </summary>
    /// <value>资源运营状态场景： ARREAR：欠费场景 POLICE：公安场景 ILLEGAL：违规场景 VERIFY：客户未实名认证冻结场景</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum Scene
    {
        /// <summary>
        /// Enum ARREAR for value: ARREAR
        /// </summary>
        [EnumMember(Value = "ARREAR")]
        ARREAR = 1,

        /// <summary>
        /// Enum POLICE for value: POLICE
        /// </summary>
        [EnumMember(Value = "POLICE")]
        POLICE = 2,

        /// <summary>
        /// Enum ILLEGAL for value: ILLEGAL
        /// </summary>
        [EnumMember(Value = "ILLEGAL")]
        ILLEGAL = 3,

        /// <summary>
        /// Enum VERIFY for value: VERIFY
        /// </summary>
        [EnumMember(Value = "VERIFY")]
        VERIFY = 4

    }

}
