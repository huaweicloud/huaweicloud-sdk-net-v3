using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class KeystoneListUsersRequest 
    {

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("enabled", IsQuery = true)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("password_expires_at", IsQuery = true)]
        public string PasswordExpiresAt { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KeystoneListUsersRequest {\n");
            sb.Append("  enabled: ").Append(Enabled).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  passwordExpiresAt: ").Append(PasswordExpiresAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as KeystoneListUsersRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(KeystoneListUsersRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PasswordExpiresAt == input.PasswordExpiresAt ||
                    (this.PasswordExpiresAt != null &&
                    this.PasswordExpiresAt.Equals(input.PasswordExpiresAt))
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
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PasswordExpiresAt != null)
                    hashCode = hashCode * 59 + this.PasswordExpiresAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
