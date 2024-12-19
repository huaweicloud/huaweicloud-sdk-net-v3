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
    /// Request Object
    /// </summary>
    public class ShowStoredQueryRequest 
    {

        /// <summary>
        /// 查询ID
        /// </summary>
        [SDKProperty("query_id", IsPath = true)]
        [JsonProperty("query_id", NullValueHandling = NullValueHandling.Ignore)]
        public string QueryId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowStoredQueryRequest {\n");
            sb.Append("  queryId: ").Append(QueryId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowStoredQueryRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowStoredQueryRequest input)
        {
            if (input == null) return false;
            if (this.QueryId != input.QueryId || (this.QueryId != null && !this.QueryId.Equals(input.QueryId))) return false;

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
                if (this.QueryId != null) hashCode = hashCode * 59 + this.QueryId.GetHashCode();
                return hashCode;
            }
        }
    }
}
