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
    public class CreateSubscriptionUserRequestDingTalkBotEndpointInfo 
    {

        /// <summary>
        /// 钉钉企业用户的userId。
        /// </summary>
        [JsonProperty("endpoint", NullValueHandling = NullValueHandling.Ignore)]
        public string Endpoint { get; set; }

        /// <summary>
        /// 个人钉钉appKey字段。
        /// </summary>
        [JsonProperty("app_key", NullValueHandling = NullValueHandling.Ignore)]
        public string AppKey { get; set; }

        /// <summary>
        /// 个人钉钉appSecret字段。
        /// </summary>
        [JsonProperty("app_secret", NullValueHandling = NullValueHandling.Ignore)]
        public string AppSecret { get; set; }

        /// <summary>
        /// 个人钉钉robotCode字段。
        /// </summary>
        [JsonProperty("robot_code", NullValueHandling = NullValueHandling.Ignore)]
        public string RobotCode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSubscriptionUserRequestDingTalkBotEndpointInfo {\n");
            sb.Append("  endpoint: ").Append(Endpoint).Append("\n");
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
            return this.Equals(input as CreateSubscriptionUserRequestDingTalkBotEndpointInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateSubscriptionUserRequestDingTalkBotEndpointInfo input)
        {
            if (input == null) return false;
            if (this.Endpoint != input.Endpoint || (this.Endpoint != null && !this.Endpoint.Equals(input.Endpoint))) return false;
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
                if (this.Endpoint != null) hashCode = hashCode * 59 + this.Endpoint.GetHashCode();
                if (this.AppKey != null) hashCode = hashCode * 59 + this.AppKey.GetHashCode();
                if (this.AppSecret != null) hashCode = hashCode * 59 + this.AppSecret.GetHashCode();
                if (this.RobotCode != null) hashCode = hashCode * 59 + this.RobotCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
