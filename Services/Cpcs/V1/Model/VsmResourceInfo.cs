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
    public class VsmResourceInfo 
    {

        /// <summary>
        /// 当前租户拥有的vsm集群数量
        /// </summary>
        [JsonProperty("cluster_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? ClusterNum { get; set; }

        /// <summary>
        /// 当前租户名下由cpcs代创建和管理的vsm集群数量
        /// </summary>
        [JsonProperty("cpcs_cluster_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? CpcsClusterNum { get; set; }

        /// <summary>
        /// 当前租户拥有的vsm实例总数
        /// </summary>
        [JsonProperty("instance_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? InstanceNum { get; set; }

        /// <summary>
        /// 当前租户名下由cpcs代创建和管理的vsm实例总数
        /// </summary>
        [JsonProperty("cpcs_instance_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? CpcsInstanceNum { get; set; }

        /// <summary>
        /// 当前租户被分配的vsm实例配额数
        /// </summary>
        [JsonProperty("instance_quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? InstanceQuota { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VsmResourceInfo {\n");
            sb.Append("  clusterNum: ").Append(ClusterNum).Append("\n");
            sb.Append("  cpcsClusterNum: ").Append(CpcsClusterNum).Append("\n");
            sb.Append("  instanceNum: ").Append(InstanceNum).Append("\n");
            sb.Append("  cpcsInstanceNum: ").Append(CpcsInstanceNum).Append("\n");
            sb.Append("  instanceQuota: ").Append(InstanceQuota).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VsmResourceInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VsmResourceInfo input)
        {
            if (input == null) return false;
            if (this.ClusterNum != input.ClusterNum || (this.ClusterNum != null && !this.ClusterNum.Equals(input.ClusterNum))) return false;
            if (this.CpcsClusterNum != input.CpcsClusterNum || (this.CpcsClusterNum != null && !this.CpcsClusterNum.Equals(input.CpcsClusterNum))) return false;
            if (this.InstanceNum != input.InstanceNum || (this.InstanceNum != null && !this.InstanceNum.Equals(input.InstanceNum))) return false;
            if (this.CpcsInstanceNum != input.CpcsInstanceNum || (this.CpcsInstanceNum != null && !this.CpcsInstanceNum.Equals(input.CpcsInstanceNum))) return false;
            if (this.InstanceQuota != input.InstanceQuota || (this.InstanceQuota != null && !this.InstanceQuota.Equals(input.InstanceQuota))) return false;

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
                if (this.CpcsClusterNum != null) hashCode = hashCode * 59 + this.CpcsClusterNum.GetHashCode();
                if (this.InstanceNum != null) hashCode = hashCode * 59 + this.InstanceNum.GetHashCode();
                if (this.CpcsInstanceNum != null) hashCode = hashCode * 59 + this.CpcsInstanceNum.GetHashCode();
                if (this.InstanceQuota != null) hashCode = hashCode * 59 + this.InstanceQuota.GetHashCode();
                return hashCode;
            }
        }
    }
}
