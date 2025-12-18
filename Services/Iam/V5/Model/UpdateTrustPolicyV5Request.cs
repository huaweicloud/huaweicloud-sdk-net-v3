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
    /// Request Object
    /// </summary>
    public class UpdateTrustPolicyV5Request 
    {

        /// <summary>
        /// 信任委托ID，长度为1到64个字符，只包含字母、数字和\&quot;-\&quot;的字符串。
        /// </summary>
        [SDKProperty("agency_id", IsPath = true)]
        [JsonProperty("agency_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AgencyId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateTrustPolicyReqBody Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateTrustPolicyV5Request {\n");
            sb.Append("  agencyId: ").Append(AgencyId).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateTrustPolicyV5Request);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateTrustPolicyV5Request input)
        {
            if (input == null) return false;
            if (this.AgencyId != input.AgencyId || (this.AgencyId != null && !this.AgencyId.Equals(input.AgencyId))) return false;
            if (this.Body != input.Body || (this.Body != null && !this.Body.Equals(input.Body))) return false;

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
                if (this.AgencyId != null) hashCode = hashCode * 59 + this.AgencyId.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
