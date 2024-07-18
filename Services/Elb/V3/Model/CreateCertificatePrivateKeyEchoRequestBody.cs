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
        /// 证书回显开关，项目粒度的,默认情况下,\&quot;private_key_echo\&quot;是true,证书的返回体中展示私钥。 当值为false时,证书的返回体中不展示私钥。
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
            if (input == null)
                return false;

            return 
                (
                    this.PrivateKeyEcho == input.PrivateKeyEcho ||
                    (this.PrivateKeyEcho != null &&
                    this.PrivateKeyEcho.Equals(input.PrivateKeyEcho))
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
                if (this.PrivateKeyEcho != null)
                    hashCode = hashCode * 59 + this.PrivateKeyEcho.GetHashCode();
                return hashCode;
            }
        }
    }
}
