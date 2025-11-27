using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rfs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CallIdentityPrimitiveTypeHolder 
    {
        /// <summary>
        /// 仅支持资源栈集权限模式为SERVICE_MANAGED时指定该参数。用于指定用户是以组织管理账号还是成员账号中的服务委托管理员身份调用资源栈集。默认为SELF。 当资源栈集权限模式为SELF_MANAGED时，默认为SELF。  无论指定何种用户身份，涉及操作的资源栈集始终在组织管理账号名下。   * &#x60;SELF&#x60; - 以组织管理账号身份调用。   * &#x60;DELEGATED_ADMIN&#x60; - 以服务委托管理员身份调用。用户的华为云账号必须在组织中已经被注册为”资源编排资源栈集服务“的委托管理员。
        /// </summary>
        /// <value>仅支持资源栈集权限模式为SERVICE_MANAGED时指定该参数。用于指定用户是以组织管理账号还是成员账号中的服务委托管理员身份调用资源栈集。默认为SELF。 当资源栈集权限模式为SELF_MANAGED时，默认为SELF。  无论指定何种用户身份，涉及操作的资源栈集始终在组织管理账号名下。   * &#x60;SELF&#x60; - 以组织管理账号身份调用。   * &#x60;DELEGATED_ADMIN&#x60; - 以服务委托管理员身份调用。用户的华为云账号必须在组织中已经被注册为”资源编排资源栈集服务“的委托管理员。</value>
        [JsonConverter(typeof(EnumClassConverter<CallIdentityEnum>))]
        public class CallIdentityEnum
        {
            /// <summary>
            /// Enum SELF for value: SELF
            /// </summary>
            public static readonly CallIdentityEnum SELF = new CallIdentityEnum("SELF");

            /// <summary>
            /// Enum DELEGATED_ADMIN for value: DELEGATED_ADMIN
            /// </summary>
            public static readonly CallIdentityEnum DELEGATED_ADMIN = new CallIdentityEnum("DELEGATED_ADMIN");

            private static readonly Dictionary<string, CallIdentityEnum> StaticFields =
            new Dictionary<string, CallIdentityEnum>()
            {
                { "SELF", SELF },
                { "DELEGATED_ADMIN", DELEGATED_ADMIN },
            };

            private string _value;

            public CallIdentityEnum()
            {

            }

            public CallIdentityEnum(string value)
            {
                _value = value;
            }

            public static CallIdentityEnum FromValue(string value)
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

                if (this.Equals(obj as CallIdentityEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CallIdentityEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CallIdentityEnum a, CallIdentityEnum b)
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

            public static bool operator !=(CallIdentityEnum a, CallIdentityEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 仅支持资源栈集权限模式为SERVICE_MANAGED时指定该参数。用于指定用户是以组织管理账号还是成员账号中的服务委托管理员身份调用资源栈集。默认为SELF。 当资源栈集权限模式为SELF_MANAGED时，默认为SELF。  无论指定何种用户身份，涉及操作的资源栈集始终在组织管理账号名下。   * &#x60;SELF&#x60; - 以组织管理账号身份调用。   * &#x60;DELEGATED_ADMIN&#x60; - 以服务委托管理员身份调用。用户的华为云账号必须在组织中已经被注册为”资源编排资源栈集服务“的委托管理员。
        /// </summary>
        [JsonProperty("call_identity", NullValueHandling = NullValueHandling.Ignore)]
        public CallIdentityEnum CallIdentity { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CallIdentityPrimitiveTypeHolder {\n");
            sb.Append("  callIdentity: ").Append(CallIdentity).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CallIdentityPrimitiveTypeHolder);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CallIdentityPrimitiveTypeHolder input)
        {
            if (input == null) return false;
            if (this.CallIdentity != input.CallIdentity) return false;

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
                hashCode = hashCode * 59 + this.CallIdentity.GetHashCode();
                return hashCode;
            }
        }
    }
}
