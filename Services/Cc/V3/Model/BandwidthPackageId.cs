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
    /// 带宽包实例ID。
    /// </summary>
    public class BandwidthPackageId 
    {

        /// <summary>
        /// 带宽包实例ID。
        /// </summary>
        [JsonProperty("bandwidth_package_id", NullValueHandling = NullValueHandling.Ignore)]
        public string _BandwidthPackageId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BandwidthPackageId {\n");
            sb.Append("  _bandwidthPackageId: ").Append(_BandwidthPackageId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BandwidthPackageId);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BandwidthPackageId input)
        {
            if (input == null) return false;
            if (this._BandwidthPackageId != input._BandwidthPackageId || (this._BandwidthPackageId != null && !this._BandwidthPackageId.Equals(input._BandwidthPackageId))) return false;

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
                if (this._BandwidthPackageId != null) hashCode = hashCode * 59 + this._BandwidthPackageId.GetHashCode();
                return hashCode;
            }
        }
    }
}
