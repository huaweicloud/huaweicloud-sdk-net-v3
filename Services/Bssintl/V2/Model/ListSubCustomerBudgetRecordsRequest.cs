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
    /// Request Object
    /// </summary>
    public class ListSubCustomerBudgetRecordsRequest 
    {

        /// <summary>
        /// |参数名称：客户ID| |参数的约束及描述：该参数必填，范围限制：1-64|
        /// </summary>
        [SDKProperty("customer_id", IsQuery = true)]
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerId { get; set; }

        /// <summary>
        /// |参数名称：云经销商ID| |参数的约束及描述：该参数非必填，范围限制：0-64，如果华为云总经销商（一级经销商）需要查询云经销商的子客户预算调整记录，必须携带该字段|
        /// </summary>
        [SDKProperty("indirect_partner_id", IsQuery = true)]
        [JsonProperty("indirect_partner_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IndirectPartnerId { get; set; }

        /// <summary>
        /// |参数名称：操作类别| |参数的约束及描述：该参数非必填，SETTING：设置，DELETE：解除关联关系，此参数不携带时，查询所有类型数据。此参数携带值不支持为空或者空串。|
        /// </summary>
        [SDKProperty("operation_type", IsQuery = true)]
        [JsonProperty("operation_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OperationType { get; set; }

        /// <summary>
        /// |参数名称：预算模式| |参数的约束及描述：该参数非必填，MONTHLY：月度预算，PACKAGE：一次性预算，此参数不携带时，查询所有类型数据。此参数携带值不支持为空或者空串。|
        /// </summary>
        [SDKProperty("budget_type", IsQuery = true)]
        [JsonProperty("budget_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BudgetType { get; set; }

        /// <summary>
        /// |参数名称：偏移量| |参数的约束及描述：该参数非必填，范围限制：0-2147483647，从0开始，默认值为0。|
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// |参数名称：每次查询的数量| |参数的约束及描述：该参数非必填，范围限制：1-100，默认值为10。|
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSubCustomerBudgetRecordsRequest {\n");
            sb.Append("  customerId: ").Append(CustomerId).Append("\n");
            sb.Append("  indirectPartnerId: ").Append(IndirectPartnerId).Append("\n");
            sb.Append("  operationType: ").Append(OperationType).Append("\n");
            sb.Append("  budgetType: ").Append(BudgetType).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSubCustomerBudgetRecordsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSubCustomerBudgetRecordsRequest input)
        {
            if (input == null) return false;
            if (this.CustomerId != input.CustomerId || (this.CustomerId != null && !this.CustomerId.Equals(input.CustomerId))) return false;
            if (this.IndirectPartnerId != input.IndirectPartnerId || (this.IndirectPartnerId != null && !this.IndirectPartnerId.Equals(input.IndirectPartnerId))) return false;
            if (this.OperationType != input.OperationType || (this.OperationType != null && !this.OperationType.Equals(input.OperationType))) return false;
            if (this.BudgetType != input.BudgetType || (this.BudgetType != null && !this.BudgetType.Equals(input.BudgetType))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;

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
                if (this.CustomerId != null) hashCode = hashCode * 59 + this.CustomerId.GetHashCode();
                if (this.IndirectPartnerId != null) hashCode = hashCode * 59 + this.IndirectPartnerId.GetHashCode();
                if (this.OperationType != null) hashCode = hashCode * 59 + this.OperationType.GetHashCode();
                if (this.BudgetType != null) hashCode = hashCode * 59 + this.BudgetType.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
