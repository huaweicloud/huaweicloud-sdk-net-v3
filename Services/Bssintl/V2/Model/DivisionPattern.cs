using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bssintl.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DivisionPattern 
    {

        /// <summary>
        /// 阶梯类型，1：一次分档模式、2：累计分档模式
        /// </summary>
        [JsonProperty("pattern_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? PatternType { get; set; }

        /// <summary>
        /// 分档类型，1：STEP，按档拆分定价、2：TIER，按最终档定价
        /// </summary>
        [JsonProperty("division_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? DivisionType { get; set; }

        /// <summary>
        /// 阶梯分档列表
        /// </summary>
        [JsonProperty("division_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<Division> DivisionList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DivisionPattern {\n");
            sb.Append("  patternType: ").Append(PatternType).Append("\n");
            sb.Append("  divisionType: ").Append(DivisionType).Append("\n");
            sb.Append("  divisionList: ").Append(DivisionList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DivisionPattern);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DivisionPattern input)
        {
            if (input == null) return false;
            if (this.PatternType != input.PatternType || (this.PatternType != null && !this.PatternType.Equals(input.PatternType))) return false;
            if (this.DivisionType != input.DivisionType || (this.DivisionType != null && !this.DivisionType.Equals(input.DivisionType))) return false;
            if (this.DivisionList != input.DivisionList || (this.DivisionList != null && input.DivisionList != null && !this.DivisionList.SequenceEqual(input.DivisionList))) return false;

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
                if (this.PatternType != null) hashCode = hashCode * 59 + this.PatternType.GetHashCode();
                if (this.DivisionType != null) hashCode = hashCode * 59 + this.DivisionType.GetHashCode();
                if (this.DivisionList != null) hashCode = hashCode * 59 + this.DivisionList.GetHashCode();
                return hashCode;
            }
        }
    }
}
