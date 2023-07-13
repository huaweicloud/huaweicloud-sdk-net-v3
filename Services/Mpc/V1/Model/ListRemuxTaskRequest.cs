using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Mpc.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListRemuxTaskRequest 
    {
        /// <summary>
        /// 任务执行状态。  取值如下： - INIT：初始状态 - WAITING：等待启动 - PROCESSING：处理中 - SUCCEED：处理成功 - FAILED：处理失败 - CANCELED：已取消 
        /// </summary>
        /// <value>任务执行状态。  取值如下： - INIT：初始状态 - WAITING：等待启动 - PROCESSING：处理中 - SUCCEED：处理成功 - FAILED：处理失败 - CANCELED：已取消 </value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum INIT for value: INIT
            /// </summary>
            public static readonly StatusEnum INIT = new StatusEnum("INIT");

            /// <summary>
            /// Enum WAITING for value: WAITING
            /// </summary>
            public static readonly StatusEnum WAITING = new StatusEnum("WAITING");

            /// <summary>
            /// Enum PROCESSING for value: PROCESSING
            /// </summary>
            public static readonly StatusEnum PROCESSING = new StatusEnum("PROCESSING");

            /// <summary>
            /// Enum SUCCEED for value: SUCCEED
            /// </summary>
            public static readonly StatusEnum SUCCEED = new StatusEnum("SUCCEED");

            /// <summary>
            /// Enum FAILED for value: FAILED
            /// </summary>
            public static readonly StatusEnum FAILED = new StatusEnum("FAILED");

            /// <summary>
            /// Enum CANCELED for value: CANCELED
            /// </summary>
            public static readonly StatusEnum CANCELED = new StatusEnum("CANCELED");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "INIT", INIT },
                { "WAITING", WAITING },
                { "PROCESSING", PROCESSING },
                { "SUCCEED", SUCCEED },
                { "FAILED", FAILED },
                { "CANCELED", CANCELED },
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
        /// 任务ID。一次最多10个 
        /// </summary>
        [SDKProperty("task_id", IsQuery = true)]
        [JsonProperty("task_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TaskId { get; set; }

        /// <summary>
        /// 任务执行状态。  取值如下： - INIT：初始状态 - WAITING：等待启动 - PROCESSING：处理中 - SUCCEED：处理成功 - FAILED：处理失败 - CANCELED：已取消 
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 起始时间。格式为yyyymmddhhmmss。必须是与时区无关的UTC时间，指定task_id时该参数无效 
        /// </summary>
        [SDKProperty("start_time", IsQuery = true)]
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 结束时间。格式为yyyymmddhhmmss。必须是与时区无关的UTC时间，指定task_id时该参数无效 
        /// </summary>
        [SDKProperty("end_time", IsQuery = true)]
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 源文件存储桶。 
        /// </summary>
        [SDKProperty("input_bucket", IsQuery = true)]
        [JsonProperty("input_bucket", NullValueHandling = NullValueHandling.Ignore)]
        public string InputBucket { get; set; }

        /// <summary>
        /// 源对象名称. 
        /// </summary>
        [SDKProperty("input_object", IsQuery = true)]
        [JsonProperty("input_object", NullValueHandling = NullValueHandling.Ignore)]
        public string InputObject { get; set; }

        /// <summary>
        /// 分页编号。查询指定“task_id”时，该参数无效。  默认值：0。 
        /// </summary>
        [SDKProperty("page", IsQuery = true)]
        [JsonProperty("page", NullValueHandling = NullValueHandling.Ignore)]
        public int? Page { get; set; }

        /// <summary>
        /// 每页记录数。查询指定“task_id”时，该参数无效。  取值范围：[1,100]。  默认值：10。 
        /// </summary>
        [SDKProperty("size", IsQuery = true)]
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRemuxTaskRequest {\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  inputBucket: ").Append(InputBucket).Append("\n");
            sb.Append("  inputObject: ").Append(InputObject).Append("\n");
            sb.Append("  page: ").Append(Page).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListRemuxTaskRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListRemuxTaskRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TaskId == input.TaskId ||
                    this.TaskId != null &&
                    input.TaskId != null &&
                    this.TaskId.SequenceEqual(input.TaskId)
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.InputBucket == input.InputBucket ||
                    (this.InputBucket != null &&
                    this.InputBucket.Equals(input.InputBucket))
                ) && 
                (
                    this.InputObject == input.InputObject ||
                    (this.InputObject != null &&
                    this.InputObject.Equals(input.InputObject))
                ) && 
                (
                    this.Page == input.Page ||
                    (this.Page != null &&
                    this.Page.Equals(input.Page))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
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
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.InputBucket != null)
                    hashCode = hashCode * 59 + this.InputBucket.GetHashCode();
                if (this.InputObject != null)
                    hashCode = hashCode * 59 + this.InputObject.GetHashCode();
                if (this.Page != null)
                    hashCode = hashCode * 59 + this.Page.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                return hashCode;
            }
        }
    }
}
