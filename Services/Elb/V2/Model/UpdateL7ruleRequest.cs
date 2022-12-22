using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class UpdateL7ruleRequest 
    {

        /// <summary>
        /// 待更新的转发规则所在的转发策略id
        /// </summary>
        [SDKProperty("l7policy_id", IsPath = true)]
        [JsonProperty("l7policy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string L7policyId { get; set; }

        /// <summary>
        /// 待更新的转发规则id
        /// </summary>
        [SDKProperty("l7rule_id", IsPath = true)]
        [JsonProperty("l7rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string L7ruleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateL7ruleRequestBody Body { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateL7ruleRequest {\n");
            sb.Append("  l7policyId: ").Append(L7policyId).Append("\n");
            sb.Append("  l7ruleId: ").Append(L7ruleId).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateL7ruleRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateL7ruleRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.L7policyId == input.L7policyId ||
                    (this.L7policyId != null &&
                    this.L7policyId.Equals(input.L7policyId))
                ) && 
                (
                    this.L7ruleId == input.L7ruleId ||
                    (this.L7ruleId != null &&
                    this.L7ruleId.Equals(input.L7ruleId))
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
                if (this.L7policyId != null)
                    hashCode = hashCode * 59 + this.L7policyId.GetHashCode();
                if (this.L7ruleId != null)
                    hashCode = hashCode * 59 + this.L7ruleId.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
