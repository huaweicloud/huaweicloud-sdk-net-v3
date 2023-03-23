using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Nat.V2.Model
{
    /// <summary>
    /// 分页信息。
    /// </summary>
    public class PageInfo 
    {

        /// <summary>
        /// 分页查询结果中最后一条记录的ID。通常用于查询下一页。
        /// </summary>
        [JsonProperty("next_marker", NullValueHandling = NullValueHandling.Ignore)]
        public string NextMarker { get; set; }

        /// <summary>
        /// 分页查询结果中第一条记录的ID。通常用于配合page_reverse&#x3D;true查询上一页。
        /// </summary>
        [JsonProperty("previous_marker", NullValueHandling = NullValueHandling.Ignore)]
        public string PreviousMarker { get; set; }

        /// <summary>
        /// 分页查询资源时，本页的实例的个数。
        /// </summary>
        [JsonProperty("current_count", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? CurrentCount { get; set; }



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
