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
    /// 终端节点类型，取值范围: - EIP：本账号中的弹性公网IP - ECS：本账号中私网ECS实例 - ELB：本账号中私网ELB实例 - CUSTOM_IP：云外公网IP - CUSTOM_DOMAIN_NAME：云外公网域名 - CUSTOM_EIP：本Region的弹性公网IP
    /// </summary>
    /// <value>终端节点类型，取值范围: - EIP：本账号中的弹性公网IP - ECS：本账号中私网ECS实例 - ELB：本账号中私网ELB实例 - CUSTOM_IP：云外公网IP - CUSTOM_DOMAIN_NAME：云外公网域名 - CUSTOM_EIP：本Region的弹性公网IP</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum EndpointType
    {
        /// <summary>
        /// Enum EIP for value: EIP
        /// </summary>
        [EnumMember(Value = "EIP")]
        EIP = 1,

        /// <summary>
        /// Enum ECS for value: ECS
        /// </summary>
        [EnumMember(Value = "ECS")]
        ECS = 2,

        /// <summary>
        /// Enum ELB for value: ELB
        /// </summary>
        [EnumMember(Value = "ELB")]
        ELB = 3,

        /// <summary>
        /// Enum CUSTOM_IP for value: CUSTOM_IP
        /// </summary>
        [EnumMember(Value = "CUSTOM_IP")]
        CUSTOM_IP = 4,

        /// <summary>
        /// Enum CUSTOM_DOMAIN_NAME for value: CUSTOM_DOMAIN_NAME
        /// </summary>
        [EnumMember(Value = "CUSTOM_DOMAIN_NAME")]
        CUSTOM_DOMAIN_NAME = 5,

        /// <summary>
        /// Enum CUSTOM_EIP for value: CUSTOM_EIP
        /// </summary>
        [EnumMember(Value = "CUSTOM_EIP")]
        CUSTOM_EIP = 6

    }

}
