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
    /// 数字人模型元数据。
    /// </summary>
    public class HumanModelAssetMeta 
    {
        /// <summary>
        /// **参数解释**： 数字人模型建模类型。 **约束限制**： 不涉及 **取值范围**： * UPLOADED：租户上传的模型 * PICTURE_MODELING：照片建模生成的模型 * CHARACTER_CUSTOMIZATION_MODELING：捏脸生成的模型
        /// </summary>
        /// <value>**参数解释**： 数字人模型建模类型。 **约束限制**： 不涉及 **取值范围**： * UPLOADED：租户上传的模型 * PICTURE_MODELING：照片建模生成的模型 * CHARACTER_CUSTOMIZATION_MODELING：捏脸生成的模型</value>
        [JsonConverter(typeof(EnumClassConverter<ModelingTypeEnum>))]
        public class ModelingTypeEnum
        {
            /// <summary>
            /// Enum UPLOADED for value: UPLOADED
            /// </summary>
            public static readonly ModelingTypeEnum UPLOADED = new ModelingTypeEnum("UPLOADED");

            /// <summary>
            /// Enum PICTURE_MODELING for value: PICTURE_MODELING
            /// </summary>
            public static readonly ModelingTypeEnum PICTURE_MODELING = new ModelingTypeEnum("PICTURE_MODELING");

            /// <summary>
            /// Enum CHARACTER_CUSTOMIZATION_MODELING for value: CHARACTER_CUSTOMIZATION_MODELING
            /// </summary>
            public static readonly ModelingTypeEnum CHARACTER_CUSTOMIZATION_MODELING = new ModelingTypeEnum("CHARACTER_CUSTOMIZATION_MODELING");

            private static readonly Dictionary<string, ModelingTypeEnum> StaticFields =
            new Dictionary<string, ModelingTypeEnum>()
            {
                { "UPLOADED", UPLOADED },
                { "PICTURE_MODELING", PICTURE_MODELING },
                { "CHARACTER_CUSTOMIZATION_MODELING", CHARACTER_CUSTOMIZATION_MODELING },
            };

            private string _value;

            public ModelingTypeEnum()
            {

            }

            public ModelingTypeEnum(string value)
            {
                _value = value;
            }

            public static ModelingTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ModelingTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ModelingTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ModelingTypeEnum a, ModelingTypeEnum b)
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

            public static bool operator !=(ModelingTypeEnum a, ModelingTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： 数字人模型风格ID。 **约束限制**： 当前仅支持系统提供的几种风格。 **取值范围**： * system_male_001：男性风格01 * system_female_001：女性风格01 * system_male_002：男性风格02  * system_female_002：女性风格02  **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("style_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StyleId { get; set; }

        /// <summary>
        /// **参数解释**： 数字人模型建模类型。 **约束限制**： 不涉及 **取值范围**： * UPLOADED：租户上传的模型 * PICTURE_MODELING：照片建模生成的模型 * CHARACTER_CUSTOMIZATION_MODELING：捏脸生成的模型
        /// </summary>
        [JsonProperty("modeling_type", NullValueHandling = NullValueHandling.Ignore)]
        public ModelingTypeEnum ModelingType { get; set; }
        /// <summary>
        /// **参数解释**： 建模任务ID。 **约束限制**： 仅由MetaStudio服务生成的模型系统自行填写 **取值范围**： 字符长度0-64位。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("modeling_job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ModelingJobId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("model_properties", NullValueHandling = NullValueHandling.Ignore)]
        public HumanModelMetaProperties ModelProperties { get; set; }

        /// <summary>
        /// 可替换组件列表。
        /// </summary>
        [JsonProperty("components", NullValueHandling = NullValueHandling.Ignore)]
        public List<ComponentInfo> Components { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HumanModelAssetMeta {\n");
            sb.Append("  styleId: ").Append(StyleId).Append("\n");
            sb.Append("  modelingType: ").Append(ModelingType).Append("\n");
            sb.Append("  modelingJobId: ").Append(ModelingJobId).Append("\n");
            sb.Append("  modelProperties: ").Append(ModelProperties).Append("\n");
            sb.Append("  components: ").Append(Components).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HumanModelAssetMeta);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HumanModelAssetMeta input)
        {
            if (input == null) return false;
            if (this.StyleId != input.StyleId || (this.StyleId != null && !this.StyleId.Equals(input.StyleId))) return false;
            if (this.ModelingType != input.ModelingType) return false;
            if (this.ModelingJobId != input.ModelingJobId || (this.ModelingJobId != null && !this.ModelingJobId.Equals(input.ModelingJobId))) return false;
            if (this.ModelProperties != input.ModelProperties || (this.ModelProperties != null && !this.ModelProperties.Equals(input.ModelProperties))) return false;
            if (this.Components != input.Components || (this.Components != null && input.Components != null && !this.Components.SequenceEqual(input.Components))) return false;

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
                if (this.StyleId != null) hashCode = hashCode * 59 + this.StyleId.GetHashCode();
                hashCode = hashCode * 59 + this.ModelingType.GetHashCode();
                if (this.ModelingJobId != null) hashCode = hashCode * 59 + this.ModelingJobId.GetHashCode();
                if (this.ModelProperties != null) hashCode = hashCode * 59 + this.ModelProperties.GetHashCode();
                if (this.Components != null) hashCode = hashCode * 59 + this.Components.GetHashCode();
                return hashCode;
            }
        }
    }
}
