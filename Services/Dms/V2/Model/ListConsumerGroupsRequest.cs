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
    public class ListConsumerGroupsRequest 
    {

        /// <summary>
        /// 指定的队列ID
        /// </summary>
        [SDKProperty("queue_id", IsPath = true)]
        [JsonProperty("queue_id", NullValueHandling = NullValueHandling.Ignore)]
        public string QueueId { get; set; }

        /// <summary>
        /// 是否包含死信信息。默认值为：false
        /// </summary>
        [SDKProperty("include_deadletter", IsQuery = true)]
        [JsonProperty("include_deadletter", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeDeadletter { get; set; }

        /// <summary>
        /// 是否查询消费组的详情，默认值为true。  配置为false时，查询的消费组列表不包含消费详情，接口响应速度快。
        /// </summary>
        [SDKProperty("include_messages_num", IsQuery = true)]
        [JsonProperty("include_messages_num", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeMessagesNum { get; set; }

        /// <summary>
        /// 设置每页显示的消费组数量。  page_size和current_page必须同时配置有效值，否则默认查询所有消费组。
        /// </summary>
        [SDKProperty("page_size", IsQuery = true)]
        [JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 设置查询消费组的页码。  page_size和current_page必须同时配置有效值，否则默认查询所有消费组。
        /// </summary>
        [SDKProperty("current_page", IsQuery = true)]
        [JsonProperty("current_page", NullValueHandling = NullValueHandling.Ignore)]
        public int? CurrentPage { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListConsumerGroupsRequest {\n");
            sb.Append("  queueId: ").Append(QueueId).Append("\n");
            sb.Append("  includeDeadletter: ").Append(IncludeDeadletter).Append("\n");
            sb.Append("  includeMessagesNum: ").Append(IncludeMessagesNum).Append("\n");
            sb.Append("  pageSize: ").Append(PageSize).Append("\n");
            sb.Append("  currentPage: ").Append(CurrentPage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListConsumerGroupsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListConsumerGroupsRequest input)
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
                ) && 
                (
                    this.IncludeMessagesNum == input.IncludeMessagesNum ||
                    (this.IncludeMessagesNum != null &&
                    this.IncludeMessagesNum.Equals(input.IncludeMessagesNum))
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    (this.PageSize != null &&
                    this.PageSize.Equals(input.PageSize))
                ) && 
                (
                    this.CurrentPage == input.CurrentPage ||
                    (this.CurrentPage != null &&
                    this.CurrentPage.Equals(input.CurrentPage))
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
                if (this.IncludeMessagesNum != null)
                    hashCode = hashCode * 59 + this.IncludeMessagesNum.GetHashCode();
                if (this.PageSize != null)
                    hashCode = hashCode * 59 + this.PageSize.GetHashCode();
                if (this.CurrentPage != null)
                    hashCode = hashCode * 59 + this.CurrentPage.GetHashCode();
                return hashCode;
            }
        }
    }
}
