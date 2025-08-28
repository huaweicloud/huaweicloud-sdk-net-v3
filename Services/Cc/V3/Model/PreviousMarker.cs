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
    /// 上一页的marker，为空时表示第一页。
    /// </summary>
    public class PreviousMarker 
    {

        /// <summary>
        /// 向前分页标识符。
        /// </summary>
        [JsonProperty("previous_marker", NullValueHandling = NullValueHandling.Ignore)]
        public string _PreviousMarker { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PreviousMarker {\n");
            sb.Append("  _previousMarker: ").Append(_PreviousMarker).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PreviousMarker);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PreviousMarker input)
        {
            if (input == null) return false;
            if (this._PreviousMarker != input._PreviousMarker || (this._PreviousMarker != null && !this._PreviousMarker.Equals(input._PreviousMarker))) return false;

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
                if (this._PreviousMarker != null) hashCode = hashCode * 59 + this._PreviousMarker.GetHashCode();
                return hashCode;
            }
        }
    }
}
