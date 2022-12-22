using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Frs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class LiveDetectBase64Req 
    {

        /// <summary>
        /// 该参数为动作时间数组拼接的字符串，数组的长度和actions的数量一致，每一项代表了对应次序动作的起始时间和结束时间，单位为距视频开始的毫秒数。
        /// </summary>
        [JsonProperty("action_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ActionTime { get; set; }

        /// <summary>
        /// 视频数据，Base64编码，要求： • Base64编码后大小不超过8MB，建议客户端压缩到200KB~2MB。 • 限制视频时长1～15秒。 • 建议帧率10fps～30fps。 • 封装格式：mp4、avi、flv、webm、asf、mov。 • 视频编码格式： h261、h263、h264、hevc、vc1、vp8、vp9、wmv3。
        /// </summary>
        [JsonProperty("video_base64", NullValueHandling = NullValueHandling.Ignore)]
        public string VideoBase64 { get; set; }

        /// <summary>
        /// 动作代码顺序列表，英文逗号（,）分隔。建议单动作，目前支持的动作有： • 1：左摇头 • 2：右摇头 • 3：点头 • 4：嘴部动作
        /// </summary>
        [JsonProperty("actions", NullValueHandling = NullValueHandling.Ignore)]
        public string Actions { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LiveDetectBase64Req {\n");
            sb.Append("  actionTime: ").Append(ActionTime).Append("\n");
            sb.Append("  videoBase64: ").Append(VideoBase64).Append("\n");
            sb.Append("  actions: ").Append(Actions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LiveDetectBase64Req);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LiveDetectBase64Req input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ActionTime == input.ActionTime ||
                    (this.ActionTime != null &&
                    this.ActionTime.Equals(input.ActionTime))
                ) && 
                (
                    this.VideoBase64 == input.VideoBase64 ||
                    (this.VideoBase64 != null &&
                    this.VideoBase64.Equals(input.VideoBase64))
                ) && 
                (
                    this.Actions == input.Actions ||
                    (this.Actions != null &&
                    this.Actions.Equals(input.Actions))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ActionTime != null)
                    hashCode = hashCode * 59 + this.ActionTime.GetHashCode();
                if (this.VideoBase64 != null)
                    hashCode = hashCode * 59 + this.VideoBase64.GetHashCode();
                if (this.Actions != null)
                    hashCode = hashCode * 59 + this.Actions.GetHashCode();
                return hashCode;
            }
        }
    }
}
