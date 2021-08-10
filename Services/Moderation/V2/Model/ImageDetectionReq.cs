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
    public class ImageDetectionReq 
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
            /// Enum TERRORISM for value: terrorism
            /// </summary>
            public static readonly CategoriesEnum TERRORISM = new CategoriesEnum("terrorism");

            /// <summary>
            /// Enum PORN for value: porn
            /// </summary>
            public static readonly CategoriesEnum PORN = new CategoriesEnum("porn");

            /// <summary>
            /// Enum AD for value: ad
            /// </summary>
            public static readonly CategoriesEnum AD = new CategoriesEnum("ad");

            /// <summary>
            /// Enum ALL for value: all
            /// </summary>
            public static readonly CategoriesEnum ALL = new CategoriesEnum("all");

            private static readonly Dictionary<string, CategoriesEnum> StaticFields =
            new Dictionary<string, CategoriesEnum>()
            {
                { "politics", POLITICS },
                { "terrorism", TERRORISM },
                { "porn", PORN },
                { "ad", AD },
                { "all", ALL },
            };

            private string Value;

            public CategoriesEnum(string value)
            {
                Value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
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
        /// 与image二选一  图片的URL路径，目前支持：  - 公网HTTP/HTTPS URL  - 华为云OBS提供的URL，使用OBS数据需要进行授权。包括对服务授权、临时授权、匿名公开授权。详请参见[配置OBS访问权限](https://support.huaweicloud.com/api-moderation/moderation_03_0020.html)。   &gt; - 接口响应时间依赖图片的下载时间，如果图片下载时间过长，会返回接口调用失败。请保证被检测图片所在的存储服务稳定可靠，建议您使用华为云OBS存储。 
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// 与url二选一  图片文件Base64编码字符串。要求base64编码后大小不超过10M。  政治人物检测人脸部分不小于50*50像素。  支持JPG/PNG/BMP格式。 
        /// </summary>
        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public byte[] Image { get; set; }

        /// <summary>
        /// 图像审核规则名称，默认使用default规则。  &gt; 审核规则的创建和使用请参见[配置审核规则](https://support.huaweicloud.com/api-moderation/moderation_03_0063.html) 
        /// </summary>
        [JsonProperty("moderation_rule", NullValueHandling = NullValueHandling.Ignore)]
        public string ModerationRule { get; set; }

        /// <summary>
        /// 检测场景:  - politics：是否涉及政治人物的检测。  - terrorism：是否包含涉政暴恐元素的检测。  - porn：是否包含涉黄内容元素的检测。  - ad：是否包含广告的检测（公测特性）。  - all：包含politics、terrorism和porn三种场景的检测。  可通过配置上述场景，来完对应场景元素的检测。  为空或无此参数表示politics和terrorism都检测，但不包含porn场景。  &gt; 每个检测场景的检测次数会分类统计。 
        /// </summary>
        [JsonProperty("categories", NullValueHandling = NullValueHandling.Ignore)]
        public List<CategoriesEnum> Categories { get; set; }
        /// <summary>
        /// 检测场景: ad场景自定义词库，配置方式同文本审核自定义词库配置方式 
        /// </summary>
        [JsonProperty("ad_glossaries", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AdGlossaries { get; set; }

        /// <summary>
        /// 图文审核检测场景。当categories包含ad时，该参数生效。 当前支持的场景有系统场景和用户自定义场景： - 系统场景为：   - qr_code：二维码   - politics：涉政   - porn：涉黄   - ad：广告   - abuse：辱骂   - contraband：违禁品 - 用户自定义场景为：自定义黑名单词库。   &gt; 自定义词库的创建和使用请参见[配置自定义词库](https://support.huaweicloud.com/api-moderation/moderation_03_0020.html)。 
        /// </summary>
        [JsonProperty("ad_categories", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AdCategories { get; set; }

        /// <summary>
        /// - 结果过滤门限，只有置信度不低于此门限的结果才会呈现在detail的列表中，取值范围 0-1，当未设置此值时各个检测场景会使用各自的默认值。  - politics检测场景的默认值为0.95。  - terrorism检测场景的默认值为0。  - ad检测场景的默认值为0。  - 无特殊需求直接不传此参数或像示例中一样值设为空字符串即可。  &gt; - 如果检测场景中的最高置信度也未达到threshold，则结果列表为空；反之threshold过小，则会使结果列表中内容过多。 &gt; - threshold参数不支持porn场景筛选。 &gt; -  threshold参数不会影响响应中的suggestion。 
        /// </summary>
        [JsonProperty("threshold", NullValueHandling = NullValueHandling.Ignore)]
        public float? Threshold { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageDetectionReq {\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  image: ").Append(Image).Append("\n");
            sb.Append("  moderationRule: ").Append(ModerationRule).Append("\n");
            sb.Append("  categories: ").Append(Categories).Append("\n");
            sb.Append("  adGlossaries: ").Append(AdGlossaries).Append("\n");
            sb.Append("  adCategories: ").Append(AdCategories).Append("\n");
            sb.Append("  threshold: ").Append(Threshold).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImageDetectionReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImageDetectionReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
                ) && 
                (
                    this.ModerationRule == input.ModerationRule ||
                    (this.ModerationRule != null &&
                    this.ModerationRule.Equals(input.ModerationRule))
                ) && 
                (
                    this.Categories == input.Categories ||
                    this.Categories != null &&
                    input.Categories != null &&
                    this.Categories.SequenceEqual(input.Categories)
                ) && 
                (
                    this.AdGlossaries == input.AdGlossaries ||
                    this.AdGlossaries != null &&
                    input.AdGlossaries != null &&
                    this.AdGlossaries.SequenceEqual(input.AdGlossaries)
                ) && 
                (
                    this.AdCategories == input.AdCategories ||
                    this.AdCategories != null &&
                    input.AdCategories != null &&
                    this.AdCategories.SequenceEqual(input.AdCategories)
                ) && 
                (
                    this.Threshold == input.Threshold ||
                    (this.Threshold != null &&
                    this.Threshold.Equals(input.Threshold))
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
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Image != null)
                    hashCode = hashCode * 59 + this.Image.GetHashCode();
                if (this.ModerationRule != null)
                    hashCode = hashCode * 59 + this.ModerationRule.GetHashCode();
                if (this.Categories != null)
                    hashCode = hashCode * 59 + this.Categories.GetHashCode();
                if (this.AdGlossaries != null)
                    hashCode = hashCode * 59 + this.AdGlossaries.GetHashCode();
                if (this.AdCategories != null)
                    hashCode = hashCode * 59 + this.AdCategories.GetHashCode();
                if (this.Threshold != null)
                    hashCode = hashCode * 59 + this.Threshold.GetHashCode();
                return hashCode;
            }
        }
    }
}
