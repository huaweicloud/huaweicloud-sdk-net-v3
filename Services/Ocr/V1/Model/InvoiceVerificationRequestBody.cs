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
        /// 发票代码。发票种类为全电发票时，该参数须为空字符串。
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
        /// 校验码后六位。 - 以下种类发票，参数不可为空    增值税普通发票、增值税电子普通发票、增值税普通发票（卷式）、增值税电子普通发票（通行费）、区块链电子发票。  - 区块链电子发票需要填写5位校验码。 
        /// </summary>
        [JsonProperty("check_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckCode { get; set; }

        /// <summary>
        /// 合计金额。和票据上的金额的有效数字保持一致，例如票据上的金额为88.00，则需要输入字符串为“88.00”，才能验真成功。如果输入“88”或“88.0”可能会产生\&quot;result_code\&quot;: \&quot;1010\&quot;, \&quot; Parameter error.\&quot;报错。  发票种类为全电发票时，该参数须为价税合计金额，其他票种使用不含税合计金额。  - 以下种类发票，参数不可为空    增值税专用发票、增值税电子专用发票、机动车销售统一发票、二手车销售统一发票、区块链电子发票、全电发票。  - 填写发票合计金额（不含税）    增值税专用发票、增值税电子专用发票、机动车销售统一发票、区块链电子发票。  - 二手车发票需要填写发票车价合计金额 
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
            if (input == null) return false;
            if (this.Code != input.Code || (this.Code != null && !this.Code.Equals(input.Code))) return false;
            if (this.Number != input.Number || (this.Number != null && !this.Number.Equals(input.Number))) return false;
            if (this.IssueDate != input.IssueDate || (this.IssueDate != null && !this.IssueDate.Equals(input.IssueDate))) return false;
            if (this.CheckCode != input.CheckCode || (this.CheckCode != null && !this.CheckCode.Equals(input.CheckCode))) return false;
            if (this.SubtotalAmount != input.SubtotalAmount || (this.SubtotalAmount != null && !this.SubtotalAmount.Equals(input.SubtotalAmount))) return false;

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
                if (this.Code != null) hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Number != null) hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.IssueDate != null) hashCode = hashCode * 59 + this.IssueDate.GetHashCode();
                if (this.CheckCode != null) hashCode = hashCode * 59 + this.CheckCode.GetHashCode();
                if (this.SubtotalAmount != null) hashCode = hashCode * 59 + this.SubtotalAmount.GetHashCode();
                return hashCode;
            }
        }
    }
}
