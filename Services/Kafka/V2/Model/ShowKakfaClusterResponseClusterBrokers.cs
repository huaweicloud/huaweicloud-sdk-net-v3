using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ShowKakfaClusterResponseClusterBrokers 
    {

        /// <summary>
        /// **参数解释**： 是否健康。   **取值范围**： - true：健康。 - false：不健康。
        /// </summary>
        [JsonProperty("health", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Health { get; set; }

        /// <summary>
        /// **参数解释**： Host地址。   **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("host", NullValueHandling = NullValueHandling.Ignore)]
        public string Host { get; set; }

        /// <summary>
        /// **参数解释**： 端口。   **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public int? Port { get; set; }

        /// <summary>
        /// **参数解释**： 节点ID。   **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("broker_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BrokerId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowKakfaClusterResponseClusterBrokers {\n");
            sb.Append("  health: ").Append(Health).Append("\n");
            sb.Append("  host: ").Append(Host).Append("\n");
            sb.Append("  port: ").Append(Port).Append("\n");
            sb.Append("  brokerId: ").Append(BrokerId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowKakfaClusterResponseClusterBrokers);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowKakfaClusterResponseClusterBrokers input)
        {
            if (input == null) return false;
            if (this.Health != input.Health || (this.Health != null && !this.Health.Equals(input.Health))) return false;
            if (this.Host != input.Host || (this.Host != null && !this.Host.Equals(input.Host))) return false;
            if (this.Port != input.Port || (this.Port != null && !this.Port.Equals(input.Port))) return false;
            if (this.BrokerId != input.BrokerId || (this.BrokerId != null && !this.BrokerId.Equals(input.BrokerId))) return false;

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
                if (this.Health != null) hashCode = hashCode * 59 + this.Health.GetHashCode();
                if (this.Host != null) hashCode = hashCode * 59 + this.Host.GetHashCode();
                if (this.Port != null) hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.BrokerId != null) hashCode = hashCode * 59 + this.BrokerId.GetHashCode();
                return hashCode;
            }
        }
    }
}
