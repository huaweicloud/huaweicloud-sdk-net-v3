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
    /// 是否冻结。
    /// </summary>
    public class IsFrozen 
    {

        /// <summary>
        /// 是否冻结。
        /// </summary>
        [JsonProperty("is_frozen", NullValueHandling = NullValueHandling.Ignore)]
        public bool? _IsFrozen { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IsFrozen {\n");
            sb.Append("  _isFrozen: ").Append(_IsFrozen).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IsFrozen);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IsFrozen input)
        {
            if (input == null) return false;
            if (this._IsFrozen != input._IsFrozen || (this._IsFrozen != null && !this._IsFrozen.Equals(input._IsFrozen))) return false;

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
                if (this._IsFrozen != null) hashCode = hashCode * 59 + this._IsFrozen.GetHashCode();
                return hashCode;
            }
        }
    }
}
