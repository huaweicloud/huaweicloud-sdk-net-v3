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
    /// 按桌面标签下发执行脚本或命令请求体。
    /// </summary>
    public class ExecuteScriptByDesktopTagReq 
    {
        /// <summary>
        /// 命令行类型，执行命令行时必传。 - POWERSHELL：WINDOWS系统使用。 - BAT：WINDOWS系统使用。 - SHELL：LINUX系统使用。
        /// </summary>
        /// <value>命令行类型，执行命令行时必传。 - POWERSHELL：WINDOWS系统使用。 - BAT：WINDOWS系统使用。 - SHELL：LINUX系统使用。</value>
        [JsonConverter(typeof(EnumClassConverter<CommandTypeEnum>))]
        public class CommandTypeEnum
        {
            /// <summary>
            /// Enum POWERSHELL for value: POWERSHELL
            /// </summary>
            public static readonly CommandTypeEnum POWERSHELL = new CommandTypeEnum("POWERSHELL");

            /// <summary>
            /// Enum BAT for value: BAT
            /// </summary>
            public static readonly CommandTypeEnum BAT = new CommandTypeEnum("BAT");

            /// <summary>
            /// Enum SHELL for value: SHELL
            /// </summary>
            public static readonly CommandTypeEnum SHELL = new CommandTypeEnum("SHELL");

            private static readonly Dictionary<string, CommandTypeEnum> StaticFields =
            new Dictionary<string, CommandTypeEnum>()
            {
                { "POWERSHELL", POWERSHELL },
                { "BAT", BAT },
                { "SHELL", SHELL },
            };

            private string _value;

            public CommandTypeEnum()
            {

            }

            public CommandTypeEnum(string value)
            {
                _value = value;
            }

            public static CommandTypeEnum FromValue(string value)
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

                if (this.Equals(obj as CommandTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CommandTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CommandTypeEnum a, CommandTypeEnum b)
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

            public static bool operator !=(CommandTypeEnum a, CommandTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 桌面标签。
        /// </summary>
        [JsonProperty("desktop_tag", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopTag { get; set; }

        /// <summary>
        /// 执行的脚本id列表，与command二选一。
        /// </summary>
        [JsonProperty("script_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ScriptIds { get; set; }

        /// <summary>
        /// 首批执行的桌面数量，优先级高于gray_desktop_ids。
        /// </summary>
        [JsonProperty("gray_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? GrayCount { get; set; }

        /// <summary>
        /// 首批执行的桌面id列表，优先级低于gray_count。
        /// </summary>
        [JsonProperty("gray_desktop_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> GrayDesktopIds { get; set; }

        /// <summary>
        /// 灰度失败阈值，灰度执行失败次数达到该值时，不执行下一批任务。
        /// </summary>
        [JsonProperty("gray_fail_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? GrayFailThreshold { get; set; }

        /// <summary>
        /// 执行脚本前置步骤。
        /// </summary>
        [JsonProperty("pre_start", NullValueHandling = NullValueHandling.Ignore)]
        public string PreStart { get; set; }

        /// <summary>
        /// 执行脚本完成后置步骤，当前支持关机（stop）、重启（reboot）。
        /// </summary>
        [JsonProperty("post_finish", NullValueHandling = NullValueHandling.Ignore)]
        public string PostFinish { get; set; }

        /// <summary>
        /// 执行的命令行，与script_ids二选一。
        /// </summary>
        [JsonProperty("command_content", NullValueHandling = NullValueHandling.Ignore)]
        public string CommandContent { get; set; }

        /// <summary>
        /// 命令行类型，执行命令行时必传。 - POWERSHELL：WINDOWS系统使用。 - BAT：WINDOWS系统使用。 - SHELL：LINUX系统使用。
        /// </summary>
        [JsonProperty("command_type", NullValueHandling = NullValueHandling.Ignore)]
        public CommandTypeEnum CommandType { get; set; }
        /// <summary>
        /// 执行脚本的超时时间，单位分钟，默认1分钟。
        /// </summary>
        [JsonProperty("execution_timeout", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExecutionTimeout { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExecuteScriptByDesktopTagReq {\n");
            sb.Append("  desktopTag: ").Append(DesktopTag).Append("\n");
            sb.Append("  scriptIds: ").Append(ScriptIds).Append("\n");
            sb.Append("  grayCount: ").Append(GrayCount).Append("\n");
            sb.Append("  grayDesktopIds: ").Append(GrayDesktopIds).Append("\n");
            sb.Append("  grayFailThreshold: ").Append(GrayFailThreshold).Append("\n");
            sb.Append("  preStart: ").Append(PreStart).Append("\n");
            sb.Append("  postFinish: ").Append(PostFinish).Append("\n");
            sb.Append("  commandContent: ").Append(CommandContent).Append("\n");
            sb.Append("  commandType: ").Append(CommandType).Append("\n");
            sb.Append("  executionTimeout: ").Append(ExecutionTimeout).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExecuteScriptByDesktopTagReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExecuteScriptByDesktopTagReq input)
        {
            if (input == null) return false;
            if (this.DesktopTag != input.DesktopTag || (this.DesktopTag != null && !this.DesktopTag.Equals(input.DesktopTag))) return false;
            if (this.ScriptIds != input.ScriptIds || (this.ScriptIds != null && input.ScriptIds != null && !this.ScriptIds.SequenceEqual(input.ScriptIds))) return false;
            if (this.GrayCount != input.GrayCount || (this.GrayCount != null && !this.GrayCount.Equals(input.GrayCount))) return false;
            if (this.GrayDesktopIds != input.GrayDesktopIds || (this.GrayDesktopIds != null && input.GrayDesktopIds != null && !this.GrayDesktopIds.SequenceEqual(input.GrayDesktopIds))) return false;
            if (this.GrayFailThreshold != input.GrayFailThreshold || (this.GrayFailThreshold != null && !this.GrayFailThreshold.Equals(input.GrayFailThreshold))) return false;
            if (this.PreStart != input.PreStart || (this.PreStart != null && !this.PreStart.Equals(input.PreStart))) return false;
            if (this.PostFinish != input.PostFinish || (this.PostFinish != null && !this.PostFinish.Equals(input.PostFinish))) return false;
            if (this.CommandContent != input.CommandContent || (this.CommandContent != null && !this.CommandContent.Equals(input.CommandContent))) return false;
            if (this.CommandType != input.CommandType) return false;
            if (this.ExecutionTimeout != input.ExecutionTimeout || (this.ExecutionTimeout != null && !this.ExecutionTimeout.Equals(input.ExecutionTimeout))) return false;

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
                if (this.DesktopTag != null) hashCode = hashCode * 59 + this.DesktopTag.GetHashCode();
                if (this.ScriptIds != null) hashCode = hashCode * 59 + this.ScriptIds.GetHashCode();
                if (this.GrayCount != null) hashCode = hashCode * 59 + this.GrayCount.GetHashCode();
                if (this.GrayDesktopIds != null) hashCode = hashCode * 59 + this.GrayDesktopIds.GetHashCode();
                if (this.GrayFailThreshold != null) hashCode = hashCode * 59 + this.GrayFailThreshold.GetHashCode();
                if (this.PreStart != null) hashCode = hashCode * 59 + this.PreStart.GetHashCode();
                if (this.PostFinish != null) hashCode = hashCode * 59 + this.PostFinish.GetHashCode();
                if (this.CommandContent != null) hashCode = hashCode * 59 + this.CommandContent.GetHashCode();
                hashCode = hashCode * 59 + this.CommandType.GetHashCode();
                if (this.ExecutionTimeout != null) hashCode = hashCode * 59 + this.ExecutionTimeout.GetHashCode();
                return hashCode;
            }
        }
    }
}
