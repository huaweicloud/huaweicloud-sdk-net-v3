using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DomainMigrate 
    {

        /// <summary>
        /// 是否触发其他区域迁移
        /// </summary>
        [JsonProperty("all_regions", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllRegions { get; set; }

        /// <summary>
        /// 存储库默认扩容比，取值范围0到1
        /// </summary>
        [JsonProperty("reservation", NullValueHandling = NullValueHandling.Ignore)]
        public float? Reservation { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainMigrate {\n");
            sb.Append("  allRegions: ").Append(AllRegions).Append("\n");
            sb.Append("  reservation: ").Append(Reservation).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DomainMigrate);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DomainMigrate input)
        {
            if (input == null) return false;
            if (this.AllRegions != input.AllRegions || (this.AllRegions != null && !this.AllRegions.Equals(input.AllRegions))) return false;
            if (this.Reservation != input.Reservation || (this.Reservation != null && !this.Reservation.Equals(input.Reservation))) return false;

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
                if (this.AllRegions != null) hashCode = hashCode * 59 + this.AllRegions.GetHashCode();
                if (this.Reservation != null) hashCode = hashCode * 59 + this.Reservation.GetHashCode();
                return hashCode;
            }
        }
    }
}
