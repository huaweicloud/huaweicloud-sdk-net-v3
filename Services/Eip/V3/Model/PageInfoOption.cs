using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eip.V3.Model
{
    /// <summary>
    /// 分页页码信息
    /// </summary>
    public class PageInfoOption 
    {

        /// <summary>
        /// 翻页时，作为前一页的marker取值
        /// </summary>
        [JsonProperty("previous_marker", NullValueHandling = NullValueHandling.Ignore)]
        public string PreviousMarker { get; set; }

        /// <summary>
        /// 翻页时，作为后一页的marker取值
        /// </summary>
        [JsonProperty("next_marker", NullValueHandling = NullValueHandling.Ignore)]
        public string NextMarker { get; set; }

        /// <summary>
        /// 当前页的数据总数
        /// </summary>
        [JsonProperty("current_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? CurrentCount { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PageInfoOption {\n");
            sb.Append("  previousMarker: ").Append(PreviousMarker).Append("\n");
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
            return this.Equals(input as PageInfoOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PageInfoOption input)
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
                if (this.PreviousMarker != null)
                    hashCode = hashCode * 59 + this.PreviousMarker.GetHashCode();
                if (this.NextMarker != null)
                    hashCode = hashCode * 59 + this.NextMarker.GetHashCode();
                if (this.CurrentCount != null)
                    hashCode = hashCode * 59 + this.CurrentCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
