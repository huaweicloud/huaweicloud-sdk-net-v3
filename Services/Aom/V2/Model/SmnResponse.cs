using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V2.Model
{
    /// <summary>
    /// SMN返回的发送结果信息
    /// </summary>
    public class SmnResponse 
    {

        /// <summary>
        /// 发送时间。
        /// </summary>
        [JsonProperty("sent_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? SentTime { get; set; }

        /// <summary>
        /// 发送的通知的消息内容。
        /// </summary>
        [JsonProperty("smn_notified_history", NullValueHandling = NullValueHandling.Ignore)]
        public List<SmnInfo> SmnNotifiedHistory { get; set; }

        /// <summary>
        /// 请求smn服务的请求id。
        /// </summary>
        [JsonProperty("smn_request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SmnRequestId { get; set; }

        /// <summary>
        /// 调用smn服务返回的信息。
        /// </summary>
        [JsonProperty("smn_response_body", NullValueHandling = NullValueHandling.Ignore)]
        public string SmnResponseBody { get; set; }

        /// <summary>
        /// 调用smn服务返回的http状态码。
        /// </summary>
        [JsonProperty("smn_response_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SmnResponseCode { get; set; }

        /// <summary>
        /// smn的主题。
        /// </summary>
        [JsonProperty("smn_topic", NullValueHandling = NullValueHandling.Ignore)]
        public string SmnTopic { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmnResponse {\n");
            sb.Append("  sentTime: ").Append(SentTime).Append("\n");
            sb.Append("  smnNotifiedHistory: ").Append(SmnNotifiedHistory).Append("\n");
            sb.Append("  smnRequestId: ").Append(SmnRequestId).Append("\n");
            sb.Append("  smnResponseBody: ").Append(SmnResponseBody).Append("\n");
            sb.Append("  smnResponseCode: ").Append(SmnResponseCode).Append("\n");
            sb.Append("  smnTopic: ").Append(SmnTopic).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SmnResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SmnResponse input)
        {
            if (input == null) return false;
            if (this.SentTime != input.SentTime || (this.SentTime != null && !this.SentTime.Equals(input.SentTime))) return false;
            if (this.SmnNotifiedHistory != input.SmnNotifiedHistory || (this.SmnNotifiedHistory != null && input.SmnNotifiedHistory != null && !this.SmnNotifiedHistory.SequenceEqual(input.SmnNotifiedHistory))) return false;
            if (this.SmnRequestId != input.SmnRequestId || (this.SmnRequestId != null && !this.SmnRequestId.Equals(input.SmnRequestId))) return false;
            if (this.SmnResponseBody != input.SmnResponseBody || (this.SmnResponseBody != null && !this.SmnResponseBody.Equals(input.SmnResponseBody))) return false;
            if (this.SmnResponseCode != input.SmnResponseCode || (this.SmnResponseCode != null && !this.SmnResponseCode.Equals(input.SmnResponseCode))) return false;
            if (this.SmnTopic != input.SmnTopic || (this.SmnTopic != null && !this.SmnTopic.Equals(input.SmnTopic))) return false;

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
                if (this.SentTime != null) hashCode = hashCode * 59 + this.SentTime.GetHashCode();
                if (this.SmnNotifiedHistory != null) hashCode = hashCode * 59 + this.SmnNotifiedHistory.GetHashCode();
                if (this.SmnRequestId != null) hashCode = hashCode * 59 + this.SmnRequestId.GetHashCode();
                if (this.SmnResponseBody != null) hashCode = hashCode * 59 + this.SmnResponseBody.GetHashCode();
                if (this.SmnResponseCode != null) hashCode = hashCode * 59 + this.SmnResponseCode.GetHashCode();
                if (this.SmnTopic != null) hashCode = hashCode * 59 + this.SmnTopic.GetHashCode();
                return hashCode;
            }
        }
    }
}
