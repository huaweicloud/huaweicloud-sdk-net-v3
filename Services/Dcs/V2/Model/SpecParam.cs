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
    public class SpecParam 
    {

        /// <summary>
        /// **参数解释**： 实例分片数。 **约束限制**： 不涉及。 **取值范围**： 1-128。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("sharding_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ShardingCount { get; set; }

        /// <summary>
        /// 副本数 **参数解释**： 实例副本数。 **约束限制**： 不涉及。 **取值范围**： 1-10。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("replica_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReplicaCount { get; set; }

        /// <summary>
        /// 副本数 **参数解释**： 实例类型。 **约束限制**： 不涉及。 **取值范围**： 1.ha：主备类型 2.single：单机类型 3.ha_rw_split：读写分离类型 4.proxy：proxy集群类型 5.cluster：cluster集群类型 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("cache_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string CacheMode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SpecParam {\n");
            sb.Append("  shardingCount: ").Append(ShardingCount).Append("\n");
            sb.Append("  replicaCount: ").Append(ReplicaCount).Append("\n");
            sb.Append("  cacheMode: ").Append(CacheMode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SpecParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SpecParam input)
        {
            if (input == null) return false;
            if (this.ShardingCount != input.ShardingCount || (this.ShardingCount != null && !this.ShardingCount.Equals(input.ShardingCount))) return false;
            if (this.ReplicaCount != input.ReplicaCount || (this.ReplicaCount != null && !this.ReplicaCount.Equals(input.ReplicaCount))) return false;
            if (this.CacheMode != input.CacheMode || (this.CacheMode != null && !this.CacheMode.Equals(input.CacheMode))) return false;

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
                if (this.ShardingCount != null) hashCode = hashCode * 59 + this.ShardingCount.GetHashCode();
                if (this.ReplicaCount != null) hashCode = hashCode * 59 + this.ReplicaCount.GetHashCode();
                if (this.CacheMode != null) hashCode = hashCode * 59 + this.CacheMode.GetHashCode();
                return hashCode;
            }
        }
    }
}
