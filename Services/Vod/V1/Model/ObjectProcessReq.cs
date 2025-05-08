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
    public class ObjectProcessReq 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("input", NullValueHandling = NullValueHandling.Ignore)]
        public ObsInfo Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("output", NullValueHandling = NullValueHandling.Ignore)]
        public ObsInfo Output { get; set; }

        /// <summary>
        /// 转码任务列表 
        /// </summary>
        [JsonProperty("transcode_task", NullValueHandling = NullValueHandling.Ignore)]
        public List<ObjectTranscodeTask> TranscodeTask { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("video_process", NullValueHandling = NullValueHandling.Ignore)]
        public VideoProcess VideoProcess { get; set; }

        /// <summary>
        /// 水印设置 
        /// </summary>
        [JsonProperty("watermarks", NullValueHandling = NullValueHandling.Ignore)]
        public List<WatermarkRequest> Watermarks { get; set; }

        /// <summary>
        /// 转码任务列表 
        /// </summary>
        [JsonProperty("thumbnail_task", NullValueHandling = NullValueHandling.Ignore)]
        public List<ObjectThumbnailTask> ThumbnailTask { get; set; }

        /// <summary>
        /// 转码任务列表 
        /// </summary>
        [JsonProperty("image_sprite_task", NullValueHandling = NullValueHandling.Ignore)]
        public List<ObjectImageSpriteTask> ImageSpriteTask { get; set; }

        /// <summary>
        /// 回调url 
        /// </summary>
        [JsonProperty("callback_url", NullValueHandling = NullValueHandling.Ignore)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// 自定义上下文，回调时会回调给用户，透传信息
        /// </summary>
        [JsonProperty("session_context", NullValueHandling = NullValueHandling.Ignore)]
        public string SessionContext { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ObjectProcessReq {\n");
            sb.Append("  input: ").Append(Input).Append("\n");
            sb.Append("  output: ").Append(Output).Append("\n");
            sb.Append("  transcodeTask: ").Append(TranscodeTask).Append("\n");
            sb.Append("  videoProcess: ").Append(VideoProcess).Append("\n");
            sb.Append("  watermarks: ").Append(Watermarks).Append("\n");
            sb.Append("  thumbnailTask: ").Append(ThumbnailTask).Append("\n");
            sb.Append("  imageSpriteTask: ").Append(ImageSpriteTask).Append("\n");
            sb.Append("  callbackUrl: ").Append(CallbackUrl).Append("\n");
            sb.Append("  sessionContext: ").Append(SessionContext).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ObjectProcessReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ObjectProcessReq input)
        {
            if (input == null) return false;
            if (this.Input != input.Input || (this.Input != null && !this.Input.Equals(input.Input))) return false;
            if (this.Output != input.Output || (this.Output != null && !this.Output.Equals(input.Output))) return false;
            if (this.TranscodeTask != input.TranscodeTask || (this.TranscodeTask != null && input.TranscodeTask != null && !this.TranscodeTask.SequenceEqual(input.TranscodeTask))) return false;
            if (this.VideoProcess != input.VideoProcess || (this.VideoProcess != null && !this.VideoProcess.Equals(input.VideoProcess))) return false;
            if (this.Watermarks != input.Watermarks || (this.Watermarks != null && input.Watermarks != null && !this.Watermarks.SequenceEqual(input.Watermarks))) return false;
            if (this.ThumbnailTask != input.ThumbnailTask || (this.ThumbnailTask != null && input.ThumbnailTask != null && !this.ThumbnailTask.SequenceEqual(input.ThumbnailTask))) return false;
            if (this.ImageSpriteTask != input.ImageSpriteTask || (this.ImageSpriteTask != null && input.ImageSpriteTask != null && !this.ImageSpriteTask.SequenceEqual(input.ImageSpriteTask))) return false;
            if (this.CallbackUrl != input.CallbackUrl || (this.CallbackUrl != null && !this.CallbackUrl.Equals(input.CallbackUrl))) return false;
            if (this.SessionContext != input.SessionContext || (this.SessionContext != null && !this.SessionContext.Equals(input.SessionContext))) return false;

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
                if (this.Input != null) hashCode = hashCode * 59 + this.Input.GetHashCode();
                if (this.Output != null) hashCode = hashCode * 59 + this.Output.GetHashCode();
                if (this.TranscodeTask != null) hashCode = hashCode * 59 + this.TranscodeTask.GetHashCode();
                if (this.VideoProcess != null) hashCode = hashCode * 59 + this.VideoProcess.GetHashCode();
                if (this.Watermarks != null) hashCode = hashCode * 59 + this.Watermarks.GetHashCode();
                if (this.ThumbnailTask != null) hashCode = hashCode * 59 + this.ThumbnailTask.GetHashCode();
                if (this.ImageSpriteTask != null) hashCode = hashCode * 59 + this.ImageSpriteTask.GetHashCode();
                if (this.CallbackUrl != null) hashCode = hashCode * 59 + this.CallbackUrl.GetHashCode();
                if (this.SessionContext != null) hashCode = hashCode * 59 + this.SessionContext.GetHashCode();
                return hashCode;
            }
        }
    }
}
