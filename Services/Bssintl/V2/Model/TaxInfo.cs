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
                return hashCode;
            }
        }
    }
}
