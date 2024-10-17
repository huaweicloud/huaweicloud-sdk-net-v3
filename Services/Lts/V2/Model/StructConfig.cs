using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// 结构化配置参数体
    /// </summary>
    public class StructConfig 
    {
        /// <summary>
        /// 所用模板类型，分为built_in及custom两种类型，对应系统模板和自定义模板，系统模板分为CTS，VPC和ELB三种。
        /// </summary>
        /// <value>所用模板类型，分为built_in及custom两种类型，对应系统模板和自定义模板，系统模板分为CTS，VPC和ELB三种。</value>
        [JsonConverter(typeof(EnumClassConverter<TemplateTypeEnum>))]
        public class TemplateTypeEnum
        {
            /// <summary>
            /// Enum BUILT_IN for value: built_in
            /// </summary>
            public static readonly TemplateTypeEnum BUILT_IN = new TemplateTypeEnum("built_in");

            /// <summary>
            /// Enum CUSTOM for value: custom
            /// </summary>
            public static readonly TemplateTypeEnum CUSTOM = new TemplateTypeEnum("custom");

            private static readonly Dictionary<string, TemplateTypeEnum> StaticFields =
            new Dictionary<string, TemplateTypeEnum>()
            {
                { "built_in", BUILT_IN },
                { "custom", CUSTOM },
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
        /// 日志组ID，获取方式请参见：获取账号ID、项目ID、日志组ID、日志流ID（https://support.huaweicloud.com/api-lts/lts_api_0006.html）。
        /// </summary>
        [JsonProperty("log_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogGroupId { get; set; }

        /// <summary>
        /// 日志流ID，获取方式请参见：获取账号ID、项目ID、日志组ID、日志流ID（https://support.huaweicloud.com/api-lts/lts_api_0006.html）。
        /// </summary>
        [JsonProperty("log_stream_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogStreamId { get; set; }

        /// <summary>
        /// 所用模板id。当使用系统模板时，当前属性可以为空
        /// </summary>
        [JsonProperty("template_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateId { get; set; }

        /// <summary>
        /// 所用模板名称，会对模板名称及id进行校验
        /// </summary>
        [JsonProperty("template_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateName { get; set; }

        /// <summary>
        /// 所用模板类型，分为built_in及custom两种类型，对应系统模板和自定义模板，系统模板分为CTS，VPC和ELB三种。
        /// </summary>
        [JsonProperty("template_type", NullValueHandling = NullValueHandling.Ignore)]
        public TemplateTypeEnum TemplateType { get; set; }
        /// <summary>
        /// 示例字段数组，只需要填写与模板中is_analysis状态不同的字段
        /// </summary>
        [JsonProperty("demo_fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<FieldModel> DemoFields { get; set; }

        /// <summary>
        /// Tag字段数组，只需要填写与模板中is_analysis状态不同的字段
        /// </summary>
        [JsonProperty("tag_fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<FieldModel> TagFields { get; set; }

        /// <summary>
        /// 是否开启demo_fields和tag_fields快速分析,为true时，所有的demo_fields和tag_fields全部字段均打开快速分析;不填或者为false，以模板中的demo_fields和tag_fields中的is_analysis决定是否开启快速分析。
        /// </summary>
        [JsonProperty("quick_analysis", NullValueHandling = NullValueHandling.Ignore)]
        public bool? QuickAnalysis { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StructConfig {\n");
            sb.Append("  logGroupId: ").Append(LogGroupId).Append("\n");
            sb.Append("  logStreamId: ").Append(LogStreamId).Append("\n");
            sb.Append("  templateId: ").Append(TemplateId).Append("\n");
            sb.Append("  templateName: ").Append(TemplateName).Append("\n");
            sb.Append("  templateType: ").Append(TemplateType).Append("\n");
            sb.Append("  demoFields: ").Append(DemoFields).Append("\n");
            sb.Append("  tagFields: ").Append(TagFields).Append("\n");
            sb.Append("  quickAnalysis: ").Append(QuickAnalysis).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StructConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StructConfig input)
        {
            if (input == null) return false;
            if (this.LogGroupId != input.LogGroupId || (this.LogGroupId != null && !this.LogGroupId.Equals(input.LogGroupId))) return false;
            if (this.LogStreamId != input.LogStreamId || (this.LogStreamId != null && !this.LogStreamId.Equals(input.LogStreamId))) return false;
            if (this.TemplateId != input.TemplateId || (this.TemplateId != null && !this.TemplateId.Equals(input.TemplateId))) return false;
            if (this.TemplateName != input.TemplateName || (this.TemplateName != null && !this.TemplateName.Equals(input.TemplateName))) return false;
            if (this.TemplateType != input.TemplateType) return false;
            if (this.DemoFields != input.DemoFields || (this.DemoFields != null && input.DemoFields != null && !this.DemoFields.SequenceEqual(input.DemoFields))) return false;
            if (this.TagFields != input.TagFields || (this.TagFields != null && input.TagFields != null && !this.TagFields.SequenceEqual(input.TagFields))) return false;
            if (this.QuickAnalysis != input.QuickAnalysis || (this.QuickAnalysis != null && !this.QuickAnalysis.Equals(input.QuickAnalysis))) return false;

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
                if (this.LogGroupId != null) hashCode = hashCode * 59 + this.LogGroupId.GetHashCode();
                if (this.LogStreamId != null) hashCode = hashCode * 59 + this.LogStreamId.GetHashCode();
                if (this.TemplateId != null) hashCode = hashCode * 59 + this.TemplateId.GetHashCode();
                if (this.TemplateName != null) hashCode = hashCode * 59 + this.TemplateName.GetHashCode();
                hashCode = hashCode * 59 + this.TemplateType.GetHashCode();
                if (this.DemoFields != null) hashCode = hashCode * 59 + this.DemoFields.GetHashCode();
                if (this.TagFields != null) hashCode = hashCode * 59 + this.TagFields.GetHashCode();
                if (this.QuickAnalysis != null) hashCode = hashCode * 59 + this.QuickAnalysis.GetHashCode();
                return hashCode;
            }
        }
    }
}
