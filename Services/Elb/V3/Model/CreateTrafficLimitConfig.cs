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
    /// **参数解释**：转发策略限速的配置。  **约束限制**：不涉及
    /// </summary>
    public class CreateTrafficLimitConfig 
    {

        /// <summary>
        /// **参数解释**：转发策略qps限速。  **约束限制**：不涉及  **取值范围**：0-100000，单位：个/秒。0表示不限速。  **默认取值**：不涉及
        /// </summary>
        [JsonProperty("qps", NullValueHandling = NullValueHandling.Ignore)]
        public int? Qps { get; set; }

        /// <summary>
        /// **参数解释**：对转发策略单源(单个客户端IP)进行限速。  **约束限制**： - quic监听器下转发策略不支持配置单源限速。 - 指定该字段时，赋值可以为0或者为null。 - 如果qps不为0，per_source_ip_qps需要小于qps。  **取值范围**：0-100000，单位：个/秒。0表示不限速。  **默认取值**：不涉及
        /// </summary>
        [JsonProperty("per_source_ip_qps", NullValueHandling = NullValueHandling.Ignore)]
        public int? PerSourceIpQps { get; set; }

        /// <summary>
        /// **参数解释**：设置当单源qps超限时，允许的局部突增请求数量。超出该限制的请求将返回503。  **约束限制**：不涉及  **取值范围**：0-100000，单位：个/秒。  **默认取值**：不涉及
        /// </summary>
        [JsonProperty("burst", NullValueHandling = NullValueHandling.Ignore)]
        public int? Burst { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTrafficLimitConfig {\n");
            sb.Append("  qps: ").Append(Qps).Append("\n");
            sb.Append("  perSourceIpQps: ").Append(PerSourceIpQps).Append("\n");
            sb.Append("  burst: ").Append(Burst).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateTrafficLimitConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateTrafficLimitConfig input)
        {
            if (input == null) return false;
            if (this.Qps != input.Qps || (this.Qps != null && !this.Qps.Equals(input.Qps))) return false;
            if (this.PerSourceIpQps != input.PerSourceIpQps || (this.PerSourceIpQps != null && !this.PerSourceIpQps.Equals(input.PerSourceIpQps))) return false;
            if (this.Burst != input.Burst || (this.Burst != null && !this.Burst.Equals(input.Burst))) return false;

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
                if (this.Qps != null) hashCode = hashCode * 59 + this.Qps.GetHashCode();
                if (this.PerSourceIpQps != null) hashCode = hashCode * 59 + this.PerSourceIpQps.GetHashCode();
                if (this.Burst != null) hashCode = hashCode * 59 + this.Burst.GetHashCode();
                return hashCode;
            }
        }
    }
}
