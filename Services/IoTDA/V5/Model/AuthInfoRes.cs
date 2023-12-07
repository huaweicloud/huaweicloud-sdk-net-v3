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
    /// 设备接入类型。
    /// </summary>
    public class AuthInfoRes 
    {

        /// <summary>
        /// **参数说明**：鉴权类型。注意：不填写auth_type默认为密钥认证接入方式(SECRET)。 **取值范围**： - SECRET:使用密钥认证接入方式。 - CERTIFICATES:使用证书认证接入方式。
        /// </summary>
        [JsonProperty("auth_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthType { get; set; }

        /// <summary>
        /// **参数说明**：设备密钥，认证类型使用密钥认证接入(SECRET)可填写该字段。注意：NB设备密钥由于协议特殊性，只支持十六进制密钥接入；查询设备列表接口不返回该参数。 **取值范围**：长度不低于8不超过32，只允许字母、数字、下划线（_）、连接符（-）的组合。
        /// </summary>
        [JsonProperty("secret", NullValueHandling = NullValueHandling.Ignore)]
        public string Secret { get; set; }

        /// <summary>
        /// **参数说明**：设备备用密钥，认证类型使用密钥认证接入(SECRET)该字段有效，当主密钥校验不通过时，会启用辅密钥校验，辅密钥与主密钥有相同的效力；辅密钥对coap协议接入的设备不生效。注意：NB设备密钥由于协议特殊性，只支持十六进制密钥接入；查询设备列表接口不返回该参数。 **取值范围**：长度不低于8不超过32，只允许字母、数字、下划线（_）、连接符（-）的组合。
        /// </summary>
        [JsonProperty("secondary_secret", NullValueHandling = NullValueHandling.Ignore)]
        public string SecondarySecret { get; set; }

        /// <summary>
        /// **参数说明**：证书指纹，认证类型使用证书认证接入(CERTIFICATES)该字段有效，注册设备时不填写该字段则取第一次设备接入时的证书指纹。 **取值范围**：长度为40的十六进制字符串或者长度为64的十六进制字符串。
        /// </summary>
        [JsonProperty("fingerprint", NullValueHandling = NullValueHandling.Ignore)]
        public string Fingerprint { get; set; }

        /// <summary>
        /// **参数说明**：证书备用指纹，认证类型使用证书认证接入(CERTIFICATES)该字段有效，当主指纹校验不通过时，会启用辅指纹校验，辅指纹与主指纹有相同的效力。 **取值范围**：长度为40的十六进制字符串或者长度为64的十六进制字符串。
        /// </summary>
        [JsonProperty("secondary_fingerprint", NullValueHandling = NullValueHandling.Ignore)]
        public string SecondaryFingerprint { get; set; }

        /// <summary>
        /// **参数说明**：指设备是否通过安全协议方式接入。 **取值范围**： - true：通过安全协议方式接入。 - false：通过非安全协议方式接入。非安全接入的设备存在被仿冒等安全风险，请谨慎使用。
        /// </summary>
        [JsonProperty("secure_access", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SecureAccess { get; set; }

        /// <summary>
        /// **参数说明**：设备接入的有效时间，单位：秒，默认值：0 若设备在有效时间内未接入物联网平台并激活，则平台会删除该设备的注册信息。若设置为“0”，则表示平台不会删除该设备的注册信息（建议填写为“0”）。 注意：该参数只对直连设备生效。
        /// </summary>
        [JsonProperty("timeout", NullValueHandling = NullValueHandling.Ignore)]
        public int? Timeout { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthInfoRes {\n");
            sb.Append("  authType: ").Append(AuthType).Append("\n");
            sb.Append("  secret: ").Append(Secret).Append("\n");
            sb.Append("  secondarySecret: ").Append(SecondarySecret).Append("\n");
            sb.Append("  fingerprint: ").Append(Fingerprint).Append("\n");
            sb.Append("  secondaryFingerprint: ").Append(SecondaryFingerprint).Append("\n");
            sb.Append("  secureAccess: ").Append(SecureAccess).Append("\n");
            sb.Append("  timeout: ").Append(Timeout).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AuthInfoRes);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AuthInfoRes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AuthType == input.AuthType ||
                    (this.AuthType != null &&
                    this.AuthType.Equals(input.AuthType))
                ) && 
                (
                    this.Secret == input.Secret ||
                    (this.Secret != null &&
                    this.Secret.Equals(input.Secret))
                ) && 
                (
                    this.SecondarySecret == input.SecondarySecret ||
                    (this.SecondarySecret != null &&
                    this.SecondarySecret.Equals(input.SecondarySecret))
                ) && 
                (
                    this.Fingerprint == input.Fingerprint ||
                    (this.Fingerprint != null &&
                    this.Fingerprint.Equals(input.Fingerprint))
                ) && 
                (
                    this.SecondaryFingerprint == input.SecondaryFingerprint ||
                    (this.SecondaryFingerprint != null &&
                    this.SecondaryFingerprint.Equals(input.SecondaryFingerprint))
                ) && 
                (
                    this.SecureAccess == input.SecureAccess ||
                    (this.SecureAccess != null &&
                    this.SecureAccess.Equals(input.SecureAccess))
                ) && 
                (
                    this.Timeout == input.Timeout ||
                    (this.Timeout != null &&
                    this.Timeout.Equals(input.Timeout))
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
                if (this.AuthType != null)
                    hashCode = hashCode * 59 + this.AuthType.GetHashCode();
                if (this.Secret != null)
                    hashCode = hashCode * 59 + this.Secret.GetHashCode();
                if (this.SecondarySecret != null)
                    hashCode = hashCode * 59 + this.SecondarySecret.GetHashCode();
                if (this.Fingerprint != null)
                    hashCode = hashCode * 59 + this.Fingerprint.GetHashCode();
                if (this.SecondaryFingerprint != null)
                    hashCode = hashCode * 59 + this.SecondaryFingerprint.GetHashCode();
                if (this.SecureAccess != null)
                    hashCode = hashCode * 59 + this.SecureAccess.GetHashCode();
                if (this.Timeout != null)
                    hashCode = hashCode * 59 + this.Timeout.GetHashCode();
                return hashCode;
            }
        }
    }
}
