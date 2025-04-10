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
    public class ItemList 
    {

        /// <summary>
        /// 货物或应税劳务、服务名称。 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

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
        /// 车牌号码。 当\&quot;type\&quot;被识别为\&quot;toll\&quot;且\&quot;advanced_mode\&quot;设置为“true”时才返回。 
        /// </summary>
        [JsonProperty("license_plate_number", NullValueHandling = NullValueHandling.Ignore)]
        public string LicensePlateNumber { get; set; }

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
        /// 通行日期止。 当\&quot;type\&quot;被识别为\&quot;toll\&quot;且\&quot;advanced_mode\&quot;设置为“true”时才返回。 
        /// </summary>
        [JsonProperty("end_date", NullValueHandling = NullValueHandling.Ignore)]
        public string EndDate { get; set; }

        /// <summary>
        /// 通行日期起。 当\&quot;type\&quot;被识别为\&quot;toll\&quot;且\&quot;advanced_mode\&quot;设置为“true”时才返回。 
        /// </summary>
        [JsonProperty("start_date", NullValueHandling = NullValueHandling.Ignore)]
        public string StartDate { get; set; }

        /// <summary>
        /// 车辆类型。 当\&quot;type\&quot;被识别为\&quot;toll\&quot;且\&quot;advanced_mode\&quot;设置为“true”时才返回。 
        /// </summary>
        [JsonProperty("vehicle_type", NullValueHandling = NullValueHandling.Ignore)]
        public string VehicleType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemList {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  specification: ").Append(Specification).Append("\n");
            sb.Append("  unit: ").Append(Unit).Append("\n");
            sb.Append("  quantity: ").Append(Quantity).Append("\n");
            sb.Append("  unitPrice: ").Append(UnitPrice).Append("\n");
            sb.Append("  licensePlateNumber: ").Append(LicensePlateNumber).Append("\n");
            sb.Append("  amount: ").Append(Amount).Append("\n");
            sb.Append("  taxRate: ").Append(TaxRate).Append("\n");
            sb.Append("  tax: ").Append(Tax).Append("\n");
            sb.Append("  endDate: ").Append(EndDate).Append("\n");
            sb.Append("  startDate: ").Append(StartDate).Append("\n");
            sb.Append("  vehicleType: ").Append(VehicleType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ItemList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ItemList input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Specification != input.Specification || (this.Specification != null && !this.Specification.Equals(input.Specification))) return false;
            if (this.Unit != input.Unit || (this.Unit != null && !this.Unit.Equals(input.Unit))) return false;
            if (this.Quantity != input.Quantity || (this.Quantity != null && !this.Quantity.Equals(input.Quantity))) return false;
            if (this.UnitPrice != input.UnitPrice || (this.UnitPrice != null && !this.UnitPrice.Equals(input.UnitPrice))) return false;
            if (this.LicensePlateNumber != input.LicensePlateNumber || (this.LicensePlateNumber != null && !this.LicensePlateNumber.Equals(input.LicensePlateNumber))) return false;
            if (this.Amount != input.Amount || (this.Amount != null && !this.Amount.Equals(input.Amount))) return false;
            if (this.TaxRate != input.TaxRate || (this.TaxRate != null && !this.TaxRate.Equals(input.TaxRate))) return false;
            if (this.Tax != input.Tax || (this.Tax != null && !this.Tax.Equals(input.Tax))) return false;
            if (this.EndDate != input.EndDate || (this.EndDate != null && !this.EndDate.Equals(input.EndDate))) return false;
            if (this.StartDate != input.StartDate || (this.StartDate != null && !this.StartDate.Equals(input.StartDate))) return false;
            if (this.VehicleType != input.VehicleType || (this.VehicleType != null && !this.VehicleType.Equals(input.VehicleType))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Specification != null) hashCode = hashCode * 59 + this.Specification.GetHashCode();
                if (this.Unit != null) hashCode = hashCode * 59 + this.Unit.GetHashCode();
                if (this.Quantity != null) hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.UnitPrice != null) hashCode = hashCode * 59 + this.UnitPrice.GetHashCode();
                if (this.LicensePlateNumber != null) hashCode = hashCode * 59 + this.LicensePlateNumber.GetHashCode();
                if (this.Amount != null) hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.TaxRate != null) hashCode = hashCode * 59 + this.TaxRate.GetHashCode();
                if (this.Tax != null) hashCode = hashCode * 59 + this.Tax.GetHashCode();
                if (this.EndDate != null) hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.StartDate != null) hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.VehicleType != null) hashCode = hashCode * 59 + this.VehicleType.GetHashCode();
                return hashCode;
            }
        }
    }
}
