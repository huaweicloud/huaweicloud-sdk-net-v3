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
    public class ListMonitoredObjectsOfInstanceResponse : SdkResponse
    {

        /// <summary>
        /// 当前查询维度路由。如果是主维度，则数组中是自身ID。
        /// </summary>
        [JsonProperty("router", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Router { get; set; }

        /// <summary>
        /// 当前查询维度子维度对象列表。当前只有维度为dcs_instance_id时才有值。 - Proxy集群有两个子维度，分别为dcs_cluster_redis_node和dcs_cluster_proxy_node。 - Cluster集群有一个子维度 dcs_cluster_proxy_node。 
        /// </summary>
        [JsonProperty("children", NullValueHandling = NullValueHandling.Ignore)]
        public List<DimChild> Children { get; set; }

        /// <summary>
        /// 当前查询维度监控对象列表。
        /// </summary>
        [JsonProperty("instances", NullValueHandling = NullValueHandling.Ignore)]
        public List<InstancesMonitoredObject> Instances { get; set; }

        /// <summary>
        /// Proxy集群或Cluster集群时才存在，表示集群数据节点维度的监控对象列表。字段名称与children的子维度对象名称相同。
        /// </summary>
        [JsonProperty("dcs_cluster_redis_node", NullValueHandling = NullValueHandling.Ignore)]
        public List<ClusterRedisNodeMonitoredObject> DcsClusterRedisNode { get; set; }

        /// <summary>
        /// Proxy集群时才存在，表示集群Proxy节点维度的监控对象列表。字段名称与children的子维度对象名称相同。
        /// </summary>
        [JsonProperty("dcs_cluster_proxy_node", NullValueHandling = NullValueHandling.Ignore)]
        public List<ProxyNodeMonitoredObject> DcsClusterProxyNode { get; set; }

        /// <summary>
        /// 主维度监控对象的总数。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListMonitoredObjectsOfInstanceResponse {\n");
            sb.Append("  router: ").Append(Router).Append("\n");
            sb.Append("  children: ").Append(Children).Append("\n");
            sb.Append("  instances: ").Append(Instances).Append("\n");
            sb.Append("  dcsClusterRedisNode: ").Append(DcsClusterRedisNode).Append("\n");
            sb.Append("  dcsClusterProxyNode: ").Append(DcsClusterProxyNode).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListMonitoredObjectsOfInstanceResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListMonitoredObjectsOfInstanceResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Router == input.Router ||
                    this.Router != null &&
                    input.Router != null &&
                    this.Router.SequenceEqual(input.Router)
                ) && 
                (
                    this.Children == input.Children ||
                    this.Children != null &&
                    input.Children != null &&
                    this.Children.SequenceEqual(input.Children)
                ) && 
                (
                    this.Instances == input.Instances ||
                    this.Instances != null &&
                    input.Instances != null &&
                    this.Instances.SequenceEqual(input.Instances)
                ) && 
                (
                    this.DcsClusterRedisNode == input.DcsClusterRedisNode ||
                    this.DcsClusterRedisNode != null &&
                    input.DcsClusterRedisNode != null &&
                    this.DcsClusterRedisNode.SequenceEqual(input.DcsClusterRedisNode)
                ) && 
                (
                    this.DcsClusterProxyNode == input.DcsClusterProxyNode ||
                    this.DcsClusterProxyNode != null &&
                    input.DcsClusterProxyNode != null &&
                    this.DcsClusterProxyNode.SequenceEqual(input.DcsClusterProxyNode)
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
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
                if (this.Router != null)
                    hashCode = hashCode * 59 + this.Router.GetHashCode();
                if (this.Children != null)
                    hashCode = hashCode * 59 + this.Children.GetHashCode();
                if (this.Instances != null)
                    hashCode = hashCode * 59 + this.Instances.GetHashCode();
                if (this.DcsClusterRedisNode != null)
                    hashCode = hashCode * 59 + this.DcsClusterRedisNode.GetHashCode();
                if (this.DcsClusterProxyNode != null)
                    hashCode = hashCode * 59 + this.DcsClusterProxyNode.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
