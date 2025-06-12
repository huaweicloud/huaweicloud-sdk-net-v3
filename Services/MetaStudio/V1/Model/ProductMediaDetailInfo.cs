using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ProductMediaDetailInfo 
    {
        /// <summary>
        /// 资产类型 * IMAGE：图片 * VIDEO：视频 * AUDIO：音频
        /// </summary>
        /// <value>资产类型 * IMAGE：图片 * VIDEO：视频 * AUDIO：音频</value>
        [JsonConverter(typeof(EnumClassConverter<AssetTypeEnum>))]
        public class AssetTypeEnum
        {
            /// <summary>
            /// Enum IMAGE for value: IMAGE
            /// </summary>
            public static readonly AssetTypeEnum IMAGE = new AssetTypeEnum("IMAGE");

            /// <summary>
            /// Enum VIDEO for value: VIDEO
            /// </summary>
            public static readonly AssetTypeEnum VIDEO = new AssetTypeEnum("VIDEO");

            /// <summary>
            /// Enum AUDIO for value: AUDIO
            /// </summary>
            public static readonly AssetTypeEnum AUDIO = new AssetTypeEnum("AUDIO");

            private static readonly Dictionary<string, AssetTypeEnum> StaticFields =
            new Dictionary<string, AssetTypeEnum>()
            {
                { "IMAGE", IMAGE },
                { "VIDEO", VIDEO },
                { "AUDIO", AUDIO },
            };

            private string _value;

            public AssetTypeEnum()
            {

            }

            public AssetTypeEnum(string value)
            {
                _value = value;
            }

            public static AssetTypeEnum FromValue(string value)
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

                if (this.Equals(obj as AssetTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AssetTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AssetTypeEnum a, AssetTypeEnum b)
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

            public static bool operator !=(AssetTypeEnum a, AssetTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 资产ID
        /// </summary>
        [JsonProperty("asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetId { get; set; }

        /// <summary>
        /// 资产类型 * IMAGE：图片 * VIDEO：视频 * AUDIO：音频
        /// </summary>
        [JsonProperty("asset_type", NullValueHandling = NullValueHandling.Ignore)]
        public AssetTypeEnum AssetType { get; set; }
        /// <summary>
        /// **参数解释**： 资产次序。不设置或者0表示按照加入时间先后排序。业务上将次序最靠前的图片设置为商品封面。
        /// </summary>
        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public int? Order { get; set; }

        /// <summary>
        /// 资产名称。
        /// </summary>
        [JsonProperty("asset_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetName { get; set; }

        /// <summary>
        /// 资产状态。
        /// </summary>
        [JsonProperty("asset_state", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetState { get; set; }

        /// <summary>
        /// 封面图片路径。
        /// </summary>
        [JsonProperty("cover_url", NullValueHandling = NullValueHandling.Ignore)]
        public string CoverUrl { get; set; }

        /// <summary>
        /// 缩略图路径。
        /// </summary>
        [JsonProperty("thumbnail_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ThumbnailUrl { get; set; }

        /// <summary>
        /// 缩略图路径。
        /// </summary>
        [JsonProperty("main_url", NullValueHandling = NullValueHandling.Ignore)]
        public string MainUrl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductMediaDetailInfo {\n");
            sb.Append("  assetId: ").Append(AssetId).Append("\n");
            sb.Append("  assetType: ").Append(AssetType).Append("\n");
            sb.Append("  order: ").Append(Order).Append("\n");
            sb.Append("  assetName: ").Append(AssetName).Append("\n");
            sb.Append("  assetState: ").Append(AssetState).Append("\n");
            sb.Append("  coverUrl: ").Append(CoverUrl).Append("\n");
            sb.Append("  thumbnailUrl: ").Append(ThumbnailUrl).Append("\n");
            sb.Append("  mainUrl: ").Append(MainUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProductMediaDetailInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProductMediaDetailInfo input)
        {
            if (input == null) return false;
            if (this.AssetId != input.AssetId || (this.AssetId != null && !this.AssetId.Equals(input.AssetId))) return false;
            if (this.AssetType != input.AssetType) return false;
            if (this.Order != input.Order || (this.Order != null && !this.Order.Equals(input.Order))) return false;
            if (this.AssetName != input.AssetName || (this.AssetName != null && !this.AssetName.Equals(input.AssetName))) return false;
            if (this.AssetState != input.AssetState || (this.AssetState != null && !this.AssetState.Equals(input.AssetState))) return false;
            if (this.CoverUrl != input.CoverUrl || (this.CoverUrl != null && !this.CoverUrl.Equals(input.CoverUrl))) return false;
            if (this.ThumbnailUrl != input.ThumbnailUrl || (this.ThumbnailUrl != null && !this.ThumbnailUrl.Equals(input.ThumbnailUrl))) return false;
            if (this.MainUrl != input.MainUrl || (this.MainUrl != null && !this.MainUrl.Equals(input.MainUrl))) return false;

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
                if (this.AssetId != null) hashCode = hashCode * 59 + this.AssetId.GetHashCode();
                hashCode = hashCode * 59 + this.AssetType.GetHashCode();
                if (this.Order != null) hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.AssetName != null) hashCode = hashCode * 59 + this.AssetName.GetHashCode();
                if (this.AssetState != null) hashCode = hashCode * 59 + this.AssetState.GetHashCode();
                if (this.CoverUrl != null) hashCode = hashCode * 59 + this.CoverUrl.GetHashCode();
                if (this.ThumbnailUrl != null) hashCode = hashCode * 59 + this.ThumbnailUrl.GetHashCode();
                if (this.MainUrl != null) hashCode = hashCode * 59 + this.MainUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
