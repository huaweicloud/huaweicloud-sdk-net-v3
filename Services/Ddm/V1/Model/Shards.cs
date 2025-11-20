using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ddm.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Shards 
    {

        /// <summary>
        /// 物理分片所在RDS的ID。
        /// </summary>
        [JsonProperty("data_node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DataNodeId { get; set; }

        /// <summary>
        /// 物理分片名称。
        /// </summary>
        [JsonProperty("physical_db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PhysicalDbName { get; set; }

        /// <summary>
        /// 物理分片运行状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 物理分片序号。
        /// </summary>
        [JsonProperty("shard_index", NullValueHandling = NullValueHandling.Ignore)]
        public int? ShardIndex { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Shards {\n");
            sb.Append("  dataNodeId: ").Append(DataNodeId).Append("\n");
            sb.Append("  physicalDbName: ").Append(PhysicalDbName).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  shardIndex: ").Append(ShardIndex).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Shards);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Shards input)
        {
            if (input == null) return false;
            if (this.DataNodeId != input.DataNodeId || (this.DataNodeId != null && !this.DataNodeId.Equals(input.DataNodeId))) return false;
            if (this.PhysicalDbName != input.PhysicalDbName || (this.PhysicalDbName != null && !this.PhysicalDbName.Equals(input.PhysicalDbName))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.ShardIndex != input.ShardIndex || (this.ShardIndex != null && !this.ShardIndex.Equals(input.ShardIndex))) return false;

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
                if (this.DataNodeId != null) hashCode = hashCode * 59 + this.DataNodeId.GetHashCode();
                if (this.PhysicalDbName != null) hashCode = hashCode * 59 + this.PhysicalDbName.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ShardIndex != null) hashCode = hashCode * 59 + this.ShardIndex.GetHashCode();
                return hashCode;
            }
        }
    }
}
