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
    /// 下一页的marker，为空时表示最后一页。
    /// </summary>
    public class NextMarker 
    {

        /// <summary>
        /// 向后分页标识符。
        /// </summary>
        [JsonProperty("next_marker", NullValueHandling = NullValueHandling.Ignore)]
        public string _NextMarker { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NextMarker {\n");
            sb.Append("  _nextMarker: ").Append(_NextMarker).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NextMarker);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NextMarker input)
        {
            if (input == null) return false;
            if (this._NextMarker != input._NextMarker || (this._NextMarker != null && !this._NextMarker.Equals(input._NextMarker))) return false;

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
                if (this._NextMarker != null) hashCode = hashCode * 59 + this._NextMarker.GetHashCode();
                return hashCode;
            }
        }
    }
}
