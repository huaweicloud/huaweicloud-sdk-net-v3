using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowTrainingJobLogsPreviewResponse : SdkResponse
    {

        /// <summary>
        /// 日志内容。如果日志大小没有超过上限（n兆）则返回全部内容，如果日志超过了上限（n兆）则返回最新的n兆的日志。2022/03/01 00:00:00 (GMT+08:00)后，此参数名称由“context”改为“content”。
        /// </summary>
        [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
        public string Content { get; set; }

        /// <summary>
        /// 当前返回的日志大小（单位：字节）。最大为5兆。
        /// </summary>
        [JsonProperty("current_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? CurrentSize { get; set; }

        /// <summary>
        /// 完整的日志大小（单位：字节）。
        /// </summary>
        [JsonProperty("full_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? FullSize { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowTrainingJobLogsPreviewResponse {\n");
            sb.Append("  content: ").Append(Content).Append("\n");
            sb.Append("  currentSize: ").Append(CurrentSize).Append("\n");
            sb.Append("  fullSize: ").Append(FullSize).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowTrainingJobLogsPreviewResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowTrainingJobLogsPreviewResponse input)
        {
            if (input == null) return false;
            if (this.Content != input.Content || (this.Content != null && !this.Content.Equals(input.Content))) return false;
            if (this.CurrentSize != input.CurrentSize || (this.CurrentSize != null && !this.CurrentSize.Equals(input.CurrentSize))) return false;
            if (this.FullSize != input.FullSize || (this.FullSize != null && !this.FullSize.Equals(input.FullSize))) return false;

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
                if (this.Content != null) hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.CurrentSize != null) hashCode = hashCode * 59 + this.CurrentSize.GetHashCode();
                if (this.FullSize != null) hashCode = hashCode * 59 + this.FullSize.GetHashCode();
                return hashCode;
            }
        }
    }
}
