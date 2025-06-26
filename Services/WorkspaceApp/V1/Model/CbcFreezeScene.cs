using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 更新云服务状态的业务场景，默认&#x60;ARREAR&#x60;。 * &#x60;ARREAR&#x60; - 欠费场景；为正常的运营业务场景，包括包周期资源到期、按需资源扣费失败。 * &#x60;POLICE&#x60; - 公安冻结场景。 * &#x60;ILLEGAL&#x60; - 违规冻结场景。 * &#x60;VERIFY&#x60; - 客户未实名认证冻结场景。 * &#x60;PARTNER&#x60; - 合作伙伴冻结（合作伙伴冻结子客户资源）。
    /// </summary>
    /// <value>更新云服务状态的业务场景，默认&#x60;ARREAR&#x60;。 * &#x60;ARREAR&#x60; - 欠费场景；为正常的运营业务场景，包括包周期资源到期、按需资源扣费失败。 * &#x60;POLICE&#x60; - 公安冻结场景。 * &#x60;ILLEGAL&#x60; - 违规冻结场景。 * &#x60;VERIFY&#x60; - 客户未实名认证冻结场景。 * &#x60;PARTNER&#x60; - 合作伙伴冻结（合作伙伴冻结子客户资源）。</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum CbcFreezeScene
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
        VERIFY = 4,

        /// <summary>
        /// Enum PARTNER for value: PARTNER
        /// </summary>
        [EnumMember(Value = "PARTNER")]
        PARTNER = 5

    }

}
