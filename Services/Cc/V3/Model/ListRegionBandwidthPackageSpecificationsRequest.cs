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
        /// 每页返回的个数。 取值范围：1~2000。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 翻页信息，从上次API调用返回的翻页数据中获取，可填写前一页marker或者后一页marker，填入前一页previous_marker就向前翻页，后一页next_marker就向后翻页。 翻页过程中，查询条件不能修改，包括过滤条件、排序条件、limit。
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 根据城域带宽包本端区域ID过滤租户城域带宽配置列表。
        /// </summary>
        [SDKProperty("local_region_id", IsQuery = true)]
        [JsonProperty("local_region_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LocalRegionId { get; set; }

        /// <summary>
        /// 根据城域带宽包对端区域ID过滤租户城域带宽配置列表。
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
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
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
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Marker != input.Marker || (this.Marker != null && !this.Marker.Equals(input.Marker))) return false;
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
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Marker != null) hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.LocalRegionId != null) hashCode = hashCode * 59 + this.LocalRegionId.GetHashCode();
                if (this.RemoteRegionId != null) hashCode = hashCode * 59 + this.RemoteRegionId.GetHashCode();
                return hashCode;
            }
        }
    }
}
