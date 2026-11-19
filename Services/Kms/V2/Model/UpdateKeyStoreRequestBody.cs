using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kms.V2.Model
{
    /// <summary>
    /// 更新专属密钥库请求体
    /// </summary>
    public class UpdateKeyStoreRequestBody 
    {

        /// <summary>
        /// 访问XKS-Proxy的凭据ID
        /// </summary>
        [JsonProperty("proxy_access_key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProxyAccessKeyId { get; set; }

        /// <summary>
        /// 访问XKS-Proxy的凭据Key
        /// </summary>
        [JsonProperty("proxy_secret_access_key", NullValueHandling = NullValueHandling.Ignore)]
        public string ProxySecretAccessKey { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateKeyStoreRequestBody {\n");
            sb.Append("  proxyAccessKeyId: ").Append(ProxyAccessKeyId).Append("\n");
            sb.Append("  proxySecretAccessKey: ").Append(ProxySecretAccessKey).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateKeyStoreRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateKeyStoreRequestBody input)
        {
            if (input == null) return false;
            if (this.ProxyAccessKeyId != input.ProxyAccessKeyId || (this.ProxyAccessKeyId != null && !this.ProxyAccessKeyId.Equals(input.ProxyAccessKeyId))) return false;
            if (this.ProxySecretAccessKey != input.ProxySecretAccessKey || (this.ProxySecretAccessKey != null && !this.ProxySecretAccessKey.Equals(input.ProxySecretAccessKey))) return false;

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
                if (this.ProxyAccessKeyId != null) hashCode = hashCode * 59 + this.ProxyAccessKeyId.GetHashCode();
                if (this.ProxySecretAccessKey != null) hashCode = hashCode * 59 + this.ProxySecretAccessKey.GetHashCode();
                return hashCode;
            }
        }
    }
}
