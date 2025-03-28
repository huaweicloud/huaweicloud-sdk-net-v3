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
    /// 部署目标信息。
    /// </summary>
    public class DeploymentTargets 
    {
        /// <summary>
        /// 租户ID筛选类型，仅支持资源栈集权限模型是SERVICE_MANAGED时指定该参数。默认为NONE  用户可以指定不同的筛选类型，通过domain_ids或domain_ids_uri 指定或排除部署的用户信息，以增加或限制部署目标用户范围，实现不同的部署策略。     * &#x60;INTERSECTION&#x60; - 从所提供的 OUs 中选择指定用户进行部署。指定该类型时，domain_ids和domain_ids_uri 有且仅能有一个存在。    * &#x60;DIFFERENCE&#x60; - 从所提供的 OUs 中排除指定用户部署。指定该类型时，domain_ids和domain_ids_uri 有且仅能有一个存在。    * &#x60;UNION&#x60; - 除了部署到提供的 OUs 外，还将部署到指定的账号中。用户可以通过同时指定organizational_unit_ids 和 domain_ids/domain_ids_uri 以实现在同一请求中部署整个OU和来自不同OU的特定个人账号。指定该类型时，domain_ids和domain_ids_uri 有且仅能有一个存在。创建资源栈实例（CreateStackInstances）除外，该API 不允许指定使用该类型。    * &#x60;NONE&#x60; - 只部署在指定 OUs 中的所有账号。该类型下domain_ids和domain_ids_uri字段必须为空。
        /// </summary>
        /// <value>租户ID筛选类型，仅支持资源栈集权限模型是SERVICE_MANAGED时指定该参数。默认为NONE  用户可以指定不同的筛选类型，通过domain_ids或domain_ids_uri 指定或排除部署的用户信息，以增加或限制部署目标用户范围，实现不同的部署策略。     * &#x60;INTERSECTION&#x60; - 从所提供的 OUs 中选择指定用户进行部署。指定该类型时，domain_ids和domain_ids_uri 有且仅能有一个存在。    * &#x60;DIFFERENCE&#x60; - 从所提供的 OUs 中排除指定用户部署。指定该类型时，domain_ids和domain_ids_uri 有且仅能有一个存在。    * &#x60;UNION&#x60; - 除了部署到提供的 OUs 外，还将部署到指定的账号中。用户可以通过同时指定organizational_unit_ids 和 domain_ids/domain_ids_uri 以实现在同一请求中部署整个OU和来自不同OU的特定个人账号。指定该类型时，domain_ids和domain_ids_uri 有且仅能有一个存在。创建资源栈实例（CreateStackInstances）除外，该API 不允许指定使用该类型。    * &#x60;NONE&#x60; - 只部署在指定 OUs 中的所有账号。该类型下domain_ids和domain_ids_uri字段必须为空。</value>
        [JsonConverter(typeof(EnumClassConverter<DomainIdFilterTypeEnum>))]
        public class DomainIdFilterTypeEnum
        {
            /// <summary>
            /// Enum INTERSECTION for value: INTERSECTION
            /// </summary>
            public static readonly DomainIdFilterTypeEnum INTERSECTION = new DomainIdFilterTypeEnum("INTERSECTION");

            /// <summary>
            /// Enum DIFFERENCE for value: DIFFERENCE
            /// </summary>
            public static readonly DomainIdFilterTypeEnum DIFFERENCE = new DomainIdFilterTypeEnum("DIFFERENCE");

            /// <summary>
            /// Enum UNION for value: UNION
            /// </summary>
            public static readonly DomainIdFilterTypeEnum UNION = new DomainIdFilterTypeEnum("UNION");

            /// <summary>
            /// Enum NONE for value: NONE
            /// </summary>
            public static readonly DomainIdFilterTypeEnum NONE = new DomainIdFilterTypeEnum("NONE");

            private static readonly Dictionary<string, DomainIdFilterTypeEnum> StaticFields =
            new Dictionary<string, DomainIdFilterTypeEnum>()
            {
                { "INTERSECTION", INTERSECTION },
                { "DIFFERENCE", DIFFERENCE },
                { "UNION", UNION },
                { "NONE", NONE },
            };

            private string _value;

            public DomainIdFilterTypeEnum()
            {

            }

            public DomainIdFilterTypeEnum(string value)
            {
                _value = value;
            }

            public static DomainIdFilterTypeEnum FromValue(string value)
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

                if (this.Equals(obj as DomainIdFilterTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DomainIdFilterTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DomainIdFilterTypeEnum a, DomainIdFilterTypeEnum b)
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

            public static bool operator !=(DomainIdFilterTypeEnum a, DomainIdFilterTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 用户指定资源栈集操作所涉及的区域。  *在DeployStackSet API中，根据用户输入regions和domain_ids列表，以笛卡尔积的形式选择资源栈集中存在的资源栈实例进行部署。如果指定了没有被资源栈集所管理的region，则会报错。*
        /// </summary>
        [JsonProperty("regions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Regions { get; set; }

        /// <summary>
        /// 当资源栈集权限模型是SELF_MANAGED时，用户指定包含本次操作涉及到的租户ID内容。  *在DeployStackSet API中，如果指定该参数，根据用户输入的domain_ids列表和regions列表，以笛卡尔积的形式选择资源栈集中存在的资源栈实例进行部署。如果指定了没有被资源栈集所管理的domain_id，则会报错。*  当资源栈集权限模型是SERVICE_MANAGED时，该参数需结合domain_id_filter_type使用。用于指定资源栈集操作涉及到的，从所提供的OU中指定或排除部署的租户ID信息，或除提供的OU外，还进行额外部署的租户ID信息。  domain_ids和domain_ids_uri 有且仅有一个存在。
        /// </summary>
        [JsonProperty("domain_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DomainIds { get; set; }

        /// <summary>
        /// 当资源栈集权限模型是SELF_MANAGED时，用户指定包含本次操作涉及到的租户ID内容文件的OBS地址。  内容格式要求每个租户ID以逗号（,）分隔，支持换行。当前仅支持csv文件，且文件的编码格式须为UTF-8。文件内容大小不超过100KB。  上传的csv文件应尽量避免Excel操作，以防出现读取内容不一致的问题。推荐使用记事本打开确认内容是否符合预期。  *在DeployStackSet API中，如果指定该参数，根据用户输入的domain_ids_uri文件内容和regions列表，以笛卡尔积的形式选择资源栈集中存在的资源栈实例进行部署。如果内容包含了没有被资源栈集所管理的domain_id，则会报错。*  当资源栈集权限模型是SERVICE_MANAGED时，该参数需结合domain_id_filter_type使用。链接文件内容用于指定资源栈集操作涉及到的，从所提供的OU中指定或排除部署的租户ID信息，或除提供的OU外，还进行额外部署的租户ID信息。  domain_ids和domain_ids_uri有且仅有一个存在。
        /// </summary>
        [JsonProperty("domain_ids_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainIdsUri { get; set; }

        /// <summary>
        /// 组织单元（Organizational Unit，缩写OU）ID列表，仅在资源栈集权限模型是SERVICE_MANAGED时，才允许指定该参数。  用户指定的Organization组织部署的ID列表，可以是根组织（Root）ID，也可以是某些组织单元的ID。  创建资源栈实例 （CreateStackInstances）API 必须指定该参数，该API 会异步校验OU IDs 的合法性，校验有效的OU IDs 及其所有非空子OU ID 都会被资源栈集记录管理。该API允许指定没有或者已经被资源栈集管理的OU IDs。   * 若资源栈集不自动部署，空子OU不会被资源栈集记录管理（特指子OU下无成员账号或部署排除其下所有成员账号）。*   * 【暂不支持】若资源栈集开启自动部署，空子OU也会被资源栈集记录管理（特指子OU下无成员账号或部署排除其下所有成员账号），自动部署仅针对成员账号变动，不针对其他组织结构变化，例如新增OU等，新增OU不会自动被资源栈集管理。*  部署或删除资源栈实例（DeployStackSet、UpdateStackInstances、DeleteStackInstances） API，只允许指定已经被资源栈集管理的OU IDs。若指定了没有被资源栈集记录管理的OU IDs，则会报错。  删除资源栈实例 （DeleteStackInstances）API 必须指定该参数。  用户可以通过获取资源栈集元数据（ShowStackSetMetadata）API ，获取通过创建资源栈实例（CreateStackInstances）API 请求指定过的OU IDs。  资源栈集不仅会部署到目标 OU 中的用户，同时还会部署所有子 OU 下的用户。指定该参数后，资源栈集会根据用户输入的 OU 列表下所有的用户信息（包含子 OU 下的用户）和region列表，以笛卡尔积的形式，选择资源栈实例进行创建或部署。  *资源栈集不会选择组织管理员作为部署目标，进行资源栈实例的创建或部署，即使组织管理员位于给与的组织或组织的 OU 中。*
        /// </summary>
        [JsonProperty("organizational_unit_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> OrganizationalUnitIds { get; set; }

        /// <summary>
        /// 租户ID筛选类型，仅支持资源栈集权限模型是SERVICE_MANAGED时指定该参数。默认为NONE  用户可以指定不同的筛选类型，通过domain_ids或domain_ids_uri 指定或排除部署的用户信息，以增加或限制部署目标用户范围，实现不同的部署策略。     * &#x60;INTERSECTION&#x60; - 从所提供的 OUs 中选择指定用户进行部署。指定该类型时，domain_ids和domain_ids_uri 有且仅能有一个存在。    * &#x60;DIFFERENCE&#x60; - 从所提供的 OUs 中排除指定用户部署。指定该类型时，domain_ids和domain_ids_uri 有且仅能有一个存在。    * &#x60;UNION&#x60; - 除了部署到提供的 OUs 外，还将部署到指定的账号中。用户可以通过同时指定organizational_unit_ids 和 domain_ids/domain_ids_uri 以实现在同一请求中部署整个OU和来自不同OU的特定个人账号。指定该类型时，domain_ids和domain_ids_uri 有且仅能有一个存在。创建资源栈实例（CreateStackInstances）除外，该API 不允许指定使用该类型。    * &#x60;NONE&#x60; - 只部署在指定 OUs 中的所有账号。该类型下domain_ids和domain_ids_uri字段必须为空。
        /// </summary>
        [JsonProperty("domain_id_filter_type", NullValueHandling = NullValueHandling.Ignore)]
        public DomainIdFilterTypeEnum DomainIdFilterType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeploymentTargets {\n");
            sb.Append("  regions: ").Append(Regions).Append("\n");
            sb.Append("  domainIds: ").Append(DomainIds).Append("\n");
            sb.Append("  domainIdsUri: ").Append(DomainIdsUri).Append("\n");
            sb.Append("  organizationalUnitIds: ").Append(OrganizationalUnitIds).Append("\n");
            sb.Append("  domainIdFilterType: ").Append(DomainIdFilterType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeploymentTargets);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeploymentTargets input)
        {
            if (input == null) return false;
            if (this.Regions != input.Regions || (this.Regions != null && input.Regions != null && !this.Regions.SequenceEqual(input.Regions))) return false;
            if (this.DomainIds != input.DomainIds || (this.DomainIds != null && input.DomainIds != null && !this.DomainIds.SequenceEqual(input.DomainIds))) return false;
            if (this.DomainIdsUri != input.DomainIdsUri || (this.DomainIdsUri != null && !this.DomainIdsUri.Equals(input.DomainIdsUri))) return false;
            if (this.OrganizationalUnitIds != input.OrganizationalUnitIds || (this.OrganizationalUnitIds != null && input.OrganizationalUnitIds != null && !this.OrganizationalUnitIds.SequenceEqual(input.OrganizationalUnitIds))) return false;
            if (this.DomainIdFilterType != input.DomainIdFilterType) return false;

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
                if (this.Regions != null) hashCode = hashCode * 59 + this.Regions.GetHashCode();
                if (this.DomainIds != null) hashCode = hashCode * 59 + this.DomainIds.GetHashCode();
                if (this.DomainIdsUri != null) hashCode = hashCode * 59 + this.DomainIdsUri.GetHashCode();
                if (this.OrganizationalUnitIds != null) hashCode = hashCode * 59 + this.OrganizationalUnitIds.GetHashCode();
                hashCode = hashCode * 59 + this.DomainIdFilterType.GetHashCode();
                return hashCode;
            }
        }
    }
}
