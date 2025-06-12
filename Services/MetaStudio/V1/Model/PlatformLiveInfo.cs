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
    /// 平台直播信息
    /// </summary>
    public class PlatformLiveInfo 
    {

        /// <summary>
        /// 直播平台ID。
        /// </summary>
        [JsonProperty("platform_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PlatformId { get; set; }

        /// <summary>
        /// 直播ID。如果配置，则段落切换回调中会携带该信息。只能包含英文、数字、-、_。 美团对应liveId
        /// </summary>
        [JsonProperty("live_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LiveId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlatformLiveInfo {\n");
            sb.Append("  platformId: ").Append(PlatformId).Append("\n");
            sb.Append("  liveId: ").Append(LiveId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PlatformLiveInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PlatformLiveInfo input)
        {
            if (input == null) return false;
            if (this.PlatformId != input.PlatformId || (this.PlatformId != null && !this.PlatformId.Equals(input.PlatformId))) return false;
            if (this.LiveId != input.LiveId || (this.LiveId != null && !this.LiveId.Equals(input.LiveId))) return false;

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
                if (this.PlatformId != null) hashCode = hashCode * 59 + this.PlatformId.GetHashCode();
                if (this.LiveId != null) hashCode = hashCode * 59 + this.LiveId.GetHashCode();
                return hashCode;
            }
        }
    }
}
