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
    /// 创建产品信息结构体。
    /// </summary>
    public class AddProduct 
    {

        /// <summary>
        /// **参数说明**：产品ID，用于唯一标识一个产品。如果携带此参数，平台将产品ID设置为该参数值；如果不携带此参数，产品ID在物联网平台创建产品后由平台分配获得。 **取值范围**：长度不超过36，只允许字母、数字、下划线（_）、连接符（-）的组合。
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// **参数说明**：产品名称。 **取值范围**：长度不超过64，只允许中文、字母、数字、以及_?&#39;#().,&amp;%@!-等字符的组合。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数说明**：设备类型。 **取值范围**：长度不超过32，只允许中文、字母、数字、以及_?&#39;#().,&amp;%@!-等字符的组合。
        /// </summary>
        [JsonProperty("device_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceType { get; set; }

        /// <summary>
        /// **参数说明**：设备使用的协议类型。 **取值范围**：MQTT，CoAP，HTTP，HTTPS，Modbus，ONVIF，OPC-UA，OPC-DA，Other。
        /// </summary>
        [JsonProperty("protocol_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ProtocolType { get; set; }

        /// <summary>
        /// **参数说明**：设备上报数据的格式。 **取值范围**： - json：JSON格式 - binary：二进制码流格式 默认值json。
        /// </summary>
        [JsonProperty("data_format", NullValueHandling = NullValueHandling.Ignore)]
        public string DataFormat { get; set; }

        /// <summary>
        /// **参数说明**：设备的服务能力列表。 **取值范围**：数组长度大小不超过500，内容大小不超过500k。
        /// </summary>
        [JsonProperty("service_capabilities", NullValueHandling = NullValueHandling.Ignore)]
        public List<ServiceCapability> ServiceCapabilities { get; set; }

        /// <summary>
        /// **参数说明**：厂商名称。 **取值范围**：长度不超过32，只允许中文、字母、数字、以及_?&#39;#().,&amp;%@!-等字符的组合。
        /// </summary>
        [JsonProperty("manufacturer_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ManufacturerName { get; set; }

        /// <summary>
        /// **参数说明**：设备所属行业。 **取值范围**：长度不超过64，只允许中文、字母、数字、以及_?&#39;#().,&amp;%@!-等字符的组合。
        /// </summary>
        [JsonProperty("industry", NullValueHandling = NullValueHandling.Ignore)]
        public string Industry { get; set; }

        /// <summary>
        /// **参数说明**：产品的描述信息。 **取值范围**：长度不超过128，只允许中文、字母、数字、空白字符、以及_?&#39;#().,;&amp;%@!- ，、：；。/等字符的组合。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数说明**：资源空间ID。此参数为非必选参数，存在多资源空间的用户需要使用该接口时，建议携带该参数指定创建的产品归属到哪个资源空间下，否则创建的产品将会归属到[[默认资源空间](https://support.huaweicloud.com/usermanual-iothub/iot_01_0006.html#section0)](tag:hws)[[默认资源空间](https://support.huaweicloud.com/intl/zh-cn/usermanual-iothub/iot_01_0006.html#section0)](tag:hws_hk)下。 **取值范围**：长度不超过36，只允许字母、数字、下划线（_）、连接符（-）的组合。
        /// </summary>
        [JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddProduct {\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  deviceType: ").Append(DeviceType).Append("\n");
            sb.Append("  protocolType: ").Append(ProtocolType).Append("\n");
            sb.Append("  dataFormat: ").Append(DataFormat).Append("\n");
            sb.Append("  serviceCapabilities: ").Append(ServiceCapabilities).Append("\n");
            sb.Append("  manufacturerName: ").Append(ManufacturerName).Append("\n");
            sb.Append("  industry: ").Append(Industry).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  appId: ").Append(AppId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddProduct);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddProduct input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProductId == input.ProductId ||
                    (this.ProductId != null &&
                    this.ProductId.Equals(input.ProductId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.DeviceType == input.DeviceType ||
                    (this.DeviceType != null &&
                    this.DeviceType.Equals(input.DeviceType))
                ) && 
                (
                    this.ProtocolType == input.ProtocolType ||
                    (this.ProtocolType != null &&
                    this.ProtocolType.Equals(input.ProtocolType))
                ) && 
                (
                    this.DataFormat == input.DataFormat ||
                    (this.DataFormat != null &&
                    this.DataFormat.Equals(input.DataFormat))
                ) && 
                (
                    this.ServiceCapabilities == input.ServiceCapabilities ||
                    this.ServiceCapabilities != null &&
                    input.ServiceCapabilities != null &&
                    this.ServiceCapabilities.SequenceEqual(input.ServiceCapabilities)
                ) && 
                (
                    this.ManufacturerName == input.ManufacturerName ||
                    (this.ManufacturerName != null &&
                    this.ManufacturerName.Equals(input.ManufacturerName))
                ) && 
                (
                    this.Industry == input.Industry ||
                    (this.Industry != null &&
                    this.Industry.Equals(input.Industry))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.AppId == input.AppId ||
                    (this.AppId != null &&
                    this.AppId.Equals(input.AppId))
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
                if (this.ProductId != null)
                    hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.DeviceType != null)
                    hashCode = hashCode * 59 + this.DeviceType.GetHashCode();
                if (this.ProtocolType != null)
                    hashCode = hashCode * 59 + this.ProtocolType.GetHashCode();
                if (this.DataFormat != null)
                    hashCode = hashCode * 59 + this.DataFormat.GetHashCode();
                if (this.ServiceCapabilities != null)
                    hashCode = hashCode * 59 + this.ServiceCapabilities.GetHashCode();
                if (this.ManufacturerName != null)
                    hashCode = hashCode * 59 + this.ManufacturerName.GetHashCode();
                if (this.Industry != null)
                    hashCode = hashCode * 59 + this.Industry.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.AppId != null)
                    hashCode = hashCode * 59 + this.AppId.GetHashCode();
                return hashCode;
            }
        }
    }
}
