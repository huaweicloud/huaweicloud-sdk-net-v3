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
    public class TaxInfo 
    {

        /// <summary>
        /// 税种。 VATISSWHTGST
        /// </summary>
        [JsonProperty("taxClass", NullValueHandling = NullValueHandling.Ignore)]
        public string TaxClass { get; set; }

        /// <summary>
        /// 税率。
        /// </summary>
        [JsonProperty("taxRate", NullValueHandling = NullValueHandling.Ignore)]
        public string TaxRate { get; set; }

        /// <summary>
        /// 税种子类。 PISCOFINSCGSTSGSTIGSTISSWHTVAT
        /// </summary>
        [JsonProperty("subTaxClass", NullValueHandling = NullValueHandling.Ignore)]
        public string SubTaxClass { get; set; }

        /// <summary>
        /// 税金金额。 单位：美元
        /// </summary>
        [JsonProperty("taxAmount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? TaxAmount { get; set; }

        /// <summary>
        /// |参数名称：是否展示| |参数的约束及描述：是否展示。Y：展示 N：不展示|
        /// </summary>
        [JsonProperty("taxVisibleFlag", NullValueHandling = NullValueHandling.Ignore)]
        public string TaxVisibleFlag { get; set; }

        /// <summary>
        /// |参数名称：是否入账| |参数的约束及描述：是否入账。Y：入账 N：不入账|
        /// </summary>
        [JsonProperty("taxAccountingFlag", NullValueHandling = NullValueHandling.Ignore)]
        public string TaxAccountingFlag { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaxInfo {\n");
            sb.Append("  taxClass: ").Append(TaxClass).Append("\n");
            sb.Append("  taxRate: ").Append(TaxRate).Append("\n");
            sb.Append("  subTaxClass: ").Append(SubTaxClass).Append("\n");
            sb.Append("  taxAmount: ").Append(TaxAmount).Append("\n");
            sb.Append("  taxVisibleFlag: ").Append(TaxVisibleFlag).Append("\n");
            sb.Append("  taxAccountingFlag: ").Append(TaxAccountingFlag).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TaxInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TaxInfo input)
        {
            if (input == null) return false;
            if (this.TaxClass != input.TaxClass || (this.TaxClass != null && !this.TaxClass.Equals(input.TaxClass))) return false;
            if (this.TaxRate != input.TaxRate || (this.TaxRate != null && !this.TaxRate.Equals(input.TaxRate))) return false;
            if (this.SubTaxClass != input.SubTaxClass || (this.SubTaxClass != null && !this.SubTaxClass.Equals(input.SubTaxClass))) return false;
            if (this.TaxAmount != input.TaxAmount || (this.TaxAmount != null && !this.TaxAmount.Equals(input.TaxAmount))) return false;
            if (this.TaxVisibleFlag != input.TaxVisibleFlag || (this.TaxVisibleFlag != null && !this.TaxVisibleFlag.Equals(input.TaxVisibleFlag))) return false;
            if (this.TaxAccountingFlag != input.TaxAccountingFlag || (this.TaxAccountingFlag != null && !this.TaxAccountingFlag.Equals(input.TaxAccountingFlag))) return false;

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
                if (this.TaxClass != null) hashCode = hashCode * 59 + this.TaxClass.GetHashCode();
                if (this.TaxRate != null) hashCode = hashCode * 59 + this.TaxRate.GetHashCode();
                if (this.SubTaxClass != null) hashCode = hashCode * 59 + this.SubTaxClass.GetHashCode();
                if (this.TaxAmount != null) hashCode = hashCode * 59 + this.TaxAmount.GetHashCode();
                if (this.TaxVisibleFlag != null) hashCode = hashCode * 59 + this.TaxVisibleFlag.GetHashCode();
                if (this.TaxAccountingFlag != null) hashCode = hashCode * 59 + this.TaxAccountingFlag.GetHashCode();
                return hashCode;
            }
        }
    }
}
