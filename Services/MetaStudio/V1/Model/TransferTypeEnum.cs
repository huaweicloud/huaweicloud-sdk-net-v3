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
    /// **参数解释**： 转移类型。默认值是TRANSFER_OUT。 **约束限制**： * 只有管理员或者开了资产转移白名单租户才有权限转出资产。 * 普通租户有权限转回已接收成功的资产，转回给转移发起方。 **取值范围**： * TRANSFER_OUT: 资产转出 * TRANSFER_BACK：资产转回
    /// </summary>
    /// <value>**参数解释**： 转移类型。默认值是TRANSFER_OUT。 **约束限制**： * 只有管理员或者开了资产转移白名单租户才有权限转出资产。 * 普通租户有权限转回已接收成功的资产，转回给转移发起方。 **取值范围**： * TRANSFER_OUT: 资产转出 * TRANSFER_BACK：资产转回</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum TransferTypeEnum
    {
        /// <summary>
        /// Enum TRANSFER_OUT for value: TRANSFER_OUT
        /// </summary>
        [EnumMember(Value = "TRANSFER_OUT")]
        TRANSFER_OUT = 1,

        /// <summary>
        /// Enum TRANSFER_BACK for value: TRANSFER_BACK
        /// </summary>
        [EnumMember(Value = "TRANSFER_BACK")]
        TRANSFER_BACK = 2

    }

}
