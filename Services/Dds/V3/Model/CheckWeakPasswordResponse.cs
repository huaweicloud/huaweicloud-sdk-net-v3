using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dds.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CheckWeakPasswordResponse : SdkResponse
    {

        /// <summary>
        /// 是否弱密码，true:是弱密码 false:不是弱密码
        /// </summary>
        [JsonProperty("weak", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Weak { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckWeakPasswordResponse {\n");
            sb.Append("  weak: ").Append(Weak).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckWeakPasswordResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CheckWeakPasswordResponse input)
        {
            if (input == null) return false;
            if (this.Weak != input.Weak || (this.Weak != null && !this.Weak.Equals(input.Weak))) return false;

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
                if (this.Weak != null) hashCode = hashCode * 59 + this.Weak.GetHashCode();
                return hashCode;
            }
        }
    }
}
