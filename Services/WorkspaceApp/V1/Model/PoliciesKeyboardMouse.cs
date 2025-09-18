using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 键盘鼠标。
    /// </summary>
    public class PoliciesKeyboardMouse 
    {
        /// <summary>
        /// 虚拟机鼠标回馈。取值为： SELFADAPTION：自适应鼠标回馈。 FORCE：强制鼠标回馈。 CLOSE：关闭鼠标回馈。
        /// </summary>
        /// <value>虚拟机鼠标回馈。取值为： SELFADAPTION：自适应鼠标回馈。 FORCE：强制鼠标回馈。 CLOSE：关闭鼠标回馈。</value>
        [JsonConverter(typeof(EnumClassConverter<MouseFeedbackEnum>))]
        public class MouseFeedbackEnum
        {
            /// <summary>
            /// Enum SELFADAPTION for value: SELFADAPTION
            /// </summary>
            public static readonly MouseFeedbackEnum SELFADAPTION = new MouseFeedbackEnum("SELFADAPTION");

            /// <summary>
            /// Enum FORCE for value: FORCE
            /// </summary>
            public static readonly MouseFeedbackEnum FORCE = new MouseFeedbackEnum("FORCE");

            /// <summary>
            /// Enum CLOSE for value: CLOSE
            /// </summary>
            public static readonly MouseFeedbackEnum CLOSE = new MouseFeedbackEnum("CLOSE");

            private static readonly Dictionary<string, MouseFeedbackEnum> StaticFields =
            new Dictionary<string, MouseFeedbackEnum>()
            {
                { "SELFADAPTION", SELFADAPTION },
                { "FORCE", FORCE },
                { "CLOSE", CLOSE },
            };

            private string _value;

            public MouseFeedbackEnum()
            {

            }

            public MouseFeedbackEnum(string value)
            {
                _value = value;
            }

            public static MouseFeedbackEnum FromValue(string value)
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

                if (this.Equals(obj as MouseFeedbackEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(MouseFeedbackEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(MouseFeedbackEnum a, MouseFeedbackEnum b)
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

            public static bool operator !=(MouseFeedbackEnum a, MouseFeedbackEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 虚拟机鼠标模拟方式。取值为： ABSOLUTE_POSITION：绝对位置模拟。 RELATIVE_POSITION：相对位置模拟。
        /// </summary>
        /// <value>虚拟机鼠标模拟方式。取值为： ABSOLUTE_POSITION：绝对位置模拟。 RELATIVE_POSITION：相对位置模拟。</value>
        [JsonConverter(typeof(EnumClassConverter<MouseSimulationModeEnum>))]
        public class MouseSimulationModeEnum
        {
            /// <summary>
            /// Enum ABSOLUTE_POSITION for value: ABSOLUTE_POSITION
            /// </summary>
            public static readonly MouseSimulationModeEnum ABSOLUTE_POSITION = new MouseSimulationModeEnum("ABSOLUTE_POSITION");

            /// <summary>
            /// Enum RELATIVE_POSITION for value: RELATIVE_POSITION
            /// </summary>
            public static readonly MouseSimulationModeEnum RELATIVE_POSITION = new MouseSimulationModeEnum("RELATIVE_POSITION");

            private static readonly Dictionary<string, MouseSimulationModeEnum> StaticFields =
            new Dictionary<string, MouseSimulationModeEnum>()
            {
                { "ABSOLUTE_POSITION", ABSOLUTE_POSITION },
                { "RELATIVE_POSITION", RELATIVE_POSITION },
            };

            private string _value;

            public MouseSimulationModeEnum()
            {

            }

            public MouseSimulationModeEnum(string value)
            {
                _value = value;
            }

            public static MouseSimulationModeEnum FromValue(string value)
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

                if (this.Equals(obj as MouseSimulationModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(MouseSimulationModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(MouseSimulationModeEnum a, MouseSimulationModeEnum b)
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

            public static bool operator !=(MouseSimulationModeEnum a, MouseSimulationModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 虚拟机鼠标回馈。取值为： SELFADAPTION：自适应鼠标回馈。 FORCE：强制鼠标回馈。 CLOSE：关闭鼠标回馈。
        /// </summary>
        [JsonProperty("mouse_feedback", NullValueHandling = NullValueHandling.Ignore)]
        public MouseFeedbackEnum MouseFeedback { get; set; }
        /// <summary>
        /// 虚拟机鼠标模拟方式。取值为： ABSOLUTE_POSITION：绝对位置模拟。 RELATIVE_POSITION：相对位置模拟。
        /// </summary>
        [JsonProperty("mouse_simulation_mode", NullValueHandling = NullValueHandling.Ignore)]
        public MouseSimulationModeEnum MouseSimulationMode { get; set; }
        /// <summary>
        /// 虚拟机外部光标反馈。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("external_cursor_feedback", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExternalCursorFeedback { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesKeyboardMouse {\n");
            sb.Append("  mouseFeedback: ").Append(MouseFeedback).Append("\n");
            sb.Append("  mouseSimulationMode: ").Append(MouseSimulationMode).Append("\n");
            sb.Append("  externalCursorFeedback: ").Append(ExternalCursorFeedback).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesKeyboardMouse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesKeyboardMouse input)
        {
            if (input == null) return false;
            if (this.MouseFeedback != input.MouseFeedback) return false;
            if (this.MouseSimulationMode != input.MouseSimulationMode) return false;
            if (this.ExternalCursorFeedback != input.ExternalCursorFeedback || (this.ExternalCursorFeedback != null && !this.ExternalCursorFeedback.Equals(input.ExternalCursorFeedback))) return false;

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
                hashCode = hashCode * 59 + this.MouseFeedback.GetHashCode();
                hashCode = hashCode * 59 + this.MouseSimulationMode.GetHashCode();
                if (this.ExternalCursorFeedback != null) hashCode = hashCode * 59 + this.ExternalCursorFeedback.GetHashCode();
                return hashCode;
            }
        }
    }
}
