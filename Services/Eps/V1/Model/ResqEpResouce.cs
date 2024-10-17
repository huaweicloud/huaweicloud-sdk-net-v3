using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eps.V1.Model
{
    /// <summary>
    /// 获取企业项目下资源请求
    /// </summary>
    public class ResqEpResouce 
    {

        /// <summary>
        /// 项目ID列表。resource_types中包含region级别服务时为必选项。
        /// </summary>
        [JsonProperty("projects", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Projects { get; set; }

        /// <summary>
        /// 资源类型列表， 此参数为可输入的值（区分大小写）。例如：ecs,scaling_group, images, disk, vpcs,security-groups, shared_bandwidth, eip, cdn等。
        /// </summary>
        [JsonProperty("resource_types", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ResourceTypes { get; set; }

        /// <summary>
        /// 索引位置， 从offset指定的下一条数据开始查询，必须为数字，不能为负数，默认为0。
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 查询记录数，不传默认为1000，limit最多为1000, 最小值为1。
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 搜索字段，key为要匹配的字段，固定为resource_name，value为匹配的值，不传则表示无匹配条件。
        /// </summary>
        [JsonProperty("matches", NullValueHandling = NullValueHandling.Ignore)]
        public List<Match> Matches { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResqEpResouce {\n");
            sb.Append("  projects: ").Append(Projects).Append("\n");
            sb.Append("  resourceTypes: ").Append(ResourceTypes).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  matches: ").Append(Matches).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResqEpResouce);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResqEpResouce input)
        {
            if (input == null) return false;
            if (this.Projects != input.Projects || (this.Projects != null && input.Projects != null && !this.Projects.SequenceEqual(input.Projects))) return false;
            if (this.ResourceTypes != input.ResourceTypes || (this.ResourceTypes != null && input.ResourceTypes != null && !this.ResourceTypes.SequenceEqual(input.ResourceTypes))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Matches != input.Matches || (this.Matches != null && input.Matches != null && !this.Matches.SequenceEqual(input.Matches))) return false;

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
                if (this.Projects != null) hashCode = hashCode * 59 + this.Projects.GetHashCode();
                if (this.ResourceTypes != null) hashCode = hashCode * 59 + this.ResourceTypes.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Matches != null) hashCode = hashCode * 59 + this.Matches.GetHashCode();
                return hashCode;
            }
        }
    }
}
