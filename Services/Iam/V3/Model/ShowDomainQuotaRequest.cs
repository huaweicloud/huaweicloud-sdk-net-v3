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
    public class ShowDomainQuotaRequest 
    {
        /// <summary>
        /// Defines type
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum USER for value: user
            /// </summary>
            public static readonly TypeEnum USER = new TypeEnum("user");

            /// <summary>
            /// Enum GROUP for value: group
            /// </summary>
            public static readonly TypeEnum GROUP = new TypeEnum("group");

            /// <summary>
            /// Enum IDP for value: idp
            /// </summary>
            public static readonly TypeEnum IDP = new TypeEnum("idp");

            /// <summary>
            /// Enum AGENCY for value: agency
            /// </summary>
            public static readonly TypeEnum AGENCY = new TypeEnum("agency");

            /// <summary>
            /// Enum POLICY for value: policy
            /// </summary>
            public static readonly TypeEnum POLICY = new TypeEnum("policy");

            /// <summary>
            /// Enum ASSIGMENT_GROUP_MP for value: assigment_group_mp
            /// </summary>
            public static readonly TypeEnum ASSIGMENT_GROUP_MP = new TypeEnum("assigment_group_mp");

            /// <summary>
            /// Enum ASSIGMENT_AGENCY_MP for value: assigment_agency_mp
            /// </summary>
            public static readonly TypeEnum ASSIGMENT_AGENCY_MP = new TypeEnum("assigment_agency_mp");

            /// <summary>
            /// Enum ASSIGMENT_GROUP_EP for value: assigment_group_ep
            /// </summary>
            public static readonly TypeEnum ASSIGMENT_GROUP_EP = new TypeEnum("assigment_group_ep");

            /// <summary>
            /// Enum ASSIGMENT_USER_EP for value: assigment_user_ep
            /// </summary>
            public static readonly TypeEnum ASSIGMENT_USER_EP = new TypeEnum("assigment_user_ep");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "user", USER },
                { "group", GROUP },
                { "idp", IDP },
                { "agency", AGENCY },
                { "policy", POLICY },
                { "assigment_group_mp", ASSIGMENT_GROUP_MP },
                { "assigment_agency_mp", ASSIGMENT_AGENCY_MP },
                { "assigment_group_ep", ASSIGMENT_GROUP_EP },
                { "assigment_user_ep", ASSIGMENT_USER_EP },
            };

            private string Value;

            public TypeEnum(string value)
            {
                Value = value;
            }

            public static TypeEnum FromValue(string value)
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
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

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
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
        [SDKProperty("type", IsQuery = true)]
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDomainQuotaRequest {\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDomainQuotaRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDomainQuotaRequest input)
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
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
