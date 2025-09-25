using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class WaitEventTime 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("code_wait_event_time", NullValueHandling = NullValueHandling.Ignore)]
        public CodeWaitEventTime CodeWaitEventTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("resource_wait_event_time", NullValueHandling = NullValueHandling.Ignore)]
        public ResourceWaitEventTime ResourceWaitEventTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WaitEventTime {\n");
            sb.Append("  codeWaitEventTime: ").Append(CodeWaitEventTime).Append("\n");
            sb.Append("  resourceWaitEventTime: ").Append(ResourceWaitEventTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WaitEventTime);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WaitEventTime input)
        {
            if (input == null) return false;
            if (this.CodeWaitEventTime != input.CodeWaitEventTime || (this.CodeWaitEventTime != null && !this.CodeWaitEventTime.Equals(input.CodeWaitEventTime))) return false;
            if (this.ResourceWaitEventTime != input.ResourceWaitEventTime || (this.ResourceWaitEventTime != null && !this.ResourceWaitEventTime.Equals(input.ResourceWaitEventTime))) return false;

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
                if (this.CodeWaitEventTime != null) hashCode = hashCode * 59 + this.CodeWaitEventTime.GetHashCode();
                if (this.ResourceWaitEventTime != null) hashCode = hashCode * 59 + this.ResourceWaitEventTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
