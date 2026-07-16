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
    /// 断点配置信息
    /// </summary>
    public class CheckpointConf 
    {

        /// <summary>
        /// 断点ID
        /// </summary>
        [JsonProperty("checkpoint_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckpointId { get; set; }

        /// <summary>
        /// 保存续训任务的步数。 0：关闭不保，-1：自动无限制。
        /// </summary>
        [JsonProperty("save_checkpoints_max", NullValueHandling = NullValueHandling.Ignore)]
        public int? SaveCheckpointsMax { get; set; }

        /// <summary>
        /// 跳过步数，0表示不跳过。
        /// </summary>
        [JsonProperty("skipped_steps", NullValueHandling = NullValueHandling.Ignore)]
        public int? SkippedSteps { get; set; }

        /// <summary>
        /// 是否续训任务。  0：非续训,，1:续训。
        /// </summary>
        [JsonProperty("restore_training", NullValueHandling = NullValueHandling.Ignore)]
        public int? RestoreTraining { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckpointConf {\n");
            sb.Append("  checkpointId: ").Append(CheckpointId).Append("\n");
            sb.Append("  saveCheckpointsMax: ").Append(SaveCheckpointsMax).Append("\n");
            sb.Append("  skippedSteps: ").Append(SkippedSteps).Append("\n");
            sb.Append("  restoreTraining: ").Append(RestoreTraining).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckpointConf);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CheckpointConf input)
        {
            if (input == null) return false;
            if (this.CheckpointId != input.CheckpointId || (this.CheckpointId != null && !this.CheckpointId.Equals(input.CheckpointId))) return false;
            if (this.SaveCheckpointsMax != input.SaveCheckpointsMax || (this.SaveCheckpointsMax != null && !this.SaveCheckpointsMax.Equals(input.SaveCheckpointsMax))) return false;
            if (this.SkippedSteps != input.SkippedSteps || (this.SkippedSteps != null && !this.SkippedSteps.Equals(input.SkippedSteps))) return false;
            if (this.RestoreTraining != input.RestoreTraining || (this.RestoreTraining != null && !this.RestoreTraining.Equals(input.RestoreTraining))) return false;

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
                if (this.SaveCheckpointsMax != null) hashCode = hashCode * 59 + this.SaveCheckpointsMax.GetHashCode();
                if (this.SkippedSteps != null) hashCode = hashCode * 59 + this.SkippedSteps.GetHashCode();
                if (this.RestoreTraining != null) hashCode = hashCode * 59 + this.RestoreTraining.GetHashCode();
                return hashCode;
            }
        }
    }
}
