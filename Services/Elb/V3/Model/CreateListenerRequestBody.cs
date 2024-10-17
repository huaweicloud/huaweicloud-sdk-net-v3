using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// This is a auto create Body Object
    /// </summary>
    public class CreateListenerRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("listener", NullValueHandling = NullValueHandling.Ignore)]
        public CreateListenerOption Listener { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateListenerRequestBody {\n");
            sb.Append("  listener: ").Append(Listener).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateListenerRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateListenerRequestBody input)
        {
            if (input == null) return false;
            if (this.Listener != input.Listener || (this.Listener != null && !this.Listener.Equals(input.Listener))) return false;

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
                if (this.Listener != null) hashCode = hashCode * 59 + this.Listener.GetHashCode();
                return hashCode;
            }
        }
    }
}
