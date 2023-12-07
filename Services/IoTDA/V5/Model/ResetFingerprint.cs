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
    /// 
    /// </summary>
    public class ResetFingerprint 
    {

        /// <summary>
        /// **参数说明**：设备指纹。设置该字段时平台将设备指纹重置为指定值；不携带时将之置空，后续设备第一次接入时，该设备指纹的值将设置为第一次接入时的证书指纹。 **取值范围**：长度为40的十六进制字符串或者长度为64的十六进制字符串。
        /// </summary>
        [JsonProperty("fingerprint", NullValueHandling = NullValueHandling.Ignore)]
        public string Fingerprint { get; set; }

        /// <summary>
        /// **参数说明**：是否强制断开设备的连接，当前仅限长连接。默认值false。
        /// </summary>
        [JsonProperty("force_disconnect", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ForceDisconnect { get; set; }

        /// <summary>
        /// **参数说明**：重置设备证书指纹的的类型。 **取值范围**： - PRIMARY：重置主指纹。设备证书鉴权优先使用的指纹，当设备接入物联网平台时，平台将优先使用主指纹进行校验。 - SECONDARY：重置辅指纹。设备的备用指纹，当主指纹校验不通过时，会启用辅指纹校验，辅指纹与主指纹有相同的效力。
        /// </summary>
        [JsonProperty("fingerprint_type", NullValueHandling = NullValueHandling.Ignore)]
        public string FingerprintType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResetFingerprint {\n");
            sb.Append("  fingerprint: ").Append(Fingerprint).Append("\n");
            sb.Append("  forceDisconnect: ").Append(ForceDisconnect).Append("\n");
            sb.Append("  fingerprintType: ").Append(FingerprintType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResetFingerprint);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResetFingerprint input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Fingerprint == input.Fingerprint ||
                    (this.Fingerprint != null &&
                    this.Fingerprint.Equals(input.Fingerprint))
                ) && 
                (
                    this.ForceDisconnect == input.ForceDisconnect ||
                    (this.ForceDisconnect != null &&
                    this.ForceDisconnect.Equals(input.ForceDisconnect))
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
                if (this.Fingerprint != null)
                    hashCode = hashCode * 59 + this.Fingerprint.GetHashCode();
                if (this.ForceDisconnect != null)
                    hashCode = hashCode * 59 + this.ForceDisconnect.GetHashCode();
                if (this.FingerprintType != null)
                    hashCode = hashCode * 59 + this.FingerprintType.GetHashCode();
                return hashCode;
            }
        }
    }
}
