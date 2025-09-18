using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cc.V3.Model
{
    /// <summary>
    /// 云连接实例。
    /// </summary>
    public class CloudConnection 
    {
        /// <summary>
        /// 云连接实例的状态。ACTIVE：表示状态可用。
        /// </summary>
        /// <value>云连接实例的状态。ACTIVE：表示状态可用。</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum ACTIVE for value: ACTIVE
            /// </summary>
            public static readonly StatusEnum ACTIVE = new StatusEnum("ACTIVE");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "ACTIVE", ACTIVE },
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 云连接使用场景。 - VPC：虚拟私有云。
        /// </summary>
        /// <value>云连接使用场景。 - VPC：虚拟私有云。</value>
        [JsonConverter(typeof(EnumClassConverter<UsedSceneEnum>))]
        public class UsedSceneEnum
        {
            /// <summary>
            /// Enum VPC for value: vpc
            /// </summary>
            public static readonly UsedSceneEnum VPC = new UsedSceneEnum("vpc");

            private static readonly Dictionary<string, UsedSceneEnum> StaticFields =
            new Dictionary<string, UsedSceneEnum>()
            {
                { "vpc", VPC },
            };

            private string _value;

            public UsedSceneEnum()
            {

            }

            public UsedSceneEnum(string value)
            {
                _value = value;
            }

            public static UsedSceneEnum FromValue(string value)
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

                if (this.Equals(obj as UsedSceneEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(UsedSceneEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(UsedSceneEnum a, UsedSceneEnum b)
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

            public static bool operator !=(UsedSceneEnum a, UsedSceneEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 实例名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 实例描述。不支持 &lt;&gt;。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 实例所属账号ID。
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 实例所属企业项目ID。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 实例创建时间。UTC时间格式，yyyy-MM-ddTHH:mm:ss。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 实例更新时间。UTC时间格式，yyyy-MM-ddTHH:mm:ss。
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// 实例标签。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// 云连接实例的状态。ACTIVE：表示状态可用。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 云连接实例的管理状态。
        /// </summary>
        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        /// <summary>
        /// 云连接使用场景。 - VPC：虚拟私有云。
        /// </summary>
        [JsonProperty("used_scene", NullValueHandling = NullValueHandling.Ignore)]
        public UsedSceneEnum UsedScene { get; set; }
        /// <summary>
        /// 云连接实例关联网络实例的个数。
        /// </summary>
        [JsonProperty("network_instance_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? NetworkInstanceNumber { get; set; }

        /// <summary>
        /// 云连接实例关联带宽包的个数。
        /// </summary>
        [JsonProperty("bandwidth_package_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? BandwidthPackageNumber { get; set; }

        /// <summary>
        /// 云连接实例关联域间带宽的个数。
        /// </summary>
        [JsonProperty("inter_region_bandwidth_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? InterRegionBandwidthNumber { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CloudConnection {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  adminStateUp: ").Append(AdminStateUp).Append("\n");
            sb.Append("  usedScene: ").Append(UsedScene).Append("\n");
            sb.Append("  networkInstanceNumber: ").Append(NetworkInstanceNumber).Append("\n");
            sb.Append("  bandwidthPackageNumber: ").Append(BandwidthPackageNumber).Append("\n");
            sb.Append("  interRegionBandwidthNumber: ").Append(InterRegionBandwidthNumber).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CloudConnection);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CloudConnection input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.Status != input.Status) return false;
            if (this.AdminStateUp != input.AdminStateUp || (this.AdminStateUp != null && !this.AdminStateUp.Equals(input.AdminStateUp))) return false;
            if (this.UsedScene != input.UsedScene) return false;
            if (this.NetworkInstanceNumber != input.NetworkInstanceNumber || (this.NetworkInstanceNumber != null && !this.NetworkInstanceNumber.Equals(input.NetworkInstanceNumber))) return false;
            if (this.BandwidthPackageNumber != input.BandwidthPackageNumber || (this.BandwidthPackageNumber != null && !this.BandwidthPackageNumber.Equals(input.BandwidthPackageNumber))) return false;
            if (this.InterRegionBandwidthNumber != input.InterRegionBandwidthNumber || (this.InterRegionBandwidthNumber != null && !this.InterRegionBandwidthNumber.Equals(input.InterRegionBandwidthNumber))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.AdminStateUp != null) hashCode = hashCode * 59 + this.AdminStateUp.GetHashCode();
                hashCode = hashCode * 59 + this.UsedScene.GetHashCode();
                if (this.NetworkInstanceNumber != null) hashCode = hashCode * 59 + this.NetworkInstanceNumber.GetHashCode();
                if (this.BandwidthPackageNumber != null) hashCode = hashCode * 59 + this.BandwidthPackageNumber.GetHashCode();
                if (this.InterRegionBandwidthNumber != null) hashCode = hashCode * 59 + this.InterRegionBandwidthNumber.GetHashCode();
                return hashCode;
            }
        }
    }
}
