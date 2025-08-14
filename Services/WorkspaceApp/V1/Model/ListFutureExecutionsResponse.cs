using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListFutureExecutionsResponse : SdkResponse
    {

        /// <summary>
        /// 未来执行的具体时间列表。
        /// </summary>
        [JsonProperty("future_executions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> FutureExecutions { get; set; }

        /// <summary>
        /// 时区。
        /// </summary>
        [JsonProperty("time_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeZone { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListFutureExecutionsResponse {\n");
            sb.Append("  futureExecutions: ").Append(FutureExecutions).Append("\n");
            sb.Append("  timeZone: ").Append(TimeZone).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListFutureExecutionsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListFutureExecutionsResponse input)
        {
            if (input == null) return false;
            if (this.FutureExecutions != input.FutureExecutions || (this.FutureExecutions != null && input.FutureExecutions != null && !this.FutureExecutions.SequenceEqual(input.FutureExecutions))) return false;
            if (this.TimeZone != input.TimeZone || (this.TimeZone != null && !this.TimeZone.Equals(input.TimeZone))) return false;

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
                if (this.FutureExecutions != null) hashCode = hashCode * 59 + this.FutureExecutions.GetHashCode();
                if (this.TimeZone != null) hashCode = hashCode * 59 + this.TimeZone.GetHashCode();
                return hashCode;
            }
        }
    }
}
