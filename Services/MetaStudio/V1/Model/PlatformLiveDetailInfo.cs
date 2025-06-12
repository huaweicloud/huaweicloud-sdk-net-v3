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
    public class PlatformLiveDetailInfo 
    {

        /// <summary>
        /// 直播平台ID。
        /// </summary>
        [JsonProperty("platform_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PlatformId { get; set; }

        /// <summary>
        /// 直播平台。美团填写meituan
        /// </summary>
        [JsonProperty("platform", NullValueHandling = NullValueHandling.Ignore)]
        public string Platform { get; set; }

        /// <summary>
        /// 授权账号信息。 美团平台对应：opBizCode
        /// </summary>
        [JsonProperty("account", NullValueHandling = NullValueHandling.Ignore)]
        public string Account { get; set; }

        /// <summary>
        /// 直播ID。如果配置，则段落切换回调中会携带该信息。 美团对应liveId
        /// </summary>
        [JsonProperty("live_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LiveId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlatformLiveDetailInfo {\n");
            sb.Append("  platformId: ").Append(PlatformId).Append("\n");
            sb.Append("  platform: ").Append(Platform).Append("\n");
            sb.Append("  account: ").Append(Account).Append("\n");
            sb.Append("  liveId: ").Append(LiveId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PlatformLiveDetailInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PlatformLiveDetailInfo input)
        {
            if (input == null) return false;
            if (this.PlatformId != input.PlatformId || (this.PlatformId != null && !this.PlatformId.Equals(input.PlatformId))) return false;
            if (this.Platform != input.Platform || (this.Platform != null && !this.Platform.Equals(input.Platform))) return false;
            if (this.Account != input.Account || (this.Account != null && !this.Account.Equals(input.Account))) return false;
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
                if (this.Platform != null) hashCode = hashCode * 59 + this.Platform.GetHashCode();
                if (this.Account != null) hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.LiveId != null) hashCode = hashCode * 59 + this.LiveId.GetHashCode();
                return hashCode;
            }
        }
    }
}
