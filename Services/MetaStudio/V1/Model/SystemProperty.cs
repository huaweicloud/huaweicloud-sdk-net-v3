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
    public class SystemProperty 
    {
        /// <summary>
        /// **参数解释**： 操作。 **约束限制**： 系统属性仅为系统设置，普通用户无法修改。 **取值范围**： * ADD：增加 * DELETE：删除  **默认取值**： 不涉及
        /// </summary>
        /// <value>**参数解释**： 操作。 **约束限制**： 系统属性仅为系统设置，普通用户无法修改。 **取值范围**： * ADD：增加 * DELETE：删除  **默认取值**： 不涉及</value>
        [JsonConverter(typeof(EnumClassConverter<ActionEnum>))]
        public class ActionEnum
        {
            /// <summary>
            /// Enum ADD for value: ADD
            /// </summary>
            public static readonly ActionEnum ADD = new ActionEnum("ADD");

            /// <summary>
            /// Enum DELETE for value: DELETE
            /// </summary>
            public static readonly ActionEnum DELETE = new ActionEnum("DELETE");

            private static readonly Dictionary<string, ActionEnum> StaticFields =
            new Dictionary<string, ActionEnum>()
            {
                { "ADD", ADD },
                { "DELETE", DELETE },
            };

            private string _value;

            public ActionEnum()
            {

            }

            public ActionEnum(string value)
            {
                _value = value;
            }

            public static ActionEnum FromValue(string value)
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

                if (this.Equals(obj as ActionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ActionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ActionEnum a, ActionEnum b)
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

            public static bool operator !=(ActionEnum a, ActionEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**： 系统属性条目。 **约束限制**： 系统属性仅为系统设置，普通用户无法修改。 **取值范围**： 公共资产属性： * BACKGROUND_IMG：视频制作的背景图片。value设置成Yes * CREATED_BY_PLATFORM: 是否平台生成。 * BACKGROUND_SCENE：视频制作的2D背景场景。value可选Horizontal（横屏）或者Vertical（竖屏）。 * MEITUAN_MATERIAL_APPROVED: 美团平台已审核标识，value设置成YES。  分身数字人资产属性： * MATERIAL_IMG：素材图片，用作图片图层。value设置成Yes，否则控制台视频制作、直播等界面的贴图区域，将无法看到此图片。 * MATERIAL_VIDEO：素材视频，用作视频图层。value设置成Yes，否则控制台视频制作、直播等界面的视频区域，将无法看到此视频。 * DIGITAL_HUMAN_2D_VIDEO：分身数字人视频。 * BUSINESS_CARD_VIDEO：名片视频。 * BUSSINESS_CARD_VIDEO：名片视频(过期) * PHOTO_VIDEO：照片数字人视频。  **默认取值**： 不涉及
        /// </summary>
        /// <value>**参数解释**： 系统属性条目。 **约束限制**： 系统属性仅为系统设置，普通用户无法修改。 **取值范围**： 公共资产属性： * BACKGROUND_IMG：视频制作的背景图片。value设置成Yes * CREATED_BY_PLATFORM: 是否平台生成。 * BACKGROUND_SCENE：视频制作的2D背景场景。value可选Horizontal（横屏）或者Vertical（竖屏）。 * MEITUAN_MATERIAL_APPROVED: 美团平台已审核标识，value设置成YES。  分身数字人资产属性： * MATERIAL_IMG：素材图片，用作图片图层。value设置成Yes，否则控制台视频制作、直播等界面的贴图区域，将无法看到此图片。 * MATERIAL_VIDEO：素材视频，用作视频图层。value设置成Yes，否则控制台视频制作、直播等界面的视频区域，将无法看到此视频。 * DIGITAL_HUMAN_2D_VIDEO：分身数字人视频。 * BUSINESS_CARD_VIDEO：名片视频。 * BUSSINESS_CARD_VIDEO：名片视频(过期) * PHOTO_VIDEO：照片数字人视频。  **默认取值**： 不涉及</value>
        [JsonConverter(typeof(EnumClassConverter<KeyEnum>))]
        public class KeyEnum
        {
            /// <summary>
            /// Enum STYLE_ID for value: STYLE_ID
            /// </summary>
            public static readonly KeyEnum STYLE_ID = new KeyEnum("STYLE_ID");

            /// <summary>
            /// Enum DH_ID for value: DH_ID
            /// </summary>
            public static readonly KeyEnum DH_ID = new KeyEnum("DH_ID");

            /// <summary>
            /// Enum PLATFORM_AVAILABLE for value: PLATFORM_AVAILABLE
            /// </summary>
            public static readonly KeyEnum PLATFORM_AVAILABLE = new KeyEnum("PLATFORM_AVAILABLE");

            /// <summary>
            /// Enum RENDER_ENGINE for value: RENDER_ENGINE
            /// </summary>
            public static readonly KeyEnum RENDER_ENGINE = new KeyEnum("RENDER_ENGINE");

            /// <summary>
            /// Enum BACKGROUND_IMG for value: BACKGROUND_IMG
            /// </summary>
            public static readonly KeyEnum BACKGROUND_IMG = new KeyEnum("BACKGROUND_IMG");

            /// <summary>
            /// Enum BACKGROUND_SCENE for value: BACKGROUND_SCENE
            /// </summary>
            public static readonly KeyEnum BACKGROUND_SCENE = new KeyEnum("BACKGROUND_SCENE");

            /// <summary>
            /// Enum CREATED_BY_PLATFORM for value: CREATED_BY_PLATFORM
            /// </summary>
            public static readonly KeyEnum CREATED_BY_PLATFORM = new KeyEnum("CREATED_BY_PLATFORM");

            /// <summary>
            /// Enum MATERIAL_IMG for value: MATERIAL_IMG
            /// </summary>
            public static readonly KeyEnum MATERIAL_IMG = new KeyEnum("MATERIAL_IMG");

            /// <summary>
            /// Enum MATERIAL_VIDEO for value: MATERIAL_VIDEO
            /// </summary>
            public static readonly KeyEnum MATERIAL_VIDEO = new KeyEnum("MATERIAL_VIDEO");

            /// <summary>
            /// Enum DIGITAL_HUMAN_2D_VIDEO for value: DIGITAL_HUMAN_2D_VIDEO
            /// </summary>
            public static readonly KeyEnum DIGITAL_HUMAN_2D_VIDEO = new KeyEnum("DIGITAL_HUMAN_2D_VIDEO");

            /// <summary>
            /// Enum DIGITAL_HUMAN_3D_VIDEO for value: DIGITAL_HUMAN_3D_VIDEO
            /// </summary>
            public static readonly KeyEnum DIGITAL_HUMAN_3D_VIDEO = new KeyEnum("DIGITAL_HUMAN_3D_VIDEO");

            /// <summary>
            /// Enum BUSSINESS_CARD_VIDEO for value: BUSSINESS_CARD_VIDEO
            /// </summary>
            public static readonly KeyEnum BUSSINESS_CARD_VIDEO = new KeyEnum("BUSSINESS_CARD_VIDEO");

            /// <summary>
            /// Enum BUSINESS_CARD_VIDEO for value: BUSINESS_CARD_VIDEO
            /// </summary>
            public static readonly KeyEnum BUSINESS_CARD_VIDEO = new KeyEnum("BUSINESS_CARD_VIDEO");

            /// <summary>
            /// Enum PHOTO_VIDEO for value: PHOTO_VIDEO
            /// </summary>
            public static readonly KeyEnum PHOTO_VIDEO = new KeyEnum("PHOTO_VIDEO");

            /// <summary>
            /// Enum TO_BE_TRANSLATED_VIDEO for value: TO_BE_TRANSLATED_VIDEO
            /// </summary>
            public static readonly KeyEnum TO_BE_TRANSLATED_VIDEO = new KeyEnum("TO_BE_TRANSLATED_VIDEO");

            /// <summary>
            /// Enum TRANSLATED_VIDEO for value: TRANSLATED_VIDEO
            /// </summary>
            public static readonly KeyEnum TRANSLATED_VIDEO = new KeyEnum("TRANSLATED_VIDEO");

            /// <summary>
            /// Enum LAYER_CONFIG_ENABLE for value: LAYER_CONFIG_ENABLE
            /// </summary>
            public static readonly KeyEnum LAYER_CONFIG_ENABLE = new KeyEnum("LAYER_CONFIG_ENABLE");

            /// <summary>
            /// Enum MEITUAN_MATERIAL_APPROVED for value: MEITUAN_MATERIAL_APPROVED
            /// </summary>
            public static readonly KeyEnum MEITUAN_MATERIAL_APPROVED = new KeyEnum("MEITUAN_MATERIAL_APPROVED");

            private static readonly Dictionary<string, KeyEnum> StaticFields =
            new Dictionary<string, KeyEnum>()
            {
                { "STYLE_ID", STYLE_ID },
                { "DH_ID", DH_ID },
                { "PLATFORM_AVAILABLE", PLATFORM_AVAILABLE },
                { "RENDER_ENGINE", RENDER_ENGINE },
                { "BACKGROUND_IMG", BACKGROUND_IMG },
                { "BACKGROUND_SCENE", BACKGROUND_SCENE },
                { "CREATED_BY_PLATFORM", CREATED_BY_PLATFORM },
                { "MATERIAL_IMG", MATERIAL_IMG },
                { "MATERIAL_VIDEO", MATERIAL_VIDEO },
                { "DIGITAL_HUMAN_2D_VIDEO", DIGITAL_HUMAN_2D_VIDEO },
                { "DIGITAL_HUMAN_3D_VIDEO", DIGITAL_HUMAN_3D_VIDEO },
                { "BUSSINESS_CARD_VIDEO", BUSSINESS_CARD_VIDEO },
                { "BUSINESS_CARD_VIDEO", BUSINESS_CARD_VIDEO },
                { "PHOTO_VIDEO", PHOTO_VIDEO },
                { "TO_BE_TRANSLATED_VIDEO", TO_BE_TRANSLATED_VIDEO },
                { "TRANSLATED_VIDEO", TRANSLATED_VIDEO },
                { "LAYER_CONFIG_ENABLE", LAYER_CONFIG_ENABLE },
                { "MEITUAN_MATERIAL_APPROVED", MEITUAN_MATERIAL_APPROVED },
            };

            private string _value;

            public KeyEnum()
            {

            }

            public KeyEnum(string value)
            {
                _value = value;
            }

            public static KeyEnum FromValue(string value)
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

                if (this.Equals(obj as KeyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(KeyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(KeyEnum a, KeyEnum b)
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

            public static bool operator !=(KeyEnum a, KeyEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： 操作。 **约束限制**： 系统属性仅为系统设置，普通用户无法修改。 **取值范围**： * ADD：增加 * DELETE：删除  **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public ActionEnum Action { get; set; }
        /// <summary>
        /// **参数解释**： 系统属性条目。 **约束限制**： 系统属性仅为系统设置，普通用户无法修改。 **取值范围**： 公共资产属性： * BACKGROUND_IMG：视频制作的背景图片。value设置成Yes * CREATED_BY_PLATFORM: 是否平台生成。 * BACKGROUND_SCENE：视频制作的2D背景场景。value可选Horizontal（横屏）或者Vertical（竖屏）。 * MEITUAN_MATERIAL_APPROVED: 美团平台已审核标识，value设置成YES。  分身数字人资产属性： * MATERIAL_IMG：素材图片，用作图片图层。value设置成Yes，否则控制台视频制作、直播等界面的贴图区域，将无法看到此图片。 * MATERIAL_VIDEO：素材视频，用作视频图层。value设置成Yes，否则控制台视频制作、直播等界面的视频区域，将无法看到此视频。 * DIGITAL_HUMAN_2D_VIDEO：分身数字人视频。 * BUSINESS_CARD_VIDEO：名片视频。 * BUSSINESS_CARD_VIDEO：名片视频(过期) * PHOTO_VIDEO：照片数字人视频。  **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public KeyEnum Key { get; set; }
        /// <summary>
        /// **参数解释**： 系统属性属性值。 **约束限制**： 系统属性仅为系统设置，普通用户无法修改。 **取值范围**： 字符长度1-1024位 **默认取值** 不涉及
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SystemProperty {\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  key: ").Append(Key).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SystemProperty);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SystemProperty input)
        {
            if (input == null) return false;
            if (this.Action != input.Action) return false;
            if (this.Key != input.Key) return false;
            if (this.Value != input.Value || (this.Value != null && !this.Value.Equals(input.Value))) return false;

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
                hashCode = hashCode * 59 + this.Action.GetHashCode();
                hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }
    }
}
