using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Versatile.V1.Model
{
    /// <summary>
    /// 知识检索请求体。
    /// </summary>
    public class KnowledgeBaseRetrievalReq 
    {
        /// <summary>
        /// **参数解释**： 检索策略模式。  **约束限制**： 不涉及。  **取值范围**： - doc：语义检索。 - keyword：关键词检索。 - mix：混合检索。 - faq：FAQ检索。  **默认取值**： doc。
        /// </summary>
        /// <value>**参数解释**： 检索策略模式。  **约束限制**： 不涉及。  **取值范围**： - doc：语义检索。 - keyword：关键词检索。 - mix：混合检索。 - faq：FAQ检索。  **默认取值**： doc。</value>
        [JsonConverter(typeof(EnumClassConverter<SearchModeEnum>))]
        public class SearchModeEnum
        {
            /// <summary>
            /// Enum DOC for value: doc
            /// </summary>
            public static readonly SearchModeEnum DOC = new SearchModeEnum("doc");

            /// <summary>
            /// Enum KEYWORD for value: keyword
            /// </summary>
            public static readonly SearchModeEnum KEYWORD = new SearchModeEnum("keyword");

            /// <summary>
            /// Enum MIX for value: mix
            /// </summary>
            public static readonly SearchModeEnum MIX = new SearchModeEnum("mix");

            /// <summary>
            /// Enum FAQ for value: faq
            /// </summary>
            public static readonly SearchModeEnum FAQ = new SearchModeEnum("faq");

            private static readonly Dictionary<string, SearchModeEnum> StaticFields =
            new Dictionary<string, SearchModeEnum>()
            {
                { "doc", DOC },
                { "keyword", KEYWORD },
                { "mix", MIX },
                { "faq", FAQ },
            };

            private string _value;

            public SearchModeEnum()
            {

            }

            public SearchModeEnum(string value)
            {
                _value = value;
            }

            public static SearchModeEnum FromValue(string value)
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

                if (this.Equals(obj as SearchModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SearchModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SearchModeEnum a, SearchModeEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(SearchModeEnum a, SearchModeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**： 知识检索结果切片中，对图片标签进行处理和保留的具体方式。  **约束限制**： 该功能要求被检索的知识库本身支持返回图片信息。  **取值范围**： - RETAIN_IMAGE_ID：保留图片ID，格式：{KI|imageId}。 - RETAIN_PLACEHOLDER：保留占位符，格式：{KI|N}，N为序号。 - REMOVE_IMAGE：移除图片（即替换为空字符串）。  **默认取值**： REMOVE_IMAGE。
        /// </summary>
        /// <value>**参数解释**： 知识检索结果切片中，对图片标签进行处理和保留的具体方式。  **约束限制**： 该功能要求被检索的知识库本身支持返回图片信息。  **取值范围**： - RETAIN_IMAGE_ID：保留图片ID，格式：{KI|imageId}。 - RETAIN_PLACEHOLDER：保留占位符，格式：{KI|N}，N为序号。 - REMOVE_IMAGE：移除图片（即替换为空字符串）。  **默认取值**： REMOVE_IMAGE。</value>
        [JsonConverter(typeof(EnumClassConverter<ImageMaskPolicyEnum>))]
        public class ImageMaskPolicyEnum
        {
            /// <summary>
            /// Enum RETAIN_IMAGE_ID for value: RETAIN_IMAGE_ID
            /// </summary>
            public static readonly ImageMaskPolicyEnum RETAIN_IMAGE_ID = new ImageMaskPolicyEnum("RETAIN_IMAGE_ID");

            /// <summary>
            /// Enum RETAIN_PLACEHOLDER for value: RETAIN_PLACEHOLDER
            /// </summary>
            public static readonly ImageMaskPolicyEnum RETAIN_PLACEHOLDER = new ImageMaskPolicyEnum("RETAIN_PLACEHOLDER");

            /// <summary>
            /// Enum REMOVE_IMAGE for value: REMOVE_IMAGE
            /// </summary>
            public static readonly ImageMaskPolicyEnum REMOVE_IMAGE = new ImageMaskPolicyEnum("REMOVE_IMAGE");

            private static readonly Dictionary<string, ImageMaskPolicyEnum> StaticFields =
            new Dictionary<string, ImageMaskPolicyEnum>()
            {
                { "RETAIN_IMAGE_ID", RETAIN_IMAGE_ID },
                { "RETAIN_PLACEHOLDER", RETAIN_PLACEHOLDER },
                { "REMOVE_IMAGE", REMOVE_IMAGE },
            };

            private string _value;

            public ImageMaskPolicyEnum()
            {

            }

            public ImageMaskPolicyEnum(string value)
            {
                _value = value;
            }

            public static ImageMaskPolicyEnum FromValue(string value)
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

                if (this.Equals(obj as ImageMaskPolicyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ImageMaskPolicyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ImageMaskPolicyEnum a, ImageMaskPolicyEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(ImageMaskPolicyEnum a, ImageMaskPolicyEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： 知识库ID列表。  **约束限制**： 最多可同时检索3个知识库。  **取值范围**： 不涉及。  **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("knowledge_base_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> KnowledgeBaseIds { get; set; }

        /// <summary>
        /// **参数解释**： 用户输入的问题或关键词。  **约束限制**： 不涉及。  **取值范围**： 长度 1 至 4096 字符。  **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("query", NullValueHandling = NullValueHandling.Ignore)]
        public string Query { get; set; }

        /// <summary>
        /// **参数解释**： 检索策略模式。  **约束限制**： 不涉及。  **取值范围**： - doc：语义检索。 - keyword：关键词检索。 - mix：混合检索。 - faq：FAQ检索。  **默认取值**： doc。
        /// </summary>
        [JsonProperty("search_mode", NullValueHandling = NullValueHandling.Ignore)]
        public SearchModeEnum SearchMode { get; set; }
        /// <summary>
        /// **参数解释**： 每个知识库最多返回的检索结果数量。  **约束限制**： 若传入小数，系统会默认截断小数部分。  **取值范围**： 1 至 100（含）。  **默认取值**： 10。
        /// </summary>
        [JsonProperty("top_k", NullValueHandling = NullValueHandling.Ignore)]
        public int? TopK { get; set; }

        /// <summary>
        /// **参数解释**： 检索结果的最低相关度得分，低于此值的片段将被过滤。  **约束限制**： 不涉及。  **取值范围**： [0.0, 1.0]，包含两端。  **默认取值**： 0.5。
        /// </summary>
        [JsonProperty("similarity_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public float? SimilarityThreshold { get; set; }

        /// <summary>
        /// **参数解释**： 知识检索结果切片中，对图片标签进行处理和保留的具体方式。  **约束限制**： 该功能要求被检索的知识库本身支持返回图片信息。  **取值范围**： - RETAIN_IMAGE_ID：保留图片ID，格式：{KI|imageId}。 - RETAIN_PLACEHOLDER：保留占位符，格式：{KI|N}，N为序号。 - REMOVE_IMAGE：移除图片（即替换为空字符串）。  **默认取值**： REMOVE_IMAGE。
        /// </summary>
        [JsonProperty("image_mask_policy", NullValueHandling = NullValueHandling.Ignore)]
        public ImageMaskPolicyEnum ImageMaskPolicy { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KnowledgeBaseRetrievalReq {\n");
            sb.Append("  knowledgeBaseIds: ").Append(KnowledgeBaseIds).Append("\n");
            sb.Append("  query: ").Append(Query).Append("\n");
            sb.Append("  searchMode: ").Append(SearchMode).Append("\n");
            sb.Append("  topK: ").Append(TopK).Append("\n");
            sb.Append("  similarityThreshold: ").Append(SimilarityThreshold).Append("\n");
            sb.Append("  imageMaskPolicy: ").Append(ImageMaskPolicy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as KnowledgeBaseRetrievalReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(KnowledgeBaseRetrievalReq input)
        {
            if (input == null) return false;
            if (this.KnowledgeBaseIds != input.KnowledgeBaseIds || (this.KnowledgeBaseIds != null && input.KnowledgeBaseIds != null && !this.KnowledgeBaseIds.SequenceEqual(input.KnowledgeBaseIds))) return false;
            if (this.Query != input.Query || (this.Query != null && !this.Query.Equals(input.Query))) return false;
            if (this.SearchMode != input.SearchMode) return false;
            if (this.TopK != input.TopK || (this.TopK != null && !this.TopK.Equals(input.TopK))) return false;
            if (this.SimilarityThreshold != input.SimilarityThreshold || (this.SimilarityThreshold != null && !this.SimilarityThreshold.Equals(input.SimilarityThreshold))) return false;
            if (this.ImageMaskPolicy != input.ImageMaskPolicy) return false;

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
                if (this.KnowledgeBaseIds != null) hashCode = hashCode * 59 + this.KnowledgeBaseIds.GetHashCode();
                if (this.Query != null) hashCode = hashCode * 59 + this.Query.GetHashCode();
                hashCode = hashCode * 59 + this.SearchMode.GetHashCode();
                if (this.TopK != null) hashCode = hashCode * 59 + this.TopK.GetHashCode();
                if (this.SimilarityThreshold != null) hashCode = hashCode * 59 + this.SimilarityThreshold.GetHashCode();
                hashCode = hashCode * 59 + this.ImageMaskPolicy.GetHashCode();
                return hashCode;
            }
        }
    }
}
