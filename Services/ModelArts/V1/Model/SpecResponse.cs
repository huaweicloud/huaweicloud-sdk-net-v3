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
    /// 训练作业规格参数。
    /// </summary>
    public class SpecResponse 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("resource", NullValueHandling = NullValueHandling.Ignore)]
        public Resource Resource { get; set; }

        /// <summary>
        /// **参数解释**：训练作业挂载卷信息。
        /// </summary>
        [JsonProperty("volumes", NullValueHandling = NullValueHandling.Ignore)]
        public List<JobVolumeResp> Volumes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("log_export_path", NullValueHandling = NullValueHandling.Ignore)]
        public LogExportPathResp LogExportPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("schedule_policy", NullValueHandling = NullValueHandling.Ignore)]
        public SchedulePolicyResp SchedulePolicy { get; set; }

        /// <summary>
        /// **参数解释**：指标采集配置。
        /// </summary>
        [JsonProperty("custom_metrics", NullValueHandling = NullValueHandling.Ignore)]
        public List<CustomMetrics> CustomMetrics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("output_model", NullValueHandling = NullValueHandling.Ignore)]
        public OutputModelResp OutputModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("asset_model", NullValueHandling = NullValueHandling.Ignore)]
        public AssetModelResp AssetModel { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SpecResponse {\n");
            sb.Append("  resource: ").Append(Resource).Append("\n");
            sb.Append("  volumes: ").Append(Volumes).Append("\n");
            sb.Append("  logExportPath: ").Append(LogExportPath).Append("\n");
            sb.Append("  schedulePolicy: ").Append(SchedulePolicy).Append("\n");
            sb.Append("  customMetrics: ").Append(CustomMetrics).Append("\n");
            sb.Append("  outputModel: ").Append(OutputModel).Append("\n");
            sb.Append("  assetModel: ").Append(AssetModel).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SpecResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SpecResponse input)
        {
            if (input == null) return false;
            if (this.Resource != input.Resource || (this.Resource != null && !this.Resource.Equals(input.Resource))) return false;
            if (this.Volumes != input.Volumes || (this.Volumes != null && input.Volumes != null && !this.Volumes.SequenceEqual(input.Volumes))) return false;
            if (this.LogExportPath != input.LogExportPath || (this.LogExportPath != null && !this.LogExportPath.Equals(input.LogExportPath))) return false;
            if (this.SchedulePolicy != input.SchedulePolicy || (this.SchedulePolicy != null && !this.SchedulePolicy.Equals(input.SchedulePolicy))) return false;
            if (this.CustomMetrics != input.CustomMetrics || (this.CustomMetrics != null && input.CustomMetrics != null && !this.CustomMetrics.SequenceEqual(input.CustomMetrics))) return false;
            if (this.OutputModel != input.OutputModel || (this.OutputModel != null && !this.OutputModel.Equals(input.OutputModel))) return false;
            if (this.AssetModel != input.AssetModel || (this.AssetModel != null && !this.AssetModel.Equals(input.AssetModel))) return false;

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
                if (this.Resource != null) hashCode = hashCode * 59 + this.Resource.GetHashCode();
                if (this.Volumes != null) hashCode = hashCode * 59 + this.Volumes.GetHashCode();
                if (this.LogExportPath != null) hashCode = hashCode * 59 + this.LogExportPath.GetHashCode();
                if (this.SchedulePolicy != null) hashCode = hashCode * 59 + this.SchedulePolicy.GetHashCode();
                if (this.CustomMetrics != null) hashCode = hashCode * 59 + this.CustomMetrics.GetHashCode();
                if (this.OutputModel != null) hashCode = hashCode * 59 + this.OutputModel.GetHashCode();
                if (this.AssetModel != null) hashCode = hashCode * 59 + this.AssetModel.GetHashCode();
                return hashCode;
            }
        }
    }
}
