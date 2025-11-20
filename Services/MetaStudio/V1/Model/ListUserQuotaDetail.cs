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
    /// 配额信息
    /// </summary>
    public class ListUserQuotaDetail 
    {

        /// <summary>
        /// 分身数字人训练模型数量。-1表示无限制。
        /// </summary>
        [JsonProperty("modeling_count_2d_model", NullValueHandling = NullValueHandling.Ignore)]
        public int? ModelingCount2dModel { get; set; }

        /// <summary>
        /// 分身数字人flexus版训练模型数量。-1表示无限制。
        /// </summary>
        [JsonProperty("modeling_count_2d_model_flexus", NullValueHandling = NullValueHandling.Ignore)]
        public int? ModelingCount2dModelFlexus { get; set; }

        /// <summary>
        /// 分身数字人视频制作内容时间，单位分钟。-1表示无限制。
        /// </summary>
        [JsonProperty("video_time_2d_model", NullValueHandling = NullValueHandling.Ignore)]
        public float? VideoTime2dModel { get; set; }

        /// <summary>
        /// 分身数字人视频制作flexus版内容时间，单位分钟。-1表示无限制。
        /// </summary>
        [JsonProperty("video_time_flexus_2d_model", NullValueHandling = NullValueHandling.Ignore)]
        public float? VideoTimeFlexus2dModel { get; set; }

        /// <summary>
        /// 声音克隆基础版。-1表示无限制。
        /// </summary>
        [JsonProperty("voice_clone_basic", NullValueHandling = NullValueHandling.Ignore)]
        public int? VoiceCloneBasic { get; set; }

        /// <summary>
        /// 声音克隆进阶版。-1表示无限制。
        /// </summary>
        [JsonProperty("voice_clone_middle", NullValueHandling = NullValueHandling.Ignore)]
        public int? VoiceCloneMiddle { get; set; }

        /// <summary>
        /// 声音克隆高级版。-1表示无限制。
        /// </summary>
        [JsonProperty("voice_clone_advance", NullValueHandling = NullValueHandling.Ignore)]
        public int? VoiceCloneAdvance { get; set; }

        /// <summary>
        /// 声音克隆flexus版。-1表示无限制。
        /// </summary>
        [JsonProperty("voice_clone_flexus", NullValueHandling = NullValueHandling.Ignore)]
        public int? VoiceCloneFlexus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListUserQuotaDetail {\n");
            sb.Append("  modelingCount2dModel: ").Append(ModelingCount2dModel).Append("\n");
            sb.Append("  modelingCount2dModelFlexus: ").Append(ModelingCount2dModelFlexus).Append("\n");
            sb.Append("  videoTime2dModel: ").Append(VideoTime2dModel).Append("\n");
            sb.Append("  videoTimeFlexus2dModel: ").Append(VideoTimeFlexus2dModel).Append("\n");
            sb.Append("  voiceCloneBasic: ").Append(VoiceCloneBasic).Append("\n");
            sb.Append("  voiceCloneMiddle: ").Append(VoiceCloneMiddle).Append("\n");
            sb.Append("  voiceCloneAdvance: ").Append(VoiceCloneAdvance).Append("\n");
            sb.Append("  voiceCloneFlexus: ").Append(VoiceCloneFlexus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListUserQuotaDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListUserQuotaDetail input)
        {
            if (input == null) return false;
            if (this.ModelingCount2dModel != input.ModelingCount2dModel || (this.ModelingCount2dModel != null && !this.ModelingCount2dModel.Equals(input.ModelingCount2dModel))) return false;
            if (this.ModelingCount2dModelFlexus != input.ModelingCount2dModelFlexus || (this.ModelingCount2dModelFlexus != null && !this.ModelingCount2dModelFlexus.Equals(input.ModelingCount2dModelFlexus))) return false;
            if (this.VideoTime2dModel != input.VideoTime2dModel || (this.VideoTime2dModel != null && !this.VideoTime2dModel.Equals(input.VideoTime2dModel))) return false;
            if (this.VideoTimeFlexus2dModel != input.VideoTimeFlexus2dModel || (this.VideoTimeFlexus2dModel != null && !this.VideoTimeFlexus2dModel.Equals(input.VideoTimeFlexus2dModel))) return false;
            if (this.VoiceCloneBasic != input.VoiceCloneBasic || (this.VoiceCloneBasic != null && !this.VoiceCloneBasic.Equals(input.VoiceCloneBasic))) return false;
            if (this.VoiceCloneMiddle != input.VoiceCloneMiddle || (this.VoiceCloneMiddle != null && !this.VoiceCloneMiddle.Equals(input.VoiceCloneMiddle))) return false;
            if (this.VoiceCloneAdvance != input.VoiceCloneAdvance || (this.VoiceCloneAdvance != null && !this.VoiceCloneAdvance.Equals(input.VoiceCloneAdvance))) return false;
            if (this.VoiceCloneFlexus != input.VoiceCloneFlexus || (this.VoiceCloneFlexus != null && !this.VoiceCloneFlexus.Equals(input.VoiceCloneFlexus))) return false;

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
                if (this.ModelingCount2dModel != null) hashCode = hashCode * 59 + this.ModelingCount2dModel.GetHashCode();
                if (this.ModelingCount2dModelFlexus != null) hashCode = hashCode * 59 + this.ModelingCount2dModelFlexus.GetHashCode();
                if (this.VideoTime2dModel != null) hashCode = hashCode * 59 + this.VideoTime2dModel.GetHashCode();
                if (this.VideoTimeFlexus2dModel != null) hashCode = hashCode * 59 + this.VideoTimeFlexus2dModel.GetHashCode();
                if (this.VoiceCloneBasic != null) hashCode = hashCode * 59 + this.VoiceCloneBasic.GetHashCode();
                if (this.VoiceCloneMiddle != null) hashCode = hashCode * 59 + this.VoiceCloneMiddle.GetHashCode();
                if (this.VoiceCloneAdvance != null) hashCode = hashCode * 59 + this.VoiceCloneAdvance.GetHashCode();
                if (this.VoiceCloneFlexus != null) hashCode = hashCode * 59 + this.VoiceCloneFlexus.GetHashCode();
                return hashCode;
            }
        }
    }
}
