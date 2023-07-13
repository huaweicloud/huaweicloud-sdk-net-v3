using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ComputeFlavor 
    {

        /// <summary>
        /// cpu核数。
        /// </summary>
        [JsonProperty("vcpus", NullValueHandling = NullValueHandling.Ignore)]
        public string Vcpus { get; set; }

        /// <summary>
        /// 内存大小，单位为GB。
        /// </summary>
        [JsonProperty("ram", NullValueHandling = NullValueHandling.Ignore)]
        public string Ram { get; set; }

        /// <summary>
        /// 规格码。
        /// </summary>
        [JsonProperty("spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SpecCode { get; set; }

        /// <summary>
        /// 可用区状态。
        /// </summary>
        [JsonProperty("az_status", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> AzStatus { get; set; }

        /// <summary>
        /// Region状态。
        /// </summary>
        [JsonProperty("region_status", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ComputeFlavor {\n");
            sb.Append("  vcpus: ").Append(Vcpus).Append("\n");
            sb.Append("  ram: ").Append(Ram).Append("\n");
            sb.Append("  specCode: ").Append(SpecCode).Append("\n");
            sb.Append("  azStatus: ").Append(AzStatus).Append("\n");
            sb.Append("  regionStatus: ").Append(RegionStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ComputeFlavor);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ComputeFlavor input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Vcpus == input.Vcpus ||
                    (this.Vcpus != null &&
                    this.Vcpus.Equals(input.Vcpus))
                ) && 
                (
                    this.Ram == input.Ram ||
                    (this.Ram != null &&
                    this.Ram.Equals(input.Ram))
                ) && 
                (
                    this.SpecCode == input.SpecCode ||
                    (this.SpecCode != null &&
                    this.SpecCode.Equals(input.SpecCode))
                ) && 
                (
                    this.AzStatus == input.AzStatus ||
                    this.AzStatus != null &&
                    input.AzStatus != null &&
                    this.AzStatus.SequenceEqual(input.AzStatus)
                ) && 
                (
                    this.RegionStatus == input.RegionStatus ||
                    (this.RegionStatus != null &&
                    this.RegionStatus.Equals(input.RegionStatus))
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
                if (this.Vcpus != null)
                    hashCode = hashCode * 59 + this.Vcpus.GetHashCode();
                if (this.Ram != null)
                    hashCode = hashCode * 59 + this.Ram.GetHashCode();
                if (this.SpecCode != null)
                    hashCode = hashCode * 59 + this.SpecCode.GetHashCode();
                if (this.AzStatus != null)
                    hashCode = hashCode * 59 + this.AzStatus.GetHashCode();
                if (this.RegionStatus != null)
                    hashCode = hashCode * 59 + this.RegionStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
