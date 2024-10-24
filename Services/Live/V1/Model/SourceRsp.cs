using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// RTMP推流地址。只有频道入流协议为RTMP_PUSH时，会返回RTMP推流地址
    /// </summary>
    public class SourceRsp 
    {

        /// <summary>
        /// RTMP推流地址
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// 码率。  单位：bps。取值范围：(0,104,857,600]（100Mbps）
        /// </summary>
        [JsonProperty("bitrate", NullValueHandling = NullValueHandling.Ignore)]
        public int? Bitrate { get; set; }

        /// <summary>
        /// 分辨率对应宽的值。取值范围：0 - 4096（4K）
        /// </summary>
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public int? Width { get; set; }

        /// <summary>
        /// 分辨率对应高的值。取值范围：0 - 2160（4K）
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public int? Height { get; set; }

        /// <summary>
        /// 描述是否使用该流做截图
        /// </summary>
        [JsonProperty("enable_snapshot", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableSnapshot { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SourceRsp {\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  bitrate: ").Append(Bitrate).Append("\n");
            sb.Append("  width: ").Append(Width).Append("\n");
            sb.Append("  height: ").Append(Height).Append("\n");
            sb.Append("  enableSnapshot: ").Append(EnableSnapshot).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SourceRsp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SourceRsp input)
        {
            if (input == null) return false;
            if (this.Url != input.Url || (this.Url != null && !this.Url.Equals(input.Url))) return false;
            if (this.Bitrate != input.Bitrate || (this.Bitrate != null && !this.Bitrate.Equals(input.Bitrate))) return false;
            if (this.Width != input.Width || (this.Width != null && !this.Width.Equals(input.Width))) return false;
            if (this.Height != input.Height || (this.Height != null && !this.Height.Equals(input.Height))) return false;
            if (this.EnableSnapshot != input.EnableSnapshot || (this.EnableSnapshot != null && !this.EnableSnapshot.Equals(input.EnableSnapshot))) return false;

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
                if (this.Url != null) hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Bitrate != null) hashCode = hashCode * 59 + this.Bitrate.GetHashCode();
                if (this.Width != null) hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.Height != null) hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.EnableSnapshot != null) hashCode = hashCode * 59 + this.EnableSnapshot.GetHashCode();
                return hashCode;
            }
        }
    }
}
