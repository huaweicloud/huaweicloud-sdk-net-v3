using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// This is a auto create Body Object
    /// </summary>
    public class ListServersByTagRequestBody 
    {

        /// <summary>
        /// 值为filter：表示按标签过滤弹性云服务器，返回符合条件的云服务器列表。
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }

        /// <summary>
        /// 查询返回的云服务器数量限制，最多为1000，不能为负数。  - 如果action的值为count时，此参数无效。 - 如果action的值为filter时，limit必填，取值范围[0-1000]，如果不传值，系统默认limit值为1000。
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public string Limit { get; set; }

        /// <summary>
        /// 偏移量：指定返回记录的开始位置，必须为数字，取值范围为大于或等于0。  查询第一页数据时，可以不传入此参数。  - 如果action的值为count，此参数无效。 - 如果action的值为filter时，必填，如果用户不传值，系统默认offset值为0。
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public string Offset { get; set; }

        /// <summary>
        /// 查询包含所有指定标签的弹性云服务器。  - 最多包含10个key，每个key下面的value最多10个。 - 结构体不能缺失。 - key不能为空或者空字符串。 - key不能重复。 - 同一个key中values不能重复。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<ServerTags> Tags { get; set; }

        /// <summary>
        /// 查询不包含所有指定标签的弹性云服务器。  - 最多包含10个key，每个key下面的value最多10个。 - 结构体不能缺失。 - key不能为空或者空字符串。 - key不能重复。 - 同一个key中values不能重复。
        /// </summary>
        [JsonProperty("not_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<ServerTags> NotTags { get; set; }

        /// <summary>
        /// 搜索字段，用于按条件搜索弹性云服务器。  当前仅支持按resource_name进行搜索
        /// </summary>
        [JsonProperty("matches", NullValueHandling = NullValueHandling.Ignore)]
        public List<ServerTagMatch> Matches { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListServersByTagRequestBody {\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  notTags: ").Append(NotTags).Append("\n");
            sb.Append("  matches: ").Append(Matches).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListServersByTagRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListServersByTagRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
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
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.NotTags == input.NotTags ||
                    this.NotTags != null &&
                    input.NotTags != null &&
                    this.NotTags.SequenceEqual(input.NotTags)
                ) && 
                (
                    this.Matches == input.Matches ||
                    this.Matches != null &&
                    input.Matches != null &&
                    this.Matches.SequenceEqual(input.Matches)
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
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.NotTags != null)
                    hashCode = hashCode * 59 + this.NotTags.GetHashCode();
                if (this.Matches != null)
                    hashCode = hashCode * 59 + this.Matches.GetHashCode();
                return hashCode;
            }
        }
    }
}
