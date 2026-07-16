using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 训练作业元信息。
    /// </summary>
    public class JobMetadata 
    {

        /// <summary>
        /// 训练作业名称。限制为1-64位只含数字、字母、下划线和中划线的名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 指定作业所处的工作空间，默认值为“0”。
        /// </summary>
        [JsonProperty("workspace_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// 对训练作业的描述，默认为“NULL”，字符串的长度限制为[0, 256]。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 训练作业高级功能配置，可选取值如下： - \&quot;job_template\&quot;: \&quot;Template RL\&quot;（异构作业）。 - \&quot;fault-tolerance/job-retry-num\&quot;: \&quot;3\&quot;（故障自动重启次数）。 - \&quot;jupyter-lab/enable\&quot;: \&quot;true\&quot;（JupyterLab训练应用程序）
        /// </summary>
        [JsonProperty("annotations", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Annotations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("training_experiment_reference", NullValueHandling = NullValueHandling.Ignore)]
        public TrainingExperimentRequest TrainingExperimentReference { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobMetadata {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  workspaceId: ").Append(WorkspaceId).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  annotations: ").Append(Annotations).Append("\n");
            sb.Append("  trainingExperimentReference: ").Append(TrainingExperimentReference).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JobMetadata);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JobMetadata input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.WorkspaceId != input.WorkspaceId || (this.WorkspaceId != null && !this.WorkspaceId.Equals(input.WorkspaceId))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Annotations != input.Annotations || (this.Annotations != null && input.Annotations != null && !this.Annotations.SequenceEqual(input.Annotations))) return false;
            if (this.TrainingExperimentReference != input.TrainingExperimentReference || (this.TrainingExperimentReference != null && !this.TrainingExperimentReference.Equals(input.TrainingExperimentReference))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.WorkspaceId != null) hashCode = hashCode * 59 + this.WorkspaceId.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Annotations != null) hashCode = hashCode * 59 + this.Annotations.GetHashCode();
                if (this.TrainingExperimentReference != null) hashCode = hashCode * 59 + this.TrainingExperimentReference.GetHashCode();
                return hashCode;
            }
        }
    }
}
