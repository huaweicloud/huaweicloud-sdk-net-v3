using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsDeploy.V2.Model
{
    /// <summary>
    /// 部署任务触发场景配置
    /// </summary>
    public class TaskTriggerVO 
    {

        /// <summary>
        /// 部署任务允许执行的场景。其中0：所有执行请求均可，1：只允许流水线触发
        /// </summary>
        [JsonProperty("trigger_source", NullValueHandling = NullValueHandling.Ignore)]
        public string TriggerSource { get; set; }

        /// <summary>
        /// 当任务只允许流水线触发执行时，流水线传递的来源信息，当前只有CloudArtifact
        /// </summary>
        [JsonProperty("artifact_source_system", NullValueHandling = NullValueHandling.Ignore)]
        public string ArtifactSourceSystem { get; set; }

        /// <summary>
        /// 当任务只允许流水线触发执行时，对应流水线源的制品仓库类型（generic、docker）
        /// </summary>
        [JsonProperty("artifact_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ArtifactType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskTriggerVO {\n");
            sb.Append("  triggerSource: ").Append(TriggerSource).Append("\n");
            sb.Append("  artifactSourceSystem: ").Append(ArtifactSourceSystem).Append("\n");
            sb.Append("  artifactType: ").Append(ArtifactType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TaskTriggerVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TaskTriggerVO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TriggerSource == input.TriggerSource ||
                    (this.TriggerSource != null &&
                    this.TriggerSource.Equals(input.TriggerSource))
                ) && 
                (
                    this.ArtifactSourceSystem == input.ArtifactSourceSystem ||
                    (this.ArtifactSourceSystem != null &&
                    this.ArtifactSourceSystem.Equals(input.ArtifactSourceSystem))
                ) && 
                (
                    this.ArtifactType == input.ArtifactType ||
                    (this.ArtifactType != null &&
                    this.ArtifactType.Equals(input.ArtifactType))
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
                if (this.TriggerSource != null)
                    hashCode = hashCode * 59 + this.TriggerSource.GetHashCode();
                if (this.ArtifactSourceSystem != null)
                    hashCode = hashCode * 59 + this.ArtifactSourceSystem.GetHashCode();
                if (this.ArtifactType != null)
                    hashCode = hashCode * 59 + this.ArtifactType.GetHashCode();
                return hashCode;
            }
        }
    }
}
