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
    public class InvoiceVerificationRequestBody 
    {

        /// <summary>
        /// 发票代码
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// 发票日期格式YYYY-MM-DD
        /// </summary>
        [JsonProperty("issue_date", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueDate { get; set; }

        /// <summary>
        /// 校验码后六位  发票种类为增值税普通发票、增值税电子普通发票、增值税普通发票（卷式）、增值税电子普通发票（通行费）、区块链电子发票时此项不可为空（区块链电子发票验真时，填写的是5位校验码） 
        /// </summary>
        [JsonProperty("check_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckCode { get; set; }

        /// <summary>
        /// 合计金额（不含税）  1.发票种类为增值税专用发票、增值税电子专用发票、机动车销售统一发票、二手车销售统一发票、区块链电子发票时不可为空； 2.增值税专用发票、增值税电子专用发票、机动车销售统一发票、区块链电子发票填写发票合计金额（不含税），二手车发票填写发票车价合计 
        /// </summary>
        [JsonProperty("subtotal_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string SubtotalAmount { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvoiceVerificationRequestBody {\n");
            sb.Append("  code: ").Append(Code).Append("\n");
            sb.Append("  number: ").Append(Number).Append("\n");
            sb.Append("  issueDate: ").Append(IssueDate).Append("\n");
            sb.Append("  checkCode: ").Append(CheckCode).Append("\n");
            sb.Append("  subtotalAmount: ").Append(SubtotalAmount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InvoiceVerificationRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InvoiceVerificationRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
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
                    this.CheckCode == input.CheckCode ||
                    (this.CheckCode != null &&
                    this.CheckCode.Equals(input.CheckCode))
                ) && 
                (
                    this.SubtotalAmount == input.SubtotalAmount ||
                    (this.SubtotalAmount != null &&
                    this.SubtotalAmount.Equals(input.SubtotalAmount))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.IssueDate != null)
                    hashCode = hashCode * 59 + this.IssueDate.GetHashCode();
                if (this.CheckCode != null)
                    hashCode = hashCode * 59 + this.CheckCode.GetHashCode();
                if (this.SubtotalAmount != null)
                    hashCode = hashCode * 59 + this.SubtotalAmount.GetHashCode();
                return hashCode;
            }
        }
    }
}
