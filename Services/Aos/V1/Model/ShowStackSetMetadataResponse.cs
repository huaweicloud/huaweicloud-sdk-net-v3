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
    /// Response Object
    /// </summary>
    public class ShowStackSetMetadataResponse : SdkResponse
    {
        /// <summary>
        /// 权限模型，定义了RFS操作资源栈集时所需委托的创建方式，枚举值，默认为SELF_MANAGED。用户可以使用创建资源栈集（CreateStackSet）API 指定该参数。该参数暂不支持更新。用户如果想要更新权限模型，可以通过先删除再创建同名资源栈集实现。   * &#x60;SELF_MANAGED&#x60; - 自我管理，基于部署需求，用户需要提前手动创建委托，既包含管理账号授权给RFS的委托，也包含成员账号授权给管理账号的委托。如果委托不存在或权限不足，创建资源栈集不会失败，创建资源栈实例时才会报错。   * &#x60;SERVICE_MANAGED&#x60; - 服务管理，基于Organization服务，RFS会自动创建部署Organization 成员账号时所需的全部 IAM 委托。用户需要提前在Organization可信服务列表中将”资源编排资源栈集服务“启用，且只有Organization的管理账号或”资源编排资源栈集服务“的委托管理员，才允许指定SERVICE_MANAGED创建资源栈集，否则会报错。
        /// </summary>
        /// <value>权限模型，定义了RFS操作资源栈集时所需委托的创建方式，枚举值，默认为SELF_MANAGED。用户可以使用创建资源栈集（CreateStackSet）API 指定该参数。该参数暂不支持更新。用户如果想要更新权限模型，可以通过先删除再创建同名资源栈集实现。   * &#x60;SELF_MANAGED&#x60; - 自我管理，基于部署需求，用户需要提前手动创建委托，既包含管理账号授权给RFS的委托，也包含成员账号授权给管理账号的委托。如果委托不存在或权限不足，创建资源栈集不会失败，创建资源栈实例时才会报错。   * &#x60;SERVICE_MANAGED&#x60; - 服务管理，基于Organization服务，RFS会自动创建部署Organization 成员账号时所需的全部 IAM 委托。用户需要提前在Organization可信服务列表中将”资源编排资源栈集服务“启用，且只有Organization的管理账号或”资源编排资源栈集服务“的委托管理员，才允许指定SERVICE_MANAGED创建资源栈集，否则会报错。</value>
        [JsonConverter(typeof(EnumClassConverter<PermissionModelEnum>))]
        public class PermissionModelEnum
        {
            /// <summary>
            /// Enum SELF_MANAGED for value: SELF_MANAGED
            /// </summary>
            public static readonly PermissionModelEnum SELF_MANAGED = new PermissionModelEnum("SELF_MANAGED");

            /// <summary>
            /// Enum SERVICE_MANAGED for value: SERVICE_MANAGED
            /// </summary>
            public static readonly PermissionModelEnum SERVICE_MANAGED = new PermissionModelEnum("SERVICE_MANAGED");

            private static readonly Dictionary<string, PermissionModelEnum> StaticFields =
            new Dictionary<string, PermissionModelEnum>()
            {
                { "SELF_MANAGED", SELF_MANAGED },
                { "SERVICE_MANAGED", SERVICE_MANAGED },
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
        /// 资源栈集的状态     * &#x60;IDLE&#x60; - 资源栈集空闲 * &#x60;OPERATION_IN_PROGRESS&#x60; - 资源栈集操作中 * &#x60;DEACTIVATED&#x60; - 资源栈集禁用
        /// </summary>
        /// <value>资源栈集的状态     * &#x60;IDLE&#x60; - 资源栈集空闲 * &#x60;OPERATION_IN_PROGRESS&#x60; - 资源栈集操作中 * &#x60;DEACTIVATED&#x60; - 资源栈集禁用</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum IDLE for value: IDLE
            /// </summary>
            public static readonly StatusEnum IDLE = new StatusEnum("IDLE");

            /// <summary>
            /// Enum OPERATION_IN_PROGRESS for value: OPERATION_IN_PROGRESS
            /// </summary>
            public static readonly StatusEnum OPERATION_IN_PROGRESS = new StatusEnum("OPERATION_IN_PROGRESS");

            /// <summary>
            /// Enum DEACTIVATED for value: DEACTIVATED
            /// </summary>
            public static readonly StatusEnum DEACTIVATED = new StatusEnum("DEACTIVATED");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "IDLE", IDLE },
                { "OPERATION_IN_PROGRESS", OPERATION_IN_PROGRESS },
                { "DEACTIVATED", DEACTIVATED },
            };

            private string _value;

            public StatusEnum()
            {

            }

            public StatusEnum(string value)
            {
                _value = value;
            }

            public static StatusEnum FromValue(string value)
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

                if (this.Equals(obj as StatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
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
        /// 资源栈集（stack_set）的名字。此名字在domain_id+region下应唯一，可以使用中文、大小写英文、数字、下划线、中划线。首字符需为中文或者英文，区分大小写。
        /// </summary>
        [JsonProperty("stack_set_name", NullValueHandling = NullValueHandling.Ignore)]
        public string StackSetName { get; set; }

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
        /// 权限模型，定义了RFS操作资源栈集时所需委托的创建方式，枚举值，默认为SELF_MANAGED。用户可以使用创建资源栈集（CreateStackSet）API 指定该参数。该参数暂不支持更新。用户如果想要更新权限模型，可以通过先删除再创建同名资源栈集实现。   * &#x60;SELF_MANAGED&#x60; - 自我管理，基于部署需求，用户需要提前手动创建委托，既包含管理账号授权给RFS的委托，也包含成员账号授权给管理账号的委托。如果委托不存在或权限不足，创建资源栈集不会失败，创建资源栈实例时才会报错。   * &#x60;SERVICE_MANAGED&#x60; - 服务管理，基于Organization服务，RFS会自动创建部署Organization 成员账号时所需的全部 IAM 委托。用户需要提前在Organization可信服务列表中将”资源编排资源栈集服务“启用，且只有Organization的管理账号或”资源编排资源栈集服务“的委托管理员，才允许指定SERVICE_MANAGED创建资源栈集，否则会报错。
        /// </summary>
        [JsonProperty("permission_model", NullValueHandling = NullValueHandling.Ignore)]
        public PermissionModelEnum PermissionModel { get; set; }
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
        /// 资源栈集的状态     * &#x60;IDLE&#x60; - 资源栈集空闲 * &#x60;OPERATION_IN_PROGRESS&#x60; - 资源栈集操作中 * &#x60;DEACTIVATED&#x60; - 资源栈集禁用
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// vars_uri对应的文件内容
        /// </summary>
        [JsonProperty("vars_uri_content", NullValueHandling = NullValueHandling.Ignore)]
        public string VarsUriContent { get; set; }

        /// <summary>
        /// HCL参数文件的内容。HCL模板支持参数传入，即，同一个模板可以给予不同的参数而达到不同的效果。  * vars_body使用HCL的tfvars格式，用户可以将“.tfvars”中的内容提交到vars_body中  * 资源编排服务支持vars_body和vars_uri，如果以上两种方式中声明了同一个变量，将报错400  * 如果vars_body过大，可以使用vars_uri  * 资源栈集不支持敏感数据加密，资源编排服务会直接明文使用、log、展示、存储对应的vars_body。
        /// </summary>
        [JsonProperty("vars_body", NullValueHandling = NullValueHandling.Ignore)]
        public string VarsBody { get; set; }

        /// <summary>
        /// 资源栈集的创建时间，格式为YYYY-MM-DDTHH:mm:ss.SSSZ，精确到毫秒，UTC时区，即，如1970-01-01T00:00:00.000Z。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 资源栈集的更新时间，格式为YYYY-MM-DDTHH:mm:ss.SSSZ，精确到毫秒，UTC时区，即，如1970-01-01T00:00:00.000Z。
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

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
        /// 组织单元（Organizational Unit，缩写OU）ID列表，仅在资源栈集权限模型是SERVICE_MANAGED时，才允许指定该参数。  用户指定的Organization组织部署的ID列表，可以是根组织（Root）ID，也可以是某些组织单元的ID。  创建资源栈实例 （CreateStackInstances）API 必须指定该参数，该API 会异步校验OU IDs 的合法性，校验有效的OU IDs 及其所有非空子OU ID 都会被资源栈集记录管理。该API允许指定没有或者已经被资源栈集管理的OU IDs。   * 若资源栈集不自动部署，空子OU不会被资源栈集记录管理（特指子OU下无成员账号或部署排除其下所有成员账号）。*   * 【暂不支持】若资源栈集开启自动部署，空子OU也会被资源栈集记录管理（特指子OU下无成员账号或部署排除其下所有成员账号），自动部署仅针对成员账号变动，不针对其他组织结构变化，例如新增OU等，新增OU不会自动被资源栈集管理。*  部署或删除资源栈实例（DeployStackSet、UpdateStackInstances、DeleteStackInstances） API，只允许指定已经被资源栈集管理的OU IDs。若指定了没有被资源栈集记录管理的OU IDs，则会报错。  删除资源栈实例 （DeleteStackInstances）API 必须指定该参数。  用户可以通过获取资源栈集元数据（ShowStackSetMetadata）API ，获取通过创建资源栈实例（CreateStackInstances）API 请求指定过的OU IDs。  资源栈集不仅会部署到目标 OU 中的用户，同时还会部署所有子 OU 下的用户。指定该参数后，资源栈集会根据用户输入的 OU 列表下所有的用户信息（包含子 OU 下的用户）和region列表，以笛卡尔积的形式，选择资源栈实例进行创建或部署。  *资源栈集不会选择组织管理员作为部署目标，进行资源栈实例的创建或部署，即使组织管理员位于给与的组织或组织的 OU 中。*
        /// </summary>
        [JsonProperty("organizational_unit_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> OrganizationalUnitIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowStackSetMetadataResponse {\n");
            sb.Append("  stackSetId: ").Append(StackSetId).Append("\n");
            sb.Append("  stackSetName: ").Append(StackSetName).Append("\n");
            sb.Append("  stackSetDescription: ").Append(StackSetDescription).Append("\n");
            sb.Append("  initialStackDescription: ").Append(InitialStackDescription).Append("\n");
            sb.Append("  permissionModel: ").Append(PermissionModel).Append("\n");
            sb.Append("  administrationAgencyName: ").Append(AdministrationAgencyName).Append("\n");
            sb.Append("  managedAgencyName: ").Append(ManagedAgencyName).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  varsUriContent: ").Append(VarsUriContent).Append("\n");
            sb.Append("  varsBody: ").Append(VarsBody).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  administrationAgencyUrn: ").Append(AdministrationAgencyUrn).Append("\n");
            sb.Append("  managedOperation: ").Append(ManagedOperation).Append("\n");
            sb.Append("  organizationalUnitIds: ").Append(OrganizationalUnitIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowStackSetMetadataResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowStackSetMetadataResponse input)
        {
            if (input == null) return false;
            if (this.StackSetId != input.StackSetId || (this.StackSetId != null && !this.StackSetId.Equals(input.StackSetId))) return false;
            if (this.StackSetName != input.StackSetName || (this.StackSetName != null && !this.StackSetName.Equals(input.StackSetName))) return false;
            if (this.StackSetDescription != input.StackSetDescription || (this.StackSetDescription != null && !this.StackSetDescription.Equals(input.StackSetDescription))) return false;
            if (this.InitialStackDescription != input.InitialStackDescription || (this.InitialStackDescription != null && !this.InitialStackDescription.Equals(input.InitialStackDescription))) return false;
            if (this.PermissionModel != input.PermissionModel) return false;
            if (this.AdministrationAgencyName != input.AdministrationAgencyName || (this.AdministrationAgencyName != null && !this.AdministrationAgencyName.Equals(input.AdministrationAgencyName))) return false;
            if (this.ManagedAgencyName != input.ManagedAgencyName || (this.ManagedAgencyName != null && !this.ManagedAgencyName.Equals(input.ManagedAgencyName))) return false;
            if (this.Status != input.Status) return false;
            if (this.VarsUriContent != input.VarsUriContent || (this.VarsUriContent != null && !this.VarsUriContent.Equals(input.VarsUriContent))) return false;
            if (this.VarsBody != input.VarsBody || (this.VarsBody != null && !this.VarsBody.Equals(input.VarsBody))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.AdministrationAgencyUrn != input.AdministrationAgencyUrn || (this.AdministrationAgencyUrn != null && !this.AdministrationAgencyUrn.Equals(input.AdministrationAgencyUrn))) return false;
            if (this.ManagedOperation != input.ManagedOperation || (this.ManagedOperation != null && !this.ManagedOperation.Equals(input.ManagedOperation))) return false;
            if (this.OrganizationalUnitIds != input.OrganizationalUnitIds || (this.OrganizationalUnitIds != null && input.OrganizationalUnitIds != null && !this.OrganizationalUnitIds.SequenceEqual(input.OrganizationalUnitIds))) return false;

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
                if (this.StackSetName != null) hashCode = hashCode * 59 + this.StackSetName.GetHashCode();
                if (this.StackSetDescription != null) hashCode = hashCode * 59 + this.StackSetDescription.GetHashCode();
                if (this.InitialStackDescription != null) hashCode = hashCode * 59 + this.InitialStackDescription.GetHashCode();
                hashCode = hashCode * 59 + this.PermissionModel.GetHashCode();
                if (this.AdministrationAgencyName != null) hashCode = hashCode * 59 + this.AdministrationAgencyName.GetHashCode();
                if (this.ManagedAgencyName != null) hashCode = hashCode * 59 + this.ManagedAgencyName.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.VarsUriContent != null) hashCode = hashCode * 59 + this.VarsUriContent.GetHashCode();
                if (this.VarsBody != null) hashCode = hashCode * 59 + this.VarsBody.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.AdministrationAgencyUrn != null) hashCode = hashCode * 59 + this.AdministrationAgencyUrn.GetHashCode();
                if (this.ManagedOperation != null) hashCode = hashCode * 59 + this.ManagedOperation.GetHashCode();
                if (this.OrganizationalUnitIds != null) hashCode = hashCode * 59 + this.OrganizationalUnitIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
