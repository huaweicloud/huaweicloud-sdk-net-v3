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
    /// 
    /// </summary>
    public class StepExecutionAction 
    {
        /// <summary>
        /// 操作名称，枚举如下:  - retry 重试  - stop 停止  - continue 继续
        /// </summary>
        /// <value>操作名称，枚举如下:  - retry 重试  - stop 停止  - continue 继续</value>
        [JsonConverter(typeof(EnumClassConverter<ActionNameEnum>))]
        public class ActionNameEnum
        {
            /// <summary>
            /// Enum RETRY_ for value: retry：重试
            /// </summary>
            public static readonly ActionNameEnum RETRY_ = new ActionNameEnum("retry：重试");

            /// <summary>
            /// Enum STOP_ for value: stop：停止
            /// </summary>
            public static readonly ActionNameEnum STOP_ = new ActionNameEnum("stop：停止");

            /// <summary>
            /// Enum CONTINUE_ for value: continue：停止
            /// </summary>
            public static readonly ActionNameEnum CONTINUE_ = new ActionNameEnum("continue：停止");

            private static readonly Dictionary<string, ActionNameEnum> StaticFields =
            new Dictionary<string, ActionNameEnum>()
            {
                { "retry：重试", RETRY_ },
                { "stop：停止", STOP_ },
                { "continue：停止", CONTINUE_ },
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
        /// 操作名称，枚举如下:  - retry 重试  - stop 停止  - continue 继续
        /// </summary>
        [JsonProperty("action_name", NullValueHandling = NullValueHandling.Ignore)]
        public ActionNameEnum ActionName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("data_requirements", NullValueHandling = NullValueHandling.Ignore)]
        public List<DataRequirement> DataRequirements { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("parameters", NullValueHandling = NullValueHandling.Ignore)]
        public List<WorkflowParameter> Parameters { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StepExecutionAction {\n");
            sb.Append("  actionName: ").Append(ActionName).Append("\n");
            sb.Append("  dataRequirements: ").Append(DataRequirements).Append("\n");
            sb.Append("  parameters: ").Append(Parameters).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StepExecutionAction);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StepExecutionAction input)
        {
            if (input == null) return false;
            if (this.ActionName != input.ActionName) return false;
            if (this.DataRequirements != input.DataRequirements || (this.DataRequirements != null && input.DataRequirements != null && !this.DataRequirements.SequenceEqual(input.DataRequirements))) return false;
            if (this.Parameters != input.Parameters || (this.Parameters != null && input.Parameters != null && !this.Parameters.SequenceEqual(input.Parameters))) return false;

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
                if (this.DataRequirements != null) hashCode = hashCode * 59 + this.DataRequirements.GetHashCode();
                if (this.Parameters != null) hashCode = hashCode * 59 + this.Parameters.GetHashCode();
                return hashCode;
            }
        }
    }
}
