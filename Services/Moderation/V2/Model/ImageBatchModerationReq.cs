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
    public class ImageBatchModerationReq 
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
        /// 图片的URL路径，目前支持： - 公网HTTP/HTTPS URL - 华为云OBS提供的URL，使用OBS数据需要进行授权。包括对服务授权、临时授权、匿名公开授权。详请参见[配置OBS访问权限](https://support.huaweicloud.com/api-moderation/moderation_03_0020.html)。 &gt; 图片的URL路径列表最多支持10个URL地址。接口响应时间依赖图片的下载时间，如果图片下载时间过长，会返回接口调用失败。请保证被检测图片所在的存储服务稳定可靠，建议您使用华为云OBS存储。 
        /// </summary>
        [JsonProperty("urls", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Urls { get; set; }

        /// <summary>
        /// 请参见[表1](https://support.huaweicloud.com/api-moderation/moderation_03_0019.html#moderation_03_0019__zh-cn_topic_0087142444_table2693546819540)中categories参数说明。
        /// </summary>
        [JsonProperty("categories", NullValueHandling = NullValueHandling.Ignore)]
        public List<CategoriesEnum> Categories { get; set; }
        /// <summary>
        /// 请参见[表1](https://support.huaweicloud.com/api-moderation/moderation_03_0019.html#moderation_03_0019__zh-cn_topic_0087142444_table2693546819540)中threshold参数说明。
        /// </summary>
        [JsonProperty("threshold", NullValueHandling = NullValueHandling.Ignore)]
        public double? Threshold { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageBatchModerationReq {\n");
            sb.Append("  urls: ").Append(Urls).Append("\n");
            sb.Append("  categories: ").Append(Categories).Append("\n");
            sb.Append("  threshold: ").Append(Threshold).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImageBatchModerationReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImageBatchModerationReq input)
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
                if (this.Urls != null)
                    hashCode = hashCode * 59 + this.Urls.GetHashCode();
                if (this.Categories != null)
                    hashCode = hashCode * 59 + this.Categories.GetHashCode();
                if (this.Threshold != null)
                    hashCode = hashCode * 59 + this.Threshold.GetHashCode();
                return hashCode;
            }
        }
    }
}
