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
    public class CriterionSetsInfo 
    {

        /// <summary>
        /// **参数解释：** 规则列表。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("criterionSetList", NullValueHandling = NullValueHandling.Ignore)]
        public List<CriterionSetListV2Body> CriterionSetList { get; set; }

        /// <summary>
        /// **参数解释：** 规则总数。 **取值范围：** ≥0
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CriterionSetsInfo {\n");
            sb.Append("  criterionSetList: ").Append(CriterionSetList).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CriterionSetsInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CriterionSetsInfo input)
        {
            if (input == null) return false;
            if (this.CriterionSetList != input.CriterionSetList || (this.CriterionSetList != null && input.CriterionSetList != null && !this.CriterionSetList.SequenceEqual(input.CriterionSetList))) return false;
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
                if (this.CriterionSetList != null) hashCode = hashCode * 59 + this.CriterionSetList.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
