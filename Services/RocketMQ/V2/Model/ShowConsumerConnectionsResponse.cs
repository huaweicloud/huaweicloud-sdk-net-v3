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
    /// Response Object
    /// </summary>
    public class ShowConsumerConnectionsResponse : SdkResponse
    {

        /// <summary>
        /// 消费组名称。
        /// </summary>
        [JsonProperty("group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <summary>
        /// 消费组是否在线。
        /// </summary>
        [JsonProperty("online", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Online { get; set; }

        /// <summary>
        /// 订阅关系是否一致。
        /// </summary>
        [JsonProperty("subscription_consistency", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SubscriptionConsistency { get; set; }

        /// <summary>
        /// 消费者总数。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// 下个分页的offset。
        /// </summary>
        [JsonProperty("next_offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? NextOffset { get; set; }

        /// <summary>
        /// 上个分页的offset。
        /// </summary>
        [JsonProperty("previous_offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? PreviousOffset { get; set; }

        /// <summary>
        /// 消费者订阅详情列表。
        /// </summary>
        [JsonProperty("clients", NullValueHandling = NullValueHandling.Ignore)]
        public List<ClientData> Clients { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowConsumerConnectionsResponse {\n");
            sb.Append("  groupName: ").Append(GroupName).Append("\n");
            sb.Append("  online: ").Append(Online).Append("\n");
            sb.Append("  subscriptionConsistency: ").Append(SubscriptionConsistency).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  nextOffset: ").Append(NextOffset).Append("\n");
            sb.Append("  previousOffset: ").Append(PreviousOffset).Append("\n");
            sb.Append("  clients: ").Append(Clients).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowConsumerConnectionsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowConsumerConnectionsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GroupName == input.GroupName ||
                    (this.GroupName != null &&
                    this.GroupName.Equals(input.GroupName))
                ) && 
                (
                    this.Online == input.Online ||
                    (this.Online != null &&
                    this.Online.Equals(input.Online))
                ) && 
                (
                    this.SubscriptionConsistency == input.SubscriptionConsistency ||
                    (this.SubscriptionConsistency != null &&
                    this.SubscriptionConsistency.Equals(input.SubscriptionConsistency))
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.NextOffset == input.NextOffset ||
                    (this.NextOffset != null &&
                    this.NextOffset.Equals(input.NextOffset))
                ) && 
                (
                    this.PreviousOffset == input.PreviousOffset ||
                    (this.PreviousOffset != null &&
                    this.PreviousOffset.Equals(input.PreviousOffset))
                ) && 
                (
                    this.Clients == input.Clients ||
                    this.Clients != null &&
                    input.Clients != null &&
                    this.Clients.SequenceEqual(input.Clients)
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
                if (this.GroupName != null)
                    hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.Online != null)
                    hashCode = hashCode * 59 + this.Online.GetHashCode();
                if (this.SubscriptionConsistency != null)
                    hashCode = hashCode * 59 + this.SubscriptionConsistency.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.NextOffset != null)
                    hashCode = hashCode * 59 + this.NextOffset.GetHashCode();
                if (this.PreviousOffset != null)
                    hashCode = hashCode * 59 + this.PreviousOffset.GetHashCode();
                if (this.Clients != null)
                    hashCode = hashCode * 59 + this.Clients.GetHashCode();
                return hashCode;
            }
        }
    }
}
