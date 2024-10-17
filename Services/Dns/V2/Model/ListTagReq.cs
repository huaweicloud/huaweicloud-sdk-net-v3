using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dns.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ListTagReq 
    {

        /// <summary>
        /// 包含标签。 最多包含10个key，每个key下面的value最多10个，结构体不能缺失，key不能为空或者空字符串。Key不能重复，同一个key中values不能重复。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<TagValues> Tags { get; set; }

        /// <summary>
        /// 最多包含10个key，每个key下面的value最多10个，结构体不能缺失，key不能为空或者空字符串。Key不能重复，同一个key中values不能重复。
        /// </summary>
        [JsonProperty("tags_any", NullValueHandling = NullValueHandling.Ignore)]
        public List<TagValues> TagsAny { get; set; }

        /// <summary>
        /// 最多包含10个key，每个key下面的value最多10个，结构体不能缺失，key不能为空或者空字符串。Key不能重复，同一个key中values不能重复。
        /// </summary>
        [JsonProperty("not_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<TagValues> NotTags { get; set; }

        /// <summary>
        /// 最多包含10个key，每个key下面的value最多10个，结构体不能缺失，key不能为空或者空字符串。Key不能重复，同一个key中values不能重复。
        /// </summary>
        [JsonProperty("not_tags_any", NullValueHandling = NullValueHandling.Ignore)]
        public List<TagValues> NotTagsAny { get; set; }

        /// <summary>
        /// 每页返回的资源个数。  取值范围：1~1000  参数取值说明：  如果action为filter时，默认为1000。 如果action为count时，无此参数。
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 分页查询起始偏移量，表示从偏移量的下一个资源开始查询。  取值范围：0~2147483647  默认值为0。  参数取值说明： 查询第一页数据时，不需要传入此参数。 查询后续页码数据时，将查询前一页数据时响应体中的值带入此参数。 如果action为filter时，默认为0，必须为数字，不能为负数。 如果action为count时，无此参数。
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 操作标识（区分大小写）。  取值范围：  filter：分页过滤查询 count：查询总条数
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }

        /// <summary>
        /// key为要匹配的字段，value为匹配的值。  如果value为空字符串则精确匹配，否则模糊匹配。
        /// </summary>
        [JsonProperty("matches", NullValueHandling = NullValueHandling.Ignore)]
        public List<Match> Matches { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTagReq {\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  tagsAny: ").Append(TagsAny).Append("\n");
            sb.Append("  notTags: ").Append(NotTags).Append("\n");
            sb.Append("  notTagsAny: ").Append(NotTagsAny).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  matches: ").Append(Matches).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTagReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTagReq input)
        {
            if (input == null) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.TagsAny != input.TagsAny || (this.TagsAny != null && input.TagsAny != null && !this.TagsAny.SequenceEqual(input.TagsAny))) return false;
            if (this.NotTags != input.NotTags || (this.NotTags != null && input.NotTags != null && !this.NotTags.SequenceEqual(input.NotTags))) return false;
            if (this.NotTagsAny != input.NotTagsAny || (this.NotTagsAny != null && input.NotTagsAny != null && !this.NotTagsAny.SequenceEqual(input.NotTagsAny))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Action != input.Action || (this.Action != null && !this.Action.Equals(input.Action))) return false;
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
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.TagsAny != null) hashCode = hashCode * 59 + this.TagsAny.GetHashCode();
                if (this.NotTags != null) hashCode = hashCode * 59 + this.NotTags.GetHashCode();
                if (this.NotTagsAny != null) hashCode = hashCode * 59 + this.NotTagsAny.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Action != null) hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Matches != null) hashCode = hashCode * 59 + this.Matches.GetHashCode();
                return hashCode;
            }
        }
    }
}
