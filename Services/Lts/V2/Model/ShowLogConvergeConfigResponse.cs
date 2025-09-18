using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowLogConvergeConfigResponse : SdkResponse
    {
        /// <summary>
        /// creating: 配置创建中   done：配置创建完成
        /// </summary>
        /// <value>creating: 配置创建中   done：配置创建完成</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum CREATING for value: creating
            /// </summary>
            public static readonly StatusEnum CREATING = new StatusEnum("creating");

            /// <summary>
            /// Enum _DONE for value:  done
            /// </summary>
            public static readonly StatusEnum _DONE = new StatusEnum(" done");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "creating", CREATING },
                { " done", _DONE },
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
        /// ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 组织成员账号id
        /// </summary>
        [JsonProperty("member_account_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MemberAccountId { get; set; }

        /// <summary>
        /// 管理员或者委托管理员项目id
        /// </summary>
        [JsonProperty("member_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MemberProjectId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateTime { get; set; }

        /// <summary>
        /// creating: 配置创建中   done：配置创建完成
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 组织id
        /// </summary>
        [JsonProperty("organization_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// 管理员或者委托管理员账号id
        /// </summary>
        [JsonProperty("management_account_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ManagementAccountId { get; set; }

        /// <summary>
        /// 管理员项目id
        /// </summary>
        [JsonProperty("management_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ManagementProjectId { get; set; }

        /// <summary>
        /// 版本
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 日志汇聚配置
        /// </summary>
        [JsonProperty("log_mapping_config", NullValueHandling = NullValueHandling.Ignore)]
        public List<LogMappingConfig> LogMappingConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowLogConvergeConfigResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  memberAccountId: ").Append(MemberAccountId).Append("\n");
            sb.Append("  memberProjectId: ").Append(MemberProjectId).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  organizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  managementAccountId: ").Append(ManagementAccountId).Append("\n");
            sb.Append("  managementProjectId: ").Append(ManagementProjectId).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  logMappingConfig: ").Append(LogMappingConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowLogConvergeConfigResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowLogConvergeConfigResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.MemberAccountId != input.MemberAccountId || (this.MemberAccountId != null && !this.MemberAccountId.Equals(input.MemberAccountId))) return false;
            if (this.MemberProjectId != input.MemberProjectId || (this.MemberProjectId != null && !this.MemberProjectId.Equals(input.MemberProjectId))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.Status != input.Status) return false;
            if (this.OrganizationId != input.OrganizationId || (this.OrganizationId != null && !this.OrganizationId.Equals(input.OrganizationId))) return false;
            if (this.ManagementAccountId != input.ManagementAccountId || (this.ManagementAccountId != null && !this.ManagementAccountId.Equals(input.ManagementAccountId))) return false;
            if (this.ManagementProjectId != input.ManagementProjectId || (this.ManagementProjectId != null && !this.ManagementProjectId.Equals(input.ManagementProjectId))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.LogMappingConfig != input.LogMappingConfig || (this.LogMappingConfig != null && input.LogMappingConfig != null && !this.LogMappingConfig.SequenceEqual(input.LogMappingConfig))) return false;

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
                if (this.MemberAccountId != null) hashCode = hashCode * 59 + this.MemberAccountId.GetHashCode();
                if (this.MemberProjectId != null) hashCode = hashCode * 59 + this.MemberProjectId.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.OrganizationId != null) hashCode = hashCode * 59 + this.OrganizationId.GetHashCode();
                if (this.ManagementAccountId != null) hashCode = hashCode * 59 + this.ManagementAccountId.GetHashCode();
                if (this.ManagementProjectId != null) hashCode = hashCode * 59 + this.ManagementProjectId.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.LogMappingConfig != null) hashCode = hashCode * 59 + this.LogMappingConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
