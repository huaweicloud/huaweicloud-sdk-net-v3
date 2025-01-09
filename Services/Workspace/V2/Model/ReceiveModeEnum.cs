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
    /// 验证码接收模式 VMFA：虚拟MFA设备 HMFA：硬件MFA设备
    /// </summary>
    /// <value>验证码接收模式 VMFA：虚拟MFA设备 HMFA：硬件MFA设备</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ReceiveModeEnum
    {
        /// <summary>
        /// Enum VMFA for value: VMFA
        /// </summary>
        [EnumMember(Value = "VMFA")]
        VMFA = 1,

        /// <summary>
        /// Enum HMFA for value: HMFA
        /// </summary>
        [EnumMember(Value = "HMFA")]
        HMFA = 2

    }

}
