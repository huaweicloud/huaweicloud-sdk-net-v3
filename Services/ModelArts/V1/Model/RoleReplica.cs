using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 角色副本配置
    /// </summary>
    public class RoleReplica 
    {

        /// <summary>
        /// **参数解释：** 角色名称。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释：** 最大副本数。 **取值范围：** 1~128。
        /// </summary>
        [JsonProperty("max_replicas", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxReplicas { get; set; }

        /// <summary>
        /// **参数解释：** 最小副本数。 **取值范围：** 1~128。
        /// </summary>
        [JsonProperty("min_replicas", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinReplicas { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoleReplica {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  maxReplicas: ").Append(MaxReplicas).Append("\n");
            sb.Append("  minReplicas: ").Append(MinReplicas).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RoleReplica);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RoleReplica input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.MaxReplicas != input.MaxReplicas || (this.MaxReplicas != null && !this.MaxReplicas.Equals(input.MaxReplicas))) return false;
            if (this.MinReplicas != input.MinReplicas || (this.MinReplicas != null && !this.MinReplicas.Equals(input.MinReplicas))) return false;

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
                if (this.MaxReplicas != null) hashCode = hashCode * 59 + this.MaxReplicas.GetHashCode();
                if (this.MinReplicas != null) hashCode = hashCode * 59 + this.MinReplicas.GetHashCode();
                return hashCode;
            }
        }
    }
}
