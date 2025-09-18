using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 克隆任务请求体。
    /// </summary>
    public class CloneJobReq 
    {
        /// <summary>
        /// 任务版本号，新UX任务为2.0。默认为空，即克隆老任务。
        /// </summary>
        /// <value>任务版本号，新UX任务为2.0。默认为空，即克隆老任务。</value>
        [JsonConverter(typeof(EnumClassConverter<TaskVersionEnum>))]
        public class TaskVersionEnum
        {
            /// <summary>
            /// Enum _2_0 for value: 2.0
            /// </summary>
            public static readonly TaskVersionEnum _2_0 = new TaskVersionEnum("2.0");

            private static readonly Dictionary<string, TaskVersionEnum> StaticFields =
            new Dictionary<string, TaskVersionEnum>()
            {
                { "2.0", _2_0 },
            };

            private string _value;

            public TaskVersionEnum()
            {

            }

            public TaskVersionEnum(string value)
            {
                _value = value;
            }

            public static TaskVersionEnum FromValue(string value)
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

                if (this.Equals(obj as TaskVersionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TaskVersionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TaskVersionEnum a, TaskVersionEnum b)
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

            public static bool operator !=(TaskVersionEnum a, TaskVersionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 被克隆任务ID。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 克隆任务名称。名称在4位到50位之间，必须以字母开头，可以包含字母、数字、中划线或下划线，不能包含其他特殊字符，任务名称不能重复。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 任务版本号，新UX任务为2.0。默认为空，即克隆老任务。
        /// </summary>
        [JsonProperty("task_version", NullValueHandling = NullValueHandling.Ignore)]
        public TaskVersionEnum TaskVersion { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CloneJobReq {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  taskVersion: ").Append(TaskVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CloneJobReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CloneJobReq input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.TaskVersion != input.TaskVersion) return false;

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
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.TaskVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
