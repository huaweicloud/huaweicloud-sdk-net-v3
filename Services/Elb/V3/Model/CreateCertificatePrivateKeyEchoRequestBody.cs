using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// This is a auto create Body Object
    /// </summary>
    public class CreateCertificatePrivateKeyEchoRequestBody 
    {

        /// <summary>
        /// **参数解释**：ELB证书的私钥回显开关。  **约束限制**：不涉及  **取值范围**： - true：开启回显，证书的列表、详情、创建和更新接口响应字段将会显示私钥内容。 - false：关闭回显，证书的所有接口响应不显私钥内容，使用脱敏内容（*****）代替。  **默认取值**：不涉及
        /// </summary>
        [JsonProperty("private_key_echo", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PrivateKeyEcho { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateCertificatePrivateKeyEchoRequestBody {\n");
            sb.Append("  privateKeyEcho: ").Append(PrivateKeyEcho).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateCertificatePrivateKeyEchoRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateCertificatePrivateKeyEchoRequestBody input)
        {
            if (input == null) return false;
            if (this.PrivateKeyEcho != input.PrivateKeyEcho || (this.PrivateKeyEcho != null && !this.PrivateKeyEcho.Equals(input.PrivateKeyEcho))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.PrivateKeyEcho != null) hashCode = hashCode * 59 + this.PrivateKeyEcho.GetHashCode();
                return hashCode;
            }
        }
    }
}
