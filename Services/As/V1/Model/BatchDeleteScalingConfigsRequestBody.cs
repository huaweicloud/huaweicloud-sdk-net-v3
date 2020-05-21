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
    /// 批量删除伸缩配置请求
    /// </summary>
    public class BatchDeleteScalingConfigsRequestBody 
    {

        /// <summary>
        /// 伸缩配置ID。
        /// </summary>
        [JsonProperty("scaling_configuration_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ScalingConfigurationId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteScalingConfigsRequestBody {\n");
            sb.Append("  scalingConfigurationId: ").Append(ScalingConfigurationId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteScalingConfigsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteScalingConfigsRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ScalingConfigurationId == input.ScalingConfigurationId ||
                    this.ScalingConfigurationId != null &&
                    input.ScalingConfigurationId != null &&
                    this.ScalingConfigurationId.SequenceEqual(input.ScalingConfigurationId)
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
                if (this.ScalingConfigurationId != null)
                    hashCode = hashCode * 59 + this.ScalingConfigurationId.GetHashCode();
                return hashCode;
            }
        }
    }
}
