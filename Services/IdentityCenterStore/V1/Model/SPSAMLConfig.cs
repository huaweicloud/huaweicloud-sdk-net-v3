using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenterStore.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SPSAMLConfig 
    {

        /// <summary>
        /// 服务提供商断言响应地址
        /// </summary>
        [JsonProperty("acs_url", NullValueHandling = NullValueHandling.Ignore)]
        public string AcsUrl { get; set; }

        /// <summary>
        /// 服务提供商签发者
        /// </summary>
        [JsonProperty("issuer", NullValueHandling = NullValueHandling.Ignore)]
        public string Issuer { get; set; }

        /// <summary>
        /// 服务提供商元数据
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public string Metadata { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SPSAMLConfig {\n");
            sb.Append("  acsUrl: ").Append(AcsUrl).Append("\n");
            sb.Append("  issuer: ").Append(Issuer).Append("\n");
            sb.Append("  metadata: ").Append(Metadata).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SPSAMLConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SPSAMLConfig input)
        {
            if (input == null) return false;
            if (this.AcsUrl != input.AcsUrl || (this.AcsUrl != null && !this.AcsUrl.Equals(input.AcsUrl))) return false;
            if (this.Issuer != input.Issuer || (this.Issuer != null && !this.Issuer.Equals(input.Issuer))) return false;
            if (this.Metadata != input.Metadata || (this.Metadata != null && !this.Metadata.Equals(input.Metadata))) return false;

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
                if (this.AcsUrl != null) hashCode = hashCode * 59 + this.AcsUrl.GetHashCode();
                if (this.Issuer != null) hashCode = hashCode * 59 + this.Issuer.GetHashCode();
                if (this.Metadata != null) hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                return hashCode;
            }
        }
    }
}
