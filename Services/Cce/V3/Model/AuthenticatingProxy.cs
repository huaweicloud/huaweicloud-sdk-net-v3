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
    /// authenticatingProxy模式相关配置。认证模式为authenticating_proxy时必选
    /// </summary>
    public class AuthenticatingProxy 
    {

        /// <summary>
        /// authenticating_proxy模式配置的x509格式CA证书(base64编码)。当集群认证模式为authenticating_proxy时，此项必须填写。   最大长度：1M 
        /// </summary>
        [JsonProperty("ca", NullValueHandling = NullValueHandling.Ignore)]
        public string Ca { get; set; }

        /// <summary>
        /// authenticating_proxy模式配置的x509格式CA证书签发的客户端证书，用于kube-apiserver到扩展apiserver的认证。(base64编码)。当集群认证模式为authenticating_proxy时，此项必须填写。 
        /// </summary>
        [JsonProperty("cert", NullValueHandling = NullValueHandling.Ignore)]
        public string Cert { get; set; }

        /// <summary>
        /// authenticating_proxy模式配置的x509格式CA证书签发的客户端证书时对应的私钥，用于kube-apiserver到扩展apiserver的认证。Kubernetes集群使用的私钥尚不支持密码加密，请使用未加密的私钥。(base64编码)。当集群认证模式为authenticating_proxy时，此项必须填写。 
        /// </summary>
        [JsonProperty("privateKey", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateKey { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthenticatingProxy {\n");
            sb.Append("  ca: ").Append(Ca).Append("\n");
            sb.Append("  cert: ").Append(Cert).Append("\n");
            sb.Append("  privateKey: ").Append(PrivateKey).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AuthenticatingProxy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AuthenticatingProxy input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Ca == input.Ca ||
                    (this.Ca != null &&
                    this.Ca.Equals(input.Ca))
                ) && 
                (
                    this.Cert == input.Cert ||
                    (this.Cert != null &&
                    this.Cert.Equals(input.Cert))
                ) && 
                (
                    this.PrivateKey == input.PrivateKey ||
                    (this.PrivateKey != null &&
                    this.PrivateKey.Equals(input.PrivateKey))
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
                if (this.Ca != null)
                    hashCode = hashCode * 59 + this.Ca.GetHashCode();
                if (this.Cert != null)
                    hashCode = hashCode * 59 + this.Cert.GetHashCode();
                if (this.PrivateKey != null)
                    hashCode = hashCode * 59 + this.PrivateKey.GetHashCode();
                return hashCode;
            }
        }
    }
}
