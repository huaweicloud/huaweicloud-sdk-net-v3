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
    public class ShowJobPipelineInfoRequest 
    {

        /// <summary>
        /// 构建的任务ID； 编辑构建任务时，浏览器URL末尾的32位数字、字母组合的字符串。
        /// </summary>
        [SDKProperty("job_id", IsPath = true)]
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 输入\&quot;true\&quot;或者\&quot;false\&quot;来控制返回参数是不是完整的
        /// </summary>
        [SDKProperty("all", IsQuery = true)]
        [JsonProperty("all", NullValueHandling = NullValueHandling.Ignore)]
        public string All { get; set; }

        /// <summary>
        /// 移除未使用的参数
        /// </summary>
        [SDKProperty("check_param_used", IsQuery = true)]
        [JsonProperty("check_param_used", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckParamUsed { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowJobPipelineInfoRequest {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  all: ").Append(All).Append("\n");
            sb.Append("  checkParamUsed: ").Append(CheckParamUsed).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowJobPipelineInfoRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowJobPipelineInfoRequest input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.All != input.All || (this.All != null && !this.All.Equals(input.All))) return false;
            if (this.CheckParamUsed != input.CheckParamUsed || (this.CheckParamUsed != null && !this.CheckParamUsed.Equals(input.CheckParamUsed))) return false;

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
                if (this.All != null) hashCode = hashCode * 59 + this.All.GetHashCode();
                if (this.CheckParamUsed != null) hashCode = hashCode * 59 + this.CheckParamUsed.GetHashCode();
                return hashCode;
            }
        }
    }
}
