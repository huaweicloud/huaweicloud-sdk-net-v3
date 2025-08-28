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
    /// 城域带宽包实例。
    /// </summary>
    public class RegionBandwidthPackageSpecification 
    {

        /// <summary>
        /// RegionID。
        /// </summary>
        [JsonProperty("local_region_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LocalRegionId { get; set; }

        /// <summary>
        /// RegionID。
        /// </summary>
        [JsonProperty("remote_region_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RemoteRegionId { get; set; }

        /// <summary>
        /// 互通Region带宽包的规格ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 互通Region带宽包的规格名字。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 互通Region带宽包的规格英文名字。
        /// </summary>
        [JsonProperty("en_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EnName { get; set; }

        /// <summary>
        /// 互通Region带宽包的规格西语名字。
        /// </summary>
        [JsonProperty("es_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EsName { get; set; }

        /// <summary>
        /// 互通Region带宽包的规格葡语名字。
        /// </summary>
        [JsonProperty("pt_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PtName { get; set; }

        /// <summary>
        /// 带宽包产品规格列表。
        /// </summary>
        [JsonProperty("spec_codes", NullValueHandling = NullValueHandling.Ignore)]
        public List<SpecificationCodeInfo> SpecCodes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RegionBandwidthPackageSpecification {\n");
            sb.Append("  localRegionId: ").Append(LocalRegionId).Append("\n");
            sb.Append("  remoteRegionId: ").Append(RemoteRegionId).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  enName: ").Append(EnName).Append("\n");
            sb.Append("  esName: ").Append(EsName).Append("\n");
            sb.Append("  ptName: ").Append(PtName).Append("\n");
            sb.Append("  specCodes: ").Append(SpecCodes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RegionBandwidthPackageSpecification);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RegionBandwidthPackageSpecification input)
        {
            if (input == null) return false;
            if (this.LocalRegionId != input.LocalRegionId || (this.LocalRegionId != null && !this.LocalRegionId.Equals(input.LocalRegionId))) return false;
            if (this.RemoteRegionId != input.RemoteRegionId || (this.RemoteRegionId != null && !this.RemoteRegionId.Equals(input.RemoteRegionId))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.EnName != input.EnName || (this.EnName != null && !this.EnName.Equals(input.EnName))) return false;
            if (this.EsName != input.EsName || (this.EsName != null && !this.EsName.Equals(input.EsName))) return false;
            if (this.PtName != input.PtName || (this.PtName != null && !this.PtName.Equals(input.PtName))) return false;
            if (this.SpecCodes != input.SpecCodes || (this.SpecCodes != null && input.SpecCodes != null && !this.SpecCodes.SequenceEqual(input.SpecCodes))) return false;

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
                if (this.LocalRegionId != null) hashCode = hashCode * 59 + this.LocalRegionId.GetHashCode();
                if (this.RemoteRegionId != null) hashCode = hashCode * 59 + this.RemoteRegionId.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.EnName != null) hashCode = hashCode * 59 + this.EnName.GetHashCode();
                if (this.EsName != null) hashCode = hashCode * 59 + this.EsName.GetHashCode();
                if (this.PtName != null) hashCode = hashCode * 59 + this.PtName.GetHashCode();
                if (this.SpecCodes != null) hashCode = hashCode * 59 + this.SpecCodes.GetHashCode();
                return hashCode;
            }
        }
    }
}
