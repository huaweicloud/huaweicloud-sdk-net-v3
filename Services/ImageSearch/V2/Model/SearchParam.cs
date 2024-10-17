using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ImageSearch.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SearchParam 
    {
        /// <summary>
        /// 搜索类型，必须为服务实例支持的搜索类型。服务实例的搜索类型列表可在创建服务实例时进行配置。 &gt; 可以使用枚举名或者枚举值（例如IMAGE/0），枚举值可能会变动，建议使用枚举名。
        /// </summary>
        /// <value>搜索类型，必须为服务实例支持的搜索类型。服务实例的搜索类型列表可在创建服务实例时进行配置。 &gt; 可以使用枚举名或者枚举值（例如IMAGE/0），枚举值可能会变动，建议使用枚举名。</value>
        [JsonConverter(typeof(EnumClassConverter<SearchTypeEnum>))]
        public class SearchTypeEnum
        {
            /// <summary>
            /// Enum IMAGE for value: IMAGE
            /// </summary>
            public static readonly SearchTypeEnum IMAGE = new SearchTypeEnum("IMAGE");

            /// <summary>
            /// Enum KEYWORD for value: KEYWORD
            /// </summary>
            public static readonly SearchTypeEnum KEYWORD = new SearchTypeEnum("KEYWORD");

            /// <summary>
            /// Enum TEXT for value: TEXT
            /// </summary>
            public static readonly SearchTypeEnum TEXT = new SearchTypeEnum("TEXT");

            /// <summary>
            /// Enum CATEGORY for value: CATEGORY
            /// </summary>
            public static readonly SearchTypeEnum CATEGORY = new SearchTypeEnum("CATEGORY");

            private static readonly Dictionary<string, SearchTypeEnum> StaticFields =
            new Dictionary<string, SearchTypeEnum>()
            {
                { "IMAGE", IMAGE },
                { "KEYWORD", KEYWORD },
                { "TEXT", TEXT },
                { "CATEGORY", CATEGORY },
            };

            private string _value;

            public SearchTypeEnum()
            {

            }

            public SearchTypeEnum(string value)
            {
                _value = value;
            }

            public static SearchTypeEnum FromValue(string value)
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

                if (this.Equals(obj as SearchTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SearchTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SearchTypeEnum a, SearchTypeEnum b)
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

            public static bool operator !=(SearchTypeEnum a, SearchTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 搜索类型，必须为服务实例支持的搜索类型。服务实例的搜索类型列表可在创建服务实例时进行配置。 &gt; 可以使用枚举名或者枚举值（例如IMAGE/0），枚举值可能会变动，建议使用枚举名。
        /// </summary>
        [JsonProperty("search_type", NullValueHandling = NullValueHandling.Ignore)]
        public SearchTypeEnum SearchType { get; set; }
        /// <summary>
        /// 返回搜索结果的数量，默认为10，取值范围为[1, 1000]。
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 返回搜索结果的偏移量，即返回序号在[offset, offset+limit]内的搜索结果。默认为0，取值范围为[0, N]。 - 默认情况下，搜索要求offset+limit &lt;&#x3D; 1000。 - 针对支持全量召回的场景，使用全量召回时，要求offset必须为0。
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("last_item", NullValueHandling = NullValueHandling.Ignore)]
        public SearchAfterParam LastItem { get; set; }

        /// <summary>
        /// 返回搜索结果的最小得分，用于对搜索结果进行score过滤，取值范围为[0, 1]。 - 目前仅对IMAGE/CATEGORY搜索类型生效。
        /// </summary>
        [JsonProperty("min_score", NullValueHandling = NullValueHandling.Ignore)]
        public double? MinScore { get; set; }

        /// <summary>
        /// 自定义字符标签，用于对搜索结果进行条件过滤。格式为键值对{key:value}。 - key: 必须为服务实例custom_tags中已存在的key，可在创建服务实例时进行配置，或在更新服务实例时进行新增。 - value: 标签值列表，列表内多个标签值为“或”关系，即满足一个即可。列表长度范围为[1, 32]，标签值类型为字符串，字符长度范围为[1, 64]。
        /// </summary>
        [JsonProperty("custom_tags", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, List<string>> CustomTags { get; set; }

        /// <summary>
        /// 自定义数值标签，用于对搜索结果进行条件过滤。格式为键值对{key:value}。 - key: 必须为服务实例custom_num_tags中已存在的key，可在创建服务实例时进行配置，或在更新服务实例时进行新增。针对没有设置该数值标签的数据，会直接过滤。 - value: 标签值的取值范围，标签值在给定的取值范围内即视为符合条件。
        /// </summary>
        [JsonProperty("custom_num_tags", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, RangeParam> CustomNumTags { get; set; }

        /// <summary>
        /// 图像文件的base64字符串，基于图像搜索时，与image_url二选一。要求如下： - 格式：目前仅支持JPEG/JPG/PNG/BMP/WEBP格式的图像。 - 大小：图像文件大小要求不超过5M。 - 尺寸：默认情况下，要求图像的最短边大于64px，最长边小于4096px。部分服务类型有特殊要求，可参见服务类型说明。 - 其他：图片中不能包含旋转信息。
        /// </summary>
        [JsonProperty("image_base64", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageBase64 { get; set; }

        /// <summary>
        /// 图像文件的服务可访问URL，字符长度范围为[1, 4096]。基于图像搜索时，与image_base64二选一。
        /// </summary>
        [JsonProperty("image_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 关键词列表，搜索时关键词数量范围为[1, 10]，关键词字符长度范围为[1, 64]。使用KEYWORD搜索类型进行搜索时，必须提供该参数。
        /// </summary>
        [JsonProperty("keywords", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Keywords { get; set; }

        /// <summary>
        /// 文本字符串，字符长度范围为[1, 512]。
        /// </summary>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("optional_params", NullValueHandling = NullValueHandling.Ignore)]
        public SearchOptionalParam OptionalParams { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchParam {\n");
            sb.Append("  searchType: ").Append(SearchType).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  lastItem: ").Append(LastItem).Append("\n");
            sb.Append("  minScore: ").Append(MinScore).Append("\n");
            sb.Append("  customTags: ").Append(CustomTags).Append("\n");
            sb.Append("  customNumTags: ").Append(CustomNumTags).Append("\n");
            sb.Append("  imageBase64: ").Append(ImageBase64).Append("\n");
            sb.Append("  imageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  keywords: ").Append(Keywords).Append("\n");
            sb.Append("  text: ").Append(Text).Append("\n");
            sb.Append("  optionalParams: ").Append(OptionalParams).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SearchParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SearchParam input)
        {
            if (input == null) return false;
            if (this.SearchType != input.SearchType) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.LastItem != input.LastItem || (this.LastItem != null && !this.LastItem.Equals(input.LastItem))) return false;
            if (this.MinScore != input.MinScore || (this.MinScore != null && !this.MinScore.Equals(input.MinScore))) return false;
            if (this.CustomTags != input.CustomTags || (this.CustomTags != null && input.CustomTags != null && !this.CustomTags.SequenceEqual(input.CustomTags))) return false;
            if (this.CustomNumTags != input.CustomNumTags || (this.CustomNumTags != null && input.CustomNumTags != null && !this.CustomNumTags.SequenceEqual(input.CustomNumTags))) return false;
            if (this.ImageBase64 != input.ImageBase64 || (this.ImageBase64 != null && !this.ImageBase64.Equals(input.ImageBase64))) return false;
            if (this.ImageUrl != input.ImageUrl || (this.ImageUrl != null && !this.ImageUrl.Equals(input.ImageUrl))) return false;
            if (this.Keywords != input.Keywords || (this.Keywords != null && input.Keywords != null && !this.Keywords.SequenceEqual(input.Keywords))) return false;
            if (this.Text != input.Text || (this.Text != null && !this.Text.Equals(input.Text))) return false;
            if (this.OptionalParams != input.OptionalParams || (this.OptionalParams != null && !this.OptionalParams.Equals(input.OptionalParams))) return false;

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
                hashCode = hashCode * 59 + this.SearchType.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.LastItem != null) hashCode = hashCode * 59 + this.LastItem.GetHashCode();
                if (this.MinScore != null) hashCode = hashCode * 59 + this.MinScore.GetHashCode();
                if (this.CustomTags != null) hashCode = hashCode * 59 + this.CustomTags.GetHashCode();
                if (this.CustomNumTags != null) hashCode = hashCode * 59 + this.CustomNumTags.GetHashCode();
                if (this.ImageBase64 != null) hashCode = hashCode * 59 + this.ImageBase64.GetHashCode();
                if (this.ImageUrl != null) hashCode = hashCode * 59 + this.ImageUrl.GetHashCode();
                if (this.Keywords != null) hashCode = hashCode * 59 + this.Keywords.GetHashCode();
                if (this.Text != null) hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.OptionalParams != null) hashCode = hashCode * 59 + this.OptionalParams.GetHashCode();
                return hashCode;
            }
        }
    }
}
