using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.AntiDDoS.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowNewTaskStatusResponse : SdkResponse
    {
        /// <summary>
        /// 任务状态，可选范围： - success: 表示成功 - failed: 表示失败 - waiting: 表示等待 - running: 表示运行中 - preprocess: 表示预处理 - ready: 表示准备
        /// </summary>
        /// <value>任务状态，可选范围： - success: 表示成功 - failed: 表示失败 - waiting: 表示等待 - running: 表示运行中 - preprocess: 表示预处理 - ready: 表示准备</value>
        [JsonConverter(typeof(EnumClassConverter<TaskStatusEnum>))]
        public class TaskStatusEnum
        {
            /// <summary>
            /// Enum SUCCESS for value: success
            /// </summary>
            public static readonly TaskStatusEnum SUCCESS = new TaskStatusEnum("success");

            /// <summary>
            /// Enum FAILED for value: failed
            /// </summary>
            public static readonly TaskStatusEnum FAILED = new TaskStatusEnum("failed");

            /// <summary>
            /// Enum WAITING for value: waiting
            /// </summary>
            public static readonly TaskStatusEnum WAITING = new TaskStatusEnum("waiting");

            /// <summary>
            /// Enum RUNNING for value: running
            /// </summary>
            public static readonly TaskStatusEnum RUNNING = new TaskStatusEnum("running");

            /// <summary>
            /// Enum PREPROCESS for value: preprocess
            /// </summary>
            public static readonly TaskStatusEnum PREPROCESS = new TaskStatusEnum("preprocess");

            /// <summary>
            /// Enum READY for value: ready
            /// </summary>
            public static readonly TaskStatusEnum READY = new TaskStatusEnum("ready");

            private static readonly Dictionary<string, TaskStatusEnum> StaticFields =
            new Dictionary<string, TaskStatusEnum>()
            {
                { "success", SUCCESS },
                { "failed", FAILED },
                { "waiting", WAITING },
                { "running", RUNNING },
                { "preprocess", PREPROCESS },
                { "ready", READY },
            };

            private string _value;

            public TaskStatusEnum()
            {

            }

            public TaskStatusEnum(string value)
            {
                _value = value;
            }

            public static TaskStatusEnum FromValue(string value)
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

                if (this.Equals(obj as TaskStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TaskStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TaskStatusEnum a, TaskStatusEnum b)
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

            public static bool operator !=(TaskStatusEnum a, TaskStatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 任务状态，可选范围： - success: 表示成功 - failed: 表示失败 - waiting: 表示等待 - running: 表示运行中 - preprocess: 表示预处理 - ready: 表示准备
        /// </summary>
        [JsonProperty("task_status", NullValueHandling = NullValueHandling.Ignore)]
        public TaskStatusEnum TaskStatus { get; set; }
        /// <summary>
        /// 任务的附加信息
        /// </summary>
        [JsonProperty("task_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskMsg { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowNewTaskStatusResponse {\n");
            sb.Append("  taskStatus: ").Append(TaskStatus).Append("\n");
            sb.Append("  taskMsg: ").Append(TaskMsg).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowNewTaskStatusResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowNewTaskStatusResponse input)
        {
            if (input == null) return false;
            if (this.TaskStatus != input.TaskStatus) return false;
            if (this.TaskMsg != input.TaskMsg || (this.TaskMsg != null && !this.TaskMsg.Equals(input.TaskMsg))) return false;

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
                hashCode = hashCode * 59 + this.TaskStatus.GetHashCode();
                if (this.TaskMsg != null) hashCode = hashCode * 59 + this.TaskMsg.GetHashCode();
                return hashCode;
            }
        }
    }
}
