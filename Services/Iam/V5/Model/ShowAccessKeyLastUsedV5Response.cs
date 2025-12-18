using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowAccessKeyLastUsedV5Response : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("access_key_last_used", NullValueHandling = NullValueHandling.Ignore)]
        public AccessKeyLastUsed AccessKeyLastUsed { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAccessKeyLastUsedV5Response {\n");
            sb.Append("  accessKeyLastUsed: ").Append(AccessKeyLastUsed).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAccessKeyLastUsedV5Response);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAccessKeyLastUsedV5Response input)
        {
            if (input == null) return false;
            if (this.AccessKeyLastUsed != input.AccessKeyLastUsed || (this.AccessKeyLastUsed != null && !this.AccessKeyLastUsed.Equals(input.AccessKeyLastUsed))) return false;

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
                if (this.AccessKeyLastUsed != null) hashCode = hashCode * 59 + this.AccessKeyLastUsed.GetHashCode();
                return hashCode;
            }
        }
    }
}
