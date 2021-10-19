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
    /// Response Object
    /// </summary>
    public class ShowSinkTaskDetailResponse : SdkResponse
    {

        /// <summary>
        /// 转储任务名称。
        /// </summary>
        [JsonProperty("task_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskName { get; set; }

        /// <summary>
        /// 转储任务类型。
        /// </summary>
        [JsonProperty("destination_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationType { get; set; }

        /// <summary>
        /// 转储任务创建时间戳。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// 转储任务状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 返回任务转存的topics列表或者正则表达式。
        /// </summary>
        [JsonProperty("topics", NullValueHandling = NullValueHandling.Ignore)]
        public string Topics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("obs_destination_descriptor", NullValueHandling = NullValueHandling.Ignore)]
        public ShowSinkTaskDetailRespObsDestinationDescriptor ObsDestinationDescriptor { get; set; }

        /// <summary>
        /// topic信息。
        /// </summary>
        [JsonProperty("topics_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowSinkTaskDetailRespTopicsInfo> TopicsInfo { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowSinkTaskDetailResponse {\n");
            sb.Append("  taskName: ").Append(TaskName).Append("\n");
            sb.Append("  destinationType: ").Append(DestinationType).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  topics: ").Append(Topics).Append("\n");
            sb.Append("  obsDestinationDescriptor: ").Append(ObsDestinationDescriptor).Append("\n");
            sb.Append("  topicsInfo: ").Append(TopicsInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowSinkTaskDetailResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowSinkTaskDetailResponse input)
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
                    this.DestinationType == input.DestinationType ||
                    (this.DestinationType != null &&
                    this.DestinationType.Equals(input.DestinationType))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Topics == input.Topics ||
                    (this.Topics != null &&
                    this.Topics.Equals(input.Topics))
                ) && 
                (
                    this.ObsDestinationDescriptor == input.ObsDestinationDescriptor ||
                    (this.ObsDestinationDescriptor != null &&
                    this.ObsDestinationDescriptor.Equals(input.ObsDestinationDescriptor))
                ) && 
                (
                    this.TopicsInfo == input.TopicsInfo ||
                    this.TopicsInfo != null &&
                    input.TopicsInfo != null &&
                    this.TopicsInfo.SequenceEqual(input.TopicsInfo)
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
                if (this.DestinationType != null)
                    hashCode = hashCode * 59 + this.DestinationType.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Topics != null)
                    hashCode = hashCode * 59 + this.Topics.GetHashCode();
                if (this.ObsDestinationDescriptor != null)
                    hashCode = hashCode * 59 + this.ObsDestinationDescriptor.GetHashCode();
                if (this.TopicsInfo != null)
                    hashCode = hashCode * 59 + this.TopicsInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
