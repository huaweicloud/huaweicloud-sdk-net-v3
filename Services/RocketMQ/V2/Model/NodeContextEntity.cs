using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.RocketMQ.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class NodeContextEntity 
    {

        /// <summary>
        /// **参数解释**： ID。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**： broker名称。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("broker_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BrokerName { get; set; }

        /// <summary>
        /// **参数解释**： broker的ID。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("broker_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? BrokerId { get; set; }

        /// <summary>
        /// **参数解释**： 地址。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        /// **参数解释**： 公网地址。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("public_address", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicAddress { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeContextEntity {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  brokerName: ").Append(BrokerName).Append("\n");
            sb.Append("  brokerId: ").Append(BrokerId).Append("\n");
            sb.Append("  address: ").Append(Address).Append("\n");
            sb.Append("  publicAddress: ").Append(PublicAddress).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodeContextEntity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodeContextEntity input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.BrokerName != input.BrokerName || (this.BrokerName != null && !this.BrokerName.Equals(input.BrokerName))) return false;
            if (this.BrokerId != input.BrokerId || (this.BrokerId != null && !this.BrokerId.Equals(input.BrokerId))) return false;
            if (this.Address != input.Address || (this.Address != null && !this.Address.Equals(input.Address))) return false;
            if (this.PublicAddress != input.PublicAddress || (this.PublicAddress != null && !this.PublicAddress.Equals(input.PublicAddress))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.BrokerName != null) hashCode = hashCode * 59 + this.BrokerName.GetHashCode();
                if (this.BrokerId != null) hashCode = hashCode * 59 + this.BrokerId.GetHashCode();
                if (this.Address != null) hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.PublicAddress != null) hashCode = hashCode * 59 + this.PublicAddress.GetHashCode();
                return hashCode;
            }
        }
    }
}
