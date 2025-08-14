using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenterStore.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class MfaDeviceDto 
    {

        /// <summary>
        /// MFA设备唯一标识符（ID）
        /// </summary>
        [JsonProperty("device_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceId { get; set; }

        /// <summary>
        /// MFA设备名称
        /// </summary>
        [JsonProperty("device_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceName { get; set; }

        /// <summary>
        /// MFA设备显示名称
        /// </summary>
        [JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// MFA类型
        /// </summary>
        [JsonProperty("mfa_type", NullValueHandling = NullValueHandling.Ignore)]
        public string MfaType { get; set; }

        /// <summary>
        /// 注册时间
        /// </summary>
        [JsonProperty("registered_date", NullValueHandling = NullValueHandling.Ignore)]
        public long? RegisteredDate { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MfaDeviceDto {\n");
            sb.Append("  deviceId: ").Append(DeviceId).Append("\n");
            sb.Append("  deviceName: ").Append(DeviceName).Append("\n");
            sb.Append("  displayName: ").Append(DisplayName).Append("\n");
            sb.Append("  mfaType: ").Append(MfaType).Append("\n");
            sb.Append("  registeredDate: ").Append(RegisteredDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MfaDeviceDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MfaDeviceDto input)
        {
            if (input == null) return false;
            if (this.DeviceId != input.DeviceId || (this.DeviceId != null && !this.DeviceId.Equals(input.DeviceId))) return false;
            if (this.DeviceName != input.DeviceName || (this.DeviceName != null && !this.DeviceName.Equals(input.DeviceName))) return false;
            if (this.DisplayName != input.DisplayName || (this.DisplayName != null && !this.DisplayName.Equals(input.DisplayName))) return false;
            if (this.MfaType != input.MfaType || (this.MfaType != null && !this.MfaType.Equals(input.MfaType))) return false;
            if (this.RegisteredDate != input.RegisteredDate || (this.RegisteredDate != null && !this.RegisteredDate.Equals(input.RegisteredDate))) return false;

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
                if (this.DeviceId != null) hashCode = hashCode * 59 + this.DeviceId.GetHashCode();
                if (this.DeviceName != null) hashCode = hashCode * 59 + this.DeviceName.GetHashCode();
                if (this.DisplayName != null) hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.MfaType != null) hashCode = hashCode * 59 + this.MfaType.GetHashCode();
                if (this.RegisteredDate != null) hashCode = hashCode * 59 + this.RegisteredDate.GetHashCode();
                return hashCode;
            }
        }
    }
}
