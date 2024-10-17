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
    /// 停止构建任务接口请求体
    /// </summary>
    public class StopJobRequestBody 
    {

        /// <summary>
        /// 构建任务ID；编辑构建任务时，浏览器URL末尾的32位数字、字母组合的字符串
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 构建任务的构建编号，从1开始，每次构建递增1
        /// </summary>
        [JsonProperty("build_no", NullValueHandling = NullValueHandling.Ignore)]
        public string BuildNo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StopJobRequestBody {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  buildNo: ").Append(BuildNo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StopJobRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StopJobRequestBody input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.BuildNo != input.BuildNo || (this.BuildNo != null && !this.BuildNo.Equals(input.BuildNo))) return false;

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
                return hashCode;
            }
        }
    }
}
