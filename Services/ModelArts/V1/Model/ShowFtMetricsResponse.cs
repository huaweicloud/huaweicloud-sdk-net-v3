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
    /// Response Object
    /// </summary>
    public class ShowFtMetricsResponse : SdkResponse
    {

        /// <summary>
        /// 训练loss信息
        /// </summary>
        [JsonProperty("loss", NullValueHandling = NullValueHandling.Ignore)]
        public Object Loss { get; set; }

        /// <summary>
        /// 评测loss信息
        /// </summary>
        [JsonProperty("eval_loss", NullValueHandling = NullValueHandling.Ignore)]
        public Object EvalLoss { get; set; }

        /// <summary>
        /// 训练预估时长信息
        /// </summary>
        [JsonProperty("training_info", NullValueHandling = NullValueHandling.Ignore)]
        public Object TrainingInfo { get; set; }

        /// <summary>
        /// 训练进度信息
        /// </summary>
        [JsonProperty("train_process", NullValueHandling = NullValueHandling.Ignore)]
        public double? TrainProcess { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public FtMetricData Data { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowFtMetricsResponse {\n");
            sb.Append("  loss: ").Append(Loss).Append("\n");
            sb.Append("  evalLoss: ").Append(EvalLoss).Append("\n");
            sb.Append("  trainingInfo: ").Append(TrainingInfo).Append("\n");
            sb.Append("  trainProcess: ").Append(TrainProcess).Append("\n");
            sb.Append("  data: ").Append(Data).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowFtMetricsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowFtMetricsResponse input)
        {
            if (input == null) return false;
            if (this.Loss != input.Loss || (this.Loss != null && !this.Loss.Equals(input.Loss))) return false;
            if (this.EvalLoss != input.EvalLoss || (this.EvalLoss != null && !this.EvalLoss.Equals(input.EvalLoss))) return false;
            if (this.TrainingInfo != input.TrainingInfo || (this.TrainingInfo != null && !this.TrainingInfo.Equals(input.TrainingInfo))) return false;
            if (this.TrainProcess != input.TrainProcess || (this.TrainProcess != null && !this.TrainProcess.Equals(input.TrainProcess))) return false;
            if (this.Data != input.Data || (this.Data != null && !this.Data.Equals(input.Data))) return false;

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
                if (this.Loss != null) hashCode = hashCode * 59 + this.Loss.GetHashCode();
                if (this.EvalLoss != null) hashCode = hashCode * 59 + this.EvalLoss.GetHashCode();
                if (this.TrainingInfo != null) hashCode = hashCode * 59 + this.TrainingInfo.GetHashCode();
                if (this.TrainProcess != null) hashCode = hashCode * 59 + this.TrainProcess.GetHashCode();
                if (this.Data != null) hashCode = hashCode * 59 + this.Data.GetHashCode();
                return hashCode;
            }
        }
    }
}
