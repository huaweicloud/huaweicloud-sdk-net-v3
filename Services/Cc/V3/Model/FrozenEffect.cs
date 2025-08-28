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
    /// 冻结效果。
    /// </summary>
    public class FrozenEffect 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("frozen_effect", NullValueHandling = NullValueHandling.Ignore)]
        public FrozenEffectEnum _FrozenEffect { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FrozenEffect {\n");
            sb.Append("  _frozenEffect: ").Append(_FrozenEffect).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FrozenEffect);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FrozenEffect input)
        {
            if (input == null) return false;
            if (this._FrozenEffect != input._FrozenEffect) return false;

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
                hashCode = hashCode * 59 + this._FrozenEffect.GetHashCode();
                return hashCode;
            }
        }
    }
}
