using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class User 
    {

        /// <summary>
        /// 客户端证书。 
        /// </summary>
        [JsonProperty("client-certificate-data", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientCertificateData { get; set; }

        /// <summary>
        /// 包含来自TLS客户端密钥文件的PEM编码数据。 
        /// </summary>
        [JsonProperty("client-key-data", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientKeyData { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class User {\n");
            sb.Append("  clientCertificateData: ").Append(ClientCertificateData).Append("\n");
            sb.Append("  clientKeyData: ").Append(ClientKeyData).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as User);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(User input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClientCertificateData == input.ClientCertificateData ||
                    (this.ClientCertificateData != null &&
                    this.ClientCertificateData.Equals(input.ClientCertificateData))
                ) && 
                (
                    this.ClientKeyData == input.ClientKeyData ||
                    (this.ClientKeyData != null &&
                    this.ClientKeyData.Equals(input.ClientKeyData))
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
                if (this.ClientCertificateData != null)
                    hashCode = hashCode * 59 + this.ClientCertificateData.GetHashCode();
                if (this.ClientKeyData != null)
                    hashCode = hashCode * 59 + this.ClientKeyData.GetHashCode();
                return hashCode;
            }
        }
    }
}
