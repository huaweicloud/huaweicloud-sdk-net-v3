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
    /// Request Object
    /// </summary>
    public class ShowJobConfigDiffRequest 
    {

        /// <summary>
        /// 构建的任务ID； 编辑构建任务时，浏览器URL末尾的32位数字、字母组合的字符串。
        /// </summary>
        [SDKProperty("job_id", IsPath = true)]
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 新记录的序号
        /// </summary>
        [SDKProperty("revisedl_no", IsQuery = true)]
        [JsonProperty("revisedl_no", NullValueHandling = NullValueHandling.Ignore)]
        public string RevisedlNo { get; set; }

        /// <summary>
        /// 原记录的序号
        /// </summary>
        [SDKProperty("original_no", IsQuery = true)]
        [JsonProperty("original_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginalNo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowJobConfigDiffRequest {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  revisedlNo: ").Append(RevisedlNo).Append("\n");
            sb.Append("  originalNo: ").Append(OriginalNo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowJobConfigDiffRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowJobConfigDiffRequest input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.RevisedlNo != input.RevisedlNo || (this.RevisedlNo != null && !this.RevisedlNo.Equals(input.RevisedlNo))) return false;
            if (this.OriginalNo != input.OriginalNo || (this.OriginalNo != null && !this.OriginalNo.Equals(input.OriginalNo))) return false;

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
                if (this.RevisedlNo != null) hashCode = hashCode * 59 + this.RevisedlNo.GetHashCode();
                if (this.OriginalNo != null) hashCode = hashCode * 59 + this.OriginalNo.GetHashCode();
                return hashCode;
            }
        }
    }
}
