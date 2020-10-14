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
    /// 副本列表
    /// </summary>
    public class InstanceReplicationListInfo 
    {

        /// <summary>
        /// 副本角色，取值有： - master：表示主节点。 - slave：表示从节点。 
        /// </summary>
        [JsonProperty("replication_role", NullValueHandling = NullValueHandling.Ignore)]
        public string ReplicationRole { get; set; }

        /// <summary>
        /// 副本IP。
        /// </summary>
        [JsonProperty("replication_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string ReplicationIp { get; set; }

        /// <summary>
        /// 是否是新加副本。
        /// </summary>
        [JsonProperty("is_replication", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsReplication { get; set; }

        /// <summary>
        /// 副本id。
        /// </summary>
        [JsonProperty("replication_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ReplicationId { get; set; }

        /// <summary>
        /// 节点id。
        /// </summary>
        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; }

        /// <summary>
        /// 副本状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 副本所在的可用区
        /// </summary>
        [JsonProperty("az_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AzCode { get; set; }

        /// <summary>
        /// 副本对应的监控指标维度信息。可用于调用云监控服务的查询监控数据指标相关接口 - 副本的监控维度为多维度，返回数组中包含两个维度信息。从云监控查询监控数据时，要按多维度传递指标维度参数，才能查询到监控指标值 - 第一个维度为副本父维度信息，维度名称为dcs_instance_id，维度值对应副本所在的实例ID - 第二个维度，维度名称为dcs_cluster_redis_node,维度值为副本的监控对象ID，与副本ID和节点ID不同。 
        /// </summary>
        [JsonProperty("dimensions", NullValueHandling = NullValueHandling.Ignore)]
        public List<InstanceReplicationDimensionsInfo> Dimensions { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstanceReplicationListInfo {\n");
            sb.Append("  replicationRole: ").Append(ReplicationRole).Append("\n");
            sb.Append("  replicationIp: ").Append(ReplicationIp).Append("\n");
            sb.Append("  isReplication: ").Append(IsReplication).Append("\n");
            sb.Append("  replicationId: ").Append(ReplicationId).Append("\n");
            sb.Append("  nodeId: ").Append(NodeId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  azCode: ").Append(AzCode).Append("\n");
            sb.Append("  dimensions: ").Append(Dimensions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InstanceReplicationListInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InstanceReplicationListInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ReplicationRole == input.ReplicationRole ||
                    (this.ReplicationRole != null &&
                    this.ReplicationRole.Equals(input.ReplicationRole))
                ) && 
                (
                    this.ReplicationIp == input.ReplicationIp ||
                    (this.ReplicationIp != null &&
                    this.ReplicationIp.Equals(input.ReplicationIp))
                ) && 
                (
                    this.IsReplication == input.IsReplication ||
                    (this.IsReplication != null &&
                    this.IsReplication.Equals(input.IsReplication))
                ) && 
                (
                    this.ReplicationId == input.ReplicationId ||
                    (this.ReplicationId != null &&
                    this.ReplicationId.Equals(input.ReplicationId))
                ) && 
                (
                    this.NodeId == input.NodeId ||
                    (this.NodeId != null &&
                    this.NodeId.Equals(input.NodeId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.AzCode == input.AzCode ||
                    (this.AzCode != null &&
                    this.AzCode.Equals(input.AzCode))
                ) && 
                (
                    this.Dimensions == input.Dimensions ||
                    this.Dimensions != null &&
                    input.Dimensions != null &&
                    this.Dimensions.SequenceEqual(input.Dimensions)
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
                if (this.ReplicationRole != null)
                    hashCode = hashCode * 59 + this.ReplicationRole.GetHashCode();
                if (this.ReplicationIp != null)
                    hashCode = hashCode * 59 + this.ReplicationIp.GetHashCode();
                if (this.IsReplication != null)
                    hashCode = hashCode * 59 + this.IsReplication.GetHashCode();
                if (this.ReplicationId != null)
                    hashCode = hashCode * 59 + this.ReplicationId.GetHashCode();
                if (this.NodeId != null)
                    hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.AzCode != null)
                    hashCode = hashCode * 59 + this.AzCode.GetHashCode();
                if (this.Dimensions != null)
                    hashCode = hashCode * 59 + this.Dimensions.GetHashCode();
                return hashCode;
            }
        }
    }
}
