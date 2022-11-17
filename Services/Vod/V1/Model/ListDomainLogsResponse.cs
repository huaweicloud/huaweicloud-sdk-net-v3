using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vod.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListDomainLogsResponse : SdkResponse
    {

        /// <summary>
        /// 日志总数。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// 日志列表数据。
        /// </summary>
        [JsonProperty("logs", NullValueHandling = NullValueHandling.Ignore)]
        public List<CdnLog> Logs { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDomainLogsResponse {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  logs: ").Append(Logs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDomainLogsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDomainLogsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.Logs == input.Logs ||
                    this.Logs != null &&
                    input.Logs != null &&
                    this.Logs.SequenceEqual(input.Logs)
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
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Logs != null)
                    hashCode = hashCode * 59 + this.Logs.GetHashCode();
                return hashCode;
            }
        }
    }
}
