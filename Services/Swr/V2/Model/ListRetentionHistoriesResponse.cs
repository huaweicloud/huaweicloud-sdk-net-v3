using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListRetentionHistoriesResponse : SdkResponse
    {

        /// <summary>
        /// 镜像老化日志
        /// </summary>
        [JsonProperty("retention_log", NullValueHandling = NullValueHandling.Ignore)]
        public List<RetentionLog> RetentionLog { get; set; }

        /// <summary>
        /// 总个数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("Content-Range", IsHeader = true)]
        [JsonProperty("Content-Range", NullValueHandling = NullValueHandling.Ignore)]
        public string ContentRange { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRetentionHistoriesResponse {\n");
            sb.Append("  retentionLog: ").Append(RetentionLog).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  contentRange: ").Append(ContentRange).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListRetentionHistoriesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListRetentionHistoriesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RetentionLog == input.RetentionLog ||
                    this.RetentionLog != null &&
                    input.RetentionLog != null &&
                    this.RetentionLog.SequenceEqual(input.RetentionLog)
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.ContentRange == input.ContentRange ||
                    (this.ContentRange != null &&
                    this.ContentRange.Equals(input.ContentRange))
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
                if (this.RetentionLog != null)
                    hashCode = hashCode * 59 + this.RetentionLog.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.ContentRange != null)
                    hashCode = hashCode * 59 + this.ContentRange.GetHashCode();
                return hashCode;
            }
        }
    }
}
