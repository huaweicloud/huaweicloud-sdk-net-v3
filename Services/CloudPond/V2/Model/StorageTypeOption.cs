using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CloudPond.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class StorageTypeOption 
    {

        /// <summary>
        /// 存储类型id，uuid
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 售卖存储类型
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 地区编码，表示允许在这个国家购买部署
        /// </summary>
        [JsonProperty("zone_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ZoneCode { get; set; }

        /// <summary>
        /// 步长，为0时仅可购买gears中的容量
        /// </summary>
        [JsonProperty("expand_capacity_step", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExpandCapacityStep { get; set; }

        /// <summary>
        /// 固定购买容量，为空时直接按步长购买
        /// </summary>
        [JsonProperty("supported_capacities", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> SupportedCapacities { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StorageTypeOption {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  zoneCode: ").Append(ZoneCode).Append("\n");
            sb.Append("  expandCapacityStep: ").Append(ExpandCapacityStep).Append("\n");
            sb.Append("  supportedCapacities: ").Append(SupportedCapacities).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StorageTypeOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StorageTypeOption input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ZoneCode != input.ZoneCode || (this.ZoneCode != null && !this.ZoneCode.Equals(input.ZoneCode))) return false;
            if (this.ExpandCapacityStep != input.ExpandCapacityStep || (this.ExpandCapacityStep != null && !this.ExpandCapacityStep.Equals(input.ExpandCapacityStep))) return false;
            if (this.SupportedCapacities != input.SupportedCapacities || (this.SupportedCapacities != null && input.SupportedCapacities != null && !this.SupportedCapacities.SequenceEqual(input.SupportedCapacities))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ZoneCode != null) hashCode = hashCode * 59 + this.ZoneCode.GetHashCode();
                if (this.ExpandCapacityStep != null) hashCode = hashCode * 59 + this.ExpandCapacityStep.GetHashCode();
                if (this.SupportedCapacities != null) hashCode = hashCode * 59 + this.SupportedCapacities.GetHashCode();
                return hashCode;
            }
        }
    }
}
