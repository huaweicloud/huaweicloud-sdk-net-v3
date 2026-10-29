using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsCheck.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class StatisticStatusV2 
    {

        /// <summary>
        /// **参数解释：** [待处理问题数。](tag:hws,hws_hk)[待处理和重新打开（需打开忽略审核开关）问题数。](tag:fcs,hcs,hcs_sm,hcs_site,hcs_sitesm) **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("unresolved", NullValueHandling = NullValueHandling.Ignore)]
        public int? Unresolved { get; set; }

        /// <summary>
        /// **参数解释：** 已解决和已修复问题数。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("resolved", NullValueHandling = NullValueHandling.Ignore)]
        public int? Resolved { get; set; }

        /// <summary>
        /// **参数解释：** 已忽略问题数。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("dismissed", NullValueHandling = NullValueHandling.Ignore)]
        public int? Dismissed { get; set; }

        /// <summary>
        /// **参数解释：** 已修复问题数。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("fixed", NullValueHandling = NullValueHandling.Ignore)]
        public int? Fixed { get; set; }

        /// <summary>
        /// **参数解释：** 已解决问题数。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("solved", NullValueHandling = NullValueHandling.Ignore)]
        public int? Solved { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatisticStatusV2 {\n");
            sb.Append("  unresolved: ").Append(Unresolved).Append("\n");
            sb.Append("  resolved: ").Append(Resolved).Append("\n");
            sb.Append("  dismissed: ").Append(Dismissed).Append("\n");
            sb.Append("  Fixed: ").Append(Fixed).Append("\n");
            sb.Append("  solved: ").Append(Solved).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StatisticStatusV2);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StatisticStatusV2 input)
        {
            if (input == null) return false;
            if (this.Unresolved != input.Unresolved || (this.Unresolved != null && !this.Unresolved.Equals(input.Unresolved))) return false;
            if (this.Resolved != input.Resolved || (this.Resolved != null && !this.Resolved.Equals(input.Resolved))) return false;
            if (this.Dismissed != input.Dismissed || (this.Dismissed != null && !this.Dismissed.Equals(input.Dismissed))) return false;
            if (this.Fixed != input.Fixed || (this.Fixed != null && !this.Fixed.Equals(input.Fixed))) return false;
            if (this.Solved != input.Solved || (this.Solved != null && !this.Solved.Equals(input.Solved))) return false;

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
                if (this.Unresolved != null) hashCode = hashCode * 59 + this.Unresolved.GetHashCode();
                if (this.Resolved != null) hashCode = hashCode * 59 + this.Resolved.GetHashCode();
                if (this.Dismissed != null) hashCode = hashCode * 59 + this.Dismissed.GetHashCode();
                if (this.Fixed != null) hashCode = hashCode * 59 + this.Fixed.GetHashCode();
                if (this.Solved != null) hashCode = hashCode * 59 + this.Solved.GetHashCode();
                return hashCode;
            }
        }
    }
}
