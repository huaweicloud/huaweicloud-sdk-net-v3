using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.As.V1.Model
{
    /// <summary>
    /// 请求正常
    /// </summary>
    public class ShowTagsRequestBody 
    {
        /// <summary>
        /// 操作标识（仅限filter，count）：filter（过滤）：即分页查询。count（查询总条数）：按照条件将总条数返回即可。
        /// </summary>
        /// <value>操作标识（仅限filter，count）：filter（过滤）：即分页查询。count（查询总条数）：按照条件将总条数返回即可。</value>
        [JsonConverter(typeof(EnumClassConverter<ActionEnum>))]
        public class ActionEnum
        {
            /// <summary>
            /// Enum FILTER for value: filter
            /// </summary>
            public static readonly ActionEnum FILTER = new ActionEnum("filter");

            /// <summary>
            /// Enum COUNT for value: count
            /// </summary>
            public static readonly ActionEnum COUNT = new ActionEnum("count");

            private static readonly Dictionary<string, ActionEnum> StaticFields =
            new Dictionary<string, ActionEnum>()
            {
                { "filter", FILTER },
                { "count", COUNT },
            };

            private string Value;

            public ActionEnum(string value)
            {
                Value = value;
            }

            public static ActionEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as ActionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ActionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(ActionEnum a, ActionEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(ActionEnum a, ActionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 过滤条件，包含标签，最多包含10个Tag，结构体不能缺失。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<TagsMultiValue> Tags { get; set; }

        /// <summary>
        /// 过滤条件，包含任意标签，最多包含10个Tag。
        /// </summary>
        [JsonProperty("tags_any", NullValueHandling = NullValueHandling.Ignore)]
        public List<TagsMultiValue> TagsAny { get; set; }

        /// <summary>
        /// 过滤条件，不包含标签，最多包含10个Tag。
        /// </summary>
        [JsonProperty("not_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<TagsMultiValue> NotTags { get; set; }

        /// <summary>
        /// 过滤条件，不包含任意标签，最多包含10个Tag。
        /// </summary>
        [JsonProperty("not_tags_any", NullValueHandling = NullValueHandling.Ignore)]
        public List<TagsMultiValue> NotTagsAny { get; set; }

        /// <summary>
        /// 查询记录数（action为count时无此参数）如果action为filter默认为1000，limit最多为1000，不能为负数，最小值为1。
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public string Limit { get; set; }

        /// <summary>
        /// 分页位置标识（资源ID或索引位置）。
        /// </summary>
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 操作标识（仅限filter，count）：filter（过滤）：即分页查询。count（查询总条数）：按照条件将总条数返回即可。
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public ActionEnum Action { get; set; }
        /// <summary>
        /// （索引位置），从offset指定的下一条数据开始查询。查询第一页数据时，不需要传入此参数。查询后续页码数据时，将查询前一页数据时，不需要传入此参数。查询后续页码数据时，将查询前一页数据时响应体中的值带入此参数。必须为数字，不能为负数。action：count时，无此参数。action：filter时，默认为0
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public string Offset { get; set; }

        /// <summary>
        /// 模糊搜索字段。
        /// </summary>
        [JsonProperty("matchs", NullValueHandling = NullValueHandling.Ignore)]
        public List<Matches> Matchs { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowTagsRequestBody {\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  tagsAny: ").Append(TagsAny).Append("\n");
            sb.Append("  notTags: ").Append(NotTags).Append("\n");
            sb.Append("  notTagsAny: ").Append(NotTagsAny).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  matchs: ").Append(Matchs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowTagsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowTagsRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.TagsAny == input.TagsAny ||
                    this.TagsAny != null &&
                    input.TagsAny != null &&
                    this.TagsAny.SequenceEqual(input.TagsAny)
                ) && 
                (
                    this.NotTags == input.NotTags ||
                    this.NotTags != null &&
                    input.NotTags != null &&
                    this.NotTags.SequenceEqual(input.NotTags)
                ) && 
                (
                    this.NotTagsAny == input.NotTagsAny ||
                    this.NotTagsAny != null &&
                    input.NotTagsAny != null &&
                    this.NotTagsAny.SequenceEqual(input.NotTagsAny)
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Marker == input.Marker ||
                    (this.Marker != null &&
                    this.Marker.Equals(input.Marker))
                ) && 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && 
                (
                    this.Matchs == input.Matchs ||
                    this.Matchs != null &&
                    input.Matchs != null &&
                    this.Matchs.SequenceEqual(input.Matchs)
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
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.TagsAny != null)
                    hashCode = hashCode * 59 + this.TagsAny.GetHashCode();
                if (this.NotTags != null)
                    hashCode = hashCode * 59 + this.NotTags.GetHashCode();
                if (this.NotTagsAny != null)
                    hashCode = hashCode * 59 + this.NotTagsAny.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Marker != null)
                    hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Matchs != null)
                    hashCode = hashCode * 59 + this.Matchs.GetHashCode();
                return hashCode;
            }
        }
    }
}
