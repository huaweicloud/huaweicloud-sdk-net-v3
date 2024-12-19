using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Config.V1.Model
{
    /// <summary>
    /// 分页对象
    /// </summary>
    public class PageInfo 
    {

        /// <summary>
        /// 当前页的资源数量
        /// </summary>
        [JsonProperty("current_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? CurrentCount { get; set; }

        /// <summary>
        /// 下一页的marker
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
            if (input == null) return false;
            if (this.CurrentCount != input.CurrentCount || (this.CurrentCount != null && !this.CurrentCount.Equals(input.CurrentCount))) return false;
            if (this.NextMarker != input.NextMarker || (this.NextMarker != null && !this.NextMarker.Equals(input.NextMarker))) return false;

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
                if (this.CurrentCount != null) hashCode = hashCode * 59 + this.CurrentCount.GetHashCode();
                if (this.NextMarker != null) hashCode = hashCode * 59 + this.NextMarker.GetHashCode();
                return hashCode;
            }
        }
    }
}
