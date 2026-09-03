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
    public class ListSubscriptionUserResponseFeishuEndpointInfo 
    {

        /// <summary>
        /// 终端地址。
        /// </summary>
        [JsonProperty("endpoint", NullValueHandling = NullValueHandling.Ignore)]
        public string Endpoint { get; set; }

        /// <summary>
        /// feishu协议订阅用户的关键字。feishu协议订阅用户必须指定keyword和sign_secret二者之一。当用户在飞书机器人端添加关键字校验的安全策略时，这里的关键字必须是飞书端所填写的关键字之一。
        /// </summary>
        [JsonProperty("keyword", NullValueHandling = NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// feishu协议订阅用户的加签密钥字段。feishu协议订阅用户必须指定keyword和sign_secret二者之一。当用户在飞书机器人端添加关键字校验的安全策略时，这里的关键字必须是飞书端所填写的关键字之一。
        /// </summary>
        [JsonProperty("sign_secret", NullValueHandling = NullValueHandling.Ignore)]
        public string SignSecret { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSubscriptionUserResponseFeishuEndpointInfo {\n");
            sb.Append("  endpoint: ").Append(Endpoint).Append("\n");
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
            return this.Equals(input as ListSubscriptionUserResponseFeishuEndpointInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSubscriptionUserResponseFeishuEndpointInfo input)
        {
            if (input == null) return false;
            if (this.Endpoint != input.Endpoint || (this.Endpoint != null && !this.Endpoint.Equals(input.Endpoint))) return false;
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
                if (this.Endpoint != null) hashCode = hashCode * 59 + this.Endpoint.GetHashCode();
                if (this.Keyword != null) hashCode = hashCode * 59 + this.Keyword.GetHashCode();
                if (this.SignSecret != null) hashCode = hashCode * 59 + this.SignSecret.GetHashCode();
                return hashCode;
            }
        }
    }
}
