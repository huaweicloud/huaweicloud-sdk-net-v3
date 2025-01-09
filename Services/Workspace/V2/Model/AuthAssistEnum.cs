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
    /// 认证类型。 OTP：OTP辅助认证 RADIUS: RADIUS认证
    /// </summary>
    /// <value>认证类型。 OTP：OTP辅助认证 RADIUS: RADIUS认证</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum AuthAssistEnum
    {
        /// <summary>
        /// Enum OTP for value: OTP
        /// </summary>
        [EnumMember(Value = "OTP")]
        OTP = 1,

        /// <summary>
        /// Enum RADIUS_GATEWAY for value: RADIUS_GATEWAY
        /// </summary>
        [EnumMember(Value = "RADIUS_GATEWAY")]
        RADIUS_GATEWAY = 2,

        /// <summary>
        /// Enum RADIUS for value: RADIUS
        /// </summary>
        [EnumMember(Value = "RADIUS")]
        RADIUS = 3

    }

}
