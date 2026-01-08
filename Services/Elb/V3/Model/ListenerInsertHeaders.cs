using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ListenerInsertHeaders 
    {
        /// <summary>
        /// **参数解释**：处理X-Forwarded-For头字段的模式： 配置 append，将请求发送至后端服务之前把最后一跳 IP 加入X-Forwarded-For头字段； 配置 remove，请求发送至后端服务之前删除X-Forwarded-For标头，无论请求是否携带X-Forwarded-For头字段； 配置preserve，保留请求中已有的X-Forwarded-For标头；  **约束限制**：仅HTTP、HTTPS、TERMINATED_HTTPS、QUIC协议的监听器支持该字段；  **取值范围**：append、remove、preserve  **默认取值**：append
        /// </summary>
        /// <value>**参数解释**：处理X-Forwarded-For头字段的模式： 配置 append，将请求发送至后端服务之前把最后一跳 IP 加入X-Forwarded-For头字段； 配置 remove，请求发送至后端服务之前删除X-Forwarded-For标头，无论请求是否携带X-Forwarded-For头字段； 配置preserve，保留请求中已有的X-Forwarded-For标头；  **约束限制**：仅HTTP、HTTPS、TERMINATED_HTTPS、QUIC协议的监听器支持该字段；  **取值范围**：append、remove、preserve  **默认取值**：append</value>
        [JsonConverter(typeof(EnumClassConverter<XForwardedForProcessingModeEnum>))]
        public class XForwardedForProcessingModeEnum
        {
            /// <summary>
            /// Enum APPEND_REMOVE_PRESERVE for value: append、remove、preserve
            /// </summary>
            public static readonly XForwardedForProcessingModeEnum APPEND_REMOVE_PRESERVE = new XForwardedForProcessingModeEnum("append、remove、preserve");

            private static readonly Dictionary<string, XForwardedForProcessingModeEnum> StaticFields =
            new Dictionary<string, XForwardedForProcessingModeEnum>()
            {
                { "append、remove、preserve", APPEND_REMOVE_PRESERVE },
            };

            private string _value;

            public XForwardedForProcessingModeEnum()
            {

            }

            public XForwardedForProcessingModeEnum(string value)
            {
                _value = value;
            }

            public static XForwardedForProcessingModeEnum FromValue(string value)
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

                if (this.Equals(obj as XForwardedForProcessingModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(XForwardedForProcessingModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(XForwardedForProcessingModeEnum a, XForwardedForProcessingModeEnum b)
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

            public static bool operator !=(XForwardedForProcessingModeEnum a, XForwardedForProcessingModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**：X-Forwarded-ELB-IP设为true可以将ELB实例的eip地址从报文的http头中带到后端服务器。
        /// </summary>
        [JsonProperty("X-Forwarded-ELB-IP", NullValueHandling = NullValueHandling.Ignore)]
        public bool? XForwardedELBIP { get; set; }

        /// <summary>
        /// **参数解释**：X-Forwarded-Port设为true可以将ELB实例的监听端口从报文的http头中带到后端服务器。
        /// </summary>
        [JsonProperty("X-Forwarded-Port", NullValueHandling = NullValueHandling.Ignore)]
        public bool? XForwardedPort { get; set; }

        /// <summary>
        /// **参数解释**：X-Forwarded-For-Port设为true可以将客户端的源端口从报文的http头中带到后端服务器。
        /// </summary>
        [JsonProperty("X-Forwarded-For-Port", NullValueHandling = NullValueHandling.Ignore)]
        public bool? XForwardedForPort { get; set; }

        /// <summary>
        /// **参数解释**：X-Forwarded-Host设为true可以将客户请求头的X-Forwarded-Host设置为请求头的Host带到后端服务器。
        /// </summary>
        [JsonProperty("X-Forwarded-Host", NullValueHandling = NullValueHandling.Ignore)]
        public bool? XForwardedHost { get; set; }

        /// <summary>
        /// **参数解释**：X-Forwarded-Proto设为true可以将负载均衡器实例的监听协议通过报文的http头带到后端服务器。
        /// </summary>
        [JsonProperty("X-Forwarded-Proto", NullValueHandling = NullValueHandling.Ignore)]
        public bool? XForwardedProto { get; set; }

        /// <summary>
        /// **参数解释**：X-Real-IP设为true可以将客户端的IP通过报文的http头带到后端服务器。
        /// </summary>
        [JsonProperty("X-Real-IP", NullValueHandling = NullValueHandling.Ignore)]
        public bool? XRealIP { get; set; }

        /// <summary>
        /// **参数解释**：X-Forwarded-ELB-ID设为true可以将负载均衡器实例的ID通过报文的http头带到后端服务器。
        /// </summary>
        [JsonProperty("X-Forwarded-ELB-ID", NullValueHandling = NullValueHandling.Ignore)]
        public bool? XForwardedELBID { get; set; }

        /// <summary>
        /// **参数解释**：X-Forwarded-TLS-Certificate-ID设为true可以将负载均衡器实例的证书ID通过报文的http头带到后端服务器。
        /// </summary>
        [JsonProperty("X-Forwarded-TLS-Certificate-ID", NullValueHandling = NullValueHandling.Ignore)]
        public bool? XForwardedTLSCertificateID { get; set; }

        /// <summary>
        /// **参数解释**：X-Forwarded-TLS-Protocol设为true可以将负载均衡器实例的算法协议通过报文的http头带到后端服务器。
        /// </summary>
        [JsonProperty("X-Forwarded-TLS-Protocol", NullValueHandling = NullValueHandling.Ignore)]
        public bool? XForwardedTLSProtocol { get; set; }

        /// <summary>
        /// **参数解释**：X-Forwarded-TLS-Cipher设为true可以将负载均衡器实例的算法套件通过报文的http头带到后端服务器。
        /// </summary>
        [JsonProperty("X-Forwarded-TLS-Cipher", NullValueHandling = NullValueHandling.Ignore)]
        public bool? XForwardedTLSCipher { get; set; }

        /// <summary>
        /// **参数解释**：自定义X-Forwarded-TLS-Protocol头字段名称。  **约束限制**：只有当 X-Forwarded-TLS-Protocol 的值为 true 时，此值才会生效。仅HTTPS、TERMINATED_HTTPS、QUIC协议的监听器支持该字段  **取值范围**：1~40 个字符。支持字母 a~z、短划线（-）、下划线（_）和数字。  **默认取值**：无
        /// </summary>
        [JsonProperty("X-Forwarded-TLS-Protocol-alias", NullValueHandling = NullValueHandling.Ignore)]
        public string XForwardedTLSProtocolAlias { get; set; }

        /// <summary>
        /// **参数解释**：自定义X-Forwarded-TLS-Cipher头字段名称。  **约束限制**：只有当 X-Forwarded-TLS-Cipher 的值为 true 时，此值才会生效。仅HTTPS、TERMINATED_HTTPS、QUIC协议的监听器支持该字段  **取值范围**：1~40 个字符。支持字母 a~z、短划线（-）、下划线（_）和数字。  **默认取值**：无
        /// </summary>
        [JsonProperty("X-Forwarded-TLS-Cipher-alias", NullValueHandling = NullValueHandling.Ignore)]
        public string XForwardedTLSCipherAlias { get; set; }

        /// <summary>
        /// **参数解释**：处理X-Forwarded-For头字段的模式： 配置 append，将请求发送至后端服务之前把最后一跳 IP 加入X-Forwarded-For头字段； 配置 remove，请求发送至后端服务之前删除X-Forwarded-For标头，无论请求是否携带X-Forwarded-For头字段； 配置preserve，保留请求中已有的X-Forwarded-For标头；  **约束限制**：仅HTTP、HTTPS、TERMINATED_HTTPS、QUIC协议的监听器支持该字段；  **取值范围**：append、remove、preserve  **默认取值**：append
        /// </summary>
        [JsonProperty("X-Forwarded-For-Processing-Mode", NullValueHandling = NullValueHandling.Ignore)]
        public XForwardedForProcessingModeEnum XForwardedForProcessingMode { get; set; }
        /// <summary>
        /// **参数解释**：是否通过X-Forwarded-Clientcert-subjectdn头字段获取访问负载均衡实例客户端证书的所有者信息。  **约束限制**：仅HTTPS、TERMINATED_HTTPS、QUIC协议的监听器支持该字段  **取值范围**：true、false  **默认取值**：false
        /// </summary>
        [JsonProperty("X-Forwarded-Clientcert-subjectdn-enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? XForwardedClientcertSubjectdnEnable { get; set; }

        /// <summary>
        /// **参数解释**：自定义X-Forwarded-Clientcert-subjectdn头字段名称。  **约束限制**：只有当 X-Forwarded-Clientcert-subjectdn-enable 的值为 true 时，此值才会生效。仅HTTPS、TERMINATED_HTTPS、QUIC协议的监听器支持该字段  **取值范围**：1~40 个字符。支持字母 a~z、短划线（-）、下划线（_）和数字。  **默认取值**：无
        /// </summary>
        [JsonProperty("X-Forwarded-Clientcert-subjectdn-alias", NullValueHandling = NullValueHandling.Ignore)]
        public string XForwardedClientcertSubjectdnAlias { get; set; }

        /// <summary>
        /// **参数解释**：是否通过X-Forwarded-Clientcert-issuerdn头字段获取访问负载均衡实例客户端证书的发行者信息。  **约束限制**：仅HTTPS、TERMINATED_HTTPS、QUIC协议的监听器支持该字段  **取值范围**：true、false  **默认取值**：false
        /// </summary>
        [JsonProperty("X-Forwarded-Clientcert-issuerdn-enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? XForwardedClientcertIssuerdnEnable { get; set; }

        /// <summary>
        /// **参数解释**：自定义X-Forwarded-Clientcert-issuerdn头字段名称。  **约束限制**：只有当 X-Forwarded-Clientcert-issuerdn-enable 的值为 true 时，此值才会生效。仅HTTPS、TERMINATED_HTTPS、QUIC协议的监听器支持该字段  **取值范围**：1~40 个字符。支持字母 a~z、短划线（-）、下划线（_）和数字。  **默认取值**：无
        /// </summary>
        [JsonProperty("X-Forwarded-Clientcert-issuerdn-alias", NullValueHandling = NullValueHandling.Ignore)]
        public string XForwardedClientcertIssuerdnAlias { get; set; }

        /// <summary>
        /// **参数解释**：是否通过X-Forwarded-Clientcert-fingerprint头字段获取访问负载均衡实例客户端证书的指纹取值。  **约束限制**：仅HTTPS、TERMINATED_HTTPS、QUIC协议的监听器支持该字段  **取值范围**：true、false  **默认取值**：false
        /// </summary>
        [JsonProperty("X-Forwarded-Clientcert-fingerprint-enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? XForwardedClientcertFingerprintEnable { get; set; }

        /// <summary>
        /// **参数解释**：自定义X-Forwarded-Clientcert-fingerprint头字段名称。  **约束限制**：只有当 X-Forwarded-Clientcert-fingerprint-enable 的值为 true 时，此值才会生效。仅HTTPS、TERMINATED_HTTPS、QUIC协议的监听器支持该字段  **取值范围**：1~40 个字符。支持字母 a~z、短划线（-）、下划线（_）和数字。  **默认取值**：无
        /// </summary>
        [JsonProperty("X-Forwarded-Clientcert-fingerprint-alias", NullValueHandling = NullValueHandling.Ignore)]
        public string XForwardedClientcertFingerprintAlias { get; set; }

        /// <summary>
        /// **参数解释**：是否通过X-Forwarded-Clientcert-clientverify头字段获取对访问负载均衡实例客户端证书的校验结果。  **约束限制**：仅HTTPS、TERMINATED_HTTPS、QUIC协议的监听器支持该字段  **取值范围**：true、false  **默认取值**：false
        /// </summary>
        [JsonProperty("X-Forwarded-Clientcert-clientverify-enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? XForwardedClientcertClientverifyEnable { get; set; }

        /// <summary>
        /// **参数解释**：自定义X-Forwarded-Clientcert-clientverify头字段名称。  **约束限制**：只有当 X-Forwarded-Clientcert-clientverify-enable 的值为 true 时，此值才会生效。仅HTTPS、TERMINATED_HTTPS、QUIC协议的监听器支持该字段  **取值范围**：1~40 个字符。支持字母 a~z、短划线（-）、下划线（_）和数字。  **默认取值**：无
        /// </summary>
        [JsonProperty("X-Forwarded-Clientcert-clientverify-alias", NullValueHandling = NullValueHandling.Ignore)]
        public string XForwardedClientcertClientverifyAlias { get; set; }

        /// <summary>
        /// **参数解释**：是否通过X-Forwarded-Clientcert-serialnumber 头字段获取客户端证书的序列号信息。  **约束限制**：仅HTTPS、TERMINATED_HTTPS、QUIC协议的监听器支持该字段  **取值范围**：true、false  **默认取值**：false
        /// </summary>
        [JsonProperty("X-Forwarded-Clientcert-serialnumber-enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? XForwardedClientcertSerialnumberEnable { get; set; }

        /// <summary>
        /// **参数解释**：自定义X-Forwarded-Clientcert-serialnumber头字段名称。  **约束限制**：只有当X-Forwarded-Clientcert-serialnumber-enable 的值为 true 时，此值才会生效。仅HTTPS、TERMINATED_HTTPS、QUIC协议的监听器支持该字段  **取值范围**：1~40 个字符。支持字母 a~z、短划线（-）、下划线（_）和数字。  **默认取值**：无
        /// </summary>
        [JsonProperty("X-Forwarded-Clientcert-serialnumber-alias", NullValueHandling = NullValueHandling.Ignore)]
        public string XForwardedClientcertSerialnumberAlias { get; set; }

        /// <summary>
        /// **参数解释**：是否通过X-Forwarded-Clientcert 头字段获取客户端证书的内容。  **约束限制**：仅HTTPS、TERMINATED_HTTPS、QUIC协议的监听器支持该字段  **取值范围**：true、false  **默认取值**：false
        /// </summary>
        [JsonProperty("X-Forwarded-Clientcert-enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? XForwardedClientcertEnable { get; set; }

        /// <summary>
        /// **参数解释**：自定义X-Forwarded-Clientcert头字段名称。  **约束限制**：只有当X-Forwarded-Clientcert-enable 的值为 true 时，此值才会生效。仅HTTPS、TERMINATED_HTTPS、QUIC、TLS协议的监听器支持该字段  **取值范围**：1~40 个字符。支持字母 a~z、短划线（-）、下划线（_）和数字。  **默认取值**：无
        /// </summary>
        [JsonProperty("X-Forwarded-Clientcert-alias", NullValueHandling = NullValueHandling.Ignore)]
        public string XForwardedClientcertAlias { get; set; }

        /// <summary>
        /// **参数解释**：是否通过X-Forwarded-Clientcert-ciphers 头字段获取客户端支持的TLS加密套件。  **约束限制**：仅HTTPS、TERMINATED_HTTPS、QUIC协议的监听器支持该字段。  **取值范围**：true、false  **默认取值**：false
        /// </summary>
        [JsonProperty("X-Forwarded-Clientcert-ciphers-enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? XForwardedClientcertCiphersEnable { get; set; }

        /// <summary>
        /// **参数解释**：自定义X-Forwarded-Clientcert-ciphers头字段名称。  **约束限制**：只有当X-Forwarded-Clientcert-ciphers-enable 的值为 true 时，此值才会生效。仅HTTPS、TERMINATED_HTTPS、QUIC协议的监听器支持该字段  **取值范围**：1~40 个字符。支持字母 a~z、短划线（-）、下划线（_）和数字。  **默认取值**：无
        /// </summary>
        [JsonProperty("X-Forwarded-Clientcert-ciphers-alias", NullValueHandling = NullValueHandling.Ignore)]
        public string XForwardedClientcertCiphersAlias { get; set; }

        /// <summary>
        /// **参数解释**：是否通过X-Forwarded-Clientcert-end 头字段获取客户端证书的结束日期。  **约束限制**：仅HTTPS、TERMINATED_HTTPS、QUIC协议的监听器支持该字段。  **取值范围**：true、false  **默认取值**：false
        /// </summary>
        [JsonProperty("X-Forwarded-Clientcert-end-enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? XForwardedClientcertEndEnable { get; set; }

        /// <summary>
        /// **参数解释**：自定义X-Forwarded-Clientcert-end头字段名称。  **约束限制**：只有当X-Forwarded-Clientcert-end-enable 的值为 true 时，此值才会生效。仅HTTPS、TERMINATED_HTTPS、QUIC、TLS协议的监听器支持该字段  **取值范围**：1~40 个字符。支持字母 a~z、短划线（-）、下划线（_）和数字。  **默认取值**：无
        /// </summary>
        [JsonProperty("X-Forwarded-Clientcert-end-alias", NullValueHandling = NullValueHandling.Ignore)]
        public string XForwardedClientcertEndAlias { get; set; }

        /// <summary>
        /// **参数解释**：是否通过X-Forwarded-Tls-Alpn-Protocol 头字段获取客户端和服务器之间ALPN（Application-Layer Protocol Negotiation）协商的应用层协议。  **约束限制**：仅HTTPS、TERMINATED_HTTPS、QUIC协议的监听器支持该字段。  **取值范围**：true、false  **默认取值**：false
        /// </summary>
        [JsonProperty("X-Forwarded-Tls-Alpn-Protocol-enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? XForwardedTlsAlpnProtocolEnable { get; set; }

        /// <summary>
        /// **参数解释**：自定义X-Forwarded-Tls-Alpn-Protocol头字段名称。  **约束限制**：只有当X-Forwarded-Tls-Alpn-Protocol-enable 的值为 true 时，此值才会生效。仅HTTPS、TERMINATED_HTTPS、QUIC协议的监听器支持该字段  **取值范围**：1~40 个字符。支持字母 a~z、短划线（-）、下划线（_）和数字。  **默认取值**：无
        /// </summary>
        [JsonProperty("X-Forwarded-Tls-Alpn-Protocol-alias", NullValueHandling = NullValueHandling.Ignore)]
        public string XForwardedTlsAlpnProtocolAlias { get; set; }

        /// <summary>
        /// **参数解释**：是否通过X-Forwarded-Tls-Sni 头字段获取客户端访问的sni证书的域名。  **约束限制**：仅HTTPS、TERMINATED_HTTPS、QUIC协议的监听器支持该字段。  **取值范围**：true、false  **默认取值**：false
        /// </summary>
        [JsonProperty("X-Forwarded-Tls-Sni-enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? XForwardedTlsSniEnable { get; set; }

        /// <summary>
        /// **参数解释**：自定义X-Forwarded-Tls-Sni头字段名称。  **约束限制**：只有当X-Forwarded-Tls-Sni-enable 的值为 true 时，此值才会生效。仅HTTPS、TERMINATED_HTTPS、QUIC协议的监听器支持该字段  **取值范围**：1~40 个字符。支持字母 a~z、短划线（-）、下划线（_）和数字。  **默认取值**：无
        /// </summary>
        [JsonProperty("X-Forwarded-Tls-Sni-alias", NullValueHandling = NullValueHandling.Ignore)]
        public string XForwardedTlsSniAlias { get; set; }

        /// <summary>
        /// **参数解释**：是否通过X-Forwarded-Tls-Ja3头字段获取访问负载均衡实例客户端的ja3指纹。  **约束限制**：仅HTTPS、TERMINATED_HTTPS、QUIC协议的监听器支持该字段。  **取值范围**：true、false  **默认取值**：false
        /// </summary>
        [JsonProperty("X-Forwarded-Tls-Ja3-enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? XForwardedTlsJa3Enable { get; set; }

        /// <summary>
        /// **参数解释**：自定义X-Forwarded-Tls-Ja3头字段名称。  **约束限制**：只有当X-Forwarded-Tls-Ja3-enable 的值为 true 时，此值才会生效。仅HTTPS、TERMINATED_HTTPS、QUIC协议的监听器支持该字段  **取值范围**：1~40 个字符。支持字母 a~z、短划线（-）、下划线（_）和数字。  **默认取值**：无
        /// </summary>
        [JsonProperty("X-Forwarded-Tls-Ja3-alias", NullValueHandling = NullValueHandling.Ignore)]
        public string XForwardedTlsJa3Alias { get; set; }

        /// <summary>
        /// **参数解释**：是否通过X-Forwarded-Tls-Ja4头字段获取访问负载均衡实例客户端的ja4指纹。  **约束限制**：仅HTTPS、TERMINATED_HTTPS、QUIC协议的监听器支持该字段。  **取值范围**：true、false  **默认取值**：false
        /// </summary>
        [JsonProperty("X-Forwarded-Tls-Ja4-enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? XForwardedTlsJa4Enable { get; set; }

        /// <summary>
        /// **参数解释**：自定义X-Forwarded-Tls-Ja4头字段名称。  **约束限制**：只有当X-Forwarded-Tls-Ja4-enable 的值为 true 时，此值才会生效。仅HTTPS、TERMINATED_HTTPS、QUIC协议的监听器支持该字段  **取值范围**：1~40 个字符。支持字母 a~z、短划线（-）、下划线（_）和数字。  **默认取值**：无
        /// </summary>
        [JsonProperty("X-Forwarded-Tls-Ja4-alias", NullValueHandling = NullValueHandling.Ignore)]
        public string XForwardedTlsJa4Alias { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListenerInsertHeaders {\n");
            sb.Append("  xForwardedELBIP: ").Append(XForwardedELBIP).Append("\n");
            sb.Append("  xForwardedPort: ").Append(XForwardedPort).Append("\n");
            sb.Append("  xForwardedForPort: ").Append(XForwardedForPort).Append("\n");
            sb.Append("  xForwardedHost: ").Append(XForwardedHost).Append("\n");
            sb.Append("  xForwardedProto: ").Append(XForwardedProto).Append("\n");
            sb.Append("  xRealIP: ").Append(XRealIP).Append("\n");
            sb.Append("  xForwardedELBID: ").Append(XForwardedELBID).Append("\n");
            sb.Append("  xForwardedTLSCertificateID: ").Append(XForwardedTLSCertificateID).Append("\n");
            sb.Append("  xForwardedTLSProtocol: ").Append(XForwardedTLSProtocol).Append("\n");
            sb.Append("  xForwardedTLSCipher: ").Append(XForwardedTLSCipher).Append("\n");
            sb.Append("  xForwardedTLSProtocolAlias: ").Append(XForwardedTLSProtocolAlias).Append("\n");
            sb.Append("  xForwardedTLSCipherAlias: ").Append(XForwardedTLSCipherAlias).Append("\n");
            sb.Append("  xForwardedForProcessingMode: ").Append(XForwardedForProcessingMode).Append("\n");
            sb.Append("  xForwardedClientcertSubjectdnEnable: ").Append(XForwardedClientcertSubjectdnEnable).Append("\n");
            sb.Append("  xForwardedClientcertSubjectdnAlias: ").Append(XForwardedClientcertSubjectdnAlias).Append("\n");
            sb.Append("  xForwardedClientcertIssuerdnEnable: ").Append(XForwardedClientcertIssuerdnEnable).Append("\n");
            sb.Append("  xForwardedClientcertIssuerdnAlias: ").Append(XForwardedClientcertIssuerdnAlias).Append("\n");
            sb.Append("  xForwardedClientcertFingerprintEnable: ").Append(XForwardedClientcertFingerprintEnable).Append("\n");
            sb.Append("  xForwardedClientcertFingerprintAlias: ").Append(XForwardedClientcertFingerprintAlias).Append("\n");
            sb.Append("  xForwardedClientcertClientverifyEnable: ").Append(XForwardedClientcertClientverifyEnable).Append("\n");
            sb.Append("  xForwardedClientcertClientverifyAlias: ").Append(XForwardedClientcertClientverifyAlias).Append("\n");
            sb.Append("  xForwardedClientcertSerialnumberEnable: ").Append(XForwardedClientcertSerialnumberEnable).Append("\n");
            sb.Append("  xForwardedClientcertSerialnumberAlias: ").Append(XForwardedClientcertSerialnumberAlias).Append("\n");
            sb.Append("  xForwardedClientcertEnable: ").Append(XForwardedClientcertEnable).Append("\n");
            sb.Append("  xForwardedClientcertAlias: ").Append(XForwardedClientcertAlias).Append("\n");
            sb.Append("  xForwardedClientcertCiphersEnable: ").Append(XForwardedClientcertCiphersEnable).Append("\n");
            sb.Append("  xForwardedClientcertCiphersAlias: ").Append(XForwardedClientcertCiphersAlias).Append("\n");
            sb.Append("  xForwardedClientcertEndEnable: ").Append(XForwardedClientcertEndEnable).Append("\n");
            sb.Append("  xForwardedClientcertEndAlias: ").Append(XForwardedClientcertEndAlias).Append("\n");
            sb.Append("  xForwardedTlsAlpnProtocolEnable: ").Append(XForwardedTlsAlpnProtocolEnable).Append("\n");
            sb.Append("  xForwardedTlsAlpnProtocolAlias: ").Append(XForwardedTlsAlpnProtocolAlias).Append("\n");
            sb.Append("  xForwardedTlsSniEnable: ").Append(XForwardedTlsSniEnable).Append("\n");
            sb.Append("  xForwardedTlsSniAlias: ").Append(XForwardedTlsSniAlias).Append("\n");
            sb.Append("  xForwardedTlsJa3Enable: ").Append(XForwardedTlsJa3Enable).Append("\n");
            sb.Append("  xForwardedTlsJa3Alias: ").Append(XForwardedTlsJa3Alias).Append("\n");
            sb.Append("  xForwardedTlsJa4Enable: ").Append(XForwardedTlsJa4Enable).Append("\n");
            sb.Append("  xForwardedTlsJa4Alias: ").Append(XForwardedTlsJa4Alias).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListenerInsertHeaders);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListenerInsertHeaders input)
        {
            if (input == null) return false;
            if (this.XForwardedELBIP != input.XForwardedELBIP || (this.XForwardedELBIP != null && !this.XForwardedELBIP.Equals(input.XForwardedELBIP))) return false;
            if (this.XForwardedPort != input.XForwardedPort || (this.XForwardedPort != null && !this.XForwardedPort.Equals(input.XForwardedPort))) return false;
            if (this.XForwardedForPort != input.XForwardedForPort || (this.XForwardedForPort != null && !this.XForwardedForPort.Equals(input.XForwardedForPort))) return false;
            if (this.XForwardedHost != input.XForwardedHost || (this.XForwardedHost != null && !this.XForwardedHost.Equals(input.XForwardedHost))) return false;
            if (this.XForwardedProto != input.XForwardedProto || (this.XForwardedProto != null && !this.XForwardedProto.Equals(input.XForwardedProto))) return false;
            if (this.XRealIP != input.XRealIP || (this.XRealIP != null && !this.XRealIP.Equals(input.XRealIP))) return false;
            if (this.XForwardedELBID != input.XForwardedELBID || (this.XForwardedELBID != null && !this.XForwardedELBID.Equals(input.XForwardedELBID))) return false;
            if (this.XForwardedTLSCertificateID != input.XForwardedTLSCertificateID || (this.XForwardedTLSCertificateID != null && !this.XForwardedTLSCertificateID.Equals(input.XForwardedTLSCertificateID))) return false;
            if (this.XForwardedTLSProtocol != input.XForwardedTLSProtocol || (this.XForwardedTLSProtocol != null && !this.XForwardedTLSProtocol.Equals(input.XForwardedTLSProtocol))) return false;
            if (this.XForwardedTLSCipher != input.XForwardedTLSCipher || (this.XForwardedTLSCipher != null && !this.XForwardedTLSCipher.Equals(input.XForwardedTLSCipher))) return false;
            if (this.XForwardedTLSProtocolAlias != input.XForwardedTLSProtocolAlias || (this.XForwardedTLSProtocolAlias != null && !this.XForwardedTLSProtocolAlias.Equals(input.XForwardedTLSProtocolAlias))) return false;
            if (this.XForwardedTLSCipherAlias != input.XForwardedTLSCipherAlias || (this.XForwardedTLSCipherAlias != null && !this.XForwardedTLSCipherAlias.Equals(input.XForwardedTLSCipherAlias))) return false;
            if (this.XForwardedForProcessingMode != input.XForwardedForProcessingMode) return false;
            if (this.XForwardedClientcertSubjectdnEnable != input.XForwardedClientcertSubjectdnEnable || (this.XForwardedClientcertSubjectdnEnable != null && !this.XForwardedClientcertSubjectdnEnable.Equals(input.XForwardedClientcertSubjectdnEnable))) return false;
            if (this.XForwardedClientcertSubjectdnAlias != input.XForwardedClientcertSubjectdnAlias || (this.XForwardedClientcertSubjectdnAlias != null && !this.XForwardedClientcertSubjectdnAlias.Equals(input.XForwardedClientcertSubjectdnAlias))) return false;
            if (this.XForwardedClientcertIssuerdnEnable != input.XForwardedClientcertIssuerdnEnable || (this.XForwardedClientcertIssuerdnEnable != null && !this.XForwardedClientcertIssuerdnEnable.Equals(input.XForwardedClientcertIssuerdnEnable))) return false;
            if (this.XForwardedClientcertIssuerdnAlias != input.XForwardedClientcertIssuerdnAlias || (this.XForwardedClientcertIssuerdnAlias != null && !this.XForwardedClientcertIssuerdnAlias.Equals(input.XForwardedClientcertIssuerdnAlias))) return false;
            if (this.XForwardedClientcertFingerprintEnable != input.XForwardedClientcertFingerprintEnable || (this.XForwardedClientcertFingerprintEnable != null && !this.XForwardedClientcertFingerprintEnable.Equals(input.XForwardedClientcertFingerprintEnable))) return false;
            if (this.XForwardedClientcertFingerprintAlias != input.XForwardedClientcertFingerprintAlias || (this.XForwardedClientcertFingerprintAlias != null && !this.XForwardedClientcertFingerprintAlias.Equals(input.XForwardedClientcertFingerprintAlias))) return false;
            if (this.XForwardedClientcertClientverifyEnable != input.XForwardedClientcertClientverifyEnable || (this.XForwardedClientcertClientverifyEnable != null && !this.XForwardedClientcertClientverifyEnable.Equals(input.XForwardedClientcertClientverifyEnable))) return false;
            if (this.XForwardedClientcertClientverifyAlias != input.XForwardedClientcertClientverifyAlias || (this.XForwardedClientcertClientverifyAlias != null && !this.XForwardedClientcertClientverifyAlias.Equals(input.XForwardedClientcertClientverifyAlias))) return false;
            if (this.XForwardedClientcertSerialnumberEnable != input.XForwardedClientcertSerialnumberEnable || (this.XForwardedClientcertSerialnumberEnable != null && !this.XForwardedClientcertSerialnumberEnable.Equals(input.XForwardedClientcertSerialnumberEnable))) return false;
            if (this.XForwardedClientcertSerialnumberAlias != input.XForwardedClientcertSerialnumberAlias || (this.XForwardedClientcertSerialnumberAlias != null && !this.XForwardedClientcertSerialnumberAlias.Equals(input.XForwardedClientcertSerialnumberAlias))) return false;
            if (this.XForwardedClientcertEnable != input.XForwardedClientcertEnable || (this.XForwardedClientcertEnable != null && !this.XForwardedClientcertEnable.Equals(input.XForwardedClientcertEnable))) return false;
            if (this.XForwardedClientcertAlias != input.XForwardedClientcertAlias || (this.XForwardedClientcertAlias != null && !this.XForwardedClientcertAlias.Equals(input.XForwardedClientcertAlias))) return false;
            if (this.XForwardedClientcertCiphersEnable != input.XForwardedClientcertCiphersEnable || (this.XForwardedClientcertCiphersEnable != null && !this.XForwardedClientcertCiphersEnable.Equals(input.XForwardedClientcertCiphersEnable))) return false;
            if (this.XForwardedClientcertCiphersAlias != input.XForwardedClientcertCiphersAlias || (this.XForwardedClientcertCiphersAlias != null && !this.XForwardedClientcertCiphersAlias.Equals(input.XForwardedClientcertCiphersAlias))) return false;
            if (this.XForwardedClientcertEndEnable != input.XForwardedClientcertEndEnable || (this.XForwardedClientcertEndEnable != null && !this.XForwardedClientcertEndEnable.Equals(input.XForwardedClientcertEndEnable))) return false;
            if (this.XForwardedClientcertEndAlias != input.XForwardedClientcertEndAlias || (this.XForwardedClientcertEndAlias != null && !this.XForwardedClientcertEndAlias.Equals(input.XForwardedClientcertEndAlias))) return false;
            if (this.XForwardedTlsAlpnProtocolEnable != input.XForwardedTlsAlpnProtocolEnable || (this.XForwardedTlsAlpnProtocolEnable != null && !this.XForwardedTlsAlpnProtocolEnable.Equals(input.XForwardedTlsAlpnProtocolEnable))) return false;
            if (this.XForwardedTlsAlpnProtocolAlias != input.XForwardedTlsAlpnProtocolAlias || (this.XForwardedTlsAlpnProtocolAlias != null && !this.XForwardedTlsAlpnProtocolAlias.Equals(input.XForwardedTlsAlpnProtocolAlias))) return false;
            if (this.XForwardedTlsSniEnable != input.XForwardedTlsSniEnable || (this.XForwardedTlsSniEnable != null && !this.XForwardedTlsSniEnable.Equals(input.XForwardedTlsSniEnable))) return false;
            if (this.XForwardedTlsSniAlias != input.XForwardedTlsSniAlias || (this.XForwardedTlsSniAlias != null && !this.XForwardedTlsSniAlias.Equals(input.XForwardedTlsSniAlias))) return false;
            if (this.XForwardedTlsJa3Enable != input.XForwardedTlsJa3Enable || (this.XForwardedTlsJa3Enable != null && !this.XForwardedTlsJa3Enable.Equals(input.XForwardedTlsJa3Enable))) return false;
            if (this.XForwardedTlsJa3Alias != input.XForwardedTlsJa3Alias || (this.XForwardedTlsJa3Alias != null && !this.XForwardedTlsJa3Alias.Equals(input.XForwardedTlsJa3Alias))) return false;
            if (this.XForwardedTlsJa4Enable != input.XForwardedTlsJa4Enable || (this.XForwardedTlsJa4Enable != null && !this.XForwardedTlsJa4Enable.Equals(input.XForwardedTlsJa4Enable))) return false;
            if (this.XForwardedTlsJa4Alias != input.XForwardedTlsJa4Alias || (this.XForwardedTlsJa4Alias != null && !this.XForwardedTlsJa4Alias.Equals(input.XForwardedTlsJa4Alias))) return false;

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
                if (this.XForwardedELBIP != null) hashCode = hashCode * 59 + this.XForwardedELBIP.GetHashCode();
                if (this.XForwardedPort != null) hashCode = hashCode * 59 + this.XForwardedPort.GetHashCode();
                if (this.XForwardedForPort != null) hashCode = hashCode * 59 + this.XForwardedForPort.GetHashCode();
                if (this.XForwardedHost != null) hashCode = hashCode * 59 + this.XForwardedHost.GetHashCode();
                if (this.XForwardedProto != null) hashCode = hashCode * 59 + this.XForwardedProto.GetHashCode();
                if (this.XRealIP != null) hashCode = hashCode * 59 + this.XRealIP.GetHashCode();
                if (this.XForwardedELBID != null) hashCode = hashCode * 59 + this.XForwardedELBID.GetHashCode();
                if (this.XForwardedTLSCertificateID != null) hashCode = hashCode * 59 + this.XForwardedTLSCertificateID.GetHashCode();
                if (this.XForwardedTLSProtocol != null) hashCode = hashCode * 59 + this.XForwardedTLSProtocol.GetHashCode();
                if (this.XForwardedTLSCipher != null) hashCode = hashCode * 59 + this.XForwardedTLSCipher.GetHashCode();
                if (this.XForwardedTLSProtocolAlias != null) hashCode = hashCode * 59 + this.XForwardedTLSProtocolAlias.GetHashCode();
                if (this.XForwardedTLSCipherAlias != null) hashCode = hashCode * 59 + this.XForwardedTLSCipherAlias.GetHashCode();
                hashCode = hashCode * 59 + this.XForwardedForProcessingMode.GetHashCode();
                if (this.XForwardedClientcertSubjectdnEnable != null) hashCode = hashCode * 59 + this.XForwardedClientcertSubjectdnEnable.GetHashCode();
                if (this.XForwardedClientcertSubjectdnAlias != null) hashCode = hashCode * 59 + this.XForwardedClientcertSubjectdnAlias.GetHashCode();
                if (this.XForwardedClientcertIssuerdnEnable != null) hashCode = hashCode * 59 + this.XForwardedClientcertIssuerdnEnable.GetHashCode();
                if (this.XForwardedClientcertIssuerdnAlias != null) hashCode = hashCode * 59 + this.XForwardedClientcertIssuerdnAlias.GetHashCode();
                if (this.XForwardedClientcertFingerprintEnable != null) hashCode = hashCode * 59 + this.XForwardedClientcertFingerprintEnable.GetHashCode();
                if (this.XForwardedClientcertFingerprintAlias != null) hashCode = hashCode * 59 + this.XForwardedClientcertFingerprintAlias.GetHashCode();
                if (this.XForwardedClientcertClientverifyEnable != null) hashCode = hashCode * 59 + this.XForwardedClientcertClientverifyEnable.GetHashCode();
                if (this.XForwardedClientcertClientverifyAlias != null) hashCode = hashCode * 59 + this.XForwardedClientcertClientverifyAlias.GetHashCode();
                if (this.XForwardedClientcertSerialnumberEnable != null) hashCode = hashCode * 59 + this.XForwardedClientcertSerialnumberEnable.GetHashCode();
                if (this.XForwardedClientcertSerialnumberAlias != null) hashCode = hashCode * 59 + this.XForwardedClientcertSerialnumberAlias.GetHashCode();
                if (this.XForwardedClientcertEnable != null) hashCode = hashCode * 59 + this.XForwardedClientcertEnable.GetHashCode();
                if (this.XForwardedClientcertAlias != null) hashCode = hashCode * 59 + this.XForwardedClientcertAlias.GetHashCode();
                if (this.XForwardedClientcertCiphersEnable != null) hashCode = hashCode * 59 + this.XForwardedClientcertCiphersEnable.GetHashCode();
                if (this.XForwardedClientcertCiphersAlias != null) hashCode = hashCode * 59 + this.XForwardedClientcertCiphersAlias.GetHashCode();
                if (this.XForwardedClientcertEndEnable != null) hashCode = hashCode * 59 + this.XForwardedClientcertEndEnable.GetHashCode();
                if (this.XForwardedClientcertEndAlias != null) hashCode = hashCode * 59 + this.XForwardedClientcertEndAlias.GetHashCode();
                if (this.XForwardedTlsAlpnProtocolEnable != null) hashCode = hashCode * 59 + this.XForwardedTlsAlpnProtocolEnable.GetHashCode();
                if (this.XForwardedTlsAlpnProtocolAlias != null) hashCode = hashCode * 59 + this.XForwardedTlsAlpnProtocolAlias.GetHashCode();
                if (this.XForwardedTlsSniEnable != null) hashCode = hashCode * 59 + this.XForwardedTlsSniEnable.GetHashCode();
                if (this.XForwardedTlsSniAlias != null) hashCode = hashCode * 59 + this.XForwardedTlsSniAlias.GetHashCode();
                if (this.XForwardedTlsJa3Enable != null) hashCode = hashCode * 59 + this.XForwardedTlsJa3Enable.GetHashCode();
                if (this.XForwardedTlsJa3Alias != null) hashCode = hashCode * 59 + this.XForwardedTlsJa3Alias.GetHashCode();
                if (this.XForwardedTlsJa4Enable != null) hashCode = hashCode * 59 + this.XForwardedTlsJa4Enable.GetHashCode();
                if (this.XForwardedTlsJa4Alias != null) hashCode = hashCode * 59 + this.XForwardedTlsJa4Alias.GetHashCode();
                return hashCode;
            }
        }
    }
}
