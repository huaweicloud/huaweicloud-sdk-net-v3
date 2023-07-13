using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kps.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListKeypairTaskResponse : SdkResponse
    {
        /// <summary>
        /// 密钥对正在处理的状态。 - READY_RESET 准备重置 - RUNNING_RESET 正在重置 - FAILED_RESET 重置失败 - SUCCESS_RESET 重置成功 - READY_REPLACE 准备替换 - RUNNING_REPLACE 正在替换 - FAILED_RESET 替换失败 - SUCCESS_RESET 替换成功 - READY_UNBIND 准备解绑 - RUNNING_UNBIND 正在解绑 - FAILED_UNBIND 解绑失败 - SUCCESS_UNBIND 解绑成功
        /// </summary>
        /// <value>密钥对正在处理的状态。 - READY_RESET 准备重置 - RUNNING_RESET 正在重置 - FAILED_RESET 重置失败 - SUCCESS_RESET 重置成功 - READY_REPLACE 准备替换 - RUNNING_REPLACE 正在替换 - FAILED_RESET 替换失败 - SUCCESS_RESET 替换成功 - READY_UNBIND 准备解绑 - RUNNING_UNBIND 正在解绑 - FAILED_UNBIND 解绑失败 - SUCCESS_UNBIND 解绑成功</value>
        [JsonConverter(typeof(EnumClassConverter<TaskStatusEnum>))]
        public class TaskStatusEnum
        {
            /// <summary>
            /// Enum READY_RESET for value: READY_RESET
            /// </summary>
            public static readonly TaskStatusEnum READY_RESET = new TaskStatusEnum("READY_RESET");

            /// <summary>
            /// Enum RUNNING_RESET for value: RUNNING_RESET
            /// </summary>
            public static readonly TaskStatusEnum RUNNING_RESET = new TaskStatusEnum("RUNNING_RESET");

            /// <summary>
            /// Enum FAILED_RESET for value: FAILED_RESET
            /// </summary>
            public static readonly TaskStatusEnum FAILED_RESET = new TaskStatusEnum("FAILED_RESET");

            /// <summary>
            /// Enum SUCCESS_RESET for value: SUCCESS_RESET
            /// </summary>
            public static readonly TaskStatusEnum SUCCESS_RESET = new TaskStatusEnum("SUCCESS_RESET");

            /// <summary>
            /// Enum READY_REPLACE for value: READY_REPLACE
            /// </summary>
            public static readonly TaskStatusEnum READY_REPLACE = new TaskStatusEnum("READY_REPLACE");

            /// <summary>
            /// Enum RUNNING_REPLACE for value: RUNNING_REPLACE
            /// </summary>
            public static readonly TaskStatusEnum RUNNING_REPLACE = new TaskStatusEnum("RUNNING_REPLACE");

            /// <summary>
            /// Enum READY_UNBIND for value: READY_UNBIND
            /// </summary>
            public static readonly TaskStatusEnum READY_UNBIND = new TaskStatusEnum("READY_UNBIND");

            /// <summary>
            /// Enum RUNNING_UNBIND for value: RUNNING_UNBIND
            /// </summary>
            public static readonly TaskStatusEnum RUNNING_UNBIND = new TaskStatusEnum("RUNNING_UNBIND");

            /// <summary>
            /// Enum FAILED_UNBIND for value: FAILED_UNBIND
            /// </summary>
            public static readonly TaskStatusEnum FAILED_UNBIND = new TaskStatusEnum("FAILED_UNBIND");

            /// <summary>
            /// Enum SUCCESS_UNBIND for value: SUCCESS_UNBIND
            /// </summary>
            public static readonly TaskStatusEnum SUCCESS_UNBIND = new TaskStatusEnum("SUCCESS_UNBIND");

            private static readonly Dictionary<string, TaskStatusEnum> StaticFields =
            new Dictionary<string, TaskStatusEnum>()
            {
                { "READY_RESET", READY_RESET },
                { "RUNNING_RESET", RUNNING_RESET },
                { "FAILED_RESET", FAILED_RESET },
                { "SUCCESS_RESET", SUCCESS_RESET },
                { "READY_REPLACE", READY_REPLACE },
                { "RUNNING_REPLACE", RUNNING_REPLACE },
                { "READY_UNBIND", READY_UNBIND },
                { "RUNNING_UNBIND", RUNNING_UNBIND },
                { "FAILED_UNBIND", FAILED_UNBIND },
                { "SUCCESS_UNBIND", SUCCESS_UNBIND },
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
        /// 租户虚拟机ID
        /// </summary>
        [JsonProperty("server_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerId { get; set; }

        /// <summary>
        /// 任务下发成功返回的ID
        /// </summary>
        [JsonProperty("task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskId { get; set; }

        /// <summary>
        /// 密钥对正在处理的状态。 - READY_RESET 准备重置 - RUNNING_RESET 正在重置 - FAILED_RESET 重置失败 - SUCCESS_RESET 重置成功 - READY_REPLACE 准备替换 - RUNNING_REPLACE 正在替换 - FAILED_RESET 替换失败 - SUCCESS_RESET 替换成功 - READY_UNBIND 准备解绑 - RUNNING_UNBIND 正在解绑 - FAILED_UNBIND 解绑失败 - SUCCESS_UNBIND 解绑成功
        /// </summary>
        [JsonProperty("task_status", NullValueHandling = NullValueHandling.Ignore)]
        public TaskStatusEnum TaskStatus { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListKeypairTaskResponse {\n");
            sb.Append("  serverId: ").Append(ServerId).Append("\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("  taskStatus: ").Append(TaskStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListKeypairTaskResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListKeypairTaskResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ServerId == input.ServerId ||
                    (this.ServerId != null &&
                    this.ServerId.Equals(input.ServerId))
                ) && 
                (
                    this.TaskId == input.TaskId ||
                    (this.TaskId != null &&
                    this.TaskId.Equals(input.TaskId))
                ) && 
                (
                    this.TaskStatus == input.TaskStatus ||
                    (this.TaskStatus != null &&
                    this.TaskStatus.Equals(input.TaskStatus))
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
                if (this.ServerId != null)
                    hashCode = hashCode * 59 + this.ServerId.GetHashCode();
                if (this.TaskId != null)
                    hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.TaskStatus != null)
                    hashCode = hashCode * 59 + this.TaskStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
