using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rgc.V1.Model
{
    /// <summary>
    /// 创建模板请求参数。
    /// </summary>
    public class CreateTemplateRequestBody 
    {
        /// <summary>
        /// 模板类型，包括预置和自定义。
        /// </summary>
        /// <value>模板类型，包括预置和自定义。</value>
        [JsonConverter(typeof(EnumClassConverter<TemplateTypeEnum>))]
        public class TemplateTypeEnum
        {
            /// <summary>
            /// Enum PREDEFINED for value: predefined
            /// </summary>
            public static readonly TemplateTypeEnum PREDEFINED = new TemplateTypeEnum("predefined");

            /// <summary>
            /// Enum CUSTOMIZED for value: customized
            /// </summary>
            public static readonly TemplateTypeEnum CUSTOMIZED = new TemplateTypeEnum("customized");

            private static readonly Dictionary<string, TemplateTypeEnum> StaticFields =
            new Dictionary<string, TemplateTypeEnum>()
            {
                { "predefined", PREDEFINED },
                { "customized", CUSTOMIZED },
            };

            private string _value;

            public TemplateTypeEnum()
            {

            }

            public TemplateTypeEnum(string value)
            {
                _value = value;
            }

            public static TemplateTypeEnum FromValue(string value)
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
        /// 模板名称。
        /// </summary>
        [JsonProperty("template_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateName { get; set; }

        /// <summary>
        /// 模板类型，包括预置和自定义。
        /// </summary>
        [JsonProperty("template_type", NullValueHandling = NullValueHandling.Ignore)]
        public TemplateTypeEnum TemplateType { get; set; }
        /// <summary>
        /// 模板描述。
        /// </summary>
        [JsonProperty("template_description", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateDescription { get; set; }

        /// <summary>
        /// 模板内容。
        /// </summary>
        [JsonProperty("template_body", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateBody { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTemplateRequestBody {\n");
            sb.Append("  templateName: ").Append(TemplateName).Append("\n");
            sb.Append("  templateType: ").Append(TemplateType).Append("\n");
            sb.Append("  templateDescription: ").Append(TemplateDescription).Append("\n");
            sb.Append("  templateBody: ").Append(TemplateBody).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateTemplateRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateTemplateRequestBody input)
        {
            if (input == null) return false;
            if (this.TemplateName != input.TemplateName || (this.TemplateName != null && !this.TemplateName.Equals(input.TemplateName))) return false;
            if (this.TemplateType != input.TemplateType) return false;
            if (this.TemplateDescription != input.TemplateDescription || (this.TemplateDescription != null && !this.TemplateDescription.Equals(input.TemplateDescription))) return false;
            if (this.TemplateBody != input.TemplateBody || (this.TemplateBody != null && !this.TemplateBody.Equals(input.TemplateBody))) return false;

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
                if (this.TemplateBody != null) hashCode = hashCode * 59 + this.TemplateBody.GetHashCode();
                return hashCode;
            }
        }
    }
}
