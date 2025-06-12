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
    /// 背景配置。
    /// </summary>
    public class BackgroundConfigInfo 
    {
        /// <summary>
        /// **参数解释**： 背景类型。 **约束限制**： 不涉及。 **取值范围**： * IMAGE：图片背景，指定图片用作分身数字人背景。 * COLOR：纯色背景，指定颜色RGB值作为分身数字人背景。  **默认取值**： 不涉及
        /// </summary>
        /// <value>**参数解释**： 背景类型。 **约束限制**： 不涉及。 **取值范围**： * IMAGE：图片背景，指定图片用作分身数字人背景。 * COLOR：纯色背景，指定颜色RGB值作为分身数字人背景。  **默认取值**： 不涉及</value>
        [JsonConverter(typeof(EnumClassConverter<BackgroundTypeEnum>))]
        public class BackgroundTypeEnum
        {
            /// <summary>
            /// Enum IMAGE for value: IMAGE
            /// </summary>
            public static readonly BackgroundTypeEnum IMAGE = new BackgroundTypeEnum("IMAGE");

            /// <summary>
            /// Enum COLOR for value: COLOR
            /// </summary>
            public static readonly BackgroundTypeEnum COLOR = new BackgroundTypeEnum("COLOR");

            /// <summary>
            /// Enum IMAGE_2D for value: IMAGE_2D
            /// </summary>
            public static readonly BackgroundTypeEnum IMAGE_2D = new BackgroundTypeEnum("IMAGE_2D");

            /// <summary>
            /// Enum VIDEO for value: VIDEO
            /// </summary>
            public static readonly BackgroundTypeEnum VIDEO = new BackgroundTypeEnum("VIDEO");

            /// <summary>
            /// Enum AUDIO for value: AUDIO
            /// </summary>
            public static readonly BackgroundTypeEnum AUDIO = new BackgroundTypeEnum("AUDIO");

            private static readonly Dictionary<string, BackgroundTypeEnum> StaticFields =
            new Dictionary<string, BackgroundTypeEnum>()
            {
                { "IMAGE", IMAGE },
                { "COLOR", COLOR },
                { "IMAGE_2D", IMAGE_2D },
                { "VIDEO", VIDEO },
                { "AUDIO", AUDIO },
            };

            private string _value;

            public BackgroundTypeEnum()
            {

            }

            public BackgroundTypeEnum(string value)
            {
                _value = value;
            }

            public static BackgroundTypeEnum FromValue(string value)
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

                if (this.Equals(obj as BackgroundTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(BackgroundTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(BackgroundTypeEnum a, BackgroundTypeEnum b)
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

            public static bool operator !=(BackgroundTypeEnum a, BackgroundTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： 背景类型。 **约束限制**： 不涉及。 **取值范围**： * IMAGE：图片背景，指定图片用作分身数字人背景。 * COLOR：纯色背景，指定颜色RGB值作为分身数字人背景。  **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("background_type", NullValueHandling = NullValueHandling.Ignore)]
        public BackgroundTypeEnum BackgroundType { get; set; }
        /// <summary>
        /// **参数解释**： 背景文件的URL。 **约束限制**： * 仅直播支持外部URL，其他业务通过资产库查询获取，不支持外部URL。 * background_type&#x3D;IMAGE时需要填写。  **取值范围**： 字符长度1-2048位 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("background_config", NullValueHandling = NullValueHandling.Ignore)]
        public string BackgroundConfig { get; set; }

        /// <summary>
        /// **参数解释**： 纯色背景的RGB颜色值。 **约束限制**： background_type&#x3D;COLOR时需要填写。 **取值范围**： 字符长度0-16位
        /// </summary>
        [JsonProperty("background_color_config", NullValueHandling = NullValueHandling.Ignore)]
        public string BackgroundColorConfig { get; set; }

        /// <summary>
        /// **参数解释**： 背景资产ID。 &gt; 背景是背景图片时，填图片资产ID。  **约束限制**： 不涉及 **取值范围**： 字符长度0-64位 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("background_asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BackgroundAssetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("background_image_config", NullValueHandling = NullValueHandling.Ignore)]
        public BackgroundImageConfig BackgroundImageConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackgroundConfigInfo {\n");
            sb.Append("  backgroundType: ").Append(BackgroundType).Append("\n");
            sb.Append("  backgroundConfig: ").Append(BackgroundConfig).Append("\n");
            sb.Append("  backgroundColorConfig: ").Append(BackgroundColorConfig).Append("\n");
            sb.Append("  backgroundAssetId: ").Append(BackgroundAssetId).Append("\n");
            sb.Append("  backgroundImageConfig: ").Append(BackgroundImageConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BackgroundConfigInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BackgroundConfigInfo input)
        {
            if (input == null) return false;
            if (this.BackgroundType != input.BackgroundType) return false;
            if (this.BackgroundConfig != input.BackgroundConfig || (this.BackgroundConfig != null && !this.BackgroundConfig.Equals(input.BackgroundConfig))) return false;
            if (this.BackgroundColorConfig != input.BackgroundColorConfig || (this.BackgroundColorConfig != null && !this.BackgroundColorConfig.Equals(input.BackgroundColorConfig))) return false;
            if (this.BackgroundAssetId != input.BackgroundAssetId || (this.BackgroundAssetId != null && !this.BackgroundAssetId.Equals(input.BackgroundAssetId))) return false;
            if (this.BackgroundImageConfig != input.BackgroundImageConfig || (this.BackgroundImageConfig != null && !this.BackgroundImageConfig.Equals(input.BackgroundImageConfig))) return false;

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
                hashCode = hashCode * 59 + this.BackgroundType.GetHashCode();
                if (this.BackgroundConfig != null) hashCode = hashCode * 59 + this.BackgroundConfig.GetHashCode();
                if (this.BackgroundColorConfig != null) hashCode = hashCode * 59 + this.BackgroundColorConfig.GetHashCode();
                if (this.BackgroundAssetId != null) hashCode = hashCode * 59 + this.BackgroundAssetId.GetHashCode();
                if (this.BackgroundImageConfig != null) hashCode = hashCode * 59 + this.BackgroundImageConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
