using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DeletePolicyTemplateRequest 
    {

        /// <summary>
        /// 策略模板id。
        /// </summary>
        [SDKProperty("policy_template_id", IsPath = true)]
        [JsonProperty("policy_template_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyTemplateId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeletePolicyTemplateRequest {\n");
            sb.Append("  policyTemplateId: ").Append(PolicyTemplateId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeletePolicyTemplateRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeletePolicyTemplateRequest input)
        {
            if (input == null) return false;
            if (this.PolicyTemplateId != input.PolicyTemplateId || (this.PolicyTemplateId != null && !this.PolicyTemplateId.Equals(input.PolicyTemplateId))) return false;

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
                if (this.PolicyTemplateId != null) hashCode = hashCode * 59 + this.PolicyTemplateId.GetHashCode();
                return hashCode;
            }
        }
    }
}
