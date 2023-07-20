using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListQueryStructuredLogsResponse : SdkResponse
    {

        /// <summary>
        /// 日志信息。
        /// </summary>
        [JsonProperty("struct_logs", NullValueHandling = NullValueHandling.Ignore)]
        public List<StructLogContents> StructLogs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListQueryStructuredLogsResponse {\n");
            sb.Append("  structLogs: ").Append(StructLogs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListQueryStructuredLogsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListQueryStructuredLogsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StructLogs == input.StructLogs ||
                    this.StructLogs != null &&
                    input.StructLogs != null &&
                    this.StructLogs.SequenceEqual(input.StructLogs)
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
                if (this.StructLogs != null)
                    hashCode = hashCode * 59 + this.StructLogs.GetHashCode();
                return hashCode;
            }
        }
    }
}
