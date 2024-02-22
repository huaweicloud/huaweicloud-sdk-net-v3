using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ocr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class TrainTicketResult 
    {

        /// <summary>
        /// 火车票左上角的车票ID。 
        /// </summary>
        [JsonProperty("ticket_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TicketId { get; set; }

        /// <summary>
        /// 检票口信息。 
        /// </summary>
        [JsonProperty("check_port", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckPort { get; set; }

        /// <summary>
        /// 车次。 
        /// </summary>
        [JsonProperty("train_number", NullValueHandling = NullValueHandling.Ignore)]
        public string TrainNumber { get; set; }

        /// <summary>
        /// 始发站。 
        /// </summary>
        [JsonProperty("departure_station", NullValueHandling = NullValueHandling.Ignore)]
        public string DepartureStation { get; set; }

        /// <summary>
        /// 终点站。 
        /// </summary>
        [JsonProperty("destination_station", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationStation { get; set; }

        /// <summary>
        /// 始发站拼音。 
        /// </summary>
        [JsonProperty("departure_station_en", NullValueHandling = NullValueHandling.Ignore)]
        public string DepartureStationEn { get; set; }

        /// <summary>
        /// 终点站拼音。 
        /// </summary>
        [JsonProperty("destination_station_en", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationStationEn { get; set; }

        /// <summary>
        /// 开车时间。 
        /// </summary>
        [JsonProperty("departure_time", NullValueHandling = NullValueHandling.Ignore)]
        public string DepartureTime { get; set; }

        /// <summary>
        /// 座位号。 
        /// </summary>
        [JsonProperty("seat_number", NullValueHandling = NullValueHandling.Ignore)]
        public string SeatNumber { get; set; }

        /// <summary>
        /// 票价。 
        /// </summary>
        [JsonProperty("ticket_price", NullValueHandling = NullValueHandling.Ignore)]
        public string TicketPrice { get; set; }

        /// <summary>
        /// 售票方式。 
        /// </summary>
        [JsonProperty("sale_method", NullValueHandling = NullValueHandling.Ignore)]
        public string SaleMethod { get; set; }

        /// <summary>
        /// 座位类别。 
        /// </summary>
        [JsonProperty("seat_category", NullValueHandling = NullValueHandling.Ignore)]
        public string SeatCategory { get; set; }

        /// <summary>
        /// 是否改签票, \&quot;Yes\&quot;表示改签票，\&quot;No\&quot;表示非改签票。 
        /// </summary>
        [JsonProperty("ticket_changing", NullValueHandling = NullValueHandling.Ignore)]
        public string TicketChanging { get; set; }

        /// <summary>
        /// 车票持有人的身份证号。 
        /// </summary>
        [JsonProperty("id_number", NullValueHandling = NullValueHandling.Ignore)]
        public string IdNumber { get; set; }

        /// <summary>
        /// 车票持有人姓名。 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 车票最下方的序列号。 
        /// </summary>
        [JsonProperty("log_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogId { get; set; }

        /// <summary>
        /// 车票售票地点。 
        /// </summary>
        [JsonProperty("sale_location", NullValueHandling = NullValueHandling.Ignore)]
        public string SaleLocation { get; set; }

        /// <summary>
        /// 类型。包含以下几种类型： - paper：纸质火车票 - electronic：电子发票 - refund_old：旧版退票凭证 - refund_new：新版退票凭证 
        /// </summary>
        [JsonProperty("invoice_style", NullValueHandling = NullValueHandling.Ignore)]
        public string InvoiceStyle { get; set; }

        /// <summary>
        /// 开票时间 
        /// </summary>
        [JsonProperty("issue_date", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueDate { get; set; }

        /// <summary>
        /// 打折标识 
        /// </summary>
        [JsonProperty("discount_mark", NullValueHandling = NullValueHandling.Ignore)]
        public string DiscountMark { get; set; }

        /// <summary>
        /// 电子客票号 
        /// </summary>
        [JsonProperty("serial_number", NullValueHandling = NullValueHandling.Ignore)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// 税金价格 
        /// </summary>
        [JsonProperty("tax_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string TaxAmount { get; set; }

        /// <summary>
        /// 税率 
        /// </summary>
        [JsonProperty("tax_rate", NullValueHandling = NullValueHandling.Ignore)]
        public string TaxRate { get; set; }

        /// <summary>
        /// 是否是空调车厢 
        /// </summary>
        [JsonProperty("air_conditioning", NullValueHandling = NullValueHandling.Ignore)]
        public string AirConditioning { get; set; }

        /// <summary>
        /// 原发票号码 
        /// </summary>
        [JsonProperty("original_invoice_number", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginalInvoiceNumber { get; set; }

        /// <summary>
        /// 统一社会信用号码 
        /// </summary>
        [JsonProperty("unified_social_credit_code", NullValueHandling = NullValueHandling.Ignore)]
        public string UnifiedSocialCreditCode { get; set; }

        /// <summary>
        /// 购买方名称 
        /// </summary>
        [JsonProperty("buyer_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BuyerName { get; set; }

        /// <summary>
        /// 不含税价格 
        /// </summary>
        [JsonProperty("total_amount_excluding_tax", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalAmountExcludingTax { get; set; }

        /// <summary>
        /// 发票号码 
        /// </summary>
        [JsonProperty("invoice_number", NullValueHandling = NullValueHandling.Ignore)]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// 是否有印章，True表示有印章，False表示不含印章，字段默认为False 
        /// </summary>
        [JsonProperty("seal_mark", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SealMark { get; set; }

        /// <summary>
        /// 标题 
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// 地区 
        /// </summary>
        [JsonProperty("area", NullValueHandling = NullValueHandling.Ignore)]
        public string Area { get; set; }

        /// <summary>
        /// 收据编码 
        /// </summary>
        [JsonProperty("receipt_number", NullValueHandling = NullValueHandling.Ignore)]
        public string ReceiptNumber { get; set; }

        /// <summary>
        /// 小写票据金额 
        /// </summary>
        [JsonProperty("amount_in_figures", NullValueHandling = NullValueHandling.Ignore)]
        public string AmountInFigures { get; set; }

        /// <summary>
        /// 大写票据金额 
        /// </summary>
        [JsonProperty("amount_in_words", NullValueHandling = NullValueHandling.Ignore)]
        public string AmountInWords { get; set; }

        /// <summary>
        /// 相关字段的置信度信息，置信度越大，表示本次识别的对应字段的可靠性越高，在统计意义上，置信度越大，准确率越高。 置信度由算法给出，不直接等价于对应字段的准确率。
        /// </summary>
        [JsonProperty("confidence", NullValueHandling = NullValueHandling.Ignore)]
        public Object Confidence { get; set; }

        /// <summary>
        /// 对应所有在原图上识别到的字段位置信息，包含所有文字区域四个顶点的二维坐标（x,y）。采用图像坐标系，坐标原点为图片左上角，x轴沿水平方向，y轴沿竖直方向。 
        /// </summary>
        [JsonProperty("text_location", NullValueHandling = NullValueHandling.Ignore)]
        public Object TextLocation { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrainTicketResult {\n");
            sb.Append("  ticketId: ").Append(TicketId).Append("\n");
            sb.Append("  checkPort: ").Append(CheckPort).Append("\n");
            sb.Append("  trainNumber: ").Append(TrainNumber).Append("\n");
            sb.Append("  departureStation: ").Append(DepartureStation).Append("\n");
            sb.Append("  destinationStation: ").Append(DestinationStation).Append("\n");
            sb.Append("  departureStationEn: ").Append(DepartureStationEn).Append("\n");
            sb.Append("  destinationStationEn: ").Append(DestinationStationEn).Append("\n");
            sb.Append("  departureTime: ").Append(DepartureTime).Append("\n");
            sb.Append("  seatNumber: ").Append(SeatNumber).Append("\n");
            sb.Append("  ticketPrice: ").Append(TicketPrice).Append("\n");
            sb.Append("  saleMethod: ").Append(SaleMethod).Append("\n");
            sb.Append("  seatCategory: ").Append(SeatCategory).Append("\n");
            sb.Append("  ticketChanging: ").Append(TicketChanging).Append("\n");
            sb.Append("  idNumber: ").Append(IdNumber).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  logId: ").Append(LogId).Append("\n");
            sb.Append("  saleLocation: ").Append(SaleLocation).Append("\n");
            sb.Append("  invoiceStyle: ").Append(InvoiceStyle).Append("\n");
            sb.Append("  issueDate: ").Append(IssueDate).Append("\n");
            sb.Append("  discountMark: ").Append(DiscountMark).Append("\n");
            sb.Append("  serialNumber: ").Append(SerialNumber).Append("\n");
            sb.Append("  taxAmount: ").Append(TaxAmount).Append("\n");
            sb.Append("  taxRate: ").Append(TaxRate).Append("\n");
            sb.Append("  airConditioning: ").Append(AirConditioning).Append("\n");
            sb.Append("  originalInvoiceNumber: ").Append(OriginalInvoiceNumber).Append("\n");
            sb.Append("  unifiedSocialCreditCode: ").Append(UnifiedSocialCreditCode).Append("\n");
            sb.Append("  buyerName: ").Append(BuyerName).Append("\n");
            sb.Append("  totalAmountExcludingTax: ").Append(TotalAmountExcludingTax).Append("\n");
            sb.Append("  invoiceNumber: ").Append(InvoiceNumber).Append("\n");
            sb.Append("  sealMark: ").Append(SealMark).Append("\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  area: ").Append(Area).Append("\n");
            sb.Append("  receiptNumber: ").Append(ReceiptNumber).Append("\n");
            sb.Append("  amountInFigures: ").Append(AmountInFigures).Append("\n");
            sb.Append("  amountInWords: ").Append(AmountInWords).Append("\n");
            sb.Append("  confidence: ").Append(Confidence).Append("\n");
            sb.Append("  textLocation: ").Append(TextLocation).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TrainTicketResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TrainTicketResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TicketId == input.TicketId ||
                    (this.TicketId != null &&
                    this.TicketId.Equals(input.TicketId))
                ) && 
                (
                    this.CheckPort == input.CheckPort ||
                    (this.CheckPort != null &&
                    this.CheckPort.Equals(input.CheckPort))
                ) && 
                (
                    this.TrainNumber == input.TrainNumber ||
                    (this.TrainNumber != null &&
                    this.TrainNumber.Equals(input.TrainNumber))
                ) && 
                (
                    this.DepartureStation == input.DepartureStation ||
                    (this.DepartureStation != null &&
                    this.DepartureStation.Equals(input.DepartureStation))
                ) && 
                (
                    this.DestinationStation == input.DestinationStation ||
                    (this.DestinationStation != null &&
                    this.DestinationStation.Equals(input.DestinationStation))
                ) && 
                (
                    this.DepartureStationEn == input.DepartureStationEn ||
                    (this.DepartureStationEn != null &&
                    this.DepartureStationEn.Equals(input.DepartureStationEn))
                ) && 
                (
                    this.DestinationStationEn == input.DestinationStationEn ||
                    (this.DestinationStationEn != null &&
                    this.DestinationStationEn.Equals(input.DestinationStationEn))
                ) && 
                (
                    this.DepartureTime == input.DepartureTime ||
                    (this.DepartureTime != null &&
                    this.DepartureTime.Equals(input.DepartureTime))
                ) && 
                (
                    this.SeatNumber == input.SeatNumber ||
                    (this.SeatNumber != null &&
                    this.SeatNumber.Equals(input.SeatNumber))
                ) && 
                (
                    this.TicketPrice == input.TicketPrice ||
                    (this.TicketPrice != null &&
                    this.TicketPrice.Equals(input.TicketPrice))
                ) && 
                (
                    this.SaleMethod == input.SaleMethod ||
                    (this.SaleMethod != null &&
                    this.SaleMethod.Equals(input.SaleMethod))
                ) && 
                (
                    this.SeatCategory == input.SeatCategory ||
                    (this.SeatCategory != null &&
                    this.SeatCategory.Equals(input.SeatCategory))
                ) && 
                (
                    this.TicketChanging == input.TicketChanging ||
                    (this.TicketChanging != null &&
                    this.TicketChanging.Equals(input.TicketChanging))
                ) && 
                (
                    this.IdNumber == input.IdNumber ||
                    (this.IdNumber != null &&
                    this.IdNumber.Equals(input.IdNumber))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.LogId == input.LogId ||
                    (this.LogId != null &&
                    this.LogId.Equals(input.LogId))
                ) && 
                (
                    this.SaleLocation == input.SaleLocation ||
                    (this.SaleLocation != null &&
                    this.SaleLocation.Equals(input.SaleLocation))
                ) && 
                (
                    this.InvoiceStyle == input.InvoiceStyle ||
                    (this.InvoiceStyle != null &&
                    this.InvoiceStyle.Equals(input.InvoiceStyle))
                ) && 
                (
                    this.IssueDate == input.IssueDate ||
                    (this.IssueDate != null &&
                    this.IssueDate.Equals(input.IssueDate))
                ) && 
                (
                    this.DiscountMark == input.DiscountMark ||
                    (this.DiscountMark != null &&
                    this.DiscountMark.Equals(input.DiscountMark))
                ) && 
                (
                    this.SerialNumber == input.SerialNumber ||
                    (this.SerialNumber != null &&
                    this.SerialNumber.Equals(input.SerialNumber))
                ) && 
                (
                    this.TaxAmount == input.TaxAmount ||
                    (this.TaxAmount != null &&
                    this.TaxAmount.Equals(input.TaxAmount))
                ) && 
                (
                    this.TaxRate == input.TaxRate ||
                    (this.TaxRate != null &&
                    this.TaxRate.Equals(input.TaxRate))
                ) && 
                (
                    this.AirConditioning == input.AirConditioning ||
                    (this.AirConditioning != null &&
                    this.AirConditioning.Equals(input.AirConditioning))
                ) && 
                (
                    this.OriginalInvoiceNumber == input.OriginalInvoiceNumber ||
                    (this.OriginalInvoiceNumber != null &&
                    this.OriginalInvoiceNumber.Equals(input.OriginalInvoiceNumber))
                ) && 
                (
                    this.UnifiedSocialCreditCode == input.UnifiedSocialCreditCode ||
                    (this.UnifiedSocialCreditCode != null &&
                    this.UnifiedSocialCreditCode.Equals(input.UnifiedSocialCreditCode))
                ) && 
                (
                    this.BuyerName == input.BuyerName ||
                    (this.BuyerName != null &&
                    this.BuyerName.Equals(input.BuyerName))
                ) && 
                (
                    this.TotalAmountExcludingTax == input.TotalAmountExcludingTax ||
                    (this.TotalAmountExcludingTax != null &&
                    this.TotalAmountExcludingTax.Equals(input.TotalAmountExcludingTax))
                ) && 
                (
                    this.InvoiceNumber == input.InvoiceNumber ||
                    (this.InvoiceNumber != null &&
                    this.InvoiceNumber.Equals(input.InvoiceNumber))
                ) && 
                (
                    this.SealMark == input.SealMark ||
                    (this.SealMark != null &&
                    this.SealMark.Equals(input.SealMark))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Area == input.Area ||
                    (this.Area != null &&
                    this.Area.Equals(input.Area))
                ) && 
                (
                    this.ReceiptNumber == input.ReceiptNumber ||
                    (this.ReceiptNumber != null &&
                    this.ReceiptNumber.Equals(input.ReceiptNumber))
                ) && 
                (
                    this.AmountInFigures == input.AmountInFigures ||
                    (this.AmountInFigures != null &&
                    this.AmountInFigures.Equals(input.AmountInFigures))
                ) && 
                (
                    this.AmountInWords == input.AmountInWords ||
                    (this.AmountInWords != null &&
                    this.AmountInWords.Equals(input.AmountInWords))
                ) && 
                (
                    this.Confidence == input.Confidence ||
                    (this.Confidence != null &&
                    this.Confidence.Equals(input.Confidence))
                ) && 
                (
                    this.TextLocation == input.TextLocation ||
                    (this.TextLocation != null &&
                    this.TextLocation.Equals(input.TextLocation))
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
                if (this.TicketId != null)
                    hashCode = hashCode * 59 + this.TicketId.GetHashCode();
                if (this.CheckPort != null)
                    hashCode = hashCode * 59 + this.CheckPort.GetHashCode();
                if (this.TrainNumber != null)
                    hashCode = hashCode * 59 + this.TrainNumber.GetHashCode();
                if (this.DepartureStation != null)
                    hashCode = hashCode * 59 + this.DepartureStation.GetHashCode();
                if (this.DestinationStation != null)
                    hashCode = hashCode * 59 + this.DestinationStation.GetHashCode();
                if (this.DepartureStationEn != null)
                    hashCode = hashCode * 59 + this.DepartureStationEn.GetHashCode();
                if (this.DestinationStationEn != null)
                    hashCode = hashCode * 59 + this.DestinationStationEn.GetHashCode();
                if (this.DepartureTime != null)
                    hashCode = hashCode * 59 + this.DepartureTime.GetHashCode();
                if (this.SeatNumber != null)
                    hashCode = hashCode * 59 + this.SeatNumber.GetHashCode();
                if (this.TicketPrice != null)
                    hashCode = hashCode * 59 + this.TicketPrice.GetHashCode();
                if (this.SaleMethod != null)
                    hashCode = hashCode * 59 + this.SaleMethod.GetHashCode();
                if (this.SeatCategory != null)
                    hashCode = hashCode * 59 + this.SeatCategory.GetHashCode();
                if (this.TicketChanging != null)
                    hashCode = hashCode * 59 + this.TicketChanging.GetHashCode();
                if (this.IdNumber != null)
                    hashCode = hashCode * 59 + this.IdNumber.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.LogId != null)
                    hashCode = hashCode * 59 + this.LogId.GetHashCode();
                if (this.SaleLocation != null)
                    hashCode = hashCode * 59 + this.SaleLocation.GetHashCode();
                if (this.InvoiceStyle != null)
                    hashCode = hashCode * 59 + this.InvoiceStyle.GetHashCode();
                if (this.IssueDate != null)
                    hashCode = hashCode * 59 + this.IssueDate.GetHashCode();
                if (this.DiscountMark != null)
                    hashCode = hashCode * 59 + this.DiscountMark.GetHashCode();
                if (this.SerialNumber != null)
                    hashCode = hashCode * 59 + this.SerialNumber.GetHashCode();
                if (this.TaxAmount != null)
                    hashCode = hashCode * 59 + this.TaxAmount.GetHashCode();
                if (this.TaxRate != null)
                    hashCode = hashCode * 59 + this.TaxRate.GetHashCode();
                if (this.AirConditioning != null)
                    hashCode = hashCode * 59 + this.AirConditioning.GetHashCode();
                if (this.OriginalInvoiceNumber != null)
                    hashCode = hashCode * 59 + this.OriginalInvoiceNumber.GetHashCode();
                if (this.UnifiedSocialCreditCode != null)
                    hashCode = hashCode * 59 + this.UnifiedSocialCreditCode.GetHashCode();
                if (this.BuyerName != null)
                    hashCode = hashCode * 59 + this.BuyerName.GetHashCode();
                if (this.TotalAmountExcludingTax != null)
                    hashCode = hashCode * 59 + this.TotalAmountExcludingTax.GetHashCode();
                if (this.InvoiceNumber != null)
                    hashCode = hashCode * 59 + this.InvoiceNumber.GetHashCode();
                if (this.SealMark != null)
                    hashCode = hashCode * 59 + this.SealMark.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Area != null)
                    hashCode = hashCode * 59 + this.Area.GetHashCode();
                if (this.ReceiptNumber != null)
                    hashCode = hashCode * 59 + this.ReceiptNumber.GetHashCode();
                if (this.AmountInFigures != null)
                    hashCode = hashCode * 59 + this.AmountInFigures.GetHashCode();
                if (this.AmountInWords != null)
                    hashCode = hashCode * 59 + this.AmountInWords.GetHashCode();
                if (this.Confidence != null)
                    hashCode = hashCode * 59 + this.Confidence.GetHashCode();
                if (this.TextLocation != null)
                    hashCode = hashCode * 59 + this.TextLocation.GetHashCode();
                return hashCode;
            }
        }
    }
}
