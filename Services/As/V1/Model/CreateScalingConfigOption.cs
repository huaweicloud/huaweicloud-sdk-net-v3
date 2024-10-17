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
        /// 源伸缩配置ID，通过该ID查询已有伸缩配置信息与instance_config中参数进行结合，创建新的伸缩配置。 说明：  - 若传入instance_config中的instance_id，则优先使用instance_id相关实例配置创建新的伸缩配置，source_scaling_configuration_id参数不生效。  - 若未传入instance_config中的instance_id，则使用source_scaling_configuration_id与instance_config中的参数相结合创建伸缩配置。         - 若instance_config中的参数值为null，则创建新伸缩配置时该字段不产生修改。         - 若instance_config中的参数值不为null，则创建新伸缩配置时该字段将覆盖原有值，其中值为空时，该字段会被清空。  - 若不指定source_scaling_configuration_id创建伸缩配置，则scaling_configuration_name和instance_config为必选。
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
            if (input == null) return false;
            if (this.ScalingConfigurationName != input.ScalingConfigurationName || (this.ScalingConfigurationName != null && !this.ScalingConfigurationName.Equals(input.ScalingConfigurationName))) return false;
            if (this.InstanceConfig != input.InstanceConfig || (this.InstanceConfig != null && !this.InstanceConfig.Equals(input.InstanceConfig))) return false;
            if (this.SourceScalingConfigurationId != input.SourceScalingConfigurationId || (this.SourceScalingConfigurationId != null && !this.SourceScalingConfigurationId.Equals(input.SourceScalingConfigurationId))) return false;

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
                if (this.ScalingConfigurationName != null) hashCode = hashCode * 59 + this.ScalingConfigurationName.GetHashCode();
                if (this.InstanceConfig != null) hashCode = hashCode * 59 + this.InstanceConfig.GetHashCode();
                if (this.SourceScalingConfigurationId != null) hashCode = hashCode * 59 + this.SourceScalingConfigurationId.GetHashCode();
                return hashCode;
            }
        }
    }
}
