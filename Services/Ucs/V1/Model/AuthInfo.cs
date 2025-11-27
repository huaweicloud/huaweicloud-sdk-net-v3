using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ucs.V1.Model
{
    /// <summary>
    /// 用户认证信息
    /// </summary>
    public class AuthInfo 
    {

        /// <summary>
        /// 客户端证书
        /// </summary>
        [JsonProperty("client-certificate-data", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientCertificateData { get; set; }

        /// <summary>
        /// 包含来自TLS客户端密钥文件的PEM编码数据
        /// </summary>
        [JsonProperty("client-key-data", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientKeyData { get; set; }

        /// <summary>
        /// 身份验证令牌
        /// </summary>
        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthInfo {\n");
            sb.Append("  clientCertificateData: ").Append(ClientCertificateData).Append("\n");
            sb.Append("  clientKeyData: ").Append(ClientKeyData).Append("\n");
            sb.Append("  token: ").Append(Token).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AuthInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AuthInfo input)
        {
            if (input == null) return false;
            if (this.ClientCertificateData != input.ClientCertificateData || (this.ClientCertificateData != null && !this.ClientCertificateData.Equals(input.ClientCertificateData))) return false;
            if (this.ClientKeyData != input.ClientKeyData || (this.ClientKeyData != null && !this.ClientKeyData.Equals(input.ClientKeyData))) return false;
            if (this.Token != input.Token || (this.Token != null && !this.Token.Equals(input.Token))) return false;

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
                if (this.ClientCertificateData != null) hashCode = hashCode * 59 + this.ClientCertificateData.GetHashCode();
                if (this.ClientKeyData != null) hashCode = hashCode * 59 + this.ClientKeyData.GetHashCode();
                if (this.Token != null) hashCode = hashCode * 59 + this.Token.GetHashCode();
                return hashCode;
            }
        }
    }
}
