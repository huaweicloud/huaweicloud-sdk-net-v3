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
    /// 训练作业规格参数。有此字段时，无需填写tasks字段。
    /// </summary>
    public class Spec 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("resource", NullValueHandling = NullValueHandling.Ignore)]
        public SpecResource Resource { get; set; }

        /// <summary>
        /// **参数解释**：训练作业挂载卷信息。 **约束限制**：不涉及。
        /// </summary>
        [JsonProperty("volumes", NullValueHandling = NullValueHandling.Ignore)]
        public List<SpecVolumes> Volumes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("log_export_path", NullValueHandling = NullValueHandling.Ignore)]
        public LogExportPath LogExportPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("auto_stop", NullValueHandling = NullValueHandling.Ignore)]
        public AutoStop AutoStop { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("schedule_policy", NullValueHandling = NullValueHandling.Ignore)]
        public SchedulePolicy SchedulePolicy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("log_export_config", NullValueHandling = NullValueHandling.Ignore)]
        public LogExportConfig LogExportConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("notification", NullValueHandling = NullValueHandling.Ignore)]
        public Notification Notification { get; set; }

        /// <summary>
        /// **参数解释**：指标采集配置。
        /// </summary>
        [JsonProperty("custom_metrics", NullValueHandling = NullValueHandling.Ignore)]
        public List<CustomMetrics> CustomMetrics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("output_model", NullValueHandling = NullValueHandling.Ignore)]
        public OutputModel OutputModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("asset_model", NullValueHandling = NullValueHandling.Ignore)]
        public AssetModel AssetModel { get; set; }

        /// <summary>
        /// **参数解释**：精调训练作业资产模型ID。
        /// </summary>
        [JsonProperty("asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Spec {\n");
            sb.Append("  resource: ").Append(Resource).Append("\n");
            sb.Append("  volumes: ").Append(Volumes).Append("\n");
            sb.Append("  logExportPath: ").Append(LogExportPath).Append("\n");
            sb.Append("  autoStop: ").Append(AutoStop).Append("\n");
            sb.Append("  schedulePolicy: ").Append(SchedulePolicy).Append("\n");
            sb.Append("  logExportConfig: ").Append(LogExportConfig).Append("\n");
            sb.Append("  notification: ").Append(Notification).Append("\n");
            sb.Append("  customMetrics: ").Append(CustomMetrics).Append("\n");
            sb.Append("  outputModel: ").Append(OutputModel).Append("\n");
            sb.Append("  assetModel: ").Append(AssetModel).Append("\n");
            sb.Append("  assetId: ").Append(AssetId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Spec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Spec input)
        {
            if (input == null) return false;
            if (this.Resource != input.Resource || (this.Resource != null && !this.Resource.Equals(input.Resource))) return false;
            if (this.Volumes != input.Volumes || (this.Volumes != null && input.Volumes != null && !this.Volumes.SequenceEqual(input.Volumes))) return false;
            if (this.LogExportPath != input.LogExportPath || (this.LogExportPath != null && !this.LogExportPath.Equals(input.LogExportPath))) return false;
            if (this.AutoStop != input.AutoStop || (this.AutoStop != null && !this.AutoStop.Equals(input.AutoStop))) return false;
            if (this.SchedulePolicy != input.SchedulePolicy || (this.SchedulePolicy != null && !this.SchedulePolicy.Equals(input.SchedulePolicy))) return false;
            if (this.LogExportConfig != input.LogExportConfig || (this.LogExportConfig != null && !this.LogExportConfig.Equals(input.LogExportConfig))) return false;
            if (this.Notification != input.Notification || (this.Notification != null && !this.Notification.Equals(input.Notification))) return false;
            if (this.CustomMetrics != input.CustomMetrics || (this.CustomMetrics != null && input.CustomMetrics != null && !this.CustomMetrics.SequenceEqual(input.CustomMetrics))) return false;
            if (this.OutputModel != input.OutputModel || (this.OutputModel != null && !this.OutputModel.Equals(input.OutputModel))) return false;
            if (this.AssetModel != input.AssetModel || (this.AssetModel != null && !this.AssetModel.Equals(input.AssetModel))) return false;
            if (this.AssetId != input.AssetId || (this.AssetId != null && !this.AssetId.Equals(input.AssetId))) return false;

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
                if (this.AutoStop != null) hashCode = hashCode * 59 + this.AutoStop.GetHashCode();
                if (this.SchedulePolicy != null) hashCode = hashCode * 59 + this.SchedulePolicy.GetHashCode();
                if (this.LogExportConfig != null) hashCode = hashCode * 59 + this.LogExportConfig.GetHashCode();
                if (this.Notification != null) hashCode = hashCode * 59 + this.Notification.GetHashCode();
                if (this.CustomMetrics != null) hashCode = hashCode * 59 + this.CustomMetrics.GetHashCode();
                if (this.OutputModel != null) hashCode = hashCode * 59 + this.OutputModel.GetHashCode();
                if (this.AssetModel != null) hashCode = hashCode * 59 + this.AssetModel.GetHashCode();
                if (this.AssetId != null) hashCode = hashCode * 59 + this.AssetId.GetHashCode();
                return hashCode;
            }
        }
    }
}
