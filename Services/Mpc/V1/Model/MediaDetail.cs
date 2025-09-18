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
    public class MediaDetail 
    {

        /// <summary>
        /// 任务名称
        /// </summary>
        [JsonProperty("features", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Features { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("origin_para", NullValueHandling = NullValueHandling.Ignore)]
        public OriginPara OriginPara { get; set; }

        /// <summary>
        /// 多路输出片源信息
        /// </summary>
        [JsonProperty("output_video_paras", NullValueHandling = NullValueHandling.Ignore)]
        public List<OutputVideoPara> OutputVideoParas { get; set; }

        /// <summary>
        /// 被替换的子索引文件 
        /// </summary>
        [JsonProperty("replace_sub_index", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ReplaceSubIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("output_thumbnail_para", NullValueHandling = NullValueHandling.Ignore)]
        public OutputThumbnailPara OutputThumbnailPara { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("output_watermark_paras", NullValueHandling = NullValueHandling.Ignore)]
        public OutputWatermarkPara OutputWatermarkParas { get; set; }

        /// <summary>
        /// 输出文件的metadata信息 
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public List<FileMetaData> Metadata { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MediaDetail {\n");
            sb.Append("  features: ").Append(Features).Append("\n");
            sb.Append("  originPara: ").Append(OriginPara).Append("\n");
            sb.Append("  outputVideoParas: ").Append(OutputVideoParas).Append("\n");
            sb.Append("  replaceSubIndex: ").Append(ReplaceSubIndex).Append("\n");
            sb.Append("  outputThumbnailPara: ").Append(OutputThumbnailPara).Append("\n");
            sb.Append("  outputWatermarkParas: ").Append(OutputWatermarkParas).Append("\n");
            sb.Append("  metadata: ").Append(Metadata).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MediaDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MediaDetail input)
        {
            if (input == null) return false;
            if (this.Features != input.Features || (this.Features != null && input.Features != null && !this.Features.SequenceEqual(input.Features))) return false;
            if (this.OriginPara != input.OriginPara || (this.OriginPara != null && !this.OriginPara.Equals(input.OriginPara))) return false;
            if (this.OutputVideoParas != input.OutputVideoParas || (this.OutputVideoParas != null && input.OutputVideoParas != null && !this.OutputVideoParas.SequenceEqual(input.OutputVideoParas))) return false;
            if (this.ReplaceSubIndex != input.ReplaceSubIndex || (this.ReplaceSubIndex != null && input.ReplaceSubIndex != null && !this.ReplaceSubIndex.SequenceEqual(input.ReplaceSubIndex))) return false;
            if (this.OutputThumbnailPara != input.OutputThumbnailPara || (this.OutputThumbnailPara != null && !this.OutputThumbnailPara.Equals(input.OutputThumbnailPara))) return false;
            if (this.OutputWatermarkParas != input.OutputWatermarkParas || (this.OutputWatermarkParas != null && !this.OutputWatermarkParas.Equals(input.OutputWatermarkParas))) return false;
            if (this.Metadata != input.Metadata || (this.Metadata != null && input.Metadata != null && !this.Metadata.SequenceEqual(input.Metadata))) return false;

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
                if (this.Features != null) hashCode = hashCode * 59 + this.Features.GetHashCode();
                if (this.OriginPara != null) hashCode = hashCode * 59 + this.OriginPara.GetHashCode();
                if (this.OutputVideoParas != null) hashCode = hashCode * 59 + this.OutputVideoParas.GetHashCode();
                if (this.ReplaceSubIndex != null) hashCode = hashCode * 59 + this.ReplaceSubIndex.GetHashCode();
                if (this.OutputThumbnailPara != null) hashCode = hashCode * 59 + this.OutputThumbnailPara.GetHashCode();
                if (this.OutputWatermarkParas != null) hashCode = hashCode * 59 + this.OutputWatermarkParas.GetHashCode();
                if (this.Metadata != null) hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                return hashCode;
            }
        }
    }
}
