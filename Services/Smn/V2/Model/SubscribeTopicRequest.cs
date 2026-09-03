using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Smn.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class SubscribeTopicRequest 
    {

        /// <summary>
        /// Topic的唯一的资源标识，可通过[查询主题列表](smn_api_51004.xml)获取该标识。当订阅类型为短信或邮件时，与token、endpoint参数组合使用，三个参数中设置任意两个或全部设置均可确认订阅成功；当订阅类型为其他时，该参数必填，需与token同时设置。
        /// </summary>
        [SDKProperty("topic_urn", IsQuery = true)]
        [JsonProperty("topic_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string TopicUrn { get; set; }

        /// <summary>
        /// 订阅终端地址。仅当订阅类型为短信或邮件时可设置，与token、topic_urn参数组合使用，三个参数中设置任意两个或全部设置均可确认订阅成功。
        /// </summary>
        [SDKProperty("endpoint", IsQuery = true)]
        [JsonProperty("endpoint", NullValueHandling = NullValueHandling.Ignore)]
        public string Endpoint { get; set; }

        /// <summary>
        /// 确认订阅Token信息。（订阅链接中携带的token信息）
        /// </summary>
        [SDKProperty("token", IsQuery = true)]
        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscribeTopicRequest {\n");
            sb.Append("  topicUrn: ").Append(TopicUrn).Append("\n");
            sb.Append("  endpoint: ").Append(Endpoint).Append("\n");
            sb.Append("  token: ").Append(Token).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SubscribeTopicRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SubscribeTopicRequest input)
        {
            if (input == null) return false;
            if (this.TopicUrn != input.TopicUrn || (this.TopicUrn != null && !this.TopicUrn.Equals(input.TopicUrn))) return false;
            if (this.Endpoint != input.Endpoint || (this.Endpoint != null && !this.Endpoint.Equals(input.Endpoint))) return false;
            if (this.Token != input.Token || (this.Token != null && !this.Token.Equals(input.Token))) return false;

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
                if (this.TopicUrn != null) hashCode = hashCode * 59 + this.TopicUrn.GetHashCode();
                if (this.Endpoint != null) hashCode = hashCode * 59 + this.Endpoint.GetHashCode();
                if (this.Token != null) hashCode = hashCode * 59 + this.Token.GetHashCode();
                return hashCode;
            }
        }
    }
}
