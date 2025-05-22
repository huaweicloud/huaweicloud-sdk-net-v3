using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsBuild.V3.Model
{
    /// <summary>
    /// 结果
    /// </summary>
    public class RealTimeLogResponseBodyResult 
    {

        /// <summary>
        /// 是否还有剩余日志标识
        /// </summary>
        [JsonProperty("has_more_data", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasMoreData { get; set; }

        /// <summary>
        /// 偏移量，可用于下一次请求
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 返回日志内容，可能会空，请再次请求
        /// </summary>
        [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
        public string Content { get; set; }

        /// <summary>
        /// 当前请求偏移量
        /// </summary>
        [JsonProperty("current_offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? CurrentOffset { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RealTimeLogResponseBodyResult {\n");
            sb.Append("  hasMoreData: ").Append(HasMoreData).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  content: ").Append(Content).Append("\n");
            sb.Append("  currentOffset: ").Append(CurrentOffset).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RealTimeLogResponseBodyResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RealTimeLogResponseBodyResult input)
        {
            if (input == null) return false;
            if (this.HasMoreData != input.HasMoreData || (this.HasMoreData != null && !this.HasMoreData.Equals(input.HasMoreData))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Content != input.Content || (this.Content != null && !this.Content.Equals(input.Content))) return false;
            if (this.CurrentOffset != input.CurrentOffset || (this.CurrentOffset != null && !this.CurrentOffset.Equals(input.CurrentOffset))) return false;

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
                if (this.HasMoreData != null) hashCode = hashCode * 59 + this.HasMoreData.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Content != null) hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.CurrentOffset != null) hashCode = hashCode * 59 + this.CurrentOffset.GetHashCode();
                return hashCode;
            }
        }
    }
}
