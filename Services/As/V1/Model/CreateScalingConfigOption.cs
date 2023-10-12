using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.As.V1.Model
{
    /// <summary>
    /// 创建伸缩配置请求
    /// </summary>
    public class CreateScalingConfigOption 
    {

        /// <summary>
        /// 伸缩配置名称(1-64个字符)，只能包含中文、字母、数字、下划线或中划线。
        /// </summary>
        [JsonProperty("scaling_configuration_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ScalingConfigurationName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("instance_config", NullValueHandling = NullValueHandling.Ignore)]
        public InstanceConfig InstanceConfig { get; set; }

        /// <summary>
        /// 源伸缩配置ID，通过ID获取原有伸缩配置信息进行修改，传入需修改的配置字段若为null值不产生修改，其他任何值（包括空值）均覆盖原有值。注意：若传入instance_id则优先使用instance_id获取到的值进行修改。
        /// </summary>
        [JsonProperty("source_scaling_configuration_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceScalingConfigurationId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateScalingConfigOption {\n");
            sb.Append("  scalingConfigurationName: ").Append(ScalingConfigurationName).Append("\n");
            sb.Append("  instanceConfig: ").Append(InstanceConfig).Append("\n");
            sb.Append("  sourceScalingConfigurationId: ").Append(SourceScalingConfigurationId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateScalingConfigOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateScalingConfigOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ScalingConfigurationName == input.ScalingConfigurationName ||
                    (this.ScalingConfigurationName != null &&
                    this.ScalingConfigurationName.Equals(input.ScalingConfigurationName))
                ) && 
                (
                    this.InstanceConfig == input.InstanceConfig ||
                    (this.InstanceConfig != null &&
                    this.InstanceConfig.Equals(input.InstanceConfig))
                ) && 
                (
                    this.SourceScalingConfigurationId == input.SourceScalingConfigurationId ||
                    (this.SourceScalingConfigurationId != null &&
                    this.SourceScalingConfigurationId.Equals(input.SourceScalingConfigurationId))
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
                if (this.ScalingConfigurationName != null)
                    hashCode = hashCode * 59 + this.ScalingConfigurationName.GetHashCode();
                if (this.InstanceConfig != null)
                    hashCode = hashCode * 59 + this.InstanceConfig.GetHashCode();
                if (this.SourceScalingConfigurationId != null)
                    hashCode = hashCode * 59 + this.SourceScalingConfigurationId.GetHashCode();
                return hashCode;
            }
        }
    }
}
