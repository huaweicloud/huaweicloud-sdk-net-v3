using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aos.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PrivatePolicyBodyPrimitiveTypeHolder 
    {

        /// <summary>
        /// 策略内容。仅支持OPA开源引擎识别的，以rego（https://www.openpolicyagent.org/docs/latest/policy-language/）语言编写的策略模板。  policy_body和policy_uri 必须有且只有一个存在
        /// </summary>
        [JsonProperty("policy_body", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyBody { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrivatePolicyBodyPrimitiveTypeHolder {\n");
            sb.Append("  policyBody: ").Append(PolicyBody).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PrivatePolicyBodyPrimitiveTypeHolder);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PrivatePolicyBodyPrimitiveTypeHolder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PolicyBody == input.PolicyBody ||
                    (this.PolicyBody != null &&
                    this.PolicyBody.Equals(input.PolicyBody))
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
                if (this.PolicyBody != null)
                    hashCode = hashCode * 59 + this.PolicyBody.GetHashCode();
                return hashCode;
            }
        }
    }
}
