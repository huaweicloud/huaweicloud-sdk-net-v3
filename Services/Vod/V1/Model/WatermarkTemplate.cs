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
    public class WatermarkTemplate 
    {

        /// <summary>
        /// 水印模板名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 水印模板配置id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 启用状态。  取值为： - 0：停用 - 1：启用
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public long? Status { get; set; }

        /// <summary>
        /// 水印图片相对输出视频的水平偏移量。  默认值是0。
        /// </summary>
        [JsonProperty("dx", NullValueHandling = NullValueHandling.Ignore)]
        public string Dx { get; set; }

        /// <summary>
        /// 水印图片相对输出视频的垂直偏移量。  默认值是0。
        /// </summary>
        [JsonProperty("dy", NullValueHandling = NullValueHandling.Ignore)]
        public string Dy { get; set; }

        /// <summary>
        /// 水印的位置。
        /// </summary>
        [JsonProperty("position", NullValueHandling = NullValueHandling.Ignore)]
        public string Position { get; set; }

        /// <summary>
        /// 水印图片宽。
        /// </summary>
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public string Width { get; set; }

        /// <summary>
        /// 水印图片高。
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public string Height { get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 水印图片下载url。
        /// </summary>
        [JsonProperty("image_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 水印图片格式类型。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 水印类型，当前只支持Image（图片水印）。
        /// </summary>
        [JsonProperty("watermark_type", NullValueHandling = NullValueHandling.Ignore)]
        public string WatermarkType { get; set; }

        /// <summary>
        /// type设置为Image时有效。  目前包括： - Original：只做简单缩放，不做其他处理 - Transparent：图片底色透明 - Grayed：彩色图片变灰
        /// </summary>
        [JsonProperty("image_process", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageProcess { get; set; }

        /// <summary>
        /// 水印开始时间，与\&quot;timeline_duration\&quot;配合使用。 取值范围:[0, END)。\&quot;END\&quot;表示视频结束时间。 单位:秒。 
        /// </summary>
        [JsonProperty("timeline_start", NullValueHandling = NullValueHandling.Ignore)]
        public string TimelineStart { get; set; }

        /// <summary>
        /// 水印持续时间，与\&quot;timeline_start\&quot;配合使用。 取值范围:(0,END-开始时间]。\&quot;END\&quot;表示视频结束时间。 单位:秒。 默认:END。 
        /// </summary>
        [JsonProperty("timeline_duration", NullValueHandling = NullValueHandling.Ignore)]
        public string TimelineDuration { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WatermarkTemplate {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  dx: ").Append(Dx).Append("\n");
            sb.Append("  dy: ").Append(Dy).Append("\n");
            sb.Append("  position: ").Append(Position).Append("\n");
            sb.Append("  width: ").Append(Width).Append("\n");
            sb.Append("  height: ").Append(Height).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  imageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  watermarkType: ").Append(WatermarkType).Append("\n");
            sb.Append("  imageProcess: ").Append(ImageProcess).Append("\n");
            sb.Append("  timelineStart: ").Append(TimelineStart).Append("\n");
            sb.Append("  timelineDuration: ").Append(TimelineDuration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WatermarkTemplate);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WatermarkTemplate input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Dx != input.Dx || (this.Dx != null && !this.Dx.Equals(input.Dx))) return false;
            if (this.Dy != input.Dy || (this.Dy != null && !this.Dy.Equals(input.Dy))) return false;
            if (this.Position != input.Position || (this.Position != null && !this.Position.Equals(input.Position))) return false;
            if (this.Width != input.Width || (this.Width != null && !this.Width.Equals(input.Width))) return false;
            if (this.Height != input.Height || (this.Height != null && !this.Height.Equals(input.Height))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.ImageUrl != input.ImageUrl || (this.ImageUrl != null && !this.ImageUrl.Equals(input.ImageUrl))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.WatermarkType != input.WatermarkType || (this.WatermarkType != null && !this.WatermarkType.Equals(input.WatermarkType))) return false;
            if (this.ImageProcess != input.ImageProcess || (this.ImageProcess != null && !this.ImageProcess.Equals(input.ImageProcess))) return false;
            if (this.TimelineStart != input.TimelineStart || (this.TimelineStart != null && !this.TimelineStart.Equals(input.TimelineStart))) return false;
            if (this.TimelineDuration != input.TimelineDuration || (this.TimelineDuration != null && !this.TimelineDuration.Equals(input.TimelineDuration))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Dx != null) hashCode = hashCode * 59 + this.Dx.GetHashCode();
                if (this.Dy != null) hashCode = hashCode * 59 + this.Dy.GetHashCode();
                if (this.Position != null) hashCode = hashCode * 59 + this.Position.GetHashCode();
                if (this.Width != null) hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.Height != null) hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.ImageUrl != null) hashCode = hashCode * 59 + this.ImageUrl.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.WatermarkType != null) hashCode = hashCode * 59 + this.WatermarkType.GetHashCode();
                if (this.ImageProcess != null) hashCode = hashCode * 59 + this.ImageProcess.GetHashCode();
                if (this.TimelineStart != null) hashCode = hashCode * 59 + this.TimelineStart.GetHashCode();
                if (this.TimelineDuration != null) hashCode = hashCode * 59 + this.TimelineDuration.GetHashCode();
                return hashCode;
            }
        }
    }
}
