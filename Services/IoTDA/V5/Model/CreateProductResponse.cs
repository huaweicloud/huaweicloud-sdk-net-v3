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
    public class CreateProductResponse : SdkResponse
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
        /// 产品ID，用于唯一标识一个产品，在物联网平台创建产品后由平台分配获得。
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// 产品名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 设备类型。
        /// </summary>
        [JsonProperty("device_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceType { get; set; }

        /// <summary>
        /// 设备使用的协议类型。取值范围：MQTT，CoAP，HTTP，HTTPS，Modbus，ONVIF， OPC-UA，OPC-DA。
        /// </summary>
        [JsonProperty("protocol_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ProtocolType { get; set; }

        /// <summary>
        /// 设备上报数据的格式，取值范围：json，binary。
        /// </summary>
        [JsonProperty("data_format", NullValueHandling = NullValueHandling.Ignore)]
        public string DataFormat { get; set; }

        /// <summary>
        /// 厂商名称。
        /// </summary>
        [JsonProperty("manufacturer_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ManufacturerName { get; set; }

        /// <summary>
        /// 设备所属行业。
        /// </summary>
        [JsonProperty("industry", NullValueHandling = NullValueHandling.Ignore)]
        public string Industry { get; set; }

        /// <summary>
        /// 产品的描述信息。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 设备的服务能力列表。
        /// </summary>
        [JsonProperty("service_capabilities", NullValueHandling = NullValueHandling.Ignore)]
        public List<ServiceCapability> ServiceCapabilities { get; set; }

        /// <summary>
        /// 在物联网平台创建产品的时间，格式：yyyyMMdd&#39;T&#39;HHmmss&#39;Z&#39;，如20151212T121212Z。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateProductResponse {\n");
            sb.Append("  appId: ").Append(AppId).Append("\n");
            sb.Append("  appName: ").Append(AppName).Append("\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  deviceType: ").Append(DeviceType).Append("\n");
            sb.Append("  protocolType: ").Append(ProtocolType).Append("\n");
            sb.Append("  dataFormat: ").Append(DataFormat).Append("\n");
            sb.Append("  manufacturerName: ").Append(ManufacturerName).Append("\n");
            sb.Append("  industry: ").Append(Industry).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  serviceCapabilities: ").Append(ServiceCapabilities).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateProductResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateProductResponse input)
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
                    this.AppName == input.AppName ||
                    (this.AppName != null &&
                    this.AppName.Equals(input.AppName))
                ) && 
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
                    this.ServiceCapabilities == input.ServiceCapabilities ||
                    this.ServiceCapabilities != null &&
                    input.ServiceCapabilities != null &&
                    this.ServiceCapabilities.SequenceEqual(input.ServiceCapabilities)
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
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
                if (this.AppName != null)
                    hashCode = hashCode * 59 + this.AppName.GetHashCode();
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
                if (this.ManufacturerName != null)
                    hashCode = hashCode * 59 + this.ManufacturerName.GetHashCode();
                if (this.Industry != null)
                    hashCode = hashCode * 59 + this.Industry.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ServiceCapabilities != null)
                    hashCode = hashCode * 59 + this.ServiceCapabilities.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
