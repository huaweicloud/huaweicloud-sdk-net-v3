using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aos.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowStackSetTemplateResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("Location", IsHeader = true)]
        [JsonProperty("Location", NullValueHandling = NullValueHandling.Ignore)]
        public string Location { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowStackSetTemplateResponse {\n");
            sb.Append("  location: ").Append(Location).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowStackSetTemplateResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowStackSetTemplateResponse input)
        {
            if (input == null) return false;
            if (this.Location != input.Location || (this.Location != null && !this.Location.Equals(input.Location))) return false;

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
                if (this.Location != null) hashCode = hashCode * 59 + this.Location.GetHashCode();
                return hashCode;
            }
        }
    }
}
