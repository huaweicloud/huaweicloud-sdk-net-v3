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
    /// 商品状态说明：   - TESTING - 测试   - ONSALE - 在售   - SUSPENDED - 已停售   - RETIREMENT - 产品退出
    /// </summary>
    /// <value>商品状态说明：   - TESTING - 测试   - ONSALE - 在售   - SUSPENDED - 已停售   - RETIREMENT - 产品退出</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum OfferingStatus
    {
        /// <summary>
        /// Enum TESTING for value: TESTING
        /// </summary>
        [EnumMember(Value = "TESTING")]
        TESTING = 1,

        /// <summary>
        /// Enum ONSALE for value: ONSALE
        /// </summary>
        [EnumMember(Value = "ONSALE")]
        ONSALE = 2,

        /// <summary>
        /// Enum SUSPENDED for value: SUSPENDED
        /// </summary>
        [EnumMember(Value = "SUSPENDED")]
        SUSPENDED = 3,

        /// <summary>
        /// Enum RETIREMENT for value: RETIREMENT
        /// </summary>
        [EnumMember(Value = "RETIREMENT")]
        RETIREMENT = 4

    }

}
