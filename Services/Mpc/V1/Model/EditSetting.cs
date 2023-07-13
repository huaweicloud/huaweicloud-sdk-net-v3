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
    public class EditSetting 
    {

        /// <summary>
        /// input指定源文件开始截取的时间，单位：秒。可以有正数或者负数，正数表示从开始往后的时间点，负数表示从结尾往前的时间点 
        /// </summary>
        [JsonProperty("timeline_start", NullValueHandling = NullValueHandling.Ignore)]
        public string TimelineStart { get; set; }

        /// <summary>
        /// input指定源文件接受截取的时间，单位：秒。可以有正数或者负数，正数表示从开始往后的时间点，负数表示从结尾往前的时间点。 
        /// </summary>
        [JsonProperty("timeline_end", NullValueHandling = NullValueHandling.Ignore)]
        public string TimelineEnd { get; set; }

        /// <summary>
        /// 转码模板id
        /// </summary>
        [JsonProperty("trans_template_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? TransTemplateId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("av_parameter", NullValueHandling = NullValueHandling.Ignore)]
        public AvParameters AvParameter { get; set; }

        /// <summary>
        /// 马赛克（模糊处理）配置，会对input指定的源文件进行马赛克处理，马赛克基于视频左上角为参考位置 
        /// </summary>
        [JsonProperty("mosaics", NullValueHandling = NullValueHandling.Ignore)]
        public List<MosaicInfo> Mosaics { get; set; }

        /// <summary>
        /// 图片水印配置，会对input指定的源文件进行马赛克处理。水印设置参数里面的overlay_input字段不填 
        /// </summary>
        [JsonProperty("image_watermarks", NullValueHandling = NullValueHandling.Ignore)]
        public List<ImageWatermarkSetting> ImageWatermarks { get; set; }

        /// <summary>
        /// 头部文件列表，需要指定文件名。列表内文件会按照顺序拼接在input指定文件的前面 
        /// </summary>
        [JsonProperty("heads", NullValueHandling = NullValueHandling.Ignore)]
        public List<ObsObjInfo> Heads { get; set; }

        /// <summary>
        /// 尾部文件列表，需要指定文件名。列表内文件会按照顺序拼接在input指定文件的后面 
        /// </summary>
        [JsonProperty("tails", NullValueHandling = NullValueHandling.Ignore)]
        public List<ObsObjInfo> Tails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("output", NullValueHandling = NullValueHandling.Ignore)]
        public ObsObjInfo Output { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EditSetting {\n");
            sb.Append("  timelineStart: ").Append(TimelineStart).Append("\n");
            sb.Append("  timelineEnd: ").Append(TimelineEnd).Append("\n");
            sb.Append("  transTemplateId: ").Append(TransTemplateId).Append("\n");
            sb.Append("  avParameter: ").Append(AvParameter).Append("\n");
            sb.Append("  mosaics: ").Append(Mosaics).Append("\n");
            sb.Append("  imageWatermarks: ").Append(ImageWatermarks).Append("\n");
            sb.Append("  heads: ").Append(Heads).Append("\n");
            sb.Append("  tails: ").Append(Tails).Append("\n");
            sb.Append("  output: ").Append(Output).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EditSetting);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EditSetting input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TimelineStart == input.TimelineStart ||
                    (this.TimelineStart != null &&
                    this.TimelineStart.Equals(input.TimelineStart))
                ) && 
                (
                    this.TimelineEnd == input.TimelineEnd ||
                    (this.TimelineEnd != null &&
                    this.TimelineEnd.Equals(input.TimelineEnd))
                ) && 
                (
                    this.TransTemplateId == input.TransTemplateId ||
                    (this.TransTemplateId != null &&
                    this.TransTemplateId.Equals(input.TransTemplateId))
                ) && 
                (
                    this.AvParameter == input.AvParameter ||
                    (this.AvParameter != null &&
                    this.AvParameter.Equals(input.AvParameter))
                ) && 
                (
                    this.Mosaics == input.Mosaics ||
                    this.Mosaics != null &&
                    input.Mosaics != null &&
                    this.Mosaics.SequenceEqual(input.Mosaics)
                ) && 
                (
                    this.ImageWatermarks == input.ImageWatermarks ||
                    this.ImageWatermarks != null &&
                    input.ImageWatermarks != null &&
                    this.ImageWatermarks.SequenceEqual(input.ImageWatermarks)
                ) && 
                (
                    this.Heads == input.Heads ||
                    this.Heads != null &&
                    input.Heads != null &&
                    this.Heads.SequenceEqual(input.Heads)
                ) && 
                (
                    this.Tails == input.Tails ||
                    this.Tails != null &&
                    input.Tails != null &&
                    this.Tails.SequenceEqual(input.Tails)
                ) && 
                (
                    this.Output == input.Output ||
                    (this.Output != null &&
                    this.Output.Equals(input.Output))
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
                if (this.TimelineStart != null)
                    hashCode = hashCode * 59 + this.TimelineStart.GetHashCode();
                if (this.TimelineEnd != null)
                    hashCode = hashCode * 59 + this.TimelineEnd.GetHashCode();
                if (this.TransTemplateId != null)
                    hashCode = hashCode * 59 + this.TransTemplateId.GetHashCode();
                if (this.AvParameter != null)
                    hashCode = hashCode * 59 + this.AvParameter.GetHashCode();
                if (this.Mosaics != null)
                    hashCode = hashCode * 59 + this.Mosaics.GetHashCode();
                if (this.ImageWatermarks != null)
                    hashCode = hashCode * 59 + this.ImageWatermarks.GetHashCode();
                if (this.Heads != null)
                    hashCode = hashCode * 59 + this.Heads.GetHashCode();
                if (this.Tails != null)
                    hashCode = hashCode * 59 + this.Tails.GetHashCode();
                if (this.Output != null)
                    hashCode = hashCode * 59 + this.Output.GetHashCode();
                return hashCode;
            }
        }
    }
}
