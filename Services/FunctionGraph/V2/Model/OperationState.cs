using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.FunctionGraph.V2.Model
{
    /// <summary>
    /// 函数执行节点信息
    /// </summary>
    public class OperationState 
    {
        /// <summary>
        /// Action执行模式，支持串行，并行两种模式，默认串行
        /// </summary>
        /// <value>Action执行模式，支持串行，并行两种模式，默认串行</value>
        [JsonConverter(typeof(EnumClassConverter<ActionModeEnum>))]
        public class ActionModeEnum
        {
            /// <summary>
            /// Enum SEQUENTIAL for value: sequential
            /// </summary>
            public static readonly ActionModeEnum SEQUENTIAL = new ActionModeEnum("sequential");

            /// <summary>
            /// Enum PARALLEL for value: parallel
            /// </summary>
            public static readonly ActionModeEnum PARALLEL = new ActionModeEnum("parallel");

            private static readonly Dictionary<string, ActionModeEnum> StaticFields =
            new Dictionary<string, ActionModeEnum>()
            {
                { "sequential", SEQUENTIAL },
                { "parallel", PARALLEL },
            };

            private string _value;

            public ActionModeEnum()
            {

            }

            public ActionModeEnum(string value)
            {
                _value = value;
            }

            public static ActionModeEnum FromValue(string value)
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

                if (this.Equals(obj as ActionModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ActionModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ActionModeEnum a, ActionModeEnum b)
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

            public static bool operator !=(ActionModeEnum a, ActionModeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 节点类型
        /// </summary>
        /// <value>节点类型</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum OPERATION for value: Operation
            /// </summary>
            public static readonly TypeEnum OPERATION = new TypeEnum("Operation");

            /// <summary>
            /// Enum SLEEP for value: Sleep
            /// </summary>
            public static readonly TypeEnum SLEEP = new TypeEnum("Sleep");

            /// <summary>
            /// Enum END for value: End
            /// </summary>
            public static readonly TypeEnum END = new TypeEnum("End");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "Operation", OPERATION },
                { "Sleep", SLEEP },
                { "End", END },
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
        /// Action执行模式，支持串行，并行两种模式，默认串行
        /// </summary>
        [JsonProperty("action_mode", NullValueHandling = NullValueHandling.Ignore)]
        public ActionModeEnum ActionMode { get; set; }
        /// <summary>
        /// 节点中要执行的操作列表
        /// </summary>
        [JsonProperty("actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Action> Actions { get; set; }

        /// <summary>
        /// 错误处理策略
        /// </summary>
        [JsonProperty("on_errors", NullValueHandling = NullValueHandling.Ignore)]
        public List<OnError> OnErrors { get; set; }

        /// <summary>
        /// 节点ID，需要在当前函数流中唯一
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 节点名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 节点类型
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 是否是结束节点
        /// </summary>
        [JsonProperty("end", NullValueHandling = NullValueHandling.Ignore)]
        public bool? End { get; set; }

        /// <summary>
        /// 下一步骤节点ID
        /// </summary>
        [JsonProperty("transition", NullValueHandling = NullValueHandling.Ignore)]
        public string Transition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("state_data_filter", NullValueHandling = NullValueHandling.Ignore)]
        public StateDataFilter StateDataFilter { get; set; }

        /// <summary>
        /// 时间等待节点等待时间（秒）,节点类型为Sleep时为必填，节点类型不为Sleep时无效
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public long? Duration { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OperationState {\n");
            sb.Append("  actionMode: ").Append(ActionMode).Append("\n");
            sb.Append("  actions: ").Append(Actions).Append("\n");
            sb.Append("  onErrors: ").Append(OnErrors).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  end: ").Append(End).Append("\n");
            sb.Append("  transition: ").Append(Transition).Append("\n");
            sb.Append("  stateDataFilter: ").Append(StateDataFilter).Append("\n");
            sb.Append("  duration: ").Append(Duration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OperationState);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OperationState input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ActionMode == input.ActionMode ||
                    (this.ActionMode != null &&
                    this.ActionMode.Equals(input.ActionMode))
                ) && 
                (
                    this.Actions == input.Actions ||
                    this.Actions != null &&
                    input.Actions != null &&
                    this.Actions.SequenceEqual(input.Actions)
                ) && 
                (
                    this.OnErrors == input.OnErrors ||
                    this.OnErrors != null &&
                    input.OnErrors != null &&
                    this.OnErrors.SequenceEqual(input.OnErrors)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.End == input.End ||
                    (this.End != null &&
                    this.End.Equals(input.End))
                ) && 
                (
                    this.Transition == input.Transition ||
                    (this.Transition != null &&
                    this.Transition.Equals(input.Transition))
                ) && 
                (
                    this.StateDataFilter == input.StateDataFilter ||
                    (this.StateDataFilter != null &&
                    this.StateDataFilter.Equals(input.StateDataFilter))
                ) && 
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
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
                if (this.ActionMode != null)
                    hashCode = hashCode * 59 + this.ActionMode.GetHashCode();
                if (this.Actions != null)
                    hashCode = hashCode * 59 + this.Actions.GetHashCode();
                if (this.OnErrors != null)
                    hashCode = hashCode * 59 + this.OnErrors.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.End != null)
                    hashCode = hashCode * 59 + this.End.GetHashCode();
                if (this.Transition != null)
                    hashCode = hashCode * 59 + this.Transition.GetHashCode();
                if (this.StateDataFilter != null)
                    hashCode = hashCode * 59 + this.StateDataFilter.GetHashCode();
                if (this.Duration != null)
                    hashCode = hashCode * 59 + this.Duration.GetHashCode();
                return hashCode;
            }
        }
    }
}
