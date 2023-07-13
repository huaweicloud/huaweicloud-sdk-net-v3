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
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MediaDetail {\n");
            sb.Append("  features: ").Append(Features).Append("\n");
            sb.Append("  originPara: ").Append(OriginPara).Append("\n");
            sb.Append("  outputVideoParas: ").Append(OutputVideoParas).Append("\n");
            sb.Append("  outputThumbnailPara: ").Append(OutputThumbnailPara).Append("\n");
            sb.Append("  outputWatermarkParas: ").Append(OutputWatermarkParas).Append("\n");
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
            if (input == null)
                return false;

            return 
                (
                    this.Features == input.Features ||
                    this.Features != null &&
                    input.Features != null &&
                    this.Features.SequenceEqual(input.Features)
                ) && 
                (
                    this.OriginPara == input.OriginPara ||
                    (this.OriginPara != null &&
                    this.OriginPara.Equals(input.OriginPara))
                ) && 
                (
                    this.OutputVideoParas == input.OutputVideoParas ||
                    this.OutputVideoParas != null &&
                    input.OutputVideoParas != null &&
                    this.OutputVideoParas.SequenceEqual(input.OutputVideoParas)
                ) && 
                (
                    this.OutputThumbnailPara == input.OutputThumbnailPara ||
                    (this.OutputThumbnailPara != null &&
                    this.OutputThumbnailPara.Equals(input.OutputThumbnailPara))
                ) && 
                (
                    this.OutputWatermarkParas == input.OutputWatermarkParas ||
                    (this.OutputWatermarkParas != null &&
                    this.OutputWatermarkParas.Equals(input.OutputWatermarkParas))
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
                if (this.Features != null)
                    hashCode = hashCode * 59 + this.Features.GetHashCode();
                if (this.OriginPara != null)
                    hashCode = hashCode * 59 + this.OriginPara.GetHashCode();
                if (this.OutputVideoParas != null)
                    hashCode = hashCode * 59 + this.OutputVideoParas.GetHashCode();
                if (this.OutputThumbnailPara != null)
                    hashCode = hashCode * 59 + this.OutputThumbnailPara.GetHashCode();
                if (this.OutputWatermarkParas != null)
                    hashCode = hashCode * 59 + this.OutputWatermarkParas.GetHashCode();
                return hashCode;
            }
        }
    }
}
