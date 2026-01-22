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
    /// **参数解释**：会话持久性对象。  **约束限制**：慢启动与会话保持不能同时开启。若都开启则会导致会话保持失效。 [荷兰region不支持该字段，请勿使用。](tag:dt)
    /// </summary>
    public class UpdatePoolSessionPersistenceOption 
    {
        /// <summary>
        /// **参数解释**：会话保持类型。  [**约束限制**： - 当pool的protocol为TCP、UDP，无论type取值如何，都会被忽略，会话保持只按SOURCE_IP生效。 - 当pool的protocol为HTTP、HTTPS时。type可以为HTTP_COOKIE和APP_COOKIE，其他取值会话保持失效。 - 若pool的protocol为QUIC，则必须开启session_persistence且type为SOURCE_IP。 ](tag:hws,hws_hk,ocb,ctc,hcs,g42,tm,cmcc,hk_g42,hws_ocb,hk_vdf,srg,fcs,dt)  [**约束限制**： - 当pool的protocol为TCP、UDP，无论type取值如何，都会被忽略，会话保持只按SOURCE_IP生效。 - 当pool的protocol为HTTP、HTTPS时。type只能为HTTP_COOKIE，其他取值会话保持失效。](tag:hws_eu,hcso_dt)  **取值范围**： - SOURCE_IP：基于源IP地址的会话保持，也就是根据客户端的源IP地址将流量持续转发到同一后端服务器（member）。 - HTTP_COOKIE：通过在HTTP响应中插入一个特殊的Cookie，实现会话保持。负载均衡会在后续请求中识别该Cookie，并将请求转发到对应的后端服务器。 - APP_COOKIE：基于应用层Cookie的会话保持。与HTTP_COOKIE不同的是，APP_COOKIE要求后端服务在响应中插入一个指定名称的Cookie，负载均衡器识别后，将后续请求转发到相同后端member。  **默认取值**：不涉及  [不支持QUIC。](tag:tm,hws_eu,g42,hk_g42,hcso_dt)  [荷兰region不支持QUIC。](tag:dt)
        /// </summary>
        /// <value>**参数解释**：会话保持类型。  [**约束限制**： - 当pool的protocol为TCP、UDP，无论type取值如何，都会被忽略，会话保持只按SOURCE_IP生效。 - 当pool的protocol为HTTP、HTTPS时。type可以为HTTP_COOKIE和APP_COOKIE，其他取值会话保持失效。 - 若pool的protocol为QUIC，则必须开启session_persistence且type为SOURCE_IP。 ](tag:hws,hws_hk,ocb,ctc,hcs,g42,tm,cmcc,hk_g42,hws_ocb,hk_vdf,srg,fcs,dt)  [**约束限制**： - 当pool的protocol为TCP、UDP，无论type取值如何，都会被忽略，会话保持只按SOURCE_IP生效。 - 当pool的protocol为HTTP、HTTPS时。type只能为HTTP_COOKIE，其他取值会话保持失效。](tag:hws_eu,hcso_dt)  **取值范围**： - SOURCE_IP：基于源IP地址的会话保持，也就是根据客户端的源IP地址将流量持续转发到同一后端服务器（member）。 - HTTP_COOKIE：通过在HTTP响应中插入一个特殊的Cookie，实现会话保持。负载均衡会在后续请求中识别该Cookie，并将请求转发到对应的后端服务器。 - APP_COOKIE：基于应用层Cookie的会话保持。与HTTP_COOKIE不同的是，APP_COOKIE要求后端服务在响应中插入一个指定名称的Cookie，负载均衡器识别后，将后续请求转发到相同后端member。  **默认取值**：不涉及  [不支持QUIC。](tag:tm,hws_eu,g42,hk_g42,hcso_dt)  [荷兰region不支持QUIC。](tag:dt)</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum SOURCE_IP for value: SOURCE_IP
            /// </summary>
            public static readonly TypeEnum SOURCE_IP = new TypeEnum("SOURCE_IP");

            /// <summary>
            /// Enum HTTP_COOKIE for value: HTTP_COOKIE
            /// </summary>
            public static readonly TypeEnum HTTP_COOKIE = new TypeEnum("HTTP_COOKIE");

            /// <summary>
            /// Enum APP_COOKIE for value: APP_COOKIE
            /// </summary>
            public static readonly TypeEnum APP_COOKIE = new TypeEnum("APP_COOKIE");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "SOURCE_IP", SOURCE_IP },
                { "HTTP_COOKIE", HTTP_COOKIE },
                { "APP_COOKIE", APP_COOKIE },
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
        /// **参数解释**：cookie名称。  **约束限制**： - 只有当type为APP_COOKIE时才有效。其他情况下传该字段会报错。 - 网关型LB，不支持该特性，请勿使用。  **取值范围**：最大长度1024个字符。  **默认取值**：不涉及  [不支持该字段，请勿使用。](tag:hws_eu,hcso_dt)
        /// </summary>
        [JsonProperty("cookie_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CookieName { get; set; }

        /// <summary>
        /// **参数解释**：会话保持类型。  [**约束限制**： - 当pool的protocol为TCP、UDP，无论type取值如何，都会被忽略，会话保持只按SOURCE_IP生效。 - 当pool的protocol为HTTP、HTTPS时。type可以为HTTP_COOKIE和APP_COOKIE，其他取值会话保持失效。 - 若pool的protocol为QUIC，则必须开启session_persistence且type为SOURCE_IP。 ](tag:hws,hws_hk,ocb,ctc,hcs,g42,tm,cmcc,hk_g42,hws_ocb,hk_vdf,srg,fcs,dt)  [**约束限制**： - 当pool的protocol为TCP、UDP，无论type取值如何，都会被忽略，会话保持只按SOURCE_IP生效。 - 当pool的protocol为HTTP、HTTPS时。type只能为HTTP_COOKIE，其他取值会话保持失效。](tag:hws_eu,hcso_dt)  **取值范围**： - SOURCE_IP：基于源IP地址的会话保持，也就是根据客户端的源IP地址将流量持续转发到同一后端服务器（member）。 - HTTP_COOKIE：通过在HTTP响应中插入一个特殊的Cookie，实现会话保持。负载均衡会在后续请求中识别该Cookie，并将请求转发到对应的后端服务器。 - APP_COOKIE：基于应用层Cookie的会话保持。与HTTP_COOKIE不同的是，APP_COOKIE要求后端服务在响应中插入一个指定名称的Cookie，负载均衡器识别后，将后续请求转发到相同后端member。  **默认取值**：不涉及  [不支持QUIC。](tag:tm,hws_eu,g42,hk_g42,hcso_dt)  [荷兰region不支持QUIC。](tag:dt)
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// **参数解释**：会话保持的时间。  **约束限制**：当type为APP_COOKIE时不生效。  **取值范围**： - 如果pool的protocol为TCP、UDP和QUIC，则范围为[1,60]（分钟）。 - 如果pool的protocol为HTTP和HTTPS，则范围为[1,1440]（分钟）。  **默认取值**：不涉及 [不支持QUIC。](tag:tm,hws_eu,g42,hk_g42,hcso_dt)  [荷兰region不支持QUIC。](tag:dt)
        /// </summary>
        [JsonProperty("persistence_timeout", NullValueHandling = NullValueHandling.Ignore)]
        public int? PersistenceTimeout { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdatePoolSessionPersistenceOption {\n");
            sb.Append("  cookieName: ").Append(CookieName).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  persistenceTimeout: ").Append(PersistenceTimeout).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdatePoolSessionPersistenceOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdatePoolSessionPersistenceOption input)
        {
            if (input == null) return false;
            if (this.CookieName != input.CookieName || (this.CookieName != null && !this.CookieName.Equals(input.CookieName))) return false;
            if (this.Type != input.Type) return false;
            if (this.PersistenceTimeout != input.PersistenceTimeout || (this.PersistenceTimeout != null && !this.PersistenceTimeout.Equals(input.PersistenceTimeout))) return false;

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
                if (this.CookieName != null) hashCode = hashCode * 59 + this.CookieName.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.PersistenceTimeout != null) hashCode = hashCode * 59 + this.PersistenceTimeout.GetHashCode();
                return hashCode;
            }
        }
    }
}
