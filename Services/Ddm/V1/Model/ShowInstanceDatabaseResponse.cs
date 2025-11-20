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
    /// Response Object
    /// </summary>
    public class ShowInstanceDatabaseResponse : SdkResponse
    {

        /// <summary>
        /// 逻辑库分片信息。
        /// </summary>
        [JsonProperty("shards", NullValueHandling = NullValueHandling.Ignore)]
        public List<Shards> Shards { get; set; }

        /// <summary>
        /// 逻辑库状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 创建时间，格式为\&quot;yyyy-MM-ddTHH:mm:ssZ\&quot;。 其中，T指某个时间的开始；Z指时区偏移量，例如北京时间偏移显示为+0800。
        /// </summary>
        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public string Created { get; set; }

        /// <summary>
        /// 更新时间，格式为\&quot;yyyy-MM-ddTHH:mm:ssZ\&quot;。 其中，T指某个时间的开始；Z指时区偏移量，例如北京时间偏移显示为+0800。
        /// </summary>
        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public string Updated { get; set; }

        /// <summary>
        /// 逻辑库名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 拆分模式。
        /// </summary>
        [JsonProperty("shard_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string ShardMode { get; set; }

        /// <summary>
        /// 逻辑库分片数。
        /// </summary>
        [JsonProperty("shard_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? ShardNumber { get; set; }

        /// <summary>
        /// 关联的后端DN信息。
        /// </summary>
        [JsonProperty("data_nodes", NullValueHandling = NullValueHandling.Ignore)]
        public List<DataNodes> DataNodes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowInstanceDatabaseResponse {\n");
            sb.Append("  shards: ").Append(Shards).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  created: ").Append(Created).Append("\n");
            sb.Append("  updated: ").Append(Updated).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  shardMode: ").Append(ShardMode).Append("\n");
            sb.Append("  shardNumber: ").Append(ShardNumber).Append("\n");
            sb.Append("  dataNodes: ").Append(DataNodes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowInstanceDatabaseResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowInstanceDatabaseResponse input)
        {
            if (input == null) return false;
            if (this.Shards != input.Shards || (this.Shards != null && input.Shards != null && !this.Shards.SequenceEqual(input.Shards))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Created != input.Created || (this.Created != null && !this.Created.Equals(input.Created))) return false;
            if (this.Updated != input.Updated || (this.Updated != null && !this.Updated.Equals(input.Updated))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ShardMode != input.ShardMode || (this.ShardMode != null && !this.ShardMode.Equals(input.ShardMode))) return false;
            if (this.ShardNumber != input.ShardNumber || (this.ShardNumber != null && !this.ShardNumber.Equals(input.ShardNumber))) return false;
            if (this.DataNodes != input.DataNodes || (this.DataNodes != null && input.DataNodes != null && !this.DataNodes.SequenceEqual(input.DataNodes))) return false;

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
                if (this.Shards != null) hashCode = hashCode * 59 + this.Shards.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Created != null) hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Updated != null) hashCode = hashCode * 59 + this.Updated.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ShardMode != null) hashCode = hashCode * 59 + this.ShardMode.GetHashCode();
                if (this.ShardNumber != null) hashCode = hashCode * 59 + this.ShardNumber.GetHashCode();
                if (this.DataNodes != null) hashCode = hashCode * 59 + this.DataNodes.GetHashCode();
                return hashCode;
            }
        }
    }
}
