using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Apm.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowSpanSearchResponse : SdkResponse
    {

        /// <summary>
        /// 返回的总数。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// span信息。
        /// </summary>
        [JsonProperty("span_info_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ClientSpanInfo> SpanInfoList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowSpanSearchResponse {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  spanInfoList: ").Append(SpanInfoList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowSpanSearchResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowSpanSearchResponse input)
        {
            if (input == null) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.SpanInfoList != input.SpanInfoList || (this.SpanInfoList != null && input.SpanInfoList != null && !this.SpanInfoList.SequenceEqual(input.SpanInfoList))) return false;

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
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.SpanInfoList != null) hashCode = hashCode * 59 + this.SpanInfoList.GetHashCode();
                return hashCode;
            }
        }
    }
}
