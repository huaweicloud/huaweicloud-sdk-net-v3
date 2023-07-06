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
    public class LineCompareResultDetails 
    {

        /// <summary>
        /// 源库名称。
        /// </summary>
        [JsonProperty("source_db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceDbName { get; set; }

        /// <summary>
        /// 该库的表的行对比详情。
        /// </summary>
        [JsonProperty("line_compare_detail", NullValueHandling = NullValueHandling.Ignore)]
        public List<LineCompareDetail> LineCompareDetail { get; set; }

        /// <summary>
        /// 该库的行对比结果详情总数。
        /// </summary>
        [JsonProperty("line_compare_detail_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? LineCompareDetailCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LineCompareResultDetails {\n");
            sb.Append("  sourceDbName: ").Append(SourceDbName).Append("\n");
            sb.Append("  lineCompareDetail: ").Append(LineCompareDetail).Append("\n");
            sb.Append("  lineCompareDetailCount: ").Append(LineCompareDetailCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LineCompareResultDetails);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LineCompareResultDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SourceDbName == input.SourceDbName ||
                    (this.SourceDbName != null &&
                    this.SourceDbName.Equals(input.SourceDbName))
                ) && 
                (
                    this.LineCompareDetail == input.LineCompareDetail ||
                    this.LineCompareDetail != null &&
                    input.LineCompareDetail != null &&
                    this.LineCompareDetail.SequenceEqual(input.LineCompareDetail)
                ) && 
                (
                    this.LineCompareDetailCount == input.LineCompareDetailCount ||
                    (this.LineCompareDetailCount != null &&
                    this.LineCompareDetailCount.Equals(input.LineCompareDetailCount))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.SourceDbName != null)
                    hashCode = hashCode * 59 + this.SourceDbName.GetHashCode();
                if (this.LineCompareDetail != null)
                    hashCode = hashCode * 59 + this.LineCompareDetail.GetHashCode();
                if (this.LineCompareDetailCount != null)
                    hashCode = hashCode * 59 + this.LineCompareDetailCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
