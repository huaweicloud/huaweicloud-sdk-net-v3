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
    public class CcspServiceInfo 
    {

        /// <summary>
        /// 当前租户拥有的密码服务集群数量
        /// </summary>
        [JsonProperty("cluster_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? ClusterNum { get; set; }

        /// <summary>
        /// 当前租户拥有的密码服务实例数量
        /// </summary>
        [JsonProperty("instance_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? InstanceNum { get; set; }

        /// <summary>
        /// 当前租户的可创建的密码服务实例配额数
        /// </summary>
        [JsonProperty("instance_quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? InstanceQuota { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("instance_distribution", NullValueHandling = NullValueHandling.Ignore)]
        public InstanceDistribution InstanceDistribution { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CcspServiceInfo {\n");
            sb.Append("  clusterNum: ").Append(ClusterNum).Append("\n");
            sb.Append("  instanceNum: ").Append(InstanceNum).Append("\n");
            sb.Append("  instanceQuota: ").Append(InstanceQuota).Append("\n");
            sb.Append("  instanceDistribution: ").Append(InstanceDistribution).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CcspServiceInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CcspServiceInfo input)
        {
            if (input == null) return false;
            if (this.ClusterNum != input.ClusterNum || (this.ClusterNum != null && !this.ClusterNum.Equals(input.ClusterNum))) return false;
            if (this.InstanceNum != input.InstanceNum || (this.InstanceNum != null && !this.InstanceNum.Equals(input.InstanceNum))) return false;
            if (this.InstanceQuota != input.InstanceQuota || (this.InstanceQuota != null && !this.InstanceQuota.Equals(input.InstanceQuota))) return false;
            if (this.InstanceDistribution != input.InstanceDistribution || (this.InstanceDistribution != null && !this.InstanceDistribution.Equals(input.InstanceDistribution))) return false;

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
                if (this.ClusterNum != null) hashCode = hashCode * 59 + this.ClusterNum.GetHashCode();
                if (this.InstanceNum != null) hashCode = hashCode * 59 + this.InstanceNum.GetHashCode();
                if (this.InstanceQuota != null) hashCode = hashCode * 59 + this.InstanceQuota.GetHashCode();
                if (this.InstanceDistribution != null) hashCode = hashCode * 59 + this.InstanceDistribution.GetHashCode();
                return hashCode;
            }
        }
    }
}
