using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V2.Model
{
    /// <summary>
    /// 后端云服务器组的会话持久性。 当开启会话保持后，在一定时间内，来自同一客户端的请求会发送到同一个后端云服务器上。 当会话保持关闭时，该字段取值为null。
    /// </summary>
    public class SessionPersistence 
    {
        /// <summary>
        /// 会话保持的类型。SOURCE_IP：根据请求的源IP，将同一IP的请求发送到同一个后端云服务器上。HTTP_COOKIE：客户端第一次发送请求时，负载均衡器自动生成cookie并将该cookie插入响应消息中，后续请求会发送到处理第一个请求的后端云服务器上。APP_COOKIE：客户端第一次发送请求时，后端服务器生成cookie并将该cookie插入响应消息中，后续请求会发送到处理第一个请求的后端云服务器上。当后端云服务器的protocol为TCP时，只按SOURCE_IP生效当后端云服务器的protocol为HTTP时，只按HTTP_COOKIE或APP_COOKIE生效
        /// </summary>
        /// <value>会话保持的类型。SOURCE_IP：根据请求的源IP，将同一IP的请求发送到同一个后端云服务器上。HTTP_COOKIE：客户端第一次发送请求时，负载均衡器自动生成cookie并将该cookie插入响应消息中，后续请求会发送到处理第一个请求的后端云服务器上。APP_COOKIE：客户端第一次发送请求时，后端服务器生成cookie并将该cookie插入响应消息中，后续请求会发送到处理第一个请求的后端云服务器上。当后端云服务器的protocol为TCP时，只按SOURCE_IP生效当后端云服务器的protocol为HTTP时，只按HTTP_COOKIE或APP_COOKIE生效</value>
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
        /// 会话保持的类型。SOURCE_IP：根据请求的源IP，将同一IP的请求发送到同一个后端云服务器上。HTTP_COOKIE：客户端第一次发送请求时，负载均衡器自动生成cookie并将该cookie插入响应消息中，后续请求会发送到处理第一个请求的后端云服务器上。APP_COOKIE：客户端第一次发送请求时，后端服务器生成cookie并将该cookie插入响应消息中，后续请求会发送到处理第一个请求的后端云服务器上。当后端云服务器的protocol为TCP时，只按SOURCE_IP生效当后端云服务器的protocol为HTTP时，只按HTTP_COOKIE或APP_COOKIE生效
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// cookie的名称。只有当会话保持的类型是APP_COOKIE时可以指定。
        /// </summary>
        [JsonProperty("cookie_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CookieName { get; set; }

        /// <summary>
        /// 会话保持的超时时间。取值范围：[1,60]（分钟）：当后端云服务器的protocol为TCP、UDP时[1,1440]（分钟）：当后端云服务器的protocol为HTTP时。当type为APP_COOKIE时该字段不生效。
        /// </summary>
        [JsonProperty("persistence_timeout", NullValueHandling = NullValueHandling.Ignore)]
        public int? PersistenceTimeout { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SessionPersistence {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  cookieName: ").Append(CookieName).Append("\n");
            sb.Append("  persistenceTimeout: ").Append(PersistenceTimeout).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SessionPersistence);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SessionPersistence input)
        {
            if (input == null) return false;
            if (this.Type != input.Type) return false;
            if (this.CookieName != input.CookieName || (this.CookieName != null && !this.CookieName.Equals(input.CookieName))) return false;
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
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.CookieName != null) hashCode = hashCode * 59 + this.CookieName.GetHashCode();
                if (this.PersistenceTimeout != null) hashCode = hashCode * 59 + this.PersistenceTimeout.GetHashCode();
                return hashCode;
            }
        }
    }
}
