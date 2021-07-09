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
    public class Authentication 
    {

        /// <summary>
        /// 集群认证模式。   - kubernetes 1.11及之前版本的集群支持“x509”、“rbac”和“authenticating_proxy”，默认取值为“x509”。  - kubernetes 1.13及以上版本的集群支持“rbac”和“authenticating_proxy”，默认取值为“rbac”。
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public string Mode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("authenticatingProxy", NullValueHandling = NullValueHandling.Ignore)]
        public AuthenticatingProxy AuthenticatingProxy { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Authentication {\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("  authenticatingProxy: ").Append(AuthenticatingProxy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Authentication);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Authentication input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Mode == input.Mode ||
                    (this.Mode != null &&
                    this.Mode.Equals(input.Mode))
                ) && 
                (
                    this.AuthenticatingProxy == input.AuthenticatingProxy ||
                    (this.AuthenticatingProxy != null &&
                    this.AuthenticatingProxy.Equals(input.AuthenticatingProxy))
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
                if (this.Mode != null)
                    hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.AuthenticatingProxy != null)
                    hashCode = hashCode * 59 + this.AuthenticatingProxy.GetHashCode();
                return hashCode;
            }
        }
    }
}
