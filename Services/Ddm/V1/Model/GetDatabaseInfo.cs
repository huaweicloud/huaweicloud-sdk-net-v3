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
    /// databases 返回参数
    /// </summary>
    public class GetDatabaseInfo 
    {

        /// <summary>
        /// 逻辑库名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 逻辑库的工作模式。  - cluster表示逻辑库是拆分模式。 - single表示逻辑库是非拆分模式。
        /// </summary>
        [JsonProperty("shard_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string ShardMode { get; set; }

        /// <summary>
        /// 同一种工作模式下逻辑库分片的数量。
        /// </summary>
        [JsonProperty("shard_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? ShardNumber { get; set; }

        /// <summary>
        /// 逻辑库状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 逻辑库的创建时间。
        /// </summary>
        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public long? Created { get; set; }

        /// <summary>
        /// 逻辑库关联的RDS实例信息。
        /// </summary>
        [JsonProperty("used_rds", NullValueHandling = NullValueHandling.Ignore)]
        public List<GetDatabaseUsedRds> UsedRds { get; set; }

        /// <summary>
        /// 单个RDS上的逻辑库分片数。
        /// </summary>
        [JsonProperty("shard_unit", NullValueHandling = NullValueHandling.Ignore)]
        public int? ShardUnit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetDatabaseInfo {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  shardMode: ").Append(ShardMode).Append("\n");
            sb.Append("  shardNumber: ").Append(ShardNumber).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  created: ").Append(Created).Append("\n");
            sb.Append("  usedRds: ").Append(UsedRds).Append("\n");
            sb.Append("  shardUnit: ").Append(ShardUnit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetDatabaseInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GetDatabaseInfo input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ShardMode != input.ShardMode || (this.ShardMode != null && !this.ShardMode.Equals(input.ShardMode))) return false;
            if (this.ShardNumber != input.ShardNumber || (this.ShardNumber != null && !this.ShardNumber.Equals(input.ShardNumber))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Created != input.Created || (this.Created != null && !this.Created.Equals(input.Created))) return false;
            if (this.UsedRds != input.UsedRds || (this.UsedRds != null && input.UsedRds != null && !this.UsedRds.SequenceEqual(input.UsedRds))) return false;
            if (this.ShardUnit != input.ShardUnit || (this.ShardUnit != null && !this.ShardUnit.Equals(input.ShardUnit))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ShardMode != null) hashCode = hashCode * 59 + this.ShardMode.GetHashCode();
                if (this.ShardNumber != null) hashCode = hashCode * 59 + this.ShardNumber.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Created != null) hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.UsedRds != null) hashCode = hashCode * 59 + this.UsedRds.GetHashCode();
                if (this.ShardUnit != null) hashCode = hashCode * 59 + this.ShardUnit.GetHashCode();
                return hashCode;
            }
        }
    }
}
