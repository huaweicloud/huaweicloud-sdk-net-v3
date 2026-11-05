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
    public class SupabaseEmailTemplateReq 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("mailer_confirmation", NullValueHandling = NullValueHandling.Ignore)]
        public SupabaseMailerItemTemplateReq MailerConfirmation { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SupabaseEmailTemplateReq {\n");
            sb.Append("  mailerConfirmation: ").Append(MailerConfirmation).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SupabaseEmailTemplateReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SupabaseEmailTemplateReq input)
        {
            if (input == null) return false;
            if (this.MailerConfirmation != input.MailerConfirmation || (this.MailerConfirmation != null && !this.MailerConfirmation.Equals(input.MailerConfirmation))) return false;

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
                if (this.MailerConfirmation != null) hashCode = hashCode * 59 + this.MailerConfirmation.GetHashCode();
                return hashCode;
            }
        }
    }
}
