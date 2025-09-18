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
    /// 对端大区ID。
    /// </summary>
    public class RemoteAreaId 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("remote_area_id", NullValueHandling = NullValueHandling.Ignore)]
        public RemoteAreaIdDef _RemoteAreaId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RemoteAreaId {\n");
            sb.Append("  _remoteAreaId: ").Append(_RemoteAreaId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RemoteAreaId);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RemoteAreaId input)
        {
            if (input == null) return false;
            if (this._RemoteAreaId != input._RemoteAreaId) return false;

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
                hashCode = hashCode * 59 + this._RemoteAreaId.GetHashCode();
                return hashCode;
            }
        }
    }
}
