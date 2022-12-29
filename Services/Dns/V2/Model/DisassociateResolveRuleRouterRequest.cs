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
    /// Request Object
    /// </summary>
    public class DisassociateResolveRuleRouterRequest 
    {

        /// <summary>
        /// 待解关联resolverrule的ID。
        /// </summary>
        [SDKProperty("resolverrule_id", IsPath = true)]
        [JsonProperty("resolverrule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResolverruleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public DisassociaterouterReq Body { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DisassociateResolveRuleRouterRequest {\n");
            sb.Append("  resolverruleId: ").Append(ResolverruleId).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DisassociateResolveRuleRouterRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DisassociateResolveRuleRouterRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResolverruleId == input.ResolverruleId ||
                    (this.ResolverruleId != null &&
                    this.ResolverruleId.Equals(input.ResolverruleId))
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
                if (this.ResolverruleId != null)
                    hashCode = hashCode * 59 + this.ResolverruleId.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
