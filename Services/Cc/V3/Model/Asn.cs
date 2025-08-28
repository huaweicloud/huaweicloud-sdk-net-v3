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
    /// 网络实例BGP协议的AS号。
    /// </summary>
    public class Asn 
    {

        /// <summary>
        /// 网络实例BGP协议的AS号。
        /// </summary>
        [JsonProperty("asn", NullValueHandling = NullValueHandling.Ignore)]
        public long? _Asn { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Asn {\n");
            sb.Append("  _asn: ").Append(_Asn).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Asn);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Asn input)
        {
            if (input == null) return false;
            if (this._Asn != input._Asn || (this._Asn != null && !this._Asn.Equals(input._Asn))) return false;

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
                if (this._Asn != null) hashCode = hashCode * 59 + this._Asn.GetHashCode();
                return hashCode;
            }
        }
    }
}
