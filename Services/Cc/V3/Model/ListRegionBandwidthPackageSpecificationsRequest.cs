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
    /// Request Object
    /// </summary>
    public class ListRegionBandwidthPackageSpecificationsRequest 
    {

        /// <summary>
        /// 根据城域带宽包本端区域ID过滤租户城域带宽配置列表
        /// </summary>
        [SDKProperty("local_region_id", IsQuery = true)]
        [JsonProperty("local_region_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LocalRegionId { get; set; }

        /// <summary>
        /// 根据城域带宽包对端区域ID过滤租户城域带宽配置列表
        /// </summary>
        [SDKProperty("remote_region_id", IsQuery = true)]
        [JsonProperty("remote_region_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RemoteRegionId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRegionBandwidthPackageSpecificationsRequest {\n");
            sb.Append("  localRegionId: ").Append(LocalRegionId).Append("\n");
            sb.Append("  remoteRegionId: ").Append(RemoteRegionId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListRegionBandwidthPackageSpecificationsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListRegionBandwidthPackageSpecificationsRequest input)
        {
            if (input == null) return false;
            if (this.LocalRegionId != input.LocalRegionId || (this.LocalRegionId != null && !this.LocalRegionId.Equals(input.LocalRegionId))) return false;
            if (this.RemoteRegionId != input.RemoteRegionId || (this.RemoteRegionId != null && !this.RemoteRegionId.Equals(input.RemoteRegionId))) return false;

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
                return hashCode;
            }
        }
    }
}
