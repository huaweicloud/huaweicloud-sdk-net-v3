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
    /// 算法管理算法配置。
    /// </summary>
    public class Algorithm 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public AlgorithmMetadata Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("job_config", NullValueHandling = NullValueHandling.Ignore)]
        public AlgorithmJobConfig JobConfig { get; set; }

        /// <summary>
        /// 算法资源约束。可不设置。设置后，在算法使用于训练作业时，控制台会过滤可用的公共资源池。
        /// </summary>
        [JsonProperty("resource_requirements", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceRequirement> ResourceRequirements { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("advanced_config", NullValueHandling = NullValueHandling.Ignore)]
        public AlgorithmAdvancedConfig AdvancedConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Algorithm {\n");
            sb.Append("  metadata: ").Append(Metadata).Append("\n");
            sb.Append("  jobConfig: ").Append(JobConfig).Append("\n");
            sb.Append("  resourceRequirements: ").Append(ResourceRequirements).Append("\n");
            sb.Append("  advancedConfig: ").Append(AdvancedConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Algorithm);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Algorithm input)
        {
            if (input == null) return false;
            if (this.Metadata != input.Metadata || (this.Metadata != null && !this.Metadata.Equals(input.Metadata))) return false;
            if (this.JobConfig != input.JobConfig || (this.JobConfig != null && !this.JobConfig.Equals(input.JobConfig))) return false;
            if (this.ResourceRequirements != input.ResourceRequirements || (this.ResourceRequirements != null && input.ResourceRequirements != null && !this.ResourceRequirements.SequenceEqual(input.ResourceRequirements))) return false;
            if (this.AdvancedConfig != input.AdvancedConfig || (this.AdvancedConfig != null && !this.AdvancedConfig.Equals(input.AdvancedConfig))) return false;

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
                if (this.Metadata != null) hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.JobConfig != null) hashCode = hashCode * 59 + this.JobConfig.GetHashCode();
                if (this.ResourceRequirements != null) hashCode = hashCode * 59 + this.ResourceRequirements.GetHashCode();
                if (this.AdvancedConfig != null) hashCode = hashCode * 59 + this.AdvancedConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
