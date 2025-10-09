using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// **参数描述**：  查询Serverless自定义扩容策略响应体。  **约束限制**：  不涉及。
    /// </summary>
    public class ServerlessScalingPolicy 
    {

        /// <summary>
        /// **参数描述**：  自定义扩容步长。  **约束限制**：  不涉及。  **取值范围**：  2-算力上限的一半。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("enlarge_step_size", NullValueHandling = NullValueHandling.Ignore)]
        public string EnlargeStepSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("custom_scaling_config", NullValueHandling = NullValueHandling.Ignore)]
        public CustomScalingConfig CustomScalingConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServerlessScalingPolicy {\n");
            sb.Append("  enlargeStepSize: ").Append(EnlargeStepSize).Append("\n");
            sb.Append("  customScalingConfig: ").Append(CustomScalingConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServerlessScalingPolicy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServerlessScalingPolicy input)
        {
            if (input == null) return false;
            if (this.EnlargeStepSize != input.EnlargeStepSize || (this.EnlargeStepSize != null && !this.EnlargeStepSize.Equals(input.EnlargeStepSize))) return false;
            if (this.CustomScalingConfig != input.CustomScalingConfig || (this.CustomScalingConfig != null && !this.CustomScalingConfig.Equals(input.CustomScalingConfig))) return false;

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
                if (this.EnlargeStepSize != null) hashCode = hashCode * 59 + this.EnlargeStepSize.GetHashCode();
                if (this.CustomScalingConfig != null) hashCode = hashCode * 59 + this.CustomScalingConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
