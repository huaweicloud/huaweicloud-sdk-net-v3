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
    /// 脚本执行任务信息。
    /// </summary>
    public class ScriptExecutionTask 
    {
        /// <summary>
        /// 任务状态，值含： - FINISH：已完成。 - FAILED：失败。 - RUNNING：运行中。 - INIT： 初始化。
        /// </summary>
        /// <value>任务状态，值含： - FINISH：已完成。 - FAILED：失败。 - RUNNING：运行中。 - INIT： 初始化。</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum FINISH for value: FINISH
            /// </summary>
            public static readonly StatusEnum FINISH = new StatusEnum("FINISH");

            /// <summary>
            /// Enum FAILED for value: FAILED
            /// </summary>
            public static readonly StatusEnum FAILED = new StatusEnum("FAILED");

            /// <summary>
            /// Enum RUNNING for value: RUNNING
            /// </summary>
            public static readonly StatusEnum RUNNING = new StatusEnum("RUNNING");

            /// <summary>
            /// Enum INIT for value: INIT
            /// </summary>
            public static readonly StatusEnum INIT = new StatusEnum("INIT");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "FINISH", FINISH },
                { "FAILED", FAILED },
                { "RUNNING", RUNNING },
                { "INIT", INIT },
            };

            private string _value;

            public StatusEnum()
            {

            }

            public StatusEnum(string value)
            {
                _value = value;
            }

            public static StatusEnum FromValue(string value)
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

                if (this.Equals(obj as StatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 任务id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 桌面池id。
        /// </summary>
        [JsonProperty("desktop_pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopPoolId { get; set; }

        /// <summary>
        /// 桌面池名称。
        /// </summary>
        [JsonProperty("desktop_pool_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopPoolName { get; set; }

        /// <summary>
        /// 脚本信息列表。
        /// </summary>
        [JsonProperty("scripts", NullValueHandling = NullValueHandling.Ignore)]
        public List<Script> Scripts { get; set; }

        /// <summary>
        /// 执行的命令行。
        /// </summary>
        [JsonProperty("command_content", NullValueHandling = NullValueHandling.Ignore)]
        public string CommandContent { get; set; }

        /// <summary>
        /// 命令行类型。 - POWERSHELL：WINDOWS系统使用。 - BAT：WINDOWS系统使用。 - SHELL：LINUX系统使用。
        /// </summary>
        [JsonProperty("command_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CommandType { get; set; }

        /// <summary>
        /// 任务开始时间，格式为：yyyy-MM-ddTHH:mm:ssZ。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 任务结束时间，格式为：yyyy-MM-ddTHH:mm:ssZ。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 任务状态，值含： - FINISH：已完成。 - FAILED：失败。 - RUNNING：运行中。 - INIT： 初始化。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 成功数量。
        /// </summary>
        [JsonProperty("success_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? SuccessNum { get; set; }

        /// <summary>
        /// 失败数量。
        /// </summary>
        [JsonProperty("failed_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? FailedNum { get; set; }

        /// <summary>
        /// 跳过数量。
        /// </summary>
        [JsonProperty("skip_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? SkipNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScriptExecutionTask {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  desktopPoolId: ").Append(DesktopPoolId).Append("\n");
            sb.Append("  desktopPoolName: ").Append(DesktopPoolName).Append("\n");
            sb.Append("  scripts: ").Append(Scripts).Append("\n");
            sb.Append("  commandContent: ").Append(CommandContent).Append("\n");
            sb.Append("  commandType: ").Append(CommandType).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  successNum: ").Append(SuccessNum).Append("\n");
            sb.Append("  failedNum: ").Append(FailedNum).Append("\n");
            sb.Append("  skipNum: ").Append(SkipNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScriptExecutionTask);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ScriptExecutionTask input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.DesktopPoolId != input.DesktopPoolId || (this.DesktopPoolId != null && !this.DesktopPoolId.Equals(input.DesktopPoolId))) return false;
            if (this.DesktopPoolName != input.DesktopPoolName || (this.DesktopPoolName != null && !this.DesktopPoolName.Equals(input.DesktopPoolName))) return false;
            if (this.Scripts != input.Scripts || (this.Scripts != null && input.Scripts != null && !this.Scripts.SequenceEqual(input.Scripts))) return false;
            if (this.CommandContent != input.CommandContent || (this.CommandContent != null && !this.CommandContent.Equals(input.CommandContent))) return false;
            if (this.CommandType != input.CommandType || (this.CommandType != null && !this.CommandType.Equals(input.CommandType))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.Status != input.Status) return false;
            if (this.SuccessNum != input.SuccessNum || (this.SuccessNum != null && !this.SuccessNum.Equals(input.SuccessNum))) return false;
            if (this.FailedNum != input.FailedNum || (this.FailedNum != null && !this.FailedNum.Equals(input.FailedNum))) return false;
            if (this.SkipNum != input.SkipNum || (this.SkipNum != null && !this.SkipNum.Equals(input.SkipNum))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.DesktopPoolId != null) hashCode = hashCode * 59 + this.DesktopPoolId.GetHashCode();
                if (this.DesktopPoolName != null) hashCode = hashCode * 59 + this.DesktopPoolName.GetHashCode();
                if (this.Scripts != null) hashCode = hashCode * 59 + this.Scripts.GetHashCode();
                if (this.CommandContent != null) hashCode = hashCode * 59 + this.CommandContent.GetHashCode();
                if (this.CommandType != null) hashCode = hashCode * 59 + this.CommandType.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.SuccessNum != null) hashCode = hashCode * 59 + this.SuccessNum.GetHashCode();
                if (this.FailedNum != null) hashCode = hashCode * 59 + this.FailedNum.GetHashCode();
                if (this.SkipNum != null) hashCode = hashCode * 59 + this.SkipNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
