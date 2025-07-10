using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rgc.V1.Model
{
    /// <summary>
    /// 设置Landing Zone的参数。
    /// </summary>
    public class SetupLandingZoneReqBody 
    {
        /// <summary>
        /// 设置Landing Zone的类型。包括CREATE、REPAIR以及UPDATE。
        /// </summary>
        /// <value>设置Landing Zone的类型。包括CREATE、REPAIR以及UPDATE。</value>
        [JsonConverter(typeof(EnumClassConverter<SetupLandingZoneActionTypeEnum>))]
        public class SetupLandingZoneActionTypeEnum
        {
            /// <summary>
            /// Enum CREATE for value: CREATE
            /// </summary>
            public static readonly SetupLandingZoneActionTypeEnum CREATE = new SetupLandingZoneActionTypeEnum("CREATE");

            /// <summary>
            /// Enum UPDATE for value: UPDATE
            /// </summary>
            public static readonly SetupLandingZoneActionTypeEnum UPDATE = new SetupLandingZoneActionTypeEnum("UPDATE");

            /// <summary>
            /// Enum REPAIR for value: REPAIR
            /// </summary>
            public static readonly SetupLandingZoneActionTypeEnum REPAIR = new SetupLandingZoneActionTypeEnum("REPAIR");

            private static readonly Dictionary<string, SetupLandingZoneActionTypeEnum> StaticFields =
            new Dictionary<string, SetupLandingZoneActionTypeEnum>()
            {
                { "CREATE", CREATE },
                { "UPDATE", UPDATE },
                { "REPAIR", REPAIR },
            };

            private string _value;

            public SetupLandingZoneActionTypeEnum()
            {

            }

            public SetupLandingZoneActionTypeEnum(string value)
            {
                _value = value;
            }

            public static SetupLandingZoneActionTypeEnum FromValue(string value)
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

                if (this.Equals(obj as SetupLandingZoneActionTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SetupLandingZoneActionTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SetupLandingZoneActionTypeEnum a, SetupLandingZoneActionTypeEnum b)
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

            public static bool operator !=(SetupLandingZoneActionTypeEnum a, SetupLandingZoneActionTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 是否设置Landing Zone的identity center。
        /// </summary>
        /// <value>是否设置Landing Zone的identity center。</value>
        [JsonConverter(typeof(EnumClassConverter<IdentityCenterStatusEnum>))]
        public class IdentityCenterStatusEnum
        {
            /// <summary>
            /// Enum ENABLE for value: ENABLE
            /// </summary>
            public static readonly IdentityCenterStatusEnum ENABLE = new IdentityCenterStatusEnum("ENABLE");

            /// <summary>
            /// Enum DISABLE for value: DISABLE
            /// </summary>
            public static readonly IdentityCenterStatusEnum DISABLE = new IdentityCenterStatusEnum("DISABLE");

            private static readonly Dictionary<string, IdentityCenterStatusEnum> StaticFields =
            new Dictionary<string, IdentityCenterStatusEnum>()
            {
                { "ENABLE", ENABLE },
                { "DISABLE", DISABLE },
            };

            private string _value;

            public IdentityCenterStatusEnum()
            {

            }

            public IdentityCenterStatusEnum(string value)
            {
                _value = value;
            }

            public static IdentityCenterStatusEnum FromValue(string value)
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

                if (this.Equals(obj as IdentityCenterStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(IdentityCenterStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(IdentityCenterStatusEnum a, IdentityCenterStatusEnum b)
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

            public static bool operator !=(IdentityCenterStatusEnum a, IdentityCenterStatusEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 设置organization的类型。STANDARD和NON_STANDARD。
        /// </summary>
        /// <value>设置organization的类型。STANDARD和NON_STANDARD。</value>
        [JsonConverter(typeof(EnumClassConverter<OrganizationStructureTypeEnum>))]
        public class OrganizationStructureTypeEnum
        {
            /// <summary>
            /// Enum STANDARD for value: STANDARD
            /// </summary>
            public static readonly OrganizationStructureTypeEnum STANDARD = new OrganizationStructureTypeEnum("STANDARD");

            /// <summary>
            /// Enum NON_STANDARD for value: NON_STANDARD
            /// </summary>
            public static readonly OrganizationStructureTypeEnum NON_STANDARD = new OrganizationStructureTypeEnum("NON_STANDARD");

            private static readonly Dictionary<string, OrganizationStructureTypeEnum> StaticFields =
            new Dictionary<string, OrganizationStructureTypeEnum>()
            {
                { "STANDARD", STANDARD },
                { "NON_STANDARD", NON_STANDARD },
            };

            private string _value;

            public OrganizationStructureTypeEnum()
            {

            }

            public OrganizationStructureTypeEnum(string value)
            {
                _value = value;
            }

            public static OrganizationStructureTypeEnum FromValue(string value)
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

                if (this.Equals(obj as OrganizationStructureTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OrganizationStructureTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OrganizationStructureTypeEnum a, OrganizationStructureTypeEnum b)
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

            public static bool operator !=(OrganizationStructureTypeEnum a, OrganizationStructureTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 管理员纳管账号创建Identity Center用户所用邮箱。
        /// </summary>
        [JsonProperty("identity_store_email", NullValueHandling = NullValueHandling.Ignore)]
        public string IdentityStoreEmail { get; set; }

        /// <summary>
        /// 主区域。
        /// </summary>
        [JsonProperty("home_region", NullValueHandling = NullValueHandling.Ignore)]
        public string HomeRegion { get; set; }

        /// <summary>
        /// 设置Landing Zone的类型。包括CREATE、REPAIR以及UPDATE。
        /// </summary>
        [JsonProperty("setup_landing_zone_action_type", NullValueHandling = NullValueHandling.Ignore)]
        public SetupLandingZoneActionTypeEnum SetupLandingZoneActionType { get; set; }
        /// <summary>
        /// 当前纳管账号纳管的区域。
        /// </summary>
        [JsonProperty("region_configuration_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<RegionConfigurationList> RegionConfigurationList { get; set; }

        /// <summary>
        /// 是否设置Landing Zone的identity center。
        /// </summary>
        [JsonProperty("identity_center_status", NullValueHandling = NullValueHandling.Ignore)]
        public IdentityCenterStatusEnum IdentityCenterStatus { get; set; }
        /// <summary>
        /// 设置organization的类型。STANDARD和NON_STANDARD。
        /// </summary>
        [JsonProperty("organization_structure_type", NullValueHandling = NullValueHandling.Ignore)]
        public OrganizationStructureTypeEnum OrganizationStructureType { get; set; }
        /// <summary>
        /// 基础环境的纳管账号体系。
        /// </summary>
        [JsonProperty("organization_structure", NullValueHandling = NullValueHandling.Ignore)]
        public List<OrganizationStructureBaseLine> OrganizationStructure { get; set; }

        /// <summary>
        /// 是否允许区域拒绝，默认false。
        /// </summary>
        [JsonProperty("deny_ungoverned_regions", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DenyUngovernedRegions { get; set; }

        /// <summary>
        /// 是否允许设置组织汇聚。
        /// </summary>
        [JsonProperty("cloud_trail_type", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CloudTrailType { get; set; }

        /// <summary>
        /// 加密字段。
        /// </summary>
        [JsonProperty("kms_key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("logging_configuration", NullValueHandling = NullValueHandling.Ignore)]
        public LoggingConfiguration LoggingConfiguration { get; set; }

        /// <summary>
        /// 基线版本
        /// </summary>
        [JsonProperty("baseline_version", NullValueHandling = NullValueHandling.Ignore)]
        public string BaselineVersion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetupLandingZoneReqBody {\n");
            sb.Append("  identityStoreEmail: ").Append(IdentityStoreEmail).Append("\n");
            sb.Append("  homeRegion: ").Append(HomeRegion).Append("\n");
            sb.Append("  setupLandingZoneActionType: ").Append(SetupLandingZoneActionType).Append("\n");
            sb.Append("  regionConfigurationList: ").Append(RegionConfigurationList).Append("\n");
            sb.Append("  identityCenterStatus: ").Append(IdentityCenterStatus).Append("\n");
            sb.Append("  organizationStructureType: ").Append(OrganizationStructureType).Append("\n");
            sb.Append("  organizationStructure: ").Append(OrganizationStructure).Append("\n");
            sb.Append("  denyUngovernedRegions: ").Append(DenyUngovernedRegions).Append("\n");
            sb.Append("  cloudTrailType: ").Append(CloudTrailType).Append("\n");
            sb.Append("  kmsKeyId: ").Append(KmsKeyId).Append("\n");
            sb.Append("  loggingConfiguration: ").Append(LoggingConfiguration).Append("\n");
            sb.Append("  baselineVersion: ").Append(BaselineVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SetupLandingZoneReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SetupLandingZoneReqBody input)
        {
            if (input == null) return false;
            if (this.IdentityStoreEmail != input.IdentityStoreEmail || (this.IdentityStoreEmail != null && !this.IdentityStoreEmail.Equals(input.IdentityStoreEmail))) return false;
            if (this.HomeRegion != input.HomeRegion || (this.HomeRegion != null && !this.HomeRegion.Equals(input.HomeRegion))) return false;
            if (this.SetupLandingZoneActionType != input.SetupLandingZoneActionType) return false;
            if (this.RegionConfigurationList != input.RegionConfigurationList || (this.RegionConfigurationList != null && input.RegionConfigurationList != null && !this.RegionConfigurationList.SequenceEqual(input.RegionConfigurationList))) return false;
            if (this.IdentityCenterStatus != input.IdentityCenterStatus) return false;
            if (this.OrganizationStructureType != input.OrganizationStructureType) return false;
            if (this.OrganizationStructure != input.OrganizationStructure || (this.OrganizationStructure != null && input.OrganizationStructure != null && !this.OrganizationStructure.SequenceEqual(input.OrganizationStructure))) return false;
            if (this.DenyUngovernedRegions != input.DenyUngovernedRegions || (this.DenyUngovernedRegions != null && !this.DenyUngovernedRegions.Equals(input.DenyUngovernedRegions))) return false;
            if (this.CloudTrailType != input.CloudTrailType || (this.CloudTrailType != null && !this.CloudTrailType.Equals(input.CloudTrailType))) return false;
            if (this.KmsKeyId != input.KmsKeyId || (this.KmsKeyId != null && !this.KmsKeyId.Equals(input.KmsKeyId))) return false;
            if (this.LoggingConfiguration != input.LoggingConfiguration || (this.LoggingConfiguration != null && !this.LoggingConfiguration.Equals(input.LoggingConfiguration))) return false;
            if (this.BaselineVersion != input.BaselineVersion || (this.BaselineVersion != null && !this.BaselineVersion.Equals(input.BaselineVersion))) return false;

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
                if (this.IdentityStoreEmail != null) hashCode = hashCode * 59 + this.IdentityStoreEmail.GetHashCode();
                if (this.HomeRegion != null) hashCode = hashCode * 59 + this.HomeRegion.GetHashCode();
                hashCode = hashCode * 59 + this.SetupLandingZoneActionType.GetHashCode();
                if (this.RegionConfigurationList != null) hashCode = hashCode * 59 + this.RegionConfigurationList.GetHashCode();
                hashCode = hashCode * 59 + this.IdentityCenterStatus.GetHashCode();
                hashCode = hashCode * 59 + this.OrganizationStructureType.GetHashCode();
                if (this.OrganizationStructure != null) hashCode = hashCode * 59 + this.OrganizationStructure.GetHashCode();
                if (this.DenyUngovernedRegions != null) hashCode = hashCode * 59 + this.DenyUngovernedRegions.GetHashCode();
                if (this.CloudTrailType != null) hashCode = hashCode * 59 + this.CloudTrailType.GetHashCode();
                if (this.KmsKeyId != null) hashCode = hashCode * 59 + this.KmsKeyId.GetHashCode();
                if (this.LoggingConfiguration != null) hashCode = hashCode * 59 + this.LoggingConfiguration.GetHashCode();
                if (this.BaselineVersion != null) hashCode = hashCode * 59 + this.BaselineVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
