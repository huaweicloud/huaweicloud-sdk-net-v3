using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bss.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AgentPayInfoV2 
    {

        /// <summary>
        /// |参数名称：订单代理支付人的客户账号ID。| |参数的约束及描述：订单代理支付人的客户账号ID|
        /// </summary>
        [JsonProperty("paying_agent_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PayingAgentId { get; set; }

        /// <summary>
        /// |参数名称：是否代理支付。| |参数的约束及描述：是否代理支付。true：代理支付，不为ture时为非代理支付订单|
        /// </summary>
        [JsonProperty("is_agent_pay", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAgentPay { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentPayInfoV2 {\n");
            sb.Append("  payingAgentId: ").Append(PayingAgentId).Append("\n");
            sb.Append("  isAgentPay: ").Append(IsAgentPay).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AgentPayInfoV2);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AgentPayInfoV2 input)
        {
            if (input == null) return false;
            if (this.PayingAgentId != input.PayingAgentId || (this.PayingAgentId != null && !this.PayingAgentId.Equals(input.PayingAgentId))) return false;
            if (this.IsAgentPay != input.IsAgentPay || (this.IsAgentPay != null && !this.IsAgentPay.Equals(input.IsAgentPay))) return false;

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
                if (this.PayingAgentId != null) hashCode = hashCode * 59 + this.PayingAgentId.GetHashCode();
                if (this.IsAgentPay != null) hashCode = hashCode * 59 + this.IsAgentPay.GetHashCode();
                return hashCode;
            }
        }
    }
}
