using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AvailabilityZoneInfo 
    {

        /// <summary>
        /// 可用分区编码。
        /// </summary>
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// 可用分区名称。
        /// </summary>
        [JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// 可用分区国际化信息。
        /// </summary>
        [JsonProperty("i18n", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> I18n { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("sold_out", NullValueHandling = NullValueHandling.Ignore)]
        public SoldOutInfo SoldOut { get; set; }

        /// <summary>
        /// 指定当前分区下自定义支持的产品ID列表，如果为空则支持所有套餐。
        /// </summary>
        [JsonProperty("product_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ProductIds { get; set; }

        /// <summary>
        /// 是否可见。
        /// </summary>
        [JsonProperty("visible", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Visible { get; set; }

        /// <summary>
        /// 是否默认可用分区。
        /// </summary>
        [JsonProperty("default_availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DefaultAvailabilityZone { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AvailabilityZoneInfo {\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  displayName: ").Append(DisplayName).Append("\n");
            sb.Append("  i18n: ").Append(I18n).Append("\n");
            sb.Append("  soldOut: ").Append(SoldOut).Append("\n");
            sb.Append("  productIds: ").Append(ProductIds).Append("\n");
            sb.Append("  visible: ").Append(Visible).Append("\n");
            sb.Append("  defaultAvailabilityZone: ").Append(DefaultAvailabilityZone).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AvailabilityZoneInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AvailabilityZoneInfo input)
        {
            if (input == null) return false;
            if (this.AvailabilityZone != input.AvailabilityZone || (this.AvailabilityZone != null && !this.AvailabilityZone.Equals(input.AvailabilityZone))) return false;
            if (this.DisplayName != input.DisplayName || (this.DisplayName != null && !this.DisplayName.Equals(input.DisplayName))) return false;
            if (this.I18n != input.I18n || (this.I18n != null && input.I18n != null && !this.I18n.SequenceEqual(input.I18n))) return false;
            if (this.SoldOut != input.SoldOut || (this.SoldOut != null && !this.SoldOut.Equals(input.SoldOut))) return false;
            if (this.ProductIds != input.ProductIds || (this.ProductIds != null && input.ProductIds != null && !this.ProductIds.SequenceEqual(input.ProductIds))) return false;
            if (this.Visible != input.Visible || (this.Visible != null && !this.Visible.Equals(input.Visible))) return false;
            if (this.DefaultAvailabilityZone != input.DefaultAvailabilityZone || (this.DefaultAvailabilityZone != null && !this.DefaultAvailabilityZone.Equals(input.DefaultAvailabilityZone))) return false;

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
                if (this.AvailabilityZone != null) hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                if (this.DisplayName != null) hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.I18n != null) hashCode = hashCode * 59 + this.I18n.GetHashCode();
                if (this.SoldOut != null) hashCode = hashCode * 59 + this.SoldOut.GetHashCode();
                if (this.ProductIds != null) hashCode = hashCode * 59 + this.ProductIds.GetHashCode();
                if (this.Visible != null) hashCode = hashCode * 59 + this.Visible.GetHashCode();
                if (this.DefaultAvailabilityZone != null) hashCode = hashCode * 59 + this.DefaultAvailabilityZone.GetHashCode();
                return hashCode;
            }
        }
    }
}
