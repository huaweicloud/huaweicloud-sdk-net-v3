using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListQueryHttpCodeResponse : SdkResponse
    {

        /// <summary>
        /// 基于时间轴的状态码
        /// </summary>
        [JsonProperty("data_series", NullValueHandling = NullValueHandling.Ignore)]
        public List<HttpCodeSummary> DataSeries { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("X-Request-Id", IsHeader = true)]
        [JsonProperty("X-Request-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string XRequestId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListQueryHttpCodeResponse {\n");
            sb.Append("  dataSeries: ").Append(DataSeries).Append("\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListQueryHttpCodeResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListQueryHttpCodeResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DataSeries == input.DataSeries ||
                    this.DataSeries != null &&
                    input.DataSeries != null &&
                    this.DataSeries.SequenceEqual(input.DataSeries)
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
                if (this.DataSeries != null)
                    hashCode = hashCode * 59 + this.DataSeries.GetHashCode();
                if (this.XRequestId != null)
                    hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
