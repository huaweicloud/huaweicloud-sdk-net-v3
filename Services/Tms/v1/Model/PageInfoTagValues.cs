using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Tms.v1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PageInfoTagValues 
    {

        /// <summary>
        /// 分页位置标识（索引）
        /// </summary>
        [JsonProperty("next_marker", NullValueHandling = NullValueHandling.Ignore)]
        public string NextMarker { get; set; }

        /// <summary>
        /// 当前页标签值的数量
        /// </summary>
        [JsonProperty("current_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? CurrentCount { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PageInfoTagValues {\n");
            sb.Append("  nextMarker: ").Append(NextMarker).Append("\n");
            sb.Append("  currentCount: ").Append(CurrentCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PageInfoTagValues);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PageInfoTagValues input)
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
                if (this.CurrentCount != null)
                    hashCode = hashCode * 59 + this.CurrentCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
