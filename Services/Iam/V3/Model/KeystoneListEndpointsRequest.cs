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
    public class KeystoneListEndpointsRequest 
    {
        /// <summary>
        /// Defines Interface
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<InterfaceEnum>))]
        public class InterfaceEnum
        {
            /// <summary>
            /// Enum PUBLIC for value: public
            /// </summary>
            public static readonly InterfaceEnum PUBLIC = new InterfaceEnum("public");

            /// <summary>
            /// Enum INTERNAL for value: internal
            /// </summary>
            public static readonly InterfaceEnum INTERNAL = new InterfaceEnum("internal");

            /// <summary>
            /// Enum ADMIN for value: admin
            /// </summary>
            public static readonly InterfaceEnum ADMIN = new InterfaceEnum("admin");

            private static readonly Dictionary<string, InterfaceEnum> StaticFields =
            new Dictionary<string, InterfaceEnum>()
            {
                { "public", PUBLIC },
                { "internal", INTERNAL },
                { "admin", ADMIN },
            };

            private string Value;

            public InterfaceEnum(string value)
            {
                Value = value;
            }

            public static InterfaceEnum FromValue(string value)
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

                if (this.Equals(obj as InterfaceEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(InterfaceEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(InterfaceEnum a, InterfaceEnum b)
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

            public static bool operator !=(InterfaceEnum a, InterfaceEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("interface", IsQuery = true)]
        [JsonProperty("interface", NullValueHandling = NullValueHandling.Ignore)]
        public InterfaceEnum Interface { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("service_id", IsQuery = true)]
        [JsonProperty("service_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KeystoneListEndpointsRequest {\n");
            sb.Append("  Interface: ").Append(Interface).Append("\n");
            sb.Append("  serviceId: ").Append(ServiceId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as KeystoneListEndpointsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(KeystoneListEndpointsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Interface == input.Interface ||
                    (this.Interface != null &&
                    this.Interface.Equals(input.Interface))
                ) && 
                (
                    this.ServiceId == input.ServiceId ||
                    (this.ServiceId != null &&
                    this.ServiceId.Equals(input.ServiceId))
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
                if (this.Interface != null)
                    hashCode = hashCode * 59 + this.Interface.GetHashCode();
                if (this.ServiceId != null)
                    hashCode = hashCode * 59 + this.ServiceId.GetHashCode();
                return hashCode;
            }
        }
    }
}
