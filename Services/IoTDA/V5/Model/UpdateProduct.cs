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
    /// 修改产品信息结构体。
    /// </summary>
    public class UpdateProduct 
    {

        /// <summary>
        /// 资源空间ID。此参数为非必选参数，存在多资源空间的用户需要使用该接口时，必须携带该参数指定修改的产品属于哪个资源空间，否则接口会提示错误。如果用户存在多资源空间，同时又不想携带该参数，可以联系华为技术支持对用户数据做资源空间合并。
        /// </summary>
        [JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }

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
        /// 设备使用的协议类型。取值范围：MQTT，CoAP，HTTP，HTTPS，Modbus，ONVIF。
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
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateProduct {\n");
            sb.Append("  appId: ").Append(AppId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  deviceType: ").Append(DeviceType).Append("\n");
            sb.Append("  protocolType: ").Append(ProtocolType).Append("\n");
            sb.Append("  dataFormat: ").Append(DataFormat).Append("\n");
            sb.Append("  manufacturerName: ").Append(ManufacturerName).Append("\n");
            sb.Append("  industry: ").Append(Industry).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  serviceCapabilities: ").Append(ServiceCapabilities).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateProduct);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateProduct input)
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
                return hashCode;
            }
        }
    }
}
