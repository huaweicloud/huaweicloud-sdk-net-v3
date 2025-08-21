using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateAlarmTemplateRequestBody 
    {
        /// <summary>
        /// **参数解释**： 自定义告警模板类型 **约束限制**： 当template_type为0或者不选时，policies中的dimension_name必填。当template_type为2时，dimension_name为空。 **取值范围**： 枚举值。0：指标；2： 事件。 **默认取值**： 0 
        /// </summary>
        /// <value>**参数解释**： 自定义告警模板类型 **约束限制**： 当template_type为0或者不选时，policies中的dimension_name必填。当template_type为2时，dimension_name为空。 **取值范围**： 枚举值。0：指标；2： 事件。 **默认取值**： 0 </value>
        [JsonConverter(typeof(EnumClassConverter<TemplateTypeEnum>))]
        public class TemplateTypeEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            public static readonly TemplateTypeEnum NUMBER_0 = new TemplateTypeEnum(0);

            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            public static readonly TemplateTypeEnum NUMBER_2 = new TemplateTypeEnum(2);

            private static readonly Dictionary<int?, TemplateTypeEnum> StaticFields =
            new Dictionary<int?, TemplateTypeEnum>()
            {
                { 0, NUMBER_0 },
                { 2, NUMBER_2 },
            };

            private int? _value;

            public TemplateTypeEnum()
            {

            }

            public TemplateTypeEnum(int? value)
            {
                _value = value;
            }

            public static TemplateTypeEnum FromValue(int? value)
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

            public int? GetValue()
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

                if (this.Equals(obj as TemplateTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TemplateTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TemplateTypeEnum a, TemplateTypeEnum b)
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

            public static bool operator !=(TemplateTypeEnum a, TemplateTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 告警模板的名称，以字母或汉字开头，可包含字母、数字、汉字、_、-，长度范围[1,128]
        /// </summary>
        [JsonProperty("template_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateName { get; set; }

        /// <summary>
        /// **参数解释**： 自定义告警模板类型 **约束限制**： 当template_type为0或者不选时，policies中的dimension_name必填。当template_type为2时，dimension_name为空。 **取值范围**： 枚举值。0：指标；2： 事件。 **默认取值**： 0 
        /// </summary>
        [JsonProperty("template_type", NullValueHandling = NullValueHandling.Ignore)]
        public TemplateTypeEnum TemplateType { get; set; }
        /// <summary>
        /// 告警模板的描述，长度范围[0,256]，该字段默认值为空字符串
        /// </summary>
        [JsonProperty("template_description", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateDescription { get; set; }

        /// <summary>
        /// 告警模板策略列表
        /// </summary>
        [JsonProperty("policies", NullValueHandling = NullValueHandling.Ignore)]
        public List<Policies> Policies { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateAlarmTemplateRequestBody {\n");
            sb.Append("  templateName: ").Append(TemplateName).Append("\n");
            sb.Append("  templateType: ").Append(TemplateType).Append("\n");
            sb.Append("  templateDescription: ").Append(TemplateDescription).Append("\n");
            sb.Append("  policies: ").Append(Policies).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateAlarmTemplateRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateAlarmTemplateRequestBody input)
        {
            if (input == null) return false;
            if (this.TemplateName != input.TemplateName || (this.TemplateName != null && !this.TemplateName.Equals(input.TemplateName))) return false;
            if (this.TemplateType != input.TemplateType) return false;
            if (this.TemplateDescription != input.TemplateDescription || (this.TemplateDescription != null && !this.TemplateDescription.Equals(input.TemplateDescription))) return false;
            if (this.Policies != input.Policies || (this.Policies != null && input.Policies != null && !this.Policies.SequenceEqual(input.Policies))) return false;

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
                if (this.TemplateName != null) hashCode = hashCode * 59 + this.TemplateName.GetHashCode();
                hashCode = hashCode * 59 + this.TemplateType.GetHashCode();
                if (this.TemplateDescription != null) hashCode = hashCode * 59 + this.TemplateDescription.GetHashCode();
                if (this.Policies != null) hashCode = hashCode * 59 + this.Policies.GetHashCode();
                return hashCode;
            }
        }
    }
}
