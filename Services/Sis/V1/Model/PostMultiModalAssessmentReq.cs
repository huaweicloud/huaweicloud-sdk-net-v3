using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Sis.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PostMultiModalAssessmentReq 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("config", NullValueHandling = NullValueHandling.Ignore)]
        public MultiModalConfig Config { get; set; }

        /// <summary>
        /// 视频数据，Base64编码，要求Base64编码后大小不超过10M。  注意评测接口使用次数定义为：每8秒的视频作为一次，不足8秒按一次计算。例如传入4秒或8秒的视频，都算作使用一次，传入9秒的视频则视为调用2次。
        /// </summary>
        [JsonProperty("video_data", NullValueHandling = NullValueHandling.Ignore)]
        public string VideoData { get; set; }

        /// <summary>
        /// 被评估视频和语音数据对应的试题文本，长度不可超过256字节。
        /// </summary>
        [JsonProperty("ref_text", NullValueHandling = NullValueHandling.Ignore)]
        public string RefText { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostMultiModalAssessmentReq {\n");
            sb.Append("  config: ").Append(Config).Append("\n");
            sb.Append("  videoData: ").Append(VideoData).Append("\n");
            sb.Append("  refText: ").Append(RefText).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PostMultiModalAssessmentReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PostMultiModalAssessmentReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Config == input.Config ||
                    (this.Config != null &&
                    this.Config.Equals(input.Config))
                ) && 
                (
                    this.VideoData == input.VideoData ||
                    (this.VideoData != null &&
                    this.VideoData.Equals(input.VideoData))
                ) && 
                (
                    this.RefText == input.RefText ||
                    (this.RefText != null &&
                    this.RefText.Equals(input.RefText))
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
                if (this.Config != null)
                    hashCode = hashCode * 59 + this.Config.GetHashCode();
                if (this.VideoData != null)
                    hashCode = hashCode * 59 + this.VideoData.GetHashCode();
                if (this.RefText != null)
                    hashCode = hashCode * 59 + this.RefText.GetHashCode();
                return hashCode;
            }
        }
    }
}
