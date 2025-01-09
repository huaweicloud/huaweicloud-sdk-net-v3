using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 外设。
    /// </summary>
    public class PoliciesPeripherals 
    {

        /// <summary>
        /// 设备调试策略。
        /// </summary>
        [JsonProperty("usb_custom_policy_debug", NullValueHandling = NullValueHandling.Ignore)]
        public string UsbCustomPolicyDebug { get; set; }

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
        /// 
        /// </summary>
        [JsonProperty("parallel_port_redirection", NullValueHandling = NullValueHandling.Ignore)]
        public PoliciesPeripheralsParallelPortRedirection ParallelPortRedirection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("driver_interface_redirection", NullValueHandling = NullValueHandling.Ignore)]
        public PoliciesPeripheralsDriverInterfaceRedirection DriverInterfaceRedirection { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesPeripherals {\n");
            sb.Append("  usbCustomPolicyDebug: ").Append(UsbCustomPolicyDebug).Append("\n");
            sb.Append("  usbPortRedirection: ").Append(UsbPortRedirection).Append("\n");
            sb.Append("  deviceRedirection: ").Append(DeviceRedirection).Append("\n");
            sb.Append("  usbDeviceCommon: ").Append(UsbDeviceCommon).Append("\n");
            sb.Append("  serialPortRedirection: ").Append(SerialPortRedirection).Append("\n");
            sb.Append("  parallelPortRedirection: ").Append(ParallelPortRedirection).Append("\n");
            sb.Append("  driverInterfaceRedirection: ").Append(DriverInterfaceRedirection).Append("\n");
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
            if (this.UsbCustomPolicyDebug != input.UsbCustomPolicyDebug || (this.UsbCustomPolicyDebug != null && !this.UsbCustomPolicyDebug.Equals(input.UsbCustomPolicyDebug))) return false;
            if (this.UsbPortRedirection != input.UsbPortRedirection || (this.UsbPortRedirection != null && !this.UsbPortRedirection.Equals(input.UsbPortRedirection))) return false;
            if (this.DeviceRedirection != input.DeviceRedirection || (this.DeviceRedirection != null && !this.DeviceRedirection.Equals(input.DeviceRedirection))) return false;
            if (this.UsbDeviceCommon != input.UsbDeviceCommon || (this.UsbDeviceCommon != null && !this.UsbDeviceCommon.Equals(input.UsbDeviceCommon))) return false;
            if (this.SerialPortRedirection != input.SerialPortRedirection || (this.SerialPortRedirection != null && !this.SerialPortRedirection.Equals(input.SerialPortRedirection))) return false;
            if (this.ParallelPortRedirection != input.ParallelPortRedirection || (this.ParallelPortRedirection != null && !this.ParallelPortRedirection.Equals(input.ParallelPortRedirection))) return false;
            if (this.DriverInterfaceRedirection != input.DriverInterfaceRedirection || (this.DriverInterfaceRedirection != null && !this.DriverInterfaceRedirection.Equals(input.DriverInterfaceRedirection))) return false;

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
                if (this.UsbCustomPolicyDebug != null) hashCode = hashCode * 59 + this.UsbCustomPolicyDebug.GetHashCode();
                if (this.UsbPortRedirection != null) hashCode = hashCode * 59 + this.UsbPortRedirection.GetHashCode();
                if (this.DeviceRedirection != null) hashCode = hashCode * 59 + this.DeviceRedirection.GetHashCode();
                if (this.UsbDeviceCommon != null) hashCode = hashCode * 59 + this.UsbDeviceCommon.GetHashCode();
                if (this.SerialPortRedirection != null) hashCode = hashCode * 59 + this.SerialPortRedirection.GetHashCode();
                if (this.ParallelPortRedirection != null) hashCode = hashCode * 59 + this.ParallelPortRedirection.GetHashCode();
                if (this.DriverInterfaceRedirection != null) hashCode = hashCode * 59 + this.DriverInterfaceRedirection.GetHashCode();
                return hashCode;
            }
        }
    }
}
