using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsDeploy.V2.Model
{
    /// <summary>
    /// 部署参数类
    /// </summary>
    public class ConfigInfoDO 
    {
        /// <summary>
        /// 类型，如果填写name字段，则type必选,若type为空则默认为text
        /// </summary>
        /// <value>类型，如果填写name字段，则type必选,若type为空则默认为text</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum TEXT for value: text
            /// </summary>
            public static readonly TypeEnum TEXT = new TypeEnum("text");

            /// <summary>
            /// Enum HOST_GROUP for value: host_group
            /// </summary>
            public static readonly TypeEnum HOST_GROUP = new TypeEnum("host_group");

            /// <summary>
            /// Enum ENUM for value: enum
            /// </summary>
            public static readonly TypeEnum ENUM = new TypeEnum("enum");

            /// <summary>
            /// Enum ENCRYPT for value: encrypt
            /// </summary>
            public static readonly TypeEnum ENCRYPT = new TypeEnum("encrypt");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "text", TEXT },
                { "host_group", HOST_GROUP },
                { "enum", ENUM },
                { "encrypt", ENCRYPT },
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 表示是否为静态参数，值为1时不支持部署时变更参数，值为0时支持，并且也会把该参数上报流水线
        /// </summary>
        /// <value>表示是否为静态参数，值为1时不支持部署时变更参数，值为0时支持，并且也会把该参数上报流水线</value>
        [JsonConverter(typeof(EnumClassConverter<StaticStatusEnum>))]
        public class StaticStatusEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            public static readonly StaticStatusEnum NUMBER_0 = new StaticStatusEnum(0);

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly StaticStatusEnum NUMBER_1 = new StaticStatusEnum(1);

            private static readonly Dictionary<int?, StaticStatusEnum> StaticFields =
            new Dictionary<int?, StaticStatusEnum>()
            {
                { 0, NUMBER_0 },
                { 1, NUMBER_1 },
            };

            private int? _value;

            public StaticStatusEnum()
            {

            }

            public StaticStatusEnum(int? value)
            {
                _value = value;
            }

            public static StaticStatusEnum FromValue(int? value)
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

                if (this.Equals(obj as StaticStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StaticStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StaticStatusEnum a, StaticStatusEnum b)
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

            public static bool operator !=(StaticStatusEnum a, StaticStatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 部署参数名称，用户可自定义
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 类型，如果填写name字段，则type必选,若type为空则默认为text
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 部署参数值
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        /// <summary>
        /// 部署任务id，创建应用后由系统自动生成
        /// </summary>
        [JsonProperty("task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskId { get; set; }

        /// <summary>
        /// 表示是否为静态参数，值为1时不支持部署时变更参数，值为0时支持，并且也会把该参数上报流水线
        /// </summary>
        [JsonProperty("static_status", NullValueHandling = NullValueHandling.Ignore)]
        public StaticStatusEnum StaticStatus { get; set; }
        /// <summary>
        /// 当参数类型为enum枚举类型时，必须填写可选值
        /// </summary>
        [JsonProperty("limits", NullValueHandling = NullValueHandling.Ignore)]
        public List<ParamTypeLimits> Limits { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfigInfoDO {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("  staticStatus: ").Append(StaticStatus).Append("\n");
            sb.Append("  limits: ").Append(Limits).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConfigInfoDO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConfigInfoDO input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Type != input.Type) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Value != input.Value || (this.Value != null && !this.Value.Equals(input.Value))) return false;
            if (this.TaskId != input.TaskId || (this.TaskId != null && !this.TaskId.Equals(input.TaskId))) return false;
            if (this.StaticStatus != input.StaticStatus) return false;
            if (this.Limits != input.Limits || (this.Limits != null && input.Limits != null && !this.Limits.SequenceEqual(input.Limits))) return false;

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
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.TaskId != null) hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                hashCode = hashCode * 59 + this.StaticStatus.GetHashCode();
                if (this.Limits != null) hashCode = hashCode * 59 + this.Limits.GetHashCode();
                return hashCode;
            }
        }
    }
}
