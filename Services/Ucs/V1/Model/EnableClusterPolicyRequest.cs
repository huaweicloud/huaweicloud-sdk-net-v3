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
    /// Request Object
    /// </summary>
    public class EnableClusterPolicyRequest 
    {

        /// <summary>
        /// 集群id
        /// </summary>
        [SDKProperty("clusterid", IsPath = true)]
        [JsonProperty("clusterid", NullValueHandling = NullValueHandling.Ignore)]
        public string Clusterid { get; set; }

        /// <summary>
        /// 重试启动策略中心
        /// </summary>
        [SDKProperty("retry", IsQuery = true)]
        [JsonProperty("retry", NullValueHandling = NullValueHandling.Ignore)]
        public string Retry { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnableClusterPolicyRequest {\n");
            sb.Append("  clusterid: ").Append(Clusterid).Append("\n");
            sb.Append("  retry: ").Append(Retry).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EnableClusterPolicyRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EnableClusterPolicyRequest input)
        {
            if (input == null) return false;
            if (this.Clusterid != input.Clusterid || (this.Clusterid != null && !this.Clusterid.Equals(input.Clusterid))) return false;
            if (this.Retry != input.Retry || (this.Retry != null && !this.Retry.Equals(input.Retry))) return false;

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
                if (this.Clusterid != null) hashCode = hashCode * 59 + this.Clusterid.GetHashCode();
                if (this.Retry != null) hashCode = hashCode * 59 + this.Retry.GetHashCode();
                return hashCode;
            }
        }
    }
}
