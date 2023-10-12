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
    /// 
    /// </summary>
    public class UpdateStackSetRequestBody 
    {
        /// <summary>
        /// 权限模型，定义了RFS操作资源栈集时所需委托的创建方式，枚举值     * &#x60;SERVICE_MANAGED&#x60; - 用户在自己的Organization中将RFS设置为可信服务后，才可以使用此种模式创建资源栈集。用户不需要手动创建委托，基于Organization，RFS会自动帮用户创建委托。只有Organization组织管理员或委托管理员才可以在SERVICE_MANAGED下创建资源栈集。     * &#x60;SELF_MANAGED&#x60; - 基于部署需求，用户需要提前手动创建委托，既包含管理账号给RFS的委托，也包含成员账号创建给管理账号的委托。如果委托不存在或错误，创建资源栈集不会失败，部署资源栈集或部署资源栈实例的时候才会报错。
        /// </summary>
        /// <value>权限模型，定义了RFS操作资源栈集时所需委托的创建方式，枚举值     * &#x60;SERVICE_MANAGED&#x60; - 用户在自己的Organization中将RFS设置为可信服务后，才可以使用此种模式创建资源栈集。用户不需要手动创建委托，基于Organization，RFS会自动帮用户创建委托。只有Organization组织管理员或委托管理员才可以在SERVICE_MANAGED下创建资源栈集。     * &#x60;SELF_MANAGED&#x60; - 基于部署需求，用户需要提前手动创建委托，既包含管理账号给RFS的委托，也包含成员账号创建给管理账号的委托。如果委托不存在或错误，创建资源栈集不会失败，部署资源栈集或部署资源栈实例的时候才会报错。</value>
        [JsonConverter(typeof(EnumClassConverter<PermissionModelEnum>))]
        public class PermissionModelEnum
        {
            /// <summary>
            /// Enum SELF_MANAGED for value: SELF_MANAGED
            /// </summary>
            public static readonly PermissionModelEnum SELF_MANAGED = new PermissionModelEnum("SELF_MANAGED");

            private static readonly Dictionary<string, PermissionModelEnum> StaticFields =
            new Dictionary<string, PermissionModelEnum>()
            {
                { "SELF_MANAGED", SELF_MANAGED },
            };

            private string _value;

            public PermissionModelEnum()
            {

            }

            public PermissionModelEnum(string value)
            {
                _value = value;
            }

            public static PermissionModelEnum FromValue(string value)
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

                if (this.Equals(obj as PermissionModelEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PermissionModelEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PermissionModelEnum a, PermissionModelEnum b)
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

            public static bool operator !=(PermissionModelEnum a, PermissionModelEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 资源栈集（stack_set）的唯一ID。  此ID由资源编排服务在生成资源栈的时候生成，为UUID。  由于资源栈集名仅仅在同一时间下唯一，即用户允许先生成一个叫HelloWorld的资源栈集，删除，在重新创建一个同名资源栈集。  对于团队并行开发，用户可能希望确保，当前我操作的资源栈集就是我以为的那个，而不是又其他队友删除后创建的同名资源栈集。因此，使用ID就可以做到强匹配。  资源编排服务保证每次创建的资源栈集所对应的ID都不相同，更新不会影响ID。如果给与的stack_set_id和当前资源栈集的ID不一致，则返回400
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
        /// 权限模型，定义了RFS操作资源栈集时所需委托的创建方式，枚举值     * &#x60;SERVICE_MANAGED&#x60; - 用户在自己的Organization中将RFS设置为可信服务后，才可以使用此种模式创建资源栈集。用户不需要手动创建委托，基于Organization，RFS会自动帮用户创建委托。只有Organization组织管理员或委托管理员才可以在SERVICE_MANAGED下创建资源栈集。     * &#x60;SELF_MANAGED&#x60; - 基于部署需求，用户需要提前手动创建委托，既包含管理账号给RFS的委托，也包含成员账号创建给管理账号的委托。如果委托不存在或错误，创建资源栈集不会失败，部署资源栈集或部署资源栈实例的时候才会报错。
        /// </summary>
        [JsonProperty("permission_model", NullValueHandling = NullValueHandling.Ignore)]
        public PermissionModelEnum PermissionModel { get; set; }
        /// <summary>
        /// 管理委托名称  资源编排服务使用该委托获取成员账号委托给管理账号的权限  当用户定义SELF_MANAGED权限类型时，administration_agency_name和administration_agency_urn 必须有且只有一个存在。  推荐用户在使用v5委托时给与administration_agency_urn，administration_agency_name只支持接收v3委托名称，若给与了v5委托名称，则会在部署模板时失败。  当用户使用SERVICE_MANAGED权限类型时，指定该参数将报错400。
        /// </summary>
        [JsonProperty("administration_agency_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AdministrationAgencyName { get; set; }

        /// <summary>
        /// 被管理的委托名称。  资源编排服务会使用该委托获取实际部署资源所需要的权限  不同成员账号委托给管理账号的委托名称需要保持一致。暂不支持根据不同provider定义不同委托权限  当用户定义SELF_MANAGED权限类型时，必须指定该参数。当用户使用SERVICE_MANAGED权限类型时，指定该参数将报错400
        /// </summary>
        [JsonProperty("managed_agency_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ManagedAgencyName { get; set; }

        /// <summary>
        /// 管理委托URN  资源编排服务使用该委托获取成员账号委托给管理账号的权限  当用户定义SELF_MANAGED权限类型时，administration_agency_name和administration_agency_urn 必须有且只有一个存在。  推荐用户在使用v5委托时给与administration_agency_urn，administration_agency_name只支持接收普通委托名称，若给与了v5委托名称，则会在部署模板时失败。  当用户使用SERVICE_MANAGED权限类型时，指定该参数将报错400。
        /// </summary>
        [JsonProperty("administration_agency_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string AdministrationAgencyUrn { get; set; }



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
            sb.Append("  permissionModel: ").Append(PermissionModel).Append("\n");
            sb.Append("  administrationAgencyName: ").Append(AdministrationAgencyName).Append("\n");
            sb.Append("  managedAgencyName: ").Append(ManagedAgencyName).Append("\n");
            sb.Append("  administrationAgencyUrn: ").Append(AdministrationAgencyUrn).Append("\n");
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
            if (input == null)
                return false;

            return 
                (
                    this.StackSetId == input.StackSetId ||
                    (this.StackSetId != null &&
                    this.StackSetId.Equals(input.StackSetId))
                ) && 
                (
                    this.StackSetDescription == input.StackSetDescription ||
                    (this.StackSetDescription != null &&
                    this.StackSetDescription.Equals(input.StackSetDescription))
                ) && 
                (
                    this.InitialStackDescription == input.InitialStackDescription ||
                    (this.InitialStackDescription != null &&
                    this.InitialStackDescription.Equals(input.InitialStackDescription))
                ) && 
                (
                    this.PermissionModel == input.PermissionModel ||
                    (this.PermissionModel != null &&
                    this.PermissionModel.Equals(input.PermissionModel))
                ) && 
                (
                    this.AdministrationAgencyName == input.AdministrationAgencyName ||
                    (this.AdministrationAgencyName != null &&
                    this.AdministrationAgencyName.Equals(input.AdministrationAgencyName))
                ) && 
                (
                    this.ManagedAgencyName == input.ManagedAgencyName ||
                    (this.ManagedAgencyName != null &&
                    this.ManagedAgencyName.Equals(input.ManagedAgencyName))
                ) && 
                (
                    this.AdministrationAgencyUrn == input.AdministrationAgencyUrn ||
                    (this.AdministrationAgencyUrn != null &&
                    this.AdministrationAgencyUrn.Equals(input.AdministrationAgencyUrn))
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
                if (this.StackSetId != null)
                    hashCode = hashCode * 59 + this.StackSetId.GetHashCode();
                if (this.StackSetDescription != null)
                    hashCode = hashCode * 59 + this.StackSetDescription.GetHashCode();
                if (this.InitialStackDescription != null)
                    hashCode = hashCode * 59 + this.InitialStackDescription.GetHashCode();
                if (this.PermissionModel != null)
                    hashCode = hashCode * 59 + this.PermissionModel.GetHashCode();
                if (this.AdministrationAgencyName != null)
                    hashCode = hashCode * 59 + this.AdministrationAgencyName.GetHashCode();
                if (this.ManagedAgencyName != null)
                    hashCode = hashCode * 59 + this.ManagedAgencyName.GetHashCode();
                if (this.AdministrationAgencyUrn != null)
                    hashCode = hashCode * 59 + this.AdministrationAgencyUrn.GetHashCode();
                return hashCode;
            }
        }
    }
}
