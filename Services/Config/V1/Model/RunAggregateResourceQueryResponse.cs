using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Config.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class RunAggregateResourceQueryResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("query_info", NullValueHandling = NullValueHandling.Ignore)]
        public QueryInfo QueryInfo { get; set; }

        /// <summary>
        /// ResourceQL 查询结果.
        /// </summary>
        [JsonProperty("results", NullValueHandling = NullValueHandling.Ignore)]
        public List<Object> Results { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RunAggregateResourceQueryResponse {\n");
            sb.Append("  queryInfo: ").Append(QueryInfo).Append("\n");
            sb.Append("  results: ").Append(Results).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RunAggregateResourceQueryResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RunAggregateResourceQueryResponse input)
        {
            if (input == null) return false;
            if (this.QueryInfo != input.QueryInfo || (this.QueryInfo != null && !this.QueryInfo.Equals(input.QueryInfo))) return false;
            if (this.Results != input.Results || (this.Results != null && input.Results != null && !this.Results.SequenceEqual(input.Results))) return false;

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
                if (this.QueryInfo != null) hashCode = hashCode * 59 + this.QueryInfo.GetHashCode();
                if (this.Results != null) hashCode = hashCode * 59 + this.Results.GetHashCode();
                return hashCode;
            }
        }
    }
}
