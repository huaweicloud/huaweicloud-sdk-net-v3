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
    /// 
    /// </summary>
    public class LtsStructTemplateInfo 
    {
        /// <summary>
        /// 结构化方式
        /// </summary>
        /// <value>结构化方式</value>
        [JsonConverter(typeof(EnumClassConverter<ParseTypeEnum>))]
        public class ParseTypeEnum
        {
            /// <summary>
            /// Enum BUILT_IN for value: built_in
            /// </summary>
            public static readonly ParseTypeEnum BUILT_IN = new ParseTypeEnum("built_in");

            /// <summary>
            /// Enum JSON for value: json
            /// </summary>
            public static readonly ParseTypeEnum JSON = new ParseTypeEnum("json");

            /// <summary>
            /// Enum CUSTOM_REGEX for value: custom_regex
            /// </summary>
            public static readonly ParseTypeEnum CUSTOM_REGEX = new ParseTypeEnum("custom_regex");

            /// <summary>
            /// Enum SPLIT for value: split
            /// </summary>
            public static readonly ParseTypeEnum SPLIT = new ParseTypeEnum("split");

            /// <summary>
            /// Enum NGINX for value: nginx
            /// </summary>
            public static readonly ParseTypeEnum NGINX = new ParseTypeEnum("nginx");

            private static readonly Dictionary<string, ParseTypeEnum> StaticFields =
            new Dictionary<string, ParseTypeEnum>()
            {
                { "built_in", BUILT_IN },
                { "json", JSON },
                { "custom_regex", CUSTOM_REGEX },
                { "split", SPLIT },
                { "nginx", NGINX },
            };

            private string _value;

            public ParseTypeEnum()
            {

            }

            public ParseTypeEnum(string value)
            {
                _value = value;
            }

            public static ParseTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ParseTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ParseTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ParseTypeEnum a, ParseTypeEnum b)
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

            public static bool operator !=(ParseTypeEnum a, ParseTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 结构化字段
        /// </summary>
        [JsonProperty("demo_fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<StructFieldInfo> DemoFields { get; set; }

        /// <summary>
        /// tag字段列表（使用tag字段解析时需要，其中系统模板不支持使用tag字段）。
        /// </summary>
        [JsonProperty("tag_fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<TagField> TagFields { get; set; }

        /// <summary>
        /// 示例日志
        /// </summary>
        [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
        public string Content { get; set; }

        /// <summary>
        /// 日志组ID
        /// </summary>
        [JsonProperty("log_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogGroupId { get; set; }

        /// <summary>
        /// 结构化方式
        /// </summary>
        [JsonProperty("parse_type", NullValueHandling = NullValueHandling.Ignore)]
        public ParseTypeEnum ParseType { get; set; }
        /// <summary>
        /// 日志流ID
        /// </summary>
        [JsonProperty("log_stream_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogStreamId { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// parse_type为custom_regex类型时必填，regex提取规则
        /// </summary>
        [JsonProperty("regex_rules", NullValueHandling = NullValueHandling.Ignore)]
        public string RegexRules { get; set; }

        /// <summary>
        /// parse_type为json类型时必填，解析层数，目前固定是3
        /// </summary>
        [JsonProperty("layers", NullValueHandling = NullValueHandling.Ignore)]
        public int? Layers { get; set; }

        /// <summary>
        /// parse_type为split类型时必填，分隔符，分词符号
        /// </summary>
        [JsonProperty("tokenizer", NullValueHandling = NullValueHandling.Ignore)]
        public string Tokenizer { get; set; }

        /// <summary>
        /// parse_type为nginx类型时必填，nginx日志格式模板
        /// </summary>
        [JsonProperty("log_format", NullValueHandling = NullValueHandling.Ignore)]
        public string LogFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("rule", NullValueHandling = NullValueHandling.Ignore)]
        public Rule Rule { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LtsStructTemplateInfo {\n");
            sb.Append("  demoFields: ").Append(DemoFields).Append("\n");
            sb.Append("  tagFields: ").Append(TagFields).Append("\n");
            sb.Append("  content: ").Append(Content).Append("\n");
            sb.Append("  logGroupId: ").Append(LogGroupId).Append("\n");
            sb.Append("  parseType: ").Append(ParseType).Append("\n");
            sb.Append("  logStreamId: ").Append(LogStreamId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  regexRules: ").Append(RegexRules).Append("\n");
            sb.Append("  layers: ").Append(Layers).Append("\n");
            sb.Append("  tokenizer: ").Append(Tokenizer).Append("\n");
            sb.Append("  logFormat: ").Append(LogFormat).Append("\n");
            sb.Append("  rule: ").Append(Rule).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LtsStructTemplateInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LtsStructTemplateInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DemoFields == input.DemoFields ||
                    this.DemoFields != null &&
                    input.DemoFields != null &&
                    this.DemoFields.SequenceEqual(input.DemoFields)
                ) && 
                (
                    this.TagFields == input.TagFields ||
                    this.TagFields != null &&
                    input.TagFields != null &&
                    this.TagFields.SequenceEqual(input.TagFields)
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.LogGroupId == input.LogGroupId ||
                    (this.LogGroupId != null &&
                    this.LogGroupId.Equals(input.LogGroupId))
                ) && 
                (
                    this.ParseType == input.ParseType ||
                    (this.ParseType != null &&
                    this.ParseType.Equals(input.ParseType))
                ) && 
                (
                    this.LogStreamId == input.LogStreamId ||
                    (this.LogStreamId != null &&
                    this.LogStreamId.Equals(input.LogStreamId))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.RegexRules == input.RegexRules ||
                    (this.RegexRules != null &&
                    this.RegexRules.Equals(input.RegexRules))
                ) && 
                (
                    this.Layers == input.Layers ||
                    (this.Layers != null &&
                    this.Layers.Equals(input.Layers))
                ) && 
                (
                    this.Tokenizer == input.Tokenizer ||
                    (this.Tokenizer != null &&
                    this.Tokenizer.Equals(input.Tokenizer))
                ) && 
                (
                    this.LogFormat == input.LogFormat ||
                    (this.LogFormat != null &&
                    this.LogFormat.Equals(input.LogFormat))
                ) && 
                (
                    this.Rule == input.Rule ||
                    (this.Rule != null &&
                    this.Rule.Equals(input.Rule))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.DemoFields != null)
                    hashCode = hashCode * 59 + this.DemoFields.GetHashCode();
                if (this.TagFields != null)
                    hashCode = hashCode * 59 + this.TagFields.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.LogGroupId != null)
                    hashCode = hashCode * 59 + this.LogGroupId.GetHashCode();
                if (this.ParseType != null)
                    hashCode = hashCode * 59 + this.ParseType.GetHashCode();
                if (this.LogStreamId != null)
                    hashCode = hashCode * 59 + this.LogStreamId.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.RegexRules != null)
                    hashCode = hashCode * 59 + this.RegexRules.GetHashCode();
                if (this.Layers != null)
                    hashCode = hashCode * 59 + this.Layers.GetHashCode();
                if (this.Tokenizer != null)
                    hashCode = hashCode * 59 + this.Tokenizer.GetHashCode();
                if (this.LogFormat != null)
                    hashCode = hashCode * 59 + this.LogFormat.GetHashCode();
                if (this.Rule != null)
                    hashCode = hashCode * 59 + this.Rule.GetHashCode();
                return hashCode;
            }
        }
    }
}
