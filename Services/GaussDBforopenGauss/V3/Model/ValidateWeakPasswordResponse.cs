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
    /// Response Object
    /// </summary>
    public class ValidateWeakPasswordResponse : SdkResponse
    {

        /// <summary>
        /// 是否为弱密码。 - 返回\&quot;true\&quot;，是弱密码。 - 返回\&quot;false\&quot;，不是弱密码。
        /// </summary>
        [JsonProperty("is_weak_password", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsWeakPassword { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValidateWeakPasswordResponse {\n");
            sb.Append("  isWeakPassword: ").Append(IsWeakPassword).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ValidateWeakPasswordResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ValidateWeakPasswordResponse input)
        {
            if (input == null) return false;
            if (this.IsWeakPassword != input.IsWeakPassword || (this.IsWeakPassword != null && !this.IsWeakPassword.Equals(input.IsWeakPassword))) return false;

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
                if (this.IsWeakPassword != null) hashCode = hashCode * 59 + this.IsWeakPassword.GetHashCode();
                return hashCode;
            }
        }
    }
}
