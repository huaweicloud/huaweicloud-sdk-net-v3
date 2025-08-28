using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cc.V3.Model
{
    /// <summary>
    /// 更新授权的详细信息。
    /// </summary>
    public class UpdateAuthorisationRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("authorisation", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateAuthorisation Authorisation { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateAuthorisationRequestBody {\n");
            sb.Append("  authorisation: ").Append(Authorisation).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateAuthorisationRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateAuthorisationRequestBody input)
        {
            if (input == null) return false;
            if (this.Authorisation != input.Authorisation || (this.Authorisation != null && !this.Authorisation.Equals(input.Authorisation))) return false;

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
                if (this.Authorisation != null) hashCode = hashCode * 59 + this.Authorisation.GetHashCode();
                return hashCode;
            }
        }
    }
}
