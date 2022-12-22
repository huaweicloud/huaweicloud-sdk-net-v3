using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Smn.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ApplicationItem 
    {

        /// <summary>
        /// 创建application的名字。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 应用平台。
        /// </summary>
        [JsonProperty("platform", NullValueHandling = NullValueHandling.Ignore)]
        public string Platform { get; set; }

        /// <summary>
        /// 创建application的时间。时间格式为UTC时间，YYYY-MM-DDTHH:MM:SSZ。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// Application的唯一资源标识。
        /// </summary>
        [JsonProperty("application_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplicationUrn { get; set; }

        /// <summary>
        /// Application的唯一标识ID。
        /// </summary>
        [JsonProperty("application_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// 应用平台是否启用。
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public string Enabled { get; set; }

        /// <summary>
        /// 苹果证书过期时间APNS、APNS_SANDBOX平台特有属性时间格式为UTC时间，YYYY-MM-DDTHH:MM:SSZ。
        /// </summary>
        [JsonProperty("apple_certificate_expiration_date", NullValueHandling = NullValueHandling.Ignore)]
        public string AppleCertificateExpirationDate { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationItem {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  platform: ").Append(Platform).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  applicationUrn: ").Append(ApplicationUrn).Append("\n");
            sb.Append("  applicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  enabled: ").Append(Enabled).Append("\n");
            sb.Append("  appleCertificateExpirationDate: ").Append(AppleCertificateExpirationDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ApplicationItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ApplicationItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Platform == input.Platform ||
                    (this.Platform != null &&
                    this.Platform.Equals(input.Platform))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.ApplicationUrn == input.ApplicationUrn ||
                    (this.ApplicationUrn != null &&
                    this.ApplicationUrn.Equals(input.ApplicationUrn))
                ) && 
                (
                    this.ApplicationId == input.ApplicationId ||
                    (this.ApplicationId != null &&
                    this.ApplicationId.Equals(input.ApplicationId))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.AppleCertificateExpirationDate == input.AppleCertificateExpirationDate ||
                    (this.AppleCertificateExpirationDate != null &&
                    this.AppleCertificateExpirationDate.Equals(input.AppleCertificateExpirationDate))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Platform != null)
                    hashCode = hashCode * 59 + this.Platform.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.ApplicationUrn != null)
                    hashCode = hashCode * 59 + this.ApplicationUrn.GetHashCode();
                if (this.ApplicationId != null)
                    hashCode = hashCode * 59 + this.ApplicationId.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.AppleCertificateExpirationDate != null)
                    hashCode = hashCode * 59 + this.AppleCertificateExpirationDate.GetHashCode();
                return hashCode;
            }
        }
    }
}
