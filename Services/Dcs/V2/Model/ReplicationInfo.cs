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
    /// 
    /// </summary>
    public class ReplicationInfo 
    {

        /// <summary>
        /// 副本ID
        /// </summary>
        [JsonProperty("replication_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ReplicationId { get; set; }

        /// <summary>
        /// 节点ID
        /// </summary>
        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; }

        /// <summary>
        /// 副本IP
        /// </summary>
        [JsonProperty("replication_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string ReplicationIp { get; set; }

        /// <summary>
        /// 组ID
        /// </summary>
        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }

        /// <summary>
        /// 组名称
        /// </summary>
        [JsonProperty("group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <summary>
        /// 可用区
        /// </summary>
        [JsonProperty("available_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailableZone { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReplicationInfo {\n");
            sb.Append("  replicationId: ").Append(ReplicationId).Append("\n");
            sb.Append("  nodeId: ").Append(NodeId).Append("\n");
            sb.Append("  replicationIp: ").Append(ReplicationIp).Append("\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  groupName: ").Append(GroupName).Append("\n");
            sb.Append("  availableZone: ").Append(AvailableZone).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReplicationInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReplicationInfo input)
        {
            if (input == null) return false;
            if (this.ReplicationId != input.ReplicationId || (this.ReplicationId != null && !this.ReplicationId.Equals(input.ReplicationId))) return false;
            if (this.NodeId != input.NodeId || (this.NodeId != null && !this.NodeId.Equals(input.NodeId))) return false;
            if (this.ReplicationIp != input.ReplicationIp || (this.ReplicationIp != null && !this.ReplicationIp.Equals(input.ReplicationIp))) return false;
            if (this.GroupId != input.GroupId || (this.GroupId != null && !this.GroupId.Equals(input.GroupId))) return false;
            if (this.GroupName != input.GroupName || (this.GroupName != null && !this.GroupName.Equals(input.GroupName))) return false;
            if (this.AvailableZone != input.AvailableZone || (this.AvailableZone != null && !this.AvailableZone.Equals(input.AvailableZone))) return false;

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
                if (this.ReplicationId != null) hashCode = hashCode * 59 + this.ReplicationId.GetHashCode();
                if (this.NodeId != null) hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                if (this.ReplicationIp != null) hashCode = hashCode * 59 + this.ReplicationIp.GetHashCode();
                if (this.GroupId != null) hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.GroupName != null) hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.AvailableZone != null) hashCode = hashCode * 59 + this.AvailableZone.GetHashCode();
                return hashCode;
            }
        }
    }
}
