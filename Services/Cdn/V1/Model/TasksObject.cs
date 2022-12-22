using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class TasksObject 
    {
        /// <summary>
        /// 任务的类型， 其值可以为refresh或preheating。
        /// </summary>
        /// <value>任务的类型， 其值可以为refresh或preheating。</value>
        [JsonConverter(typeof(EnumClassConverter<TaskTypeEnum>))]
        public class TaskTypeEnum
        {
            /// <summary>
            /// Enum REFRESH for value: refresh
            /// </summary>
            public static readonly TaskTypeEnum REFRESH = new TaskTypeEnum("refresh");

            /// <summary>
            /// Enum PREHEATING for value: preheating
            /// </summary>
            public static readonly TaskTypeEnum PREHEATING = new TaskTypeEnum("preheating");

            private static readonly Dictionary<string, TaskTypeEnum> StaticFields =
            new Dictionary<string, TaskTypeEnum>()
            {
                { "refresh", REFRESH },
                { "preheating", PREHEATING },
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
        /// 默认是文件file。file：文件,directory：目录。
        /// </summary>
        /// <value>默认是文件file。file：文件,directory：目录。</value>
        [JsonConverter(typeof(EnumClassConverter<FileTypeEnum>))]
        public class FileTypeEnum
        {
            /// <summary>
            /// Enum FILE for value: file
            /// </summary>
            public static readonly FileTypeEnum FILE = new FileTypeEnum("file");

            /// <summary>
            /// Enum DIRECTORY for value: directory
            /// </summary>
            public static readonly FileTypeEnum DIRECTORY = new FileTypeEnum("directory");

            private static readonly Dictionary<string, FileTypeEnum> StaticFields =
            new Dictionary<string, FileTypeEnum>()
            {
                { "file", FILE },
                { "directory", DIRECTORY },
            };

            private string _value;

            public FileTypeEnum()
            {

            }

            public FileTypeEnum(string value)
            {
                _value = value;
            }

            public static FileTypeEnum FromValue(string value)
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

                if (this.Equals(obj as FileTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(FileTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(FileTypeEnum a, FileTypeEnum b)
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

            public static bool operator !=(FileTypeEnum a, FileTypeEnum b)
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
        /// 任务的类型， 其值可以为refresh或preheating。
        /// </summary>
        [JsonProperty("task_type", NullValueHandling = NullValueHandling.Ignore)]
        public TaskTypeEnum TaskType { get; set; }
        /// <summary>
        /// 刷新结果。task_done表示刷新成功  ，task_inprocess表示刷新中。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 处理中的url个数。
        /// </summary>
        [JsonProperty("processing", NullValueHandling = NullValueHandling.Ignore)]
        public int? Processing { get; set; }

        /// <summary>
        /// 成功处理的url个数。
        /// </summary>
        [JsonProperty("succeed", NullValueHandling = NullValueHandling.Ignore)]
        public int? Succeed { get; set; }

        /// <summary>
        /// 处理失败的url个数。
        /// </summary>
        [JsonProperty("failed", NullValueHandling = NullValueHandling.Ignore)]
        public int? Failed { get; set; }

        /// <summary>
        /// url总数。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// 任务的创建时间，相对于UTC 1970-01-01到当前时间相隔的毫秒数。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// 默认是文件file。file：文件,directory：目录。
        /// </summary>
        [JsonProperty("file_type", NullValueHandling = NullValueHandling.Ignore)]
        public FileTypeEnum FileType { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TasksObject {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  taskType: ").Append(TaskType).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  processing: ").Append(Processing).Append("\n");
            sb.Append("  succeed: ").Append(Succeed).Append("\n");
            sb.Append("  failed: ").Append(Failed).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  fileType: ").Append(FileType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TasksObject);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TasksObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.TaskType == input.TaskType ||
                    (this.TaskType != null &&
                    this.TaskType.Equals(input.TaskType))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Processing == input.Processing ||
                    (this.Processing != null &&
                    this.Processing.Equals(input.Processing))
                ) && 
                (
                    this.Succeed == input.Succeed ||
                    (this.Succeed != null &&
                    this.Succeed.Equals(input.Succeed))
                ) && 
                (
                    this.Failed == input.Failed ||
                    (this.Failed != null &&
                    this.Failed.Equals(input.Failed))
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.FileType == input.FileType ||
                    (this.FileType != null &&
                    this.FileType.Equals(input.FileType))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.TaskType != null)
                    hashCode = hashCode * 59 + this.TaskType.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Processing != null)
                    hashCode = hashCode * 59 + this.Processing.GetHashCode();
                if (this.Succeed != null)
                    hashCode = hashCode * 59 + this.Succeed.GetHashCode();
                if (this.Failed != null)
                    hashCode = hashCode * 59 + this.Failed.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.FileType != null)
                    hashCode = hashCode * 59 + this.FileType.GetHashCode();
                return hashCode;
            }
        }
    }
}
