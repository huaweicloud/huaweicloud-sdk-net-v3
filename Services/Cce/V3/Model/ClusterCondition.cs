using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 集群详细状态。
    /// </summary>
    public class ClusterCondition 
    {
        /// <summary>
        /// **参数解释**： 状态类型。 **约束限制**： 不涉及 **取值范围**： - \&quot;AgencyAvailable\&quot;: CCE集群自定义委托的状态。 - \&quot;ClusterCertificate\&quot;: CCE集群证书的状态。 - \&quot;ClusterCustomCertificate\&quot;: CCE集群自有证书的状态。 - \&quot;CertificateRotation\&quot;: CCE集群证书更新的状态。 - \&quot;CustomCertificateRotation\&quot;: CCE集群自有证书更新的状态。 - \&quot;OpenIDConnectProcessing\&quot;: CCE集群开启OIDC特性处理中状态。 - \&quot;OpenIDConnectProcessSuccess\&quot;: CCE集群开启OIDC特性成功状态。 - \&quot;OpenIDConnectProcessFailed\&quot;: CCE集群开启OIDC特性失败状态。  **默认取值**： 不涉及
        /// </summary>
        /// <value>**参数解释**： 状态类型。 **约束限制**： 不涉及 **取值范围**： - \&quot;AgencyAvailable\&quot;: CCE集群自定义委托的状态。 - \&quot;ClusterCertificate\&quot;: CCE集群证书的状态。 - \&quot;ClusterCustomCertificate\&quot;: CCE集群自有证书的状态。 - \&quot;CertificateRotation\&quot;: CCE集群证书更新的状态。 - \&quot;CustomCertificateRotation\&quot;: CCE集群自有证书更新的状态。 - \&quot;OpenIDConnectProcessing\&quot;: CCE集群开启OIDC特性处理中状态。 - \&quot;OpenIDConnectProcessSuccess\&quot;: CCE集群开启OIDC特性成功状态。 - \&quot;OpenIDConnectProcessFailed\&quot;: CCE集群开启OIDC特性失败状态。  **默认取值**： 不涉及</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum AGENCYAVAILABLE for value: AgencyAvailable
            /// </summary>
            public static readonly TypeEnum AGENCYAVAILABLE = new TypeEnum("AgencyAvailable");

            /// <summary>
            /// Enum CLUSTERCERTIFICATE for value: ClusterCertificate
            /// </summary>
            public static readonly TypeEnum CLUSTERCERTIFICATE = new TypeEnum("ClusterCertificate");

            /// <summary>
            /// Enum CLUSTERCUSTOMCERTIFICATE for value: ClusterCustomCertificate
            /// </summary>
            public static readonly TypeEnum CLUSTERCUSTOMCERTIFICATE = new TypeEnum("ClusterCustomCertificate");

            /// <summary>
            /// Enum CERTIFICATEROTATION for value: CertificateRotation
            /// </summary>
            public static readonly TypeEnum CERTIFICATEROTATION = new TypeEnum("CertificateRotation");

            /// <summary>
            /// Enum CUSTOMCERTIFICATEROTATION for value: CustomCertificateRotation
            /// </summary>
            public static readonly TypeEnum CUSTOMCERTIFICATEROTATION = new TypeEnum("CustomCertificateRotation");

            /// <summary>
            /// Enum OPENIDCONNECTPROCESSING for value: OpenIDConnectProcessing
            /// </summary>
            public static readonly TypeEnum OPENIDCONNECTPROCESSING = new TypeEnum("OpenIDConnectProcessing");

            /// <summary>
            /// Enum OPENIDCONNECTPROCESSSUCCESS for value: OpenIDConnectProcessSuccess
            /// </summary>
            public static readonly TypeEnum OPENIDCONNECTPROCESSSUCCESS = new TypeEnum("OpenIDConnectProcessSuccess");

            /// <summary>
            /// Enum OPENIDCONNECTPROCESSFAILED for value: OpenIDConnectProcessFailed
            /// </summary>
            public static readonly TypeEnum OPENIDCONNECTPROCESSFAILED = new TypeEnum("OpenIDConnectProcessFailed");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "AgencyAvailable", AGENCYAVAILABLE },
                { "ClusterCertificate", CLUSTERCERTIFICATE },
                { "ClusterCustomCertificate", CLUSTERCUSTOMCERTIFICATE },
                { "CertificateRotation", CERTIFICATEROTATION },
                { "CustomCertificateRotation", CUSTOMCERTIFICATEROTATION },
                { "OpenIDConnectProcessing", OPENIDCONNECTPROCESSING },
                { "OpenIDConnectProcessSuccess", OPENIDCONNECTPROCESSSUCCESS },
                { "OpenIDConnectProcessFailed", OPENIDCONNECTPROCESSFAILED },
            };

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： 状态类型。 **约束限制**： 不涉及 **取值范围**： - \&quot;AgencyAvailable\&quot;: CCE集群自定义委托的状态。 - \&quot;ClusterCertificate\&quot;: CCE集群证书的状态。 - \&quot;ClusterCustomCertificate\&quot;: CCE集群自有证书的状态。 - \&quot;CertificateRotation\&quot;: CCE集群证书更新的状态。 - \&quot;CustomCertificateRotation\&quot;: CCE集群自有证书更新的状态。 - \&quot;OpenIDConnectProcessing\&quot;: CCE集群开启OIDC特性处理中状态。 - \&quot;OpenIDConnectProcessSuccess\&quot;: CCE集群开启OIDC特性成功状态。 - \&quot;OpenIDConnectProcessFailed\&quot;: CCE集群开启OIDC特性失败状态。  **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// **参数解释**： Condition当前状态。 **约束限制**： 不涉及 **取值范围**： - \&quot;True\&quot; - \&quot;False\&quot;  **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释**： 上次状态检查时间。 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("lastProbeTime", NullValueHandling = NullValueHandling.Ignore)]
        public string LastProbeTime { get; set; }

        /// <summary>
        /// **参数解释**： 上次状态变更时间。 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("lastTransitTime", NullValueHandling = NullValueHandling.Ignore)]
        public string LastTransitTime { get; set; }

        /// <summary>
        /// **参数解释**： 上次状态变更原因。 **约束限制**： 不涉及 **取值范围**： - type为ClusterCertificate、ClusterCustomCertificate时取值范围：   - CertificateValid：证书状态正常   - CertificateExpiringWithin180Days：证书有效期低于180天   - CertificateExpiringWithin30Days：证书有效期低于30天   - CertificateExpired：证书已过期 - type为CertificateRotation、CustomCertificateRotation时取值范围：   - RotationInProgress：更新中   - RotationSucceeded：更新成功   - RotationFailed：更新失败  **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; set; }

        /// <summary>
        /// **参数解释**： Condition详细描述。 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClusterCondition {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  lastProbeTime: ").Append(LastProbeTime).Append("\n");
            sb.Append("  lastTransitTime: ").Append(LastTransitTime).Append("\n");
            sb.Append("  reason: ").Append(Reason).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClusterCondition);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ClusterCondition input)
        {
            if (input == null) return false;
            if (this.Type != input.Type) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.LastProbeTime != input.LastProbeTime || (this.LastProbeTime != null && !this.LastProbeTime.Equals(input.LastProbeTime))) return false;
            if (this.LastTransitTime != input.LastTransitTime || (this.LastTransitTime != null && !this.LastTransitTime.Equals(input.LastTransitTime))) return false;
            if (this.Reason != input.Reason || (this.Reason != null && !this.Reason.Equals(input.Reason))) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;

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
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.LastProbeTime != null) hashCode = hashCode * 59 + this.LastProbeTime.GetHashCode();
                if (this.LastTransitTime != null) hashCode = hashCode * 59 + this.LastTransitTime.GetHashCode();
                if (this.Reason != null) hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                return hashCode;
            }
        }
    }
}
