using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// 子任务详情
    /// </summary>
    public class SubStepDetail 
    {

        /// <summary>
        /// 任务id
        /// </summary>
        [JsonProperty("sub_step_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubStepId { get; set; }

        /// <summary>
        /// 任务名
        /// </summary>
        [JsonProperty("sub_step_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SubStepName { get; set; }

        /// <summary>
        /// 任务状态
        /// </summary>
        [JsonProperty("sub_step_status", NullValueHandling = NullValueHandling.Ignore)]
        public string SubStepStatus { get; set; }

        /// <summary>
        /// 任务启动时间，格式为2020-06-17T07:38:42.503Z
        /// </summary>
        [JsonProperty("begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public string BeginTime { get; set; }

        /// <summary>
        /// 任务结束时间，格式为2020-06-17T07:38:42.503Z
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 子任务的附加属性详情
        /// </summary>
        [JsonProperty("detail", NullValueHandling = NullValueHandling.Ignore)]
        public string Detail { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [JsonProperty("error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubStepDetail {\n");
            sb.Append("  subStepId: ").Append(SubStepId).Append("\n");
            sb.Append("  subStepName: ").Append(SubStepName).Append("\n");
            sb.Append("  subStepStatus: ").Append(SubStepStatus).Append("\n");
            sb.Append("  beginTime: ").Append(BeginTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  detail: ").Append(Detail).Append("\n");
            sb.Append("  errorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SubStepDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SubStepDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SubStepId == input.SubStepId ||
                    (this.SubStepId != null &&
                    this.SubStepId.Equals(input.SubStepId))
                ) && 
                (
                    this.SubStepName == input.SubStepName ||
                    (this.SubStepName != null &&
                    this.SubStepName.Equals(input.SubStepName))
                ) && 
                (
                    this.SubStepStatus == input.SubStepStatus ||
                    (this.SubStepStatus != null &&
                    this.SubStepStatus.Equals(input.SubStepStatus))
                ) && 
                (
                    this.BeginTime == input.BeginTime ||
                    (this.BeginTime != null &&
                    this.BeginTime.Equals(input.BeginTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.Detail == input.Detail ||
                    (this.Detail != null &&
                    this.Detail.Equals(input.Detail))
                ) && 
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
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
                if (this.SubStepId != null)
                    hashCode = hashCode * 59 + this.SubStepId.GetHashCode();
                if (this.SubStepName != null)
                    hashCode = hashCode * 59 + this.SubStepName.GetHashCode();
                if (this.SubStepStatus != null)
                    hashCode = hashCode * 59 + this.SubStepStatus.GetHashCode();
                if (this.BeginTime != null)
                    hashCode = hashCode * 59 + this.BeginTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Detail != null)
                    hashCode = hashCode * 59 + this.Detail.GetHashCode();
                if (this.ErrorCode != null)
                    hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
