using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dms.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowQueueRequest 
    {

        /// <summary>
        /// 待查询的队列ID
        /// </summary>
        [SDKProperty("queue_id", IsPath = true)]
        [JsonProperty("queue_id", NullValueHandling = NullValueHandling.Ignore)]
        public string QueueId { get; set; }

        /// <summary>
        /// 是否包含死信信息。  支持的值如下：  - true：包含死信消息。 - false：不包含死信消息。  默认值为：false。  Kafka队列没有死信功能，该参数对于Kafka队列无效。
        /// </summary>
        [SDKProperty("include_deadletter", IsQuery = true)]
        [JsonProperty("include_deadletter", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeDeadletter { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowQueueRequest {\n");
            sb.Append("  queueId: ").Append(QueueId).Append("\n");
            sb.Append("  includeDeadletter: ").Append(IncludeDeadletter).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowQueueRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowQueueRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.QueueId == input.QueueId ||
                    (this.QueueId != null &&
                    this.QueueId.Equals(input.QueueId))
                ) && 
                (
                    this.IncludeDeadletter == input.IncludeDeadletter ||
                    (this.IncludeDeadletter != null &&
                    this.IncludeDeadletter.Equals(input.IncludeDeadletter))
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
                if (this.QueueId != null)
                    hashCode = hashCode * 59 + this.QueueId.GetHashCode();
                if (this.IncludeDeadletter != null)
                    hashCode = hashCode * 59 + this.IncludeDeadletter.GetHashCode();
                return hashCode;
            }
        }
    }
}
