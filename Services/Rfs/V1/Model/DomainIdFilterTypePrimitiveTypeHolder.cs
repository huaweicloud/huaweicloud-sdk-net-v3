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
    public class DomainIdFilterTypePrimitiveTypeHolder 
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

            public static bool operator !=(DomainIdFilterTypeEnum a, DomainIdFilterTypeEnum b)
            {
                return !(a == b);
            }
        }


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
            sb.Append("class DomainIdFilterTypePrimitiveTypeHolder {\n");
            sb.Append("  domainIdFilterType: ").Append(DomainIdFilterType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DomainIdFilterTypePrimitiveTypeHolder);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DomainIdFilterTypePrimitiveTypeHolder input)
        {
            if (input == null) return false;
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
                hashCode = hashCode * 59 + this.DomainIdFilterType.GetHashCode();
                return hashCode;
            }
        }
    }
}
