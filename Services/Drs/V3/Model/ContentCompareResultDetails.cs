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
    public class ContentCompareResultDetails 
    {

        /// <summary>
        /// 源库名称。
        /// </summary>
        [JsonProperty("source_db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceDbName { get; set; }

        /// <summary>
        /// 该库的表的内容对比详情。
        /// </summary>
        [JsonProperty("content_compare_detail", NullValueHandling = NullValueHandling.Ignore)]
        public List<ContentCompareDetail> ContentCompareDetail { get; set; }

        /// <summary>
        /// 内容对比结果详情总数。
        /// </summary>
        [JsonProperty("content_compare_detail_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ContentCompareDetailCount { get; set; }

        /// <summary>
        /// 该库的表的内容对比详情(无法对比的表)。
        /// </summary>
        [JsonProperty("content_uncompare_detail", NullValueHandling = NullValueHandling.Ignore)]
        public List<ContentCompareDetail> ContentUncompareDetail { get; set; }

        /// <summary>
        /// 内容对比结果详情总数(无法对比的表)。
        /// </summary>
        [JsonProperty("content_uncompare_detail_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ContentUncompareDetailCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContentCompareResultDetails {\n");
            sb.Append("  sourceDbName: ").Append(SourceDbName).Append("\n");
            sb.Append("  contentCompareDetail: ").Append(ContentCompareDetail).Append("\n");
            sb.Append("  contentCompareDetailCount: ").Append(ContentCompareDetailCount).Append("\n");
            sb.Append("  contentUncompareDetail: ").Append(ContentUncompareDetail).Append("\n");
            sb.Append("  contentUncompareDetailCount: ").Append(ContentUncompareDetailCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ContentCompareResultDetails);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ContentCompareResultDetails input)
        {
            if (input == null) return false;
            if (this.SourceDbName != input.SourceDbName || (this.SourceDbName != null && !this.SourceDbName.Equals(input.SourceDbName))) return false;
            if (this.ContentCompareDetail != input.ContentCompareDetail || (this.ContentCompareDetail != null && input.ContentCompareDetail != null && !this.ContentCompareDetail.SequenceEqual(input.ContentCompareDetail))) return false;
            if (this.ContentCompareDetailCount != input.ContentCompareDetailCount || (this.ContentCompareDetailCount != null && !this.ContentCompareDetailCount.Equals(input.ContentCompareDetailCount))) return false;
            if (this.ContentUncompareDetail != input.ContentUncompareDetail || (this.ContentUncompareDetail != null && input.ContentUncompareDetail != null && !this.ContentUncompareDetail.SequenceEqual(input.ContentUncompareDetail))) return false;
            if (this.ContentUncompareDetailCount != input.ContentUncompareDetailCount || (this.ContentUncompareDetailCount != null && !this.ContentUncompareDetailCount.Equals(input.ContentUncompareDetailCount))) return false;

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
                if (this.ContentCompareDetail != null) hashCode = hashCode * 59 + this.ContentCompareDetail.GetHashCode();
                if (this.ContentCompareDetailCount != null) hashCode = hashCode * 59 + this.ContentCompareDetailCount.GetHashCode();
                if (this.ContentUncompareDetail != null) hashCode = hashCode * 59 + this.ContentUncompareDetail.GetHashCode();
                if (this.ContentUncompareDetailCount != null) hashCode = hashCode * 59 + this.ContentUncompareDetailCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
