using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowTopUrlResponse : SdkResponse
    {

        /// <summary>
        /// 服务区域：mainland_china(中国大陆)，outside_mainland_china(中国大陆境外)，默认为mainland_china。
        /// </summary>
        [JsonProperty("service_area", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceArea { get; set; }

        /// <summary>
        /// 详情数据对象。
        /// </summary>
        [JsonProperty("top_url_summary", NullValueHandling = NullValueHandling.Ignore)]
        public List<TopUrlSummary> TopUrlSummary { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowTopUrlResponse {\n");
            sb.Append("  serviceArea: ").Append(ServiceArea).Append("\n");
            sb.Append("  topUrlSummary: ").Append(TopUrlSummary).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowTopUrlResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowTopUrlResponse input)
        {
            if (input == null) return false;
            if (this.ServiceArea != input.ServiceArea || (this.ServiceArea != null && !this.ServiceArea.Equals(input.ServiceArea))) return false;
            if (this.TopUrlSummary != input.TopUrlSummary || (this.TopUrlSummary != null && input.TopUrlSummary != null && !this.TopUrlSummary.SequenceEqual(input.TopUrlSummary))) return false;

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
                if (this.ServiceArea != null) hashCode = hashCode * 59 + this.ServiceArea.GetHashCode();
                if (this.TopUrlSummary != null) hashCode = hashCode * 59 + this.TopUrlSummary.GetHashCode();
                return hashCode;
            }
        }
    }
}
