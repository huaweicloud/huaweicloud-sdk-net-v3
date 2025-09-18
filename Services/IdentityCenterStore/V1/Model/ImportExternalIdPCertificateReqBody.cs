using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenterStore.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ImportExternalIdPCertificateReqBody 
    {
        /// <summary>
        /// 身份提供商证书用途，目前仅支持签名
        /// </summary>
        /// <value>身份提供商证书用途，目前仅支持签名</value>
        [JsonConverter(typeof(EnumClassConverter<CertificateUseEnum>))]
        public class CertificateUseEnum
        {
            /// <summary>
            /// Enum SIGNING for value: SIGNING
            /// </summary>
            public static readonly CertificateUseEnum SIGNING = new CertificateUseEnum("SIGNING");

            private static readonly Dictionary<string, CertificateUseEnum> StaticFields =
            new Dictionary<string, CertificateUseEnum>()
            {
                { "SIGNING", SIGNING },
            };

            private string _value;

            public CertificateUseEnum()
            {

            }

            public CertificateUseEnum(string value)
            {
                _value = value;
            }

            public static CertificateUseEnum FromValue(string value)
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

                if (this.Equals(obj as CertificateUseEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CertificateUseEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CertificateUseEnum a, CertificateUseEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(CertificateUseEnum a, CertificateUseEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// PEM格式的身份提供商证书内容
        /// </summary>
        [JsonProperty("x509_certificate_in_pem", NullValueHandling = NullValueHandling.Ignore)]
        public string X509CertificateInPem { get; set; }

        /// <summary>
        /// 身份提供商证书用途，目前仅支持签名
        /// </summary>
        [JsonProperty("certificate_use", NullValueHandling = NullValueHandling.Ignore)]
        public CertificateUseEnum CertificateUse { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportExternalIdPCertificateReqBody {\n");
            sb.Append("  x509CertificateInPem: ").Append(X509CertificateInPem).Append("\n");
            sb.Append("  certificateUse: ").Append(CertificateUse).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImportExternalIdPCertificateReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImportExternalIdPCertificateReqBody input)
        {
            if (input == null) return false;
            if (this.X509CertificateInPem != input.X509CertificateInPem || (this.X509CertificateInPem != null && !this.X509CertificateInPem.Equals(input.X509CertificateInPem))) return false;
            if (this.CertificateUse != input.CertificateUse) return false;

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
                if (this.X509CertificateInPem != null) hashCode = hashCode * 59 + this.X509CertificateInPem.GetHashCode();
                hashCode = hashCode * 59 + this.CertificateUse.GetHashCode();
                return hashCode;
            }
        }
    }
}
