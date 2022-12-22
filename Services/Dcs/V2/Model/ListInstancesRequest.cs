using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListInstancesRequest 
    {

        /// <summary>
        /// 实例ID。
        /// </summary>
        [SDKProperty("instance_id", IsQuery = true)]
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 是否返回创建失败的实例数。 当参数值为“true”时，返回创建失败的实例数。参数值为“false”或者其他值，不返回创建失败的实例数。
        /// </summary>
        [SDKProperty("include_failure", IsQuery = true)]
        [JsonProperty("include_failure", NullValueHandling = NullValueHandling.Ignore)]
        public string IncludeFailure { get; set; }

        /// <summary>
        /// 是否返回已删除的实例数。 当参数值为“true”时，返回已删除的实例数。参数值为“false”或者其他值，不返回已删除的实例数。
        /// </summary>
        [SDKProperty("include_delete", IsQuery = true)]
        [JsonProperty("include_delete", NullValueHandling = NullValueHandling.Ignore)]
        public string IncludeDelete { get; set; }

        /// <summary>
        /// 实例名称。
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 偏移量，表示从此偏移量开始查询， offset大于等于0
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 每页显示条数，最小值为1，最大值为1000，若不设置该参数，则为10。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 实例状态。详细状态说明见[缓存实例状态说明](https://support.huaweicloud.com/api-dcs/dcs-api-0312047.html)
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 是否按照实例名称进行精确匹配查询。  默认为“false”，表示模糊匹配实例名称查询。若参数值为“true”表示按照实例名称进行精确匹配查询。
        /// </summary>
        [SDKProperty("name_equal", IsQuery = true)]
        [JsonProperty("name_equal", NullValueHandling = NullValueHandling.Ignore)]
        public string NameEqual { get; set; }

        /// <summary>
        /// 根据实例标签键值对进行查询。{key}表示标签键，{value}表示标签值。  如果同时使用多个标签键值对进行查询，中间使用逗号分隔开，表示查询同时包含指定标签键值对的实例。 
        /// </summary>
        [SDKProperty("tags", IsQuery = true)]
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public string Tags { get; set; }

        /// <summary>
        /// 连接缓存实例的IP地址。
        /// </summary>
        [SDKProperty("ip", IsQuery = true)]
        [JsonProperty("ip", NullValueHandling = NullValueHandling.Ignore)]
        public string Ip { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListInstancesRequest {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  includeFailure: ").Append(IncludeFailure).Append("\n");
            sb.Append("  includeDelete: ").Append(IncludeDelete).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  nameEqual: ").Append(NameEqual).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  ip: ").Append(Ip).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListInstancesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListInstancesRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.IncludeFailure == input.IncludeFailure ||
                    (this.IncludeFailure != null &&
                    this.IncludeFailure.Equals(input.IncludeFailure))
                ) && 
                (
                    this.IncludeDelete == input.IncludeDelete ||
                    (this.IncludeDelete != null &&
                    this.IncludeDelete.Equals(input.IncludeDelete))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.NameEqual == input.NameEqual ||
                    (this.NameEqual != null &&
                    this.NameEqual.Equals(input.NameEqual))
                ) && 
                (
                    this.Tags == input.Tags ||
                    (this.Tags != null &&
                    this.Tags.Equals(input.Tags))
                ) && 
                (
                    this.Ip == input.Ip ||
                    (this.Ip != null &&
                    this.Ip.Equals(input.Ip))
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
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.IncludeFailure != null)
                    hashCode = hashCode * 59 + this.IncludeFailure.GetHashCode();
                if (this.IncludeDelete != null)
                    hashCode = hashCode * 59 + this.IncludeDelete.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.NameEqual != null)
                    hashCode = hashCode * 59 + this.NameEqual.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Ip != null)
                    hashCode = hashCode * 59 + this.Ip.GetHashCode();
                return hashCode;
            }
        }
    }
}
