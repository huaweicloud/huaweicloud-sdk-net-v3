using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ucs.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListReposRequest 
    {

        /// <summary>
        /// 集群id
        /// </summary>
        [SDKProperty("clusterid", IsQuery = true)]
        [JsonProperty("clusterid", NullValueHandling = NullValueHandling.Ignore)]
        public string Clusterid { get; set; }

        /// <summary>
        /// 分页获取列表时，页的大小，默认为-1
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 分页获取列表时，起始偏移量，默认为0
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 分页获取列表时，排序参数，支持create_at和update_at，默认create_at： - create_at：按创建时间排序 - update_at：按更新时间排序
        /// </summary>
        [SDKProperty("order_by", IsQuery = true)]
        [JsonProperty("order_by", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderBy { get; set; }

        /// <summary>
        /// 分页获取列表时，排序方向，支持desc和asc，默认desc： - desc：降序排序 - asc：升序排序
        /// </summary>
        [SDKProperty("order", IsQuery = true)]
        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public string Order { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListReposRequest {\n");
            sb.Append("  clusterid: ").Append(Clusterid).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  orderBy: ").Append(OrderBy).Append("\n");
            sb.Append("  order: ").Append(Order).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListReposRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListReposRequest input)
        {
            if (input == null) return false;
            if (this.Clusterid != input.Clusterid || (this.Clusterid != null && !this.Clusterid.Equals(input.Clusterid))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.OrderBy != input.OrderBy || (this.OrderBy != null && !this.OrderBy.Equals(input.OrderBy))) return false;
            if (this.Order != input.Order || (this.Order != null && !this.Order.Equals(input.Order))) return false;

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
                if (this.Clusterid != null) hashCode = hashCode * 59 + this.Clusterid.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.OrderBy != null) hashCode = hashCode * 59 + this.OrderBy.GetHashCode();
                if (this.Order != null) hashCode = hashCode * 59 + this.Order.GetHashCode();
                return hashCode;
            }
        }
    }
}
