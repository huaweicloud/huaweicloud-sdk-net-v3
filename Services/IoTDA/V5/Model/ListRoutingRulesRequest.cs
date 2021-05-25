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
    public class ListRoutingRulesRequest 
    {

        /// <summary>
        /// 实例ID。物理多租下各实例的唯一标识，一般华为云租户无需携带该参数，仅在物理多租场景下从管理面访问API时需要携带该参数。
        /// </summary>
        [SDKProperty("Instance-Id", IsHeader = true)]
        [JsonProperty("Instance-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 订阅的资源名称： - device：设备。 - device.property：设备属性。 - device.message：设备消息。 - device.message.status：设备消息状态。 - device.status：设备状态。 - batchtask：批量任务。 - product：产品。 - device.command.status：设备异步命令状态。 
        /// </summary>
        [SDKProperty("resource", IsQuery = true)]
        [JsonProperty("resource", NullValueHandling = NullValueHandling.Ignore)]
        public string Resource { get; set; }

        /// <summary>
        /// 订阅的资源事件，取值范围：与资源有关，不同的资源，事件不同 event需要与resource关联使用，具体的“resource：event”映射关系如下： - device：create（设备添加） - device：delete（设备删除） - device：update（设备更新） - device.status：update （设备状态变更） - device.property：report（设备属性上报） - device.message：report（设备消息上报） - device.message.status：update（设备消息状态变更） - batchtask：update （批量任务状态变更） - product：create（产品添加） - product：delete（产品删除） - product：update（产品更新） - device.command.status：update（设备异步命令状态更新）。 
        /// </summary>
        [SDKProperty("event", IsQuery = true)]
        [JsonProperty("event", NullValueHandling = NullValueHandling.Ignore)]
        public string Event { get; set; }

        /// <summary>
        /// 租户规则的生效范围，取值如下： - GLOBAL：生效范围为租户级 - APP：生效范围为资源空间级。如果类型为APP，可携带app_id查询指定资源空间下的规则动作列表，不携带app_id则查询[默认资源空间](https://support.huaweicloud.com/usermanual-iothub/iot_01_0006.html#section0)下的规则列表。 
        /// </summary>
        [SDKProperty("app_type", IsQuery = true)]
        [JsonProperty("app_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AppType { get; set; }

        /// <summary>
        /// 资源空间ID。此参数为非必选参数，携带app_id查询指定资源空间下的规则动作列表，不携带app_id则查询[默认资源空间](https://support.huaweicloud.com/usermanual-iothub/iot_01_0006.html#section0)下的规则动作列表。
        /// </summary>
        [SDKProperty("app_id", IsQuery = true)]
        [JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }

        /// <summary>
        /// 用户自定义的规则名称
        /// </summary>
        [SDKProperty("rule_name", IsQuery = true)]
        [JsonProperty("rule_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleName { get; set; }

        /// <summary>
        /// 分页查询时每页显示的记录数。默认每页10条记录，最大设定每页50条记录，取值范围为1-50的整数。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 上一次分页查询结果中最后一条记录的ID，在上一次分页查询时由物联网平台返回获得。分页查询时物联网平台是按marker也就是记录ID降序查询的，越新的数据记录ID也会越大。若填写marker，则本次只查询记录ID小于marker的数据记录。若不填写，则从记录ID最大也就是最新的一条数据开始查询。如果需要依次查询所有数据，则每次查询时必须填写上一次查询响应中的marker值。 
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 表示从marker后偏移offset条记录开始查询。默认为0，取值范围为0-500的整数。当offset为0时，表示从marker后第一条记录开始输出。 - 限制offset最大值是出于API性能考虑，您可以搭配marker使用该参数实现翻页，例如每页50条记录，1-11页内都可以直接使用offset跳转到指定页，但到11页后，由于offset限制为500，您需要使用第11页返回的marker作为下次查询的marker，以实现翻页到12-22页。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRoutingRulesRequest {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  resource: ").Append(Resource).Append("\n");
            sb.Append("  Event: ").Append(Event).Append("\n");
            sb.Append("  appType: ").Append(AppType).Append("\n");
            sb.Append("  appId: ").Append(AppId).Append("\n");
            sb.Append("  ruleName: ").Append(RuleName).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListRoutingRulesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListRoutingRulesRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.Resource == input.Resource ||
                    (this.Resource != null &&
                    this.Resource.Equals(input.Resource))
                ) && 
                (
                    this.Event == input.Event ||
                    (this.Event != null &&
                    this.Event.Equals(input.Event))
                ) && 
                (
                    this.AppType == input.AppType ||
                    (this.AppType != null &&
                    this.AppType.Equals(input.AppType))
                ) && 
                (
                    this.AppId == input.AppId ||
                    (this.AppId != null &&
                    this.AppId.Equals(input.AppId))
                ) && 
                (
                    this.RuleName == input.RuleName ||
                    (this.RuleName != null &&
                    this.RuleName.Equals(input.RuleName))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Marker == input.Marker ||
                    (this.Marker != null &&
                    this.Marker.Equals(input.Marker))
                ) && 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
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
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.Resource != null)
                    hashCode = hashCode * 59 + this.Resource.GetHashCode();
                if (this.Event != null)
                    hashCode = hashCode * 59 + this.Event.GetHashCode();
                if (this.AppType != null)
                    hashCode = hashCode * 59 + this.AppType.GetHashCode();
                if (this.AppId != null)
                    hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.RuleName != null)
                    hashCode = hashCode * 59 + this.RuleName.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Marker != null)
                    hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                return hashCode;
            }
        }
    }
}
