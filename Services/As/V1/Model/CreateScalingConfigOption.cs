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
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateScalingConfigOption {\n");
            sb.Append("  scalingConfigurationName: ").Append(ScalingConfigurationName).Append("\n");
            sb.Append("  instanceConfig: ").Append(InstanceConfig).Append("\n");
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
                return hashCode;
            }
        }
    }
}
