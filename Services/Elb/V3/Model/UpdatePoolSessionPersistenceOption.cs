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
    /// 会话持久性对象。
    /// </summary>
    public class UpdatePoolSessionPersistenceOption 
    {
        /// <summary>
        /// 会话保持类型。  取值范围：SOURCE_IP、HTTP_COOKIE、APP_COOKIE。  [使用说明： - 当pool的protocol为TCP、UDP，无论type取值如何，都会被忽略，会话保持只按SOURCE_IP生效。 - 当pool的protocol为HTTP、HTTPS时。如果是独享型负载均衡器的pool， 则type只能为HTTP_COOKIE，其他取值会话保持失效。 如果是共享型负载均衡器的pool，则type可以为HTTP_COOKIE和APP_COOKIE，其他取值会话保持失效。 ](tag:hws,hws_hk,ocb,ctc,hcs,g42,tm,cmcc,hk_g42,hws_ocb,fcs,dt)  [使用说明： - 当pool的protocol为TCP、UDP，无论type取值如何，都会被忽略，会话保持只按SOURCE_IP生效。 - 当pool的protocol为HTTP、HTTPS时。type只能为HTTP_COOKIE， 其他取值会话保持失效。](tag:hws_eu,hcso_dt)
        /// </summary>
        /// <value>会话保持类型。  取值范围：SOURCE_IP、HTTP_COOKIE、APP_COOKIE。  [使用说明： - 当pool的protocol为TCP、UDP，无论type取值如何，都会被忽略，会话保持只按SOURCE_IP生效。 - 当pool的protocol为HTTP、HTTPS时。如果是独享型负载均衡器的pool， 则type只能为HTTP_COOKIE，其他取值会话保持失效。 如果是共享型负载均衡器的pool，则type可以为HTTP_COOKIE和APP_COOKIE，其他取值会话保持失效。 ](tag:hws,hws_hk,ocb,ctc,hcs,g42,tm,cmcc,hk_g42,hws_ocb,fcs,dt)  [使用说明： - 当pool的protocol为TCP、UDP，无论type取值如何，都会被忽略，会话保持只按SOURCE_IP生效。 - 当pool的protocol为HTTP、HTTPS时。type只能为HTTP_COOKIE， 其他取值会话保持失效。](tag:hws_eu,hcso_dt)</value>
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
        /// cookie名称。  格式：仅支持字母、数字、中划线(-)、下划线(_)和点号(.)。  使用说明： - 只有当type为APP_COOKIE时才有效。其他情况下传该字段会报错。  [不支持该字段，请勿使用。](tag:hws_eu,hcso_dt)
        /// </summary>
        [JsonProperty("cookie_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CookieName { get; set; }

        /// <summary>
        /// 会话保持类型。  取值范围：SOURCE_IP、HTTP_COOKIE、APP_COOKIE。  [使用说明： - 当pool的protocol为TCP、UDP，无论type取值如何，都会被忽略，会话保持只按SOURCE_IP生效。 - 当pool的protocol为HTTP、HTTPS时。如果是独享型负载均衡器的pool， 则type只能为HTTP_COOKIE，其他取值会话保持失效。 如果是共享型负载均衡器的pool，则type可以为HTTP_COOKIE和APP_COOKIE，其他取值会话保持失效。 ](tag:hws,hws_hk,ocb,ctc,hcs,g42,tm,cmcc,hk_g42,hws_ocb,fcs,dt)  [使用说明： - 当pool的protocol为TCP、UDP，无论type取值如何，都会被忽略，会话保持只按SOURCE_IP生效。 - 当pool的protocol为HTTP、HTTPS时。type只能为HTTP_COOKIE， 其他取值会话保持失效。](tag:hws_eu,hcso_dt)
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 会话保持的时间。当type为APP_COOKIE时不生效。  适用范围：如果pool的protocol为TCP、UDP和QUIC则范围为[1,60]（分钟），默认值1； 如果pool的protocol为HTTP和HTTPS则范围为[1,1440]（分钟），默认值1440。
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
            if (input == null)
                return false;

            return 
                (
                    this.CookieName == input.CookieName ||
                    (this.CookieName != null &&
                    this.CookieName.Equals(input.CookieName))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.PersistenceTimeout == input.PersistenceTimeout ||
                    (this.PersistenceTimeout != null &&
                    this.PersistenceTimeout.Equals(input.PersistenceTimeout))
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
                if (this.CookieName != null)
                    hashCode = hashCode * 59 + this.CookieName.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.PersistenceTimeout != null)
                    hashCode = hashCode * 59 + this.PersistenceTimeout.GetHashCode();
                return hashCode;
            }
        }
    }
}
