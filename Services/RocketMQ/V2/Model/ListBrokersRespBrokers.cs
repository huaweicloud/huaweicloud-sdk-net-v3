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
    public class ListBrokersRespBrokers 
    {

        /// <summary>
        /// **参数解释**： 全部代理ID。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<decimal?> Ids { get; set; }

        /// <summary>
        /// **参数解释**： 节点名称。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("broker_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BrokerName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListBrokersRespBrokers {\n");
            sb.Append("  ids: ").Append(Ids).Append("\n");
            sb.Append("  brokerName: ").Append(BrokerName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListBrokersRespBrokers);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListBrokersRespBrokers input)
        {
            if (input == null) return false;
            if (this.Ids != input.Ids || (this.Ids != null && input.Ids != null && !this.Ids.SequenceEqual(input.Ids))) return false;
            if (this.BrokerName != input.BrokerName || (this.BrokerName != null && !this.BrokerName.Equals(input.BrokerName))) return false;

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
                if (this.Ids != null) hashCode = hashCode * 59 + this.Ids.GetHashCode();
                if (this.BrokerName != null) hashCode = hashCode * 59 + this.BrokerName.GetHashCode();
                return hashCode;
            }
        }
    }
}
