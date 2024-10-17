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
    /// Response Object
    /// </summary>
    public class ListCompareResultResponse : SdkResponse
    {

        /// <summary>
        /// 任务id。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("object_level_compare_results", NullValueHandling = NullValueHandling.Ignore)]
        public ObjectCompareResult ObjectLevelCompareResults { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("line_compare_results", NullValueHandling = NullValueHandling.Ignore)]
        public LineCompareResult LineCompareResults { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("content_compare_results", NullValueHandling = NullValueHandling.Ignore)]
        public ContentCompareResult ContentCompareResults { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("compare_task_list_results", NullValueHandling = NullValueHandling.Ignore)]
        public CompareTaskListResult CompareTaskListResults { get; set; }

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
            sb.Append("class ListCompareResultResponse {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  objectLevelCompareResults: ").Append(ObjectLevelCompareResults).Append("\n");
            sb.Append("  lineCompareResults: ").Append(LineCompareResults).Append("\n");
            sb.Append("  contentCompareResults: ").Append(ContentCompareResults).Append("\n");
            sb.Append("  compareTaskListResults: ").Append(CompareTaskListResults).Append("\n");
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
            return this.Equals(input as ListCompareResultResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListCompareResultResponse input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.ObjectLevelCompareResults != input.ObjectLevelCompareResults || (this.ObjectLevelCompareResults != null && !this.ObjectLevelCompareResults.Equals(input.ObjectLevelCompareResults))) return false;
            if (this.LineCompareResults != input.LineCompareResults || (this.LineCompareResults != null && !this.LineCompareResults.Equals(input.LineCompareResults))) return false;
            if (this.ContentCompareResults != input.ContentCompareResults || (this.ContentCompareResults != null && !this.ContentCompareResults.Equals(input.ContentCompareResults))) return false;
            if (this.CompareTaskListResults != input.CompareTaskListResults || (this.CompareTaskListResults != null && !this.CompareTaskListResults.Equals(input.CompareTaskListResults))) return false;
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
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.ObjectLevelCompareResults != null) hashCode = hashCode * 59 + this.ObjectLevelCompareResults.GetHashCode();
                if (this.LineCompareResults != null) hashCode = hashCode * 59 + this.LineCompareResults.GetHashCode();
                if (this.ContentCompareResults != null) hashCode = hashCode * 59 + this.ContentCompareResults.GetHashCode();
                if (this.CompareTaskListResults != null) hashCode = hashCode * 59 + this.CompareTaskListResults.GetHashCode();
                if (this.ErrorCode != null) hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.ErrorMsg != null) hashCode = hashCode * 59 + this.ErrorMsg.GetHashCode();
                return hashCode;
            }
        }
    }
}
