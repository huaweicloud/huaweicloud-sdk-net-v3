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
    public class VatInvoiceResult 
    {

        /// <summary>
        /// 增值税发票标题 
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// 增值税发票类型，可选值包括：  - special: 增值税专用发票  - normal: 增值税普通发票  - electronic: 增值税电子普通发票  - special_electronic：增值税电子专用发票  - toll：增值税电子普通发票（通行费）  - roll：增值税普通发票（卷票） 
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 发票联次。 当“advanced_mode”设置为“true”时才返回。 
        /// </summary>
        [JsonProperty("serial_number", NullValueHandling = NullValueHandling.Ignore)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// 发票归属地。 当“advanced_mode”设置为“true”时才返回。 
        /// </summary>
        [JsonProperty("attribution", NullValueHandling = NullValueHandling.Ignore)]
        public string Attribution { get; set; }

        /// <summary>
        /// 发票监制章。 当“advanced_mode”设置为“true”时才返回。 
        /// </summary>
        [JsonProperty("supervision_seal", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SupervisionSeal { get; set; }

        /// <summary>
        /// 发票代码。 
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// 机打代码。当“advanced_mode”设置为“true”时才返回。 
        /// </summary>
        [JsonProperty("print_code", NullValueHandling = NullValueHandling.Ignore)]
        public string PrintCode { get; set; }

        /// <summary>
        /// 机器编号。 当“advanced_mode”设置为“true”时才返回。 
        /// </summary>
        [JsonProperty("machine_number", NullValueHandling = NullValueHandling.Ignore)]
        public string MachineNumber { get; set; }

        /// <summary>
        /// 机打号码。 当“advanced_mode”设置为“true”时才返回 
        /// </summary>
        [JsonProperty("print_number", NullValueHandling = NullValueHandling.Ignore)]
        public string PrintNumber { get; set; }

        /// <summary>
        /// 发票校验码，特定类型增值税发票内不存在该信息时返回空字符串。 
        /// </summary>
        [JsonProperty("check_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckCode { get; set; }

        /// <summary>
        /// 发票号码。 
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// 开票日期。 
        /// </summary>
        [JsonProperty("issue_date", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueDate { get; set; }

        /// <summary>
        /// 密码区。 
        /// </summary>
        [JsonProperty("encryption_block", NullValueHandling = NullValueHandling.Ignore)]
        public string EncryptionBlock { get; set; }

        /// <summary>
        /// 购买方名称。 
        /// </summary>
        [JsonProperty("buyer_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BuyerName { get; set; }

        /// <summary>
        /// 购买方纳税人识别号。 
        /// </summary>
        [JsonProperty("buyer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BuyerId { get; set; }

        /// <summary>
        /// 购买方地址、电话。 
        /// </summary>
        [JsonProperty("buyer_address", NullValueHandling = NullValueHandling.Ignore)]
        public string BuyerAddress { get; set; }

        /// <summary>
        /// 购买方开户行及帐号。 
        /// </summary>
        [JsonProperty("buyer_bank", NullValueHandling = NullValueHandling.Ignore)]
        public string BuyerBank { get; set; }

        /// <summary>
        /// 销售方名称。 
        /// </summary>
        [JsonProperty("seller_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SellerName { get; set; }

        /// <summary>
        /// 销售方纳税人识别号。 
        /// </summary>
        [JsonProperty("seller_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SellerId { get; set; }

        /// <summary>
        /// 销售方地址、电话。 
        /// </summary>
        [JsonProperty("seller_address", NullValueHandling = NullValueHandling.Ignore)]
        public string SellerAddress { get; set; }

        /// <summary>
        /// 销售方开户行及帐号。 
        /// </summary>
        [JsonProperty("seller_bank", NullValueHandling = NullValueHandling.Ignore)]
        public string SellerBank { get; set; }

        /// <summary>
        /// 合计金额。 
        /// </summary>
        [JsonProperty("subtotal_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string SubtotalAmount { get; set; }

        /// <summary>
        /// 合计税额。 
        /// </summary>
        [JsonProperty("subtotal_tax", NullValueHandling = NullValueHandling.Ignore)]
        public string SubtotalTax { get; set; }

        /// <summary>
        /// 价税合计。 
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public string Total { get; set; }

        /// <summary>
        /// 价税合计（大写）。 当“advanced_mode”设置为“true”时才返回。 
        /// </summary>
        [JsonProperty("total_in_words", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalInWords { get; set; }

        /// <summary>
        /// 备注。 当“advanced_mode”设置为“true”时才返回。 
        /// </summary>
        [JsonProperty("remarks", NullValueHandling = NullValueHandling.Ignore)]
        public string Remarks { get; set; }

        /// <summary>
        /// 收款人。 当“advanced_mode”设置为“true”时才返回。 
        /// </summary>
        [JsonProperty("receiver", NullValueHandling = NullValueHandling.Ignore)]
        public string Receiver { get; set; }

        /// <summary>
        /// 复核。 当“advanced_mode”设置为“true”时才返回。 
        /// </summary>
        [JsonProperty("reviewer", NullValueHandling = NullValueHandling.Ignore)]
        public string Reviewer { get; set; }

        /// <summary>
        /// 开票人。 当“advanced_mode”设置为“true”时才返回。 
        /// </summary>
        [JsonProperty("issuer", NullValueHandling = NullValueHandling.Ignore)]
        public string Issuer { get; set; }

        /// <summary>
        /// 销售方发票专用章。 当“advanced_mode”设置为“true”时才返回。 
        /// </summary>
        [JsonProperty("seller_seal", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SellerSeal { get; set; }

        /// <summary>
        /// 货物或应税劳务列表。 
        /// </summary>
        [JsonProperty("item_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ItemList> ItemList { get; set; }

        /// <summary>
        /// 各个字段的置信度。 当“advanced_mode”设置为“true”时才返回。 
        /// </summary>
        [JsonProperty("confidence", NullValueHandling = NullValueHandling.Ignore)]
        public Object Confidence { get; set; }

        /// <summary>
        /// 文本框在原图位置。输出左上、右上、右下、左下四个点坐标。当“return_text_location”设置为“true”时才返回。 
        /// </summary>
        [JsonProperty("text_location", NullValueHandling = NullValueHandling.Ignore)]
        public Object TextLocation { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VatInvoiceResult {\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  serialNumber: ").Append(SerialNumber).Append("\n");
            sb.Append("  attribution: ").Append(Attribution).Append("\n");
            sb.Append("  supervisionSeal: ").Append(SupervisionSeal).Append("\n");
            sb.Append("  code: ").Append(Code).Append("\n");
            sb.Append("  printCode: ").Append(PrintCode).Append("\n");
            sb.Append("  machineNumber: ").Append(MachineNumber).Append("\n");
            sb.Append("  printNumber: ").Append(PrintNumber).Append("\n");
            sb.Append("  checkCode: ").Append(CheckCode).Append("\n");
            sb.Append("  number: ").Append(Number).Append("\n");
            sb.Append("  issueDate: ").Append(IssueDate).Append("\n");
            sb.Append("  encryptionBlock: ").Append(EncryptionBlock).Append("\n");
            sb.Append("  buyerName: ").Append(BuyerName).Append("\n");
            sb.Append("  buyerId: ").Append(BuyerId).Append("\n");
            sb.Append("  buyerAddress: ").Append(BuyerAddress).Append("\n");
            sb.Append("  buyerBank: ").Append(BuyerBank).Append("\n");
            sb.Append("  sellerName: ").Append(SellerName).Append("\n");
            sb.Append("  sellerId: ").Append(SellerId).Append("\n");
            sb.Append("  sellerAddress: ").Append(SellerAddress).Append("\n");
            sb.Append("  sellerBank: ").Append(SellerBank).Append("\n");
            sb.Append("  subtotalAmount: ").Append(SubtotalAmount).Append("\n");
            sb.Append("  subtotalTax: ").Append(SubtotalTax).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  totalInWords: ").Append(TotalInWords).Append("\n");
            sb.Append("  remarks: ").Append(Remarks).Append("\n");
            sb.Append("  receiver: ").Append(Receiver).Append("\n");
            sb.Append("  reviewer: ").Append(Reviewer).Append("\n");
            sb.Append("  issuer: ").Append(Issuer).Append("\n");
            sb.Append("  sellerSeal: ").Append(SellerSeal).Append("\n");
            sb.Append("  itemList: ").Append(ItemList).Append("\n");
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
            return this.Equals(input as VatInvoiceResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VatInvoiceResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.SerialNumber == input.SerialNumber ||
                    (this.SerialNumber != null &&
                    this.SerialNumber.Equals(input.SerialNumber))
                ) && 
                (
                    this.Attribution == input.Attribution ||
                    (this.Attribution != null &&
                    this.Attribution.Equals(input.Attribution))
                ) && 
                (
                    this.SupervisionSeal == input.SupervisionSeal ||
                    this.SupervisionSeal != null &&
                    input.SupervisionSeal != null &&
                    this.SupervisionSeal.SequenceEqual(input.SupervisionSeal)
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.PrintCode == input.PrintCode ||
                    (this.PrintCode != null &&
                    this.PrintCode.Equals(input.PrintCode))
                ) && 
                (
                    this.MachineNumber == input.MachineNumber ||
                    (this.MachineNumber != null &&
                    this.MachineNumber.Equals(input.MachineNumber))
                ) && 
                (
                    this.PrintNumber == input.PrintNumber ||
                    (this.PrintNumber != null &&
                    this.PrintNumber.Equals(input.PrintNumber))
                ) && 
                (
                    this.CheckCode == input.CheckCode ||
                    (this.CheckCode != null &&
                    this.CheckCode.Equals(input.CheckCode))
                ) && 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.IssueDate == input.IssueDate ||
                    (this.IssueDate != null &&
                    this.IssueDate.Equals(input.IssueDate))
                ) && 
                (
                    this.EncryptionBlock == input.EncryptionBlock ||
                    (this.EncryptionBlock != null &&
                    this.EncryptionBlock.Equals(input.EncryptionBlock))
                ) && 
                (
                    this.BuyerName == input.BuyerName ||
                    (this.BuyerName != null &&
                    this.BuyerName.Equals(input.BuyerName))
                ) && 
                (
                    this.BuyerId == input.BuyerId ||
                    (this.BuyerId != null &&
                    this.BuyerId.Equals(input.BuyerId))
                ) && 
                (
                    this.BuyerAddress == input.BuyerAddress ||
                    (this.BuyerAddress != null &&
                    this.BuyerAddress.Equals(input.BuyerAddress))
                ) && 
                (
                    this.BuyerBank == input.BuyerBank ||
                    (this.BuyerBank != null &&
                    this.BuyerBank.Equals(input.BuyerBank))
                ) && 
                (
                    this.SellerName == input.SellerName ||
                    (this.SellerName != null &&
                    this.SellerName.Equals(input.SellerName))
                ) && 
                (
                    this.SellerId == input.SellerId ||
                    (this.SellerId != null &&
                    this.SellerId.Equals(input.SellerId))
                ) && 
                (
                    this.SellerAddress == input.SellerAddress ||
                    (this.SellerAddress != null &&
                    this.SellerAddress.Equals(input.SellerAddress))
                ) && 
                (
                    this.SellerBank == input.SellerBank ||
                    (this.SellerBank != null &&
                    this.SellerBank.Equals(input.SellerBank))
                ) && 
                (
                    this.SubtotalAmount == input.SubtotalAmount ||
                    (this.SubtotalAmount != null &&
                    this.SubtotalAmount.Equals(input.SubtotalAmount))
                ) && 
                (
                    this.SubtotalTax == input.SubtotalTax ||
                    (this.SubtotalTax != null &&
                    this.SubtotalTax.Equals(input.SubtotalTax))
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.TotalInWords == input.TotalInWords ||
                    (this.TotalInWords != null &&
                    this.TotalInWords.Equals(input.TotalInWords))
                ) && 
                (
                    this.Remarks == input.Remarks ||
                    (this.Remarks != null &&
                    this.Remarks.Equals(input.Remarks))
                ) && 
                (
                    this.Receiver == input.Receiver ||
                    (this.Receiver != null &&
                    this.Receiver.Equals(input.Receiver))
                ) && 
                (
                    this.Reviewer == input.Reviewer ||
                    (this.Reviewer != null &&
                    this.Reviewer.Equals(input.Reviewer))
                ) && 
                (
                    this.Issuer == input.Issuer ||
                    (this.Issuer != null &&
                    this.Issuer.Equals(input.Issuer))
                ) && 
                (
                    this.SellerSeal == input.SellerSeal ||
                    this.SellerSeal != null &&
                    input.SellerSeal != null &&
                    this.SellerSeal.SequenceEqual(input.SellerSeal)
                ) && 
                (
                    this.ItemList == input.ItemList ||
                    this.ItemList != null &&
                    input.ItemList != null &&
                    this.ItemList.SequenceEqual(input.ItemList)
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
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.SerialNumber != null)
                    hashCode = hashCode * 59 + this.SerialNumber.GetHashCode();
                if (this.Attribution != null)
                    hashCode = hashCode * 59 + this.Attribution.GetHashCode();
                if (this.SupervisionSeal != null)
                    hashCode = hashCode * 59 + this.SupervisionSeal.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.PrintCode != null)
                    hashCode = hashCode * 59 + this.PrintCode.GetHashCode();
                if (this.MachineNumber != null)
                    hashCode = hashCode * 59 + this.MachineNumber.GetHashCode();
                if (this.PrintNumber != null)
                    hashCode = hashCode * 59 + this.PrintNumber.GetHashCode();
                if (this.CheckCode != null)
                    hashCode = hashCode * 59 + this.CheckCode.GetHashCode();
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.IssueDate != null)
                    hashCode = hashCode * 59 + this.IssueDate.GetHashCode();
                if (this.EncryptionBlock != null)
                    hashCode = hashCode * 59 + this.EncryptionBlock.GetHashCode();
                if (this.BuyerName != null)
                    hashCode = hashCode * 59 + this.BuyerName.GetHashCode();
                if (this.BuyerId != null)
                    hashCode = hashCode * 59 + this.BuyerId.GetHashCode();
                if (this.BuyerAddress != null)
                    hashCode = hashCode * 59 + this.BuyerAddress.GetHashCode();
                if (this.BuyerBank != null)
                    hashCode = hashCode * 59 + this.BuyerBank.GetHashCode();
                if (this.SellerName != null)
                    hashCode = hashCode * 59 + this.SellerName.GetHashCode();
                if (this.SellerId != null)
                    hashCode = hashCode * 59 + this.SellerId.GetHashCode();
                if (this.SellerAddress != null)
                    hashCode = hashCode * 59 + this.SellerAddress.GetHashCode();
                if (this.SellerBank != null)
                    hashCode = hashCode * 59 + this.SellerBank.GetHashCode();
                if (this.SubtotalAmount != null)
                    hashCode = hashCode * 59 + this.SubtotalAmount.GetHashCode();
                if (this.SubtotalTax != null)
                    hashCode = hashCode * 59 + this.SubtotalTax.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.TotalInWords != null)
                    hashCode = hashCode * 59 + this.TotalInWords.GetHashCode();
                if (this.Remarks != null)
                    hashCode = hashCode * 59 + this.Remarks.GetHashCode();
                if (this.Receiver != null)
                    hashCode = hashCode * 59 + this.Receiver.GetHashCode();
                if (this.Reviewer != null)
                    hashCode = hashCode * 59 + this.Reviewer.GetHashCode();
                if (this.Issuer != null)
                    hashCode = hashCode * 59 + this.Issuer.GetHashCode();
                if (this.SellerSeal != null)
                    hashCode = hashCode * 59 + this.SellerSeal.GetHashCode();
                if (this.ItemList != null)
                    hashCode = hashCode * 59 + this.ItemList.GetHashCode();
                if (this.Confidence != null)
                    hashCode = hashCode * 59 + this.Confidence.GetHashCode();
                if (this.TextLocation != null)
                    hashCode = hashCode * 59 + this.TextLocation.GetHashCode();
                return hashCode;
            }
        }
    }
}
