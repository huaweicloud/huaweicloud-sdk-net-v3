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
    public class ValidateConsumedMessageResponse : SdkResponse
    {

        /// <summary>
        /// 消费验证结果。
        /// </summary>
        [JsonProperty("resend_results", NullValueHandling = NullValueHandling.Ignore)]
        public List<DeadletterResendRespResendResults> ResendResults { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValidateConsumedMessageResponse {\n");
            sb.Append("  resendResults: ").Append(ResendResults).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ValidateConsumedMessageResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ValidateConsumedMessageResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResendResults == input.ResendResults ||
                    this.ResendResults != null &&
                    input.ResendResults != null &&
                    this.ResendResults.SequenceEqual(input.ResendResults)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ResendResults != null)
                    hashCode = hashCode * 59 + this.ResendResults.GetHashCode();
                return hashCode;
            }
        }
    }
}
