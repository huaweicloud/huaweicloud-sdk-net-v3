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
    public class ListMongodbErrorLogsResponse : SdkResponse
    {

        /// <summary>
        /// 错误日志具体信息。
        /// </summary>
        [JsonProperty("error_logs", NullValueHandling = NullValueHandling.Ignore)]
        public List<MongodbErrorLogDetail> ErrorLogs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListMongodbErrorLogsResponse {\n");
            sb.Append("  errorLogs: ").Append(ErrorLogs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListMongodbErrorLogsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListMongodbErrorLogsResponse input)
        {
            if (input == null) return false;
            if (this.ErrorLogs != input.ErrorLogs || (this.ErrorLogs != null && input.ErrorLogs != null && !this.ErrorLogs.SequenceEqual(input.ErrorLogs))) return false;

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
                if (this.ErrorLogs != null) hashCode = hashCode * 59 + this.ErrorLogs.GetHashCode();
                return hashCode;
            }
        }
    }
}
