using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DomainRegion 
    {

        /// <summary>
        /// 域名
        /// </summary>
        [JsonProperty("domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainName { get; set; }

        /// <summary>
        /// 指标统计数据列表，如果该时间段内无值，则为空数组[]
        /// </summary>
        [JsonProperty("region_isp_details", NullValueHandling = NullValueHandling.Ignore)]
        public List<Dictionary<string, Object>> RegionIspDetails { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainRegion {\n");
            sb.Append("  domainName: ").Append(DomainName).Append("\n");
            sb.Append("  regionIspDetails: ").Append(RegionIspDetails).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DomainRegion);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DomainRegion input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DomainName == input.DomainName ||
                    (this.DomainName != null &&
                    this.DomainName.Equals(input.DomainName))
                ) && 
                (
                    this.RegionIspDetails == input.RegionIspDetails ||
                    this.RegionIspDetails != null &&
                    input.RegionIspDetails != null &&
                    this.RegionIspDetails.SequenceEqual(input.RegionIspDetails)
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
                if (this.DomainName != null)
                    hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.RegionIspDetails != null)
                    hashCode = hashCode * 59 + this.RegionIspDetails.GetHashCode();
                return hashCode;
            }
        }
    }
}
