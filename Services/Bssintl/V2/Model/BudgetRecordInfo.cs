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
    public class BudgetRecordInfo 
    {

        /// <summary>
        /// |参数名称：预算金额||参数的约束及描述：单位：元，精确至小数点后2位。范围限制:0-2147483647|
        /// </summary>
        [JsonProperty("budget_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? BudgetAmount { get; set; }

        /// <summary>
        /// |参数名称：操作类别| |参数的约束及描述：范围限制：0-10。SETTING：设置 DELETE：解除关联关系。|
        /// </summary>
        [JsonProperty("operation_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OperationType { get; set; }

        /// <summary>
        /// |参数名称：操作时间| |参数的约束及描述：UTC时间，格式为：yyyy-MM-ddTHH:mm:ssZ。|
        /// </summary>
        [JsonProperty("operation_time", NullValueHandling = NullValueHandling.Ignore)]
        public string OperationTime { get; set; }

        /// <summary>
        /// |参数名称：操作员或系统system| |参数的约束及描述：范围限制：0-64|
        /// </summary>
        [JsonProperty("operator", NullValueHandling = NullValueHandling.Ignore)]
        public string Operator { get; set; }

        /// <summary>
        /// |参数名称：预算模式| |参数的约束及描述：范围限制：0-10。MONTHLY：月度预算 PACKAGE：一次性预算|
        /// </summary>
        [JsonProperty("budget_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BudgetType { get; set; }

        /// <summary>
        /// |参数名称：伙伴名称| |参数的约束及描述：范围限制：0-256|
        /// </summary>
        [JsonProperty("partner_corp_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PartnerCorpName { get; set; }

        /// <summary>
        /// |参数名称：伙伴账号名| |参数的约束及描述：范围限制：0-128|
        /// </summary>
        [JsonProperty("partner_account_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PartnerAccountName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BudgetRecordInfo {\n");
            sb.Append("  budgetAmount: ").Append(BudgetAmount).Append("\n");
            sb.Append("  operationType: ").Append(OperationType).Append("\n");
            sb.Append("  operationTime: ").Append(OperationTime).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  budgetType: ").Append(BudgetType).Append("\n");
            sb.Append("  partnerCorpName: ").Append(PartnerCorpName).Append("\n");
            sb.Append("  partnerAccountName: ").Append(PartnerAccountName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BudgetRecordInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BudgetRecordInfo input)
        {
            if (input == null) return false;
            if (this.BudgetAmount != input.BudgetAmount || (this.BudgetAmount != null && !this.BudgetAmount.Equals(input.BudgetAmount))) return false;
            if (this.OperationType != input.OperationType || (this.OperationType != null && !this.OperationType.Equals(input.OperationType))) return false;
            if (this.OperationTime != input.OperationTime || (this.OperationTime != null && !this.OperationTime.Equals(input.OperationTime))) return false;
            if (this.Operator != input.Operator || (this.Operator != null && !this.Operator.Equals(input.Operator))) return false;
            if (this.BudgetType != input.BudgetType || (this.BudgetType != null && !this.BudgetType.Equals(input.BudgetType))) return false;
            if (this.PartnerCorpName != input.PartnerCorpName || (this.PartnerCorpName != null && !this.PartnerCorpName.Equals(input.PartnerCorpName))) return false;
            if (this.PartnerAccountName != input.PartnerAccountName || (this.PartnerAccountName != null && !this.PartnerAccountName.Equals(input.PartnerAccountName))) return false;

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
                if (this.BudgetAmount != null) hashCode = hashCode * 59 + this.BudgetAmount.GetHashCode();
                if (this.OperationType != null) hashCode = hashCode * 59 + this.OperationType.GetHashCode();
                if (this.OperationTime != null) hashCode = hashCode * 59 + this.OperationTime.GetHashCode();
                if (this.Operator != null) hashCode = hashCode * 59 + this.Operator.GetHashCode();
                if (this.BudgetType != null) hashCode = hashCode * 59 + this.BudgetType.GetHashCode();
                if (this.PartnerCorpName != null) hashCode = hashCode * 59 + this.PartnerCorpName.GetHashCode();
                if (this.PartnerAccountName != null) hashCode = hashCode * 59 + this.PartnerAccountName.GetHashCode();
                return hashCode;
            }
        }
    }
}
