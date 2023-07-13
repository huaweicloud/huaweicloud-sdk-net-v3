using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vod.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowAssetDetailRequest 
    {
        /// <summary>
        /// Defines categories
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<CategoriesEnum>))]
        public class CategoriesEnum
        {
            /// <summary>
            /// Enum BASE_INFO for value: base_info
            /// </summary>
            public static readonly CategoriesEnum BASE_INFO = new CategoriesEnum("base_info");

            /// <summary>
            /// Enum TRANSCODE_INFO for value: transcode_info
            /// </summary>
            public static readonly CategoriesEnum TRANSCODE_INFO = new CategoriesEnum("transcode_info");

            /// <summary>
            /// Enum THUMBNAIL_INFO for value: thumbnail_info
            /// </summary>
            public static readonly CategoriesEnum THUMBNAIL_INFO = new CategoriesEnum("thumbnail_info");

            /// <summary>
            /// Enum REVIEW_INFO for value: review_info
            /// </summary>
            public static readonly CategoriesEnum REVIEW_INFO = new CategoriesEnum("review_info");

            private static readonly Dictionary<string, CategoriesEnum> StaticFields =
            new Dictionary<string, CategoriesEnum>()
            {
                { "base_info", BASE_INFO },
                { "transcode_info", TRANSCODE_INFO },
                { "thumbnail_info", THUMBNAIL_INFO },
                { "review_info", REVIEW_INFO },
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
        /// 使用AK/SK方式认证时必选，请求的发生时间。 
        /// </summary>
        [SDKProperty("X-Sdk-Date", IsHeader = true)]
        [JsonProperty("X-Sdk-Date", NullValueHandling = NullValueHandling.Ignore)]
        public string XSdkDate { get; set; }

        /// <summary>
        /// 媒资ID。
        /// </summary>
        [SDKProperty("asset_id", IsQuery = true)]
        [JsonProperty("asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetId { get; set; }

        /// <summary>
        /// 查询的信息类型。 - 为空时表示查询所有信息。 - 不为空时支持同时查询一个或者多个类型的信息，取值如下： - - base_info：媒资基本信息。 - - transcode_info：转码结果信息。 - - thumbnail_info：截图结果信息。 - - review_info：审核结果信息。
        /// </summary>
        [SDKProperty("categories", IsQuery = true)]
        [JsonProperty("categories", NullValueHandling = NullValueHandling.Ignore)]
        public List<CategoriesEnum> Categories { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAssetDetailRequest {\n");
            sb.Append("  xSdkDate: ").Append(XSdkDate).Append("\n");
            sb.Append("  assetId: ").Append(AssetId).Append("\n");
            sb.Append("  categories: ").Append(Categories).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAssetDetailRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAssetDetailRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.XSdkDate == input.XSdkDate ||
                    (this.XSdkDate != null &&
                    this.XSdkDate.Equals(input.XSdkDate))
                ) && 
                (
                    this.AssetId == input.AssetId ||
                    (this.AssetId != null &&
                    this.AssetId.Equals(input.AssetId))
                ) && 
                (
                    this.Categories == input.Categories ||
                    this.Categories != null &&
                    input.Categories != null &&
                    this.Categories.SequenceEqual(input.Categories)
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
                if (this.XSdkDate != null)
                    hashCode = hashCode * 59 + this.XSdkDate.GetHashCode();
                if (this.AssetId != null)
                    hashCode = hashCode * 59 + this.AssetId.GetHashCode();
                if (this.Categories != null)
                    hashCode = hashCode * 59 + this.Categories.GetHashCode();
                return hashCode;
            }
        }
    }
}
