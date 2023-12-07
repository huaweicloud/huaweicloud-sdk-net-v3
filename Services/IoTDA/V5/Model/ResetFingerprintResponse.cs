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
    public class ResetFingerprintResponse : SdkResponse
    {

        /// <summary>
        /// 设备ID，用于唯一标识一个设备。在注册设备时直接指定，或者由物联网平台分配获得。由物联网平台分配时，生成规则为\&quot;product_id\&quot; + \&quot;_\&quot; + \&quot;node_id\&quot;拼接而成。
        /// </summary>
        [JsonProperty("device_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceId { get; set; }

        /// <summary>
        /// 设备指纹。
        /// </summary>
        [JsonProperty("fingerprint", NullValueHandling = NullValueHandling.Ignore)]
        public string Fingerprint { get; set; }

        /// <summary>
        /// **参数说明**：重置设备证书指纹的的类型。 **取值范围**： - PRIMARY：重置主指纹。 - SECONDARY：重置辅指纹。
        /// </summary>
        [JsonProperty("fingerprint_type", NullValueHandling = NullValueHandling.Ignore)]
        public string FingerprintType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResetFingerprintResponse {\n");
            sb.Append("  deviceId: ").Append(DeviceId).Append("\n");
            sb.Append("  fingerprint: ").Append(Fingerprint).Append("\n");
            sb.Append("  fingerprintType: ").Append(FingerprintType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResetFingerprintResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResetFingerprintResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DeviceId == input.DeviceId ||
                    (this.DeviceId != null &&
                    this.DeviceId.Equals(input.DeviceId))
                ) && 
                (
                    this.Fingerprint == input.Fingerprint ||
                    (this.Fingerprint != null &&
                    this.Fingerprint.Equals(input.Fingerprint))
                ) && 
                (
                    this.FingerprintType == input.FingerprintType ||
                    (this.FingerprintType != null &&
                    this.FingerprintType.Equals(input.FingerprintType))
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
                if (this.DeviceId != null)
                    hashCode = hashCode * 59 + this.DeviceId.GetHashCode();
                if (this.Fingerprint != null)
                    hashCode = hashCode * 59 + this.Fingerprint.GetHashCode();
                if (this.FingerprintType != null)
                    hashCode = hashCode * 59 + this.FingerprintType.GetHashCode();
                return hashCode;
            }
        }
    }
}
