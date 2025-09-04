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
    public class CustomerOrderV3 
    {

        /// <summary>
        /// 订单ID。
        /// </summary>
        [JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderId { get; set; }

        /// <summary>
        /// 客户账号ID。
        /// </summary>
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerId { get; set; }

        /// <summary>
        /// 云服务类型编码。例如OBS的云服务类型编码为“hws.service.type.obs”。
        /// </summary>
        [JsonProperty("service_type_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceTypeCode { get; set; }

        /// <summary>
        /// 云服务类型名称。例如ECS的云服务类型名称为“弹性云服务器”。
        /// </summary>
        [JsonProperty("service_type_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceTypeName { get; set; }

        /// <summary>
        /// 客户订单来源类型。1：客户 2：代理 3：合同 4：分销商 5：页面删除资源 6：补录订单 7：补偿订单 8：系统自动创建
        /// </summary>
        [JsonProperty("source_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? SourceType { get; set; }

        /// <summary>
        /// 订单状态。 1：待审核2：待退款3：处理中4：已取消5：已完成6：待付款9：待确认10：待发货11：待收货12：待上门取货13：换新中
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }

        /// <summary>
        /// 订单类型。 1：开通2：续订3：变更4：退订11：按需转包年/包月13：试用14：转商用15：费用调整
        /// </summary>
        [JsonProperty("order_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? OrderType { get; set; }

        /// <summary>
        /// 订单优惠后金额（实付价格，不含券不含卡）。
        /// </summary>
        [JsonProperty("amount_after_discount", NullValueHandling = NullValueHandling.Ignore)]
        public double? AmountAfterDiscount { get; set; }

        /// <summary>
        /// 订单金额（官网价）。 退订订单中，该金额等于currencyAfterDiscount。
        /// </summary>
        [JsonProperty("official_amount", NullValueHandling = NullValueHandling.Ignore)]
        public double? OfficialAmount { get; set; }

        /// <summary>
        /// 订单金额度量单位。 1：元
        /// </summary>
        [JsonProperty("measure_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? MeasureId { get; set; }

        /// <summary>
        /// 创建时间 。 UTC时间，格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;，如“2019-05-06T08:05:01Z”。 其中，HH范围是0～23，mm和ss范围是0～59。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 支付时间。 UTC时间，格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;，如“2019-05-06T08:05:01Z”。 其中，HH范围是0～23，mm和ss范围是0～59。
        /// </summary>
        [JsonProperty("payment_time", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentTime { get; set; }

        /// <summary>
        /// 货币编码。
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// 合同ID。
        /// </summary>
        [JsonProperty("contract_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ContractId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("amount_info", NullValueHandling = NullValueHandling.Ignore)]
        public AmountInfomationV2 AmountInfo { get; set; }

        /// <summary>
        /// 订单创建者名称。 如果是客户自己下单，则此处返回下单操作员的登录名称；如果是运营人员从后台下单，则此处返回“运营人员”；如果是运营系统自动触发下单，则此处返回“运营系统”。
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 订单待付款截止时间。UTC时间，格式：yyyy-MM-ddTHH:mm:ssZ，如“2019-05-06T08:05:01Z”。其中，HH范围是0～23，mm和ss范围是0～59。
        /// </summary>
        [JsonProperty("pending_payment_end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string PendingPaymentEndTime { get; set; }

        /// <summary>
        /// 客户订单下属的订单详情信息。具体请参见表 SubCustomerOrderV3 说明：当查询订单为组合交易订单时，订单信息会返回下属的订单信息，当查询为普通订单时，此字段返回为空
        /// </summary>
        [JsonProperty("sub_order_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<SubCustomerOrderV3> SubOrderInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerOrderV3 {\n");
            sb.Append("  orderId: ").Append(OrderId).Append("\n");
            sb.Append("  customerId: ").Append(CustomerId).Append("\n");
            sb.Append("  serviceTypeCode: ").Append(ServiceTypeCode).Append("\n");
            sb.Append("  serviceTypeName: ").Append(ServiceTypeName).Append("\n");
            sb.Append("  sourceType: ").Append(SourceType).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  orderType: ").Append(OrderType).Append("\n");
            sb.Append("  amountAfterDiscount: ").Append(AmountAfterDiscount).Append("\n");
            sb.Append("  officialAmount: ").Append(OfficialAmount).Append("\n");
            sb.Append("  measureId: ").Append(MeasureId).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  paymentTime: ").Append(PaymentTime).Append("\n");
            sb.Append("  currency: ").Append(Currency).Append("\n");
            sb.Append("  contractId: ").Append(ContractId).Append("\n");
            sb.Append("  amountInfo: ").Append(AmountInfo).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  pendingPaymentEndTime: ").Append(PendingPaymentEndTime).Append("\n");
            sb.Append("  subOrderInfos: ").Append(SubOrderInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CustomerOrderV3);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CustomerOrderV3 input)
        {
            if (input == null) return false;
            if (this.OrderId != input.OrderId || (this.OrderId != null && !this.OrderId.Equals(input.OrderId))) return false;
            if (this.CustomerId != input.CustomerId || (this.CustomerId != null && !this.CustomerId.Equals(input.CustomerId))) return false;
            if (this.ServiceTypeCode != input.ServiceTypeCode || (this.ServiceTypeCode != null && !this.ServiceTypeCode.Equals(input.ServiceTypeCode))) return false;
            if (this.ServiceTypeName != input.ServiceTypeName || (this.ServiceTypeName != null && !this.ServiceTypeName.Equals(input.ServiceTypeName))) return false;
            if (this.SourceType != input.SourceType || (this.SourceType != null && !this.SourceType.Equals(input.SourceType))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.OrderType != input.OrderType || (this.OrderType != null && !this.OrderType.Equals(input.OrderType))) return false;
            if (this.AmountAfterDiscount != input.AmountAfterDiscount || (this.AmountAfterDiscount != null && !this.AmountAfterDiscount.Equals(input.AmountAfterDiscount))) return false;
            if (this.OfficialAmount != input.OfficialAmount || (this.OfficialAmount != null && !this.OfficialAmount.Equals(input.OfficialAmount))) return false;
            if (this.MeasureId != input.MeasureId || (this.MeasureId != null && !this.MeasureId.Equals(input.MeasureId))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.PaymentTime != input.PaymentTime || (this.PaymentTime != null && !this.PaymentTime.Equals(input.PaymentTime))) return false;
            if (this.Currency != input.Currency || (this.Currency != null && !this.Currency.Equals(input.Currency))) return false;
            if (this.ContractId != input.ContractId || (this.ContractId != null && !this.ContractId.Equals(input.ContractId))) return false;
            if (this.AmountInfo != input.AmountInfo || (this.AmountInfo != null && !this.AmountInfo.Equals(input.AmountInfo))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.PendingPaymentEndTime != input.PendingPaymentEndTime || (this.PendingPaymentEndTime != null && !this.PendingPaymentEndTime.Equals(input.PendingPaymentEndTime))) return false;
            if (this.SubOrderInfos != input.SubOrderInfos || (this.SubOrderInfos != null && input.SubOrderInfos != null && !this.SubOrderInfos.SequenceEqual(input.SubOrderInfos))) return false;

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
                if (this.OrderId != null) hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.CustomerId != null) hashCode = hashCode * 59 + this.CustomerId.GetHashCode();
                if (this.ServiceTypeCode != null) hashCode = hashCode * 59 + this.ServiceTypeCode.GetHashCode();
                if (this.ServiceTypeName != null) hashCode = hashCode * 59 + this.ServiceTypeName.GetHashCode();
                if (this.SourceType != null) hashCode = hashCode * 59 + this.SourceType.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.OrderType != null) hashCode = hashCode * 59 + this.OrderType.GetHashCode();
                if (this.AmountAfterDiscount != null) hashCode = hashCode * 59 + this.AmountAfterDiscount.GetHashCode();
                if (this.OfficialAmount != null) hashCode = hashCode * 59 + this.OfficialAmount.GetHashCode();
                if (this.MeasureId != null) hashCode = hashCode * 59 + this.MeasureId.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.PaymentTime != null) hashCode = hashCode * 59 + this.PaymentTime.GetHashCode();
                if (this.Currency != null) hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.ContractId != null) hashCode = hashCode * 59 + this.ContractId.GetHashCode();
                if (this.AmountInfo != null) hashCode = hashCode * 59 + this.AmountInfo.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.PendingPaymentEndTime != null) hashCode = hashCode * 59 + this.PendingPaymentEndTime.GetHashCode();
                if (this.SubOrderInfos != null) hashCode = hashCode * 59 + this.SubOrderInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
