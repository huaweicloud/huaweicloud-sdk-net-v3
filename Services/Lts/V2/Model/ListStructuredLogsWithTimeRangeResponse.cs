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
    public class ListStructuredLogsWithTimeRangeResponse : SdkResponse
    {

        /// <summary>
        /// 查询结构化日志结果信息。 此处仅为示例，具体参数名称取决于查询的字段。
        /// </summary>
        [JsonProperty("context", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Context { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListStructuredLogsWithTimeRangeResponse {\n");
            sb.Append("  context: ").Append(Context).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListStructuredLogsWithTimeRangeResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListStructuredLogsWithTimeRangeResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Context == input.Context ||
                    this.Context != null &&
                    input.Context != null &&
                    this.Context.SequenceEqual(input.Context)
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
                if (this.Context != null)
                    hashCode = hashCode * 59 + this.Context.GetHashCode();
                return hashCode;
            }
        }
    }
}
