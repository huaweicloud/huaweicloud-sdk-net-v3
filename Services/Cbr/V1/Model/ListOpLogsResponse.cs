using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListOpLogsResponse : SdkResponse
    {

        /// <summary>
        /// 任务列表
        /// </summary>
        [JsonProperty("operation_logs", NullValueHandling = NullValueHandling.Ignore)]
        public List<OperationLog> OperationLogs { get; set; }

        /// <summary>
        /// 任务个数
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListOpLogsResponse {\n");
            sb.Append("  operationLogs: ").Append(OperationLogs).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListOpLogsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListOpLogsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OperationLogs == input.OperationLogs ||
                    this.OperationLogs != null &&
                    input.OperationLogs != null &&
                    this.OperationLogs.SequenceEqual(input.OperationLogs)
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
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
                if (this.OperationLogs != null)
                    hashCode = hashCode * 59 + this.OperationLogs.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                return hashCode;
            }
        }
    }
}
