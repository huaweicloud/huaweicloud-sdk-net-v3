using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ddm.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowAvalibleTimeResponse : SdkResponse
    {

        /// <summary>
        /// 可恢复时间点。
        /// </summary>
        [JsonProperty("restorable_time_intervals", NullValueHandling = NullValueHandling.Ignore)]
        public List<RestoreTimeInterval> RestorableTimeIntervals { get; set; }

        /// <summary>
        /// **参数解释**：  分页参数: 起始值。  **参数范围**：   大于等于0。
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// **参数解释**：  分页参数: 每页记录数。  **参数范围**：  大于0且小于等于128。
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// **参数解释**：  总记录数。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAvalibleTimeResponse {\n");
            sb.Append("  restorableTimeIntervals: ").Append(RestorableTimeIntervals).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAvalibleTimeResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAvalibleTimeResponse input)
        {
            if (input == null) return false;
            if (this.RestorableTimeIntervals != input.RestorableTimeIntervals || (this.RestorableTimeIntervals != null && input.RestorableTimeIntervals != null && !this.RestorableTimeIntervals.SequenceEqual(input.RestorableTimeIntervals))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;

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
                if (this.RestorableTimeIntervals != null) hashCode = hashCode * 59 + this.RestorableTimeIntervals.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
