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
    public class UpdateStackSetRequestBody 
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
        /// 资源栈集（stack_set）的唯一ID。  此ID由资源编排服务在生成资源栈集的时候生成，为UUID。  由于资源栈集名仅仅在同一时间下唯一，即用户允许先生成一个叫HelloWorld的资源栈集，删除，再重新创建一个同名资源栈集。  对于团队并行开发，用户可能希望确保，当前我操作的资源栈集就是我以为的那个，而不是被其他队友删除后创建的同名资源栈集。因此，使用ID就可以做到强匹配。  资源编排服务保证每次创建的资源栈集所对应的ID都不相同，更新不会影响ID。如果给予的stack_set_id和当前资源栈集的ID不一致，则返回400
        /// </summary>
        [JsonProperty("stack_set_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StackSetId { get; set; }

        /// <summary>
        /// 资源栈集的描述。可用于客户识别自己的资源栈集。
        /// </summary>
        [JsonProperty("stack_set_description", NullValueHandling = NullValueHandling.Ignore)]
        public string StackSetDescription { get; set; }

        /// <summary>
        /// 初始化资源栈描述。可用于客户识别被资源栈集所管理的资源栈。  资源栈集下的资源栈仅在创建时统一使用该描述。客户想要更新初始化资源栈描述，可以通过UpdateStackSet API。  后续更新资源栈集描述将不会同步更新已管理的资源栈描述。
        /// </summary>
        [JsonProperty("initial_stack_description", NullValueHandling = NullValueHandling.Ignore)]
        public string InitialStackDescription { get; set; }

        /// <summary>
        /// 管理委托名称  资源编排服务使用该委托获取成员账号委托给管理账号的权限。该委托中必须含有iam:tokens:assume权限，用以后续获取被管理委托凭证。如果不包含，则会在新增或者部署实例时报错。  当用户定义SELF_MANAGED权限类型时，administration_agency_name和administration_agency_urn 必须有且只有一个存在。  推荐用户在使用信任委托时给予administration_agency_urn，administration_agency_name只支持接收委托名称，如果给予了信任委托名称，则会在部署模板时失败。  当用户使用SERVICE_MANAGED权限类型时，指定该参数将报错400。  [[创建委托及授权方式](https://support.huaweicloud.com/usermanual-iam/iam_06_0002.html)](tag:hws) [[创建委托及授权方式](https://support.huaweicloud.com/intl/zh-cn/usermanual-iam/iam_06_0002.html)](tag:hws_hk) [[创建委托及授权方式](https://support.huaweicloud.com/eu/usermanual-iam/iam_06_0002.html)](tag:hws_eu)
        /// </summary>
        [JsonProperty("administration_agency_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AdministrationAgencyName { get; set; }

        /// <summary>
        /// 被管理的委托名称。  资源编排服务会使用该委托获取实际部署资源所需要的权限  不同成员账号委托给管理账号的委托名称需要保持一致。暂不支持根据不同provider定义不同委托权限  当用户定义SELF_MANAGED权限类型时，必须指定该参数。当用户使用SERVICE_MANAGED权限类型时，指定该参数将报错400  [[创建委托及授权方式](https://support.huaweicloud.com/usermanual-iam/iam_06_0002.html)](tag:hws) [[创建委托及授权方式](https://support.huaweicloud.com/intl/zh-cn/usermanual-iam/iam_06_0002.html)](tag:hws_hk) [[创建委托及授权方式](https://support.huaweicloud.com/eu/usermanual-iam/iam_06_0002.html)](tag:hws_eu)
        /// </summary>
        [JsonProperty("managed_agency_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ManagedAgencyName { get; set; }

        /// <summary>
        /// 管理委托URN  资源编排服务使用该委托获取成员账号委托给管理账号的权限。该委托中必须含有sts:tokens:assume权限，用以后续获取被管理委托凭证。如果不包含，则会在新增或者部署实例时报错。  当用户定义SELF_MANAGED权限类型时，administration_agency_name和administration_agency_urn 必须有且只有一个存在。  推荐用户在使用信任委托时给予administration_agency_urn，administration_agency_name只支持接收委托名称，如果给予了信任委托名称，则会在部署模板时失败。  当用户使用SERVICE_MANAGED权限类型时，指定该参数将报错400。
        /// </summary>
        [JsonProperty("administration_agency_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string AdministrationAgencyUrn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("managed_operation", NullValueHandling = NullValueHandling.Ignore)]
        public ManagedOperation ManagedOperation { get; set; }

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
            sb.Append("class UpdateStackSetRequestBody {\n");
            sb.Append("  stackSetId: ").Append(StackSetId).Append("\n");
            sb.Append("  stackSetDescription: ").Append(StackSetDescription).Append("\n");
            sb.Append("  initialStackDescription: ").Append(InitialStackDescription).Append("\n");
            sb.Append("  administrationAgencyName: ").Append(AdministrationAgencyName).Append("\n");
            sb.Append("  managedAgencyName: ").Append(ManagedAgencyName).Append("\n");
            sb.Append("  administrationAgencyUrn: ").Append(AdministrationAgencyUrn).Append("\n");
            sb.Append("  managedOperation: ").Append(ManagedOperation).Append("\n");
            sb.Append("  callIdentity: ").Append(CallIdentity).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateStackSetRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateStackSetRequestBody input)
        {
            if (input == null) return false;
            if (this.StackSetId != input.StackSetId || (this.StackSetId != null && !this.StackSetId.Equals(input.StackSetId))) return false;
            if (this.StackSetDescription != input.StackSetDescription || (this.StackSetDescription != null && !this.StackSetDescription.Equals(input.StackSetDescription))) return false;
            if (this.InitialStackDescription != input.InitialStackDescription || (this.InitialStackDescription != null && !this.InitialStackDescription.Equals(input.InitialStackDescription))) return false;
            if (this.AdministrationAgencyName != input.AdministrationAgencyName || (this.AdministrationAgencyName != null && !this.AdministrationAgencyName.Equals(input.AdministrationAgencyName))) return false;
            if (this.ManagedAgencyName != input.ManagedAgencyName || (this.ManagedAgencyName != null && !this.ManagedAgencyName.Equals(input.ManagedAgencyName))) return false;
            if (this.AdministrationAgencyUrn != input.AdministrationAgencyUrn || (this.AdministrationAgencyUrn != null && !this.AdministrationAgencyUrn.Equals(input.AdministrationAgencyUrn))) return false;
            if (this.ManagedOperation != input.ManagedOperation || (this.ManagedOperation != null && !this.ManagedOperation.Equals(input.ManagedOperation))) return false;
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
                if (this.StackSetId != null) hashCode = hashCode * 59 + this.StackSetId.GetHashCode();
                if (this.StackSetDescription != null) hashCode = hashCode * 59 + this.StackSetDescription.GetHashCode();
                if (this.InitialStackDescription != null) hashCode = hashCode * 59 + this.InitialStackDescription.GetHashCode();
                if (this.AdministrationAgencyName != null) hashCode = hashCode * 59 + this.AdministrationAgencyName.GetHashCode();
                if (this.ManagedAgencyName != null) hashCode = hashCode * 59 + this.ManagedAgencyName.GetHashCode();
                if (this.AdministrationAgencyUrn != null) hashCode = hashCode * 59 + this.AdministrationAgencyUrn.GetHashCode();
                if (this.ManagedOperation != null) hashCode = hashCode * 59 + this.ManagedOperation.GetHashCode();
                hashCode = hashCode * 59 + this.CallIdentity.GetHashCode();
                return hashCode;
            }
        }
    }
}
