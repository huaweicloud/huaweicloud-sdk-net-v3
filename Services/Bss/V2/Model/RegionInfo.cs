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
    /// 云服务区信息
    /// </summary>
    public class RegionInfo 
    {

        /// <summary>
        /// 云服务区编码
        /// </summary>
        [JsonProperty("region_code", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionCode { get; set; }

        /// <summary>
        /// 云服务区名称
        /// </summary>
        [JsonProperty("region_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RegionInfo {\n");
            sb.Append("  regionCode: ").Append(RegionCode).Append("\n");
            sb.Append("  regionName: ").Append(RegionName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RegionInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RegionInfo input)
        {
            if (input == null) return false;
            if (this.RegionCode != input.RegionCode || (this.RegionCode != null && !this.RegionCode.Equals(input.RegionCode))) return false;
            if (this.RegionName != input.RegionName || (this.RegionName != null && !this.RegionName.Equals(input.RegionName))) return false;

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
                if (this.RegionCode != null) hashCode = hashCode * 59 + this.RegionCode.GetHashCode();
                if (this.RegionName != null) hashCode = hashCode * 59 + this.RegionName.GetHashCode();
                return hashCode;
            }
        }
    }
}
