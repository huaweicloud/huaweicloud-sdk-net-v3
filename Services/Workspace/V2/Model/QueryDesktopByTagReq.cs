using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class QueryDesktopByTagReq 
    {

        /// <summary>
        /// 默认为0
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public string Offset { get; set; }

        /// <summary>
        /// 默认为1000
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public string Limit { get; set; }

        /// <summary>
        /// 如果是filter就是分页查询，如果是count只需按照条件将总条数返回即可
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }

        /// <summary>
        /// 包含任意一个标签,该字段为true时查询所有不带标签的资源
        /// </summary>
        [JsonProperty("without_any_tag", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WithoutAnyTag { get; set; }

        /// <summary>
        /// match对象
        /// </summary>
        [JsonProperty("matches", NullValueHandling = NullValueHandling.Ignore)]
        public List<Match> Matches { get; set; }

        /// <summary>
        /// 包含的标签对象，只要有一个不包含，就不符合，一个key对应多个value
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<Tags> Tags { get; set; }

        /// <summary>
        /// 包含任意标签，若全都不包含，不符合，一个key对应多个value
        /// </summary>
        [JsonProperty("tags_any", NullValueHandling = NullValueHandling.Ignore)]
        public List<Tags> TagsAny { get; set; }

        /// <summary>
        /// 不包含标签，只要有一个不包含，就符合了，一个key对应多个value
        /// </summary>
        [JsonProperty("not_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<Tags> NotTags { get; set; }

        /// <summary>
        /// 不包含任意标签，只要包含其中一个，就不符合，一个key对应多个value
        /// </summary>
        [JsonProperty("not_tags_any", NullValueHandling = NullValueHandling.Ignore)]
        public List<Tags> NotTagsAny { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryDesktopByTagReq {\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  withoutAnyTag: ").Append(WithoutAnyTag).Append("\n");
            sb.Append("  matches: ").Append(Matches).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  tagsAny: ").Append(TagsAny).Append("\n");
            sb.Append("  notTags: ").Append(NotTags).Append("\n");
            sb.Append("  notTagsAny: ").Append(NotTagsAny).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryDesktopByTagReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryDesktopByTagReq input)
        {
            if (input == null) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Action != input.Action || (this.Action != null && !this.Action.Equals(input.Action))) return false;
            if (this.WithoutAnyTag != input.WithoutAnyTag || (this.WithoutAnyTag != null && !this.WithoutAnyTag.Equals(input.WithoutAnyTag))) return false;
            if (this.Matches != input.Matches || (this.Matches != null && input.Matches != null && !this.Matches.SequenceEqual(input.Matches))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.TagsAny != input.TagsAny || (this.TagsAny != null && input.TagsAny != null && !this.TagsAny.SequenceEqual(input.TagsAny))) return false;
            if (this.NotTags != input.NotTags || (this.NotTags != null && input.NotTags != null && !this.NotTags.SequenceEqual(input.NotTags))) return false;
            if (this.NotTagsAny != input.NotTagsAny || (this.NotTagsAny != null && input.NotTagsAny != null && !this.NotTagsAny.SequenceEqual(input.NotTagsAny))) return false;

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
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Action != null) hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.WithoutAnyTag != null) hashCode = hashCode * 59 + this.WithoutAnyTag.GetHashCode();
                if (this.Matches != null) hashCode = hashCode * 59 + this.Matches.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.TagsAny != null) hashCode = hashCode * 59 + this.TagsAny.GetHashCode();
                if (this.NotTags != null) hashCode = hashCode * 59 + this.NotTags.GetHashCode();
                if (this.NotTagsAny != null) hashCode = hashCode * 59 + this.NotTagsAny.GetHashCode();
                return hashCode;
            }
        }
    }
}