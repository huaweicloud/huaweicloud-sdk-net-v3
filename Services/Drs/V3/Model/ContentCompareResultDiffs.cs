using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ContentCompareResultDiffs 
    {

        /// <summary>
        /// 源库名称。
        /// </summary>
        [JsonProperty("source_db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceDbName { get; set; }

        /// <summary>
        /// 源库的表名称。
        /// </summary>
        [JsonProperty("source_table_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceTableName { get; set; }

        /// <summary>
        /// 内容对比结果差异。
        /// </summary>
        [JsonProperty("content_compare_diff", NullValueHandling = NullValueHandling.Ignore)]
        public List<ContentCompareDiff> ContentCompareDiff { get; set; }

        /// <summary>
        /// 内容对比结果差异总数。
        /// </summary>
        [JsonProperty("content_compare_diff_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ContentCompareDiffCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContentCompareResultDiffs {\n");
            sb.Append("  sourceDbName: ").Append(SourceDbName).Append("\n");
            sb.Append("  sourceTableName: ").Append(SourceTableName).Append("\n");
            sb.Append("  contentCompareDiff: ").Append(ContentCompareDiff).Append("\n");
            sb.Append("  contentCompareDiffCount: ").Append(ContentCompareDiffCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ContentCompareResultDiffs);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ContentCompareResultDiffs input)
        {
            if (input == null) return false;
            if (this.SourceDbName != input.SourceDbName || (this.SourceDbName != null && !this.SourceDbName.Equals(input.SourceDbName))) return false;
            if (this.SourceTableName != input.SourceTableName || (this.SourceTableName != null && !this.SourceTableName.Equals(input.SourceTableName))) return false;
            if (this.ContentCompareDiff != input.ContentCompareDiff || (this.ContentCompareDiff != null && input.ContentCompareDiff != null && !this.ContentCompareDiff.SequenceEqual(input.ContentCompareDiff))) return false;
            if (this.ContentCompareDiffCount != input.ContentCompareDiffCount || (this.ContentCompareDiffCount != null && !this.ContentCompareDiffCount.Equals(input.ContentCompareDiffCount))) return false;

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
                if (this.SourceDbName != null) hashCode = hashCode * 59 + this.SourceDbName.GetHashCode();
                if (this.SourceTableName != null) hashCode = hashCode * 59 + this.SourceTableName.GetHashCode();
                if (this.ContentCompareDiff != null) hashCode = hashCode * 59 + this.ContentCompareDiff.GetHashCode();
                if (this.ContentCompareDiffCount != null) hashCode = hashCode * 59 + this.ContentCompareDiffCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
