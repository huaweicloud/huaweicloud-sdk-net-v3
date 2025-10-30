using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListSmallVersionResponse : SdkResponse
    {

        /// <summary>
        /// 参数解释： 数据库版本信息列表。
        /// </summary>
        [JsonProperty("data_stores", NullValueHandling = NullValueHandling.Ignore)]
        public List<DatabaseSmallVersion> DataStores { get; set; }

        /// <summary>
        /// 参数解释： 查询总个数。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSmallVersionResponse {\n");
            sb.Append("  dataStores: ").Append(DataStores).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSmallVersionResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSmallVersionResponse input)
        {
            if (input == null) return false;
            if (this.DataStores != input.DataStores || (this.DataStores != null && input.DataStores != null && !this.DataStores.SequenceEqual(input.DataStores))) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;

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
                if (this.DataStores != null) hashCode = hashCode * 59 + this.DataStores.GetHashCode();
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                return hashCode;
            }
        }
    }
}
