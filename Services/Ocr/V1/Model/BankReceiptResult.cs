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
    public class BankReceiptResult 
    {

        /// <summary>
        /// 银行回单数量 
        /// </summary>
        [JsonProperty("bank_receipt_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? BankReceiptCount { get; set; }

        /// <summary>
        /// 银行回单键值对提取结果。 
        /// </summary>
        [JsonProperty("bank_receipt_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<BankReceiptDict> BankReceiptList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BankReceiptResult {\n");
            sb.Append("  bankReceiptCount: ").Append(BankReceiptCount).Append("\n");
            sb.Append("  bankReceiptList: ").Append(BankReceiptList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BankReceiptResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BankReceiptResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BankReceiptCount == input.BankReceiptCount ||
                    (this.BankReceiptCount != null &&
                    this.BankReceiptCount.Equals(input.BankReceiptCount))
                ) && 
                (
                    this.BankReceiptList == input.BankReceiptList ||
                    this.BankReceiptList != null &&
                    input.BankReceiptList != null &&
                    this.BankReceiptList.SequenceEqual(input.BankReceiptList)
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
                if (this.BankReceiptCount != null)
                    hashCode = hashCode * 59 + this.BankReceiptCount.GetHashCode();
                if (this.BankReceiptList != null)
                    hashCode = hashCode * 59 + this.BankReceiptList.GetHashCode();
                return hashCode;
            }
        }
    }
}
