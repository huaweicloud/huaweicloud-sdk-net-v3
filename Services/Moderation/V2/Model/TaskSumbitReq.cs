using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Moderation.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class TaskSumbitReq 
    {
        /// <summary>
        /// Defines categories
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<CategoriesEnum>))]
        public class CategoriesEnum
        {
            /// <summary>
            /// Enum POLITICS for value: politics
            /// </summary>
            public static readonly CategoriesEnum POLITICS = new CategoriesEnum("politics");

            /// <summary>
            /// Enum PORN for value: porn
            /// </summary>
            public static readonly CategoriesEnum PORN = new CategoriesEnum("porn");

            /// <summary>
            /// Enum TERRORISM for value: terrorism
            /// </summary>
            public static readonly CategoriesEnum TERRORISM = new CategoriesEnum("terrorism");

            private static readonly Dictionary<string, CategoriesEnum> StaticFields =
            new Dictionary<string, CategoriesEnum>()
            {
                { "politics", POLITICS },
                { "porn", PORN },
                { "terrorism", TERRORISM },
            };

            private string _value;

            public CategoriesEnum()
            {

            }

            public CategoriesEnum(string value)
            {
                _value = value;
            }

            public static CategoriesEnum FromValue(string value)
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

                if (this.Equals(obj as CategoriesEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CategoriesEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CategoriesEnum a, CategoriesEnum b)
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

            public static bool operator !=(CategoriesEnum a, CategoriesEnum b)
            {
                return !(a == b);
            }
        }



        /// <summary>
        /// 图片的URL路径，目前支持： - 公网HTTP/HTTPS URL - 华为云OBS提供的URL，使用OBS数据需要进行授权。包括对服务授权、临时授权、匿名公开授权。详请参见[配置OBS访问权限](https://support.huaweicloud.com/api-moderation/moderation_03_0020.html)。 &gt; 图片的URL路径列表最多支持500个URL地址。接口响应时间依赖图片的下载时间，如果图片下载时间过长，会返回接口调用失败。请保证被检测图片所在的存储服务稳定可靠，建议您使用华为云OBS存储。 
        /// </summary>
        [JsonProperty("urls", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Urls { get; set; }

        /// <summary>
        /// 检测场景。  - politics：是否涉及政治人物的检测。  - terrorism：是否包含涉政敏感人物、涉政暴恐元素的检测。  - porn：是否包含涉黄内容元素的检测。  可通过配置上述场景，来完成对应场景元素的检测。  为空或无此参数时默认检测politics和terrorism(不包含porn)。 
        /// </summary>
        [JsonProperty("categories", NullValueHandling = NullValueHandling.Ignore)]
        public List<CategoriesEnum> Categories { get; set; }
        /// <summary>
        /// 图像审核规则名称，默认使用default规则。 审核规则的创建和使用请参见[配置审核规则](https://support.huaweicloud.com/api-moderation/moderation_03_0063.html)。 
        /// </summary>
        [JsonProperty("moderation_rule", NullValueHandling = NullValueHandling.Ignore)]
        public string ModerationRule { get; set; }

        /// <summary>
        /// 图文审核检测场景。当categories包含ad时，该参数生效。  当前支持的场景有系统场景和用户自定义场景: - 系统场景为：   - qr_code：二维码   - politics：涉政   - porn：涉黄   - ad：广告   - abuse：辱骂   - contraband：违禁品 - 用户自定义场景为：自定义黑名单词库。  自定义词库的创建和使用请参见[配置自定义词库](https://support.huaweicloud.com/api-moderation/moderation_03_0027.html)。 
        /// </summary>
        [JsonProperty("ad_categories", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AdCategories { get; set; }

        /// <summary>
        /// 是否返回ocr识别的结果。
        /// </summary>
        [JsonProperty("show_ocr_text", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowOcrText { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskSumbitReq {\n");
            sb.Append("  urls: ").Append(Urls).Append("\n");
            sb.Append("  categories: ").Append(Categories).Append("\n");
            sb.Append("  moderationRule: ").Append(ModerationRule).Append("\n");
            sb.Append("  adCategories: ").Append(AdCategories).Append("\n");
            sb.Append("  showOcrText: ").Append(ShowOcrText).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TaskSumbitReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TaskSumbitReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Urls == input.Urls ||
                    this.Urls != null &&
                    input.Urls != null &&
                    this.Urls.SequenceEqual(input.Urls)
                ) && 
                (
                    this.Categories == input.Categories ||
                    this.Categories != null &&
                    input.Categories != null &&
                    this.Categories.SequenceEqual(input.Categories)
                ) && 
                (
                    this.ModerationRule == input.ModerationRule ||
                    (this.ModerationRule != null &&
                    this.ModerationRule.Equals(input.ModerationRule))
                ) && 
                (
                    this.AdCategories == input.AdCategories ||
                    this.AdCategories != null &&
                    input.AdCategories != null &&
                    this.AdCategories.SequenceEqual(input.AdCategories)
                ) && 
                (
                    this.ShowOcrText == input.ShowOcrText ||
                    (this.ShowOcrText != null &&
                    this.ShowOcrText.Equals(input.ShowOcrText))
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
                if (this.Urls != null)
                    hashCode = hashCode * 59 + this.Urls.GetHashCode();
                if (this.Categories != null)
                    hashCode = hashCode * 59 + this.Categories.GetHashCode();
                if (this.ModerationRule != null)
                    hashCode = hashCode * 59 + this.ModerationRule.GetHashCode();
                if (this.AdCategories != null)
                    hashCode = hashCode * 59 + this.AdCategories.GetHashCode();
                if (this.ShowOcrText != null)
                    hashCode = hashCode * 59 + this.ShowOcrText.GetHashCode();
                return hashCode;
            }
        }
    }
}
