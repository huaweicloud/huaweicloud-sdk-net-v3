using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dns.V2.Model
{
    /// <summary>
    /// 指向当前资源的链接。
    /// </summary>
    public class Link 
    {

        /// <summary>
        /// 当前资源的链接。
        /// </summary>
        [JsonProperty("self", NullValueHandling = NullValueHandling.Ignore)]
        public string Self { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Link {\n");
            sb.Append("  self: ").Append(Self).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Link);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Link input)
        {
            if (input == null) return false;
            if (this.Self != input.Self || (this.Self != null && !this.Self.Equals(input.Self))) return false;

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
                if (this.Self != null) hashCode = hashCode * 59 + this.Self.GetHashCode();
                return hashCode;
            }
        }
    }
}
