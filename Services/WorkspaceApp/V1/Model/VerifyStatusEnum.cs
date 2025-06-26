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
    /// 审核状态： * &#x60;VERIFYING&#x60; - 审核中 * &#x60;VERIFY_PASS&#x60; - 审核通过 * &#x60;Verify_FAIL&#x60; - 审核不通过
    /// </summary>
    /// <value>审核状态： * &#x60;VERIFYING&#x60; - 审核中 * &#x60;VERIFY_PASS&#x60; - 审核通过 * &#x60;Verify_FAIL&#x60; - 审核不通过</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum VerifyStatusEnum
    {
        /// <summary>
        /// Enum VERIFYING for value: VERIFYING
        /// </summary>
        [EnumMember(Value = "VERIFYING")]
        VERIFYING = 1,

        /// <summary>
        /// Enum VERIFY_PASS for value: VERIFY_PASS
        /// </summary>
        [EnumMember(Value = "VERIFY_PASS")]
        VERIFY_PASS = 2,

        /// <summary>
        /// Enum VERIFY_FAIL for value: Verify_FAIL
        /// </summary>
        [EnumMember(Value = "Verify_FAIL")]
        VERIFY_FAIL = 3

    }

}
