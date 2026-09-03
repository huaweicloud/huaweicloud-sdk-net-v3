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
    /// 
    /// </summary>
    public class ContinueTrainTask 
    {

        /// <summary>
        /// 中间产物id。
        /// </summary>
        [JsonProperty("checkpoint_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckpointId { get; set; }

        /// <summary>
        /// 续训任务id。
        /// </summary>
        [JsonProperty("continue_task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ContinueTaskId { get; set; }

        /// <summary>
        /// 续训任务名称。
        /// </summary>
        [JsonProperty("continue_task_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ContinueTaskName { get; set; }

        /// <summary>
        /// 续训训练类型。
        /// </summary>
        [JsonProperty("continue_train_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ContinueTrainType { get; set; }

        /// <summary>
        /// 跳过步数，0表示不跳过。
        /// </summary>
        [JsonProperty("skipped_steps", NullValueHandling = NullValueHandling.Ignore)]
        public int? SkippedSteps { get; set; }

        /// <summary>
        /// 是否续训任务。  0: 非续训, 1:续训。
        /// </summary>
        [JsonProperty("restore_training", NullValueHandling = NullValueHandling.Ignore)]
        public int? RestoreTraining { get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 中间产物配置信息。
        /// </summary>
        [JsonProperty("checkpoint_config", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckpointConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContinueTrainTask {\n");
            sb.Append("  checkpointId: ").Append(CheckpointId).Append("\n");
            sb.Append("  continueTaskId: ").Append(ContinueTaskId).Append("\n");
            sb.Append("  continueTaskName: ").Append(ContinueTaskName).Append("\n");
            sb.Append("  continueTrainType: ").Append(ContinueTrainType).Append("\n");
            sb.Append("  skippedSteps: ").Append(SkippedSteps).Append("\n");
            sb.Append("  restoreTraining: ").Append(RestoreTraining).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  checkpointConfig: ").Append(CheckpointConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ContinueTrainTask);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ContinueTrainTask input)
        {
            if (input == null) return false;
            if (this.CheckpointId != input.CheckpointId || (this.CheckpointId != null && !this.CheckpointId.Equals(input.CheckpointId))) return false;
            if (this.ContinueTaskId != input.ContinueTaskId || (this.ContinueTaskId != null && !this.ContinueTaskId.Equals(input.ContinueTaskId))) return false;
            if (this.ContinueTaskName != input.ContinueTaskName || (this.ContinueTaskName != null && !this.ContinueTaskName.Equals(input.ContinueTaskName))) return false;
            if (this.ContinueTrainType != input.ContinueTrainType || (this.ContinueTrainType != null && !this.ContinueTrainType.Equals(input.ContinueTrainType))) return false;
            if (this.SkippedSteps != input.SkippedSteps || (this.SkippedSteps != null && !this.SkippedSteps.Equals(input.SkippedSteps))) return false;
            if (this.RestoreTraining != input.RestoreTraining || (this.RestoreTraining != null && !this.RestoreTraining.Equals(input.RestoreTraining))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.CheckpointConfig != input.CheckpointConfig || (this.CheckpointConfig != null && !this.CheckpointConfig.Equals(input.CheckpointConfig))) return false;

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
                if (this.ContinueTaskId != null) hashCode = hashCode * 59 + this.ContinueTaskId.GetHashCode();
                if (this.ContinueTaskName != null) hashCode = hashCode * 59 + this.ContinueTaskName.GetHashCode();
                if (this.ContinueTrainType != null) hashCode = hashCode * 59 + this.ContinueTrainType.GetHashCode();
                if (this.SkippedSteps != null) hashCode = hashCode * 59 + this.SkippedSteps.GetHashCode();
                if (this.RestoreTraining != null) hashCode = hashCode * 59 + this.RestoreTraining.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.CheckpointConfig != null) hashCode = hashCode * 59 + this.CheckpointConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
