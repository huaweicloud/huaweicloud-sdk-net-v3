using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bss.V2.Model
{
    /// <summary>
    /// 站点信息
    /// </summary>
    public class SiteInfo 
    {

        /// <summary>
        /// 运营站点编码
        /// </summary>
        [JsonProperty("site_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SiteCode { get; set; }

        /// <summary>
        /// 运营站点名称
        /// </summary>
        [JsonProperty("site_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SiteName { get; set; }

        /// <summary>
        /// 云服务区信息列表
        /// </summary>
        [JsonProperty("regions", NullValueHandling = NullValueHandling.Ignore)]
        public List<RegionInfo> Regions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SiteInfo {\n");
            sb.Append("  siteCode: ").Append(SiteCode).Append("\n");
            sb.Append("  siteName: ").Append(SiteName).Append("\n");
            sb.Append("  regions: ").Append(Regions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SiteInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SiteInfo input)
        {
            if (input == null) return false;
            if (this.SiteCode != input.SiteCode || (this.SiteCode != null && !this.SiteCode.Equals(input.SiteCode))) return false;
            if (this.SiteName != input.SiteName || (this.SiteName != null && !this.SiteName.Equals(input.SiteName))) return false;
            if (this.Regions != input.Regions || (this.Regions != null && input.Regions != null && !this.Regions.SequenceEqual(input.Regions))) return false;

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
                if (this.SiteCode != null) hashCode = hashCode * 59 + this.SiteCode.GetHashCode();
                if (this.SiteName != null) hashCode = hashCode * 59 + this.SiteName.GetHashCode();
                if (this.Regions != null) hashCode = hashCode * 59 + this.Regions.GetHashCode();
                return hashCode;
            }
        }
    }
}
