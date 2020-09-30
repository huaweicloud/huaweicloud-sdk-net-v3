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
    public class KeystoneShowSecurityComplianceByOptionRequest 
    {
        /// <summary>
        /// Defines option
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<OptionEnum>))]
        public class OptionEnum
        {
            /// <summary>
            /// Enum PASSWORD_REGEX for value: password_regex
            /// </summary>
            public static readonly OptionEnum PASSWORD_REGEX = new OptionEnum("password_regex");

            /// <summary>
            /// Enum PASSWORD_REGEX_DESCRIPTION for value: password_regex_description
            /// </summary>
            public static readonly OptionEnum PASSWORD_REGEX_DESCRIPTION = new OptionEnum("password_regex_description");

            private static readonly Dictionary<string, OptionEnum> StaticFields =
            new Dictionary<string, OptionEnum>()
            {
                { "password_regex", PASSWORD_REGEX },
                { "password_regex_description", PASSWORD_REGEX_DESCRIPTION },
            };

            private string Value;

            private OptionEnum(string value)
            {
                this.Value = value;
            }

            public static OptionEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return this.Value;
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as OptionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OptionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(OptionEnum a, OptionEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(OptionEnum a, OptionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("domain_id", IsPath = true)]
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("option", IsPath = true)]
        [JsonProperty("option", NullValueHandling = NullValueHandling.Ignore)]
        public OptionEnum Option { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KeystoneShowSecurityComplianceByOptionRequest {\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  option: ").Append(Option).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as KeystoneShowSecurityComplianceByOptionRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(KeystoneShowSecurityComplianceByOptionRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DomainId == input.DomainId ||
                    (this.DomainId != null &&
                    this.DomainId.Equals(input.DomainId))
                ) && 
                (
                    this.Option == input.Option ||
                    (this.Option != null &&
                    this.Option.Equals(input.Option))
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
                if (this.DomainId != null)
                    hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.Option != null)
                    hashCode = hashCode * 59 + this.Option.GetHashCode();
                return hashCode;
            }
        }
    }
}
