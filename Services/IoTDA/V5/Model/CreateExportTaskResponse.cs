using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreateExportTaskResponse : SdkResponse
    {

        /// <summary>
        /// 导出任务唯一id。
        /// </summary>
        [JsonProperty("export_task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExportTaskId { get; set; }

        /// <summary>
        /// 导出源资源类型，支持批量任务导出类型BatchTask。
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// 资源过滤条件，Json格式，里面是(K,V)键值对，当resource_type为BatchTask时填写填写key为task_id，value为BatchTask的task_id(task_id从批量任务接口获得)。
        /// </summary>
        [JsonProperty("resource_condition", NullValueHandling = NullValueHandling.Ignore)]
        public Object ResourceCondition { get; set; }

        /// <summary>
        /// 导出格式，目前xls格式。
        /// </summary>
        [JsonProperty("export_format", NullValueHandling = NullValueHandling.Ignore)]
        public string ExportFormat { get; set; }

        /// <summary>
        /// 任务状态，状态分别有：Processing：执行中，Success：成功，Failed：失败。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 已导出的资源数量。
        /// </summary>
        [JsonProperty("export_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExportCount { get; set; }

        /// <summary>
        /// 导出任务的执行进度，取值范围为1-100，当100表示进度为100%，任务完成。
        /// </summary>
        [JsonProperty("progress", NullValueHandling = NullValueHandling.Ignore)]
        public int? Progress { get; set; }

        /// <summary>
        /// 在物联网平台创建产品的时间，格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;，如2020-08-12T12:12:12.333Z。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 导出任务的执行结束时间，格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;，如2020-08-12T12:12:12.333Z。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 租户规则的生效范围，默认GLOBAL，取值如下： - GLOBAL：生效范围为租户级 - APP：生效范围为应用级，如果类型为APP，需要携带app_id，如果不带，生效范围为defaultApp。 
        /// </summary>
        [JsonProperty("app_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AppType { get; set; }

        /// <summary>
        /// 应用ID。此参数为非必选参数，用于兼容平台老用户存在多应用的场景。存在多应用的用户需要使用该接口时，必须携带该参数指定创建的规则归属到哪个应用下，否则接口会提示错误。如果用户存在多应用，同时又不想携带该参数，可以联系华为技术支持对用户数据做应用合并。
        /// </summary>
        [JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateExportTaskResponse {\n");
            sb.Append("  exportTaskId: ").Append(ExportTaskId).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  resourceCondition: ").Append(ResourceCondition).Append("\n");
            sb.Append("  exportFormat: ").Append(ExportFormat).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  exportCount: ").Append(ExportCount).Append("\n");
            sb.Append("  progress: ").Append(Progress).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  appType: ").Append(AppType).Append("\n");
            sb.Append("  appId: ").Append(AppId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateExportTaskResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateExportTaskResponse input)
        {
            if (input == null) return false;
            if (this.ExportTaskId != input.ExportTaskId || (this.ExportTaskId != null && !this.ExportTaskId.Equals(input.ExportTaskId))) return false;
            if (this.ResourceType != input.ResourceType || (this.ResourceType != null && !this.ResourceType.Equals(input.ResourceType))) return false;
            if (this.ResourceCondition != input.ResourceCondition || (this.ResourceCondition != null && !this.ResourceCondition.Equals(input.ResourceCondition))) return false;
            if (this.ExportFormat != input.ExportFormat || (this.ExportFormat != null && !this.ExportFormat.Equals(input.ExportFormat))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.ExportCount != input.ExportCount || (this.ExportCount != null && !this.ExportCount.Equals(input.ExportCount))) return false;
            if (this.Progress != input.Progress || (this.Progress != null && !this.Progress.Equals(input.Progress))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.AppType != input.AppType || (this.AppType != null && !this.AppType.Equals(input.AppType))) return false;
            if (this.AppId != input.AppId || (this.AppId != null && !this.AppId.Equals(input.AppId))) return false;

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
                if (this.ExportTaskId != null) hashCode = hashCode * 59 + this.ExportTaskId.GetHashCode();
                if (this.ResourceType != null) hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.ResourceCondition != null) hashCode = hashCode * 59 + this.ResourceCondition.GetHashCode();
                if (this.ExportFormat != null) hashCode = hashCode * 59 + this.ExportFormat.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ExportCount != null) hashCode = hashCode * 59 + this.ExportCount.GetHashCode();
                if (this.Progress != null) hashCode = hashCode * 59 + this.Progress.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.AppType != null) hashCode = hashCode * 59 + this.AppType.GetHashCode();
                if (this.AppId != null) hashCode = hashCode * 59 + this.AppId.GetHashCode();
                return hashCode;
            }
        }
    }
}
