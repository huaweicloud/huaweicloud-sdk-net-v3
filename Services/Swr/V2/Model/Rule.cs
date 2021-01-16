using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Rule 
    {
        /// <summary>
        /// 回收类型，date_rule、tag_rule
        /// </summary>
        /// <value>回收类型，date_rule、tag_rule</value>
        [JsonConverter(typeof(EnumClassConverter<TemplateEnum>))]
        public class TemplateEnum
        {
            /// <summary>
            /// Enum DATE_RULE for value: date_rule
            /// </summary>
            public static readonly TemplateEnum DATE_RULE = new TemplateEnum("date_rule");

            /// <summary>
            /// Enum TAG_RULE for value: tag_rule
            /// </summary>
            public static readonly TemplateEnum TAG_RULE = new TemplateEnum("tag_rule");

            private static readonly Dictionary<string, TemplateEnum> StaticFields =
            new Dictionary<string, TemplateEnum>()
            {
                { "date_rule", DATE_RULE },
                { "tag_rule", TAG_RULE },
            };

            private string Value;

            public TemplateEnum(string value)
            {
                Value = value;
            }

            public static TemplateEnum FromValue(string value)
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as TemplateEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TemplateEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(TemplateEnum a, TemplateEnum b)
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

            public static bool operator !=(TemplateEnum a, TemplateEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// template是date_rule时，设置params[\&quot;days\&quot;] template是tag_rule时，设置params[\&quot;num\&quot;] 
        /// </summary>
        [JsonProperty("params", NullValueHandling = NullValueHandling.Ignore)]
        public Object Params { get; set; }

        /// <summary>
        /// 例外镜像
        /// </summary>
        [JsonProperty("tag_selectors", NullValueHandling = NullValueHandling.Ignore)]
        public List<TagSelector> TagSelectors { get; set; }

        /// <summary>
        /// 回收类型，date_rule、tag_rule
        /// </summary>
        [JsonProperty("template", NullValueHandling = NullValueHandling.Ignore)]
        public TemplateEnum Template { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Rule {\n");
            sb.Append("  Params: ").Append(Params).Append("\n");
            sb.Append("  tagSelectors: ").Append(TagSelectors).Append("\n");
            sb.Append("  template: ").Append(Template).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Rule);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Rule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Params == input.Params ||
                    (this.Params != null &&
                    this.Params.Equals(input.Params))
                ) && 
                (
                    this.TagSelectors == input.TagSelectors ||
                    this.TagSelectors != null &&
                    input.TagSelectors != null &&
                    this.TagSelectors.SequenceEqual(input.TagSelectors)
                ) && 
                (
                    this.Template == input.Template ||
                    (this.Template != null &&
                    this.Template.Equals(input.Template))
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
                if (this.Params != null)
                    hashCode = hashCode * 59 + this.Params.GetHashCode();
                if (this.TagSelectors != null)
                    hashCode = hashCode * 59 + this.TagSelectors.GetHashCode();
                if (this.Template != null)
                    hashCode = hashCode * 59 + this.Template.GetHashCode();
                return hashCode;
            }
        }
    }
}
