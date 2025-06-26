using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 外设。
    /// </summary>
    public class PoliciesPeripherals 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("usb_port_redirection", NullValueHandling = NullValueHandling.Ignore)]
        public PoliciesPeripheralsUsbPortRedirection UsbPortRedirection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("device_redirection", NullValueHandling = NullValueHandling.Ignore)]
        public PoliciesPeripheralsDeviceRedirection DeviceRedirection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("usb_device_common", NullValueHandling = NullValueHandling.Ignore)]
        public PoliciesPeripheralsUsbDeviceCommon UsbDeviceCommon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("serial_port_redirection", NullValueHandling = NullValueHandling.Ignore)]
        public PoliciesPeripheralsSerialPortRedirection SerialPortRedirection { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesPeripherals {\n");
            sb.Append("  usbPortRedirection: ").Append(UsbPortRedirection).Append("\n");
            sb.Append("  deviceRedirection: ").Append(DeviceRedirection).Append("\n");
            sb.Append("  usbDeviceCommon: ").Append(UsbDeviceCommon).Append("\n");
            sb.Append("  serialPortRedirection: ").Append(SerialPortRedirection).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesPeripherals);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesPeripherals input)
        {
            if (input == null) return false;
            if (this.UsbPortRedirection != input.UsbPortRedirection || (this.UsbPortRedirection != null && !this.UsbPortRedirection.Equals(input.UsbPortRedirection))) return false;
            if (this.DeviceRedirection != input.DeviceRedirection || (this.DeviceRedirection != null && !this.DeviceRedirection.Equals(input.DeviceRedirection))) return false;
            if (this.UsbDeviceCommon != input.UsbDeviceCommon || (this.UsbDeviceCommon != null && !this.UsbDeviceCommon.Equals(input.UsbDeviceCommon))) return false;
            if (this.SerialPortRedirection != input.SerialPortRedirection || (this.SerialPortRedirection != null && !this.SerialPortRedirection.Equals(input.SerialPortRedirection))) return false;

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
                if (this.UsbPortRedirection != null) hashCode = hashCode * 59 + this.UsbPortRedirection.GetHashCode();
                if (this.DeviceRedirection != null) hashCode = hashCode * 59 + this.DeviceRedirection.GetHashCode();
                if (this.UsbDeviceCommon != null) hashCode = hashCode * 59 + this.UsbDeviceCommon.GetHashCode();
                if (this.SerialPortRedirection != null) hashCode = hashCode * 59 + this.SerialPortRedirection.GetHashCode();
                return hashCode;
            }
        }
    }
}
