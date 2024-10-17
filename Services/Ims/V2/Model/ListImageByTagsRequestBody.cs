using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ims.V2.Model
{
    /// <summary>
    /// 请求参数
    /// </summary>
    public class ListImageByTagsRequestBody 
    {
        /// <summary>
        /// 操作标识（区分大小写），支持filter、count。filter就是分页查询；count是只需按照条件将总条数返回即可。
        /// </summary>
        /// <value>操作标识（区分大小写），支持filter、count。filter就是分页查询；count是只需按照条件将总条数返回即可。</value>
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

            private string _value;

            public ActionEnum()
            {

            }

            public ActionEnum(string value)
            {
                _value = value;
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
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
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
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
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
        /// 操作标识（区分大小写），支持filter、count。filter就是分页查询；count是只需按照条件将总条数返回即可。
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public ActionEnum Action { get; set; }
        /// <summary>
        /// 包含标签，最多包含10个key，每个key对应的values最多包含10个值，且key和values都不能重复。不能为空列表。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<Tags> Tags { get; set; }

        /// <summary>
        /// 包含任意标签，最多包含10个key，每个key对应的values最多包含10个值，且key和values都不能重复。不允许为空列表，但可以不传递参数。
        /// </summary>
        [JsonProperty("tags_any", NullValueHandling = NullValueHandling.Ignore)]
        public List<Tags> TagsAny { get; set; }

        /// <summary>
        /// 不包含标签，最多包含10个key，每个key对应的values最多包含10个值，且key和values都不能重复。不能为空列表。
        /// </summary>
        [JsonProperty("not_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<Tags> NotTags { get; set; }

        /// <summary>
        /// 不包含任意标签，最多包含10个key，每个key对应的values最多包含10个值，且key和values都不能重复。不能为空列表。
        /// </summary>
        [JsonProperty("not_tags_any", NullValueHandling = NullValueHandling.Ignore)]
        public List<Tags> NotTagsAny { get; set; }

        /// <summary>
        /// 最大查询记录数(action为count，时此参数无效）如果action为filter默认为10，limit最多为1000，不能为负数，最小值为1。
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public string Limit { get; set; }

        /// <summary>
        /// 索引位置， 从offset指定的下一条数据开始查询。 查询第一页数据时，不需要传入此参数（action为count时，此参数无效），如果action为filter默认为0，不能为负数。
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public string Offset { get; set; }

        /// <summary>
        /// 搜索字段，key为要匹配的字段，如resource_name、resource_id等。value为匹配的值。多个matches的key不允许重复。不允许为空列表，但可以不传递参数。
        /// </summary>
        [JsonProperty("matches", NullValueHandling = NullValueHandling.Ignore)]
        public List<TagKeyValue> Matches { get; set; }

        /// <summary>
        /// 不包含任意一个标签，该字段为true时查询所有不带标签的资源，此时忽略tag、not_tags、tags_any、not_tags_any字段。
        /// </summary>
        [JsonProperty("without_any_tag", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WithoutAnyTag { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListImageByTagsRequestBody {\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  tagsAny: ").Append(TagsAny).Append("\n");
            sb.Append("  notTags: ").Append(NotTags).Append("\n");
            sb.Append("  notTagsAny: ").Append(NotTagsAny).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  matches: ").Append(Matches).Append("\n");
            sb.Append("  withoutAnyTag: ").Append(WithoutAnyTag).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListImageByTagsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListImageByTagsRequestBody input)
        {
            if (input == null) return false;
            if (this.Action != input.Action) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.TagsAny != input.TagsAny || (this.TagsAny != null && input.TagsAny != null && !this.TagsAny.SequenceEqual(input.TagsAny))) return false;
            if (this.NotTags != input.NotTags || (this.NotTags != null && input.NotTags != null && !this.NotTags.SequenceEqual(input.NotTags))) return false;
            if (this.NotTagsAny != input.NotTagsAny || (this.NotTagsAny != null && input.NotTagsAny != null && !this.NotTagsAny.SequenceEqual(input.NotTagsAny))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Matches != input.Matches || (this.Matches != null && input.Matches != null && !this.Matches.SequenceEqual(input.Matches))) return false;
            if (this.WithoutAnyTag != input.WithoutAnyTag || (this.WithoutAnyTag != null && !this.WithoutAnyTag.Equals(input.WithoutAnyTag))) return false;

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
                hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.TagsAny != null) hashCode = hashCode * 59 + this.TagsAny.GetHashCode();
                if (this.NotTags != null) hashCode = hashCode * 59 + this.NotTags.GetHashCode();
                if (this.NotTagsAny != null) hashCode = hashCode * 59 + this.NotTagsAny.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Matches != null) hashCode = hashCode * 59 + this.Matches.GetHashCode();
                if (this.WithoutAnyTag != null) hashCode = hashCode * 59 + this.WithoutAnyTag.GetHashCode();
                return hashCode;
            }
        }
    }
}
