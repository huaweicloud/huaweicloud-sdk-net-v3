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
    /// 视频拖拽配置。 &gt; 1. 需同步开启FLV、MP4格式文件的URL参数功能，并选择“忽略参数”。 &gt; 2. 关闭视频拖拽功能时，FLV时间拖拽功能失效。
    /// </summary>
    public class VideoSeek 
    {

        /// <summary>
        /// 视频拖拽开关， true：开启，false：关闭  &gt; 当本字段设置为“false”时，查询域名配置接口将不会返回视频拖拽配置信息。
        /// </summary>
        [JsonProperty("enable_video_seek", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableVideoSeek { get; set; }

        /// <summary>
        /// flv时间拖拽开关， true：开启，false：关闭。
        /// </summary>
        [JsonProperty("enable_flv_by_time_seek", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableFlvByTimeSeek { get; set; }

        /// <summary>
        /// 自定义用户请求URL中视频播放的开始参数，支持使用数字0-9、字符a-z、A-Z，及\&quot;_\&quot;，长度≤64个字符。
        /// </summary>
        [JsonProperty("start_parameter", NullValueHandling = NullValueHandling.Ignore)]
        public string StartParameter { get; set; }

        /// <summary>
        /// 自定义用户请求URL中视频播放的结束参数，支持使用数字0-9、字符a-z、A-Z，及\&quot;_\&quot;，长度≤64个字符。
        /// </summary>
        [JsonProperty("end_parameter", NullValueHandling = NullValueHandling.Ignore)]
        public string EndParameter { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VideoSeek {\n");
            sb.Append("  enableVideoSeek: ").Append(EnableVideoSeek).Append("\n");
            sb.Append("  enableFlvByTimeSeek: ").Append(EnableFlvByTimeSeek).Append("\n");
            sb.Append("  startParameter: ").Append(StartParameter).Append("\n");
            sb.Append("  endParameter: ").Append(EndParameter).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VideoSeek);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VideoSeek input)
        {
            if (input == null) return false;
            if (this.EnableVideoSeek != input.EnableVideoSeek || (this.EnableVideoSeek != null && !this.EnableVideoSeek.Equals(input.EnableVideoSeek))) return false;
            if (this.EnableFlvByTimeSeek != input.EnableFlvByTimeSeek || (this.EnableFlvByTimeSeek != null && !this.EnableFlvByTimeSeek.Equals(input.EnableFlvByTimeSeek))) return false;
            if (this.StartParameter != input.StartParameter || (this.StartParameter != null && !this.StartParameter.Equals(input.StartParameter))) return false;
            if (this.EndParameter != input.EndParameter || (this.EndParameter != null && !this.EndParameter.Equals(input.EndParameter))) return false;

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
                if (this.EnableVideoSeek != null) hashCode = hashCode * 59 + this.EnableVideoSeek.GetHashCode();
                if (this.EnableFlvByTimeSeek != null) hashCode = hashCode * 59 + this.EnableFlvByTimeSeek.GetHashCode();
                if (this.StartParameter != null) hashCode = hashCode * 59 + this.StartParameter.GetHashCode();
                if (this.EndParameter != null) hashCode = hashCode * 59 + this.EndParameter.GetHashCode();
                return hashCode;
            }
        }
    }
}
