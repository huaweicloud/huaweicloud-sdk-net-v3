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
    public class InvoiceRequestInfoIntl 
    {

        /// <summary>
        /// 请求ID。
        /// </summary>
        [JsonProperty("requestId", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <summary>
        /// 驳回原因。
        /// </summary>
        [JsonProperty("cancelReason", NullValueHandling = NullValueHandling.Ignore)]
        public string CancelReason { get; set; }

        /// <summary>
        /// 开票类型。 0：个人1：企业
        /// </summary>
        [JsonProperty("titleType", NullValueHandling = NullValueHandling.Ignore)]
        public int? TitleType { get; set; }

        /// <summary>
        /// 渠道类型。 0：华为云
        /// </summary>
        [JsonProperty("channelType", NullValueHandling = NullValueHandling.Ignore)]
        public int? ChannelType { get; set; }

        /// <summary>
        /// 发票种类。 0：增值税专用发票1：增值税普通发票
        /// </summary>
        [JsonProperty("invoiceType", NullValueHandling = NullValueHandling.Ignore)]
        public int? InvoiceType { get; set; }

        /// <summary>
        /// 发票抬头。
        /// </summary>
        [JsonProperty("invoiceTitle", NullValueHandling = NullValueHandling.Ignore)]
        public string InvoiceTitle { get; set; }

        /// <summary>
        /// 已开票金额（美元） 。
        /// </summary>
        [JsonProperty("invoiceAmount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? InvoiceAmount { get; set; }

        /// <summary>
        /// 开票方式。 0：账期1：到账2：订单
        /// </summary>
        [JsonProperty("invoiceMethod", NullValueHandling = NullValueHandling.Ignore)]
        public int? InvoiceMethod { get; set; }

        /// <summary>
        /// 发票类别。 0：税票1：商票
        /// </summary>
        [JsonProperty("invoiceClass", NullValueHandling = NullValueHandling.Ignore)]
        public int? InvoiceClass { get; set; }

        /// <summary>
        /// 开票状态。 0：草稿1：待审核4：等待导出发票文件5：等待发票文件回填6：等待邮寄确认7：等待回执确认8：完成9：已退票11：等待驳回审核13：退票待审核14：待退票状态回填15：退票失败
        /// </summary>
        [JsonProperty("invoiceState", NullValueHandling = NullValueHandling.Ignore)]
        public int? InvoiceState { get; set; }

        /// <summary>
        /// 发票申请人员。
        /// </summary>
        [JsonProperty("applyOpera", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplyOpera { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("addressInfo", NullValueHandling = NullValueHandling.Ignore)]
        public PostAddressInfoIntl AddressInfo { get; set; }

        /// <summary>
        /// 申请时间（UTC时间）。
        /// </summary>
        [JsonProperty("applyTime", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplyTime { get; set; }

        /// <summary>
        /// 发票类型。 0：纸质票
        /// </summary>
        [JsonProperty("invoiceMode", NullValueHandling = NullValueHandling.Ignore)]
        public string InvoiceMode { get; set; }

        /// <summary>
        /// 电子发票寄送地。
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>
        /// 申请类型。 0：开票申请1：退票申请2：正向开票已退票
        /// </summary>
        [JsonProperty("requestMode", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestMode { get; set; }

        /// <summary>
        /// 退票时的原申请ID。
        /// </summary>
        [JsonProperty("srcRequestId", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcRequestId { get; set; }

        /// <summary>
        /// 签约主体ID。
        /// </summary>
        [JsonProperty("salesId", NullValueHandling = NullValueHandling.Ignore)]
        public string SalesId { get; set; }

        /// <summary>
        /// 发票号码。
        /// </summary>
        [JsonProperty("invoiceNo", NullValueHandling = NullValueHandling.Ignore)]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 交易类型。 3：结算信用卡扣减4：结算未结清开票5：先开票后到款6：BP月结开票7：充值开票8：包年/包月在线支付开票10：普通提现开票
        /// </summary>
        [JsonProperty("tradeType", NullValueHandling = NullValueHandling.Ignore)]
        public int? TradeType { get; set; }

        /// <summary>
        /// 发票账期。
        /// </summary>
        [JsonProperty("billCycle", NullValueHandling = NullValueHandling.Ignore)]
        public string BillCycle { get; set; }

        /// <summary>
        /// 税务信息列表，参见表4。
        /// </summary>
        [JsonProperty("taxList", NullValueHandling = NullValueHandling.Ignore)]
        public List<TaxInfo> TaxList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvoiceRequestInfoIntl {\n");
            sb.Append("  requestId: ").Append(RequestId).Append("\n");
            sb.Append("  cancelReason: ").Append(CancelReason).Append("\n");
            sb.Append("  titleType: ").Append(TitleType).Append("\n");
            sb.Append("  channelType: ").Append(ChannelType).Append("\n");
            sb.Append("  invoiceType: ").Append(InvoiceType).Append("\n");
            sb.Append("  invoiceTitle: ").Append(InvoiceTitle).Append("\n");
            sb.Append("  invoiceAmount: ").Append(InvoiceAmount).Append("\n");
            sb.Append("  invoiceMethod: ").Append(InvoiceMethod).Append("\n");
            sb.Append("  invoiceClass: ").Append(InvoiceClass).Append("\n");
            sb.Append("  invoiceState: ").Append(InvoiceState).Append("\n");
            sb.Append("  applyOpera: ").Append(ApplyOpera).Append("\n");
            sb.Append("  addressInfo: ").Append(AddressInfo).Append("\n");
            sb.Append("  applyTime: ").Append(ApplyTime).Append("\n");
            sb.Append("  invoiceMode: ").Append(InvoiceMode).Append("\n");
            sb.Append("  email: ").Append(Email).Append("\n");
            sb.Append("  requestMode: ").Append(RequestMode).Append("\n");
            sb.Append("  srcRequestId: ").Append(SrcRequestId).Append("\n");
            sb.Append("  salesId: ").Append(SalesId).Append("\n");
            sb.Append("  invoiceNo: ").Append(InvoiceNo).Append("\n");
            sb.Append("  tradeType: ").Append(TradeType).Append("\n");
            sb.Append("  billCycle: ").Append(BillCycle).Append("\n");
            sb.Append("  taxList: ").Append(TaxList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InvoiceRequestInfoIntl);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InvoiceRequestInfoIntl input)
        {
            if (input == null) return false;
            if (this.RequestId != input.RequestId || (this.RequestId != null && !this.RequestId.Equals(input.RequestId))) return false;
            if (this.CancelReason != input.CancelReason || (this.CancelReason != null && !this.CancelReason.Equals(input.CancelReason))) return false;
            if (this.TitleType != input.TitleType || (this.TitleType != null && !this.TitleType.Equals(input.TitleType))) return false;
            if (this.ChannelType != input.ChannelType || (this.ChannelType != null && !this.ChannelType.Equals(input.ChannelType))) return false;
            if (this.InvoiceType != input.InvoiceType || (this.InvoiceType != null && !this.InvoiceType.Equals(input.InvoiceType))) return false;
            if (this.InvoiceTitle != input.InvoiceTitle || (this.InvoiceTitle != null && !this.InvoiceTitle.Equals(input.InvoiceTitle))) return false;
            if (this.InvoiceAmount != input.InvoiceAmount || (this.InvoiceAmount != null && !this.InvoiceAmount.Equals(input.InvoiceAmount))) return false;
            if (this.InvoiceMethod != input.InvoiceMethod || (this.InvoiceMethod != null && !this.InvoiceMethod.Equals(input.InvoiceMethod))) return false;
            if (this.InvoiceClass != input.InvoiceClass || (this.InvoiceClass != null && !this.InvoiceClass.Equals(input.InvoiceClass))) return false;
            if (this.InvoiceState != input.InvoiceState || (this.InvoiceState != null && !this.InvoiceState.Equals(input.InvoiceState))) return false;
            if (this.ApplyOpera != input.ApplyOpera || (this.ApplyOpera != null && !this.ApplyOpera.Equals(input.ApplyOpera))) return false;
            if (this.AddressInfo != input.AddressInfo || (this.AddressInfo != null && !this.AddressInfo.Equals(input.AddressInfo))) return false;
            if (this.ApplyTime != input.ApplyTime || (this.ApplyTime != null && !this.ApplyTime.Equals(input.ApplyTime))) return false;
            if (this.InvoiceMode != input.InvoiceMode || (this.InvoiceMode != null && !this.InvoiceMode.Equals(input.InvoiceMode))) return false;
            if (this.Email != input.Email || (this.Email != null && !this.Email.Equals(input.Email))) return false;
            if (this.RequestMode != input.RequestMode || (this.RequestMode != null && !this.RequestMode.Equals(input.RequestMode))) return false;
            if (this.SrcRequestId != input.SrcRequestId || (this.SrcRequestId != null && !this.SrcRequestId.Equals(input.SrcRequestId))) return false;
            if (this.SalesId != input.SalesId || (this.SalesId != null && !this.SalesId.Equals(input.SalesId))) return false;
            if (this.InvoiceNo != input.InvoiceNo || (this.InvoiceNo != null && !this.InvoiceNo.Equals(input.InvoiceNo))) return false;
            if (this.TradeType != input.TradeType || (this.TradeType != null && !this.TradeType.Equals(input.TradeType))) return false;
            if (this.BillCycle != input.BillCycle || (this.BillCycle != null && !this.BillCycle.Equals(input.BillCycle))) return false;
            if (this.TaxList != input.TaxList || (this.TaxList != null && input.TaxList != null && !this.TaxList.SequenceEqual(input.TaxList))) return false;

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
                if (this.RequestId != null) hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                if (this.CancelReason != null) hashCode = hashCode * 59 + this.CancelReason.GetHashCode();
                if (this.TitleType != null) hashCode = hashCode * 59 + this.TitleType.GetHashCode();
                if (this.ChannelType != null) hashCode = hashCode * 59 + this.ChannelType.GetHashCode();
                if (this.InvoiceType != null) hashCode = hashCode * 59 + this.InvoiceType.GetHashCode();
                if (this.InvoiceTitle != null) hashCode = hashCode * 59 + this.InvoiceTitle.GetHashCode();
                if (this.InvoiceAmount != null) hashCode = hashCode * 59 + this.InvoiceAmount.GetHashCode();
                if (this.InvoiceMethod != null) hashCode = hashCode * 59 + this.InvoiceMethod.GetHashCode();
                if (this.InvoiceClass != null) hashCode = hashCode * 59 + this.InvoiceClass.GetHashCode();
                if (this.InvoiceState != null) hashCode = hashCode * 59 + this.InvoiceState.GetHashCode();
                if (this.ApplyOpera != null) hashCode = hashCode * 59 + this.ApplyOpera.GetHashCode();
                if (this.AddressInfo != null) hashCode = hashCode * 59 + this.AddressInfo.GetHashCode();
                if (this.ApplyTime != null) hashCode = hashCode * 59 + this.ApplyTime.GetHashCode();
                if (this.InvoiceMode != null) hashCode = hashCode * 59 + this.InvoiceMode.GetHashCode();
                if (this.Email != null) hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.RequestMode != null) hashCode = hashCode * 59 + this.RequestMode.GetHashCode();
                if (this.SrcRequestId != null) hashCode = hashCode * 59 + this.SrcRequestId.GetHashCode();
                if (this.SalesId != null) hashCode = hashCode * 59 + this.SalesId.GetHashCode();
                if (this.InvoiceNo != null) hashCode = hashCode * 59 + this.InvoiceNo.GetHashCode();
                if (this.TradeType != null) hashCode = hashCode * 59 + this.TradeType.GetHashCode();
                if (this.BillCycle != null) hashCode = hashCode * 59 + this.BillCycle.GetHashCode();
                if (this.TaxList != null) hashCode = hashCode * 59 + this.TaxList.GetHashCode();
                return hashCode;
            }
        }
    }
}
