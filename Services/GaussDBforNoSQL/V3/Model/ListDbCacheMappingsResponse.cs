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
    public class ListDbCacheMappingsResponse : SdkResponse
    {

        /// <summary>
        /// 总记录数。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 内存加速映射信息。
        /// </summary>
        [JsonProperty("dbcache_mappings", NullValueHandling = NullValueHandling.Ignore)]
        public List<QueryDBCacheMappingResponse> DbcacheMappings { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDbCacheMappingsResponse {\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  dbcacheMappings: ").Append(DbcacheMappings).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDbCacheMappingsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDbCacheMappingsResponse input)
        {
            if (input == null) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;
            if (this.DbcacheMappings != input.DbcacheMappings || (this.DbcacheMappings != null && input.DbcacheMappings != null && !this.DbcacheMappings.SequenceEqual(input.DbcacheMappings))) return false;

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
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.DbcacheMappings != null) hashCode = hashCode * 59 + this.DbcacheMappings.GetHashCode();
                return hashCode;
            }
        }
    }
}
