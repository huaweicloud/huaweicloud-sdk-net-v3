using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 表筛选器。
    /// </summary>
    public class PublicationTableFilterInfoRequest 
    {

        /// <summary>
        /// 筛选关系。  为空时表示当前为最下级筛选器，不为空时表示当前项还有下级筛选器 不为空时取值范围：AND, OR
        /// </summary>
        [JsonProperty("relation", NullValueHandling = NullValueHandling.Ignore)]
        public string Relation { get; set; }

        /// <summary>
        /// 筛选字段（仅当筛选关系为空时生效，且筛选关系为空时必传）。
        /// </summary>
        [JsonProperty("column", NullValueHandling = NullValueHandling.Ignore)]
        public string Column { get; set; }

        /// <summary>
        /// 筛选条件（仅当筛选关系为空时生效，且筛选关系为空时必传）。 取值范围： &#x3D;, !&#x3D;, &gt;, &lt;, &gt;&#x3D;, &lt;&#x3D;, LIKE, NOT LIKE, IN
        /// </summary>
        [JsonProperty("condition", NullValueHandling = NullValueHandling.Ignore)]
        public string Condition { get; set; }

        /// <summary>
        /// 筛选值（仅当筛选关系为空时生效，且筛选关系为空时必传）。
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        /// <summary>
        /// 下级筛选器（仅当筛选关系不为空时生效，且筛选关系不为空时必传）。
        /// </summary>
        [JsonProperty("filters", NullValueHandling = NullValueHandling.Ignore)]
        public List<PublicationTableFilterInfoRequest> Filters { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PublicationTableFilterInfoRequest {\n");
            sb.Append("  relation: ").Append(Relation).Append("\n");
            sb.Append("  column: ").Append(Column).Append("\n");
            sb.Append("  condition: ").Append(Condition).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("  filters: ").Append(Filters).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PublicationTableFilterInfoRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PublicationTableFilterInfoRequest input)
        {
            if (input == null) return false;
            if (this.Relation != input.Relation || (this.Relation != null && !this.Relation.Equals(input.Relation))) return false;
            if (this.Column != input.Column || (this.Column != null && !this.Column.Equals(input.Column))) return false;
            if (this.Condition != input.Condition || (this.Condition != null && !this.Condition.Equals(input.Condition))) return false;
            if (this.Value != input.Value || (this.Value != null && !this.Value.Equals(input.Value))) return false;
            if (this.Filters != input.Filters || (this.Filters != null && input.Filters != null && !this.Filters.SequenceEqual(input.Filters))) return false;

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
                if (this.Relation != null) hashCode = hashCode * 59 + this.Relation.GetHashCode();
                if (this.Column != null) hashCode = hashCode * 59 + this.Column.GetHashCode();
                if (this.Condition != null) hashCode = hashCode * 59 + this.Condition.GetHashCode();
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Filters != null) hashCode = hashCode * 59 + this.Filters.GetHashCode();
                return hashCode;
            }
        }
    }
}
