using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dms.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ConfirmDeadLettersMessagesResponse : SdkResponse
    {

        /// <summary>
        /// 确认成功的数目（如果为N，则表示前N条消息确认成功）。
        /// </summary>
        [JsonProperty("success", NullValueHandling = NullValueHandling.Ignore)]
        public int? Success { get; set; }

        /// <summary>
        /// 确认失败的数目（如果为N，则表示后N条消息确认失败）。
        /// </summary>
        [JsonProperty("fail", NullValueHandling = NullValueHandling.Ignore)]
        public int? Fail { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfirmDeadLettersMessagesResponse {\n");
            sb.Append("  success: ").Append(Success).Append("\n");
            sb.Append("  fail: ").Append(Fail).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConfirmDeadLettersMessagesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConfirmDeadLettersMessagesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Success == input.Success ||
                    (this.Success != null &&
                    this.Success.Equals(input.Success))
                ) && 
                (
                    this.Fail == input.Fail ||
                    (this.Fail != null &&
                    this.Fail.Equals(input.Fail))
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
                if (this.Success != null)
                    hashCode = hashCode * 59 + this.Success.GetHashCode();
                if (this.Fail != null)
                    hashCode = hashCode * 59 + this.Fail.GetHashCode();
                return hashCode;
            }
        }
    }
}
