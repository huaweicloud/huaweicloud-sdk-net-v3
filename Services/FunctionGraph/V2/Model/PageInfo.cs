using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.FunctionGraph.V2.Model
{
    /// <summary>
    /// 分页结构体。
    /// </summary>
    public class PageInfo 
    {

        /// <summary>
        /// 返回下一页查询地址。
        /// </summary>
        [JsonProperty("next_marker", NullValueHandling = NullValueHandling.Ignore)]
        public long? NextMarker { get; set; }

        /// <summary>
        /// 返回前一页查询地址。
        /// </summary>
        [JsonProperty("previous_marker", NullValueHandling = NullValueHandling.Ignore)]
        public long? PreviousMarker { get; set; }

        /// <summary>
        /// 本页返回条目数量。
        /// </summary>
        [JsonProperty("current_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? CurrentCount { get; set; }


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
            if (input == null)
                return false;

            return 
                (
                    this.NextMarker == input.NextMarker ||
                    (this.NextMarker != null &&
                    this.NextMarker.Equals(input.NextMarker))
                ) && 
                (
                    this.PreviousMarker == input.PreviousMarker ||
                    (this.PreviousMarker != null &&
                    this.PreviousMarker.Equals(input.PreviousMarker))
                ) && 
                (
                    this.CurrentCount == input.CurrentCount ||
                    (this.CurrentCount != null &&
                    this.CurrentCount.Equals(input.CurrentCount))
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
                if (this.NextMarker != null)
                    hashCode = hashCode * 59 + this.NextMarker.GetHashCode();
                if (this.PreviousMarker != null)
                    hashCode = hashCode * 59 + this.PreviousMarker.GetHashCode();
                if (this.CurrentCount != null)
                    hashCode = hashCode * 59 + this.CurrentCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
