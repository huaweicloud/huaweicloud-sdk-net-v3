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
    /// 子画面信息。
    /// </summary>
    public class RestPicLayoutBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("restPicLayout", NullValueHandling = NullValueHandling.Ignore)]
        public RestPicLayout RestPicLayout { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestPicLayoutBody {\n");
            sb.Append("  restPicLayout: ").Append(RestPicLayout).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestPicLayoutBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestPicLayoutBody input)
        {
            if (input == null) return false;
            if (this.RestPicLayout != input.RestPicLayout || (this.RestPicLayout != null && !this.RestPicLayout.Equals(input.RestPicLayout))) return false;

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
                if (this.RestPicLayout != null) hashCode = hashCode * 59 + this.RestPicLayout.GetHashCode();
                return hashCode;
            }
        }
    }
}
