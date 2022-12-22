using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpcep.V1.Model
{
    /// <summary>
    /// 更新网关型终端节点policy请求结构体
    /// </summary>
    public class UpdateEndpointPolicyRequestBody 
    {

        /// <summary>
        /// 只涉及开启双端固定的网关型终端节点
        /// </summary>
        [JsonProperty("policy_statement", NullValueHandling = NullValueHandling.Ignore)]
        public List<PolicyStatement> PolicyStatement { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateEndpointPolicyRequestBody {\n");
            sb.Append("  policyStatement: ").Append(PolicyStatement).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateEndpointPolicyRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateEndpointPolicyRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PolicyStatement == input.PolicyStatement ||
                    this.PolicyStatement != null &&
                    input.PolicyStatement != null &&
                    this.PolicyStatement.SequenceEqual(input.PolicyStatement)
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
                if (this.PolicyStatement != null)
                    hashCode = hashCode * 59 + this.PolicyStatement.GetHashCode();
                return hashCode;
            }
        }
    }
}
