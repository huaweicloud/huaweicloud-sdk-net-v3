using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsBuild.V3.Model
{
    /// <summary>
    /// 结果
    /// </summary>
    public class ShowReportSummaryBodyResult 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("summary", NullValueHandling = NullValueHandling.Ignore)]
        public ShowReportSummary Summary { get; set; }

        /// <summary>
        /// 单元测试报告列表
        /// </summary>
        [JsonProperty("sub_summarys", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowReportSummary> SubSummarys { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowReportSummaryBodyResult {\n");
            sb.Append("  summary: ").Append(Summary).Append("\n");
            sb.Append("  subSummarys: ").Append(SubSummarys).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowReportSummaryBodyResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowReportSummaryBodyResult input)
        {
            if (input == null) return false;
            if (this.Summary != input.Summary || (this.Summary != null && !this.Summary.Equals(input.Summary))) return false;
            if (this.SubSummarys != input.SubSummarys || (this.SubSummarys != null && input.SubSummarys != null && !this.SubSummarys.SequenceEqual(input.SubSummarys))) return false;

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
                if (this.Summary != null) hashCode = hashCode * 59 + this.Summary.GetHashCode();
                if (this.SubSummarys != null) hashCode = hashCode * 59 + this.SubSummarys.GetHashCode();
                return hashCode;
            }
        }
    }
}
