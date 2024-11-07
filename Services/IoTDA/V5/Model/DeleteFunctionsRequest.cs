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
    /// Request Object
    /// </summary>
    public class DeleteFunctionsRequest 
    {

        /// <summary>
        /// **参数说明**：实例ID。物理多租下各实例的唯一标识，建议携带该参数，在使用专业版时必须携带该参数。您可以在IoTDA管理控制台界面，选择左侧导航栏“总览”页签查看当前实例的ID，具体获取方式请参考[[查看实例详情](https://support.huaweicloud.com/usermanual-iothub/iot_01_0079.html#section1)](tag:hws) [[查看实例详情](https://support.huaweicloud.com/intl/zh-cn/usermanual-iothub/iot_01_0079.html#section1)](tag:hws_hk)。
        /// </summary>
        [SDKProperty("Instance-Id", IsHeader = true)]
        [JsonProperty("Instance-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// **参数说明**：Sp用户Token。通过调用IoBPS服务获取SP用户Token。
        /// </summary>
        [SDKProperty("Sp-Auth-Token", IsHeader = true)]
        [JsonProperty("Sp-Auth-Token", NullValueHandling = NullValueHandling.Ignore)]
        public string SpAuthToken { get; set; }

        /// <summary>
        /// **参数说明**：Stage用户的Token, 仅提供给IoStage服务使用。
        /// </summary>
        [SDKProperty("Stage-Auth-Token", IsHeader = true)]
        [JsonProperty("Stage-Auth-Token", NullValueHandling = NullValueHandling.Ignore)]
        public string StageAuthToken { get; set; }

        /// <summary>
        /// **参数说明**：函数ID。
        /// </summary>
        [SDKProperty("function_id", IsPath = true)]
        [JsonProperty("function_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FunctionId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteFunctionsRequest {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  spAuthToken: ").Append(SpAuthToken).Append("\n");
            sb.Append("  stageAuthToken: ").Append(StageAuthToken).Append("\n");
            sb.Append("  functionId: ").Append(FunctionId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteFunctionsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteFunctionsRequest input)
        {
            if (input == null) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.SpAuthToken != input.SpAuthToken || (this.SpAuthToken != null && !this.SpAuthToken.Equals(input.SpAuthToken))) return false;
            if (this.StageAuthToken != input.StageAuthToken || (this.StageAuthToken != null && !this.StageAuthToken.Equals(input.StageAuthToken))) return false;
            if (this.FunctionId != input.FunctionId || (this.FunctionId != null && !this.FunctionId.Equals(input.FunctionId))) return false;

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
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.SpAuthToken != null) hashCode = hashCode * 59 + this.SpAuthToken.GetHashCode();
                if (this.StageAuthToken != null) hashCode = hashCode * 59 + this.StageAuthToken.GetHashCode();
                if (this.FunctionId != null) hashCode = hashCode * 59 + this.FunctionId.GetHashCode();
                return hashCode;
            }
        }
    }
}
