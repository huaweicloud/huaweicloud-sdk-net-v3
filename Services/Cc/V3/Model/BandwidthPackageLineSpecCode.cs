using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cc.V3.Model
{
    /// <summary>
    /// 带宽包线路产品。
    /// </summary>
    public class BandwidthPackageLineSpecCode 
    {

        /// <summary>
        /// 带宽包等级。
        /// </summary>
        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public string Level { get; set; }

        /// <summary>
        /// 实例名称。
        /// </summary>
        [JsonProperty("name_cn", NullValueHandling = NullValueHandling.Ignore)]
        public string NameCn { get; set; }

        /// <summary>
        /// 实例名称。
        /// </summary>
        [JsonProperty("name_en", NullValueHandling = NullValueHandling.Ignore)]
        public string NameEn { get; set; }

        /// <summary>
        /// 带宽包实例的规格编码。
        /// </summary>
        [JsonProperty("spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SpecCode { get; set; }

        /// <summary>
        /// 最大带宽。
        /// </summary>
        [JsonProperty("max_bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxBandwidth { get; set; }

        /// <summary>
        /// 最小带宽。
        /// </summary>
        [JsonProperty("min_bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinBandwidth { get; set; }

        /// <summary>
        /// 支持的计费模式。
        /// </summary>
        [JsonProperty("support_billing_modes", NullValueHandling = NullValueHandling.Ignore)]
        public List<BillingModeEnum> SupportBillingModes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BandwidthPackageLineSpecCode {\n");
            sb.Append("  level: ").Append(Level).Append("\n");
            sb.Append("  nameCn: ").Append(NameCn).Append("\n");
            sb.Append("  nameEn: ").Append(NameEn).Append("\n");
            sb.Append("  specCode: ").Append(SpecCode).Append("\n");
            sb.Append("  maxBandwidth: ").Append(MaxBandwidth).Append("\n");
            sb.Append("  minBandwidth: ").Append(MinBandwidth).Append("\n");
            sb.Append("  supportBillingModes: ").Append(SupportBillingModes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BandwidthPackageLineSpecCode);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BandwidthPackageLineSpecCode input)
        {
            if (input == null) return false;
            if (this.Level != input.Level || (this.Level != null && !this.Level.Equals(input.Level))) return false;
            if (this.NameCn != input.NameCn || (this.NameCn != null && !this.NameCn.Equals(input.NameCn))) return false;
            if (this.NameEn != input.NameEn || (this.NameEn != null && !this.NameEn.Equals(input.NameEn))) return false;
            if (this.SpecCode != input.SpecCode || (this.SpecCode != null && !this.SpecCode.Equals(input.SpecCode))) return false;
            if (this.MaxBandwidth != input.MaxBandwidth || (this.MaxBandwidth != null && !this.MaxBandwidth.Equals(input.MaxBandwidth))) return false;
            if (this.MinBandwidth != input.MinBandwidth || (this.MinBandwidth != null && !this.MinBandwidth.Equals(input.MinBandwidth))) return false;
            if (this.SupportBillingModes != input.SupportBillingModes || (this.SupportBillingModes != null && input.SupportBillingModes != null && !this.SupportBillingModes.SequenceEqual(input.SupportBillingModes))) return false;

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
                if (this.Level != null) hashCode = hashCode * 59 + this.Level.GetHashCode();
                if (this.NameCn != null) hashCode = hashCode * 59 + this.NameCn.GetHashCode();
                if (this.NameEn != null) hashCode = hashCode * 59 + this.NameEn.GetHashCode();
                if (this.SpecCode != null) hashCode = hashCode * 59 + this.SpecCode.GetHashCode();
                if (this.MaxBandwidth != null) hashCode = hashCode * 59 + this.MaxBandwidth.GetHashCode();
                if (this.MinBandwidth != null) hashCode = hashCode * 59 + this.MinBandwidth.GetHashCode();
                if (this.SupportBillingModes != null) hashCode = hashCode * 59 + this.SupportBillingModes.GetHashCode();
                return hashCode;
            }
        }
    }
}
