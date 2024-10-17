using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aos.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListStackSetsRequest 
    {
        /// <summary>
        /// Defines sortKey
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<SortKeyEnum>))]
        public class SortKeyEnum
        {
            /// <summary>
            /// Enum CREATE_TIME for value: create_time
            /// </summary>
            public static readonly SortKeyEnum CREATE_TIME = new SortKeyEnum("create_time");

            private static readonly Dictionary<string, SortKeyEnum> StaticFields =
            new Dictionary<string, SortKeyEnum>()
            {
                { "create_time", CREATE_TIME },
            };

            private string _value;

            public SortKeyEnum()
            {

            }

            public SortKeyEnum(string value)
            {
                _value = value;
            }

            public static SortKeyEnum FromValue(string value)
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

                if (this.Equals(obj as SortKeyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SortKeyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SortKeyEnum a, SortKeyEnum b)
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

            public static bool operator !=(SortKeyEnum a, SortKeyEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// Defines sortDir
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<SortDirEnum>))]
        public class SortDirEnum
        {
            /// <summary>
            /// Enum ASC for value: asc
            /// </summary>
            public static readonly SortDirEnum ASC = new SortDirEnum("asc");

            /// <summary>
            /// Enum DESC for value: desc
            /// </summary>
            public static readonly SortDirEnum DESC = new SortDirEnum("desc");

            private static readonly Dictionary<string, SortDirEnum> StaticFields =
            new Dictionary<string, SortDirEnum>()
            {
                { "asc", ASC },
                { "desc", DESC },
            };

            private string _value;

            public SortDirEnum()
            {

            }

            public SortDirEnum(string value)
            {
                _value = value;
            }

            public static SortDirEnum FromValue(string value)
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

                if (this.Equals(obj as SortDirEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SortDirEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SortDirEnum a, SortDirEnum b)
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

            public static bool operator !=(SortDirEnum a, SortDirEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 仅支持资源栈集权限模式为SERVICE_MANAGED时指定该参数。用于指定用户是以组织管理账号还是成员帐户中的服务委托管理员身份调用资源栈集。默认为SELF。 * 无论指定何种用户身份，创建或部署的资源栈集始终在组织管理账号名下。*   * &#x60;SELF&#x60; - 以组织管理账号身份调用。   * &#x60;DELEGATED_ADMIN&#x60; - 以服务委托管理员身份调用。用户的华为云账号必须在组织中已经被注册为”资源编排资源栈集服务“的委托管理员。
        /// </summary>
        /// <value>仅支持资源栈集权限模式为SERVICE_MANAGED时指定该参数。用于指定用户是以组织管理账号还是成员帐户中的服务委托管理员身份调用资源栈集。默认为SELF。 * 无论指定何种用户身份，创建或部署的资源栈集始终在组织管理账号名下。*   * &#x60;SELF&#x60; - 以组织管理账号身份调用。   * &#x60;DELEGATED_ADMIN&#x60; - 以服务委托管理员身份调用。用户的华为云账号必须在组织中已经被注册为”资源编排资源栈集服务“的委托管理员。</value>
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

            public static bool operator !=(CallIdentityEnum a, CallIdentityEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 用户指定的，对于此请求的唯一ID，用于定位某个请求，推荐使用UUID
        /// </summary>
        [SDKProperty("Client-Request-Id", IsHeader = true)]
        [JsonProperty("Client-Request-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientRequestId { get; set; }

        /// <summary>
        /// 过滤条件  * 与（AND）运算符使用逗号（，）定义 * 或（OR）运算符使用竖线（|）定义，OR运算符优先级高于AND运算符 * 不支持括号 * 过滤运算符仅支持双等号（&#x3D;&#x3D;） * 过滤参数名及其值仅支持包含大小写英文、数字和下划线 * 过滤条件中禁止使用分号，如果有分号，则此条过滤会被忽略 * 一个过滤参数仅能与一个与条件相关，一个与条件中的多个或条件仅能与一个过滤参数相关
        /// </summary>
        [SDKProperty("filter", IsQuery = true)]
        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public string Filter { get; set; }

        /// <summary>
        /// 排序字段，仅支持给予create_time
        /// </summary>
        [SDKProperty("sort_key", IsQuery = true)]
        [JsonProperty("sort_key", NullValueHandling = NullValueHandling.Ignore)]
        public List<SortKeyEnum> SortKey { get; set; }
        /// <summary>
        /// 指定升序还是降序   * &#x60;asc&#x60; - 升序   * &#x60;desc&#x60; - 降序
        /// </summary>
        [SDKProperty("sort_dir", IsQuery = true)]
        [JsonProperty("sort_dir", NullValueHandling = NullValueHandling.Ignore)]
        public List<SortDirEnum> SortDir { get; set; }
        /// <summary>
        /// 仅支持资源栈集权限模式为SERVICE_MANAGED时指定该参数。用于指定用户是以组织管理账号还是成员帐户中的服务委托管理员身份调用资源栈集。默认为SELF。 * 无论指定何种用户身份，创建或部署的资源栈集始终在组织管理账号名下。*   * &#x60;SELF&#x60; - 以组织管理账号身份调用。   * &#x60;DELEGATED_ADMIN&#x60; - 以服务委托管理员身份调用。用户的华为云账号必须在组织中已经被注册为”资源编排资源栈集服务“的委托管理员。
        /// </summary>
        [SDKProperty("call_identity", IsQuery = true)]
        [JsonProperty("call_identity", NullValueHandling = NullValueHandling.Ignore)]
        public CallIdentityEnum CallIdentity { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListStackSetsRequest {\n");
            sb.Append("  clientRequestId: ").Append(ClientRequestId).Append("\n");
            sb.Append("  filter: ").Append(Filter).Append("\n");
            sb.Append("  sortKey: ").Append(SortKey).Append("\n");
            sb.Append("  sortDir: ").Append(SortDir).Append("\n");
            sb.Append("  callIdentity: ").Append(CallIdentity).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListStackSetsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListStackSetsRequest input)
        {
            if (input == null) return false;
            if (this.ClientRequestId != input.ClientRequestId || (this.ClientRequestId != null && !this.ClientRequestId.Equals(input.ClientRequestId))) return false;
            if (this.Filter != input.Filter || (this.Filter != null && !this.Filter.Equals(input.Filter))) return false;
            if (this.SortKey != input.SortKey || (this.SortKey != null && input.SortKey != null && !this.SortKey.SequenceEqual(input.SortKey))) return false;
            if (this.SortDir != input.SortDir || (this.SortDir != null && input.SortDir != null && !this.SortDir.SequenceEqual(input.SortDir))) return false;
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
                if (this.ClientRequestId != null) hashCode = hashCode * 59 + this.ClientRequestId.GetHashCode();
                if (this.Filter != null) hashCode = hashCode * 59 + this.Filter.GetHashCode();
                hashCode = hashCode * 59 + this.SortKey.GetHashCode();
                hashCode = hashCode * 59 + this.SortDir.GetHashCode();
                hashCode = hashCode * 59 + this.CallIdentity.GetHashCode();
                return hashCode;
            }
        }
    }
}
