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
    /// 对端 Region ID。
    /// </summary>
    public class RemoteRegionId 
    {

        /// <summary>
        /// RegionID。
        /// </summary>
        [JsonProperty("remote_region_id", NullValueHandling = NullValueHandling.Ignore)]
        public string _RemoteRegionId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RemoteRegionId {\n");
            sb.Append("  _remoteRegionId: ").Append(_RemoteRegionId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RemoteRegionId);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RemoteRegionId input)
        {
            if (input == null) return false;
            if (this._RemoteRegionId != input._RemoteRegionId || (this._RemoteRegionId != null && !this._RemoteRegionId.Equals(input._RemoteRegionId))) return false;

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
                if (this._RemoteRegionId != null) hashCode = hashCode * 59 + this._RemoteRegionId.GetHashCode();
                return hashCode;
            }
        }
    }
}
