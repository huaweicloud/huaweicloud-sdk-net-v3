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
    public class QueryCompareResultReq 
    {

        /// <summary>
        /// 任务id。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 请求查询结果的对象级对比任务id。
        /// </summary>
        [JsonProperty("object_level_compare_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectLevelCompareId { get; set; }

        /// <summary>
        /// 请求查询结果的行对比任务id。
        /// </summary>
        [JsonProperty("line_compare_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LineCompareId { get; set; }

        /// <summary>
        /// 请求查询结果的内容对比任务id。
        /// </summary>
        [JsonProperty("content_compare_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ContentCompareId { get; set; }

        /// <summary>
        /// 分页查询的当前页码，对查询对比任务的结果生效。
        /// </summary>
        [JsonProperty("current_page", NullValueHandling = NullValueHandling.Ignore)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// 分页查询的每页个数，对查询对比任务的结果生效。
        /// </summary>
        [JsonProperty("per_page", NullValueHandling = NullValueHandling.Ignore)]
        public int? PerPage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryCompareResultReq {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  objectLevelCompareId: ").Append(ObjectLevelCompareId).Append("\n");
            sb.Append("  lineCompareId: ").Append(LineCompareId).Append("\n");
            sb.Append("  contentCompareId: ").Append(ContentCompareId).Append("\n");
            sb.Append("  currentPage: ").Append(CurrentPage).Append("\n");
            sb.Append("  perPage: ").Append(PerPage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryCompareResultReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryCompareResultReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.ObjectLevelCompareId == input.ObjectLevelCompareId ||
                    (this.ObjectLevelCompareId != null &&
                    this.ObjectLevelCompareId.Equals(input.ObjectLevelCompareId))
                ) && 
                (
                    this.LineCompareId == input.LineCompareId ||
                    (this.LineCompareId != null &&
                    this.LineCompareId.Equals(input.LineCompareId))
                ) && 
                (
                    this.ContentCompareId == input.ContentCompareId ||
                    (this.ContentCompareId != null &&
                    this.ContentCompareId.Equals(input.ContentCompareId))
                ) && 
                (
                    this.CurrentPage == input.CurrentPage ||
                    (this.CurrentPage != null &&
                    this.CurrentPage.Equals(input.CurrentPage))
                ) && 
                (
                    this.PerPage == input.PerPage ||
                    (this.PerPage != null &&
                    this.PerPage.Equals(input.PerPage))
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
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.ObjectLevelCompareId != null)
                    hashCode = hashCode * 59 + this.ObjectLevelCompareId.GetHashCode();
                if (this.LineCompareId != null)
                    hashCode = hashCode * 59 + this.LineCompareId.GetHashCode();
                if (this.ContentCompareId != null)
                    hashCode = hashCode * 59 + this.ContentCompareId.GetHashCode();
                if (this.CurrentPage != null)
                    hashCode = hashCode * 59 + this.CurrentPage.GetHashCode();
                if (this.PerPage != null)
                    hashCode = hashCode * 59 + this.PerPage.GetHashCode();
                return hashCode;
            }
        }
    }
}
