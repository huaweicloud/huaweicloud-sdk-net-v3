using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// sqlserverTDE开关信息
    /// </summary>
    public class UpdateTdeStatusRequestBody 
    {

        /// <summary>
        /// 轮转天数
        /// </summary>
        [JsonProperty("rotate_day", NullValueHandling = NullValueHandling.Ignore)]
        public int? RotateDay { get; set; }

        /// <summary>
        /// 密钥ID
        /// </summary>
        [JsonProperty("secret_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SecretId { get; set; }

        /// <summary>
        /// 密钥名称
        /// </summary>
        [JsonProperty("secret_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SecretName { get; set; }

        /// <summary>
        /// 密钥版本
        /// </summary>
        [JsonProperty("secret_version", NullValueHandling = NullValueHandling.Ignore)]
        public string SecretVersion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateTdeStatusRequestBody {\n");
            sb.Append("  rotateDay: ").Append(RotateDay).Append("\n");
            sb.Append("  secretId: ").Append(SecretId).Append("\n");
            sb.Append("  secretName: ").Append(SecretName).Append("\n");
            sb.Append("  secretVersion: ").Append(SecretVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateTdeStatusRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateTdeStatusRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RotateDay == input.RotateDay ||
                    (this.RotateDay != null &&
                    this.RotateDay.Equals(input.RotateDay))
                ) && 
                (
                    this.SecretId == input.SecretId ||
                    (this.SecretId != null &&
                    this.SecretId.Equals(input.SecretId))
                ) && 
                (
                    this.SecretName == input.SecretName ||
                    (this.SecretName != null &&
                    this.SecretName.Equals(input.SecretName))
                ) && 
                (
                    this.SecretVersion == input.SecretVersion ||
                    (this.SecretVersion != null &&
                    this.SecretVersion.Equals(input.SecretVersion))
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
                if (this.RotateDay != null)
                    hashCode = hashCode * 59 + this.RotateDay.GetHashCode();
                if (this.SecretId != null)
                    hashCode = hashCode * 59 + this.SecretId.GetHashCode();
                if (this.SecretName != null)
                    hashCode = hashCode * 59 + this.SecretName.GetHashCode();
                if (this.SecretVersion != null)
                    hashCode = hashCode * 59 + this.SecretVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
