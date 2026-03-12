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
    /// 截图信息。
    /// </summary>
    public class QueryThumbnailInfo 
    {

        /// <summary>
        /// 截图任务 
        /// </summary>
        [JsonProperty("task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("thumbnail_para", NullValueHandling = NullValueHandling.Ignore)]
        public Thumbnail ThumbnailPara { get; set; }

        /// <summary>
        /// 视频截图个数。
        /// </summary>
        [JsonProperty("thumbnail_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ThumbnailCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryThumbnailInfo {\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("  thumbnailPara: ").Append(ThumbnailPara).Append("\n");
            sb.Append("  thumbnailCount: ").Append(ThumbnailCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryThumbnailInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryThumbnailInfo input)
        {
            if (input == null) return false;
            if (this.TaskId != input.TaskId || (this.TaskId != null && !this.TaskId.Equals(input.TaskId))) return false;
            if (this.ThumbnailPara != input.ThumbnailPara || (this.ThumbnailPara != null && !this.ThumbnailPara.Equals(input.ThumbnailPara))) return false;
            if (this.ThumbnailCount != input.ThumbnailCount || (this.ThumbnailCount != null && !this.ThumbnailCount.Equals(input.ThumbnailCount))) return false;

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
                if (this.TaskId != null) hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.ThumbnailPara != null) hashCode = hashCode * 59 + this.ThumbnailPara.GetHashCode();
                if (this.ThumbnailCount != null) hashCode = hashCode * 59 + this.ThumbnailCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
