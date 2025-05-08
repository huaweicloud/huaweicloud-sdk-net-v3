using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vod.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class VideoProcess 
    {

        /// <summary>
        /// 需要单独设置时长的HLS起始分片数量。 取值范围：[0,10]，默认值为：0 与hls_init_interval配合使用，设置前面hls_init_count个HLS分片时长。为0表示不单独配置时长。 
        /// </summary>
        [JsonProperty("hls_init_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? HlsInitCount { get; set; }

        /// <summary>
        /// 表示前面hls_init_count个HLS分片的时长。 取值范围：[2,10] ，默认值为：5 hls_init_count不为0时，该字段才起作用。 
        /// </summary>
        [JsonProperty("hls_init_interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? HlsInitInterval { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VideoProcess {\n");
            sb.Append("  hlsInitCount: ").Append(HlsInitCount).Append("\n");
            sb.Append("  hlsInitInterval: ").Append(HlsInitInterval).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VideoProcess);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VideoProcess input)
        {
            if (input == null) return false;
            if (this.HlsInitCount != input.HlsInitCount || (this.HlsInitCount != null && !this.HlsInitCount.Equals(input.HlsInitCount))) return false;
            if (this.HlsInitInterval != input.HlsInitInterval || (this.HlsInitInterval != null && !this.HlsInitInterval.Equals(input.HlsInitInterval))) return false;

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
                if (this.HlsInitCount != null) hashCode = hashCode * 59 + this.HlsInitCount.GetHashCode();
                if (this.HlsInitInterval != null) hashCode = hashCode * 59 + this.HlsInitInterval.GetHashCode();
                return hashCode;
            }
        }
    }
}
