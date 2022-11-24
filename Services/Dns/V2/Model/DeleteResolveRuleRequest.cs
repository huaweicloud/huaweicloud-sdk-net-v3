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
    public class DeleteResolveRuleRequest 
    {

        /// <summary>
        /// 待删除resolverrule的ID。
        /// </summary>
        [SDKProperty("resolverrule_id", IsPath = true)]
        [JsonProperty("resolverrule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResolverruleId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteResolveRuleRequest {\n");
            sb.Append("  resolverruleId: ").Append(ResolverruleId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteResolveRuleRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteResolveRuleRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResolverruleId == input.ResolverruleId ||
                    (this.ResolverruleId != null &&
                    this.ResolverruleId.Equals(input.ResolverruleId))
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
                return hashCode;
            }
        }
    }
}
