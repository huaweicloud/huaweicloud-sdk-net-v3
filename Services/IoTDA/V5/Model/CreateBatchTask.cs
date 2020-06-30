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
    /// 添加任务结构体
    /// </summary>
    public class CreateBatchTask 
    {

        /// <summary>
        /// 资源空间ID。此参数为非必选参数，存在多资源空间的用户需要使用该接口时，建议携带该参数指定创建的批量任务归属到哪个资源空间下，否则创建的批量任务将会归属到[默认资源空间](https://support.huaweicloud.com/usermanual-iothub/iot_01_0006.html#section0)下。
        /// </summary>
        [JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }

        /// <summary>
        /// 批量任务名称。
        /// </summary>
        [JsonProperty("task_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskName { get; set; }

        /// <summary>
        /// 批量任务类型，取值范围：firmwareUpgrade，softwareUpgrade。 - softwareUpgrade: 软件升级任务 - firmwareUpgrade: 固件升级任务 
        /// </summary>
        [JsonProperty("task_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskType { get; set; }

        /// <summary>
        /// 执行批量任务的目标，当task_type为firmwareUpgrade，softwareUpgrade时，此处填写device_id列表。
        /// </summary>
        [JsonProperty("targets", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Targets { get; set; }

        /// <summary>
        /// 任务目标筛选参数。Json格式，里面是一个个键值对，（K,V）格式标识筛选targets需要的参数，目前支持的K有group_ids（V填写group_id数组，eg:[\&quot;e495cf17-ff79-4294-8f64-4d367919d665\&quot;]，任务则会筛选出来符合该群组条件的设备作为目标）
        /// </summary>
        [JsonProperty("targets_filter", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Object> TargetsFilter { get; set; }

        /// <summary>
        /// 执行任务数据文档，Json格式，里面是(K,V)键值对。(当task_type 为softwareUpgrade|firmwareUpgrade，也就是软固件升级任务时需要填写key为package_id，value为在平台上传的软固件附件id，id由portal软件库包管理上传并查询获得)。
        /// </summary>
        [JsonProperty("document", NullValueHandling = NullValueHandling.Ignore)]
        public Object Document { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("task_policy", NullValueHandling = NullValueHandling.Ignore)]
        public TaskPolicy TaskPolicy { get; set; }

        /// <summary>
        /// 上传的批量任务文件ID。
        /// </summary>
        [JsonProperty("document_source", NullValueHandling = NullValueHandling.Ignore)]
        public string DocumentSource { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateBatchTask {\n");
            sb.Append("  appId: ").Append(AppId).Append("\n");
            sb.Append("  taskName: ").Append(TaskName).Append("\n");
            sb.Append("  taskType: ").Append(TaskType).Append("\n");
            sb.Append("  targets: ").Append(Targets).Append("\n");
            sb.Append("  targetsFilter: ").Append(TargetsFilter).Append("\n");
            sb.Append("  document: ").Append(Document).Append("\n");
            sb.Append("  taskPolicy: ").Append(TaskPolicy).Append("\n");
            sb.Append("  documentSource: ").Append(DocumentSource).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateBatchTask);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateBatchTask input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AppId == input.AppId ||
                    (this.AppId != null &&
                    this.AppId.Equals(input.AppId))
                ) && 
                (
                    this.TaskName == input.TaskName ||
                    (this.TaskName != null &&
                    this.TaskName.Equals(input.TaskName))
                ) && 
                (
                    this.TaskType == input.TaskType ||
                    (this.TaskType != null &&
                    this.TaskType.Equals(input.TaskType))
                ) && 
                (
                    this.Targets == input.Targets ||
                    this.Targets != null &&
                    input.Targets != null &&
                    this.Targets.SequenceEqual(input.Targets)
                ) && 
                (
                    this.TargetsFilter == input.TargetsFilter ||
                    this.TargetsFilter != null &&
                    input.TargetsFilter != null &&
                    this.TargetsFilter.SequenceEqual(input.TargetsFilter)
                ) && 
                (
                    this.Document == input.Document ||
                    (this.Document != null &&
                    this.Document.Equals(input.Document))
                ) && 
                (
                    this.TaskPolicy == input.TaskPolicy ||
                    (this.TaskPolicy != null &&
                    this.TaskPolicy.Equals(input.TaskPolicy))
                ) && 
                (
                    this.DocumentSource == input.DocumentSource ||
                    (this.DocumentSource != null &&
                    this.DocumentSource.Equals(input.DocumentSource))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AppId != null)
                    hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.TaskName != null)
                    hashCode = hashCode * 59 + this.TaskName.GetHashCode();
                if (this.TaskType != null)
                    hashCode = hashCode * 59 + this.TaskType.GetHashCode();
                if (this.Targets != null)
                    hashCode = hashCode * 59 + this.Targets.GetHashCode();
                if (this.TargetsFilter != null)
                    hashCode = hashCode * 59 + this.TargetsFilter.GetHashCode();
                if (this.Document != null)
                    hashCode = hashCode * 59 + this.Document.GetHashCode();
                if (this.TaskPolicy != null)
                    hashCode = hashCode * 59 + this.TaskPolicy.GetHashCode();
                if (this.DocumentSource != null)
                    hashCode = hashCode * 59 + this.DocumentSource.GetHashCode();
                return hashCode;
            }
        }
    }
}
