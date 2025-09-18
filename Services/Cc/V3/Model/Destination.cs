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
    /// 目的地址。
    /// </summary>
    public class Destination 
    {

        /// <summary>
        /// 目的地址。
        /// </summary>
        [JsonProperty("destination", NullValueHandling = NullValueHandling.Ignore)]
        public string _Destination { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Destination {\n");
            sb.Append("  _destination: ").Append(_Destination).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Destination);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Destination input)
        {
            if (input == null) return false;
            if (this._Destination != input._Destination || (this._Destination != null && !this._Destination.Equals(input._Destination))) return false;

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
                if (this._Destination != null) hashCode = hashCode * 59 + this._Destination.GetHashCode();
                return hashCode;
            }
        }
    }
}
