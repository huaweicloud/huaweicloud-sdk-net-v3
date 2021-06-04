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
    /// 设备接入类型不返回密钥模式。
    /// </summary>
    public class AuthInfoWithoutSecret 
    {

        /// <summary>
        /// **参数说明**：指设备是否通过安全协议方式接入，默认值为true。 **取值范围**： - true：通过安全协议方式接入。 - false：通过非安全协议方式接入。非安全接入的设备存在被仿冒等安全风险，请谨慎使用。
        /// </summary>
        [JsonProperty("secure_access", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SecureAccess { get; set; }

        /// <summary>
        /// **参数说明**：设备接入的有效时间，单位：秒，默认值：0。若设备在有效时间内未接入物联网平台并激活，则平台会删除该设备的注册信息。若设置为“0”，则表示平台不会删除该设备的注册信息（建议填写为“0”）。
        /// </summary>
        [JsonProperty("timeout", NullValueHandling = NullValueHandling.Ignore)]
        public int? Timeout { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthInfoWithoutSecret {\n");
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
            return this.Equals(input as AuthInfoWithoutSecret);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AuthInfoWithoutSecret input)
        {
            if (input == null)
                return false;

            return 
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
                if (this.SecureAccess != null)
                    hashCode = hashCode * 59 + this.SecureAccess.GetHashCode();
                if (this.Timeout != null)
                    hashCode = hashCode * 59 + this.Timeout.GetHashCode();
                return hashCode;
            }
        }
    }
}
