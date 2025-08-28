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
    /// 带宽包线路。
    /// </summary>
    public class BandwidthPackageLine 
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
        /// 站点编码。
        /// </summary>
        [JsonProperty("local_site_code", NullValueHandling = NullValueHandling.Ignore)]
        public string LocalSiteCode { get; set; }

        /// <summary>
        /// 站点编码。
        /// </summary>
        [JsonProperty("remote_site_code", NullValueHandling = NullValueHandling.Ignore)]
        public string RemoteSiteCode { get; set; }

        /// <summary>
        /// 支持的等级列表。
        /// </summary>
        [JsonProperty("support_levels", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SupportLevels { get; set; }

        /// <summary>
        /// 产品编码列表。
        /// </summary>
        [JsonProperty("spec_codes", NullValueHandling = NullValueHandling.Ignore)]
        public List<BandwidthPackageLineSpecCode> SpecCodes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BandwidthPackageLine {\n");
            sb.Append("  localRegionId: ").Append(LocalRegionId).Append("\n");
            sb.Append("  remoteRegionId: ").Append(RemoteRegionId).Append("\n");
            sb.Append("  localSiteCode: ").Append(LocalSiteCode).Append("\n");
            sb.Append("  remoteSiteCode: ").Append(RemoteSiteCode).Append("\n");
            sb.Append("  supportLevels: ").Append(SupportLevels).Append("\n");
            sb.Append("  specCodes: ").Append(SpecCodes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BandwidthPackageLine);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BandwidthPackageLine input)
        {
            if (input == null) return false;
            if (this.LocalRegionId != input.LocalRegionId || (this.LocalRegionId != null && !this.LocalRegionId.Equals(input.LocalRegionId))) return false;
            if (this.RemoteRegionId != input.RemoteRegionId || (this.RemoteRegionId != null && !this.RemoteRegionId.Equals(input.RemoteRegionId))) return false;
            if (this.LocalSiteCode != input.LocalSiteCode || (this.LocalSiteCode != null && !this.LocalSiteCode.Equals(input.LocalSiteCode))) return false;
            if (this.RemoteSiteCode != input.RemoteSiteCode || (this.RemoteSiteCode != null && !this.RemoteSiteCode.Equals(input.RemoteSiteCode))) return false;
            if (this.SupportLevels != input.SupportLevels || (this.SupportLevels != null && input.SupportLevels != null && !this.SupportLevels.SequenceEqual(input.SupportLevels))) return false;
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
                if (this.LocalSiteCode != null) hashCode = hashCode * 59 + this.LocalSiteCode.GetHashCode();
                if (this.RemoteSiteCode != null) hashCode = hashCode * 59 + this.RemoteSiteCode.GetHashCode();
                if (this.SupportLevels != null) hashCode = hashCode * 59 + this.SupportLevels.GetHashCode();
                if (this.SpecCodes != null) hashCode = hashCode * 59 + this.SpecCodes.GetHashCode();
                return hashCode;
            }
        }
    }
}
