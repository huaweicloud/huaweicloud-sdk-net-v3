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
    /// 失败的任务详细信息。
    /// </summary>
    public class FailedTasks 
    {
        /// <summary>
        /// 任务的操作类型。 - FAILED_RESET 重置 - FAILED_REPLACE 替换 - FAILED_UNBIND 解绑
        /// </summary>
        /// <value>任务的操作类型。 - FAILED_RESET 重置 - FAILED_REPLACE 替换 - FAILED_UNBIND 解绑</value>
        [JsonConverter(typeof(EnumClassConverter<OperateTypeEnum>))]
        public class OperateTypeEnum
        {
            /// <summary>
            /// Enum FAILED_RESET for value: FAILED_RESET
            /// </summary>
            public static readonly OperateTypeEnum FAILED_RESET = new OperateTypeEnum("FAILED_RESET");

            /// <summary>
            /// Enum FAILED_REPLACE for value: FAILED_REPLACE
            /// </summary>
            public static readonly OperateTypeEnum FAILED_REPLACE = new OperateTypeEnum("FAILED_REPLACE");

            /// <summary>
            /// Enum FAILED_UNBIND for value: FAILED_UNBIND
            /// </summary>
            public static readonly OperateTypeEnum FAILED_UNBIND = new OperateTypeEnum("FAILED_UNBIND");

            private static readonly Dictionary<string, OperateTypeEnum> StaticFields =
            new Dictionary<string, OperateTypeEnum>()
            {
                { "FAILED_RESET", FAILED_RESET },
                { "FAILED_REPLACE", FAILED_REPLACE },
                { "FAILED_UNBIND", FAILED_UNBIND },
            };

            private string _value;

            public OperateTypeEnum()
            {

            }

            public OperateTypeEnum(string value)
            {
                _value = value;
            }

            public static OperateTypeEnum FromValue(string value)
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

                if (this.Equals(obj as OperateTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OperateTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OperateTypeEnum a, OperateTypeEnum b)
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

            public static bool operator !=(OperateTypeEnum a, OperateTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 虚拟机ID
        /// </summary>
        [JsonProperty("task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskId { get; set; }

        /// <summary>
        /// 任务的操作类型。 - FAILED_RESET 重置 - FAILED_REPLACE 替换 - FAILED_UNBIND 解绑
        /// </summary>
        [JsonProperty("operate_type", NullValueHandling = NullValueHandling.Ignore)]
        public OperateTypeEnum OperateType { get; set; }
        /// <summary>
        /// 任务时间
        /// </summary>
        [JsonProperty("task_time", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskTime { get; set; }

        /// <summary>
        /// 任务失败错误码
        /// </summary>
        [JsonProperty("task_error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskErrorCode { get; set; }

        /// <summary>
        /// 任务失败错误码
        /// </summary>
        [JsonProperty("task_error_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskErrorMsg { get; set; }

        /// <summary>
        /// 虚拟机名称
        /// </summary>
        [JsonProperty("server_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerName { get; set; }

        /// <summary>
        /// 虚拟机ID
        /// </summary>
        [JsonProperty("server_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerId { get; set; }

        /// <summary>
        /// 密钥对名称
        /// </summary>
        [JsonProperty("keypair_name", NullValueHandling = NullValueHandling.Ignore)]
        public string KeypairName { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FailedTasks {\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("  operateType: ").Append(OperateType).Append("\n");
            sb.Append("  taskTime: ").Append(TaskTime).Append("\n");
            sb.Append("  taskErrorCode: ").Append(TaskErrorCode).Append("\n");
            sb.Append("  taskErrorMsg: ").Append(TaskErrorMsg).Append("\n");
            sb.Append("  serverName: ").Append(ServerName).Append("\n");
            sb.Append("  serverId: ").Append(ServerId).Append("\n");
            sb.Append("  keypairName: ").Append(KeypairName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FailedTasks);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FailedTasks input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TaskId == input.TaskId ||
                    (this.TaskId != null &&
                    this.TaskId.Equals(input.TaskId))
                ) && 
                (
                    this.OperateType == input.OperateType ||
                    (this.OperateType != null &&
                    this.OperateType.Equals(input.OperateType))
                ) && 
                (
                    this.TaskTime == input.TaskTime ||
                    (this.TaskTime != null &&
                    this.TaskTime.Equals(input.TaskTime))
                ) && 
                (
                    this.TaskErrorCode == input.TaskErrorCode ||
                    (this.TaskErrorCode != null &&
                    this.TaskErrorCode.Equals(input.TaskErrorCode))
                ) && 
                (
                    this.TaskErrorMsg == input.TaskErrorMsg ||
                    (this.TaskErrorMsg != null &&
                    this.TaskErrorMsg.Equals(input.TaskErrorMsg))
                ) && 
                (
                    this.ServerName == input.ServerName ||
                    (this.ServerName != null &&
                    this.ServerName.Equals(input.ServerName))
                ) && 
                (
                    this.ServerId == input.ServerId ||
                    (this.ServerId != null &&
                    this.ServerId.Equals(input.ServerId))
                ) && 
                (
                    this.KeypairName == input.KeypairName ||
                    (this.KeypairName != null &&
                    this.KeypairName.Equals(input.KeypairName))
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
                if (this.TaskId != null)
                    hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.OperateType != null)
                    hashCode = hashCode * 59 + this.OperateType.GetHashCode();
                if (this.TaskTime != null)
                    hashCode = hashCode * 59 + this.TaskTime.GetHashCode();
                if (this.TaskErrorCode != null)
                    hashCode = hashCode * 59 + this.TaskErrorCode.GetHashCode();
                if (this.TaskErrorMsg != null)
                    hashCode = hashCode * 59 + this.TaskErrorMsg.GetHashCode();
                if (this.ServerName != null)
                    hashCode = hashCode * 59 + this.ServerName.GetHashCode();
                if (this.ServerId != null)
                    hashCode = hashCode * 59 + this.ServerId.GetHashCode();
                if (this.KeypairName != null)
                    hashCode = hashCode * 59 + this.KeypairName.GetHashCode();
                return hashCode;
            }
        }
    }
}
