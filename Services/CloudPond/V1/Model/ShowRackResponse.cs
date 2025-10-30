using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CloudPond.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowRackResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("rack", NullValueHandling = NullValueHandling.Ignore)]
        public Rack Rack { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowRackResponse {\n");
            sb.Append("  rack: ").Append(Rack).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowRackResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowRackResponse input)
        {
            if (input == null) return false;
            if (this.Rack != input.Rack || (this.Rack != null && !this.Rack.Equals(input.Rack))) return false;

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
                if (this.Rack != null) hashCode = hashCode * 59 + this.Rack.GetHashCode();
                return hashCode;
            }
        }
    }
}
