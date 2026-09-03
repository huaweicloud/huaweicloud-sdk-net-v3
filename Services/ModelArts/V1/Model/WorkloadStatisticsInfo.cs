using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 工作负载统计
    /// </summary>
    public class WorkloadStatisticsInfo 
    {

        /// <summary>
        /// 旧版模型部署作业数量。
        /// </summary>
        [JsonProperty("infer", NullValueHandling = NullValueHandling.Ignore)]
        public int? Infer { get; set; }

        /// <summary>
        /// 开发环境作业数量。
        /// </summary>
        [JsonProperty("notebook", NullValueHandling = NullValueHandling.Ignore)]
        public int? Notebook { get; set; }

        /// <summary>
        /// 训练作业数量。
        /// </summary>
        [JsonProperty("train", NullValueHandling = NullValueHandling.Ignore)]
        public int? Train { get; set; }

        /// <summary>
        /// 权重预热作业数量。
        /// </summary>
        [JsonProperty("warmUpTask", NullValueHandling = NullValueHandling.Ignore)]
        public int? WarmUpTask { get; set; }

        /// <summary>
        /// 模型部署作业数量。
        /// </summary>
        [JsonProperty("x-infer", NullValueHandling = NullValueHandling.Ignore)]
        public int? XInfer { get; set; }

        /// <summary>
        /// 所有作业总和。
        /// </summary>
        [JsonProperty("sum", NullValueHandling = NullValueHandling.Ignore)]
        public int? Sum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkloadStatisticsInfo {\n");
            sb.Append("  infer: ").Append(Infer).Append("\n");
            sb.Append("  notebook: ").Append(Notebook).Append("\n");
            sb.Append("  train: ").Append(Train).Append("\n");
            sb.Append("  warmUpTask: ").Append(WarmUpTask).Append("\n");
            sb.Append("  xInfer: ").Append(XInfer).Append("\n");
            sb.Append("  sum: ").Append(Sum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WorkloadStatisticsInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WorkloadStatisticsInfo input)
        {
            if (input == null) return false;
            if (this.Infer != input.Infer || (this.Infer != null && !this.Infer.Equals(input.Infer))) return false;
            if (this.Notebook != input.Notebook || (this.Notebook != null && !this.Notebook.Equals(input.Notebook))) return false;
            if (this.Train != input.Train || (this.Train != null && !this.Train.Equals(input.Train))) return false;
            if (this.WarmUpTask != input.WarmUpTask || (this.WarmUpTask != null && !this.WarmUpTask.Equals(input.WarmUpTask))) return false;
            if (this.XInfer != input.XInfer || (this.XInfer != null && !this.XInfer.Equals(input.XInfer))) return false;
            if (this.Sum != input.Sum || (this.Sum != null && !this.Sum.Equals(input.Sum))) return false;

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
                if (this.Infer != null) hashCode = hashCode * 59 + this.Infer.GetHashCode();
                if (this.Notebook != null) hashCode = hashCode * 59 + this.Notebook.GetHashCode();
                if (this.Train != null) hashCode = hashCode * 59 + this.Train.GetHashCode();
                if (this.WarmUpTask != null) hashCode = hashCode * 59 + this.WarmUpTask.GetHashCode();
                if (this.XInfer != null) hashCode = hashCode * 59 + this.XInfer.GetHashCode();
                if (this.Sum != null) hashCode = hashCode * 59 + this.Sum.GetHashCode();
                return hashCode;
            }
        }
    }
}
