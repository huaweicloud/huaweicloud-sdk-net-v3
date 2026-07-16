using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 参数。
    /// </summary>
    public class WorkflowParameterResp 
    {
        /// <summary>
        /// **参数解释**：参数的类型。 **取值范围**：枚举值如下: - str：字符串 - int：整型 - bool：布尔类型 - float：浮点型
        /// </summary>
        /// <value>**参数解释**：参数的类型。 **取值范围**：枚举值如下: - str：字符串 - int：整型 - bool：布尔类型 - float：浮点型</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum STR_ for value: str：字符串类型
            /// </summary>
            public static readonly TypeEnum STR_ = new TypeEnum("str：字符串类型");

            /// <summary>
            /// Enum INT_ for value: int：整型
            /// </summary>
            public static readonly TypeEnum INT_ = new TypeEnum("int：整型");

            /// <summary>
            /// Enum BOOL_ for value: bool：布尔类型
            /// </summary>
            public static readonly TypeEnum BOOL_ = new TypeEnum("bool：布尔类型");

            /// <summary>
            /// Enum FLOAT_ for value: float：浮点型
            /// </summary>
            public static readonly TypeEnum FLOAT_ = new TypeEnum("float：浮点型");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "str：字符串类型", STR_ },
                { "int：整型", INT_ },
                { "bool：布尔类型", BOOL_ },
                { "float：浮点型", FLOAT_ },
            };

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
            }

            public static TypeEnum FromValue(string value)
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

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**：Workflow工作流配置参数的名称。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**：参数的类型。 **取值范围**：枚举值如下: - str：字符串 - int：整型 - bool：布尔类型 - float：浮点型
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// **参数解释**：Workflow工作流配置参数的描述。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**：Workflow工作流配置参数的样例。
        /// </summary>
        [JsonProperty("example", NullValueHandling = NullValueHandling.Ignore)]
        public Object Example { get; set; }

        /// <summary>
        /// **参数解释**：是否为延迟输入的参数。 **取值范围**： - true：是 - false：否
        /// </summary>
        [JsonProperty("delay", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Delay { get; set; }

        /// <summary>
        /// **参数解释**：配置参数的默认值。
        /// </summary>
        [JsonProperty("default", NullValueHandling = NullValueHandling.Ignore)]
        public Object Default { get; set; }

        /// <summary>
        /// **参数解释**：参数值。
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public Object Value { get; set; }

        /// <summary>
        /// **参数解释**：Workflow工作流配置参数的枚举项。
        /// </summary>
        [JsonProperty("enum", NullValueHandling = NullValueHandling.Ignore)]
        public List<Object> Enum { get; set; }

        /// <summary>
        /// **参数解释**：使用这个参数的工作流节点。
        /// </summary>
        [JsonProperty("used_steps", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> UsedSteps { get; set; }

        /// <summary>
        /// **参数解释**：数据格式。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("format", NullValueHandling = NullValueHandling.Ignore)]
        public string Format { get; set; }

        /// <summary>
        /// **参数解释**：限制条件。
        /// </summary>
        [JsonProperty("constraint", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Object> Constraint { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkflowParameterResp {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  example: ").Append(Example).Append("\n");
            sb.Append("  delay: ").Append(Delay).Append("\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("  Enum: ").Append(Enum).Append("\n");
            sb.Append("  usedSteps: ").Append(UsedSteps).Append("\n");
            sb.Append("  format: ").Append(Format).Append("\n");
            sb.Append("  constraint: ").Append(Constraint).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WorkflowParameterResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WorkflowParameterResp input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Type != input.Type) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Example != input.Example || (this.Example != null && !this.Example.Equals(input.Example))) return false;
            if (this.Delay != input.Delay || (this.Delay != null && !this.Delay.Equals(input.Delay))) return false;
            if (this.Default != input.Default || (this.Default != null && !this.Default.Equals(input.Default))) return false;
            if (this.Value != input.Value || (this.Value != null && !this.Value.Equals(input.Value))) return false;
            if (this.Enum != input.Enum || (this.Enum != null && input.Enum != null && !this.Enum.SequenceEqual(input.Enum))) return false;
            if (this.UsedSteps != input.UsedSteps || (this.UsedSteps != null && input.UsedSteps != null && !this.UsedSteps.SequenceEqual(input.UsedSteps))) return false;
            if (this.Format != input.Format || (this.Format != null && !this.Format.Equals(input.Format))) return false;
            if (this.Constraint != input.Constraint || (this.Constraint != null && input.Constraint != null && !this.Constraint.SequenceEqual(input.Constraint))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Example != null) hashCode = hashCode * 59 + this.Example.GetHashCode();
                if (this.Delay != null) hashCode = hashCode * 59 + this.Delay.GetHashCode();
                if (this.Default != null) hashCode = hashCode * 59 + this.Default.GetHashCode();
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Enum != null) hashCode = hashCode * 59 + this.Enum.GetHashCode();
                if (this.UsedSteps != null) hashCode = hashCode * 59 + this.UsedSteps.GetHashCode();
                if (this.Format != null) hashCode = hashCode * 59 + this.Format.GetHashCode();
                if (this.Constraint != null) hashCode = hashCode * 59 + this.Constraint.GetHashCode();
                return hashCode;
            }
        }
    }
}
