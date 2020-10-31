using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowIterationV4Response : SdkResponse
    {

        /// <summary>
        /// 迭代结束时间，年-月-日
        /// </summary>
        [JsonProperty("begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public string BeginTime { get; set; }

        /// <summary>
        /// 燃尽图
        /// </summary>
        [JsonProperty("charts", NullValueHandling = NullValueHandling.Ignore)]
        public List<Chart> Charts { get; set; }

        /// <summary>
        /// 已关闭的工单数
        /// </summary>
        [JsonProperty("closed_total", NullValueHandling = NullValueHandling.Ignore)]
        public int? ClosedTotal { get; set; }

        /// <summary>
        /// 迭代创建时间
        /// </summary>
        [JsonProperty("created_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// 迭代开始时间，年-月-日
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 是否有task
        /// </summary>
        [JsonProperty("have_task", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaveTask { get; set; }

        /// <summary>
        /// 迭代id
        /// </summary>
        [JsonProperty("iteration_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? IterationId { get; set; }

        /// <summary>
        /// 迭代标题
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 开启的工单数
        /// </summary>
        [JsonProperty("opened_total", NullValueHandling = NullValueHandling.Ignore)]
        public int? OpenedTotal { get; set; }

        /// <summary>
        /// 工作进展
        /// </summary>
        [JsonProperty("progress", NullValueHandling = NullValueHandling.Ignore)]
        public string Progress { get; set; }

        /// <summary>
        /// 工单总数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// 迭代更新时间
        /// </summary>
        [JsonProperty("updated_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedTime { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowIterationV4Response {\n");
            sb.Append("  beginTime: ").Append(BeginTime).Append("\n");
            sb.Append("  charts: ").Append(Charts).Append("\n");
            sb.Append("  closedTotal: ").Append(ClosedTotal).Append("\n");
            sb.Append("  createdTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  haveTask: ").Append(HaveTask).Append("\n");
            sb.Append("  iterationId: ").Append(IterationId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  openedTotal: ").Append(OpenedTotal).Append("\n");
            sb.Append("  progress: ").Append(Progress).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  updatedTime: ").Append(UpdatedTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowIterationV4Response);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowIterationV4Response input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BeginTime == input.BeginTime ||
                    (this.BeginTime != null &&
                    this.BeginTime.Equals(input.BeginTime))
                ) && 
                (
                    this.Charts == input.Charts ||
                    this.Charts != null &&
                    input.Charts != null &&
                    this.Charts.SequenceEqual(input.Charts)
                ) && 
                (
                    this.ClosedTotal == input.ClosedTotal ||
                    (this.ClosedTotal != null &&
                    this.ClosedTotal.Equals(input.ClosedTotal))
                ) && 
                (
                    this.CreatedTime == input.CreatedTime ||
                    (this.CreatedTime != null &&
                    this.CreatedTime.Equals(input.CreatedTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.HaveTask == input.HaveTask ||
                    (this.HaveTask != null &&
                    this.HaveTask.Equals(input.HaveTask))
                ) && 
                (
                    this.IterationId == input.IterationId ||
                    (this.IterationId != null &&
                    this.IterationId.Equals(input.IterationId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OpenedTotal == input.OpenedTotal ||
                    (this.OpenedTotal != null &&
                    this.OpenedTotal.Equals(input.OpenedTotal))
                ) && 
                (
                    this.Progress == input.Progress ||
                    (this.Progress != null &&
                    this.Progress.Equals(input.Progress))
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.UpdatedTime == input.UpdatedTime ||
                    (this.UpdatedTime != null &&
                    this.UpdatedTime.Equals(input.UpdatedTime))
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
                if (this.BeginTime != null)
                    hashCode = hashCode * 59 + this.BeginTime.GetHashCode();
                if (this.Charts != null)
                    hashCode = hashCode * 59 + this.Charts.GetHashCode();
                if (this.ClosedTotal != null)
                    hashCode = hashCode * 59 + this.ClosedTotal.GetHashCode();
                if (this.CreatedTime != null)
                    hashCode = hashCode * 59 + this.CreatedTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.HaveTask != null)
                    hashCode = hashCode * 59 + this.HaveTask.GetHashCode();
                if (this.IterationId != null)
                    hashCode = hashCode * 59 + this.IterationId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OpenedTotal != null)
                    hashCode = hashCode * 59 + this.OpenedTotal.GetHashCode();
                if (this.Progress != null)
                    hashCode = hashCode * 59 + this.Progress.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.UpdatedTime != null)
                    hashCode = hashCode * 59 + this.UpdatedTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
