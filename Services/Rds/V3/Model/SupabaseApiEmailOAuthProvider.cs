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
    public class SupabaseApiEmailOAuthProvider 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("enable_email_sign_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableEmailSignUp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("enable_email_auto_confirm", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableEmailAutoConfirm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("smtp_config", NullValueHandling = NullValueHandling.Ignore)]
        public SupabaseApiSMTPServer SmtpConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SupabaseApiEmailOAuthProvider {\n");
            sb.Append("  enableEmailSignUp: ").Append(EnableEmailSignUp).Append("\n");
            sb.Append("  enableEmailAutoConfirm: ").Append(EnableEmailAutoConfirm).Append("\n");
            sb.Append("  smtpConfig: ").Append(SmtpConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SupabaseApiEmailOAuthProvider);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SupabaseApiEmailOAuthProvider input)
        {
            if (input == null) return false;
            if (this.EnableEmailSignUp != input.EnableEmailSignUp || (this.EnableEmailSignUp != null && !this.EnableEmailSignUp.Equals(input.EnableEmailSignUp))) return false;
            if (this.EnableEmailAutoConfirm != input.EnableEmailAutoConfirm || (this.EnableEmailAutoConfirm != null && !this.EnableEmailAutoConfirm.Equals(input.EnableEmailAutoConfirm))) return false;
            if (this.SmtpConfig != input.SmtpConfig || (this.SmtpConfig != null && !this.SmtpConfig.Equals(input.SmtpConfig))) return false;

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
                if (this.EnableEmailSignUp != null) hashCode = hashCode * 59 + this.EnableEmailSignUp.GetHashCode();
                if (this.EnableEmailAutoConfirm != null) hashCode = hashCode * 59 + this.EnableEmailAutoConfirm.GetHashCode();
                if (this.SmtpConfig != null) hashCode = hashCode * 59 + this.SmtpConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
