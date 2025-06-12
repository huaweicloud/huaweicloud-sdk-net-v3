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
    public class DownloadJunitCoverageZipRequest 
    {

        /// <summary>
        /// 构建的任务ID； 编辑构建任务时，浏览器URL末尾的32位数字、字母组合的字符串。
        /// </summary>
        [SDKProperty("job_id", IsQuery = true)]
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 构建任务的构建编号，从1开始，每次构建递增1
        /// </summary>
        [SDKProperty("build_no", IsQuery = true)]
        [JsonProperty("build_no", NullValueHandling = NullValueHandling.Ignore)]
        public int? BuildNo { get; set; }

        /// <summary>
        /// 资源ID，下载覆盖率报告时使用
        /// </summary>
        [SDKProperty("root_id", IsQuery = true)]
        [JsonProperty("root_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RootId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DownloadJunitCoverageZipRequest {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  buildNo: ").Append(BuildNo).Append("\n");
            sb.Append("  rootId: ").Append(RootId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DownloadJunitCoverageZipRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DownloadJunitCoverageZipRequest input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.BuildNo != input.BuildNo || (this.BuildNo != null && !this.BuildNo.Equals(input.BuildNo))) return false;
            if (this.RootId != input.RootId || (this.RootId != null && !this.RootId.Equals(input.RootId))) return false;

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
                if (this.BuildNo != null) hashCode = hashCode * 59 + this.BuildNo.GetHashCode();
                if (this.RootId != null) hashCode = hashCode * 59 + this.RootId.GetHashCode();
                return hashCode;
            }
        }
    }
}
