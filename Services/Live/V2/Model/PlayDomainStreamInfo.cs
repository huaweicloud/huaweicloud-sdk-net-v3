using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PlayDomainStreamInfo 
    {

        /// <summary>
        /// 播放域名
        /// </summary>
        [JsonProperty("play_domain", NullValueHandling = NullValueHandling.Ignore)]
        public string PlayDomain { get; set; }

        /// <summary>
        /// 播放流名
        /// </summary>
        [JsonProperty("stream", NullValueHandling = NullValueHandling.Ignore)]
        public string Stream { get; set; }

        /// <summary>
        /// 播放的协议，支持flv,hls,rtmp。
        /// </summary>
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string Protocol { get; set; }

        /// <summary>
        /// 1分钟粒度的带宽值，单位为bps。
        /// </summary>
        [JsonProperty("bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public long? Bandwidth { get; set; }

        /// <summary>
        /// 1分钟粒度的在线人数。
        /// </summary>
        [JsonProperty("online", NullValueHandling = NullValueHandling.Ignore)]
        public long? Online { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlayDomainStreamInfo {\n");
            sb.Append("  playDomain: ").Append(PlayDomain).Append("\n");
            sb.Append("  stream: ").Append(Stream).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("  bandwidth: ").Append(Bandwidth).Append("\n");
            sb.Append("  online: ").Append(Online).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PlayDomainStreamInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PlayDomainStreamInfo input)
        {
            if (input == null) return false;
            if (this.PlayDomain != input.PlayDomain || (this.PlayDomain != null && !this.PlayDomain.Equals(input.PlayDomain))) return false;
            if (this.Stream != input.Stream || (this.Stream != null && !this.Stream.Equals(input.Stream))) return false;
            if (this.Protocol != input.Protocol || (this.Protocol != null && !this.Protocol.Equals(input.Protocol))) return false;
            if (this.Bandwidth != input.Bandwidth || (this.Bandwidth != null && !this.Bandwidth.Equals(input.Bandwidth))) return false;
            if (this.Online != input.Online || (this.Online != null && !this.Online.Equals(input.Online))) return false;

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
                if (this.PlayDomain != null) hashCode = hashCode * 59 + this.PlayDomain.GetHashCode();
                if (this.Stream != null) hashCode = hashCode * 59 + this.Stream.GetHashCode();
                if (this.Protocol != null) hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.Bandwidth != null) hashCode = hashCode * 59 + this.Bandwidth.GetHashCode();
                if (this.Online != null) hashCode = hashCode * 59 + this.Online.GetHashCode();
                return hashCode;
            }
        }
    }
}
