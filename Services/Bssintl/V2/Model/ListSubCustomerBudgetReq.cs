using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bssintl.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ListSubCustomerBudgetReq 
    {

        /// <summary>
        /// |参数名称：客户ID列表| |参数的约束及描述：必填，最大支持100个客户ID，如果其中有存在不是该伙伴的客户ID或者其中有存在与该伙伴不是转售关联类型的客户ID，在响应中不返回该客户信息。|
        /// </summary>
        [JsonProperty("customer_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CustomerIds { get; set; }

        /// <summary>
        /// |参数名称：云经销商ID| |参数约束及描述：非必填，范围限制:0-64，如果需要查询云经销商的子客户列表，必须携带该字段。除此之外，此参数不做处理。|
        /// </summary>
        [JsonProperty("indirect_partner_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IndirectPartnerId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSubCustomerBudgetReq {\n");
            sb.Append("  customerIds: ").Append(CustomerIds).Append("\n");
            sb.Append("  indirectPartnerId: ").Append(IndirectPartnerId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSubCustomerBudgetReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSubCustomerBudgetReq input)
        {
            if (input == null) return false;
            if (this.CustomerIds != input.CustomerIds || (this.CustomerIds != null && input.CustomerIds != null && !this.CustomerIds.SequenceEqual(input.CustomerIds))) return false;
            if (this.IndirectPartnerId != input.IndirectPartnerId || (this.IndirectPartnerId != null && !this.IndirectPartnerId.Equals(input.IndirectPartnerId))) return false;

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
                if (this.CustomerIds != null) hashCode = hashCode * 59 + this.CustomerIds.GetHashCode();
                if (this.IndirectPartnerId != null) hashCode = hashCode * 59 + this.IndirectPartnerId.GetHashCode();
                return hashCode;
            }
        }
    }
}
