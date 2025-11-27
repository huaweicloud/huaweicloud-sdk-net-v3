using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ucs.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DeletePolicyInstanceRequest 
    {

        /// <summary>
        /// 策略实例id
        /// </summary>
        [SDKProperty("policyinstanceid", IsPath = true)]
        [JsonProperty("policyinstanceid", NullValueHandling = NullValueHandling.Ignore)]
        public string Policyinstanceid { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeletePolicyInstanceRequest {\n");
            sb.Append("  policyinstanceid: ").Append(Policyinstanceid).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeletePolicyInstanceRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeletePolicyInstanceRequest input)
        {
            if (input == null) return false;
            if (this.Policyinstanceid != input.Policyinstanceid || (this.Policyinstanceid != null && !this.Policyinstanceid.Equals(input.Policyinstanceid))) return false;

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
                if (this.Policyinstanceid != null) hashCode = hashCode * 59 + this.Policyinstanceid.GetHashCode();
                return hashCode;
            }
        }
    }
}
