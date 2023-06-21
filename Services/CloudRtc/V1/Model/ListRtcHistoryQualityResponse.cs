using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CloudRtc.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListRtcHistoryQualityResponse : SdkResponse
    {

        /// <summary>
        /// 时间戳及相应时间的指标数值列表
        /// </summary>
        [JsonProperty("quality", NullValueHandling = NullValueHandling.Ignore)]
        public List<RtcHistoryQualityTimeValue> Quality { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("X-request-id", IsHeader = true)]
        [JsonProperty("X-request-id", NullValueHandling = NullValueHandling.Ignore)]
        public string XRequestId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRtcHistoryQualityResponse {\n");
            sb.Append("  quality: ").Append(Quality).Append("\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListRtcHistoryQualityResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListRtcHistoryQualityResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Quality == input.Quality ||
                    this.Quality != null &&
                    input.Quality != null &&
                    this.Quality.SequenceEqual(input.Quality)
                ) && 
                (
                    this.XRequestId == input.XRequestId ||
                    (this.XRequestId != null &&
                    this.XRequestId.Equals(input.XRequestId))
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
                if (this.Quality != null)
                    hashCode = hashCode * 59 + this.Quality.GetHashCode();
                if (this.XRequestId != null)
                    hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
