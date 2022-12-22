using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// 单个子任务详情结构体
    /// </summary>
    public class TaskDetail 
    {

        /// <summary>
        /// 执行批量任务的目标。
        /// </summary>
        [JsonProperty("target", NullValueHandling = NullValueHandling.Ignore)]
        public string Target { get; set; }

        /// <summary>
        /// 子任务的执行状态，结果范围：Processing，Success，Fail，Waitting，FailWaitRetry，Stopped。 - Waitting: 等待执行。 - Processing: 执行中。 - Success: 成功。 - Fail: 失败。 - FailWaitRetry: 失败重试。 - Stopped: 已停止。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 子任务执行的输出信息。
        /// </summary>
        [JsonProperty("output", NullValueHandling = NullValueHandling.Ignore)]
        public string Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        public ErrorInfo Error { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskDetail {\n");
            sb.Append("  target: ").Append(Target).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  output: ").Append(Output).Append("\n");
            sb.Append("  error: ").Append(Error).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TaskDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TaskDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Target == input.Target ||
                    (this.Target != null &&
                    this.Target.Equals(input.Target))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Output == input.Output ||
                    (this.Output != null &&
                    this.Output.Equals(input.Output))
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
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
                if (this.Target != null)
                    hashCode = hashCode * 59 + this.Target.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Output != null)
                    hashCode = hashCode * 59 + this.Output.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                return hashCode;
            }
        }
    }
}
