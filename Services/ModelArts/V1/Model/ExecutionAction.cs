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
    /// 操作Workflow Execution的动作。
    /// </summary>
    public class ExecutionAction 
    {
        /// <summary>
        /// 操作名称，枚举如下: - stop 停止 - rerun 重跑
        /// </summary>
        /// <value>操作名称，枚举如下: - stop 停止 - rerun 重跑</value>
        [JsonConverter(typeof(EnumClassConverter<ActionNameEnum>))]
        public class ActionNameEnum
        {
            /// <summary>
            /// Enum STOP for value: stop
            /// </summary>
            public static readonly ActionNameEnum STOP = new ActionNameEnum("stop");

            private static readonly Dictionary<string, ActionNameEnum> StaticFields =
            new Dictionary<string, ActionNameEnum>()
            {
                { "stop", STOP },
            };

            private string _value;

            public ActionNameEnum()
            {

            }

            public ActionNameEnum(string value)
            {
                _value = value;
            }

            public static ActionNameEnum FromValue(string value)
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

                if (this.Equals(obj as ActionNameEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ActionNameEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ActionNameEnum a, ActionNameEnum b)
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

            public static bool operator !=(ActionNameEnum a, ActionNameEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 操作名称，枚举如下: - stop 停止 - rerun 重跑
        /// </summary>
        [JsonProperty("action_name", NullValueHandling = NullValueHandling.Ignore)]
        public ActionNameEnum ActionName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("policies", NullValueHandling = NullValueHandling.Ignore)]
        public ExecutionActionPolicy Policies { get; set; }

        /// <summary>
        /// 参数。
        /// </summary>
        [JsonProperty("parameters", NullValueHandling = NullValueHandling.Ignore)]
        public List<WorkflowParameter> Parameters { get; set; }

        /// <summary>
        /// 需要的数据。
        /// </summary>
        [JsonProperty("data_requirements", NullValueHandling = NullValueHandling.Ignore)]
        public List<DataRequirement> DataRequirements { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExecutionAction {\n");
            sb.Append("  actionName: ").Append(ActionName).Append("\n");
            sb.Append("  policies: ").Append(Policies).Append("\n");
            sb.Append("  parameters: ").Append(Parameters).Append("\n");
            sb.Append("  dataRequirements: ").Append(DataRequirements).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExecutionAction);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExecutionAction input)
        {
            if (input == null) return false;
            if (this.ActionName != input.ActionName) return false;
            if (this.Policies != input.Policies || (this.Policies != null && !this.Policies.Equals(input.Policies))) return false;
            if (this.Parameters != input.Parameters || (this.Parameters != null && input.Parameters != null && !this.Parameters.SequenceEqual(input.Parameters))) return false;
            if (this.DataRequirements != input.DataRequirements || (this.DataRequirements != null && input.DataRequirements != null && !this.DataRequirements.SequenceEqual(input.DataRequirements))) return false;

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
                hashCode = hashCode * 59 + this.ActionName.GetHashCode();
                if (this.Policies != null) hashCode = hashCode * 59 + this.Policies.GetHashCode();
                if (this.Parameters != null) hashCode = hashCode * 59 + this.Parameters.GetHashCode();
                if (this.DataRequirements != null) hashCode = hashCode * 59 + this.DataRequirements.GetHashCode();
                return hashCode;
            }
        }
    }
}
