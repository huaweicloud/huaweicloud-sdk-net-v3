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
    /// 修改设备信息对象。
    /// </summary>
    public class UpdateDevice 
    {

        /// <summary>
        /// 设备名称。
        /// </summary>
        [JsonProperty("device_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceName { get; set; }

        /// <summary>
        /// 设备的描述信息。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 设备扩展信息。用户可以自定义任何想要的扩展信息，修改子设备信息时不会下发给网关。
        /// </summary>
        [JsonProperty("extension_info", NullValueHandling = NullValueHandling.Ignore)]
        public Object ExtensionInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("auth_info", NullValueHandling = NullValueHandling.Ignore)]
        public AuthInfoWithoutSecret AuthInfo { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateDevice {\n");
            sb.Append("  deviceName: ").Append(DeviceName).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  extensionInfo: ").Append(ExtensionInfo).Append("\n");
            sb.Append("  authInfo: ").Append(AuthInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateDevice);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateDevice input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DeviceName == input.DeviceName ||
                    (this.DeviceName != null &&
                    this.DeviceName.Equals(input.DeviceName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ExtensionInfo == input.ExtensionInfo ||
                    (this.ExtensionInfo != null &&
                    this.ExtensionInfo.Equals(input.ExtensionInfo))
                ) && 
                (
                    this.AuthInfo == input.AuthInfo ||
                    (this.AuthInfo != null &&
                    this.AuthInfo.Equals(input.AuthInfo))
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
                if (this.DeviceName != null)
                    hashCode = hashCode * 59 + this.DeviceName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ExtensionInfo != null)
                    hashCode = hashCode * 59 + this.ExtensionInfo.GetHashCode();
                if (this.AuthInfo != null)
                    hashCode = hashCode * 59 + this.AuthInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
