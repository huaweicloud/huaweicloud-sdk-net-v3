using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenter.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class DescribeApplicationProviderResponse : SdkResponse
    {
        /// <summary>
        /// 支持的协议
        /// </summary>
        /// <value>支持的协议</value>
        [JsonConverter(typeof(EnumClassConverter<FederationProtocolEnum>))]
        public class FederationProtocolEnum
        {
            /// <summary>
            /// Enum SAML for value: SAML
            /// </summary>
            public static readonly FederationProtocolEnum SAML = new FederationProtocolEnum("SAML");

            /// <summary>
            /// Enum OAUTH for value: OAUTH
            /// </summary>
            public static readonly FederationProtocolEnum OAUTH = new FederationProtocolEnum("OAUTH");

            private static readonly Dictionary<string, FederationProtocolEnum> StaticFields =
            new Dictionary<string, FederationProtocolEnum>()
            {
                { "SAML", SAML },
                { "OAUTH", OAUTH },
            };

            private string _value;

            public FederationProtocolEnum()
            {

            }

            public FederationProtocolEnum(string value)
            {
                _value = value;
            }

            public static FederationProtocolEnum FromValue(string value)
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
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
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

                if (this.Equals(obj as FederationProtocolEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(FederationProtocolEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(FederationProtocolEnum a, FederationProtocolEnum b)
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

            public static bool operator !=(FederationProtocolEnum a, FederationProtocolEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 应用程序提供者URN
        /// </summary>
        [JsonProperty("application_provider_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplicationProviderUrn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("display_data", NullValueHandling = NullValueHandling.Ignore)]
        public DisplayDataDto DisplayData { get; set; }

        /// <summary>
        /// 支持的协议
        /// </summary>
        [JsonProperty("federation_protocol", NullValueHandling = NullValueHandling.Ignore)]
        public FederationProtocolEnum FederationProtocol { get; set; }
        /// <summary>
        /// 应用程序提供者唯一标识符（ID）
        /// </summary>
        [JsonProperty("application_provider_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplicationProviderId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DescribeApplicationProviderResponse {\n");
            sb.Append("  applicationProviderUrn: ").Append(ApplicationProviderUrn).Append("\n");
            sb.Append("  displayData: ").Append(DisplayData).Append("\n");
            sb.Append("  federationProtocol: ").Append(FederationProtocol).Append("\n");
            sb.Append("  applicationProviderId: ").Append(ApplicationProviderId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DescribeApplicationProviderResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DescribeApplicationProviderResponse input)
        {
            if (input == null) return false;
            if (this.ApplicationProviderUrn != input.ApplicationProviderUrn || (this.ApplicationProviderUrn != null && !this.ApplicationProviderUrn.Equals(input.ApplicationProviderUrn))) return false;
            if (this.DisplayData != input.DisplayData || (this.DisplayData != null && !this.DisplayData.Equals(input.DisplayData))) return false;
            if (this.FederationProtocol != input.FederationProtocol) return false;
            if (this.ApplicationProviderId != input.ApplicationProviderId || (this.ApplicationProviderId != null && !this.ApplicationProviderId.Equals(input.ApplicationProviderId))) return false;

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
                if (this.ApplicationProviderUrn != null) hashCode = hashCode * 59 + this.ApplicationProviderUrn.GetHashCode();
                if (this.DisplayData != null) hashCode = hashCode * 59 + this.DisplayData.GetHashCode();
                hashCode = hashCode * 59 + this.FederationProtocol.GetHashCode();
                if (this.ApplicationProviderId != null) hashCode = hashCode * 59 + this.ApplicationProviderId.GetHashCode();
                return hashCode;
            }
        }
    }
}
