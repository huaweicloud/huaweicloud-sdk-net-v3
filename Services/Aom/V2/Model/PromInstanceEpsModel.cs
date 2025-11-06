using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PromInstanceEpsModel 
    {
        /// <summary>
        /// Prometheus实例状态。
        /// </summary>
        /// <value>Prometheus实例状态。</value>
        [JsonConverter(typeof(EnumClassConverter<PromStatusEnum>))]
        public class PromStatusEnum
        {
            /// <summary>
            /// Enum DELETED for value: DELETED
            /// </summary>
            public static readonly PromStatusEnum DELETED = new PromStatusEnum("DELETED");

            /// <summary>
            /// Enum NORMAL for value: NORMAL
            /// </summary>
            public static readonly PromStatusEnum NORMAL = new PromStatusEnum("NORMAL");

            /// <summary>
            /// Enum ALL for value: ALL
            /// </summary>
            public static readonly PromStatusEnum ALL = new PromStatusEnum("ALL");

            private static readonly Dictionary<string, PromStatusEnum> StaticFields =
            new Dictionary<string, PromStatusEnum>()
            {
                { "DELETED", DELETED },
                { "NORMAL", NORMAL },
                { "ALL", ALL },
            };

            private string _value;

            public PromStatusEnum()
            {

            }

            public PromStatusEnum(string value)
            {
                _value = value;
            }

            public static PromStatusEnum FromValue(string value)
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

                if (this.Equals(obj as PromStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PromStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PromStatusEnum a, PromStatusEnum b)
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

            public static bool operator !=(PromStatusEnum a, PromStatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// Prometheus实例名称 名称不能以下划线或中划线开头结尾，只含有中文、英文、数字、下划线、中划线、长度1-100。
        /// </summary>
        [JsonProperty("prom_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PromName { get; set; }

        /// <summary>
        /// Prometheus实例id。
        /// </summary>
        [JsonProperty("prom_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PromId { get; set; }

        /// <summary>
        /// Prometheus实例类型。  - default：默认普罗实例 - ECS：Prometheus for ECS - CCE：Prometheus for CCE - REMOTE_WRITE：Prometheus 通用实例 - CLOUD_SERVICE：Prometheus for 云服务 - ACROSS_ACCOUNT：Prometheus for 多账号聚合实例 （暂不支持ACROSS_ACCOUNT类型）
        /// </summary>
        [JsonProperty("prom_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PromType { get; set; }

        /// <summary>
        /// Prometheus实例版本号。
        /// </summary>
        [JsonProperty("prom_version", NullValueHandling = NullValueHandling.Ignore)]
        public string PromVersion { get; set; }

        /// <summary>
        /// Prometheus实例创建时间戳。
        /// </summary>
        [JsonProperty("prom_create_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? PromCreateTimestamp { get; set; }

        /// <summary>
        /// Prometheus实例更新时间戳。
        /// </summary>
        [JsonProperty("prom_update_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? PromUpdateTimestamp { get; set; }

        /// <summary>
        /// Prometheus实例状态。
        /// </summary>
        [JsonProperty("prom_status", NullValueHandling = NullValueHandling.Ignore)]
        public PromStatusEnum PromStatus { get; set; }
        /// <summary>
        /// Prometheus实例所属的企业项目。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// Prometheus实例所属projectId。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 删除标记。
        /// </summary>
        [JsonProperty("is_deleted_tag", NullValueHandling = NullValueHandling.Ignore)]
        public long? IsDeletedTag { get; set; }

        /// <summary>
        /// 删除时间。
        /// </summary>
        [JsonProperty("deleted_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? DeletedTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("prom_spec_config", NullValueHandling = NullValueHandling.Ignore)]
        public PromConfigModel PromSpecConfig { get; set; }

        /// <summary>
        /// Prometheus实例所属CCE特殊配置。
        /// </summary>
        [JsonProperty("cce_spec_config", NullValueHandling = NullValueHandling.Ignore)]
        public string CceSpecConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("prom_limits", NullValueHandling = NullValueHandling.Ignore)]
        public PromLimits PromLimits { get; set; }

        /// <summary>
        /// 指标存储周期修改时间。
        /// </summary>
        [JsonProperty("limits_update_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? LimitsUpdateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("application", NullValueHandling = NullValueHandling.Ignore)]
        public ApplicationModel Application { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PromInstanceEpsModel {\n");
            sb.Append("  promName: ").Append(PromName).Append("\n");
            sb.Append("  promId: ").Append(PromId).Append("\n");
            sb.Append("  promType: ").Append(PromType).Append("\n");
            sb.Append("  promVersion: ").Append(PromVersion).Append("\n");
            sb.Append("  promCreateTimestamp: ").Append(PromCreateTimestamp).Append("\n");
            sb.Append("  promUpdateTimestamp: ").Append(PromUpdateTimestamp).Append("\n");
            sb.Append("  promStatus: ").Append(PromStatus).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  isDeletedTag: ").Append(IsDeletedTag).Append("\n");
            sb.Append("  deletedTime: ").Append(DeletedTime).Append("\n");
            sb.Append("  promSpecConfig: ").Append(PromSpecConfig).Append("\n");
            sb.Append("  cceSpecConfig: ").Append(CceSpecConfig).Append("\n");
            sb.Append("  promLimits: ").Append(PromLimits).Append("\n");
            sb.Append("  limitsUpdateTime: ").Append(LimitsUpdateTime).Append("\n");
            sb.Append("  application: ").Append(Application).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PromInstanceEpsModel);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PromInstanceEpsModel input)
        {
            if (input == null) return false;
            if (this.PromName != input.PromName || (this.PromName != null && !this.PromName.Equals(input.PromName))) return false;
            if (this.PromId != input.PromId || (this.PromId != null && !this.PromId.Equals(input.PromId))) return false;
            if (this.PromType != input.PromType || (this.PromType != null && !this.PromType.Equals(input.PromType))) return false;
            if (this.PromVersion != input.PromVersion || (this.PromVersion != null && !this.PromVersion.Equals(input.PromVersion))) return false;
            if (this.PromCreateTimestamp != input.PromCreateTimestamp || (this.PromCreateTimestamp != null && !this.PromCreateTimestamp.Equals(input.PromCreateTimestamp))) return false;
            if (this.PromUpdateTimestamp != input.PromUpdateTimestamp || (this.PromUpdateTimestamp != null && !this.PromUpdateTimestamp.Equals(input.PromUpdateTimestamp))) return false;
            if (this.PromStatus != input.PromStatus) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.IsDeletedTag != input.IsDeletedTag || (this.IsDeletedTag != null && !this.IsDeletedTag.Equals(input.IsDeletedTag))) return false;
            if (this.DeletedTime != input.DeletedTime || (this.DeletedTime != null && !this.DeletedTime.Equals(input.DeletedTime))) return false;
            if (this.PromSpecConfig != input.PromSpecConfig || (this.PromSpecConfig != null && !this.PromSpecConfig.Equals(input.PromSpecConfig))) return false;
            if (this.CceSpecConfig != input.CceSpecConfig || (this.CceSpecConfig != null && !this.CceSpecConfig.Equals(input.CceSpecConfig))) return false;
            if (this.PromLimits != input.PromLimits || (this.PromLimits != null && !this.PromLimits.Equals(input.PromLimits))) return false;
            if (this.LimitsUpdateTime != input.LimitsUpdateTime || (this.LimitsUpdateTime != null && !this.LimitsUpdateTime.Equals(input.LimitsUpdateTime))) return false;
            if (this.Application != input.Application || (this.Application != null && !this.Application.Equals(input.Application))) return false;

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
                if (this.PromName != null) hashCode = hashCode * 59 + this.PromName.GetHashCode();
                if (this.PromId != null) hashCode = hashCode * 59 + this.PromId.GetHashCode();
                if (this.PromType != null) hashCode = hashCode * 59 + this.PromType.GetHashCode();
                if (this.PromVersion != null) hashCode = hashCode * 59 + this.PromVersion.GetHashCode();
                if (this.PromCreateTimestamp != null) hashCode = hashCode * 59 + this.PromCreateTimestamp.GetHashCode();
                if (this.PromUpdateTimestamp != null) hashCode = hashCode * 59 + this.PromUpdateTimestamp.GetHashCode();
                hashCode = hashCode * 59 + this.PromStatus.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.IsDeletedTag != null) hashCode = hashCode * 59 + this.IsDeletedTag.GetHashCode();
                if (this.DeletedTime != null) hashCode = hashCode * 59 + this.DeletedTime.GetHashCode();
                if (this.PromSpecConfig != null) hashCode = hashCode * 59 + this.PromSpecConfig.GetHashCode();
                if (this.CceSpecConfig != null) hashCode = hashCode * 59 + this.CceSpecConfig.GetHashCode();
                if (this.PromLimits != null) hashCode = hashCode * 59 + this.PromLimits.GetHashCode();
                if (this.LimitsUpdateTime != null) hashCode = hashCode * 59 + this.LimitsUpdateTime.GetHashCode();
                if (this.Application != null) hashCode = hashCode * 59 + this.Application.GetHashCode();
                return hashCode;
            }
        }
    }
}
