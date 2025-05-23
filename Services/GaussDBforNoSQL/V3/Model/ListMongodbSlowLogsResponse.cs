using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListMongodbSlowLogsResponse : SdkResponse
    {

        /// <summary>
        /// 慢日志具体信息。
        /// </summary>
        [JsonProperty("slow_logs", NullValueHandling = NullValueHandling.Ignore)]
        public List<MongodbSlowLogDetail> SlowLogs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListMongodbSlowLogsResponse {\n");
            sb.Append("  slowLogs: ").Append(SlowLogs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListMongodbSlowLogsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListMongodbSlowLogsResponse input)
        {
            if (input == null) return false;
            if (this.SlowLogs != input.SlowLogs || (this.SlowLogs != null && input.SlowLogs != null && !this.SlowLogs.SequenceEqual(input.SlowLogs))) return false;

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
                if (this.SlowLogs != null) hashCode = hashCode * 59 + this.SlowLogs.GetHashCode();
                return hashCode;
            }
        }
    }
}
