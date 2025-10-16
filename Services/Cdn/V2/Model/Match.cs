using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V2.Model
{
    /// <summary>
    /// **参数解释：** 规则匹配条件 **约束限制：** 不涉及
    /// </summary>
    public class Match 
    {

        /// <summary>
        /// **参数解释：** 逻辑运算符 **约束限制：** 不涉及 **取值范围：** - and: 与关系 - or: 或关系 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("logic", NullValueHandling = NullValueHandling.Ignore)]
        public string Logic { get; set; }

        /// <summary>
        /// **参数解释：** 匹配条件列表 **约束限制：** 不涉及
        /// </summary>
        [JsonProperty("criteria", NullValueHandling = NullValueHandling.Ignore)]
        public List<CriteriaItem> Criteria { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Match {\n");
            sb.Append("  logic: ").Append(Logic).Append("\n");
            sb.Append("  criteria: ").Append(Criteria).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Match);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Match input)
        {
            if (input == null) return false;
            if (this.Logic != input.Logic || (this.Logic != null && !this.Logic.Equals(input.Logic))) return false;
            if (this.Criteria != input.Criteria || (this.Criteria != null && input.Criteria != null && !this.Criteria.SequenceEqual(input.Criteria))) return false;

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
                if (this.Logic != null) hashCode = hashCode * 59 + this.Logic.GetHashCode();
                if (this.Criteria != null) hashCode = hashCode * 59 + this.Criteria.GetHashCode();
                return hashCode;
            }
        }
    }
}
