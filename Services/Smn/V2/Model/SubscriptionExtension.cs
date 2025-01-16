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
    /// 
    /// </summary>
    public class SubscriptionExtension 
    {

        /// <summary>
        /// 这是应用ID字段。当protocol值为welink时，该字段为必填字段，从welink方获取。
        /// </summary>
        [JsonProperty("client_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientId { get; set; }

        /// <summary>
        /// 该字段为应用secret字段。当protocol值为welink时，该字段为必填字段，从welink方获取。
        /// </summary>
        [JsonProperty("client_secret", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// 该字段为关键字字段。当protocol值为feishu时，这里的keyword字段和sign_secret字段二者必选其一。当用户在飞书或钉钉自定义机器人端添加关键字校验的安全策略时，这里的关键字必须是飞书或钉钉自定义机器人中所填写的关键字之一。
        /// </summary>
        [JsonProperty("keyword", NullValueHandling = NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// 这是加签密钥字段。当protocol协议为feishu时，这个字段和keyword字段二者必选且只能选其一。密钥配置必须与客户在飞书或钉钉自定义机器人的密钥配置完全一致。例如，如果在飞书端配置了密钥并且没有配置关键字，则在此处填入从飞书获取的密钥字段，如果在飞书端没有配置密钥并且配置了关键字，则不填写该字段。
        /// </summary>
        [JsonProperty("sign_secret", NullValueHandling = NullValueHandling.Ignore)]
        public string SignSecret { get; set; }

        /// <summary>
        /// 该字段为http header字段，用户可以在字段限制范围内自定义http header，header字段内容以KV对形式存在。当使用主题发送时，已确认的订阅发送消息会携带用户自定义的http header。 header应满足如下要求： key值限定为：包含英文字母([A-Za-z])、数字([0-9])、中划线(-)hyphens，中划线不得作为结尾，不得连续出现。 K/V不得超过10个 key需要以\&quot;x-\&quot;开头，不能以\&quot;x-smn\&quot;开头，正确示例：x-abc-cba, x-abc 所有K/V长度总和不得超过1024个字符 key不区分大小写 key值不可重复 value值限定为ASCII码，不支持中文或其他Unicode，支持空格
        /// </summary>
        [JsonProperty("header", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Header { get; set; }

        /// <summary>
        /// 个人钉钉appKey字段，字符长度限制64个，仅支持字母、数字、中划线(-)、下划线(_)。当订阅协议为dingTalkBot时，该字段必选。
        /// </summary>
        [JsonProperty("app_key", NullValueHandling = NullValueHandling.Ignore)]
        public string AppKey { get; set; }

        /// <summary>
        /// 个人钉钉appSecret字段，字符长度限制128个，仅支持字母、数字、中划线(-)、下划线(_)。当订阅协议为dingTalkBot时，该字段必选。
        /// </summary>
        [JsonProperty("app_secret", NullValueHandling = NullValueHandling.Ignore)]
        public string AppSecret { get; set; }

        /// <summary>
        /// 个人钉钉robotCode字段，名称：机器人编码，字符长度限制64个，仅支持字母、数字、中划线(-)、下划线(_)，一般与appKey一致。当订阅协议为dingTalkBot时，该字段必选。
        /// </summary>
        [JsonProperty("robot_code", NullValueHandling = NullValueHandling.Ignore)]
        public string RobotCode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionExtension {\n");
            sb.Append("  clientId: ").Append(ClientId).Append("\n");
            sb.Append("  clientSecret: ").Append(ClientSecret).Append("\n");
            sb.Append("  keyword: ").Append(Keyword).Append("\n");
            sb.Append("  signSecret: ").Append(SignSecret).Append("\n");
            sb.Append("  header: ").Append(Header).Append("\n");
            sb.Append("  appKey: ").Append(AppKey).Append("\n");
            sb.Append("  appSecret: ").Append(AppSecret).Append("\n");
            sb.Append("  robotCode: ").Append(RobotCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SubscriptionExtension);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SubscriptionExtension input)
        {
            if (input == null) return false;
            if (this.ClientId != input.ClientId || (this.ClientId != null && !this.ClientId.Equals(input.ClientId))) return false;
            if (this.ClientSecret != input.ClientSecret || (this.ClientSecret != null && !this.ClientSecret.Equals(input.ClientSecret))) return false;
            if (this.Keyword != input.Keyword || (this.Keyword != null && !this.Keyword.Equals(input.Keyword))) return false;
            if (this.SignSecret != input.SignSecret || (this.SignSecret != null && !this.SignSecret.Equals(input.SignSecret))) return false;
            if (this.Header != input.Header || (this.Header != null && input.Header != null && !this.Header.SequenceEqual(input.Header))) return false;
            if (this.AppKey != input.AppKey || (this.AppKey != null && !this.AppKey.Equals(input.AppKey))) return false;
            if (this.AppSecret != input.AppSecret || (this.AppSecret != null && !this.AppSecret.Equals(input.AppSecret))) return false;
            if (this.RobotCode != input.RobotCode || (this.RobotCode != null && !this.RobotCode.Equals(input.RobotCode))) return false;

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
                if (this.ClientId != null) hashCode = hashCode * 59 + this.ClientId.GetHashCode();
                if (this.ClientSecret != null) hashCode = hashCode * 59 + this.ClientSecret.GetHashCode();
                if (this.Keyword != null) hashCode = hashCode * 59 + this.Keyword.GetHashCode();
                if (this.SignSecret != null) hashCode = hashCode * 59 + this.SignSecret.GetHashCode();
                if (this.Header != null) hashCode = hashCode * 59 + this.Header.GetHashCode();
                if (this.AppKey != null) hashCode = hashCode * 59 + this.AppKey.GetHashCode();
                if (this.AppSecret != null) hashCode = hashCode * 59 + this.AppSecret.GetHashCode();
                if (this.RobotCode != null) hashCode = hashCode * 59 + this.RobotCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
