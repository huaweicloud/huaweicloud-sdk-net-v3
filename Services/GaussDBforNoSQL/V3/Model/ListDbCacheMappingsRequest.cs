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
    /// Request Object
    /// </summary>
    public class ListDbCacheMappingsRequest 
    {

        /// <summary>
        /// 映射ID，可以调用“查询内存加速映射列表和详情”接口获取。
        /// </summary>
        [SDKProperty("id", IsQuery = true)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 映射名称。名称以“*”起始，表示按照“*”后面的值模糊匹配，否则，按照实际填写的名称精确匹配查询。
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 源实例ID。
        /// </summary>
        [SDKProperty("source_instance_id", IsQuery = true)]
        [JsonProperty("source_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceInstanceId { get; set; }

        /// <summary>
        /// 源实例名称。名称以“*”起始，表示按照“*”后面的值模糊匹配，否则，按照实际填写的名称精确匹配查询。
        /// </summary>
        [SDKProperty("source_instance_name", IsQuery = true)]
        [JsonProperty("source_instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceInstanceName { get; set; }

        /// <summary>
        /// 目标实例ID。
        /// </summary>
        [SDKProperty("target_instance_id", IsQuery = true)]
        [JsonProperty("target_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetInstanceId { get; set; }

        /// <summary>
        /// 目标实例名称。名称以“*”起始，表示按照“*”后面的值模糊匹配，否则，按照实际填写的名称精确匹配查询。
        /// </summary>
        [SDKProperty("target_instance_name", IsQuery = true)]
        [JsonProperty("target_instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetInstanceName { get; set; }

        /// <summary>
        /// 索引位置，偏移量。 从第一条数据偏移offset条数据后开始查询，默认为0（偏移0条数据，表示从第一条数据开始查询）。 取值必须为数字，不能为负数。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 查询个数上限值。取值范围：1~100。不传该参数时，默认查询前100条信息。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDbCacheMappingsRequest {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  sourceInstanceId: ").Append(SourceInstanceId).Append("\n");
            sb.Append("  sourceInstanceName: ").Append(SourceInstanceName).Append("\n");
            sb.Append("  targetInstanceId: ").Append(TargetInstanceId).Append("\n");
            sb.Append("  targetInstanceName: ").Append(TargetInstanceName).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDbCacheMappingsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDbCacheMappingsRequest input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.SourceInstanceId != input.SourceInstanceId || (this.SourceInstanceId != null && !this.SourceInstanceId.Equals(input.SourceInstanceId))) return false;
            if (this.SourceInstanceName != input.SourceInstanceName || (this.SourceInstanceName != null && !this.SourceInstanceName.Equals(input.SourceInstanceName))) return false;
            if (this.TargetInstanceId != input.TargetInstanceId || (this.TargetInstanceId != null && !this.TargetInstanceId.Equals(input.TargetInstanceId))) return false;
            if (this.TargetInstanceName != input.TargetInstanceName || (this.TargetInstanceName != null && !this.TargetInstanceName.Equals(input.TargetInstanceName))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SourceInstanceId != null) hashCode = hashCode * 59 + this.SourceInstanceId.GetHashCode();
                if (this.SourceInstanceName != null) hashCode = hashCode * 59 + this.SourceInstanceName.GetHashCode();
                if (this.TargetInstanceId != null) hashCode = hashCode * 59 + this.TargetInstanceId.GetHashCode();
                if (this.TargetInstanceName != null) hashCode = hashCode * 59 + this.TargetInstanceName.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
