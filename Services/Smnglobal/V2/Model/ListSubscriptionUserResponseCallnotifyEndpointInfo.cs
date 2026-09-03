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
    public class ListSubscriptionUserResponseCallnotifyEndpointInfo 
    {

        /// <summary>
        /// 终端地址。
        /// </summary>
        [JsonProperty("endpoint", NullValueHandling = NullValueHandling.Ignore)]
        public string Endpoint { get; set; }

        /// <summary>
        /// 是否启用验证码发送确认短信，默认为false。
        /// </summary>
        [JsonProperty("verification_code_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? VerificationCodeEnabled { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSubscriptionUserResponseCallnotifyEndpointInfo {\n");
            sb.Append("  endpoint: ").Append(Endpoint).Append("\n");
            sb.Append("  verificationCodeEnabled: ").Append(VerificationCodeEnabled).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSubscriptionUserResponseCallnotifyEndpointInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSubscriptionUserResponseCallnotifyEndpointInfo input)
        {
            if (input == null) return false;
            if (this.Endpoint != input.Endpoint || (this.Endpoint != null && !this.Endpoint.Equals(input.Endpoint))) return false;
            if (this.VerificationCodeEnabled != input.VerificationCodeEnabled || (this.VerificationCodeEnabled != null && !this.VerificationCodeEnabled.Equals(input.VerificationCodeEnabled))) return false;

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
                if (this.VerificationCodeEnabled != null) hashCode = hashCode * 59 + this.VerificationCodeEnabled.GetHashCode();
                return hashCode;
            }
        }
    }
}
