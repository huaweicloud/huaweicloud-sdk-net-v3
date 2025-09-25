using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V4.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowNotificationSubscriptionsStatusResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("internal_message", NullValueHandling = NullValueHandling.Ignore)]
        public RepoNotificationSubscriptionStateDto InternalMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public RepoNotificationSubscriptionStateDto Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("qyweixin", NullValueHandling = NullValueHandling.Ignore)]
        public RepoNotificationSubscriptionStateDto Qyweixin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("feishu", NullValueHandling = NullValueHandling.Ignore)]
        public RepoNotificationSubscriptionStateDto Feishu { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("dingding", NullValueHandling = NullValueHandling.Ignore)]
        public RepoNotificationSubscriptionStateDto Dingding { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowNotificationSubscriptionsStatusResponse {\n");
            sb.Append("  internalMessage: ").Append(InternalMessage).Append("\n");
            sb.Append("  email: ").Append(Email).Append("\n");
            sb.Append("  qyweixin: ").Append(Qyweixin).Append("\n");
            sb.Append("  feishu: ").Append(Feishu).Append("\n");
            sb.Append("  dingding: ").Append(Dingding).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowNotificationSubscriptionsStatusResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowNotificationSubscriptionsStatusResponse input)
        {
            if (input == null) return false;
            if (this.InternalMessage != input.InternalMessage || (this.InternalMessage != null && !this.InternalMessage.Equals(input.InternalMessage))) return false;
            if (this.Email != input.Email || (this.Email != null && !this.Email.Equals(input.Email))) return false;
            if (this.Qyweixin != input.Qyweixin || (this.Qyweixin != null && !this.Qyweixin.Equals(input.Qyweixin))) return false;
            if (this.Feishu != input.Feishu || (this.Feishu != null && !this.Feishu.Equals(input.Feishu))) return false;
            if (this.Dingding != input.Dingding || (this.Dingding != null && !this.Dingding.Equals(input.Dingding))) return false;

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
                if (this.InternalMessage != null) hashCode = hashCode * 59 + this.InternalMessage.GetHashCode();
                if (this.Email != null) hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Qyweixin != null) hashCode = hashCode * 59 + this.Qyweixin.GetHashCode();
                if (this.Feishu != null) hashCode = hashCode * 59 + this.Feishu.GetHashCode();
                if (this.Dingding != null) hashCode = hashCode * 59 + this.Dingding.GetHashCode();
                return hashCode;
            }
        }
    }
}
