using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// 复制监听器接口请求体。
    /// </summary>
    public class CloneListenerRequestBody 
    {

        /// <summary>
        /// **参数解释**：复制后的新监听器相关配置。 **约束限制**：不涉及
        /// </summary>
        [JsonProperty("target_listener_params", NullValueHandling = NullValueHandling.Ignore)]
        public List<CloneListenerOption> TargetListenerParams { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CloneListenerRequestBody {\n");
            sb.Append("  targetListenerParams: ").Append(TargetListenerParams).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CloneListenerRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CloneListenerRequestBody input)
        {
            if (input == null) return false;
            if (this.TargetListenerParams != input.TargetListenerParams || (this.TargetListenerParams != null && input.TargetListenerParams != null && !this.TargetListenerParams.SequenceEqual(input.TargetListenerParams))) return false;

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
                if (this.TargetListenerParams != null) hashCode = hashCode * 59 + this.TargetListenerParams.GetHashCode();
                return hashCode;
            }
        }
    }
}
