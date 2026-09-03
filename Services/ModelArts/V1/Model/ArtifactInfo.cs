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
    public class ArtifactInfo 
    {

        /// <summary>
        /// 产物类型，可选值：final(最终产物)、middle(中间产物)。
        /// </summary>
        [JsonProperty("artifact_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ArtifactType { get; set; }

        /// <summary>
        /// 是否最优。
        /// </summary>
        [JsonProperty("is_best", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsBest { get; set; }

        /// <summary>
        /// 产物id。最终产物为模型ID，中间产物为断点ID。
        /// </summary>
        [JsonProperty("artifact_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ArtifactId { get; set; }

        /// <summary>
        /// 续训任务数量。
        /// </summary>
        [JsonProperty("continue_train_nums", NullValueHandling = NullValueHandling.Ignore)]
        public int? ContinueTrainNums { get; set; }

        /// <summary>
        /// 产物发布成功后的资产id。
        /// </summary>
        [JsonProperty("asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetId { get; set; }

        /// <summary>
        /// 产物发布成功后的资产名称。
        /// </summary>
        [JsonProperty("asset_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetName { get; set; }

        /// <summary>
        /// 发布状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

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
        /// loss值
        /// </summary>
        [JsonProperty("loss", NullValueHandling = NullValueHandling.Ignore)]
        public double? Loss { get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 产物发布失败的错误信息。
        /// </summary>
        [JsonProperty("publish_error_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string PublishErrorMsg { get; set; }

        /// <summary>
        /// 相关任务信息
        /// </summary>
        [JsonProperty("task_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<ContinueTrainTask> TaskInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArtifactInfo {\n");
            sb.Append("  artifactType: ").Append(ArtifactType).Append("\n");
            sb.Append("  isBest: ").Append(IsBest).Append("\n");
            sb.Append("  artifactId: ").Append(ArtifactId).Append("\n");
            sb.Append("  continueTrainNums: ").Append(ContinueTrainNums).Append("\n");
            sb.Append("  assetId: ").Append(AssetId).Append("\n");
            sb.Append("  assetName: ").Append(AssetName).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  epoch: ").Append(Epoch).Append("\n");
            sb.Append("  steps: ").Append(Steps).Append("\n");
            sb.Append("  loss: ").Append(Loss).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  publishErrorMsg: ").Append(PublishErrorMsg).Append("\n");
            sb.Append("  taskInfos: ").Append(TaskInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ArtifactInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ArtifactInfo input)
        {
            if (input == null) return false;
            if (this.ArtifactType != input.ArtifactType || (this.ArtifactType != null && !this.ArtifactType.Equals(input.ArtifactType))) return false;
            if (this.IsBest != input.IsBest || (this.IsBest != null && !this.IsBest.Equals(input.IsBest))) return false;
            if (this.ArtifactId != input.ArtifactId || (this.ArtifactId != null && !this.ArtifactId.Equals(input.ArtifactId))) return false;
            if (this.ContinueTrainNums != input.ContinueTrainNums || (this.ContinueTrainNums != null && !this.ContinueTrainNums.Equals(input.ContinueTrainNums))) return false;
            if (this.AssetId != input.AssetId || (this.AssetId != null && !this.AssetId.Equals(input.AssetId))) return false;
            if (this.AssetName != input.AssetName || (this.AssetName != null && !this.AssetName.Equals(input.AssetName))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Epoch != input.Epoch || (this.Epoch != null && !this.Epoch.Equals(input.Epoch))) return false;
            if (this.Steps != input.Steps || (this.Steps != null && !this.Steps.Equals(input.Steps))) return false;
            if (this.Loss != input.Loss || (this.Loss != null && !this.Loss.Equals(input.Loss))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.PublishErrorMsg != input.PublishErrorMsg || (this.PublishErrorMsg != null && !this.PublishErrorMsg.Equals(input.PublishErrorMsg))) return false;
            if (this.TaskInfos != input.TaskInfos || (this.TaskInfos != null && input.TaskInfos != null && !this.TaskInfos.SequenceEqual(input.TaskInfos))) return false;

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
                if (this.ArtifactType != null) hashCode = hashCode * 59 + this.ArtifactType.GetHashCode();
                if (this.IsBest != null) hashCode = hashCode * 59 + this.IsBest.GetHashCode();
                if (this.ArtifactId != null) hashCode = hashCode * 59 + this.ArtifactId.GetHashCode();
                if (this.ContinueTrainNums != null) hashCode = hashCode * 59 + this.ContinueTrainNums.GetHashCode();
                if (this.AssetId != null) hashCode = hashCode * 59 + this.AssetId.GetHashCode();
                if (this.AssetName != null) hashCode = hashCode * 59 + this.AssetName.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Epoch != null) hashCode = hashCode * 59 + this.Epoch.GetHashCode();
                if (this.Steps != null) hashCode = hashCode * 59 + this.Steps.GetHashCode();
                if (this.Loss != null) hashCode = hashCode * 59 + this.Loss.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.PublishErrorMsg != null) hashCode = hashCode * 59 + this.PublishErrorMsg.GetHashCode();
                if (this.TaskInfos != null) hashCode = hashCode * 59 + this.TaskInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
