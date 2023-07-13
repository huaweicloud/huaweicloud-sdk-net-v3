using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class BroadcastMessageResponse : SdkResponse
    {

        /// <summary>
        /// **参数说明**：资源空间ID。
        /// </summary>
        [JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }

        /// <summary>
        /// **参数说明**：接收广播消息的完整Topic名称
        /// </summary>
        [JsonProperty("topic_full_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TopicFullName { get; set; }

        /// <summary>
        /// 消息id，由物联网平台生成，用于标识该消息。
        /// </summary>
        [JsonProperty("message_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MessageId { get; set; }

        /// <summary>
        /// 消息的创建时间，\&quot;yyyyMMdd&#39;T&#39;HHmmss&#39;Z&#39;\&quot;格式的UTC字符串。
        /// </summary>
        [JsonProperty("created_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BroadcastMessageResponse {\n");
            sb.Append("  appId: ").Append(AppId).Append("\n");
            sb.Append("  topicFullName: ").Append(TopicFullName).Append("\n");
            sb.Append("  messageId: ").Append(MessageId).Append("\n");
            sb.Append("  createdTime: ").Append(CreatedTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BroadcastMessageResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BroadcastMessageResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AppId == input.AppId ||
                    (this.AppId != null &&
                    this.AppId.Equals(input.AppId))
                ) && 
                (
                    this.TopicFullName == input.TopicFullName ||
                    (this.TopicFullName != null &&
                    this.TopicFullName.Equals(input.TopicFullName))
                ) && 
                (
                    this.MessageId == input.MessageId ||
                    (this.MessageId != null &&
                    this.MessageId.Equals(input.MessageId))
                ) && 
                (
                    this.CreatedTime == input.CreatedTime ||
                    (this.CreatedTime != null &&
                    this.CreatedTime.Equals(input.CreatedTime))
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
                if (this.AppId != null)
                    hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.TopicFullName != null)
                    hashCode = hashCode * 59 + this.TopicFullName.GetHashCode();
                if (this.MessageId != null)
                    hashCode = hashCode * 59 + this.MessageId.GetHashCode();
                if (this.CreatedTime != null)
                    hashCode = hashCode * 59 + this.CreatedTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
