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
    public class DatasetConfig 
    {

        /// <summary>
        /// 训练数据集名称，取自数据集列表接口响应体name。
        /// </summary>
        [JsonProperty("dataset_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DatasetName { get; set; }

        /// <summary>
        /// 所使用的数据集来源，取值datamng|OBS|DB,分别表示来自于数据工程|OBS|数据库
        /// </summary>
        [JsonProperty("dataset_source", NullValueHandling = NullValueHandling.Ignore)]
        public string DatasetSource { get; set; }

        /// <summary>
        /// 训练数据集id，取自数据集列表接口响应体dataset_id。
        /// </summary>
        [JsonProperty("dataset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DatasetId { get; set; }

        /// <summary>
        /// 训练、验证数据集分割比率，当该模型支持验证集且验证集来自选择的训练集时使用，取值大于等于1，小于等于50。
        /// </summary>
        [JsonProperty("split_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public int? SplitRatio { get; set; }

        /// <summary>
        /// 数据集使用的阶段，取值为train|eval|test，分别表示该数据集用于训练|验证|测试。
        /// </summary>
        [JsonProperty("used_step", NullValueHandling = NullValueHandling.Ignore)]
        public string UsedStep { get; set; }

        /// <summary>
        /// 数据集配比比率，表示使用多少比率的该数据集进行训练。
        /// </summary>
        [JsonProperty("dataset_proportion", NullValueHandling = NullValueHandling.Ignore)]
        public int? DatasetProportion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DatasetConfig {\n");
            sb.Append("  datasetName: ").Append(DatasetName).Append("\n");
            sb.Append("  datasetSource: ").Append(DatasetSource).Append("\n");
            sb.Append("  datasetId: ").Append(DatasetId).Append("\n");
            sb.Append("  splitRatio: ").Append(SplitRatio).Append("\n");
            sb.Append("  usedStep: ").Append(UsedStep).Append("\n");
            sb.Append("  datasetProportion: ").Append(DatasetProportion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DatasetConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DatasetConfig input)
        {
            if (input == null) return false;
            if (this.DatasetName != input.DatasetName || (this.DatasetName != null && !this.DatasetName.Equals(input.DatasetName))) return false;
            if (this.DatasetSource != input.DatasetSource || (this.DatasetSource != null && !this.DatasetSource.Equals(input.DatasetSource))) return false;
            if (this.DatasetId != input.DatasetId || (this.DatasetId != null && !this.DatasetId.Equals(input.DatasetId))) return false;
            if (this.SplitRatio != input.SplitRatio || (this.SplitRatio != null && !this.SplitRatio.Equals(input.SplitRatio))) return false;
            if (this.UsedStep != input.UsedStep || (this.UsedStep != null && !this.UsedStep.Equals(input.UsedStep))) return false;
            if (this.DatasetProportion != input.DatasetProportion || (this.DatasetProportion != null && !this.DatasetProportion.Equals(input.DatasetProportion))) return false;

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
                if (this.DatasetName != null) hashCode = hashCode * 59 + this.DatasetName.GetHashCode();
                if (this.DatasetSource != null) hashCode = hashCode * 59 + this.DatasetSource.GetHashCode();
                if (this.DatasetId != null) hashCode = hashCode * 59 + this.DatasetId.GetHashCode();
                if (this.SplitRatio != null) hashCode = hashCode * 59 + this.SplitRatio.GetHashCode();
                if (this.UsedStep != null) hashCode = hashCode * 59 + this.UsedStep.GetHashCode();
                if (this.DatasetProportion != null) hashCode = hashCode * 59 + this.DatasetProportion.GetHashCode();
                return hashCode;
            }
        }
    }
}
