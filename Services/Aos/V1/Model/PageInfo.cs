using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aos.V1.Model
{
    /// <summary>
    /// 分页信息
    /// </summary>
    public class PageInfo 
    {

        /// <summary>
        /// 向后分页标识符。如果存在，则表示实际总输出比当前响应中包含的输出多。在对操作的后续调用中，在标签请求参数中使用此值，以获取输出的下一部分。您应该重复此操作，直到next_marker响应元素返回为null。
        /// </summary>
        [JsonProperty("next_marker", NullValueHandling = NullValueHandling.Ignore)]
        public string NextMarker { get; set; }

        /// <summary>
        /// 向前分页标识符。
        /// </summary>
        [JsonProperty("previous_marker", NullValueHandling = NullValueHandling.Ignore)]
        public string PreviousMarker { get; set; }

        /// <summary>
        /// 本页显示的条目数量。
        /// </summary>
        [JsonProperty("current_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? CurrentCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PageInfo {\n");
            sb.Append("  nextMarker: ").Append(NextMarker).Append("\n");
            sb.Append("  previousMarker: ").Append(PreviousMarker).Append("\n");
            sb.Append("  currentCount: ").Append(CurrentCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PageInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PageInfo input)
        {
            if (input == null) return false;
            if (this.NextMarker != input.NextMarker || (this.NextMarker != null && !this.NextMarker.Equals(input.NextMarker))) return false;
            if (this.PreviousMarker != input.PreviousMarker || (this.PreviousMarker != null && !this.PreviousMarker.Equals(input.PreviousMarker))) return false;
            if (this.CurrentCount != input.CurrentCount || (this.CurrentCount != null && !this.CurrentCount.Equals(input.CurrentCount))) return false;

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
                if (this.NextMarker != null) hashCode = hashCode * 59 + this.NextMarker.GetHashCode();
                if (this.PreviousMarker != null) hashCode = hashCode * 59 + this.PreviousMarker.GetHashCode();
                if (this.CurrentCount != null) hashCode = hashCode * 59 + this.CurrentCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
