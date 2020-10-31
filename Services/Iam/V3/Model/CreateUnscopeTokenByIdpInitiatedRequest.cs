using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class CreateUnscopeTokenByIdpInitiatedRequest 
    {

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("X-Idp-Id", IsHeader = true)]
        [JsonProperty("X-Idp-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string XIdpId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public Object Body { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateUnscopeTokenByIdpInitiatedRequest {\n");
            sb.Append("  xIdpId: ").Append(XIdpId).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateUnscopeTokenByIdpInitiatedRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateUnscopeTokenByIdpInitiatedRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.XIdpId == input.XIdpId ||
                    (this.XIdpId != null &&
                    this.XIdpId.Equals(input.XIdpId))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.XIdpId != null)
                    hashCode = hashCode * 59 + this.XIdpId.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
