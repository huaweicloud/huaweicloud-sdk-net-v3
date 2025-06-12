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
    /// 创建资产请求体。
    /// </summary>
    public class CreateDigitalAssetRequestBody 
    {
        /// <summary>
        /// **参数解释**： 资产类型。 **约束限制**： VOICE_MODEL，HUMAN_MODEL_2D 普通用户均无法上传。 **取值范围**： 公共资产类型： * VOICE_MODEL：音色模型 * VIDEO：视频文件 * IMAGE：图片文件 * PPT：幻灯片文件 * MUSIC: 音乐 * AUDIO: 音频 * COMMON_FILE：通用文件  分身数字人资产： * HUMAN_MODEL_2D: 分身数字人模型 * BUSINESS_CARD_TEMPLET: 数字人名片模板  3D数字人资产： * HUMAN_MODEL：3D数字人模型 * SCENE：场景模型 * ANIMATION：动作动画 * MATERIAL：风格化素材 * NORMAL_MODEL: 普通模型。  **默认取值**： 不涉及。
        /// </summary>
        /// <value>**参数解释**： 资产类型。 **约束限制**： VOICE_MODEL，HUMAN_MODEL_2D 普通用户均无法上传。 **取值范围**： 公共资产类型： * VOICE_MODEL：音色模型 * VIDEO：视频文件 * IMAGE：图片文件 * PPT：幻灯片文件 * MUSIC: 音乐 * AUDIO: 音频 * COMMON_FILE：通用文件  分身数字人资产： * HUMAN_MODEL_2D: 分身数字人模型 * BUSINESS_CARD_TEMPLET: 数字人名片模板  3D数字人资产： * HUMAN_MODEL：3D数字人模型 * SCENE：场景模型 * ANIMATION：动作动画 * MATERIAL：风格化素材 * NORMAL_MODEL: 普通模型。  **默认取值**： 不涉及。</value>
        [JsonConverter(typeof(EnumClassConverter<AssetTypeEnum>))]
        public class AssetTypeEnum
        {
            /// <summary>
            /// Enum HUMAN_MODEL for value: HUMAN_MODEL
            /// </summary>
            public static readonly AssetTypeEnum HUMAN_MODEL = new AssetTypeEnum("HUMAN_MODEL");

            /// <summary>
            /// Enum VOICE_MODEL for value: VOICE_MODEL
            /// </summary>
            public static readonly AssetTypeEnum VOICE_MODEL = new AssetTypeEnum("VOICE_MODEL");

            /// <summary>
            /// Enum SCENE for value: SCENE
            /// </summary>
            public static readonly AssetTypeEnum SCENE = new AssetTypeEnum("SCENE");

            /// <summary>
            /// Enum ANIMATION for value: ANIMATION
            /// </summary>
            public static readonly AssetTypeEnum ANIMATION = new AssetTypeEnum("ANIMATION");

            /// <summary>
            /// Enum VIDEO for value: VIDEO
            /// </summary>
            public static readonly AssetTypeEnum VIDEO = new AssetTypeEnum("VIDEO");

            /// <summary>
            /// Enum IMAGE for value: IMAGE
            /// </summary>
            public static readonly AssetTypeEnum IMAGE = new AssetTypeEnum("IMAGE");

            /// <summary>
            /// Enum PPT for value: PPT
            /// </summary>
            public static readonly AssetTypeEnum PPT = new AssetTypeEnum("PPT");

            /// <summary>
            /// Enum MATERIAL for value: MATERIAL
            /// </summary>
            public static readonly AssetTypeEnum MATERIAL = new AssetTypeEnum("MATERIAL");

            /// <summary>
            /// Enum NORMAL_MODEL for value: NORMAL_MODEL
            /// </summary>
            public static readonly AssetTypeEnum NORMAL_MODEL = new AssetTypeEnum("NORMAL_MODEL");

            /// <summary>
            /// Enum COMMON_FILE for value: COMMON_FILE
            /// </summary>
            public static readonly AssetTypeEnum COMMON_FILE = new AssetTypeEnum("COMMON_FILE");

            /// <summary>
            /// Enum HUMAN_MODEL_2D for value: HUMAN_MODEL_2D
            /// </summary>
            public static readonly AssetTypeEnum HUMAN_MODEL_2D = new AssetTypeEnum("HUMAN_MODEL_2D");

            /// <summary>
            /// Enum BUSINESS_CARD_TEMPLET for value: BUSINESS_CARD_TEMPLET
            /// </summary>
            public static readonly AssetTypeEnum BUSINESS_CARD_TEMPLET = new AssetTypeEnum("BUSINESS_CARD_TEMPLET");

            /// <summary>
            /// Enum MUSIC for value: MUSIC
            /// </summary>
            public static readonly AssetTypeEnum MUSIC = new AssetTypeEnum("MUSIC");

            /// <summary>
            /// Enum AUDIO for value: AUDIO
            /// </summary>
            public static readonly AssetTypeEnum AUDIO = new AssetTypeEnum("AUDIO");

            private static readonly Dictionary<string, AssetTypeEnum> StaticFields =
            new Dictionary<string, AssetTypeEnum>()
            {
                { "HUMAN_MODEL", HUMAN_MODEL },
                { "VOICE_MODEL", VOICE_MODEL },
                { "SCENE", SCENE },
                { "ANIMATION", ANIMATION },
                { "VIDEO", VIDEO },
                { "IMAGE", IMAGE },
                { "PPT", PPT },
                { "MATERIAL", MATERIAL },
                { "NORMAL_MODEL", NORMAL_MODEL },
                { "COMMON_FILE", COMMON_FILE },
                { "HUMAN_MODEL_2D", HUMAN_MODEL_2D },
                { "BUSINESS_CARD_TEMPLET", BUSINESS_CARD_TEMPLET },
                { "MUSIC", MUSIC },
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
        /// **参数解释**： 资产名称。 **约束限制**： 不涉及。 **取值范围**： 只能使用中英文字符，字符长度0-256位。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("asset_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetName { get; set; }

        /// <summary>
        /// **参数解释**： 资产描述。 **约束限制**： 不涉及。 **取值范围**： 只能使用中英文字符，字符长度0-4096位。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("asset_description", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetDescription { get; set; }

        /// <summary>
        /// **参数解释**： 资产类型。 **约束限制**： VOICE_MODEL，HUMAN_MODEL_2D 普通用户均无法上传。 **取值范围**： 公共资产类型： * VOICE_MODEL：音色模型 * VIDEO：视频文件 * IMAGE：图片文件 * PPT：幻灯片文件 * MUSIC: 音乐 * AUDIO: 音频 * COMMON_FILE：通用文件  分身数字人资产： * HUMAN_MODEL_2D: 分身数字人模型 * BUSINESS_CARD_TEMPLET: 数字人名片模板  3D数字人资产： * HUMAN_MODEL：3D数字人模型 * SCENE：场景模型 * ANIMATION：动作动画 * MATERIAL：风格化素材 * NORMAL_MODEL: 普通模型。  **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("asset_type", NullValueHandling = NullValueHandling.Ignore)]
        public AssetTypeEnum AssetType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("review_config", NullValueHandling = NullValueHandling.Ignore)]
        public ReviewConfig ReviewConfig { get; set; }

        /// <summary>
        /// **参数解释**： 标签列表。 &gt; 分身形象系统资产的tag定义如下： &gt; - 行业：NEWS,BUSINESS,E_COMMERCE,MARKETING,KNOWLEDGE,EDUCATION,MEDICAL,SPORTS &gt; - 性别：MALE,FEMALE &gt; - 姿势：FULL_BODY,HALF_BODY,STANDING,SITTING,FRONT_PHOTO,SIDE_PHOTO &gt; - 区域：ASIAN,WESTERN,MIDDLE_EASTERNER,AFRICAN,LATINO  **约束限制**： 不涉及 **取值范围**： 标签个数最大为50个。 标签内容为中英文，字符长度0-128位。 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("asset_extra_meta", NullValueHandling = NullValueHandling.Ignore)]
        public AssetExtraMeta AssetExtraMeta { get; set; }

        /// <summary>
        /// **参数解释**： 设置系统属性。内部参数，普通用户无需设置。 **约束限制**： 不涉及 **取值范围**： 个数最大为50个。 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("system_properties", NullValueHandling = NullValueHandling.Ignore)]
        public List<SystemProperty> SystemProperties { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("shared_config", NullValueHandling = NullValueHandling.Ignore)]
        public AssetSharedConfig SharedConfig { get; set; }

        /// <summary>
        /// **参数解释**： 是否需要生成封面。 **约束限制**： 仅用于视频类资产。 **取值范围**： * true：自动生成封面。 * false：不自动生成封面。
        /// </summary>
        [JsonProperty("is_need_generate_cover", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsNeedGenerateCover { get; set; }

        /// <summary>
        /// **参数解释**： 用于console控制台展示顺序。 如果取值相同，则默认最新的排在前面。 **约束限制**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("asset_order", NullValueHandling = NullValueHandling.Ignore)]
        public int? AssetOrder { get; set; }

        /// <summary>
        /// 支持的业务类型。： * VIDEO_2D：分身数字人视频制作 * LIVE_2D：分身数字人直播 * CHAT_2D：分身数字人智能交互
        /// </summary>
        [JsonProperty("supported_service", NullValueHandling = NullValueHandling.Ignore)]
        public List<SupportedServiceEnum> SupportedService { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDigitalAssetRequestBody {\n");
            sb.Append("  assetName: ").Append(AssetName).Append("\n");
            sb.Append("  assetDescription: ").Append(AssetDescription).Append("\n");
            sb.Append("  assetType: ").Append(AssetType).Append("\n");
            sb.Append("  reviewConfig: ").Append(ReviewConfig).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  assetExtraMeta: ").Append(AssetExtraMeta).Append("\n");
            sb.Append("  systemProperties: ").Append(SystemProperties).Append("\n");
            sb.Append("  sharedConfig: ").Append(SharedConfig).Append("\n");
            sb.Append("  isNeedGenerateCover: ").Append(IsNeedGenerateCover).Append("\n");
            sb.Append("  assetOrder: ").Append(AssetOrder).Append("\n");
            sb.Append("  supportedService: ").Append(SupportedService).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateDigitalAssetRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateDigitalAssetRequestBody input)
        {
            if (input == null) return false;
            if (this.AssetName != input.AssetName || (this.AssetName != null && !this.AssetName.Equals(input.AssetName))) return false;
            if (this.AssetDescription != input.AssetDescription || (this.AssetDescription != null && !this.AssetDescription.Equals(input.AssetDescription))) return false;
            if (this.AssetType != input.AssetType) return false;
            if (this.ReviewConfig != input.ReviewConfig || (this.ReviewConfig != null && !this.ReviewConfig.Equals(input.ReviewConfig))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.AssetExtraMeta != input.AssetExtraMeta || (this.AssetExtraMeta != null && !this.AssetExtraMeta.Equals(input.AssetExtraMeta))) return false;
            if (this.SystemProperties != input.SystemProperties || (this.SystemProperties != null && input.SystemProperties != null && !this.SystemProperties.SequenceEqual(input.SystemProperties))) return false;
            if (this.SharedConfig != input.SharedConfig || (this.SharedConfig != null && !this.SharedConfig.Equals(input.SharedConfig))) return false;
            if (this.IsNeedGenerateCover != input.IsNeedGenerateCover || (this.IsNeedGenerateCover != null && !this.IsNeedGenerateCover.Equals(input.IsNeedGenerateCover))) return false;
            if (this.AssetOrder != input.AssetOrder || (this.AssetOrder != null && !this.AssetOrder.Equals(input.AssetOrder))) return false;
            if (this.SupportedService != input.SupportedService || (this.SupportedService != null && input.SupportedService != null && !this.SupportedService.SequenceEqual(input.SupportedService))) return false;

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
                if (this.AssetName != null) hashCode = hashCode * 59 + this.AssetName.GetHashCode();
                if (this.AssetDescription != null) hashCode = hashCode * 59 + this.AssetDescription.GetHashCode();
                hashCode = hashCode * 59 + this.AssetType.GetHashCode();
                if (this.ReviewConfig != null) hashCode = hashCode * 59 + this.ReviewConfig.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.AssetExtraMeta != null) hashCode = hashCode * 59 + this.AssetExtraMeta.GetHashCode();
                if (this.SystemProperties != null) hashCode = hashCode * 59 + this.SystemProperties.GetHashCode();
                if (this.SharedConfig != null) hashCode = hashCode * 59 + this.SharedConfig.GetHashCode();
                if (this.IsNeedGenerateCover != null) hashCode = hashCode * 59 + this.IsNeedGenerateCover.GetHashCode();
                if (this.AssetOrder != null) hashCode = hashCode * 59 + this.AssetOrder.GetHashCode();
                if (this.SupportedService != null) hashCode = hashCode * 59 + this.SupportedService.GetHashCode();
                return hashCode;
            }
        }
    }
}
