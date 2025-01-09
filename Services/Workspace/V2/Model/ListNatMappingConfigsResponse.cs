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
    /// Response Object
    /// </summary>
    public class ListNatMappingConfigsResponse : SdkResponse
    {

        /// <summary>
        /// 站点ID。
        /// </summary>
        [JsonProperty("site_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SiteId { get; set; }

        /// <summary>
        /// 是否开启nat映射。
        /// </summary>
        [JsonProperty("nat_on", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NatOn { get; set; }

        /// <summary>
        /// vag Ip列表。
        /// </summary>
        [JsonProperty("vag_ips", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> VagIps { get; set; }

        /// <summary>
        /// NAT映射配置表。
        /// </summary>
        [JsonProperty("nat_vag_maps", NullValueHandling = NullValueHandling.Ignore)]
        public List<NatMappingConfig> NatVagMaps { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListNatMappingConfigsResponse {\n");
            sb.Append("  siteId: ").Append(SiteId).Append("\n");
            sb.Append("  natOn: ").Append(NatOn).Append("\n");
            sb.Append("  vagIps: ").Append(VagIps).Append("\n");
            sb.Append("  natVagMaps: ").Append(NatVagMaps).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListNatMappingConfigsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListNatMappingConfigsResponse input)
        {
            if (input == null) return false;
            if (this.SiteId != input.SiteId || (this.SiteId != null && !this.SiteId.Equals(input.SiteId))) return false;
            if (this.NatOn != input.NatOn || (this.NatOn != null && !this.NatOn.Equals(input.NatOn))) return false;
            if (this.VagIps != input.VagIps || (this.VagIps != null && input.VagIps != null && !this.VagIps.SequenceEqual(input.VagIps))) return false;
            if (this.NatVagMaps != input.NatVagMaps || (this.NatVagMaps != null && input.NatVagMaps != null && !this.NatVagMaps.SequenceEqual(input.NatVagMaps))) return false;

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
                if (this.SiteId != null) hashCode = hashCode * 59 + this.SiteId.GetHashCode();
                if (this.NatOn != null) hashCode = hashCode * 59 + this.NatOn.GetHashCode();
                if (this.VagIps != null) hashCode = hashCode * 59 + this.VagIps.GetHashCode();
                if (this.NatVagMaps != null) hashCode = hashCode * 59 + this.NatVagMaps.GetHashCode();
                return hashCode;
            }
        }
    }
}
