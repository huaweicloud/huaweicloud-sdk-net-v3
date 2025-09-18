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
    /// 智能图层配置。
    /// </summary>
    public class SmartLayerConfig 
    {
        /// <summary>
        /// 图层类型。 - IMAGE： 素材图片图层 - VIDEO： 素材视频图层 - TEXT: 文本图层
        /// </summary>
        /// <value>图层类型。 - IMAGE： 素材图片图层 - VIDEO： 素材视频图层 - TEXT: 文本图层</value>
        [JsonConverter(typeof(EnumClassConverter<LayerTypeEnum>))]
        public class LayerTypeEnum
        {
            /// <summary>
            /// Enum IMAGE for value: IMAGE
            /// </summary>
            public static readonly LayerTypeEnum IMAGE = new LayerTypeEnum("IMAGE");

            /// <summary>
            /// Enum VIDEO for value: VIDEO
            /// </summary>
            public static readonly LayerTypeEnum VIDEO = new LayerTypeEnum("VIDEO");

            /// <summary>
            /// Enum TEXT for value: TEXT
            /// </summary>
            public static readonly LayerTypeEnum TEXT = new LayerTypeEnum("TEXT");

            private static readonly Dictionary<string, LayerTypeEnum> StaticFields =
            new Dictionary<string, LayerTypeEnum>()
            {
                { "IMAGE", IMAGE },
                { "VIDEO", VIDEO },
                { "TEXT", TEXT },
            };

            private string _value;

            public LayerTypeEnum()
            {

            }

            public LayerTypeEnum(string value)
            {
                _value = value;
            }

            public static LayerTypeEnum FromValue(string value)
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

                if (this.Equals(obj as LayerTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(LayerTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(LayerTypeEnum a, LayerTypeEnum b)
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

            public static bool operator !=(LayerTypeEnum a, LayerTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 图层类型。 - IMAGE： 素材图片图层 - VIDEO： 素材视频图层 - TEXT: 文本图层
        /// </summary>
        [JsonProperty("layer_type", NullValueHandling = NullValueHandling.Ignore)]
        public LayerTypeEnum LayerType { get; set; }
        /// <summary>
        /// 图层所需资产的资产id，外部资产信息无需填写
        /// </summary>
        [JsonProperty("asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("position", NullValueHandling = NullValueHandling.Ignore)]
        public LayerPositionConfig Position { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public LayerSizeConfig Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("image_config", NullValueHandling = NullValueHandling.Ignore)]
        public SmartImageLayerConfig ImageConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("video_config", NullValueHandling = NullValueHandling.Ignore)]
        public SmartVideoLayerConfig VideoConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("text_config", NullValueHandling = NullValueHandling.Ignore)]
        public SmartTextLayerConfig TextConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmartLayerConfig {\n");
            sb.Append("  layerType: ").Append(LayerType).Append("\n");
            sb.Append("  assetId: ").Append(AssetId).Append("\n");
            sb.Append("  position: ").Append(Position).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  imageConfig: ").Append(ImageConfig).Append("\n");
            sb.Append("  videoConfig: ").Append(VideoConfig).Append("\n");
            sb.Append("  textConfig: ").Append(TextConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SmartLayerConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SmartLayerConfig input)
        {
            if (input == null) return false;
            if (this.LayerType != input.LayerType) return false;
            if (this.AssetId != input.AssetId || (this.AssetId != null && !this.AssetId.Equals(input.AssetId))) return false;
            if (this.Position != input.Position || (this.Position != null && !this.Position.Equals(input.Position))) return false;
            if (this.Size != input.Size || (this.Size != null && !this.Size.Equals(input.Size))) return false;
            if (this.ImageConfig != input.ImageConfig || (this.ImageConfig != null && !this.ImageConfig.Equals(input.ImageConfig))) return false;
            if (this.VideoConfig != input.VideoConfig || (this.VideoConfig != null && !this.VideoConfig.Equals(input.VideoConfig))) return false;
            if (this.TextConfig != input.TextConfig || (this.TextConfig != null && !this.TextConfig.Equals(input.TextConfig))) return false;

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
                hashCode = hashCode * 59 + this.LayerType.GetHashCode();
                if (this.AssetId != null) hashCode = hashCode * 59 + this.AssetId.GetHashCode();
                if (this.Position != null) hashCode = hashCode * 59 + this.Position.GetHashCode();
                if (this.Size != null) hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.ImageConfig != null) hashCode = hashCode * 59 + this.ImageConfig.GetHashCode();
                if (this.VideoConfig != null) hashCode = hashCode * 59 + this.VideoConfig.GetHashCode();
                if (this.TextConfig != null) hashCode = hashCode * 59 + this.TextConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
