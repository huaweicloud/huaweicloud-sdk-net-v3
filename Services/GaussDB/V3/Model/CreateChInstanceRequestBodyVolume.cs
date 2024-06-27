using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 存储规格。
    /// </summary>
    public class CreateChInstanceRequestBodyVolume 
    {

        /// <summary>
        /// 磁盘IO类型。 取值范围： - SSD：超高IO - ESSD：极速型SSD
        /// </summary>
        [JsonProperty("io_type", NullValueHandling = NullValueHandling.Ignore)]
        public string IoType { get; set; }

        /// <summary>
        /// 磁盘容量。取值范围：50GB~32000GB。
        /// </summary>
        [JsonProperty("capacity_in_gb", NullValueHandling = NullValueHandling.Ignore)]
        public int? CapacityInGb { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateChInstanceRequestBodyVolume {\n");
            sb.Append("  ioType: ").Append(IoType).Append("\n");
            sb.Append("  capacityInGb: ").Append(CapacityInGb).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateChInstanceRequestBodyVolume);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateChInstanceRequestBodyVolume input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IoType == input.IoType ||
                    (this.IoType != null &&
                    this.IoType.Equals(input.IoType))
                ) && 
                (
                    this.CapacityInGb == input.CapacityInGb ||
                    (this.CapacityInGb != null &&
                    this.CapacityInGb.Equals(input.CapacityInGb))
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
                if (this.IoType != null)
                    hashCode = hashCode * 59 + this.IoType.GetHashCode();
                if (this.CapacityInGb != null)
                    hashCode = hashCode * 59 + this.CapacityInGb.GetHashCode();
                return hashCode;
            }
        }
    }
}
