using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ComputeFlavorItemDetail 
    {

        /// <summary>
        /// **参数解释**: 规格ID。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**: 规格编码。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SpecCode { get; set; }

        /// <summary>
        /// **参数解释**: IaaS规格编码。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("iaas_code", NullValueHandling = NullValueHandling.Ignore)]
        public string IaasCode { get; set; }

        /// <summary>
        /// **参数解释**: CPU核数。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("vcpus", NullValueHandling = NullValueHandling.Ignore)]
        public string Vcpus { get; set; }

        /// <summary>
        /// **参数解释**: 内存大小，单位GB。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("ram", NullValueHandling = NullValueHandling.Ignore)]
        public string Ram { get; set; }

        /// <summary>
        /// **参数解释**: 是否支持IPv6。 **取值范围**: - true：支持 - false：不支持
        /// </summary>
        [JsonProperty("supported_ipv6", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SupportedIpv6 { get; set; }

        /// <summary>
        /// **参数解释**: 规格在各个可用区的状态。 **取值范围**: - normal：正常。 - sellout：已售罄。 - unknown：状态未知。 - unsupported：不支持。 - abandon：已废弃。
        /// </summary>
        [JsonProperty("az_status", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> AzStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ComputeFlavorItemDetail {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  specCode: ").Append(SpecCode).Append("\n");
            sb.Append("  iaasCode: ").Append(IaasCode).Append("\n");
            sb.Append("  vcpus: ").Append(Vcpus).Append("\n");
            sb.Append("  ram: ").Append(Ram).Append("\n");
            sb.Append("  supportedIpv6: ").Append(SupportedIpv6).Append("\n");
            sb.Append("  azStatus: ").Append(AzStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ComputeFlavorItemDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ComputeFlavorItemDetail input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.SpecCode != input.SpecCode || (this.SpecCode != null && !this.SpecCode.Equals(input.SpecCode))) return false;
            if (this.IaasCode != input.IaasCode || (this.IaasCode != null && !this.IaasCode.Equals(input.IaasCode))) return false;
            if (this.Vcpus != input.Vcpus || (this.Vcpus != null && !this.Vcpus.Equals(input.Vcpus))) return false;
            if (this.Ram != input.Ram || (this.Ram != null && !this.Ram.Equals(input.Ram))) return false;
            if (this.SupportedIpv6 != input.SupportedIpv6 || (this.SupportedIpv6 != null && !this.SupportedIpv6.Equals(input.SupportedIpv6))) return false;
            if (this.AzStatus != input.AzStatus || (this.AzStatus != null && input.AzStatus != null && !this.AzStatus.SequenceEqual(input.AzStatus))) return false;

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
                if (this.SpecCode != null) hashCode = hashCode * 59 + this.SpecCode.GetHashCode();
                if (this.IaasCode != null) hashCode = hashCode * 59 + this.IaasCode.GetHashCode();
                if (this.Vcpus != null) hashCode = hashCode * 59 + this.Vcpus.GetHashCode();
                if (this.Ram != null) hashCode = hashCode * 59 + this.Ram.GetHashCode();
                if (this.SupportedIpv6 != null) hashCode = hashCode * 59 + this.SupportedIpv6.GetHashCode();
                if (this.AzStatus != null) hashCode = hashCode * 59 + this.AzStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
