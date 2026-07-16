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
    /// 创建训练作业的作业请求体和相应体。
    /// </summary>
    public class Job 
    {

        /// <summary>
        /// **参数解释**：训练作业类型。 **约束限制**：不涉及。 **取值范围**： - job：普通作业 - federated_pool_job：资源池联邦作业 - edge_job：边缘作业 - hetero_job：异构作业 - mrs_job：MRS作业 - autosearch_job：自动化搜索作业 - diag_job：诊断作业 - visualization_job：可视化作业  **默认取值**：job。
        /// </summary>
        [JsonProperty("kind", NullValueHandling = NullValueHandling.Ignore)]
        public string Kind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public JobMetadata Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("algorithm", NullValueHandling = NullValueHandling.Ignore)]
        public JobAlgorithm Algorithm { get; set; }

        /// <summary>
        /// **参数解释**：任务列表。该功能暂未实现。 **约束限制**：不涉及。
        /// </summary>
        [JsonProperty("tasks", NullValueHandling = NullValueHandling.Ignore)]
        public List<Task> Tasks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("spec", NullValueHandling = NullValueHandling.Ignore)]
        public Spec Spec { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("endpoints", NullValueHandling = NullValueHandling.Ignore)]
        public JobEndpointsReq Endpoints { get; set; }

        /// <summary>
        /// **参数解释**：类型。 **约束限制**：不涉及。 **取值范围**：SFT（全量微调）、PRETRAIN（预训练）、LORA（lora微调）、DPO（dpo强化学习）、RFT（rft强化学习）
        /// </summary>
        [JsonProperty("train_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TrainType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ftjob_config", NullValueHandling = NullValueHandling.Ignore)]
        public MasJobConfig FtjobConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Job {\n");
            sb.Append("  kind: ").Append(Kind).Append("\n");
            sb.Append("  metadata: ").Append(Metadata).Append("\n");
            sb.Append("  algorithm: ").Append(Algorithm).Append("\n");
            sb.Append("  tasks: ").Append(Tasks).Append("\n");
            sb.Append("  spec: ").Append(Spec).Append("\n");
            sb.Append("  endpoints: ").Append(Endpoints).Append("\n");
            sb.Append("  trainType: ").Append(TrainType).Append("\n");
            sb.Append("  ftjobConfig: ").Append(FtjobConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Job);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Job input)
        {
            if (input == null) return false;
            if (this.Kind != input.Kind || (this.Kind != null && !this.Kind.Equals(input.Kind))) return false;
            if (this.Metadata != input.Metadata || (this.Metadata != null && !this.Metadata.Equals(input.Metadata))) return false;
            if (this.Algorithm != input.Algorithm || (this.Algorithm != null && !this.Algorithm.Equals(input.Algorithm))) return false;
            if (this.Tasks != input.Tasks || (this.Tasks != null && input.Tasks != null && !this.Tasks.SequenceEqual(input.Tasks))) return false;
            if (this.Spec != input.Spec || (this.Spec != null && !this.Spec.Equals(input.Spec))) return false;
            if (this.Endpoints != input.Endpoints || (this.Endpoints != null && !this.Endpoints.Equals(input.Endpoints))) return false;
            if (this.TrainType != input.TrainType || (this.TrainType != null && !this.TrainType.Equals(input.TrainType))) return false;
            if (this.FtjobConfig != input.FtjobConfig || (this.FtjobConfig != null && !this.FtjobConfig.Equals(input.FtjobConfig))) return false;

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
                if (this.Kind != null) hashCode = hashCode * 59 + this.Kind.GetHashCode();
                if (this.Metadata != null) hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Algorithm != null) hashCode = hashCode * 59 + this.Algorithm.GetHashCode();
                if (this.Tasks != null) hashCode = hashCode * 59 + this.Tasks.GetHashCode();
                if (this.Spec != null) hashCode = hashCode * 59 + this.Spec.GetHashCode();
                if (this.Endpoints != null) hashCode = hashCode * 59 + this.Endpoints.GetHashCode();
                if (this.TrainType != null) hashCode = hashCode * 59 + this.TrainType.GetHashCode();
                if (this.FtjobConfig != null) hashCode = hashCode * 59 + this.FtjobConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
