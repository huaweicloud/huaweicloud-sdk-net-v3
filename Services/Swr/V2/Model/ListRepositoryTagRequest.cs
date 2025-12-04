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
    public class ListRepositoryTagRequest 
    {

        /// <summary>
        /// 组织名称。小写字母开头，后面跟小写字母、数字、小数点、下划线或中划线（其中下划线最多允许连续两个，小数点、下划线、中划线不能直接相连），小写字母或数字结尾，1-64个字符。
        /// </summary>
        [SDKProperty("namespace", IsPath = true)]
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string Namespace { get; set; }

        /// <summary>
        /// 镜像仓库名称
        /// </summary>
        [SDKProperty("repository", IsPath = true)]
        [JsonProperty("repository", NullValueHandling = NullValueHandling.Ignore)]
        public string Repository { get; set; }

        /// <summary>
        /// 返回条数,默认返回100条，最多返回1000条数据。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// Start position of the cursor for querying the next page in pagination query.
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 镜像版本名。
        /// </summary>
        [SDKProperty("tag", IsQuery = true)]
        [JsonProperty("tag", NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }

        /// <summary>
        /// 按列排序，可设置为updated_at（按更新时间排序）或者tag（按照镜像版本排序）。注意：order_column和order_type参数需要配套使用。
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
        /// 是否返回镜像的manifest信息
        /// </summary>
        [SDKProperty("with_manifest", IsQuery = true)]
        [JsonProperty("with_manifest", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WithManifest { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRepositoryTagRequest {\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  repository: ").Append(Repository).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  tag: ").Append(Tag).Append("\n");
            sb.Append("  orderColumn: ").Append(OrderColumn).Append("\n");
            sb.Append("  orderType: ").Append(OrderType).Append("\n");
            sb.Append("  withManifest: ").Append(WithManifest).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListRepositoryTagRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListRepositoryTagRequest input)
        {
            if (input == null) return false;
            if (this.Namespace != input.Namespace || (this.Namespace != null && !this.Namespace.Equals(input.Namespace))) return false;
            if (this.Repository != input.Repository || (this.Repository != null && !this.Repository.Equals(input.Repository))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Marker != input.Marker || (this.Marker != null && !this.Marker.Equals(input.Marker))) return false;
            if (this.Tag != input.Tag || (this.Tag != null && !this.Tag.Equals(input.Tag))) return false;
            if (this.OrderColumn != input.OrderColumn || (this.OrderColumn != null && !this.OrderColumn.Equals(input.OrderColumn))) return false;
            if (this.OrderType != input.OrderType || (this.OrderType != null && !this.OrderType.Equals(input.OrderType))) return false;
            if (this.WithManifest != input.WithManifest || (this.WithManifest != null && !this.WithManifest.Equals(input.WithManifest))) return false;

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
                if (this.Namespace != null) hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.Repository != null) hashCode = hashCode * 59 + this.Repository.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Marker != null) hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.Tag != null) hashCode = hashCode * 59 + this.Tag.GetHashCode();
                if (this.OrderColumn != null) hashCode = hashCode * 59 + this.OrderColumn.GetHashCode();
                if (this.OrderType != null) hashCode = hashCode * 59 + this.OrderType.GetHashCode();
                if (this.WithManifest != null) hashCode = hashCode * 59 + this.WithManifest.GetHashCode();
                return hashCode;
            }
        }
    }
}
