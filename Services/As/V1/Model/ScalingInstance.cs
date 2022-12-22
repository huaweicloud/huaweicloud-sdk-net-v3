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
    /// 伸缩实例。
    /// </summary>
    public class ScalingInstance 
    {

        /// <summary>
        /// 云服务器名称。
        /// </summary>
        [JsonProperty("instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceName { get; set; }

        /// <summary>
        /// 云服务器id。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 实例伸缩失败原因。
        /// </summary>
        [JsonProperty("failed_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string FailedReason { get; set; }

        /// <summary>
        /// 实例伸缩失败详情。
        /// </summary>
        [JsonProperty("failed_details", NullValueHandling = NullValueHandling.Ignore)]
        public string FailedDetails { get; set; }

        /// <summary>
        /// 实例配置信息。
        /// </summary>
        [JsonProperty("instance_config", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceConfig { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScalingInstance {\n");
            sb.Append("  instanceName: ").Append(InstanceName).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  failedReason: ").Append(FailedReason).Append("\n");
            sb.Append("  failedDetails: ").Append(FailedDetails).Append("\n");
            sb.Append("  instanceConfig: ").Append(InstanceConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScalingInstance);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ScalingInstance input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstanceName == input.InstanceName ||
                    (this.InstanceName != null &&
                    this.InstanceName.Equals(input.InstanceName))
                ) && 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.FailedReason == input.FailedReason ||
                    (this.FailedReason != null &&
                    this.FailedReason.Equals(input.FailedReason))
                ) && 
                (
                    this.FailedDetails == input.FailedDetails ||
                    (this.FailedDetails != null &&
                    this.FailedDetails.Equals(input.FailedDetails))
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
                if (this.InstanceName != null)
                    hashCode = hashCode * 59 + this.InstanceName.GetHashCode();
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.FailedReason != null)
                    hashCode = hashCode * 59 + this.FailedReason.GetHashCode();
                if (this.FailedDetails != null)
                    hashCode = hashCode * 59 + this.FailedDetails.GetHashCode();
                if (this.InstanceConfig != null)
                    hashCode = hashCode * 59 + this.InstanceConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
