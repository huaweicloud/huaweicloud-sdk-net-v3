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
    public class CreateTopicReqQueues 
    {

        /// <summary>
        /// 关联的代理。
        /// </summary>
        [JsonProperty("broker", NullValueHandling = NullValueHandling.Ignore)]
        public string Broker { get; set; }

        /// <summary>
        /// 队列数，范围1~50。
        /// </summary>
        [JsonProperty("queue_num", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? QueueNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTopicReqQueues {\n");
            sb.Append("  broker: ").Append(Broker).Append("\n");
            sb.Append("  queueNum: ").Append(QueueNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateTopicReqQueues);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateTopicReqQueues input)
        {
            if (input == null) return false;
            if (this.Broker != input.Broker || (this.Broker != null && !this.Broker.Equals(input.Broker))) return false;
            if (this.QueueNum != input.QueueNum || (this.QueueNum != null && !this.QueueNum.Equals(input.QueueNum))) return false;

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
                if (this.Broker != null) hashCode = hashCode * 59 + this.Broker.GetHashCode();
                if (this.QueueNum != null) hashCode = hashCode * 59 + this.QueueNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
