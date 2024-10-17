using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V1.Model
{
    /// <summary>
    /// 鉴权继承，为M3U8/MPD索引文件下的TS/MP4文件添加鉴权参数，解决因鉴权不通过导致的TS/MP4文件无法播放的问题。
    /// </summary>
    public class InheritConfigQuery 
    {

        /// <summary>
        /// 是否开启鉴权继承，on：开启,off：关闭。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 鉴权继承配置， m3u8：M3U8,mpd：MPD,“m3u8,mpd”。
        /// </summary>
        [JsonProperty("inherit_type", NullValueHandling = NullValueHandling.Ignore)]
        public string InheritType { get; set; }

        /// <summary>
        /// 鉴权继承的文件类型时间, sys_time：当前系统时间，parent_url_time：与m3u8和mpd访问链接保持一致。
        /// </summary>
        [JsonProperty("inherit_time_type", NullValueHandling = NullValueHandling.Ignore)]
        public string InheritTimeType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InheritConfigQuery {\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  inheritType: ").Append(InheritType).Append("\n");
            sb.Append("  inheritTimeType: ").Append(InheritTimeType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InheritConfigQuery);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InheritConfigQuery input)
        {
            if (input == null) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.InheritType != input.InheritType || (this.InheritType != null && !this.InheritType.Equals(input.InheritType))) return false;
            if (this.InheritTimeType != input.InheritTimeType || (this.InheritTimeType != null && !this.InheritTimeType.Equals(input.InheritTimeType))) return false;

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
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.InheritType != null) hashCode = hashCode * 59 + this.InheritType.GetHashCode();
                if (this.InheritTimeType != null) hashCode = hashCode * 59 + this.InheritTimeType.GetHashCode();
                return hashCode;
            }
        }
    }
}
