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
    /// 消费组信息
    /// </summary>
    public class ListQueueGroupsRespGroups 
    {

        /// <summary>
        /// 队列的名称。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 队列的名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 队列的消息总数，不包含过期删除的消息数。
        /// </summary>
        [JsonProperty("produced_messages", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProducedMessages { get; set; }

        /// <summary>
        /// 已正常消费的消息总数。
        /// </summary>
        [JsonProperty("consumed_messages", NullValueHandling = NullValueHandling.Ignore)]
        public int? ConsumedMessages { get; set; }

        /// <summary>
        /// 该消费组可以消费的普通消息数。
        /// </summary>
        [JsonProperty("available_messages", NullValueHandling = NullValueHandling.Ignore)]
        public int? AvailableMessages { get; set; }

        /// <summary>
        /// 该消费组产生的死信息消息总数。仅当include_deadletter为true时，才有该响应参数。
        /// </summary>
        [JsonProperty("produced_deadletters", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProducedDeadletters { get; set; }

        /// <summary>
        /// 该消费组未消费的死信消息数。仅当include_deadletter为true时，才有该响应参数。
        /// </summary>
        [JsonProperty("available_deadletters", NullValueHandling = NullValueHandling.Ignore)]
        public int? AvailableDeadletters { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListQueueGroupsRespGroups {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  producedMessages: ").Append(ProducedMessages).Append("\n");
            sb.Append("  consumedMessages: ").Append(ConsumedMessages).Append("\n");
            sb.Append("  availableMessages: ").Append(AvailableMessages).Append("\n");
            sb.Append("  producedDeadletters: ").Append(ProducedDeadletters).Append("\n");
            sb.Append("  availableDeadletters: ").Append(AvailableDeadletters).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListQueueGroupsRespGroups);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListQueueGroupsRespGroups input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ProducedMessages == input.ProducedMessages ||
                    (this.ProducedMessages != null &&
                    this.ProducedMessages.Equals(input.ProducedMessages))
                ) && 
                (
                    this.ConsumedMessages == input.ConsumedMessages ||
                    (this.ConsumedMessages != null &&
                    this.ConsumedMessages.Equals(input.ConsumedMessages))
                ) && 
                (
                    this.AvailableMessages == input.AvailableMessages ||
                    (this.AvailableMessages != null &&
                    this.AvailableMessages.Equals(input.AvailableMessages))
                ) && 
                (
                    this.ProducedDeadletters == input.ProducedDeadletters ||
                    (this.ProducedDeadletters != null &&
                    this.ProducedDeadletters.Equals(input.ProducedDeadletters))
                ) && 
                (
                    this.AvailableDeadletters == input.AvailableDeadletters ||
                    (this.AvailableDeadletters != null &&
                    this.AvailableDeadletters.Equals(input.AvailableDeadletters))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ProducedMessages != null)
                    hashCode = hashCode * 59 + this.ProducedMessages.GetHashCode();
                if (this.ConsumedMessages != null)
                    hashCode = hashCode * 59 + this.ConsumedMessages.GetHashCode();
                if (this.AvailableMessages != null)
                    hashCode = hashCode * 59 + this.AvailableMessages.GetHashCode();
                if (this.ProducedDeadletters != null)
                    hashCode = hashCode * 59 + this.ProducedDeadletters.GetHashCode();
                if (this.AvailableDeadletters != null)
                    hashCode = hashCode * 59 + this.AvailableDeadletters.GetHashCode();
                return hashCode;
            }
        }
    }
}
