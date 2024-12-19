using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Config.V1.Model
{
    /// <summary>
    /// 资源记录器冻结状态
    /// </summary>
    public class FrozenStatus 
    {

        /// <summary>
        /// 是否冻结
        /// </summary>
        [JsonProperty("is_frozen", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsFrozen { get; set; }

        /// <summary>
        /// 冻结场景
        /// </summary>
        [JsonProperty("frozen_scene", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> FrozenScene { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FrozenStatus {\n");
            sb.Append("  isFrozen: ").Append(IsFrozen).Append("\n");
            sb.Append("  frozenScene: ").Append(FrozenScene).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FrozenStatus);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FrozenStatus input)
        {
            if (input == null) return false;
            if (this.IsFrozen != input.IsFrozen || (this.IsFrozen != null && !this.IsFrozen.Equals(input.IsFrozen))) return false;
            if (this.FrozenScene != input.FrozenScene || (this.FrozenScene != null && input.FrozenScene != null && !this.FrozenScene.SequenceEqual(input.FrozenScene))) return false;

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
                if (this.IsFrozen != null) hashCode = hashCode * 59 + this.IsFrozen.GetHashCode();
                if (this.FrozenScene != null) hashCode = hashCode * 59 + this.FrozenScene.GetHashCode();
                return hashCode;
            }
        }
    }
}
