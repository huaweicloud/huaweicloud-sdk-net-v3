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
    public class CreateSubscriptionUserRequestBody 
    {

        /// <summary>
        /// 订阅用户名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 订阅用户分组。每个订阅分组只能包含中英文、数字([0-9])、下划线(_)，下划线不能出现在开始或结尾，下划线不能连续出现，长度为1到32个字符。
        /// </summary>
        [JsonProperty("group", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Group { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("http", NullValueHandling = NullValueHandling.Ignore)]
        public CreateSubscriptionUserRequestHttpEndpointInfo Http { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("https", NullValueHandling = NullValueHandling.Ignore)]
        public CreateSubscriptionUserRequestHttpsEndpointInfo Https { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("sms", NullValueHandling = NullValueHandling.Ignore)]
        public CreateSubscriptionUserRequestSmsEndpointInfo Sms { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public CreateSubscriptionUserRequestEmailEndpointInfo Email { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSubscriptionUserRequestBody {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  group: ").Append(Group).Append("\n");
            sb.Append("  http: ").Append(Http).Append("\n");
            sb.Append("  https: ").Append(Https).Append("\n");
            sb.Append("  sms: ").Append(Sms).Append("\n");
            sb.Append("  email: ").Append(Email).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateSubscriptionUserRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateSubscriptionUserRequestBody input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Group != input.Group || (this.Group != null && input.Group != null && !this.Group.SequenceEqual(input.Group))) return false;
            if (this.Http != input.Http || (this.Http != null && !this.Http.Equals(input.Http))) return false;
            if (this.Https != input.Https || (this.Https != null && !this.Https.Equals(input.Https))) return false;
            if (this.Sms != input.Sms || (this.Sms != null && !this.Sms.Equals(input.Sms))) return false;
            if (this.Email != input.Email || (this.Email != null && !this.Email.Equals(input.Email))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Group != null) hashCode = hashCode * 59 + this.Group.GetHashCode();
                if (this.Http != null) hashCode = hashCode * 59 + this.Http.GetHashCode();
                if (this.Https != null) hashCode = hashCode * 59 + this.Https.GetHashCode();
                if (this.Sms != null) hashCode = hashCode * 59 + this.Sms.GetHashCode();
                if (this.Email != null) hashCode = hashCode * 59 + this.Email.GetHashCode();
                return hashCode;
            }
        }
    }
}
