using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.RocketMQ.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class SendDlqMessageResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**： 重发死信消息结果。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值** 不涉及。
        /// </summary>
        [JsonProperty("resend_results", NullValueHandling = NullValueHandling.Ignore)]
        public List<DeadletterResendRespResendResults> ResendResults { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SendDlqMessageResponse {\n");
            sb.Append("  resendResults: ").Append(ResendResults).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SendDlqMessageResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SendDlqMessageResponse input)
        {
            if (input == null) return false;
            if (this.ResendResults != input.ResendResults || (this.ResendResults != null && input.ResendResults != null && !this.ResendResults.SequenceEqual(input.ResendResults))) return false;

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
                if (this.ResendResults != null) hashCode = hashCode * 59 + this.ResendResults.GetHashCode();
                return hashCode;
            }
        }
    }
}
