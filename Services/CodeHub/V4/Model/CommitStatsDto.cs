using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CommitStatsDto 
    {

        /// <summary>
        /// **参数解释：** 增加行数。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("additions", NullValueHandling = NullValueHandling.Ignore)]
        public int? Additions { get; set; }

        /// <summary>
        /// **参数解释：** 删除行数。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("deletions", NullValueHandling = NullValueHandling.Ignore)]
        public int? Deletions { get; set; }

        /// <summary>
        /// **参数解释：** 变更行数。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommitStatsDto {\n");
            sb.Append("  additions: ").Append(Additions).Append("\n");
            sb.Append("  deletions: ").Append(Deletions).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CommitStatsDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CommitStatsDto input)
        {
            if (input == null) return false;
            if (this.Additions != input.Additions || (this.Additions != null && !this.Additions.Equals(input.Additions))) return false;
            if (this.Deletions != input.Deletions || (this.Deletions != null && !this.Deletions.Equals(input.Deletions))) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;

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
                if (this.Additions != null) hashCode = hashCode * 59 + this.Additions.GetHashCode();
                if (this.Deletions != null) hashCode = hashCode * 59 + this.Deletions.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
