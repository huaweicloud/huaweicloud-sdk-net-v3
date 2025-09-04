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
    public class QuotaRecord 
    {

        /// <summary>
        /// 记录ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 操作员的账号名称。
        /// </summary>
        [JsonProperty("operator", NullValueHandling = NullValueHandling.Ignore)]
        public string Operator { get; set; }

        /// <summary>
        /// 操作类型。 10：发放额度11：回收额度
        /// </summary>
        [JsonProperty("operation_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OperationType { get; set; }

        /// <summary>
        /// 云经销商的代金券额度ID。 即华为云总经销商给云经销商发放代金券额度时，产生的云经销商的代金券额度ID，或者从云经销商回收代金券额度时，云经销商的代金券额度ID。
        /// </summary>
        [JsonProperty("quota_id", NullValueHandling = NullValueHandling.Ignore)]
        public string QuotaId { get; set; }

        /// <summary>
        /// 父额度ID。 这即华为云总经销商给云经销商发放代金券额度时，华为云总经销商的额度ID，或者从云经销商回收代金券额度时，回收的华为云总经销商的额度ID。
        /// </summary>
        [JsonProperty("parent_quota_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentQuotaId { get; set; }

        /// <summary>
        /// 发放回收的金额。 取值大于0且精确到小数点后2位，单位：元。
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// 操作时间，UTC时间，UTC时间，格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;，如“2019-05-06T08:05:01Z”。其中，HH范围是0～23，mm和ss范围是0～59。
        /// </summary>
        [JsonProperty("operation_time", NullValueHandling = NullValueHandling.Ignore)]
        public string OperationTime { get; set; }

        /// <summary>
        /// 操作结果。 0：成功-1：失败
        /// </summary>
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public string Result { get; set; }

        /// <summary>
        /// 云经销商的账号名。
        /// </summary>
        [JsonProperty("indirect_partner_account_name", NullValueHandling = NullValueHandling.Ignore)]
        public string IndirectPartnerAccountName { get; set; }

        /// <summary>
        /// 云经销商ID。
        /// </summary>
        [JsonProperty("indirect_partner_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IndirectPartnerId { get; set; }

        /// <summary>
        /// 云经销商的公司名称。
        /// </summary>
        [JsonProperty("indirect_partner_name", NullValueHandling = NullValueHandling.Ignore)]
        public string IndirectPartnerName { get; set; }

        /// <summary>
        /// 备注。
        /// </summary>
        [JsonProperty("remark", NullValueHandling = NullValueHandling.Ignore)]
        public string Remark { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuotaRecord {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  operationType: ").Append(OperationType).Append("\n");
            sb.Append("  quotaId: ").Append(QuotaId).Append("\n");
            sb.Append("  parentQuotaId: ").Append(ParentQuotaId).Append("\n");
            sb.Append("  amount: ").Append(Amount).Append("\n");
            sb.Append("  operationTime: ").Append(OperationTime).Append("\n");
            sb.Append("  result: ").Append(Result).Append("\n");
            sb.Append("  indirectPartnerAccountName: ").Append(IndirectPartnerAccountName).Append("\n");
            sb.Append("  indirectPartnerId: ").Append(IndirectPartnerId).Append("\n");
            sb.Append("  indirectPartnerName: ").Append(IndirectPartnerName).Append("\n");
            sb.Append("  remark: ").Append(Remark).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QuotaRecord);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QuotaRecord input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Operator != input.Operator || (this.Operator != null && !this.Operator.Equals(input.Operator))) return false;
            if (this.OperationType != input.OperationType || (this.OperationType != null && !this.OperationType.Equals(input.OperationType))) return false;
            if (this.QuotaId != input.QuotaId || (this.QuotaId != null && !this.QuotaId.Equals(input.QuotaId))) return false;
            if (this.ParentQuotaId != input.ParentQuotaId || (this.ParentQuotaId != null && !this.ParentQuotaId.Equals(input.ParentQuotaId))) return false;
            if (this.Amount != input.Amount || (this.Amount != null && !this.Amount.Equals(input.Amount))) return false;
            if (this.OperationTime != input.OperationTime || (this.OperationTime != null && !this.OperationTime.Equals(input.OperationTime))) return false;
            if (this.Result != input.Result || (this.Result != null && !this.Result.Equals(input.Result))) return false;
            if (this.IndirectPartnerAccountName != input.IndirectPartnerAccountName || (this.IndirectPartnerAccountName != null && !this.IndirectPartnerAccountName.Equals(input.IndirectPartnerAccountName))) return false;
            if (this.IndirectPartnerId != input.IndirectPartnerId || (this.IndirectPartnerId != null && !this.IndirectPartnerId.Equals(input.IndirectPartnerId))) return false;
            if (this.IndirectPartnerName != input.IndirectPartnerName || (this.IndirectPartnerName != null && !this.IndirectPartnerName.Equals(input.IndirectPartnerName))) return false;
            if (this.Remark != input.Remark || (this.Remark != null && !this.Remark.Equals(input.Remark))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Operator != null) hashCode = hashCode * 59 + this.Operator.GetHashCode();
                if (this.OperationType != null) hashCode = hashCode * 59 + this.OperationType.GetHashCode();
                if (this.QuotaId != null) hashCode = hashCode * 59 + this.QuotaId.GetHashCode();
                if (this.ParentQuotaId != null) hashCode = hashCode * 59 + this.ParentQuotaId.GetHashCode();
                if (this.Amount != null) hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.OperationTime != null) hashCode = hashCode * 59 + this.OperationTime.GetHashCode();
                if (this.Result != null) hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.IndirectPartnerAccountName != null) hashCode = hashCode * 59 + this.IndirectPartnerAccountName.GetHashCode();
                if (this.IndirectPartnerId != null) hashCode = hashCode * 59 + this.IndirectPartnerId.GetHashCode();
                if (this.IndirectPartnerName != null) hashCode = hashCode * 59 + this.IndirectPartnerName.GetHashCode();
                if (this.Remark != null) hashCode = hashCode * 59 + this.Remark.GetHashCode();
                return hashCode;
            }
        }
    }
}
