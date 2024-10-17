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
    /// 伸缩配置详情
    /// </summary>
    public class ScalingConfiguration 
    {

        /// <summary>
        /// 伸缩配置ID，全局唯一。
        /// </summary>
        [JsonProperty("scaling_configuration_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScalingConfigurationId { get; set; }

        /// <summary>
        /// 租户ID。
        /// </summary>
        [JsonProperty("tenant", NullValueHandling = NullValueHandling.Ignore)]
        public string Tenant { get; set; }

        /// <summary>
        /// 伸缩配置名称。
        /// </summary>
        [JsonProperty("scaling_configuration_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ScalingConfigurationName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("instance_config", NullValueHandling = NullValueHandling.Ignore)]
        public InstanceConfigResult InstanceConfig { get; set; }

        /// <summary>
        /// 创建伸缩配置的时间，遵循UTC时间。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// 绑定该伸缩配置的伸缩组ID
        /// </summary>
        [JsonProperty("scaling_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScalingGroupId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScalingConfiguration {\n");
            sb.Append("  scalingConfigurationId: ").Append(ScalingConfigurationId).Append("\n");
            sb.Append("  tenant: ").Append(Tenant).Append("\n");
            sb.Append("  scalingConfigurationName: ").Append(ScalingConfigurationName).Append("\n");
            sb.Append("  instanceConfig: ").Append(InstanceConfig).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  scalingGroupId: ").Append(ScalingGroupId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScalingConfiguration);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ScalingConfiguration input)
        {
            if (input == null) return false;
            if (this.ScalingConfigurationId != input.ScalingConfigurationId || (this.ScalingConfigurationId != null && !this.ScalingConfigurationId.Equals(input.ScalingConfigurationId))) return false;
            if (this.Tenant != input.Tenant || (this.Tenant != null && !this.Tenant.Equals(input.Tenant))) return false;
            if (this.ScalingConfigurationName != input.ScalingConfigurationName || (this.ScalingConfigurationName != null && !this.ScalingConfigurationName.Equals(input.ScalingConfigurationName))) return false;
            if (this.InstanceConfig != input.InstanceConfig || (this.InstanceConfig != null && !this.InstanceConfig.Equals(input.InstanceConfig))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.ScalingGroupId != input.ScalingGroupId || (this.ScalingGroupId != null && !this.ScalingGroupId.Equals(input.ScalingGroupId))) return false;

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
                if (this.ScalingConfigurationId != null) hashCode = hashCode * 59 + this.ScalingConfigurationId.GetHashCode();
                if (this.Tenant != null) hashCode = hashCode * 59 + this.Tenant.GetHashCode();
                if (this.ScalingConfigurationName != null) hashCode = hashCode * 59 + this.ScalingConfigurationName.GetHashCode();
                if (this.InstanceConfig != null) hashCode = hashCode * 59 + this.InstanceConfig.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.ScalingGroupId != null) hashCode = hashCode * 59 + this.ScalingGroupId.GetHashCode();
                return hashCode;
            }
        }
    }
}
