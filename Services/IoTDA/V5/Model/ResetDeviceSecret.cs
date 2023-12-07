using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ResetDeviceSecret 
    {

        /// <summary>
        /// **参数说明**：设备密钥，设置该字段时平台将设备密钥重置为指定值，若不设置则由平台自动生成。 **取值范围**：长度不低于8不超过32，只允许字母、数字、下划线（_）、连接符（-）的组合。
        /// </summary>
        [JsonProperty("secret", NullValueHandling = NullValueHandling.Ignore)]
        public string Secret { get; set; }

        /// <summary>
        /// **参数说明**：是否强制断开设备的连接，当前仅限长连接。默认值false。
        /// </summary>
        [JsonProperty("force_disconnect", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ForceDisconnect { get; set; }

        /// <summary>
        /// **参数说明**：重置设备秘钥的的类型。 **取值范围**： - PRIMARY：重置主秘钥。设备秘钥鉴权优先使用的密钥，当设备接入物联网平台时，平台将优先使用主密钥进行校验。 - SECONDARY：重置辅秘钥。设备的备用密钥，当主密钥校验不通过时，会启用辅密钥校验，辅密钥与主密钥有相同的效力；辅密钥对coap协议接入的设备不生效。
        /// </summary>
        [JsonProperty("secret_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SecretType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResetDeviceSecret {\n");
            sb.Append("  secret: ").Append(Secret).Append("\n");
            sb.Append("  forceDisconnect: ").Append(ForceDisconnect).Append("\n");
            sb.Append("  secretType: ").Append(SecretType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResetDeviceSecret);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResetDeviceSecret input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Secret == input.Secret ||
                    (this.Secret != null &&
                    this.Secret.Equals(input.Secret))
                ) && 
                (
                    this.ForceDisconnect == input.ForceDisconnect ||
                    (this.ForceDisconnect != null &&
                    this.ForceDisconnect.Equals(input.ForceDisconnect))
                ) && 
                (
                    this.SecretType == input.SecretType ||
                    (this.SecretType != null &&
                    this.SecretType.Equals(input.SecretType))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Secret != null)
                    hashCode = hashCode * 59 + this.Secret.GetHashCode();
                if (this.ForceDisconnect != null)
                    hashCode = hashCode * 59 + this.ForceDisconnect.GetHashCode();
                if (this.SecretType != null)
                    hashCode = hashCode * 59 + this.SecretType.GetHashCode();
                return hashCode;
            }
        }
    }
}
