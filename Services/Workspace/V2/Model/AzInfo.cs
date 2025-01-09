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
    /// 可用区信息。
    /// </summary>
    public class AzInfo 
    {

        /// <summary>
        /// 可用区名称。
        /// </summary>
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("i18n", NullValueHandling = NullValueHandling.Ignore)]
        public I18n I18n { get; set; }

        /// <summary>
        /// 是否为默认可用分区。
        /// </summary>
        [JsonProperty("default_availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DefaultAvailabilityZone { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AzInfo {\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  i18n: ").Append(I18n).Append("\n");
            sb.Append("  defaultAvailabilityZone: ").Append(DefaultAvailabilityZone).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AzInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AzInfo input)
        {
            if (input == null) return false;
            if (this.AvailabilityZone != input.AvailabilityZone || (this.AvailabilityZone != null && !this.AvailabilityZone.Equals(input.AvailabilityZone))) return false;
            if (this.I18n != input.I18n || (this.I18n != null && !this.I18n.Equals(input.I18n))) return false;
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
                if (this.I18n != null) hashCode = hashCode * 59 + this.I18n.GetHashCode();
                if (this.DefaultAvailabilityZone != null) hashCode = hashCode * 59 + this.DefaultAvailabilityZone.GetHashCode();
                return hashCode;
            }
        }
    }
}
