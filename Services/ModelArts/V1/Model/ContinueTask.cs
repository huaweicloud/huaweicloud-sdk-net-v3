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
    /// 续训任务信息
    /// </summary>
    public class ContinueTask 
    {

        /// <summary>
        /// 断点ID
        /// </summary>
        [JsonProperty("checkpoint_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckpointId { get; set; }

        /// <summary>
        /// 续训任务模型ID
        /// </summary>
        [JsonProperty("source_model_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceModelId { get; set; }

        /// <summary>
        /// 续训任务模型名称
        /// </summary>
        [JsonProperty("source_model_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceModelName { get; set; }

        /// <summary>
        /// 轮数。
        /// </summary>
        [JsonProperty("epoch", NullValueHandling = NullValueHandling.Ignore)]
        public int? Epoch { get; set; }

        /// <summary>
        /// 步数。
        /// </summary>
        [JsonProperty("steps", NullValueHandling = NullValueHandling.Ignore)]
        public int? Steps { get; set; }

        /// <summary>
        /// 是否最优
        /// </summary>
        [JsonProperty("is_best", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsBest { get; set; }

        /// <summary>
        /// 跳过步数，0表示不跳过。
        /// </summary>
        [JsonProperty("skipped_steps", NullValueHandling = NullValueHandling.Ignore)]
        public int? SkippedSteps { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContinueTask {\n");
            sb.Append("  checkpointId: ").Append(CheckpointId).Append("\n");
            sb.Append("  sourceModelId: ").Append(SourceModelId).Append("\n");
            sb.Append("  sourceModelName: ").Append(SourceModelName).Append("\n");
            sb.Append("  epoch: ").Append(Epoch).Append("\n");
            sb.Append("  steps: ").Append(Steps).Append("\n");
            sb.Append("  isBest: ").Append(IsBest).Append("\n");
            sb.Append("  skippedSteps: ").Append(SkippedSteps).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ContinueTask);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ContinueTask input)
        {
            if (input == null) return false;
            if (this.CheckpointId != input.CheckpointId || (this.CheckpointId != null && !this.CheckpointId.Equals(input.CheckpointId))) return false;
            if (this.SourceModelId != input.SourceModelId || (this.SourceModelId != null && !this.SourceModelId.Equals(input.SourceModelId))) return false;
            if (this.SourceModelName != input.SourceModelName || (this.SourceModelName != null && !this.SourceModelName.Equals(input.SourceModelName))) return false;
            if (this.Epoch != input.Epoch || (this.Epoch != null && !this.Epoch.Equals(input.Epoch))) return false;
            if (this.Steps != input.Steps || (this.Steps != null && !this.Steps.Equals(input.Steps))) return false;
            if (this.IsBest != input.IsBest || (this.IsBest != null && !this.IsBest.Equals(input.IsBest))) return false;
            if (this.SkippedSteps != input.SkippedSteps || (this.SkippedSteps != null && !this.SkippedSteps.Equals(input.SkippedSteps))) return false;

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
                if (this.CheckpointId != null) hashCode = hashCode * 59 + this.CheckpointId.GetHashCode();
                if (this.SourceModelId != null) hashCode = hashCode * 59 + this.SourceModelId.GetHashCode();
                if (this.SourceModelName != null) hashCode = hashCode * 59 + this.SourceModelName.GetHashCode();
                if (this.Epoch != null) hashCode = hashCode * 59 + this.Epoch.GetHashCode();
                if (this.Steps != null) hashCode = hashCode * 59 + this.Steps.GetHashCode();
                if (this.IsBest != null) hashCode = hashCode * 59 + this.IsBest.GetHashCode();
                if (this.SkippedSteps != null) hashCode = hashCode * 59 + this.SkippedSteps.GetHashCode();
                return hashCode;
            }
        }
    }
}
