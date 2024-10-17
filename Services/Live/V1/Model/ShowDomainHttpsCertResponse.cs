using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowDomainHttpsCertResponse : SdkResponse
    {
        /// <summary>
        /// 证书格式，默认为PEM，当前只支持PEM格式
        /// </summary>
        /// <value>证书格式，默认为PEM，当前只支持PEM格式</value>
        [JsonConverter(typeof(EnumClassConverter<CertificateFormatEnum>))]
        public class CertificateFormatEnum
        {
            /// <summary>
            /// Enum PEM for value: PEM
            /// </summary>
            public static readonly CertificateFormatEnum PEM = new CertificateFormatEnum("PEM");

            private static readonly Dictionary<string, CertificateFormatEnum> StaticFields =
            new Dictionary<string, CertificateFormatEnum>()
            {
                { "PEM", PEM },
            };

            private string _value;

            public CertificateFormatEnum()
            {

            }

            public CertificateFormatEnum(string value)
            {
                _value = value;
            }

            public static CertificateFormatEnum FromValue(string value)
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

                if (this.Equals(obj as CertificateFormatEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CertificateFormatEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CertificateFormatEnum a, CertificateFormatEnum b)
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

            public static bool operator !=(CertificateFormatEnum a, CertificateFormatEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 证书格式，默认为PEM，当前只支持PEM格式
        /// </summary>
        [JsonProperty("certificate_format", NullValueHandling = NullValueHandling.Ignore)]
        public CertificateFormatEnum CertificateFormat { get; set; }
        /// <summary>
        /// 证书内容
        /// </summary>
        [JsonProperty("certificate", NullValueHandling = NullValueHandling.Ignore)]
        public string Certificate { get; set; }

        /// <summary>
        /// 私钥内容
        /// </summary>
        [JsonProperty("certificate_key", NullValueHandling = NullValueHandling.Ignore)]
        public string CertificateKey { get; set; }

        /// <summary>
        /// 是否开启重定向，默认false
        /// </summary>
        [JsonProperty("force_redirect", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ForceRedirect { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("gm_certificate", NullValueHandling = NullValueHandling.Ignore)]
        public GmCertificateInfo GmCertificate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("tls_certificate", NullValueHandling = NullValueHandling.Ignore)]
        public TlsCertificateInfo TlsCertificate { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDomainHttpsCertResponse {\n");
            sb.Append("  certificateFormat: ").Append(CertificateFormat).Append("\n");
            sb.Append("  certificate: ").Append(Certificate).Append("\n");
            sb.Append("  certificateKey: ").Append(CertificateKey).Append("\n");
            sb.Append("  forceRedirect: ").Append(ForceRedirect).Append("\n");
            sb.Append("  gmCertificate: ").Append(GmCertificate).Append("\n");
            sb.Append("  tlsCertificate: ").Append(TlsCertificate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDomainHttpsCertResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDomainHttpsCertResponse input)
        {
            if (input == null) return false;
            if (this.CertificateFormat != input.CertificateFormat) return false;
            if (this.Certificate != input.Certificate || (this.Certificate != null && !this.Certificate.Equals(input.Certificate))) return false;
            if (this.CertificateKey != input.CertificateKey || (this.CertificateKey != null && !this.CertificateKey.Equals(input.CertificateKey))) return false;
            if (this.ForceRedirect != input.ForceRedirect || (this.ForceRedirect != null && !this.ForceRedirect.Equals(input.ForceRedirect))) return false;
            if (this.GmCertificate != input.GmCertificate || (this.GmCertificate != null && !this.GmCertificate.Equals(input.GmCertificate))) return false;
            if (this.TlsCertificate != input.TlsCertificate || (this.TlsCertificate != null && !this.TlsCertificate.Equals(input.TlsCertificate))) return false;

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
                hashCode = hashCode * 59 + this.CertificateFormat.GetHashCode();
                if (this.Certificate != null) hashCode = hashCode * 59 + this.Certificate.GetHashCode();
                if (this.CertificateKey != null) hashCode = hashCode * 59 + this.CertificateKey.GetHashCode();
                if (this.ForceRedirect != null) hashCode = hashCode * 59 + this.ForceRedirect.GetHashCode();
                if (this.GmCertificate != null) hashCode = hashCode * 59 + this.GmCertificate.GetHashCode();
                if (this.TlsCertificate != null) hashCode = hashCode * 59 + this.TlsCertificate.GetHashCode();
                return hashCode;
            }
        }
    }
}
