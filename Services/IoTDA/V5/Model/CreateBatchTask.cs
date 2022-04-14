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
        /// **参数说明**：资源空间ID。此参数为非必选参数，存在多资源空间的用户需要使用该接口时，建议携带该参数指定创建的批量任务归属到哪个资源空间下，否则创建的批量任务将会归属到[默认资源空间](https://support.huaweicloud.com/usermanual-iothub/iot_01_0006.html#section0)下。 **取值范围**：长度不超过36，只允许字母、数字、下划线（_）、连接符（-）的组合。
        /// </summary>
        [JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }

        /// <summary>
        /// **参数说明**：批量任务名称。 **取值范围**：长度不超过128，只允许中文、字母、数字、下划线（_）的组合。
        /// </summary>
        [JsonProperty("task_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskName { get; set; }

        /// <summary>
        /// **参数说明**：批量任务类型。 **取值范围**： - softwareUpgrade: 软件升级任务 - firmwareUpgrade: 固件升级任务 - createDevices: 批量创建设备任务 - deleteDevices: 批量删除设备任务 - freezeDevices: 批量冻结设备任务 - unfreezeDevices: 批量解冻设备任务 - createCommands: 批量创建同步命令任务 - createAsyncCommands: 批量创建异步命令任务 - createMessages: 批量创建消息任务 - updateDeviceShadows：批量配置设备影子任务
        /// </summary>
        [JsonProperty("task_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskType { get; set; }

        /// <summary>
        /// **参数说明**：执行批量任务的目标，此处填写device_id列表，且最多支持3万个device_id。当task_type为firmwareUpgrade，softwareUpgrade，deleteDevices，freezeDevices，unfreezeDevices，createCommands，createAsyncCommands，createMessages，updateDeviceShadows，支持该参数。同时使用targets、targets_filter、document_source参数时，只有一个参数会生效，且平台优先使用targets，其次是targets_filter，最后是document_source。 **取值范围**：device_id列表。device_id支持长度不超过128，只允许字母、数字、下划线（_）、连接符（-）的组合。
        /// </summary>
        [JsonProperty("targets", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Targets { get; set; }

        /// <summary>
        /// **参数说明**：任务目标筛选参数。Json格式，里面是一个个键值对，（K,V）格式标识筛选targets需要的参数，目前支持的K有group_ids（V填写group_id数组，eg:[\&quot;e495cf17-ff79-4294-8f64-4d367919d665\&quot;]，任务则会筛选出来符合该群组条件的设备作为目标）。当task_type为firmwareUpgrade，softwareUpgrade，createDevices，deleteDevices，freezeDevices，unfreezeDevices，createCommands，createAsyncCommands，createMessages，updateDeviceShadows，支持该参数。同时使用targets、targets_filter、document_source参数时，只有一个参数会生效，且平台优先使用targets，其次是targets_filter，最后是document_source。
        /// </summary>
        [JsonProperty("targets_filter", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Object> TargetsFilter { get; set; }

        /// <summary>
        /// **参数说明**：执行任务数据文档，Json格式，Json里面是(K,V)键值对。当task_type为firmwareUpgrade，softwareUpgrade，createCommands，createAsyncCommands，createMessages，updateDeviceShadows，支持该参数。 - softwareUpgrade|firmwareUpgrade，需要填写key为package_id，value为在平台上传的软固件附件id，id由portal软件库包管理上传并查询获得。eg：“{\&quot;package_id\&quot;: \&quot;32822e5744a45ede319d2c50\&quot;}”。 - createCommands，需要填写同步命令相关参数，eg：“{\&quot;service_id\&quot;:\&quot;water\&quot;,\&quot;command_name\&quot;:\&quot;ON_OFF\&quot;,\&quot;paras\&quot;:{\&quot;value\&quot;:\&quot;ON\&quot;}}”，参考[设备同步命令](https://support.huaweicloud.com/api-iothub/iot_06_v5_0038.html))。 - createAsyncCommands，需要填写异步命令相关参数，eg：“{\&quot;service_id\&quot;:\&quot;water\&quot;,\&quot;command_name\&quot;:\&quot;ON_OFF\&quot;,\&quot;paras\&quot;:{\&quot;value\&quot;:\&quot;ON\&quot;},\&quot;expire_time\&quot;:0,\&quot;send_strategy\&quot;:\&quot;immediately\&quot;}”，参考[设备异步命令](https://support.huaweicloud.com/api-iothub/iot_06_v5_0040.html))。 - createMessages，需要填写消息下发相关参数，eg：“{\&quot;message_id\&quot;:\&quot;99b32da9-cd17-4cdf-a286-f6e849cbc364\&quot;,\&quot;name\&quot;:\&quot;messageName\&quot;,\&quot;message\&quot;:\&quot;HelloWorld\&quot;,\&quot;encoding\&quot;:\&quot;none\&quot;,\&quot;payload_format\&quot;:\&quot;standard\&quot;,\&quot;topic\&quot;:\&quot;messageDown\&quot;,\&quot;topic_full_name\&quot;:\&quot;/device/message/down\&quot;}”，参考[下发设备消息](https://support.huaweicloud.com/api-iothub/iot_06_v5_0059.html))。 - updateDeviceShadows，需要填写配置设备影子相关参数，eg：“{\&quot;shadow\&quot;: [{\&quot;service_id\&quot;: \&quot;WaterMeter\&quot;,\&quot;desired\&quot;: {\&quot;temperature\&quot;: \&quot;60\&quot;}}]}”，参考[配置设备影子预期数据](https://support.huaweicloud.com/api-iothub/iot_06_v5_0072.html))。限制说明：1. service_id和desired参数必填。2. 配置的service_id数量不大于5个且service_id不能重复。3. 配置参数内容大小不超过10K。
        /// </summary>
        [JsonProperty("document", NullValueHandling = NullValueHandling.Ignore)]
        public Object Document { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("task_policy", NullValueHandling = NullValueHandling.Ignore)]
        public TaskPolicy TaskPolicy { get; set; }

        /// <summary>
        /// **参数说明**：上传的批量任务文件ID。当task_type为createDevices，deleteDevices，freezeDevices，unfreezeDevices时，支持该参数。使用该参数时，需要先调用批量任务的文件管理接口上传文件来获取文件ID，文件样例请参见 [批量注册设备模板](https://developer.obs.cn-north-4.myhuaweicloud.com/template/BatchCreateDevices_Template.xlsx)，[批量删除设备模板](https://developer.obs.cn-north-4.myhuaweicloud.com/template/BatchDeleteDevices_Template.xlsx)，[批量冻结设备模板](https://developer.obs.cn-north-4.myhuaweicloud.com/template/BatchFreezeDevices_Template.xlsx)，[批量解冻设备模板](https://developer.obs.cn-north-4.myhuaweicloud.com/template/BatchUnfreezeDevices_Template.xlsx)。同时使用targets、targets_filter、document_source参数时，只有一个参数会生效，且平台优先使用targets，其次是targets_filter，最后是document_source。
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
