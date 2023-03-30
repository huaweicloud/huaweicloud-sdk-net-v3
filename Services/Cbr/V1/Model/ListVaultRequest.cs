using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListVaultRequest 
    {
        /// <summary>
        /// 云类型
        /// </summary>
        /// <value>云类型</value>
        [JsonConverter(typeof(EnumClassConverter<CloudTypeEnum>))]
        public class CloudTypeEnum
        {
            /// <summary>
            /// Enum PUBLIC for value: public
            /// </summary>
            public static readonly CloudTypeEnum PUBLIC = new CloudTypeEnum("public");

            /// <summary>
            /// Enum HYBRID for value: hybrid
            /// </summary>
            public static readonly CloudTypeEnum HYBRID = new CloudTypeEnum("hybrid");

            private static readonly Dictionary<string, CloudTypeEnum> StaticFields =
            new Dictionary<string, CloudTypeEnum>()
            {
                { "public", PUBLIC },
                { "hybrid", HYBRID },
            };

            private string _value;

            public CloudTypeEnum()
            {

            }

            public CloudTypeEnum(string value)
            {
                _value = value;
            }

            public static CloudTypeEnum FromValue(string value)
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

                if (this.Equals(obj as CloudTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CloudTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CloudTypeEnum a, CloudTypeEnum b)
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

            public static bool operator !=(CloudTypeEnum a, CloudTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 保护类型
        /// </summary>
        /// <value>保护类型</value>
        [JsonConverter(typeof(EnumClassConverter<ProtectTypeEnum>))]
        public class ProtectTypeEnum
        {
            /// <summary>
            /// Enum BACKUP for value: backup
            /// </summary>
            public static readonly ProtectTypeEnum BACKUP = new ProtectTypeEnum("backup");

            /// <summary>
            /// Enum REPLICATION for value: replication
            /// </summary>
            public static readonly ProtectTypeEnum REPLICATION = new ProtectTypeEnum("replication");

            private static readonly Dictionary<string, ProtectTypeEnum> StaticFields =
            new Dictionary<string, ProtectTypeEnum>()
            {
                { "backup", BACKUP },
                { "replication", REPLICATION },
            };

            private string _value;

            public ProtectTypeEnum()
            {

            }

            public ProtectTypeEnum(string value)
            {
                _value = value;
            }

            public static ProtectTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ProtectTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ProtectTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ProtectTypeEnum a, ProtectTypeEnum b)
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

            public static bool operator !=(ProtectTypeEnum a, ProtectTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 每页显示条目数，正整数
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 存储库名称
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 偏移值,正整数
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 云类型
        /// </summary>
        [SDKProperty("cloud_type", IsQuery = true)]
        [JsonProperty("cloud_type", NullValueHandling = NullValueHandling.Ignore)]
        public CloudTypeEnum CloudType { get; set; }
        /// <summary>
        /// 保护类型
        /// </summary>
        [SDKProperty("protect_type", IsQuery = true)]
        [JsonProperty("protect_type", NullValueHandling = NullValueHandling.Ignore)]
        public ProtectTypeEnum ProtectType { get; set; }
        /// <summary>
        /// 对象类型：云服务器（server），云硬盘（disk），文件系统（turbo），云桌面（workspace），VMware（vmware），关系型数据库（rds），文件（file）。
        /// </summary>
        [SDKProperty("object_type", IsQuery = true)]
        [JsonProperty("object_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectType { get; set; }

        /// <summary>
        /// 企业项目id或all_granted_eps，all_granted_eps表示查询用户有权限的所有企业项目id
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 存储库ID
        /// </summary>
        [SDKProperty("id", IsQuery = true)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 策略ID
        /// </summary>
        [SDKProperty("policy_id", IsQuery = true)]
        [JsonProperty("policy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyId { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 资源id
        /// </summary>
        [SDKProperty("resource_ids", IsQuery = true)]
        [JsonProperty("resource_ids", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListVaultRequest {\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  cloudType: ").Append(CloudType).Append("\n");
            sb.Append("  protectType: ").Append(ProtectType).Append("\n");
            sb.Append("  objectType: ").Append(ObjectType).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  policyId: ").Append(PolicyId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  resourceIds: ").Append(ResourceIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListVaultRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListVaultRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && 
                (
                    this.CloudType == input.CloudType ||
                    (this.CloudType != null &&
                    this.CloudType.Equals(input.CloudType))
                ) && 
                (
                    this.ProtectType == input.ProtectType ||
                    (this.ProtectType != null &&
                    this.ProtectType.Equals(input.ProtectType))
                ) && 
                (
                    this.ObjectType == input.ObjectType ||
                    (this.ObjectType != null &&
                    this.ObjectType.Equals(input.ObjectType))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.PolicyId == input.PolicyId ||
                    (this.PolicyId != null &&
                    this.PolicyId.Equals(input.PolicyId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.ResourceIds == input.ResourceIds ||
                    (this.ResourceIds != null &&
                    this.ResourceIds.Equals(input.ResourceIds))
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
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.CloudType != null)
                    hashCode = hashCode * 59 + this.CloudType.GetHashCode();
                if (this.ProtectType != null)
                    hashCode = hashCode * 59 + this.ProtectType.GetHashCode();
                if (this.ObjectType != null)
                    hashCode = hashCode * 59 + this.ObjectType.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.PolicyId != null)
                    hashCode = hashCode * 59 + this.PolicyId.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ResourceIds != null)
                    hashCode = hashCode * 59 + this.ResourceIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
