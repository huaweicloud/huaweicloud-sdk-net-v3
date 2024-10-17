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
    public class LineCompareResult 
    {

        /// <summary>
        /// 行对比任务的id。
        /// </summary>
        [JsonProperty("compare_task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CompareTaskId { get; set; }

        /// <summary>
        /// 行对比结果概览。
        /// </summary>
        [JsonProperty("line_compare_overview", NullValueHandling = NullValueHandling.Ignore)]
        public List<LineCompareResultOverview> LineCompareOverview { get; set; }

        /// <summary>
        /// 行对比结果概览总数。
        /// </summary>
        [JsonProperty("line_compare_overview_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? LineCompareOverviewCount { get; set; }

        /// <summary>
        /// 行对比结果详情。
        /// </summary>
        [JsonProperty("line_compare_details", NullValueHandling = NullValueHandling.Ignore)]
        public List<LineCompareResultDetails> LineCompareDetails { get; set; }

        /// <summary>
        /// 错误码。
        /// </summary>
        [JsonProperty("error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息。
        /// </summary>
        [JsonProperty("error_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMsg { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LineCompareResult {\n");
            sb.Append("  compareTaskId: ").Append(CompareTaskId).Append("\n");
            sb.Append("  lineCompareOverview: ").Append(LineCompareOverview).Append("\n");
            sb.Append("  lineCompareOverviewCount: ").Append(LineCompareOverviewCount).Append("\n");
            sb.Append("  lineCompareDetails: ").Append(LineCompareDetails).Append("\n");
            sb.Append("  errorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  errorMsg: ").Append(ErrorMsg).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LineCompareResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LineCompareResult input)
        {
            if (input == null) return false;
            if (this.CompareTaskId != input.CompareTaskId || (this.CompareTaskId != null && !this.CompareTaskId.Equals(input.CompareTaskId))) return false;
            if (this.LineCompareOverview != input.LineCompareOverview || (this.LineCompareOverview != null && input.LineCompareOverview != null && !this.LineCompareOverview.SequenceEqual(input.LineCompareOverview))) return false;
            if (this.LineCompareOverviewCount != input.LineCompareOverviewCount || (this.LineCompareOverviewCount != null && !this.LineCompareOverviewCount.Equals(input.LineCompareOverviewCount))) return false;
            if (this.LineCompareDetails != input.LineCompareDetails || (this.LineCompareDetails != null && input.LineCompareDetails != null && !this.LineCompareDetails.SequenceEqual(input.LineCompareDetails))) return false;
            if (this.ErrorCode != input.ErrorCode || (this.ErrorCode != null && !this.ErrorCode.Equals(input.ErrorCode))) return false;
            if (this.ErrorMsg != input.ErrorMsg || (this.ErrorMsg != null && !this.ErrorMsg.Equals(input.ErrorMsg))) return false;

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
                if (this.CompareTaskId != null) hashCode = hashCode * 59 + this.CompareTaskId.GetHashCode();
                if (this.LineCompareOverview != null) hashCode = hashCode * 59 + this.LineCompareOverview.GetHashCode();
                if (this.LineCompareOverviewCount != null) hashCode = hashCode * 59 + this.LineCompareOverviewCount.GetHashCode();
                if (this.LineCompareDetails != null) hashCode = hashCode * 59 + this.LineCompareDetails.GetHashCode();
                if (this.ErrorCode != null) hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.ErrorMsg != null) hashCode = hashCode * 59 + this.ErrorMsg.GetHashCode();
                return hashCode;
            }
        }
    }
}
