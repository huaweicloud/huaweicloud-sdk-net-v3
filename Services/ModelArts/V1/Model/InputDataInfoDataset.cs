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
    /// 数据输入信息为数据集。
    /// </summary>
    public class InputDataInfoDataset 
    {

        /// <summary>
        /// 训练作业的数据集ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 训练作业的数据集版本ID。
        /// </summary>
        [JsonProperty("version_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionId { get; set; }

        /// <summary>
        /// 训练作业需要的数据集OBS路径URL，ModelArts会通过数据集ID和数据集版本ID自动解析生成。如：“/usr/data/”。
        /// </summary>
        [JsonProperty("obs_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsUrl { get; set; }

        /// <summary>
        /// **参数解释**：数据集服务类型。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：取值为V3时表示使用的是资产服务提供的数据集，其他表示旧版数据集。
        /// </summary>
        [JsonProperty("service_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceType { get; set; }

        /// <summary>
        /// **参数解释**：训练作业的数据集名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**：精调训练作业的数据集配比比率，表示使用多少比率的该数据集进行训练。
        /// </summary>
        [JsonProperty("dataset_proportion", NullValueHandling = NullValueHandling.Ignore)]
        public int? DatasetProportion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InputDataInfoDataset {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  versionId: ").Append(VersionId).Append("\n");
            sb.Append("  obsUrl: ").Append(ObsUrl).Append("\n");
            sb.Append("  serviceType: ").Append(ServiceType).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  datasetProportion: ").Append(DatasetProportion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InputDataInfoDataset);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InputDataInfoDataset input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.VersionId != input.VersionId || (this.VersionId != null && !this.VersionId.Equals(input.VersionId))) return false;
            if (this.ObsUrl != input.ObsUrl || (this.ObsUrl != null && !this.ObsUrl.Equals(input.ObsUrl))) return false;
            if (this.ServiceType != input.ServiceType || (this.ServiceType != null && !this.ServiceType.Equals(input.ServiceType))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.VersionId != null) hashCode = hashCode * 59 + this.VersionId.GetHashCode();
                if (this.ObsUrl != null) hashCode = hashCode * 59 + this.ObsUrl.GetHashCode();
                if (this.ServiceType != null) hashCode = hashCode * 59 + this.ServiceType.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.DatasetProportion != null) hashCode = hashCode * 59 + this.DatasetProportion.GetHashCode();
                return hashCode;
            }
        }
    }
}
