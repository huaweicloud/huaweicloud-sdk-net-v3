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
    public class BelongItemList 
    {

        /// <summary>
        /// 货物或应税劳务、服务名称。 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 序号。 
        /// </summary>
        [JsonProperty("item_number", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemNumber { get; set; }

        /// <summary>
        /// 规格型号。 
        /// </summary>
        [JsonProperty("specification", NullValueHandling = NullValueHandling.Ignore)]
        public string Specification { get; set; }

        /// <summary>
        /// 单位。 
        /// </summary>
        [JsonProperty("unit", NullValueHandling = NullValueHandling.Ignore)]
        public string Unit { get; set; }

        /// <summary>
        /// 数量。 
        /// </summary>
        [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
        public string Quantity { get; set; }

        /// <summary>
        /// 单价。 
        /// </summary>
        [JsonProperty("unit_price", NullValueHandling = NullValueHandling.Ignore)]
        public string UnitPrice { get; set; }

        /// <summary>
        /// 金额。 
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Amount { get; set; }

        /// <summary>
        /// 税率。 
        /// </summary>
        [JsonProperty("tax_rate", NullValueHandling = NullValueHandling.Ignore)]
        public string TaxRate { get; set; }

        /// <summary>
        /// 税额。 
        /// </summary>
        [JsonProperty("tax", NullValueHandling = NullValueHandling.Ignore)]
        public string Tax { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BelongItemList {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  itemNumber: ").Append(ItemNumber).Append("\n");
            sb.Append("  specification: ").Append(Specification).Append("\n");
            sb.Append("  unit: ").Append(Unit).Append("\n");
            sb.Append("  quantity: ").Append(Quantity).Append("\n");
            sb.Append("  unitPrice: ").Append(UnitPrice).Append("\n");
            sb.Append("  amount: ").Append(Amount).Append("\n");
            sb.Append("  taxRate: ").Append(TaxRate).Append("\n");
            sb.Append("  tax: ").Append(Tax).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BelongItemList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BelongItemList input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ItemNumber == input.ItemNumber ||
                    (this.ItemNumber != null &&
                    this.ItemNumber.Equals(input.ItemNumber))
                ) && 
                (
                    this.Specification == input.Specification ||
                    (this.Specification != null &&
                    this.Specification.Equals(input.Specification))
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.UnitPrice == input.UnitPrice ||
                    (this.UnitPrice != null &&
                    this.UnitPrice.Equals(input.UnitPrice))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.TaxRate == input.TaxRate ||
                    (this.TaxRate != null &&
                    this.TaxRate.Equals(input.TaxRate))
                ) && 
                (
                    this.Tax == input.Tax ||
                    (this.Tax != null &&
                    this.Tax.Equals(input.Tax))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ItemNumber != null)
                    hashCode = hashCode * 59 + this.ItemNumber.GetHashCode();
                if (this.Specification != null)
                    hashCode = hashCode * 59 + this.Specification.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.UnitPrice != null)
                    hashCode = hashCode * 59 + this.UnitPrice.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.TaxRate != null)
                    hashCode = hashCode * 59 + this.TaxRate.GetHashCode();
                if (this.Tax != null)
                    hashCode = hashCode * 59 + this.Tax.GetHashCode();
                return hashCode;
            }
        }
    }
}
