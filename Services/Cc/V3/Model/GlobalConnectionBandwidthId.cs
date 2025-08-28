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
    /// 全域互联带宽ID。
    /// </summary>
    public class GlobalConnectionBandwidthId 
    {

        /// <summary>
        /// 全域互联带宽ID。
        /// </summary>
        [JsonProperty("global_connection_bandwidth_id", NullValueHandling = NullValueHandling.Ignore)]
        public string _GlobalConnectionBandwidthId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GlobalConnectionBandwidthId {\n");
            sb.Append("  _globalConnectionBandwidthId: ").Append(_GlobalConnectionBandwidthId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GlobalConnectionBandwidthId);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GlobalConnectionBandwidthId input)
        {
            if (input == null) return false;
            if (this._GlobalConnectionBandwidthId != input._GlobalConnectionBandwidthId || (this._GlobalConnectionBandwidthId != null && !this._GlobalConnectionBandwidthId.Equals(input._GlobalConnectionBandwidthId))) return false;

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
                if (this._GlobalConnectionBandwidthId != null) hashCode = hashCode * 59 + this._GlobalConnectionBandwidthId.GetHashCode();
                return hashCode;
            }
        }
    }
}
