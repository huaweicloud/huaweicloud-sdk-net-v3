using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// 会议推送参数配置请求。
    /// </summary>
    public class WebHookConfigRequest 
    {

        /// <summary>
        /// 企业ID。按企业注册回调时需要填写。
        /// </summary>
        [JsonProperty("corpId", NullValueHandling = NullValueHandling.Ignore)]
        public string CorpId { get; set; }

        /// <summary>
        /// SP ID。多租户场景下，按SP注册回调时需要填写。
        /// </summary>
        [JsonProperty("spId", NullValueHandling = NullValueHandling.Ignore)]
        public string SpId { get; set; }

        /// <summary>
        /// 订阅者ID。
        /// </summary>
        [JsonProperty("subscriberId", NullValueHandling = NullValueHandling.Ignore)]
        public string SubscriberId { get; set; }

        /// <summary>
        /// 订阅者秘钥。
        /// </summary>
        [JsonProperty("subscriberKey", NullValueHandling = NullValueHandling.Ignore)]
        public string SubscriberKey { get; set; }

        /// <summary>
        /// 订阅url。 &gt; 必须使用HTTPS。 
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebHookConfigRequest {\n");
            sb.Append("  corpId: ").Append(CorpId).Append("\n");
            sb.Append("  spId: ").Append(SpId).Append("\n");
            sb.Append("  subscriberId: ").Append(SubscriberId).Append("\n");
            sb.Append("  subscriberKey: ").Append(SubscriberKey).Append("\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WebHookConfigRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WebHookConfigRequest input)
        {
            if (input == null) return false;
            if (this.CorpId != input.CorpId || (this.CorpId != null && !this.CorpId.Equals(input.CorpId))) return false;
            if (this.SpId != input.SpId || (this.SpId != null && !this.SpId.Equals(input.SpId))) return false;
            if (this.SubscriberId != input.SubscriberId || (this.SubscriberId != null && !this.SubscriberId.Equals(input.SubscriberId))) return false;
            if (this.SubscriberKey != input.SubscriberKey || (this.SubscriberKey != null && !this.SubscriberKey.Equals(input.SubscriberKey))) return false;
            if (this.Url != input.Url || (this.Url != null && !this.Url.Equals(input.Url))) return false;

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
                if (this.CorpId != null) hashCode = hashCode * 59 + this.CorpId.GetHashCode();
                if (this.SpId != null) hashCode = hashCode * 59 + this.SpId.GetHashCode();
                if (this.SubscriberId != null) hashCode = hashCode * 59 + this.SubscriberId.GetHashCode();
                if (this.SubscriberKey != null) hashCode = hashCode * 59 + this.SubscriberKey.GetHashCode();
                if (this.Url != null) hashCode = hashCode * 59 + this.Url.GetHashCode();
                return hashCode;
            }
        }
    }
}
