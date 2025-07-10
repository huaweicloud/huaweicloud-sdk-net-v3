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
    /// 
    /// </summary>
    public class JobPipelineInfoItems 
    {

        /// <summary>
        /// 构建执行SCM
        /// </summary>
        [JsonProperty("scms", NullValueHandling = NullValueHandling.Ignore)]
        public List<CreateBuildJobScm> Scms { get; set; }

        /// <summary>
        /// 参数
        /// </summary>
        [JsonProperty("parameters", NullValueHandling = NullValueHandling.Ignore)]
        public List<JobPipelineInfoParameters> Parameters { get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [JsonProperty("job_name", NullValueHandling = NullValueHandling.Ignore)]
        public string JobName { get; set; }

        /// <summary>
        /// 任务名称信息
        /// </summary>
        [JsonProperty("job_name_massage", NullValueHandling = NullValueHandling.Ignore)]
        public string JobNameMassage { get; set; }

        /// <summary>
        /// 任务名称正则
        /// </summary>
        [JsonProperty("job_name_regex", NullValueHandling = NullValueHandling.Ignore)]
        public string JobNameRegex { get; set; }

        /// <summary>
        /// 任务名称正则
        /// </summary>
        [JsonProperty("source_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceCode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobPipelineInfoItems {\n");
            sb.Append("  scms: ").Append(Scms).Append("\n");
            sb.Append("  parameters: ").Append(Parameters).Append("\n");
            sb.Append("  jobName: ").Append(JobName).Append("\n");
            sb.Append("  jobNameMassage: ").Append(JobNameMassage).Append("\n");
            sb.Append("  jobNameRegex: ").Append(JobNameRegex).Append("\n");
            sb.Append("  sourceCode: ").Append(SourceCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JobPipelineInfoItems);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JobPipelineInfoItems input)
        {
            if (input == null) return false;
            if (this.Scms != input.Scms || (this.Scms != null && input.Scms != null && !this.Scms.SequenceEqual(input.Scms))) return false;
            if (this.Parameters != input.Parameters || (this.Parameters != null && input.Parameters != null && !this.Parameters.SequenceEqual(input.Parameters))) return false;
            if (this.JobName != input.JobName || (this.JobName != null && !this.JobName.Equals(input.JobName))) return false;
            if (this.JobNameMassage != input.JobNameMassage || (this.JobNameMassage != null && !this.JobNameMassage.Equals(input.JobNameMassage))) return false;
            if (this.JobNameRegex != input.JobNameRegex || (this.JobNameRegex != null && !this.JobNameRegex.Equals(input.JobNameRegex))) return false;
            if (this.SourceCode != input.SourceCode || (this.SourceCode != null && !this.SourceCode.Equals(input.SourceCode))) return false;

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
                if (this.Scms != null) hashCode = hashCode * 59 + this.Scms.GetHashCode();
                if (this.Parameters != null) hashCode = hashCode * 59 + this.Parameters.GetHashCode();
                if (this.JobName != null) hashCode = hashCode * 59 + this.JobName.GetHashCode();
                if (this.JobNameMassage != null) hashCode = hashCode * 59 + this.JobNameMassage.GetHashCode();
                if (this.JobNameRegex != null) hashCode = hashCode * 59 + this.JobNameRegex.GetHashCode();
                if (this.SourceCode != null) hashCode = hashCode * 59 + this.SourceCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
