using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// 包含删除IP黑名单的参数，目前只会指定生效范围进行删除。
    /// </summary>
    public class IpBlacklistDeleteDto 
    {

        /// <summary>
        /// 指定生效范围，1指定生效范围为EIP进行删除,2指定生效范围为NAT进行删除，1,2生效范围为EIP和NAT进行删除
        /// </summary>
        [JsonProperty("effect_scope", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> EffectScope { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IpBlacklistDeleteDto {\n");
            sb.Append("  effectScope: ").Append(EffectScope).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IpBlacklistDeleteDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IpBlacklistDeleteDto input)
        {
            if (input == null) return false;
            if (this.EffectScope != input.EffectScope || (this.EffectScope != null && input.EffectScope != null && !this.EffectScope.SequenceEqual(input.EffectScope))) return false;

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
                if (this.EffectScope != null) hashCode = hashCode * 59 + this.EffectScope.GetHashCode();
                return hashCode;
            }
        }
    }
}
