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
        /// 该字段为welink订阅下的租户ID字段，由租户从welink方获取。当protocol值为welink时，该字段为必填字段。
        /// </summary>
        [JsonProperty("client_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientId { get; set; }

        /// <summary>
        /// 该字段为welink订阅下的租户获取的client secret字段，由租户从welink方获取。当protocol值为welink时，该字段为必填字段。
        /// </summary>
        [JsonProperty("client_secret", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// 该字段为关键字字段。当protocol协议为feishu时，这里的keyword字段和sign_secret字段二者必选其一。当用户在飞书或钉钉机器人端添加关键字校验的安全策略时，这里的关键字必须是飞书或钉钉端所填写的关键字之一。
        /// </summary>
        [JsonProperty("keyword", NullValueHandling = NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// 这是加签密钥字段。当protocol协议为feishu或dingding时，这个字段和keyword字段二者必选且只能选其一，密钥配置必须与客户在飞书或钉钉客户端的密钥配置完全一致。例如，如果在飞书端配置了密钥并且没有配置关键字，则在此处填入从飞书获取的密钥字段，如果在飞书端没有配置密钥并且配置了关键字，则不填写该字段。
        /// </summary>
        [JsonProperty("sign_secret", NullValueHandling = NullValueHandling.Ignore)]
        public string SignSecret { get; set; }



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
                return hashCode;
            }
        }
    }
}
