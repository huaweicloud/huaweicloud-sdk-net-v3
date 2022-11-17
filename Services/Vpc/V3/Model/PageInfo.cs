using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PageInfo 
    {

        /// <summary>
        /// 当前页第一条记录
        /// </summary>
        [JsonProperty("previous_marker", NullValueHandling = NullValueHandling.Ignore)]
        public string PreviousMarker { get; set; }

        /// <summary>
        /// 当前页总数
        /// </summary>
        [JsonProperty("current_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? CurrentCount { get; set; }

        /// <summary>
        /// 当前页最后一条记录，最后一页时无next_marker字段
        /// </summary>
        [JsonProperty("next_marker", NullValueHandling = NullValueHandling.Ignore)]
        public string NextMarker { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PageInfo {\n");
            sb.Append("  previousMarker: ").Append(PreviousMarker).Append("\n");
            sb.Append("  currentCount: ").Append(CurrentCount).Append("\n");
            sb.Append("  nextMarker: ").Append(NextMarker).Append("\n");
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
                    this.PreviousMarker == input.PreviousMarker ||
                    (this.PreviousMarker != null &&
                    this.PreviousMarker.Equals(input.PreviousMarker))
                ) && 
                (
                    this.CurrentCount == input.CurrentCount ||
                    (this.CurrentCount != null &&
                    this.CurrentCount.Equals(input.CurrentCount))
                ) && 
                (
                    this.NextMarker == input.NextMarker ||
                    (this.NextMarker != null &&
                    this.NextMarker.Equals(input.NextMarker))
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
                if (this.PreviousMarker != null)
                    hashCode = hashCode * 59 + this.PreviousMarker.GetHashCode();
                if (this.CurrentCount != null)
                    hashCode = hashCode * 59 + this.CurrentCount.GetHashCode();
                if (this.NextMarker != null)
                    hashCode = hashCode * 59 + this.NextMarker.GetHashCode();
                return hashCode;
            }
        }
    }
}
