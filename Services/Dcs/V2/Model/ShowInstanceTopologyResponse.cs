using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowInstanceTopologyResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**： 集群角色：redis-server实例拓朴图。 
        /// </summary>
        [JsonProperty("redis_server", NullValueHandling = NullValueHandling.Ignore)]
        public List<TopologyInfo> RedisServer { get; set; }

        /// <summary>
        /// **参数解释**： 集群角色：lvs实例拓朴图（当前已下线），只适用于Redis 3.0版本实例。 
        /// </summary>
        [JsonProperty("cluster_lvs", NullValueHandling = NullValueHandling.Ignore)]
        public List<TopologyInfo> ClusterLvs { get; set; }

        /// <summary>
        /// **参数解释**： 集群角色：admin实例拓朴图（当前已下线），只适用于Redis 3.0版本实例。 
        /// </summary>
        [JsonProperty("cluster_admin", NullValueHandling = NullValueHandling.Ignore)]
        public List<TopologyInfo> ClusterAdmin { get; set; }

        /// <summary>
        /// **参数解释**： 集群角色：proxy实例拓朴图。 
        /// </summary>
        [JsonProperty("cluster_proxy", NullValueHandling = NullValueHandling.Ignore)]
        public List<TopologyInfo> ClusterProxy { get; set; }

        /// <summary>
        /// **参数解释**： Redis的角色master实例拓朴图，只适用于Redis 3.0版本实例。 
        /// </summary>
        [JsonProperty("master", NullValueHandling = NullValueHandling.Ignore)]
        public List<TopologyInfo> Master { get; set; }

        /// <summary>
        /// **参数解释**： 集群角色：VPC Endpoint服务实例拓朴图，适用于4.0及以上版本实例。 
        /// </summary>
        [JsonProperty("vpcendpoint", NullValueHandling = NullValueHandling.Ignore)]
        public List<TopologyInfo> Vpcendpoint { get; set; }

        /// <summary>
        /// **参数解释**： 集群角色：ELB服务实例拓朴图，适用于Redis 4.0及以上版本实例。 
        /// </summary>
        [JsonProperty("elb", NullValueHandling = NullValueHandling.Ignore)]
        public List<TopologyInfo> Elb { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowInstanceTopologyResponse {\n");
            sb.Append("  redisServer: ").Append(RedisServer).Append("\n");
            sb.Append("  clusterLvs: ").Append(ClusterLvs).Append("\n");
            sb.Append("  clusterAdmin: ").Append(ClusterAdmin).Append("\n");
            sb.Append("  clusterProxy: ").Append(ClusterProxy).Append("\n");
            sb.Append("  master: ").Append(Master).Append("\n");
            sb.Append("  vpcendpoint: ").Append(Vpcendpoint).Append("\n");
            sb.Append("  elb: ").Append(Elb).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowInstanceTopologyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowInstanceTopologyResponse input)
        {
            if (input == null) return false;
            if (this.RedisServer != input.RedisServer || (this.RedisServer != null && input.RedisServer != null && !this.RedisServer.SequenceEqual(input.RedisServer))) return false;
            if (this.ClusterLvs != input.ClusterLvs || (this.ClusterLvs != null && input.ClusterLvs != null && !this.ClusterLvs.SequenceEqual(input.ClusterLvs))) return false;
            if (this.ClusterAdmin != input.ClusterAdmin || (this.ClusterAdmin != null && input.ClusterAdmin != null && !this.ClusterAdmin.SequenceEqual(input.ClusterAdmin))) return false;
            if (this.ClusterProxy != input.ClusterProxy || (this.ClusterProxy != null && input.ClusterProxy != null && !this.ClusterProxy.SequenceEqual(input.ClusterProxy))) return false;
            if (this.Master != input.Master || (this.Master != null && input.Master != null && !this.Master.SequenceEqual(input.Master))) return false;
            if (this.Vpcendpoint != input.Vpcendpoint || (this.Vpcendpoint != null && input.Vpcendpoint != null && !this.Vpcendpoint.SequenceEqual(input.Vpcendpoint))) return false;
            if (this.Elb != input.Elb || (this.Elb != null && input.Elb != null && !this.Elb.SequenceEqual(input.Elb))) return false;

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
                if (this.RedisServer != null) hashCode = hashCode * 59 + this.RedisServer.GetHashCode();
                if (this.ClusterLvs != null) hashCode = hashCode * 59 + this.ClusterLvs.GetHashCode();
                if (this.ClusterAdmin != null) hashCode = hashCode * 59 + this.ClusterAdmin.GetHashCode();
                if (this.ClusterProxy != null) hashCode = hashCode * 59 + this.ClusterProxy.GetHashCode();
                if (this.Master != null) hashCode = hashCode * 59 + this.Master.GetHashCode();
                if (this.Vpcendpoint != null) hashCode = hashCode * 59 + this.Vpcendpoint.GetHashCode();
                if (this.Elb != null) hashCode = hashCode * 59 + this.Elb.GetHashCode();
                return hashCode;
            }
        }
    }
}
