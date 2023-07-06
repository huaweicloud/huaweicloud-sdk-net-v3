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
    public class ContentCompareResult 
    {

        /// <summary>
        /// 内容对比的任务id。
        /// </summary>
        [JsonProperty("compare_task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CompareTaskId { get; set; }

        /// <summary>
        /// 内容对比结果概览。
        /// </summary>
        [JsonProperty("content_compare_overview", NullValueHandling = NullValueHandling.Ignore)]
        public List<ContentCompareResultOverview> ContentCompareOverview { get; set; }

        /// <summary>
        /// 内容对比结果概览总数。
        /// </summary>
        [JsonProperty("content_compare_overview_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ContentCompareOverviewCount { get; set; }

        /// <summary>
        /// 内容对比结果详情。
        /// </summary>
        [JsonProperty("content_compare_details", NullValueHandling = NullValueHandling.Ignore)]
        public List<ContentCompareResultDetails> ContentCompareDetails { get; set; }

        /// <summary>
        /// 内容对比结果差异。
        /// </summary>
        [JsonProperty("content_compare_diffs", NullValueHandling = NullValueHandling.Ignore)]
        public List<ContentCompareResultDiffs> ContentCompareDiffs { get; set; }

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
            sb.Append("class ContentCompareResult {\n");
            sb.Append("  compareTaskId: ").Append(CompareTaskId).Append("\n");
            sb.Append("  contentCompareOverview: ").Append(ContentCompareOverview).Append("\n");
            sb.Append("  contentCompareOverviewCount: ").Append(ContentCompareOverviewCount).Append("\n");
            sb.Append("  contentCompareDetails: ").Append(ContentCompareDetails).Append("\n");
            sb.Append("  contentCompareDiffs: ").Append(ContentCompareDiffs).Append("\n");
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
            return this.Equals(input as ContentCompareResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ContentCompareResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CompareTaskId == input.CompareTaskId ||
                    (this.CompareTaskId != null &&
                    this.CompareTaskId.Equals(input.CompareTaskId))
                ) && 
                (
                    this.ContentCompareOverview == input.ContentCompareOverview ||
                    this.ContentCompareOverview != null &&
                    input.ContentCompareOverview != null &&
                    this.ContentCompareOverview.SequenceEqual(input.ContentCompareOverview)
                ) && 
                (
                    this.ContentCompareOverviewCount == input.ContentCompareOverviewCount ||
                    (this.ContentCompareOverviewCount != null &&
                    this.ContentCompareOverviewCount.Equals(input.ContentCompareOverviewCount))
                ) && 
                (
                    this.ContentCompareDetails == input.ContentCompareDetails ||
                    this.ContentCompareDetails != null &&
                    input.ContentCompareDetails != null &&
                    this.ContentCompareDetails.SequenceEqual(input.ContentCompareDetails)
                ) && 
                (
                    this.ContentCompareDiffs == input.ContentCompareDiffs ||
                    this.ContentCompareDiffs != null &&
                    input.ContentCompareDiffs != null &&
                    this.ContentCompareDiffs.SequenceEqual(input.ContentCompareDiffs)
                ) && 
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
                ) && 
                (
                    this.ErrorMsg == input.ErrorMsg ||
                    (this.ErrorMsg != null &&
                    this.ErrorMsg.Equals(input.ErrorMsg))
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
                if (this.CompareTaskId != null)
                    hashCode = hashCode * 59 + this.CompareTaskId.GetHashCode();
                if (this.ContentCompareOverview != null)
                    hashCode = hashCode * 59 + this.ContentCompareOverview.GetHashCode();
                if (this.ContentCompareOverviewCount != null)
                    hashCode = hashCode * 59 + this.ContentCompareOverviewCount.GetHashCode();
                if (this.ContentCompareDetails != null)
                    hashCode = hashCode * 59 + this.ContentCompareDetails.GetHashCode();
                if (this.ContentCompareDiffs != null)
                    hashCode = hashCode * 59 + this.ContentCompareDiffs.GetHashCode();
                if (this.ErrorCode != null)
                    hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.ErrorMsg != null)
                    hashCode = hashCode * 59 + this.ErrorMsg.GetHashCode();
                return hashCode;
            }
        }
    }
}
