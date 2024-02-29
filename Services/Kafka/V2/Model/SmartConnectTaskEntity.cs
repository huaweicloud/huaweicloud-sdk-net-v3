using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SmartConnectTaskEntity 
    {

        /// <summary>
        /// SmartConnect任务名称。
        /// </summary>
        [JsonProperty("task_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskName { get; set; }

        /// <summary>
        /// SmartConnect任务配置的Topic。
        /// </summary>
        [JsonProperty("topics", NullValueHandling = NullValueHandling.Ignore)]
        public string Topics { get; set; }

        /// <summary>
        /// SmartConnect任务的源端类型。
        /// </summary>
        [JsonProperty("source_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("source_task", NullValueHandling = NullValueHandling.Ignore)]
        public SmartConnectTaskRespSourceConfig SourceTask { get; set; }

        /// <summary>
        /// SmartConnect任务的目标端类型。
        /// </summary>
        [JsonProperty("sink_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SinkType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("sink_task", NullValueHandling = NullValueHandling.Ignore)]
        public SmartConnectTaskRespSinkConfig SinkTask { get; set; }

        /// <summary>
        /// SmartConnect任务的id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// SmartConnect任务的状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// SmartConnect任务的创建时间。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmartConnectTaskEntity {\n");
            sb.Append("  taskName: ").Append(TaskName).Append("\n");
            sb.Append("  topics: ").Append(Topics).Append("\n");
            sb.Append("  sourceType: ").Append(SourceType).Append("\n");
            sb.Append("  sourceTask: ").Append(SourceTask).Append("\n");
            sb.Append("  sinkType: ").Append(SinkType).Append("\n");
            sb.Append("  sinkTask: ").Append(SinkTask).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SmartConnectTaskEntity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SmartConnectTaskEntity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TaskName == input.TaskName ||
                    (this.TaskName != null &&
                    this.TaskName.Equals(input.TaskName))
                ) && 
                (
                    this.Topics == input.Topics ||
                    (this.Topics != null &&
                    this.Topics.Equals(input.Topics))
                ) && 
                (
                    this.SourceType == input.SourceType ||
                    (this.SourceType != null &&
                    this.SourceType.Equals(input.SourceType))
                ) && 
                (
                    this.SourceTask == input.SourceTask ||
                    (this.SourceTask != null &&
                    this.SourceTask.Equals(input.SourceTask))
                ) && 
                (
                    this.SinkType == input.SinkType ||
                    (this.SinkType != null &&
                    this.SinkType.Equals(input.SinkType))
                ) && 
                (
                    this.SinkTask == input.SinkTask ||
                    (this.SinkTask != null &&
                    this.SinkTask.Equals(input.SinkTask))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
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
                if (this.TaskName != null)
                    hashCode = hashCode * 59 + this.TaskName.GetHashCode();
                if (this.Topics != null)
                    hashCode = hashCode * 59 + this.Topics.GetHashCode();
                if (this.SourceType != null)
                    hashCode = hashCode * 59 + this.SourceType.GetHashCode();
                if (this.SourceTask != null)
                    hashCode = hashCode * 59 + this.SourceTask.GetHashCode();
                if (this.SinkType != null)
                    hashCode = hashCode * 59 + this.SinkType.GetHashCode();
                if (this.SinkTask != null)
                    hashCode = hashCode * 59 + this.SinkTask.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
