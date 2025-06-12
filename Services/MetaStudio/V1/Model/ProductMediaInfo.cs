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
    /// 商品素材信息
    /// </summary>
    public class ProductMediaInfo 
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
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductMediaInfo {\n");
            sb.Append("  assetId: ").Append(AssetId).Append("\n");
            sb.Append("  assetType: ").Append(AssetType).Append("\n");
            sb.Append("  order: ").Append(Order).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProductMediaInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProductMediaInfo input)
        {
            if (input == null) return false;
            if (this.AssetId != input.AssetId || (this.AssetId != null && !this.AssetId.Equals(input.AssetId))) return false;
            if (this.AssetType != input.AssetType) return false;
            if (this.Order != input.Order || (this.Order != null && !this.Order.Equals(input.Order))) return false;

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
                return hashCode;
            }
        }
    }
}
