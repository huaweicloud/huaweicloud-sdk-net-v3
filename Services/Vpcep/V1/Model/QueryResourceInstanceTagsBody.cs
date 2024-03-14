using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpcep.V1.Model
{
    /// <summary>
    /// 查询资源实例接口请求结构体
    /// </summary>
    public class QueryResourceInstanceTagsBody 
    {
        /// <summary>
        /// 操作标识（仅限于filter，count）：filter（过滤）， count(查询总条数)如果是filter就按照过滤条件查询， 如果是count，只需要返回总条数，禁止返回其他字段。
        /// </summary>
        /// <value>操作标识（仅限于filter，count）：filter（过滤）， count(查询总条数)如果是filter就按照过滤条件查询， 如果是count，只需要返回总条数，禁止返回其他字段。</value>
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
        /// 包含标签，最多包含10个key，每个key下面的value最多10个， 每个key对应的value可以为空数组但结构体不能缺失。Key不能重复， 同一个key中values不能重复。结果返回包含所有标签的资源列表， key之间是与的关系，key-value结构中value是或的关系。 无tag过滤条件时返回全量数据。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<TagValuesList> Tags { get; set; }

        /// <summary>
        /// 包含任意标签，最多包含10个key，每个key下面的value最多10个， 每个key对应的value可以为空数组但结构体不能缺失。 Key不能重复，同一个key中values不能重复。 结果返回包含标签的资源列表，key之间是或的关系，key、value结构中value是或的关系。 无过滤条件时返回全量数据。
        /// </summary>
        [JsonProperty("tags_any", NullValueHandling = NullValueHandling.Ignore)]
        public List<TagValuesList> TagsAny { get; set; }

        /// <summary>
        /// 不包含标签，最多包含10个key，每个key下面的value最多10个， 每个key对应的value可以为空数组但结构体不能缺失。Key不能重复， 同一个key中values不能重复。结果返回不包含标签的资源列表，key之间是与的关系， key、value结构中value是或的关系。 无过滤条件时返回全量数据。
        /// </summary>
        [JsonProperty("not_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<TagValuesList> NotTags { get; set; }

        /// <summary>
        /// 不包含任意标签，最多包含10个key，每个key下面的value最多10个， 每个key对应的value可以为空数组但结构体不能缺失。Key不能重复， 同一个key中values不能重复。结果返回不包含标签的资源列表， key之间是与的关系，key、value结构中value是或的关系。 无过滤条件时返回全量数据。
        /// </summary>
        [JsonProperty("not_tags_any", NullValueHandling = NullValueHandling.Ignore)]
        public List<TagValuesList> NotTagsAny { get; set; }

        /// <summary>
        /// 系统标签，
        /// </summary>
        [JsonProperty("sys_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<TagValuesList> SysTags { get; set; }

        /// <summary>
        /// 查询记录数（action为count时无此参数）如果action为filter默认为1000， limit最多为1000，不能为负数，最小值为1。
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public string Limit { get; set; }

        /// <summary>
        /// 索引位置，偏移量（action为count时无此参数）从第一条数据偏移offset条数据后开始查询， 如果action为filter默认为0（偏移0条数据，表示从第一条数据开始查询）， 必须为数字，不能为负数。
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public string Offset { get; set; }

        /// <summary>
        /// 操作标识（仅限于filter，count）：filter（过滤）， count(查询总条数)如果是filter就按照过滤条件查询， 如果是count，只需要返回总条数，禁止返回其他字段。
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public ActionEnum Action { get; set; }
        /// <summary>
        /// 搜索字段，key为要匹配的字段，如resource_name等。value为匹配的值。 key为固定字典值，不能包含重复的key或不支持的key。 根据key的值确认是否需要模糊匹配，如resource_name默认为模糊搜索（不区分大小写）， 如果value为空字符串精确匹配（多数服务不存在资源名称为空的情况， 因此此类情况返回空列表）。resource_id为精确匹配。 第一期只做resource_name，后续再扩展。
        /// </summary>
        [JsonProperty("matches", NullValueHandling = NullValueHandling.Ignore)]
        public List<Match> Matches { get; set; }

        /// <summary>
        /// 默认为false，取值【true/false】,当withoutAnyTag&#x3D;true， 忽略tags、tagsAny、notTags、notTagsAny参数校验。
        /// </summary>
        [JsonProperty("without_any_tag", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WithoutAnyTag { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryResourceInstanceTagsBody {\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  tagsAny: ").Append(TagsAny).Append("\n");
            sb.Append("  notTags: ").Append(NotTags).Append("\n");
            sb.Append("  notTagsAny: ").Append(NotTagsAny).Append("\n");
            sb.Append("  sysTags: ").Append(SysTags).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  action: ").Append(Action).Append("\n");
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
            return this.Equals(input as QueryResourceInstanceTagsBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryResourceInstanceTagsBody input)
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
                    this.SysTags == input.SysTags ||
                    this.SysTags != null &&
                    input.SysTags != null &&
                    this.SysTags.SequenceEqual(input.SysTags)
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
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.Matches == input.Matches ||
                    this.Matches != null &&
                    input.Matches != null &&
                    this.Matches.SequenceEqual(input.Matches)
                ) && 
                (
                    this.WithoutAnyTag == input.WithoutAnyTag ||
                    (this.WithoutAnyTag != null &&
                    this.WithoutAnyTag.Equals(input.WithoutAnyTag))
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
                if (this.SysTags != null)
                    hashCode = hashCode * 59 + this.SysTags.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Matches != null)
                    hashCode = hashCode * 59 + this.Matches.GetHashCode();
                if (this.WithoutAnyTag != null)
                    hashCode = hashCode * 59 + this.WithoutAnyTag.GetHashCode();
                return hashCode;
            }
        }
    }
}
