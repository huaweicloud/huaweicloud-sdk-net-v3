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
    /// 
    /// </summary>
    public class EventUpdate 
    {

        /// <summary>
        /// **参数解释**：计划执行开始时间，格式为yyyy-MM-ddTHH:mm:ssZ。 **约束限制**：不涉及。 **取值范围**：大于当前时间。 **默认取值**：不填表示立即执行。
        /// </summary>
        [JsonProperty("notBefore", NullValueHandling = NullValueHandling.Ignore)]
        public string NotBefore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("redeployConfig", NullValueHandling = NullValueHandling.Ignore)]
        public RedeployConfig RedeployConfig { get; set; }

        /// <summary>
        /// **参数解释**：授权节点ID列表。授权重部处理时可选填,支持填入单个故障节点ID。 **约束限制**：不涉及。 **取值范围**：计划事件故障节点列表。 **默认取值**：不填表示授权所有节点。
        /// </summary>
        [JsonProperty("instanceId", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> InstanceId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventUpdate {\n");
            sb.Append("  notBefore: ").Append(NotBefore).Append("\n");
            sb.Append("  redeployConfig: ").Append(RedeployConfig).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EventUpdate);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EventUpdate input)
        {
            if (input == null) return false;
            if (this.NotBefore != input.NotBefore || (this.NotBefore != null && !this.NotBefore.Equals(input.NotBefore))) return false;
            if (this.RedeployConfig != input.RedeployConfig || (this.RedeployConfig != null && !this.RedeployConfig.Equals(input.RedeployConfig))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && input.InstanceId != null && !this.InstanceId.SequenceEqual(input.InstanceId))) return false;

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
                if (this.NotBefore != null) hashCode = hashCode * 59 + this.NotBefore.GetHashCode();
                if (this.RedeployConfig != null) hashCode = hashCode * 59 + this.RedeployConfig.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                return hashCode;
            }
        }
    }
}
