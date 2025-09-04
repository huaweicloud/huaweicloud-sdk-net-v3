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
    public class AdjustRecordV3 
    {

        /// <summary>
        /// 客户账号ID。
        /// </summary>
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerId { get; set; }

        /// <summary>
        /// 客户名称。
        /// </summary>
        [JsonProperty("customer_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerName { get; set; }

        /// <summary>
        /// 调账类型。 SOURCE_OPERATION_BEADJUST：拨款SOURCE_OPERATION_BERETRIEVE：回收SOURCE_OPERATION_BEUNBIND：解绑回收
        /// </summary>
        [JsonProperty("operation_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OperationType { get; set; }

        /// <summary>
        /// 调账的总金额。
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Amount { get; set; }

        /// <summary>
        /// 币种。 CNY：人民币
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// 使用场景。
        /// </summary>
        [JsonProperty("apply_scene", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplyScene { get; set; }

        /// <summary>
        /// 调账操作的时间。 UTC时间，格式为：2016-03-28T14:45:38Z
        /// </summary>
        [JsonProperty("operation_time", NullValueHandling = NullValueHandling.Ignore)]
        public string OperationTime { get; set; }

        /// <summary>
        /// 调账单位。 1：元
        /// </summary>
        [JsonProperty("measure_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? MeasureId { get; set; }

        /// <summary>
        /// 事务ID。
        /// </summary>
        [JsonProperty("trans_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TransId { get; set; }

        /// <summary>
        /// 备注。
        /// </summary>
        [JsonProperty("memo", NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdjustRecordV3 {\n");
            sb.Append("  customerId: ").Append(CustomerId).Append("\n");
            sb.Append("  customerName: ").Append(CustomerName).Append("\n");
            sb.Append("  operationType: ").Append(OperationType).Append("\n");
            sb.Append("  amount: ").Append(Amount).Append("\n");
            sb.Append("  currency: ").Append(Currency).Append("\n");
            sb.Append("  applyScene: ").Append(ApplyScene).Append("\n");
            sb.Append("  operationTime: ").Append(OperationTime).Append("\n");
            sb.Append("  measureId: ").Append(MeasureId).Append("\n");
            sb.Append("  transId: ").Append(TransId).Append("\n");
            sb.Append("  memo: ").Append(Memo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AdjustRecordV3);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AdjustRecordV3 input)
        {
            if (input == null) return false;
            if (this.CustomerId != input.CustomerId || (this.CustomerId != null && !this.CustomerId.Equals(input.CustomerId))) return false;
            if (this.CustomerName != input.CustomerName || (this.CustomerName != null && !this.CustomerName.Equals(input.CustomerName))) return false;
            if (this.OperationType != input.OperationType || (this.OperationType != null && !this.OperationType.Equals(input.OperationType))) return false;
            if (this.Amount != input.Amount || (this.Amount != null && !this.Amount.Equals(input.Amount))) return false;
            if (this.Currency != input.Currency || (this.Currency != null && !this.Currency.Equals(input.Currency))) return false;
            if (this.ApplyScene != input.ApplyScene || (this.ApplyScene != null && !this.ApplyScene.Equals(input.ApplyScene))) return false;
            if (this.OperationTime != input.OperationTime || (this.OperationTime != null && !this.OperationTime.Equals(input.OperationTime))) return false;
            if (this.MeasureId != input.MeasureId || (this.MeasureId != null && !this.MeasureId.Equals(input.MeasureId))) return false;
            if (this.TransId != input.TransId || (this.TransId != null && !this.TransId.Equals(input.TransId))) return false;
            if (this.Memo != input.Memo || (this.Memo != null && !this.Memo.Equals(input.Memo))) return false;

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
                if (this.CustomerName != null) hashCode = hashCode * 59 + this.CustomerName.GetHashCode();
                if (this.OperationType != null) hashCode = hashCode * 59 + this.OperationType.GetHashCode();
                if (this.Amount != null) hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Currency != null) hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.ApplyScene != null) hashCode = hashCode * 59 + this.ApplyScene.GetHashCode();
                if (this.OperationTime != null) hashCode = hashCode * 59 + this.OperationTime.GetHashCode();
                if (this.MeasureId != null) hashCode = hashCode * 59 + this.MeasureId.GetHashCode();
                if (this.TransId != null) hashCode = hashCode * 59 + this.TransId.GetHashCode();
                if (this.Memo != null) hashCode = hashCode * 59 + this.Memo.GetHashCode();
                return hashCode;
            }
        }
    }
}
