using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class CheckCallNumberInConfRequest 
    {

        /// <summary>
        /// 呼叫号码
        /// </summary>
        [SDKProperty("call_number", IsQuery = true)]
        [JsonProperty("call_number", NullValueHandling = NullValueHandling.Ignore)]
        public string CallNumber { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckCallNumberInConfRequest {\n");
            sb.Append("  callNumber: ").Append(CallNumber).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckCallNumberInConfRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CheckCallNumberInConfRequest input)
        {
            if (input == null) return false;
            if (this.CallNumber != input.CallNumber || (this.CallNumber != null && !this.CallNumber.Equals(input.CallNumber))) return false;

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
                if (this.CallNumber != null) hashCode = hashCode * 59 + this.CallNumber.GetHashCode();
                return hashCode;
            }
        }
    }
}
