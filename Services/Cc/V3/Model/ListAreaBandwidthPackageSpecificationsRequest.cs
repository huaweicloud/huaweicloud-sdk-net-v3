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
    public class ListAreaBandwidthPackageSpecificationsRequest 
    {

        /// <summary>
        /// 根据本端大区ID过滤带宽包资源规格列表
        /// </summary>
        [SDKProperty("local_area_id", IsQuery = true)]
        [JsonProperty("local_area_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> LocalAreaId { get; set; }

        /// <summary>
        /// 根据对端大区ID过滤带宽包资源规格列表
        /// </summary>
        [SDKProperty("remote_area_id", IsQuery = true)]
        [JsonProperty("remote_area_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RemoteAreaId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAreaBandwidthPackageSpecificationsRequest {\n");
            sb.Append("  localAreaId: ").Append(LocalAreaId).Append("\n");
            sb.Append("  remoteAreaId: ").Append(RemoteAreaId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAreaBandwidthPackageSpecificationsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAreaBandwidthPackageSpecificationsRequest input)
        {
            if (input == null) return false;
            if (this.LocalAreaId != input.LocalAreaId || (this.LocalAreaId != null && input.LocalAreaId != null && !this.LocalAreaId.SequenceEqual(input.LocalAreaId))) return false;
            if (this.RemoteAreaId != input.RemoteAreaId || (this.RemoteAreaId != null && input.RemoteAreaId != null && !this.RemoteAreaId.SequenceEqual(input.RemoteAreaId))) return false;

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
                if (this.LocalAreaId != null) hashCode = hashCode * 59 + this.LocalAreaId.GetHashCode();
                if (this.RemoteAreaId != null) hashCode = hashCode * 59 + this.RemoteAreaId.GetHashCode();
                return hashCode;
            }
        }
    }
}
