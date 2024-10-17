using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Mpc.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class OutputVideoPara 
    {

        /// <summary>
        /// 输出视频对应的模板ID 
        /// </summary>
        [JsonProperty("template_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? TemplateId { get; set; }

        /// <summary>
        /// 视频大小 
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public long? Size { get; set; }

        /// <summary>
        /// 视频封装格式 
        /// </summary>
        [JsonProperty("pack", NullValueHandling = NullValueHandling.Ignore)]
        public string Pack { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("video", NullValueHandling = NullValueHandling.Ignore)]
        public VideoInfo Video { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("audio", NullValueHandling = NullValueHandling.Ignore)]
        public AudioInfo Audio { get; set; }

        /// <summary>
        /// 输出片源文件名 
        /// </summary>
        [JsonProperty("file_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FileName { get; set; }

        /// <summary>
        /// 折算后视频时长 
        /// </summary>
        [JsonProperty("conver_duration", NullValueHandling = NullValueHandling.Ignore)]
        public double? ConverDuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        public XCodeError Error { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OutputVideoPara {\n");
            sb.Append("  templateId: ").Append(TemplateId).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  pack: ").Append(Pack).Append("\n");
            sb.Append("  video: ").Append(Video).Append("\n");
            sb.Append("  audio: ").Append(Audio).Append("\n");
            sb.Append("  fileName: ").Append(FileName).Append("\n");
            sb.Append("  converDuration: ").Append(ConverDuration).Append("\n");
            sb.Append("  error: ").Append(Error).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OutputVideoPara);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OutputVideoPara input)
        {
            if (input == null) return false;
            if (this.TemplateId != input.TemplateId || (this.TemplateId != null && !this.TemplateId.Equals(input.TemplateId))) return false;
            if (this.Size != input.Size || (this.Size != null && !this.Size.Equals(input.Size))) return false;
            if (this.Pack != input.Pack || (this.Pack != null && !this.Pack.Equals(input.Pack))) return false;
            if (this.Video != input.Video || (this.Video != null && !this.Video.Equals(input.Video))) return false;
            if (this.Audio != input.Audio || (this.Audio != null && !this.Audio.Equals(input.Audio))) return false;
            if (this.FileName != input.FileName || (this.FileName != null && !this.FileName.Equals(input.FileName))) return false;
            if (this.ConverDuration != input.ConverDuration || (this.ConverDuration != null && !this.ConverDuration.Equals(input.ConverDuration))) return false;
            if (this.Error != input.Error || (this.Error != null && !this.Error.Equals(input.Error))) return false;

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
                if (this.TemplateId != null) hashCode = hashCode * 59 + this.TemplateId.GetHashCode();
                if (this.Size != null) hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Pack != null) hashCode = hashCode * 59 + this.Pack.GetHashCode();
                if (this.Video != null) hashCode = hashCode * 59 + this.Video.GetHashCode();
                if (this.Audio != null) hashCode = hashCode * 59 + this.Audio.GetHashCode();
                if (this.FileName != null) hashCode = hashCode * 59 + this.FileName.GetHashCode();
                if (this.ConverDuration != null) hashCode = hashCode * 59 + this.ConverDuration.GetHashCode();
                if (this.Error != null) hashCode = hashCode * 59 + this.Error.GetHashCode();
                return hashCode;
            }
        }
    }
}
