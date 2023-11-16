using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsBuild.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Vertices 
    {

        /// <summary>
        /// 子任务构建记录ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 子任务执行状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 子任务名称
        /// </summary>
        [JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// 子任务构建耗时
        /// </summary>
        [JsonProperty("build_duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? BuildDuration { get; set; }

        /// <summary>
        /// 子任务开始时间
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 子任务结束时间
        /// </summary>
        [JsonProperty("finish_time", NullValueHandling = NullValueHandling.Ignore)]
        public string FinishTime { get; set; }

        /// <summary>
        /// 子任务构建编号
        /// </summary>
        [JsonProperty("build_no", NullValueHandling = NullValueHandling.Ignore)]
        public string BuildNo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Vertices {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  displayName: ").Append(DisplayName).Append("\n");
            sb.Append("  buildDuration: ").Append(BuildDuration).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  finishTime: ").Append(FinishTime).Append("\n");
            sb.Append("  buildNo: ").Append(BuildNo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Vertices);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Vertices input)
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
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.BuildDuration == input.BuildDuration ||
                    (this.BuildDuration != null &&
                    this.BuildDuration.Equals(input.BuildDuration))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.FinishTime == input.FinishTime ||
                    (this.FinishTime != null &&
                    this.FinishTime.Equals(input.FinishTime))
                ) && 
                (
                    this.BuildNo == input.BuildNo ||
                    (this.BuildNo != null &&
                    this.BuildNo.Equals(input.BuildNo))
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
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.BuildDuration != null)
                    hashCode = hashCode * 59 + this.BuildDuration.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.FinishTime != null)
                    hashCode = hashCode * 59 + this.FinishTime.GetHashCode();
                if (this.BuildNo != null)
                    hashCode = hashCode * 59 + this.BuildNo.GetHashCode();
                return hashCode;
            }
        }
    }
}
