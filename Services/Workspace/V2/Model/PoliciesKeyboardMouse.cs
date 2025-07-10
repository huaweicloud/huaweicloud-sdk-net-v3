using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
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

            public static bool operator !=(MouseSimulationModeEnum a, MouseSimulationModeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// Windows客户端键盘模式。取值为： GLOBAL：Windows客户端键盘全局模式。（默认） WINDOW：Windows客户端键盘窗口模式。
        /// </summary>
        /// <value>Windows客户端键盘模式。取值为： GLOBAL：Windows客户端键盘全局模式。（默认） WINDOW：Windows客户端键盘窗口模式。</value>
        [JsonConverter(typeof(EnumClassConverter<WindowsClientKeyboardModeEnum>))]
        public class WindowsClientKeyboardModeEnum
        {
            /// <summary>
            /// Enum GLOBAL for value: GLOBAL
            /// </summary>
            public static readonly WindowsClientKeyboardModeEnum GLOBAL = new WindowsClientKeyboardModeEnum("GLOBAL");

            /// <summary>
            /// Enum WINDOW for value: WINDOW
            /// </summary>
            public static readonly WindowsClientKeyboardModeEnum WINDOW = new WindowsClientKeyboardModeEnum("WINDOW");

            private static readonly Dictionary<string, WindowsClientKeyboardModeEnum> StaticFields =
            new Dictionary<string, WindowsClientKeyboardModeEnum>()
            {
                { "GLOBAL", GLOBAL },
                { "WINDOW", WINDOW },
            };

            private string _value;

            public WindowsClientKeyboardModeEnum()
            {

            }

            public WindowsClientKeyboardModeEnum(string value)
            {
                _value = value;
            }

            public static WindowsClientKeyboardModeEnum FromValue(string value)
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

                if (this.Equals(obj as WindowsClientKeyboardModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(WindowsClientKeyboardModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(WindowsClientKeyboardModeEnum a, WindowsClientKeyboardModeEnum b)
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

            public static bool operator !=(WindowsClientKeyboardModeEnum a, WindowsClientKeyboardModeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// Windows客户端鼠标模式。取值为： GLOBAL：Windows客户端鼠标全局模式。 WINDOW：Windows客户端鼠标窗口模式。（默认）
        /// </summary>
        /// <value>Windows客户端鼠标模式。取值为： GLOBAL：Windows客户端鼠标全局模式。 WINDOW：Windows客户端鼠标窗口模式。（默认）</value>
        [JsonConverter(typeof(EnumClassConverter<WindowsClientMouseModeEnum>))]
        public class WindowsClientMouseModeEnum
        {
            /// <summary>
            /// Enum GLOBAL for value: GLOBAL
            /// </summary>
            public static readonly WindowsClientMouseModeEnum GLOBAL = new WindowsClientMouseModeEnum("GLOBAL");

            /// <summary>
            /// Enum WINDOW for value: WINDOW
            /// </summary>
            public static readonly WindowsClientMouseModeEnum WINDOW = new WindowsClientMouseModeEnum("WINDOW");

            private static readonly Dictionary<string, WindowsClientMouseModeEnum> StaticFields =
            new Dictionary<string, WindowsClientMouseModeEnum>()
            {
                { "GLOBAL", GLOBAL },
                { "WINDOW", WINDOW },
            };

            private string _value;

            public WindowsClientMouseModeEnum()
            {

            }

            public WindowsClientMouseModeEnum(string value)
            {
                _value = value;
            }

            public static WindowsClientMouseModeEnum FromValue(string value)
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

                if (this.Equals(obj as WindowsClientMouseModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(WindowsClientMouseModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(WindowsClientMouseModeEnum a, WindowsClientMouseModeEnum b)
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

            public static bool operator !=(WindowsClientMouseModeEnum a, WindowsClientMouseModeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// Linux客户端键盘模式。取值为： EVENT：Linux客户端键盘事件模式。（默认） GRAPH：Linux客户端键盘图形模式。
        /// </summary>
        /// <value>Linux客户端键盘模式。取值为： EVENT：Linux客户端键盘事件模式。（默认） GRAPH：Linux客户端键盘图形模式。</value>
        [JsonConverter(typeof(EnumClassConverter<LinuxClientKeyboardModeEnum>))]
        public class LinuxClientKeyboardModeEnum
        {
            /// <summary>
            /// Enum EVENT for value: EVENT
            /// </summary>
            public static readonly LinuxClientKeyboardModeEnum EVENT = new LinuxClientKeyboardModeEnum("EVENT");

            /// <summary>
            /// Enum GRAPH for value: GRAPH
            /// </summary>
            public static readonly LinuxClientKeyboardModeEnum GRAPH = new LinuxClientKeyboardModeEnum("GRAPH");

            private static readonly Dictionary<string, LinuxClientKeyboardModeEnum> StaticFields =
            new Dictionary<string, LinuxClientKeyboardModeEnum>()
            {
                { "EVENT", EVENT },
                { "GRAPH", GRAPH },
            };

            private string _value;

            public LinuxClientKeyboardModeEnum()
            {

            }

            public LinuxClientKeyboardModeEnum(string value)
            {
                _value = value;
            }

            public static LinuxClientKeyboardModeEnum FromValue(string value)
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

                if (this.Equals(obj as LinuxClientKeyboardModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(LinuxClientKeyboardModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(LinuxClientKeyboardModeEnum a, LinuxClientKeyboardModeEnum b)
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

            public static bool operator !=(LinuxClientKeyboardModeEnum a, LinuxClientKeyboardModeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// Linux客户端鼠标模式。取值为： EVENT：Linux客户端鼠标事件模式。（默认） GRAPH：Linux客户端鼠标窗口模式。
        /// </summary>
        /// <value>Linux客户端鼠标模式。取值为： EVENT：Linux客户端鼠标事件模式。（默认） GRAPH：Linux客户端鼠标窗口模式。</value>
        [JsonConverter(typeof(EnumClassConverter<LinuxClientMouseModeEnum>))]
        public class LinuxClientMouseModeEnum
        {
            /// <summary>
            /// Enum EVENT for value: EVENT
            /// </summary>
            public static readonly LinuxClientMouseModeEnum EVENT = new LinuxClientMouseModeEnum("EVENT");

            /// <summary>
            /// Enum GRAPH for value: GRAPH
            /// </summary>
            public static readonly LinuxClientMouseModeEnum GRAPH = new LinuxClientMouseModeEnum("GRAPH");

            private static readonly Dictionary<string, LinuxClientMouseModeEnum> StaticFields =
            new Dictionary<string, LinuxClientMouseModeEnum>()
            {
                { "EVENT", EVENT },
                { "GRAPH", GRAPH },
            };

            private string _value;

            public LinuxClientMouseModeEnum()
            {

            }

            public LinuxClientMouseModeEnum(string value)
            {
                _value = value;
            }

            public static LinuxClientMouseModeEnum FromValue(string value)
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

                if (this.Equals(obj as LinuxClientMouseModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(LinuxClientMouseModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(LinuxClientMouseModeEnum a, LinuxClientMouseModeEnum b)
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

            public static bool operator !=(LinuxClientMouseModeEnum a, LinuxClientMouseModeEnum b)
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
        /// 自助维护台抢占登录。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("selfhelp_console_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SelfhelpConsoleEnable { get; set; }

        /// <summary>
        /// 客户端鼠标发送间隔。取值范围为[1-30]。默认：30。
        /// </summary>
        [JsonProperty("client_mouse_send_interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? ClientMouseSendInterval { get; set; }

        /// <summary>
        /// Windows客户端键盘模式。取值为： GLOBAL：Windows客户端键盘全局模式。（默认） WINDOW：Windows客户端键盘窗口模式。
        /// </summary>
        [JsonProperty("windows_client_keyboard_mode", NullValueHandling = NullValueHandling.Ignore)]
        public WindowsClientKeyboardModeEnum WindowsClientKeyboardMode { get; set; }
        /// <summary>
        /// Windows客户端鼠标模式。取值为： GLOBAL：Windows客户端鼠标全局模式。 WINDOW：Windows客户端鼠标窗口模式。（默认）
        /// </summary>
        [JsonProperty("windows_client_mouse_mode", NullValueHandling = NullValueHandling.Ignore)]
        public WindowsClientMouseModeEnum WindowsClientMouseMode { get; set; }
        /// <summary>
        /// Linux客户端键盘模式。取值为： EVENT：Linux客户端键盘事件模式。（默认） GRAPH：Linux客户端键盘图形模式。
        /// </summary>
        [JsonProperty("linux_client_keyboard_mode", NullValueHandling = NullValueHandling.Ignore)]
        public LinuxClientKeyboardModeEnum LinuxClientKeyboardMode { get; set; }
        /// <summary>
        /// Linux客户端鼠标模式。取值为： EVENT：Linux客户端鼠标事件模式。（默认） GRAPH：Linux客户端鼠标窗口模式。
        /// </summary>
        [JsonProperty("linux_client_mouse_mode", NullValueHandling = NullValueHandling.Ignore)]
        public LinuxClientMouseModeEnum LinuxClientMouseMode { get; set; }
        /// <summary>
        /// 特殊键盘。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("special_keyboard", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SpecialKeyboard { get; set; }

        /// <summary>
        /// 游戏操纵杆。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("joy_stick_flag", NullValueHandling = NullValueHandling.Ignore)]
        public bool? JoyStickFlag { get; set; }



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
            sb.Append("  selfhelpConsoleEnable: ").Append(SelfhelpConsoleEnable).Append("\n");
            sb.Append("  clientMouseSendInterval: ").Append(ClientMouseSendInterval).Append("\n");
            sb.Append("  windowsClientKeyboardMode: ").Append(WindowsClientKeyboardMode).Append("\n");
            sb.Append("  windowsClientMouseMode: ").Append(WindowsClientMouseMode).Append("\n");
            sb.Append("  linuxClientKeyboardMode: ").Append(LinuxClientKeyboardMode).Append("\n");
            sb.Append("  linuxClientMouseMode: ").Append(LinuxClientMouseMode).Append("\n");
            sb.Append("  specialKeyboard: ").Append(SpecialKeyboard).Append("\n");
            sb.Append("  joyStickFlag: ").Append(JoyStickFlag).Append("\n");
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
            if (this.SelfhelpConsoleEnable != input.SelfhelpConsoleEnable || (this.SelfhelpConsoleEnable != null && !this.SelfhelpConsoleEnable.Equals(input.SelfhelpConsoleEnable))) return false;
            if (this.ClientMouseSendInterval != input.ClientMouseSendInterval || (this.ClientMouseSendInterval != null && !this.ClientMouseSendInterval.Equals(input.ClientMouseSendInterval))) return false;
            if (this.WindowsClientKeyboardMode != input.WindowsClientKeyboardMode) return false;
            if (this.WindowsClientMouseMode != input.WindowsClientMouseMode) return false;
            if (this.LinuxClientKeyboardMode != input.LinuxClientKeyboardMode) return false;
            if (this.LinuxClientMouseMode != input.LinuxClientMouseMode) return false;
            if (this.SpecialKeyboard != input.SpecialKeyboard || (this.SpecialKeyboard != null && !this.SpecialKeyboard.Equals(input.SpecialKeyboard))) return false;
            if (this.JoyStickFlag != input.JoyStickFlag || (this.JoyStickFlag != null && !this.JoyStickFlag.Equals(input.JoyStickFlag))) return false;

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
                if (this.SelfhelpConsoleEnable != null) hashCode = hashCode * 59 + this.SelfhelpConsoleEnable.GetHashCode();
                if (this.ClientMouseSendInterval != null) hashCode = hashCode * 59 + this.ClientMouseSendInterval.GetHashCode();
                hashCode = hashCode * 59 + this.WindowsClientKeyboardMode.GetHashCode();
                hashCode = hashCode * 59 + this.WindowsClientMouseMode.GetHashCode();
                hashCode = hashCode * 59 + this.LinuxClientKeyboardMode.GetHashCode();
                hashCode = hashCode * 59 + this.LinuxClientMouseMode.GetHashCode();
                if (this.SpecialKeyboard != null) hashCode = hashCode * 59 + this.SpecialKeyboard.GetHashCode();
                if (this.JoyStickFlag != null) hashCode = hashCode * 59 + this.JoyStickFlag.GetHashCode();
                return hashCode;
            }
        }
    }
}
