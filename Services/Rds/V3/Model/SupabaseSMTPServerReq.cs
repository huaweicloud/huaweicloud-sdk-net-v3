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
    /// 
    /// </summary>
    public class SupabaseSMTPServerReq 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("smtp_host", NullValueHandling = NullValueHandling.Ignore)]
        public string SmtpHost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("smtp_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? SmtpPort { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("smtp_user", NullValueHandling = NullValueHandling.Ignore)]
        public string SmtpUser { get; set; }

        /// <summary>
        /// 秘密，受控输入，show不返回。
        /// </summary>
        [JsonProperty("smtp_pwd", NullValueHandling = NullValueHandling.Ignore)]
        public string SmtpPwd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("smtp_admin_email", NullValueHandling = NullValueHandling.Ignore)]
        public string SmtpAdminEmail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("smtp_sender_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SmtpSenderName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("smtp_max_frequency", NullValueHandling = NullValueHandling.Ignore)]
        public int? SmtpMaxFrequency { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SupabaseSMTPServerReq {\n");
            sb.Append("  smtpHost: ").Append(SmtpHost).Append("\n");
            sb.Append("  smtpPort: ").Append(SmtpPort).Append("\n");
            sb.Append("  smtpUser: ").Append(SmtpUser).Append("\n");
            sb.Append("  smtpPwd: ").Append(SmtpPwd).Append("\n");
            sb.Append("  smtpAdminEmail: ").Append(SmtpAdminEmail).Append("\n");
            sb.Append("  smtpSenderName: ").Append(SmtpSenderName).Append("\n");
            sb.Append("  smtpMaxFrequency: ").Append(SmtpMaxFrequency).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SupabaseSMTPServerReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SupabaseSMTPServerReq input)
        {
            if (input == null) return false;
            if (this.SmtpHost != input.SmtpHost || (this.SmtpHost != null && !this.SmtpHost.Equals(input.SmtpHost))) return false;
            if (this.SmtpPort != input.SmtpPort || (this.SmtpPort != null && !this.SmtpPort.Equals(input.SmtpPort))) return false;
            if (this.SmtpUser != input.SmtpUser || (this.SmtpUser != null && !this.SmtpUser.Equals(input.SmtpUser))) return false;
            if (this.SmtpPwd != input.SmtpPwd || (this.SmtpPwd != null && !this.SmtpPwd.Equals(input.SmtpPwd))) return false;
            if (this.SmtpAdminEmail != input.SmtpAdminEmail || (this.SmtpAdminEmail != null && !this.SmtpAdminEmail.Equals(input.SmtpAdminEmail))) return false;
            if (this.SmtpSenderName != input.SmtpSenderName || (this.SmtpSenderName != null && !this.SmtpSenderName.Equals(input.SmtpSenderName))) return false;
            if (this.SmtpMaxFrequency != input.SmtpMaxFrequency || (this.SmtpMaxFrequency != null && !this.SmtpMaxFrequency.Equals(input.SmtpMaxFrequency))) return false;

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
                if (this.SmtpHost != null) hashCode = hashCode * 59 + this.SmtpHost.GetHashCode();
                if (this.SmtpPort != null) hashCode = hashCode * 59 + this.SmtpPort.GetHashCode();
                if (this.SmtpUser != null) hashCode = hashCode * 59 + this.SmtpUser.GetHashCode();
                if (this.SmtpPwd != null) hashCode = hashCode * 59 + this.SmtpPwd.GetHashCode();
                if (this.SmtpAdminEmail != null) hashCode = hashCode * 59 + this.SmtpAdminEmail.GetHashCode();
                if (this.SmtpSenderName != null) hashCode = hashCode * 59 + this.SmtpSenderName.GetHashCode();
                if (this.SmtpMaxFrequency != null) hashCode = hashCode * 59 + this.SmtpMaxFrequency.GetHashCode();
                return hashCode;
            }
        }
    }
}
