using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// hypervisor信息。
    /// </summary>
    public class Hypervisor 
    {

        /// <summary>
        /// hypervisor类型
        /// </summary>
        [JsonProperty("hypervisor_type", NullValueHandling = NullValueHandling.Ignore)]
        public string HypervisorType { get; set; }

        /// <summary>
        /// hypervisor csd信息
        /// </summary>
        [JsonProperty("csd_hypervisor", NullValueHandling = NullValueHandling.Ignore)]
        public string CsdHypervisor { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Hypervisor {\n");
            sb.Append("  hypervisorType: ").Append(HypervisorType).Append("\n");
            sb.Append("  csdHypervisor: ").Append(CsdHypervisor).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Hypervisor);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Hypervisor input)
        {
            if (input == null) return false;
            if (this.HypervisorType != input.HypervisorType || (this.HypervisorType != null && !this.HypervisorType.Equals(input.HypervisorType))) return false;
            if (this.CsdHypervisor != input.CsdHypervisor || (this.CsdHypervisor != null && !this.CsdHypervisor.Equals(input.CsdHypervisor))) return false;

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
                if (this.HypervisorType != null) hashCode = hashCode * 59 + this.HypervisorType.GetHashCode();
                if (this.CsdHypervisor != null) hashCode = hashCode * 59 + this.CsdHypervisor.GetHashCode();
                return hashCode;
            }
        }
    }
}
