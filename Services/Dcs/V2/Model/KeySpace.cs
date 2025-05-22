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
    /// 键值空间
    /// </summary>
    public class KeySpace 
    {

        /// <summary>
        /// **参数解释**： db索引值。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("db_idx", NullValueHandling = NullValueHandling.Ignore)]
        public string DbIdx { get; set; }

        /// <summary>
        /// **参数解释**： 节点键数量。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("keys", NullValueHandling = NullValueHandling.Ignore)]
        public string Keys { get; set; }

        /// <summary>
        /// **参数解释**： 节点过期键数量。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("expires", NullValueHandling = NullValueHandling.Ignore)]
        public string Expires { get; set; }

        /// <summary>
        /// **参数解释**： 节点键的平均过期时间。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("avg_ttl", NullValueHandling = NullValueHandling.Ignore)]
        public string AvgTtl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KeySpace {\n");
            sb.Append("  dbIdx: ").Append(DbIdx).Append("\n");
            sb.Append("  keys: ").Append(Keys).Append("\n");
            sb.Append("  expires: ").Append(Expires).Append("\n");
            sb.Append("  avgTtl: ").Append(AvgTtl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as KeySpace);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(KeySpace input)
        {
            if (input == null) return false;
            if (this.DbIdx != input.DbIdx || (this.DbIdx != null && !this.DbIdx.Equals(input.DbIdx))) return false;
            if (this.Keys != input.Keys || (this.Keys != null && !this.Keys.Equals(input.Keys))) return false;
            if (this.Expires != input.Expires || (this.Expires != null && !this.Expires.Equals(input.Expires))) return false;
            if (this.AvgTtl != input.AvgTtl || (this.AvgTtl != null && !this.AvgTtl.Equals(input.AvgTtl))) return false;

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
                if (this.DbIdx != null) hashCode = hashCode * 59 + this.DbIdx.GetHashCode();
                if (this.Keys != null) hashCode = hashCode * 59 + this.Keys.GetHashCode();
                if (this.Expires != null) hashCode = hashCode * 59 + this.Expires.GetHashCode();
                if (this.AvgTtl != null) hashCode = hashCode * 59 + this.AvgTtl.GetHashCode();
                return hashCode;
            }
        }
    }
}
