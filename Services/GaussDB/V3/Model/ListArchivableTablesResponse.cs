using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListArchivableTablesResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：  总记录数。  **取值范围**：  大于等于0。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// **参数解释**：  可归档表信息。
        /// </summary>
        [JsonProperty("archivable_tables", NullValueHandling = NullValueHandling.Ignore)]
        public List<ArchivableTable> ArchivableTables { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListArchivableTablesResponse {\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  archivableTables: ").Append(ArchivableTables).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListArchivableTablesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListArchivableTablesResponse input)
        {
            if (input == null) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;
            if (this.ArchivableTables != input.ArchivableTables || (this.ArchivableTables != null && input.ArchivableTables != null && !this.ArchivableTables.SequenceEqual(input.ArchivableTables))) return false;

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
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.ArchivableTables != null) hashCode = hashCode * 59 + this.ArchivableTables.GetHashCode();
                return hashCode;
            }
        }
    }
}
