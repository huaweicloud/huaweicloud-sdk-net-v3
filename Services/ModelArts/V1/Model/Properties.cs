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
    /// **参数解释**：数据集资产扩展信息。 **约束限制**：不涉及。
    /// </summary>
    public class Properties 
    {

        /// <summary>
        /// **参数解释**：数据集的条数。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("dataset_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? DatasetNum { get; set; }

        /// <summary>
        /// **参数解释**：数据集资产资源文件总大小。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("dataset_size", NullValueHandling = NullValueHandling.Ignore)]
        public long? DatasetSize { get; set; }

        /// <summary>
        /// **参数解释**：数据集资产评测模版相对地址。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("prompt_config", NullValueHandling = NullValueHandling.Ignore)]
        public string PromptConfig { get; set; }

        /// <summary>
        /// **参数解释**：数据集资产版权信息，包含数据集信息，License和地址。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("data_copyright", NullValueHandling = NullValueHandling.Ignore)]
        public string DataCopyright { get; set; }

        /// <summary>
        /// **参数解释**：数据集资产索引文件地址。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("manifest_file_path", NullValueHandling = NullValueHandling.Ignore)]
        public string ManifestFilePath { get; set; }

        /// <summary>
        /// **参数解释**：算子参数列表。 **约束限制**：不涉及。
        /// </summary>
        [JsonProperty("arguments", NullValueHandling = NullValueHandling.Ignore)]
        public List<OperatorArgument> Arguments { get; set; }

        /// <summary>
        /// **参数解释**：数据集资产修改人信息。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("updater", NullValueHandling = NullValueHandling.Ignore)]
        public string Updater { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Properties {\n");
            sb.Append("  datasetNum: ").Append(DatasetNum).Append("\n");
            sb.Append("  datasetSize: ").Append(DatasetSize).Append("\n");
            sb.Append("  promptConfig: ").Append(PromptConfig).Append("\n");
            sb.Append("  dataCopyright: ").Append(DataCopyright).Append("\n");
            sb.Append("  manifestFilePath: ").Append(ManifestFilePath).Append("\n");
            sb.Append("  arguments: ").Append(Arguments).Append("\n");
            sb.Append("  updater: ").Append(Updater).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Properties);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Properties input)
        {
            if (input == null) return false;
            if (this.DatasetNum != input.DatasetNum || (this.DatasetNum != null && !this.DatasetNum.Equals(input.DatasetNum))) return false;
            if (this.DatasetSize != input.DatasetSize || (this.DatasetSize != null && !this.DatasetSize.Equals(input.DatasetSize))) return false;
            if (this.PromptConfig != input.PromptConfig || (this.PromptConfig != null && !this.PromptConfig.Equals(input.PromptConfig))) return false;
            if (this.DataCopyright != input.DataCopyright || (this.DataCopyright != null && !this.DataCopyright.Equals(input.DataCopyright))) return false;
            if (this.ManifestFilePath != input.ManifestFilePath || (this.ManifestFilePath != null && !this.ManifestFilePath.Equals(input.ManifestFilePath))) return false;
            if (this.Arguments != input.Arguments || (this.Arguments != null && input.Arguments != null && !this.Arguments.SequenceEqual(input.Arguments))) return false;
            if (this.Updater != input.Updater || (this.Updater != null && !this.Updater.Equals(input.Updater))) return false;

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
                if (this.DatasetNum != null) hashCode = hashCode * 59 + this.DatasetNum.GetHashCode();
                if (this.DatasetSize != null) hashCode = hashCode * 59 + this.DatasetSize.GetHashCode();
                if (this.PromptConfig != null) hashCode = hashCode * 59 + this.PromptConfig.GetHashCode();
                if (this.DataCopyright != null) hashCode = hashCode * 59 + this.DataCopyright.GetHashCode();
                if (this.ManifestFilePath != null) hashCode = hashCode * 59 + this.ManifestFilePath.GetHashCode();
                if (this.Arguments != null) hashCode = hashCode * 59 + this.Arguments.GetHashCode();
                if (this.Updater != null) hashCode = hashCode * 59 + this.Updater.GetHashCode();
                return hashCode;
            }
        }
    }
}
