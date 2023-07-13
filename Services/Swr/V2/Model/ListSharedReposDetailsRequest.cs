using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListSharedReposDetailsRequest 
    {

        /// <summary>
        /// 组织名称。小写字母开头，后面跟小写字母、数字、小数点、下划线或中划线（其中下划线最多允许连续两个，小数点、下划线、中划线不能直接相连），小写字母或数字结尾，1-64个字符。
        /// </summary>
        [SDKProperty("namespace", IsQuery = true)]
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string Namespace { get; set; }

        /// <summary>
        /// 镜像仓库名称
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// self: 我共享的镜像。thirdparty: 他人共享给我的镜像
        /// </summary>
        [SDKProperty("center", IsQuery = true)]
        [JsonProperty("center", NullValueHandling = NullValueHandling.Ignore)]
        public string Center { get; set; }

        /// <summary>
        /// 返回条数。注意：offset和limit参数需要配套使用。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public string Limit { get; set; }

        /// <summary>
        /// 起始索引。注意：offset和limit参数需要配套使用。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public string Offset { get; set; }

        /// <summary>
        /// 按列排序，可设置为updated_at（按更新时间排序）。注意：order_column和order_type参数需要配套使用。
        /// </summary>
        [SDKProperty("order_column", IsQuery = true)]
        [JsonProperty("order_column", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderColumn { get; set; }

        /// <summary>
        /// 排序类型，可设置为desc（降序）、asc（升序）。注意：order_column和order_type参数需要配套使用。
        /// </summary>
        [SDKProperty("order_type", IsQuery = true)]
        [JsonProperty("order_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderType { get; set; }

        /// <summary>
        /// 应填写 center::{center}|name::{name}|limit::{limit}|offset::{offset}|namespace::{namespace}|order_column::{order_column}|order_type::{order_type} ,其中 {center}可选为self: 我共享的镜像。thirdparty: 他人共享给我的镜像，namespace为组织名称，name为镜像仓库名称， {limit}为返回条数,{offset}为起始索引,{order_column}为按列排序，可设置为name、updated_time、tag_count,{order_type}为排序类型，可设置为desc（降序）、asc（升序）
        /// </summary>
        [SDKProperty("filter", IsQuery = true)]
        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public string Filter { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSharedReposDetailsRequest {\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  center: ").Append(Center).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  orderColumn: ").Append(OrderColumn).Append("\n");
            sb.Append("  orderType: ").Append(OrderType).Append("\n");
            sb.Append("  filter: ").Append(Filter).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSharedReposDetailsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSharedReposDetailsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Center == input.Center ||
                    (this.Center != null &&
                    this.Center.Equals(input.Center))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && 
                (
                    this.OrderColumn == input.OrderColumn ||
                    (this.OrderColumn != null &&
                    this.OrderColumn.Equals(input.OrderColumn))
                ) && 
                (
                    this.OrderType == input.OrderType ||
                    (this.OrderType != null &&
                    this.OrderType.Equals(input.OrderType))
                ) && 
                (
                    this.Filter == input.Filter ||
                    (this.Filter != null &&
                    this.Filter.Equals(input.Filter))
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
                if (this.Namespace != null)
                    hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Center != null)
                    hashCode = hashCode * 59 + this.Center.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.OrderColumn != null)
                    hashCode = hashCode * 59 + this.OrderColumn.GetHashCode();
                if (this.OrderType != null)
                    hashCode = hashCode * 59 + this.OrderType.GetHashCode();
                if (this.Filter != null)
                    hashCode = hashCode * 59 + this.Filter.GetHashCode();
                return hashCode;
            }
        }
    }
}
