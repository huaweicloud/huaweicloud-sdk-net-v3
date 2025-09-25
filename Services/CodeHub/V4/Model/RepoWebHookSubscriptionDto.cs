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
    /// 
    /// </summary>
    public class RepoWebHookSubscriptionDto 
    {

        /// <summary>
        /// **参数解释：** webhook的url。
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// **参数解释：** userid列表，提醒群中的指定成员（@某个成员），最长1000，每个最长100，“;”分隔符。
        /// </summary>
        [JsonProperty("mention_users", NullValueHandling = NullValueHandling.Ignore)]
        public string MentionUsers { get; set; }

        /// <summary>
        /// **参数解释：** 手机号列表，提醒手机号对应的群成员（@某个成员），最长1000，每个最长30，“;”分隔符。
        /// </summary>
        [JsonProperty("mention_phone", NullValueHandling = NullValueHandling.Ignore)]
        public string MentionPhone { get; set; }

        /// <summary>
        /// **参数解释：** 是否设置了token。
        /// </summary>
        [JsonProperty("has_token", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasToken { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RepoWebHookSubscriptionDto {\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  mentionUsers: ").Append(MentionUsers).Append("\n");
            sb.Append("  mentionPhone: ").Append(MentionPhone).Append("\n");
            sb.Append("  hasToken: ").Append(HasToken).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RepoWebHookSubscriptionDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RepoWebHookSubscriptionDto input)
        {
            if (input == null) return false;
            if (this.Url != input.Url || (this.Url != null && !this.Url.Equals(input.Url))) return false;
            if (this.MentionUsers != input.MentionUsers || (this.MentionUsers != null && !this.MentionUsers.Equals(input.MentionUsers))) return false;
            if (this.MentionPhone != input.MentionPhone || (this.MentionPhone != null && !this.MentionPhone.Equals(input.MentionPhone))) return false;
            if (this.HasToken != input.HasToken || (this.HasToken != null && !this.HasToken.Equals(input.HasToken))) return false;

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
                if (this.Url != null) hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.MentionUsers != null) hashCode = hashCode * 59 + this.MentionUsers.GetHashCode();
                if (this.MentionPhone != null) hashCode = hashCode * 59 + this.MentionPhone.GetHashCode();
                if (this.HasToken != null) hashCode = hashCode * 59 + this.HasToken.GetHashCode();
                return hashCode;
            }
        }
    }
}
