using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vod.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class TakeOverTask 
    {
        /// <summary>
        /// 任务状态。
        /// </summary>
        /// <value>任务状态。</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
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

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "PROCESSING", PROCESSING },
                { "SUCCEED", SUCCEED },
                { "FAILED", FAILED },
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 桶名。
        /// </summary>
        [JsonProperty("bucket", NullValueHandling = NullValueHandling.Ignore)]
        public string Bucket { get; set; }

        /// <summary>
        /// 目录/文件名。
        /// </summary>
        [JsonProperty("object", NullValueHandling = NullValueHandling.Ignore)]
        public string Object { get; set; }

        /// <summary>
        /// 托管类型。  取值如下： - 0：表示存储到点播桶 - 1：表示存储在租户桶 - 2：表示存储到租户OBS桶中，且输出目录与源文件的存储目录相同。
        /// </summary>
        [JsonProperty("host_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? HostType { get; set; }

        /// <summary>
        /// 输出桶 。
        /// </summary>
        [JsonProperty("output_bucket", NullValueHandling = NullValueHandling.Ignore)]
        public string OutputBucket { get; set; }

        /// <summary>
        /// 输出路径 。
        /// </summary>
        [JsonProperty("output_path", NullValueHandling = NullValueHandling.Ignore)]
        public string OutputPath { get; set; }

        /// <summary>
        /// 任务ID。
        /// </summary>
        [JsonProperty("task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskId { get; set; }

        /// <summary>
        /// 托管文件类型。
        /// </summary>
        [JsonProperty("suffix", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Suffix { get; set; }

        /// <summary>
        /// 转码模板组 。
        /// </summary>
        [JsonProperty("template_group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateGroupName { get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 结束时间。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 任务状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 媒资的任务执行描述汇总。
        /// </summary>
        [JsonProperty("exec_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecDesc { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TakeOverTask {\n");
            sb.Append("  bucket: ").Append(Bucket).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  hostType: ").Append(HostType).Append("\n");
            sb.Append("  outputBucket: ").Append(OutputBucket).Append("\n");
            sb.Append("  outputPath: ").Append(OutputPath).Append("\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("  suffix: ").Append(Suffix).Append("\n");
            sb.Append("  templateGroupName: ").Append(TemplateGroupName).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  execDesc: ").Append(ExecDesc).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TakeOverTask);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TakeOverTask input)
        {
            if (input == null) return false;
            if (this.Bucket != input.Bucket || (this.Bucket != null && !this.Bucket.Equals(input.Bucket))) return false;
            if (this.Object != input.Object || (this.Object != null && !this.Object.Equals(input.Object))) return false;
            if (this.HostType != input.HostType || (this.HostType != null && !this.HostType.Equals(input.HostType))) return false;
            if (this.OutputBucket != input.OutputBucket || (this.OutputBucket != null && !this.OutputBucket.Equals(input.OutputBucket))) return false;
            if (this.OutputPath != input.OutputPath || (this.OutputPath != null && !this.OutputPath.Equals(input.OutputPath))) return false;
            if (this.TaskId != input.TaskId || (this.TaskId != null && !this.TaskId.Equals(input.TaskId))) return false;
            if (this.Suffix != input.Suffix || (this.Suffix != null && input.Suffix != null && !this.Suffix.SequenceEqual(input.Suffix))) return false;
            if (this.TemplateGroupName != input.TemplateGroupName || (this.TemplateGroupName != null && !this.TemplateGroupName.Equals(input.TemplateGroupName))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.Status != input.Status) return false;
            if (this.ExecDesc != input.ExecDesc || (this.ExecDesc != null && !this.ExecDesc.Equals(input.ExecDesc))) return false;

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
                if (this.Bucket != null) hashCode = hashCode * 59 + this.Bucket.GetHashCode();
                if (this.Object != null) hashCode = hashCode * 59 + this.Object.GetHashCode();
                if (this.HostType != null) hashCode = hashCode * 59 + this.HostType.GetHashCode();
                if (this.OutputBucket != null) hashCode = hashCode * 59 + this.OutputBucket.GetHashCode();
                if (this.OutputPath != null) hashCode = hashCode * 59 + this.OutputPath.GetHashCode();
                if (this.TaskId != null) hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.Suffix != null) hashCode = hashCode * 59 + this.Suffix.GetHashCode();
                if (this.TemplateGroupName != null) hashCode = hashCode * 59 + this.TemplateGroupName.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ExecDesc != null) hashCode = hashCode * 59 + this.ExecDesc.GetHashCode();
                return hashCode;
            }
        }
    }
}
