using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AnimationItem 
    {

        /// <summary>
        /// 动作资产ID。
        /// </summary>
        [JsonProperty("animation_asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AnimationAssetId { get; set; }

        /// <summary>
        /// 时间戳，相对时间戳。  单位秒。  保留3位小数。
        /// </summary>
        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public float? Timestamp { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnimationItem {\n");
            sb.Append("  animationAssetId: ").Append(AnimationAssetId).Append("\n");
            sb.Append("  timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AnimationItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AnimationItem input)
        {
            if (input == null) return false;
            if (this.AnimationAssetId != input.AnimationAssetId || (this.AnimationAssetId != null && !this.AnimationAssetId.Equals(input.AnimationAssetId))) return false;
            if (this.Timestamp != input.Timestamp || (this.Timestamp != null && !this.Timestamp.Equals(input.Timestamp))) return false;

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
                if (this.AnimationAssetId != null) hashCode = hashCode * 59 + this.AnimationAssetId.GetHashCode();
                if (this.Timestamp != null) hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                return hashCode;
            }
        }
    }
}
