using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ValidateAuthorizationRequestBody 
    {

        /// <summary>
        /// **参数解释**：工作空间鉴权请求体。
        /// </summary>
        [JsonProperty("requests", NullValueHandling = NullValueHandling.Ignore)]
        public List<AuthRequests> Requests { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValidateAuthorizationRequestBody {\n");
            sb.Append("  requests: ").Append(Requests).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ValidateAuthorizationRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ValidateAuthorizationRequestBody input)
        {
            if (input == null) return false;
            if (this.Requests != input.Requests || (this.Requests != null && input.Requests != null && !this.Requests.SequenceEqual(input.Requests))) return false;

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
                if (this.Requests != null) hashCode = hashCode * 59 + this.Requests.GetHashCode();
                return hashCode;
            }
        }
    }
}
