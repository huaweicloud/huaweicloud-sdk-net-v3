using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsArtifact.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BasePaginationResponseEntityV5 
    {

        /// <summary>
        /// **参数解释**: 总记录数。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("total_records", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalRecords { get; set; }

        /// <summary>
        /// **参数解释**: 总页数。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("total_pages", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalPages { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BasePaginationResponseEntityV5 {\n");
            sb.Append("  totalRecords: ").Append(TotalRecords).Append("\n");
            sb.Append("  totalPages: ").Append(TotalPages).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BasePaginationResponseEntityV5);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BasePaginationResponseEntityV5 input)
        {
            if (input == null) return false;
            if (this.TotalRecords != input.TotalRecords || (this.TotalRecords != null && !this.TotalRecords.Equals(input.TotalRecords))) return false;
            if (this.TotalPages != input.TotalPages || (this.TotalPages != null && !this.TotalPages.Equals(input.TotalPages))) return false;

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
                if (this.TotalRecords != null) hashCode = hashCode * 59 + this.TotalRecords.GetHashCode();
                if (this.TotalPages != null) hashCode = hashCode * 59 + this.TotalPages.GetHashCode();
                return hashCode;
            }
        }
    }
}
