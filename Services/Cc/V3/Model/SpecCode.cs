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
    /// 带宽包产品规格编码。
    /// </summary>
    public class SpecCode 
    {

        /// <summary>
        /// 带宽包实例的规格编码。
        /// </summary>
        [JsonProperty("spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string _SpecCode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SpecCode {\n");
            sb.Append("  _specCode: ").Append(_SpecCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SpecCode);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SpecCode input)
        {
            if (input == null) return false;
            if (this._SpecCode != input._SpecCode || (this._SpecCode != null && !this._SpecCode.Equals(input._SpecCode))) return false;

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
                if (this._SpecCode != null) hashCode = hashCode * 59 + this._SpecCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
