using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class EventResponse 
    {

        /// <summary>
        /// 事件ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 事件类型
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 事件状态
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// 事件发布时间
        /// </summary>
        [JsonProperty("publish_time", NullValueHandling = NullValueHandling.Ignore)]
        public string PublishTime { get; set; }

        /// <summary>
        /// 事件开始时间
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 事件完成时间
        /// </summary>
        [JsonProperty("finish_time", NullValueHandling = NullValueHandling.Ignore)]
        public string FinishTime { get; set; }

        /// <summary>
        /// 事件计划执行开始时间
        /// </summary>
        [JsonProperty("not_before", NullValueHandling = NullValueHandling.Ignore)]
        public string NotBefore { get; set; }

        /// <summary>
        /// 事件计划执行完成时间
        /// </summary>
        [JsonProperty("not_after", NullValueHandling = NullValueHandling.Ignore)]
        public string NotAfter { get; set; }

        /// <summary>
        /// 事件计划执行开始时间deadline
        /// </summary>
        [JsonProperty("not_before_deadline", NullValueHandling = NullValueHandling.Ignore)]
        public string NotBeforeDeadline { get; set; }

        /// <summary>
        /// 事件描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("execute_options", NullValueHandling = NullValueHandling.Ignore)]
        public EventResponseExecuteOptions ExecuteOptions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public EventResponseSource Source { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  publishTime: ").Append(PublishTime).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  finishTime: ").Append(FinishTime).Append("\n");
            sb.Append("  notBefore: ").Append(NotBefore).Append("\n");
            sb.Append("  notAfter: ").Append(NotAfter).Append("\n");
            sb.Append("  notBeforeDeadline: ").Append(NotBeforeDeadline).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  executeOptions: ").Append(ExecuteOptions).Append("\n");
            sb.Append("  source: ").Append(Source).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EventResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EventResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.PublishTime != input.PublishTime || (this.PublishTime != null && !this.PublishTime.Equals(input.PublishTime))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.FinishTime != input.FinishTime || (this.FinishTime != null && !this.FinishTime.Equals(input.FinishTime))) return false;
            if (this.NotBefore != input.NotBefore || (this.NotBefore != null && !this.NotBefore.Equals(input.NotBefore))) return false;
            if (this.NotAfter != input.NotAfter || (this.NotAfter != null && !this.NotAfter.Equals(input.NotAfter))) return false;
            if (this.NotBeforeDeadline != input.NotBeforeDeadline || (this.NotBeforeDeadline != null && !this.NotBeforeDeadline.Equals(input.NotBeforeDeadline))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.ExecuteOptions != input.ExecuteOptions || (this.ExecuteOptions != null && !this.ExecuteOptions.Equals(input.ExecuteOptions))) return false;
            if (this.Source != input.Source || (this.Source != null && !this.Source.Equals(input.Source))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.PublishTime != null) hashCode = hashCode * 59 + this.PublishTime.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.FinishTime != null) hashCode = hashCode * 59 + this.FinishTime.GetHashCode();
                if (this.NotBefore != null) hashCode = hashCode * 59 + this.NotBefore.GetHashCode();
                if (this.NotAfter != null) hashCode = hashCode * 59 + this.NotAfter.GetHashCode();
                if (this.NotBeforeDeadline != null) hashCode = hashCode * 59 + this.NotBeforeDeadline.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.ExecuteOptions != null) hashCode = hashCode * 59 + this.ExecuteOptions.GetHashCode();
                if (this.Source != null) hashCode = hashCode * 59 + this.Source.GetHashCode();
                return hashCode;
            }
        }
    }
}
