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
    /// 精调训练作业参数
    /// </summary>
    public class MasJobConfig 
    {

        /// <summary>
        /// 模型ID
        /// </summary>
        [JsonProperty("ft_job_uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string FtJobUuid { get; set; }

        /// <summary>
        /// 模型训练类型
        /// </summary>
        [JsonProperty("ft_train_type", NullValueHandling = NullValueHandling.Ignore)]
        public string FtTrainType { get; set; }

        /// <summary>
        /// 模型类型
        /// </summary>
        [JsonProperty("model_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ModelType { get; set; }

        /// <summary>
        /// 训练作业输出路径
        /// </summary>
        [JsonProperty("train_output_path", NullValueHandling = NullValueHandling.Ignore)]
        public string TrainOutputPath { get; set; }

        /// <summary>
        /// 训练作业进度
        /// </summary>
        [JsonProperty("train_process", NullValueHandling = NullValueHandling.Ignore)]
        public double? TrainProcess { get; set; }

        /// <summary>
        /// 断点ID
        /// </summary>
        [JsonProperty("checkpoint_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckpointId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("task_env", NullValueHandling = NullValueHandling.Ignore)]
        public TaskEnv TaskEnv { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("checkpoint_config", NullValueHandling = NullValueHandling.Ignore)]
        public CheckpointConf CheckpointConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MasJobConfig {\n");
            sb.Append("  ftJobUuid: ").Append(FtJobUuid).Append("\n");
            sb.Append("  ftTrainType: ").Append(FtTrainType).Append("\n");
            sb.Append("  modelType: ").Append(ModelType).Append("\n");
            sb.Append("  trainOutputPath: ").Append(TrainOutputPath).Append("\n");
            sb.Append("  trainProcess: ").Append(TrainProcess).Append("\n");
            sb.Append("  checkpointId: ").Append(CheckpointId).Append("\n");
            sb.Append("  taskEnv: ").Append(TaskEnv).Append("\n");
            sb.Append("  checkpointConfig: ").Append(CheckpointConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MasJobConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MasJobConfig input)
        {
            if (input == null) return false;
            if (this.FtJobUuid != input.FtJobUuid || (this.FtJobUuid != null && !this.FtJobUuid.Equals(input.FtJobUuid))) return false;
            if (this.FtTrainType != input.FtTrainType || (this.FtTrainType != null && !this.FtTrainType.Equals(input.FtTrainType))) return false;
            if (this.ModelType != input.ModelType || (this.ModelType != null && !this.ModelType.Equals(input.ModelType))) return false;
            if (this.TrainOutputPath != input.TrainOutputPath || (this.TrainOutputPath != null && !this.TrainOutputPath.Equals(input.TrainOutputPath))) return false;
            if (this.TrainProcess != input.TrainProcess || (this.TrainProcess != null && !this.TrainProcess.Equals(input.TrainProcess))) return false;
            if (this.CheckpointId != input.CheckpointId || (this.CheckpointId != null && !this.CheckpointId.Equals(input.CheckpointId))) return false;
            if (this.TaskEnv != input.TaskEnv || (this.TaskEnv != null && !this.TaskEnv.Equals(input.TaskEnv))) return false;
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
                if (this.FtJobUuid != null) hashCode = hashCode * 59 + this.FtJobUuid.GetHashCode();
                if (this.FtTrainType != null) hashCode = hashCode * 59 + this.FtTrainType.GetHashCode();
                if (this.ModelType != null) hashCode = hashCode * 59 + this.ModelType.GetHashCode();
                if (this.TrainOutputPath != null) hashCode = hashCode * 59 + this.TrainOutputPath.GetHashCode();
                if (this.TrainProcess != null) hashCode = hashCode * 59 + this.TrainProcess.GetHashCode();
                if (this.CheckpointId != null) hashCode = hashCode * 59 + this.CheckpointId.GetHashCode();
                if (this.TaskEnv != null) hashCode = hashCode * 59 + this.TaskEnv.GetHashCode();
                if (this.CheckpointConfig != null) hashCode = hashCode * 59 + this.CheckpointConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
