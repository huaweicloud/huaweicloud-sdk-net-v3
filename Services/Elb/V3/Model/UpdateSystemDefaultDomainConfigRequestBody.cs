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
    /// **参数解释**：配置负载均衡器系统默认域名化相关配置参数。
    /// </summary>
    public class UpdateSystemDefaultDomainConfigRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("loadbalancer", NullValueHandling = NullValueHandling.Ignore)]
        public SystemDefaultDnsConfigRequestBody Loadbalancer { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateSystemDefaultDomainConfigRequestBody {\n");
            sb.Append("  loadbalancer: ").Append(Loadbalancer).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateSystemDefaultDomainConfigRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateSystemDefaultDomainConfigRequestBody input)
        {
            if (input == null) return false;
            if (this.Loadbalancer != input.Loadbalancer || (this.Loadbalancer != null && !this.Loadbalancer.Equals(input.Loadbalancer))) return false;

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
                if (this.Loadbalancer != null) hashCode = hashCode * 59 + this.Loadbalancer.GetHashCode();
                return hashCode;
            }
        }
    }
}
