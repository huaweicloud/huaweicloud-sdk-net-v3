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
    public class TopicBrokers 
    {

        /// <summary>
        /// **参数解释**： 代理名称。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("broker_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BrokerName { get; set; }

        /// <summary>
        /// **参数解释**： 读队列个数。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("read_queue_num", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? ReadQueueNum { get; set; }

        /// <summary>
        /// **参数解释**： 写队列个数。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("write_queue_num", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? WriteQueueNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TopicBrokers {\n");
            sb.Append("  brokerName: ").Append(BrokerName).Append("\n");
            sb.Append("  readQueueNum: ").Append(ReadQueueNum).Append("\n");
            sb.Append("  writeQueueNum: ").Append(WriteQueueNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TopicBrokers);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TopicBrokers input)
        {
            if (input == null) return false;
            if (this.BrokerName != input.BrokerName || (this.BrokerName != null && !this.BrokerName.Equals(input.BrokerName))) return false;
            if (this.ReadQueueNum != input.ReadQueueNum || (this.ReadQueueNum != null && !this.ReadQueueNum.Equals(input.ReadQueueNum))) return false;
            if (this.WriteQueueNum != input.WriteQueueNum || (this.WriteQueueNum != null && !this.WriteQueueNum.Equals(input.WriteQueueNum))) return false;

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
                if (this.BrokerName != null) hashCode = hashCode * 59 + this.BrokerName.GetHashCode();
                if (this.ReadQueueNum != null) hashCode = hashCode * 59 + this.ReadQueueNum.GetHashCode();
                if (this.WriteQueueNum != null) hashCode = hashCode * 59 + this.WriteQueueNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
