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
    public class ObjectTaskResult 
    {

        /// <summary>
        /// 工作流中任务类型
        /// </summary>
        [JsonProperty("task_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("transcode_task", NullValueHandling = NullValueHandling.Ignore)]
        public TranscodeTask TranscodeTask { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("thumbnail_task", NullValueHandling = NullValueHandling.Ignore)]
        public ThumbnailTask ThumbnailTask { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("image_sprite_task", NullValueHandling = NullValueHandling.Ignore)]
        public ImageSpriteTask ImageSpriteTask { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ObjectTaskResult {\n");
            sb.Append("  taskType: ").Append(TaskType).Append("\n");
            sb.Append("  transcodeTask: ").Append(TranscodeTask).Append("\n");
            sb.Append("  thumbnailTask: ").Append(ThumbnailTask).Append("\n");
            sb.Append("  imageSpriteTask: ").Append(ImageSpriteTask).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ObjectTaskResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ObjectTaskResult input)
        {
            if (input == null) return false;
            if (this.TaskType != input.TaskType || (this.TaskType != null && !this.TaskType.Equals(input.TaskType))) return false;
            if (this.TranscodeTask != input.TranscodeTask || (this.TranscodeTask != null && !this.TranscodeTask.Equals(input.TranscodeTask))) return false;
            if (this.ThumbnailTask != input.ThumbnailTask || (this.ThumbnailTask != null && !this.ThumbnailTask.Equals(input.ThumbnailTask))) return false;
            if (this.ImageSpriteTask != input.ImageSpriteTask || (this.ImageSpriteTask != null && !this.ImageSpriteTask.Equals(input.ImageSpriteTask))) return false;

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
                if (this.TaskType != null) hashCode = hashCode * 59 + this.TaskType.GetHashCode();
                if (this.TranscodeTask != null) hashCode = hashCode * 59 + this.TranscodeTask.GetHashCode();
                if (this.ThumbnailTask != null) hashCode = hashCode * 59 + this.ThumbnailTask.GetHashCode();
                if (this.ImageSpriteTask != null) hashCode = hashCode * 59 + this.ImageSpriteTask.GetHashCode();
                return hashCode;
            }
        }
    }
}
