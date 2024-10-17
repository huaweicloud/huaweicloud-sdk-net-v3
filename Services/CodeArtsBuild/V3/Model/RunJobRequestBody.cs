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
    /// 执行任务接口请求体
    /// </summary>
    public class RunJobRequestBody 
    {

        /// <summary>
        /// 构建任务ID；编辑构建任务时，浏览器URL末尾的32位数字、字母组合的字符串
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 自定义参数
        /// </summary>
        [JsonProperty("parameter", NullValueHandling = NullValueHandling.Ignore)]
        public List<ParameterItem> Parameter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("scm", NullValueHandling = NullValueHandling.Ignore)]
        public Scm Scm { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RunJobRequestBody {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  Parameter: ").Append(Parameter).Append("\n");
            sb.Append("  scm: ").Append(Scm).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RunJobRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RunJobRequestBody input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.Parameter != input.Parameter || (this.Parameter != null && input.Parameter != null && !this.Parameter.SequenceEqual(input.Parameter))) return false;
            if (this.Scm != input.Scm || (this.Scm != null && !this.Scm.Equals(input.Scm))) return false;

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
                if (this.Parameter != null) hashCode = hashCode * 59 + this.Parameter.GetHashCode();
                if (this.Scm != null) hashCode = hashCode * 59 + this.Scm.GetHashCode();
                return hashCode;
            }
        }
    }
}
