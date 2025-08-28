using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cc.V3.Model
{
    /// <summary>
    /// 审批状态。 - APPROVING (审批中) - APPROVED (已审批) - UNAPPROVED (审批未通过)
    /// </summary>
    /// <value>审批状态。 - APPROVING (审批中) - APPROVED (已审批) - UNAPPROVED (审批未通过)</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ApprovedStateEnum
    {
        /// <summary>
        /// Enum APPROVING for value: APPROVING
        /// </summary>
        [EnumMember(Value = "APPROVING")]
        APPROVING = 1,

        /// <summary>
        /// Enum APPROVED for value: APPROVED
        /// </summary>
        [EnumMember(Value = "APPROVED")]
        APPROVED = 2,

        /// <summary>
        /// Enum UNAPPROVED for value: UNAPPROVED
        /// </summary>
        [EnumMember(Value = "UNAPPROVED")]
        UNAPPROVED = 3

    }

}
