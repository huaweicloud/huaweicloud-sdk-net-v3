using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Smnglobal.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ListSubscriptionUserResponseItemInfo 
    {

        /// <summary>
        /// 订阅用户ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 租户账号ID。
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 订阅用户名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 订阅用户状态。 UNCONFIRMED：未确认 CONFIRMED：已确认 CANCELLED：已取消
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 订阅用户分组。
        /// </summary>
        [JsonProperty("group", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Group { get; set; }

        /// <summary>
        /// 创建时间。时间格式为UTC时间，YYYY-MM-DDTHH:MM:SSZ。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 更新时间。时间格式为UTC时间，YYYY-MM-DDTHH:MM:SSZ。
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("http", NullValueHandling = NullValueHandling.Ignore)]
        public ListSubscriptionUserResponseHttpEndpointInfo Http { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("https", NullValueHandling = NullValueHandling.Ignore)]
        public ListSubscriptionUserResponseHttpsEndpointInfo Https { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("sms", NullValueHandling = NullValueHandling.Ignore)]
        public ListSubscriptionUserResponseSmsEndpointInfo Sms { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public ListSubscriptionUserResponseEmailEndpointInfo Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("callnotify", NullValueHandling = NullValueHandling.Ignore)]
        public ListSubscriptionUserResponseCallnotifyEndpointInfo Callnotify { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("wechat", NullValueHandling = NullValueHandling.Ignore)]
        public ListSubscriptionUserResponseWechatEndpointInfo Wechat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("dingding", NullValueHandling = NullValueHandling.Ignore)]
        public ListSubscriptionUserResponseDingdingEndpointInfo Dingding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("feishu", NullValueHandling = NullValueHandling.Ignore)]
        public ListSubscriptionUserResponseFeishuEndpointInfo Feishu { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("welink", NullValueHandling = NullValueHandling.Ignore)]
        public ListSubscriptionUserResponseWelinkEndpointInfo Welink { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ding_talk_bot", NullValueHandling = NullValueHandling.Ignore)]
        public ListSubscriptionUserResponseDingTalkBotEndpointInfo DingTalkBot { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSubscriptionUserResponseItemInfo {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  group: ").Append(Group).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  http: ").Append(Http).Append("\n");
            sb.Append("  https: ").Append(Https).Append("\n");
            sb.Append("  sms: ").Append(Sms).Append("\n");
            sb.Append("  email: ").Append(Email).Append("\n");
            sb.Append("  callnotify: ").Append(Callnotify).Append("\n");
            sb.Append("  wechat: ").Append(Wechat).Append("\n");
            sb.Append("  dingding: ").Append(Dingding).Append("\n");
            sb.Append("  feishu: ").Append(Feishu).Append("\n");
            sb.Append("  welink: ").Append(Welink).Append("\n");
            sb.Append("  dingTalkBot: ").Append(DingTalkBot).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSubscriptionUserResponseItemInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSubscriptionUserResponseItemInfo input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Group != input.Group || (this.Group != null && input.Group != null && !this.Group.SequenceEqual(input.Group))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.Http != input.Http || (this.Http != null && !this.Http.Equals(input.Http))) return false;
            if (this.Https != input.Https || (this.Https != null && !this.Https.Equals(input.Https))) return false;
            if (this.Sms != input.Sms || (this.Sms != null && !this.Sms.Equals(input.Sms))) return false;
            if (this.Email != input.Email || (this.Email != null && !this.Email.Equals(input.Email))) return false;
            if (this.Callnotify != input.Callnotify || (this.Callnotify != null && !this.Callnotify.Equals(input.Callnotify))) return false;
            if (this.Wechat != input.Wechat || (this.Wechat != null && !this.Wechat.Equals(input.Wechat))) return false;
            if (this.Dingding != input.Dingding || (this.Dingding != null && !this.Dingding.Equals(input.Dingding))) return false;
            if (this.Feishu != input.Feishu || (this.Feishu != null && !this.Feishu.Equals(input.Feishu))) return false;
            if (this.Welink != input.Welink || (this.Welink != null && !this.Welink.Equals(input.Welink))) return false;
            if (this.DingTalkBot != input.DingTalkBot || (this.DingTalkBot != null && !this.DingTalkBot.Equals(input.DingTalkBot))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Group != null) hashCode = hashCode * 59 + this.Group.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.Http != null) hashCode = hashCode * 59 + this.Http.GetHashCode();
                if (this.Https != null) hashCode = hashCode * 59 + this.Https.GetHashCode();
                if (this.Sms != null) hashCode = hashCode * 59 + this.Sms.GetHashCode();
                if (this.Email != null) hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Callnotify != null) hashCode = hashCode * 59 + this.Callnotify.GetHashCode();
                if (this.Wechat != null) hashCode = hashCode * 59 + this.Wechat.GetHashCode();
                if (this.Dingding != null) hashCode = hashCode * 59 + this.Dingding.GetHashCode();
                if (this.Feishu != null) hashCode = hashCode * 59 + this.Feishu.GetHashCode();
                if (this.Welink != null) hashCode = hashCode * 59 + this.Welink.GetHashCode();
                if (this.DingTalkBot != null) hashCode = hashCode * 59 + this.DingTalkBot.GetHashCode();
                return hashCode;
            }
        }
    }
}
