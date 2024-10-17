using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListInstanceErrorLogsResponse : SdkResponse
    {

        /// <summary>
        /// 总条数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// 日志文件列表
        /// </summary>
        [JsonProperty("log_files", NullValueHandling = NullValueHandling.Ignore)]
        public List<InstanceLogFile> LogFiles { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListInstanceErrorLogsResponse {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  logFiles: ").Append(LogFiles).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListInstanceErrorLogsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListInstanceErrorLogsResponse input)
        {
            if (input == null) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.LogFiles != input.LogFiles || (this.LogFiles != null && input.LogFiles != null && !this.LogFiles.SequenceEqual(input.LogFiles))) return false;

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
                if (this.LogFiles != null) hashCode = hashCode * 59 + this.LogFiles.GetHashCode();
                return hashCode;
            }
        }
    }
}
