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
    /// 创建导出任务结构体。
    /// </summary>
    public class AddExportTask 
    {

        /// <summary>
        /// 导出源资源类型，支持批量任务导出类型BatchTask。
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// 资源过滤条件，Json 格式，里面是(K,V)键值对，当resource_type为BatchTask时填写填写key为task_id，value为BatchTask的task_id(task_id从批量任务接口获得)。
        /// </summary>
        [JsonProperty("resource_condition", NullValueHandling = NullValueHandling.Ignore)]
        public Object ResourceCondition { get; set; }

        /// <summary>
        /// 导出格式，目前仅支持xls格式,默认格式为xls.(注意下载的文件已使用zip打包，后缀为&#39;.zip&#39;，此处格式指的导出内容承载格式)
        /// </summary>
        [JsonProperty("export_format", NullValueHandling = NullValueHandling.Ignore)]
        public string ExportFormat { get; set; }

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
            sb.Append("class AddExportTask {\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  resourceCondition: ").Append(ResourceCondition).Append("\n");
            sb.Append("  exportFormat: ").Append(ExportFormat).Append("\n");
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
            return this.Equals(input as AddExportTask);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddExportTask input)
        {
            if (input == null) return false;
            if (this.ResourceType != input.ResourceType || (this.ResourceType != null && !this.ResourceType.Equals(input.ResourceType))) return false;
            if (this.ResourceCondition != input.ResourceCondition || (this.ResourceCondition != null && !this.ResourceCondition.Equals(input.ResourceCondition))) return false;
            if (this.ExportFormat != input.ExportFormat || (this.ExportFormat != null && !this.ExportFormat.Equals(input.ExportFormat))) return false;
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
                if (this.ResourceType != null) hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.ResourceCondition != null) hashCode = hashCode * 59 + this.ResourceCondition.GetHashCode();
                if (this.ExportFormat != null) hashCode = hashCode * 59 + this.ExportFormat.GetHashCode();
                if (this.AppType != null) hashCode = hashCode * 59 + this.AppType.GetHashCode();
                if (this.AppId != null) hashCode = hashCode * 59 + this.AppId.GetHashCode();
                return hashCode;
            }
        }
    }
}
