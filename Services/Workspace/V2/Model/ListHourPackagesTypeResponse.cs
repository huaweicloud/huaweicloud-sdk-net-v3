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
    public class ListHourPackagesTypeResponse : SdkResponse
    {

        /// <summary>
        /// 可订购小时包类型列表。
        /// </summary>
        [JsonProperty("hour_packages", NullValueHandling = NullValueHandling.Ignore)]
        public List<HourPackage> HourPackages { get; set; }

        /// <summary>
        /// 云桌面支持的可用分区列表总数。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListHourPackagesTypeResponse {\n");
            sb.Append("  hourPackages: ").Append(HourPackages).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListHourPackagesTypeResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListHourPackagesTypeResponse input)
        {
            if (input == null) return false;
            if (this.HourPackages != input.HourPackages || (this.HourPackages != null && input.HourPackages != null && !this.HourPackages.SequenceEqual(input.HourPackages))) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;

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
                if (this.HourPackages != null) hashCode = hashCode * 59 + this.HourPackages.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
