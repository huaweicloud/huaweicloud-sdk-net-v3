using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cpcs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CloudServiceInfo 
    {

        /// <summary>
        /// 当前租户开通的云原生密码服务数量（只统计白名单服务情况）
        /// </summary>
        [JsonProperty("service_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? ServiceNum { get; set; }

        /// <summary>
        /// 当前租户云原生密码服务的资源实例总和
        /// </summary>
        [JsonProperty("resource_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? ResourceNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("resource_distribution", NullValueHandling = NullValueHandling.Ignore)]
        public ResourceDistribution ResourceDistribution { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CloudServiceInfo {\n");
            sb.Append("  serviceNum: ").Append(ServiceNum).Append("\n");
            sb.Append("  resourceNum: ").Append(ResourceNum).Append("\n");
            sb.Append("  resourceDistribution: ").Append(ResourceDistribution).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CloudServiceInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CloudServiceInfo input)
        {
            if (input == null) return false;
            if (this.ServiceNum != input.ServiceNum || (this.ServiceNum != null && !this.ServiceNum.Equals(input.ServiceNum))) return false;
            if (this.ResourceNum != input.ResourceNum || (this.ResourceNum != null && !this.ResourceNum.Equals(input.ResourceNum))) return false;
            if (this.ResourceDistribution != input.ResourceDistribution || (this.ResourceDistribution != null && !this.ResourceDistribution.Equals(input.ResourceDistribution))) return false;

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
                if (this.ServiceNum != null) hashCode = hashCode * 59 + this.ServiceNum.GetHashCode();
                if (this.ResourceNum != null) hashCode = hashCode * 59 + this.ResourceNum.GetHashCode();
                if (this.ResourceDistribution != null) hashCode = hashCode * 59 + this.ResourceDistribution.GetHashCode();
                return hashCode;
            }
        }
    }
}
