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
    public class MultiConcatInfo 
    {

        /// <summary>
        /// 拼接任务输入源地址。
        /// </summary>
        [JsonProperty("inputs", NullValueHandling = NullValueHandling.Ignore)]
        public List<ObsObjInfo> Inputs { get; set; }

        /// <summary>
        /// 拼接完成后转码对应的转码模板ID 
        /// </summary>
        [JsonProperty("trans_template_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> TransTemplateIds { get; set; }

        /// <summary>
        /// 转码参数。 设置“trans_template_id”和此参数，则优先使用此参数进行转码。 
        /// </summary>
        [JsonProperty("av_parameters", NullValueHandling = NullValueHandling.Ignore)]
        public List<AvParameters> AvParameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("output", NullValueHandling = NullValueHandling.Ignore)]
        public ObsObjInfo Output { get; set; }

        /// <summary>
        /// 水印信息。
        /// </summary>
        [JsonProperty("image_watermark_settings", NullValueHandling = NullValueHandling.Ignore)]
        public List<ImageWatermarkSetting> ImageWatermarkSettings { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MultiConcatInfo {\n");
            sb.Append("  inputs: ").Append(Inputs).Append("\n");
            sb.Append("  transTemplateIds: ").Append(TransTemplateIds).Append("\n");
            sb.Append("  avParameters: ").Append(AvParameters).Append("\n");
            sb.Append("  output: ").Append(Output).Append("\n");
            sb.Append("  imageWatermarkSettings: ").Append(ImageWatermarkSettings).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MultiConcatInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MultiConcatInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Inputs == input.Inputs ||
                    this.Inputs != null &&
                    input.Inputs != null &&
                    this.Inputs.SequenceEqual(input.Inputs)
                ) && 
                (
                    this.TransTemplateIds == input.TransTemplateIds ||
                    this.TransTemplateIds != null &&
                    input.TransTemplateIds != null &&
                    this.TransTemplateIds.SequenceEqual(input.TransTemplateIds)
                ) && 
                (
                    this.AvParameters == input.AvParameters ||
                    this.AvParameters != null &&
                    input.AvParameters != null &&
                    this.AvParameters.SequenceEqual(input.AvParameters)
                ) && 
                (
                    this.Output == input.Output ||
                    (this.Output != null &&
                    this.Output.Equals(input.Output))
                ) && 
                (
                    this.ImageWatermarkSettings == input.ImageWatermarkSettings ||
                    this.ImageWatermarkSettings != null &&
                    input.ImageWatermarkSettings != null &&
                    this.ImageWatermarkSettings.SequenceEqual(input.ImageWatermarkSettings)
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
                if (this.Inputs != null)
                    hashCode = hashCode * 59 + this.Inputs.GetHashCode();
                if (this.TransTemplateIds != null)
                    hashCode = hashCode * 59 + this.TransTemplateIds.GetHashCode();
                if (this.AvParameters != null)
                    hashCode = hashCode * 59 + this.AvParameters.GetHashCode();
                if (this.Output != null)
                    hashCode = hashCode * 59 + this.Output.GetHashCode();
                if (this.ImageWatermarkSettings != null)
                    hashCode = hashCode * 59 + this.ImageWatermarkSettings.GetHashCode();
                return hashCode;
            }
        }
    }
}
