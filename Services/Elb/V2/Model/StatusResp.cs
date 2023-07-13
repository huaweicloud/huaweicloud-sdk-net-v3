using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V2.Model
{
    /// <summary>
    /// 负载均衡器状态树对象
    /// </summary>
    public class StatusResp 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("loadbalancer", NullValueHandling = NullValueHandling.Ignore)]
        public LoadbalancerInStatusResp Loadbalancer { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatusResp {\n");
            sb.Append("  loadbalancer: ").Append(Loadbalancer).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StatusResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StatusResp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Loadbalancer == input.Loadbalancer ||
                    (this.Loadbalancer != null &&
                    this.Loadbalancer.Equals(input.Loadbalancer))
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
                if (this.Loadbalancer != null)
                    hashCode = hashCode * 59 + this.Loadbalancer.GetHashCode();
                return hashCode;
            }
        }
    }
}
