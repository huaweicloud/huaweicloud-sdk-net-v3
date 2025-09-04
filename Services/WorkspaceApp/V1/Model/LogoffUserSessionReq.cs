using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 注销会话请求。
    /// </summary>
    public class LogoffUserSessionReq 
    {

        /// <summary>
        /// 会话信息id列表。
        /// </summary>
        [JsonProperty("session_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SessionIds { get; set; }

        /// <summary>
        /// 客户端弹框级别，代表给会话发消息时的严重程度（比如info、warning、error级别） 0-&gt;info; 1-&gt; warn; 2-&gt;serious。
        /// </summary>
        [JsonProperty("message_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? MessageType { get; set; }

        /// <summary>
        /// 客户端弹框内容。
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// 弹框标题。
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// 延迟多长时间注销会话， 单位：秒。
        /// </summary>
        [JsonProperty("delay_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? DelayTime { get; set; }

        /// <summary>
        /// 事务id，用作客户端日志定位跟踪。
        /// </summary>
        [JsonProperty("transaction_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TransactionId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LogoffUserSessionReq {\n");
            sb.Append("  sessionIds: ").Append(SessionIds).Append("\n");
            sb.Append("  messageType: ").Append(MessageType).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  delayTime: ").Append(DelayTime).Append("\n");
            sb.Append("  transactionId: ").Append(TransactionId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LogoffUserSessionReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LogoffUserSessionReq input)
        {
            if (input == null) return false;
            if (this.SessionIds != input.SessionIds || (this.SessionIds != null && input.SessionIds != null && !this.SessionIds.SequenceEqual(input.SessionIds))) return false;
            if (this.MessageType != input.MessageType || (this.MessageType != null && !this.MessageType.Equals(input.MessageType))) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;
            if (this.DelayTime != input.DelayTime || (this.DelayTime != null && !this.DelayTime.Equals(input.DelayTime))) return false;
            if (this.TransactionId != input.TransactionId || (this.TransactionId != null && !this.TransactionId.Equals(input.TransactionId))) return false;

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
                if (this.SessionIds != null) hashCode = hashCode * 59 + this.SessionIds.GetHashCode();
                if (this.MessageType != null) hashCode = hashCode * 59 + this.MessageType.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Title != null) hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.DelayTime != null) hashCode = hashCode * 59 + this.DelayTime.GetHashCode();
                if (this.TransactionId != null) hashCode = hashCode * 59 + this.TransactionId.GetHashCode();
                return hashCode;
            }
        }
    }
}
