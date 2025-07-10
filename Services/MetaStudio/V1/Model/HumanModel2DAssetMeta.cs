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
    /// 分身模型元数据
    /// </summary>
    public class HumanModel2DAssetMeta 
    {
        /// <summary>
        /// **参数解释**： 分身数字人模型版本 **约束限制**： 不涉及 **取值范围**： * V2: V2版本模型 * V3：V3版本模型 * V3_2：V3.2版本模型 * V3_3：V3.3版本模型
        /// </summary>
        /// <value>**参数解释**： 分身数字人模型版本 **约束限制**： 不涉及 **取值范围**： * V2: V2版本模型 * V3：V3版本模型 * V3_2：V3.2版本模型 * V3_3：V3.3版本模型</value>
        [JsonConverter(typeof(EnumClassConverter<ModelVersionEnum>))]
        public class ModelVersionEnum
        {
            /// <summary>
            /// Enum V2 for value: V2
            /// </summary>
            public static readonly ModelVersionEnum V2 = new ModelVersionEnum("V2");

            /// <summary>
            /// Enum V3 for value: V3
            /// </summary>
            public static readonly ModelVersionEnum V3 = new ModelVersionEnum("V3");

            /// <summary>
            /// Enum V3_2 for value: V3_2
            /// </summary>
            public static readonly ModelVersionEnum V3_2 = new ModelVersionEnum("V3_2");

            /// <summary>
            /// Enum V3_3 for value: V3_3
            /// </summary>
            public static readonly ModelVersionEnum V3_3 = new ModelVersionEnum("V3_3");

            private static readonly Dictionary<string, ModelVersionEnum> StaticFields =
            new Dictionary<string, ModelVersionEnum>()
            {
                { "V2", V2 },
                { "V3", V3 },
                { "V3_2", V3_2 },
                { "V3_3", V3_3 },
            };

            private string _value;

            public ModelVersionEnum()
            {

            }

            public ModelVersionEnum(string value)
            {
                _value = value;
            }

            public static ModelVersionEnum FromValue(string value)
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

                if (this.Equals(obj as ModelVersionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ModelVersionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ModelVersionEnum a, ModelVersionEnum b)
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

            public static bool operator !=(ModelVersionEnum a, ModelVersionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： 分身数字人的动作是否可编辑 **约束限制**： 不涉及 **取值范围**： * true: 动作可编辑 * false: 动作不可编辑
        /// </summary>
        [JsonProperty("is_action_editable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsActionEditable { get; set; }

        /// <summary>
        /// **参数解释**： 是否是实景分身数字人 **约束限制**： 实景分身数字人不做背景替换。 **取值范围**： * true: 实景分身数字人 * false: 普通分身数字人，不带背景。
        /// </summary>
        [JsonProperty("is_real_background", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsRealBackground { get; set; }

        /// <summary>
        /// **参数解释**： 是否支持直播 **约束限制**： 不涉及 **取值范围**： * true: 支持直播 * false: 不支持直播。
        /// </summary>
        [JsonProperty("support_live", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SupportLive { get; set; }

        /// <summary>
        /// **参数解释**： 分身数字人模型版本 **约束限制**： 不涉及 **取值范围**： * V2: V2版本模型 * V3：V3版本模型 * V3_2：V3.2版本模型 * V3_3：V3.3版本模型
        /// </summary>
        [JsonProperty("model_version", NullValueHandling = NullValueHandling.Ignore)]
        public ModelVersionEnum ModelVersion { get; set; }
        /// <summary>
        /// **参数解释**： 分身数字人模型分辨率。 **约束限制**： 不涉及 **取值范围**： * 1080P：1080P。支持1080P及720P的视频输出。 * 4K：4K。支持4K、1080P及720P的视频输出。
        /// </summary>
        [JsonProperty("model_resolution", NullValueHandling = NullValueHandling.Ignore)]
        public string ModelResolution { get; set; }

        /// <summary>
        /// **参数解释**： 已执行编译任务设备类型列表。 **约束限制**： 支持走动的数字人，当前仅用于视频制作，不能用于直播和智能交互 **取值范围**： 设备名称列表最多16个。 设备名称字符长度1-64位。 **默认取值**： false
        /// </summary>
        [JsonProperty("device_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DeviceNames { get; set; }

        /// <summary>
        /// 分身数字人是否带原子动作库。 &gt; * 带原子动作库的分身数字人可做动作编排。
        /// </summary>
        [JsonProperty("is_with_action_library", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsWithActionLibrary { get; set; }

        /// <summary>
        /// 动作标签映射。
        /// </summary>
        [JsonProperty("action_tag_map", NullValueHandling = NullValueHandling.Ignore)]
        public List<ActionTagInfo> ActionTagMap { get; set; }

        /// <summary>
        /// 是否是Flexus版本分身数字人。
        /// </summary>
        [JsonProperty("is_flexus", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsFlexus { get; set; }

        /// <summary>
        /// 形象关联的声音资产ID。
        /// </summary>
        [JsonProperty("voice_asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VoiceAssetId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HumanModel2DAssetMeta {\n");
            sb.Append("  isActionEditable: ").Append(IsActionEditable).Append("\n");
            sb.Append("  isRealBackground: ").Append(IsRealBackground).Append("\n");
            sb.Append("  supportLive: ").Append(SupportLive).Append("\n");
            sb.Append("  modelVersion: ").Append(ModelVersion).Append("\n");
            sb.Append("  modelResolution: ").Append(ModelResolution).Append("\n");
            sb.Append("  deviceNames: ").Append(DeviceNames).Append("\n");
            sb.Append("  isWithActionLibrary: ").Append(IsWithActionLibrary).Append("\n");
            sb.Append("  actionTagMap: ").Append(ActionTagMap).Append("\n");
            sb.Append("  isFlexus: ").Append(IsFlexus).Append("\n");
            sb.Append("  voiceAssetId: ").Append(VoiceAssetId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HumanModel2DAssetMeta);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HumanModel2DAssetMeta input)
        {
            if (input == null) return false;
            if (this.IsActionEditable != input.IsActionEditable || (this.IsActionEditable != null && !this.IsActionEditable.Equals(input.IsActionEditable))) return false;
            if (this.IsRealBackground != input.IsRealBackground || (this.IsRealBackground != null && !this.IsRealBackground.Equals(input.IsRealBackground))) return false;
            if (this.SupportLive != input.SupportLive || (this.SupportLive != null && !this.SupportLive.Equals(input.SupportLive))) return false;
            if (this.ModelVersion != input.ModelVersion) return false;
            if (this.ModelResolution != input.ModelResolution || (this.ModelResolution != null && !this.ModelResolution.Equals(input.ModelResolution))) return false;
            if (this.DeviceNames != input.DeviceNames || (this.DeviceNames != null && input.DeviceNames != null && !this.DeviceNames.SequenceEqual(input.DeviceNames))) return false;
            if (this.IsWithActionLibrary != input.IsWithActionLibrary || (this.IsWithActionLibrary != null && !this.IsWithActionLibrary.Equals(input.IsWithActionLibrary))) return false;
            if (this.ActionTagMap != input.ActionTagMap || (this.ActionTagMap != null && input.ActionTagMap != null && !this.ActionTagMap.SequenceEqual(input.ActionTagMap))) return false;
            if (this.IsFlexus != input.IsFlexus || (this.IsFlexus != null && !this.IsFlexus.Equals(input.IsFlexus))) return false;
            if (this.VoiceAssetId != input.VoiceAssetId || (this.VoiceAssetId != null && !this.VoiceAssetId.Equals(input.VoiceAssetId))) return false;

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
                if (this.IsActionEditable != null) hashCode = hashCode * 59 + this.IsActionEditable.GetHashCode();
                if (this.IsRealBackground != null) hashCode = hashCode * 59 + this.IsRealBackground.GetHashCode();
                if (this.SupportLive != null) hashCode = hashCode * 59 + this.SupportLive.GetHashCode();
                hashCode = hashCode * 59 + this.ModelVersion.GetHashCode();
                if (this.ModelResolution != null) hashCode = hashCode * 59 + this.ModelResolution.GetHashCode();
                if (this.DeviceNames != null) hashCode = hashCode * 59 + this.DeviceNames.GetHashCode();
                if (this.IsWithActionLibrary != null) hashCode = hashCode * 59 + this.IsWithActionLibrary.GetHashCode();
                if (this.ActionTagMap != null) hashCode = hashCode * 59 + this.ActionTagMap.GetHashCode();
                if (this.IsFlexus != null) hashCode = hashCode * 59 + this.IsFlexus.GetHashCode();
                if (this.VoiceAssetId != null) hashCode = hashCode * 59 + this.VoiceAssetId.GetHashCode();
                return hashCode;
            }
        }
    }
}
