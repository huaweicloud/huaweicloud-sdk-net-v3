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
    public class MergeChannelsTaskInfo 
    {

        /// <summary>
        /// 任务Id
        /// </summary>
        [JsonProperty("task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskId { get; set; }

        /// <summary>
        /// 任务执行状态，取值如下。 \&quot;NO_TASK\&quot;      //无任务，task_id非法 \&quot;WAITING\&quot;      //等待启动 \&quot;PROCESSING\&quot;   //处理中 \&quot;SUCCEEDED\&quot;    //成功 \&quot;FAILED\&quot;       //失败 \&quot;CANCELED\&quot;     //已删除 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 任务启动时间 
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 任务结束时间 
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("output", NullValueHandling = NullValueHandling.Ignore)]
        public ObsObjInfo Output { get; set; }

        /// <summary>
        /// 任务描述，当出现异常时，此字段为异常的原因。 
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 音频文件列表
        /// </summary>
        [JsonProperty("audio_files", NullValueHandling = NullValueHandling.Ignore)]
        public List<AudioFile> AudioFiles { get; set; }

        /// <summary>
        /// 输出文件名。
        /// </summary>
        [JsonProperty("output_filename", NullValueHandling = NullValueHandling.Ignore)]
        public string OutputFilename { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MergeChannelsTaskInfo {\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  output: ").Append(Output).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  audioFiles: ").Append(AudioFiles).Append("\n");
            sb.Append("  outputFilename: ").Append(OutputFilename).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MergeChannelsTaskInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MergeChannelsTaskInfo input)
        {
            if (input == null) return false;
            if (this.TaskId != input.TaskId || (this.TaskId != null && !this.TaskId.Equals(input.TaskId))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.Output != input.Output || (this.Output != null && !this.Output.Equals(input.Output))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.AudioFiles != input.AudioFiles || (this.AudioFiles != null && input.AudioFiles != null && !this.AudioFiles.SequenceEqual(input.AudioFiles))) return false;
            if (this.OutputFilename != input.OutputFilename || (this.OutputFilename != null && !this.OutputFilename.Equals(input.OutputFilename))) return false;

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
                if (this.TaskId != null) hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Output != null) hashCode = hashCode * 59 + this.Output.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.AudioFiles != null) hashCode = hashCode * 59 + this.AudioFiles.GetHashCode();
                if (this.OutputFilename != null) hashCode = hashCode * 59 + this.OutputFilename.GetHashCode();
                return hashCode;
            }
        }
    }
}
