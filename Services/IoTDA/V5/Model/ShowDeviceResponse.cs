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
    public class ShowDeviceResponse : SdkResponse
    {

        /// <summary>
        /// 资源空间ID。
        /// </summary>
        [JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }

        /// <summary>
        /// 资源空间名称。
        /// </summary>
        [JsonProperty("app_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AppName { get; set; }

        /// <summary>
        /// 设备ID，用于唯一标识一个设备。在注册设备时直接指定，或者由物联网平台分配获得。由物联网平台分配时，生成规则为\&quot;product_id\&quot; + \&quot;_\&quot; + \&quot;node_id\&quot;拼接而成。
        /// </summary>
        [JsonProperty("device_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceId { get; set; }

        /// <summary>
        /// 设备标识码，通常使用IMEI、MAC地址或Serial No作为node_id。
        /// </summary>
        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; }

        /// <summary>
        /// 网关ID，用于标识设备所属的父设备，即父设备的设备ID。当设备是直连设备时，gateway_id与设备的device_id一致。当设备是非直连设备时，gateway_id为设备所关联的父设备的device_id。
        /// </summary>
        [JsonProperty("gateway_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GatewayId { get; set; }

        /// <summary>
        /// 设备名称。
        /// </summary>
        [JsonProperty("device_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceName { get; set; }

        /// <summary>
        /// 设备节点类型。 - ENDPOINT：非直连设备。 - GATEWAY：直连设备或网关。 - UNKNOWN：未知。
        /// </summary>
        [JsonProperty("node_type", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeType { get; set; }

        /// <summary>
        /// 设备的描述信息。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 设备的固件版本。
        /// </summary>
        [JsonProperty("fw_version", NullValueHandling = NullValueHandling.Ignore)]
        public string FwVersion { get; set; }

        /// <summary>
        /// 设备的软件版本。
        /// </summary>
        [JsonProperty("sw_version", NullValueHandling = NullValueHandling.Ignore)]
        public string SwVersion { get; set; }

        /// <summary>
        /// 设备的sdk信息。
        /// </summary>
        [JsonProperty("device_sdk_version", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceSdkVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("auth_info", NullValueHandling = NullValueHandling.Ignore)]
        public AuthInfoRes AuthInfo { get; set; }

        /// <summary>
        /// 设备关联的产品ID，用于唯一标识一个产品模型。
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// 设备关联的产品名称。
        /// </summary>
        [JsonProperty("product_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductName { get; set; }

        /// <summary>
        /// 设备的状态。 - ONLINE：设备在线。 - OFFLINE：设备离线。 - ABNORMAL：设备异常。 - INACTIVE：设备未激活。 - FROZEN：设备冻结。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 在物联网平台注册设备的时间。格式：yyyyMMdd&#39;T&#39;HHmmss&#39;Z&#39;，如20151212T121212Z。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 设备最近一次连接状态(ONLINE:在线，OFFLINE：离线，ABNORMAL：异常)变化时间。格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; ，如2015-12-12T12:12:122Z。
        /// </summary>
        [JsonProperty("connection_status_update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ConnectionStatusUpdateTime { get; set; }

        /// <summary>
        /// 设备激活时间。格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39; ，如2015-12-12T12:12:122Z。
        /// </summary>
        [JsonProperty("active_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ActiveTime { get; set; }

        /// <summary>
        /// 设备的标签列表。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<TagV5DTO> Tags { get; set; }

        /// <summary>
        /// 设备扩展信息。用户可以自定义任何想要的扩展信息，如果在创建设备时为子设备指定该字段，将会通过MQTT接口“平台通知网关子设备新增“将该信息通知给网关。
        /// </summary>
        [JsonProperty("extension_info", NullValueHandling = NullValueHandling.Ignore)]
        public Object ExtensionInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDeviceResponse {\n");
            sb.Append("  appId: ").Append(AppId).Append("\n");
            sb.Append("  appName: ").Append(AppName).Append("\n");
            sb.Append("  deviceId: ").Append(DeviceId).Append("\n");
            sb.Append("  nodeId: ").Append(NodeId).Append("\n");
            sb.Append("  gatewayId: ").Append(GatewayId).Append("\n");
            sb.Append("  deviceName: ").Append(DeviceName).Append("\n");
            sb.Append("  nodeType: ").Append(NodeType).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  fwVersion: ").Append(FwVersion).Append("\n");
            sb.Append("  swVersion: ").Append(SwVersion).Append("\n");
            sb.Append("  deviceSdkVersion: ").Append(DeviceSdkVersion).Append("\n");
            sb.Append("  authInfo: ").Append(AuthInfo).Append("\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  productName: ").Append(ProductName).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  connectionStatusUpdateTime: ").Append(ConnectionStatusUpdateTime).Append("\n");
            sb.Append("  activeTime: ").Append(ActiveTime).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  extensionInfo: ").Append(ExtensionInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDeviceResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDeviceResponse input)
        {
            if (input == null) return false;
            if (this.AppId != input.AppId || (this.AppId != null && !this.AppId.Equals(input.AppId))) return false;
            if (this.AppName != input.AppName || (this.AppName != null && !this.AppName.Equals(input.AppName))) return false;
            if (this.DeviceId != input.DeviceId || (this.DeviceId != null && !this.DeviceId.Equals(input.DeviceId))) return false;
            if (this.NodeId != input.NodeId || (this.NodeId != null && !this.NodeId.Equals(input.NodeId))) return false;
            if (this.GatewayId != input.GatewayId || (this.GatewayId != null && !this.GatewayId.Equals(input.GatewayId))) return false;
            if (this.DeviceName != input.DeviceName || (this.DeviceName != null && !this.DeviceName.Equals(input.DeviceName))) return false;
            if (this.NodeType != input.NodeType || (this.NodeType != null && !this.NodeType.Equals(input.NodeType))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.FwVersion != input.FwVersion || (this.FwVersion != null && !this.FwVersion.Equals(input.FwVersion))) return false;
            if (this.SwVersion != input.SwVersion || (this.SwVersion != null && !this.SwVersion.Equals(input.SwVersion))) return false;
            if (this.DeviceSdkVersion != input.DeviceSdkVersion || (this.DeviceSdkVersion != null && !this.DeviceSdkVersion.Equals(input.DeviceSdkVersion))) return false;
            if (this.AuthInfo != input.AuthInfo || (this.AuthInfo != null && !this.AuthInfo.Equals(input.AuthInfo))) return false;
            if (this.ProductId != input.ProductId || (this.ProductId != null && !this.ProductId.Equals(input.ProductId))) return false;
            if (this.ProductName != input.ProductName || (this.ProductName != null && !this.ProductName.Equals(input.ProductName))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.ConnectionStatusUpdateTime != input.ConnectionStatusUpdateTime || (this.ConnectionStatusUpdateTime != null && !this.ConnectionStatusUpdateTime.Equals(input.ConnectionStatusUpdateTime))) return false;
            if (this.ActiveTime != input.ActiveTime || (this.ActiveTime != null && !this.ActiveTime.Equals(input.ActiveTime))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.ExtensionInfo != input.ExtensionInfo || (this.ExtensionInfo != null && !this.ExtensionInfo.Equals(input.ExtensionInfo))) return false;

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
                if (this.AppId != null) hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.AppName != null) hashCode = hashCode * 59 + this.AppName.GetHashCode();
                if (this.DeviceId != null) hashCode = hashCode * 59 + this.DeviceId.GetHashCode();
                if (this.NodeId != null) hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                if (this.GatewayId != null) hashCode = hashCode * 59 + this.GatewayId.GetHashCode();
                if (this.DeviceName != null) hashCode = hashCode * 59 + this.DeviceName.GetHashCode();
                if (this.NodeType != null) hashCode = hashCode * 59 + this.NodeType.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.FwVersion != null) hashCode = hashCode * 59 + this.FwVersion.GetHashCode();
                if (this.SwVersion != null) hashCode = hashCode * 59 + this.SwVersion.GetHashCode();
                if (this.DeviceSdkVersion != null) hashCode = hashCode * 59 + this.DeviceSdkVersion.GetHashCode();
                if (this.AuthInfo != null) hashCode = hashCode * 59 + this.AuthInfo.GetHashCode();
                if (this.ProductId != null) hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.ProductName != null) hashCode = hashCode * 59 + this.ProductName.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.ConnectionStatusUpdateTime != null) hashCode = hashCode * 59 + this.ConnectionStatusUpdateTime.GetHashCode();
                if (this.ActiveTime != null) hashCode = hashCode * 59 + this.ActiveTime.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.ExtensionInfo != null) hashCode = hashCode * 59 + this.ExtensionInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
