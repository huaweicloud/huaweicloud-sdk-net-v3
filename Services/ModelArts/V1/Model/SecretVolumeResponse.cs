using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// **参数解释：** 密钥挂载。
    /// </summary>
    public class SecretVolumeResponse 
    {

        /// <summary>
        /// **参数解释：** 密钥名称。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("secret_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SecretName { get; set; }

        /// <summary>
        /// **参数解释：** 密钥key。 **取值范围：** 长度不大于63。
        /// </summary>
        [JsonProperty("secret_key", NullValueHandling = NullValueHandling.Ignore)]
        public string SecretKey { get; set; }

        /// <summary>
        /// **参数解释：** 密钥值。 **取值范围：** 长度不大于32768。
        /// </summary>
        [JsonProperty("secret_value", NullValueHandling = NullValueHandling.Ignore)]
        public string SecretValue { get; set; }

        /// <summary>
        /// **参数解释：** 挂载路径。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("mount_path", NullValueHandling = NullValueHandling.Ignore)]
        public string MountPath { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecretVolumeResponse {\n");
            sb.Append("  secretName: ").Append(SecretName).Append("\n");
            sb.Append("  secretKey: ").Append(SecretKey).Append("\n");
            sb.Append("  secretValue: ").Append(SecretValue).Append("\n");
            sb.Append("  mountPath: ").Append(MountPath).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SecretVolumeResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SecretVolumeResponse input)
        {
            if (input == null) return false;
            if (this.SecretName != input.SecretName || (this.SecretName != null && !this.SecretName.Equals(input.SecretName))) return false;
            if (this.SecretKey != input.SecretKey || (this.SecretKey != null && !this.SecretKey.Equals(input.SecretKey))) return false;
            if (this.SecretValue != input.SecretValue || (this.SecretValue != null && !this.SecretValue.Equals(input.SecretValue))) return false;
            if (this.MountPath != input.MountPath || (this.MountPath != null && !this.MountPath.Equals(input.MountPath))) return false;

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
                if (this.SecretName != null) hashCode = hashCode * 59 + this.SecretName.GetHashCode();
                if (this.SecretKey != null) hashCode = hashCode * 59 + this.SecretKey.GetHashCode();
                if (this.SecretValue != null) hashCode = hashCode * 59 + this.SecretValue.GetHashCode();
                if (this.MountPath != null) hashCode = hashCode * 59 + this.MountPath.GetHashCode();
                return hashCode;
            }
        }
    }
}
