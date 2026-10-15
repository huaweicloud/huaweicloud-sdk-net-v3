using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowLinkFlavorsResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("vm_flavor", NullValueHandling = NullValueHandling.Ignore)]
        public FlavorInfo VmFlavor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("volume_flavor", NullValueHandling = NullValueHandling.Ignore)]
        public FlavorInfo VolumeFlavor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("flow_flavor", NullValueHandling = NullValueHandling.Ignore)]
        public FlavorInfo FlowFlavor { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowLinkFlavorsResponse {\n");
            sb.Append("  vmFlavor: ").Append(VmFlavor).Append("\n");
            sb.Append("  volumeFlavor: ").Append(VolumeFlavor).Append("\n");
            sb.Append("  flowFlavor: ").Append(FlowFlavor).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowLinkFlavorsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowLinkFlavorsResponse input)
        {
            if (input == null) return false;
            if (this.VmFlavor != input.VmFlavor || (this.VmFlavor != null && !this.VmFlavor.Equals(input.VmFlavor))) return false;
            if (this.VolumeFlavor != input.VolumeFlavor || (this.VolumeFlavor != null && !this.VolumeFlavor.Equals(input.VolumeFlavor))) return false;
            if (this.FlowFlavor != input.FlowFlavor || (this.FlowFlavor != null && !this.FlowFlavor.Equals(input.FlowFlavor))) return false;

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
                if (this.VmFlavor != null) hashCode = hashCode * 59 + this.VmFlavor.GetHashCode();
                if (this.VolumeFlavor != null) hashCode = hashCode * 59 + this.VolumeFlavor.GetHashCode();
                if (this.FlowFlavor != null) hashCode = hashCode * 59 + this.FlowFlavor.GetHashCode();
                return hashCode;
            }
        }
    }
}
