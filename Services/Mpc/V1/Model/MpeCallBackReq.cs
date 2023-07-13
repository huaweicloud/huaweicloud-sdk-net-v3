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
    /// 
    /// </summary>
    public class MpeCallBackReq 
    {
        /// <summary>
        /// 任务类型
        /// </summary>
        /// <value>任务类型</value>
        [JsonConverter(typeof(EnumClassConverter<TaskTypeEnum>))]
        public class TaskTypeEnum
        {
            /// <summary>
            /// Enum CONCAT for value: CONCAT
            /// </summary>
            public static readonly TaskTypeEnum CONCAT = new TaskTypeEnum("CONCAT");

            /// <summary>
            /// Enum AUDIO for value: AUDIO
            /// </summary>
            public static readonly TaskTypeEnum AUDIO = new TaskTypeEnum("AUDIO");

            /// <summary>
            /// Enum CUT for value: CUT
            /// </summary>
            public static readonly TaskTypeEnum CUT = new TaskTypeEnum("CUT");

            /// <summary>
            /// Enum PARSE for value: PARSE
            /// </summary>
            public static readonly TaskTypeEnum PARSE = new TaskTypeEnum("PARSE");

            /// <summary>
            /// Enum MD5 for value: MD5
            /// </summary>
            public static readonly TaskTypeEnum MD5 = new TaskTypeEnum("MD5");

            /// <summary>
            /// Enum SNAPSHOT for value: SNAPSHOT
            /// </summary>
            public static readonly TaskTypeEnum SNAPSHOT = new TaskTypeEnum("SNAPSHOT");

            /// <summary>
            /// Enum REMUX for value: REMUX
            /// </summary>
            public static readonly TaskTypeEnum REMUX = new TaskTypeEnum("REMUX");

            /// <summary>
            /// Enum ANIMATION for value: ANIMATION
            /// </summary>
            public static readonly TaskTypeEnum ANIMATION = new TaskTypeEnum("ANIMATION");

            private static readonly Dictionary<string, TaskTypeEnum> StaticFields =
            new Dictionary<string, TaskTypeEnum>()
            {
                { "CONCAT", CONCAT },
                { "AUDIO", AUDIO },
                { "CUT", CUT },
                { "PARSE", PARSE },
                { "MD5", MD5 },
                { "SNAPSHOT", SNAPSHOT },
                { "REMUX", REMUX },
                { "ANIMATION", ANIMATION },
            };

            private string _value;

            public TaskTypeEnum()
            {

            }

            public TaskTypeEnum(string value)
            {
                _value = value;
            }

            public static TaskTypeEnum FromValue(string value)
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

                if (this.Equals(obj as TaskTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TaskTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TaskTypeEnum a, TaskTypeEnum b)
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

            public static bool operator !=(TaskTypeEnum a, TaskTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 任务类型
        /// </summary>
        [JsonProperty("task_type", NullValueHandling = NullValueHandling.Ignore)]
        public TaskTypeEnum TaskType { get; set; }
        /// <summary>
        /// 任务ID。
        /// </summary>
        [JsonProperty("task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskId { get; set; }

        /// <summary>
        /// 任务状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 任务完成进度百分比值。 
        /// </summary>
        [JsonProperty("complete_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public int? CompleteRatio { get; set; }

        /// <summary>
        /// 任务执行描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("meta_data", NullValueHandling = NullValueHandling.Ignore)]
        public MpeMetaData MetaData { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MpeCallBackReq {\n");
            sb.Append("  taskType: ").Append(TaskType).Append("\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  completeRatio: ").Append(CompleteRatio).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  metaData: ").Append(MetaData).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MpeCallBackReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MpeCallBackReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TaskType == input.TaskType ||
                    (this.TaskType != null &&
                    this.TaskType.Equals(input.TaskType))
                ) && 
                (
                    this.TaskId == input.TaskId ||
                    (this.TaskId != null &&
                    this.TaskId.Equals(input.TaskId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.CompleteRatio == input.CompleteRatio ||
                    (this.CompleteRatio != null &&
                    this.CompleteRatio.Equals(input.CompleteRatio))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.MetaData == input.MetaData ||
                    (this.MetaData != null &&
                    this.MetaData.Equals(input.MetaData))
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
                if (this.TaskType != null)
                    hashCode = hashCode * 59 + this.TaskType.GetHashCode();
                if (this.TaskId != null)
                    hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CompleteRatio != null)
                    hashCode = hashCode * 59 + this.CompleteRatio.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.MetaData != null)
                    hashCode = hashCode * 59 + this.MetaData.GetHashCode();
                return hashCode;
            }
        }
    }
}
