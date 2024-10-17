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
    /// 更新或者查询结构化模板对象
    /// </summary>
    public class StructTemplateModel 
    {
        /// <summary>
        /// 模板类型，regex,json,split,nginx
        /// </summary>
        /// <value>模板类型，regex,json,split,nginx</value>
        [JsonConverter(typeof(EnumClassConverter<TemplateTypeEnum>))]
        public class TemplateTypeEnum
        {
            /// <summary>
            /// Enum REGEX for value: regex
            /// </summary>
            public static readonly TemplateTypeEnum REGEX = new TemplateTypeEnum("regex");

            /// <summary>
            /// Enum JSON for value: json
            /// </summary>
            public static readonly TemplateTypeEnum JSON = new TemplateTypeEnum("json");

            /// <summary>
            /// Enum SPLIT for value: split
            /// </summary>
            public static readonly TemplateTypeEnum SPLIT = new TemplateTypeEnum("split");

            /// <summary>
            /// Enum NGINX for value: nginx
            /// </summary>
            public static readonly TemplateTypeEnum NGINX = new TemplateTypeEnum("nginx");

            private static readonly Dictionary<string, TemplateTypeEnum> StaticFields =
            new Dictionary<string, TemplateTypeEnum>()
            {
                { "regex", REGEX },
                { "json", JSON },
                { "split", SPLIT },
                { "nginx", NGINX },
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
        /// 项目id
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 模板名称
        /// </summary>
        [JsonProperty("template_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateName { get; set; }

        /// <summary>
        /// 模板类型，regex,json,split,nginx
        /// </summary>
        [JsonProperty("template_type", NullValueHandling = NullValueHandling.Ignore)]
        public TemplateTypeEnum TemplateType { get; set; }
        /// <summary>
        /// 示例日志
        /// </summary>
        [JsonProperty("demo_log", NullValueHandling = NullValueHandling.Ignore)]
        public string DemoLog { get; set; }

        /// <summary>
        /// 示例字段数组
        /// </summary>
        [JsonProperty("demo_fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<DemoField> DemoFields { get; set; }

        /// <summary>
        /// Tag字段数组
        /// </summary>
        [JsonProperty("tag_fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<TagFieldNew> TagFields { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("rule", NullValueHandling = NullValueHandling.Ignore)]
        public TemplateRule Rule { get; set; }

        /// <summary>
        /// 示例日志标签
        /// </summary>
        [JsonProperty("demo_label", NullValueHandling = NullValueHandling.Ignore)]
        public string DemoLabel { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// 模板id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StructTemplateModel {\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  templateName: ").Append(TemplateName).Append("\n");
            sb.Append("  templateType: ").Append(TemplateType).Append("\n");
            sb.Append("  demoLog: ").Append(DemoLog).Append("\n");
            sb.Append("  demoFields: ").Append(DemoFields).Append("\n");
            sb.Append("  tagFields: ").Append(TagFields).Append("\n");
            sb.Append("  rule: ").Append(Rule).Append("\n");
            sb.Append("  demoLabel: ").Append(DemoLabel).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StructTemplateModel);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StructTemplateModel input)
        {
            if (input == null) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.TemplateName != input.TemplateName || (this.TemplateName != null && !this.TemplateName.Equals(input.TemplateName))) return false;
            if (this.TemplateType != input.TemplateType) return false;
            if (this.DemoLog != input.DemoLog || (this.DemoLog != null && !this.DemoLog.Equals(input.DemoLog))) return false;
            if (this.DemoFields != input.DemoFields || (this.DemoFields != null && input.DemoFields != null && !this.DemoFields.SequenceEqual(input.DemoFields))) return false;
            if (this.TagFields != input.TagFields || (this.TagFields != null && input.TagFields != null && !this.TagFields.SequenceEqual(input.TagFields))) return false;
            if (this.Rule != input.Rule || (this.Rule != null && !this.Rule.Equals(input.Rule))) return false;
            if (this.DemoLabel != input.DemoLabel || (this.DemoLabel != null && !this.DemoLabel.Equals(input.DemoLabel))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;

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
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.TemplateName != null) hashCode = hashCode * 59 + this.TemplateName.GetHashCode();
                hashCode = hashCode * 59 + this.TemplateType.GetHashCode();
                if (this.DemoLog != null) hashCode = hashCode * 59 + this.DemoLog.GetHashCode();
                if (this.DemoFields != null) hashCode = hashCode * 59 + this.DemoFields.GetHashCode();
                if (this.TagFields != null) hashCode = hashCode * 59 + this.TagFields.GetHashCode();
                if (this.Rule != null) hashCode = hashCode * 59 + this.Rule.GetHashCode();
                if (this.DemoLabel != null) hashCode = hashCode * 59 + this.DemoLabel.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                return hashCode;
            }
        }
    }
}
