using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Tms.V1.Model
{
    /// <summary>
    /// 获取标签下资源请求
    /// </summary>
    public class ResqTagResource 
    {

        /// <summary>
        /// 项目ID，resource_type为region级别服务时为必选项。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 资源类型， 此参数为可输入的值（区分大小写）。例如：ecs,scaling_group, images, disk,vpcs,security-groups, shared_bandwidth,eip, cdn等，具体请参见“附录-标签支持的资源类型”章节。
        /// </summary>
        [JsonProperty("resource_types", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ResourceTypes { get; set; }

        /// <summary>
        /// 标签列表
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// 是否仅查询未带标签的资源。该字段为true时查询不带标签的资源。
        /// </summary>
        [JsonProperty("without_any_tag", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WithoutAnyTag { get; set; }

        /// <summary>
        /// 索引位置， 从offset指定的下一条数据开始查询，必须为数字，不能为负数，默认为0。
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 查询记录数，不传默认为200，limit最多为200, 最小值为1。
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResqTagResource {\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  resourceTypes: ").Append(ResourceTypes).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  withoutAnyTag: ").Append(WithoutAnyTag).Append("\n");
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
            return this.Equals(input as ResqTagResource);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResqTagResource input)
        {
            if (input == null) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.ResourceTypes != input.ResourceTypes || (this.ResourceTypes != null && input.ResourceTypes != null && !this.ResourceTypes.SequenceEqual(input.ResourceTypes))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.WithoutAnyTag != input.WithoutAnyTag || (this.WithoutAnyTag != null && !this.WithoutAnyTag.Equals(input.WithoutAnyTag))) return false;
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
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ResourceTypes != null) hashCode = hashCode * 59 + this.ResourceTypes.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.WithoutAnyTag != null) hashCode = hashCode * 59 + this.WithoutAnyTag.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
