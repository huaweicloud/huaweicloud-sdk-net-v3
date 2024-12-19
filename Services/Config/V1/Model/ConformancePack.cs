using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Config.V1.Model
{
    /// <summary>
    /// 合规规则包详情。
    /// </summary>
    public class ConformancePack 
    {
        /// <summary>
        /// 合规规则包部署状态。
        /// </summary>
        /// <value>合规规则包部署状态。</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum CREATE_SUCCESSFUL for value: CREATE_SUCCESSFUL
            /// </summary>
            public static readonly StatusEnum CREATE_SUCCESSFUL = new StatusEnum("CREATE_SUCCESSFUL");

            /// <summary>
            /// Enum CREATE_IN_PROGRESS for value: CREATE_IN_PROGRESS
            /// </summary>
            public static readonly StatusEnum CREATE_IN_PROGRESS = new StatusEnum("CREATE_IN_PROGRESS");

            /// <summary>
            /// Enum CREATE_FAILED for value: CREATE_FAILED
            /// </summary>
            public static readonly StatusEnum CREATE_FAILED = new StatusEnum("CREATE_FAILED");

            /// <summary>
            /// Enum DELETE_IN_PROGRESS for value: DELETE_IN_PROGRESS
            /// </summary>
            public static readonly StatusEnum DELETE_IN_PROGRESS = new StatusEnum("DELETE_IN_PROGRESS");

            /// <summary>
            /// Enum DELETE_FAILED for value: DELETE_FAILED
            /// </summary>
            public static readonly StatusEnum DELETE_FAILED = new StatusEnum("DELETE_FAILED");

            /// <summary>
            /// Enum ROLLBACK_SUCCESSFUL for value: ROLLBACK_SUCCESSFUL
            /// </summary>
            public static readonly StatusEnum ROLLBACK_SUCCESSFUL = new StatusEnum("ROLLBACK_SUCCESSFUL");

            /// <summary>
            /// Enum ROLLBACK_IN_PROGRESS for value: ROLLBACK_IN_PROGRESS
            /// </summary>
            public static readonly StatusEnum ROLLBACK_IN_PROGRESS = new StatusEnum("ROLLBACK_IN_PROGRESS");

            /// <summary>
            /// Enum ROLLBACK_FAILED for value: ROLLBACK_FAILED
            /// </summary>
            public static readonly StatusEnum ROLLBACK_FAILED = new StatusEnum("ROLLBACK_FAILED");

            /// <summary>
            /// Enum UPDATE_SUCCESSFUL for value: UPDATE_SUCCESSFUL
            /// </summary>
            public static readonly StatusEnum UPDATE_SUCCESSFUL = new StatusEnum("UPDATE_SUCCESSFUL");

            /// <summary>
            /// Enum UPDATE_IN_PROGRESS for value: UPDATE_IN_PROGRESS
            /// </summary>
            public static readonly StatusEnum UPDATE_IN_PROGRESS = new StatusEnum("UPDATE_IN_PROGRESS");

            /// <summary>
            /// Enum UPDATE_FAILED for value: UPDATE_FAILED
            /// </summary>
            public static readonly StatusEnum UPDATE_FAILED = new StatusEnum("UPDATE_FAILED");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "CREATE_SUCCESSFUL", CREATE_SUCCESSFUL },
                { "CREATE_IN_PROGRESS", CREATE_IN_PROGRESS },
                { "CREATE_FAILED", CREATE_FAILED },
                { "DELETE_IN_PROGRESS", DELETE_IN_PROGRESS },
                { "DELETE_FAILED", DELETE_FAILED },
                { "ROLLBACK_SUCCESSFUL", ROLLBACK_SUCCESSFUL },
                { "ROLLBACK_IN_PROGRESS", ROLLBACK_IN_PROGRESS },
                { "ROLLBACK_FAILED", ROLLBACK_FAILED },
                { "UPDATE_SUCCESSFUL", UPDATE_SUCCESSFUL },
                { "UPDATE_IN_PROGRESS", UPDATE_IN_PROGRESS },
                { "UPDATE_FAILED", UPDATE_FAILED },
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
        /// 合规规则包ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 合规规则包名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 资源栈（stack）的唯一ID。
        /// </summary>
        [JsonProperty("stack_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StackId { get; set; }

        /// <summary>
        /// 资源栈（stack）的名称。
        /// </summary>
        [JsonProperty("stack_name", NullValueHandling = NullValueHandling.Ignore)]
        public string StackName { get; set; }

        /// <summary>
        /// 部署ID。
        /// </summary>
        [JsonProperty("deployment_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DeploymentId { get; set; }

        /// <summary>
        /// 合规规则包创建时间。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 合规规则包更新时间。
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// 预定义合规规则包模板名称。
        /// </summary>
        [JsonProperty("template_key", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateKey { get; set; }

        /// <summary>
        /// 合规规则包模板OBS地址
        /// </summary>
        [JsonProperty("template_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateUri { get; set; }

        /// <summary>
        /// 委托名称
        /// </summary>
        [JsonProperty("agency_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AgencyName { get; set; }

        /// <summary>
        /// 合规规则包部署状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 部署或删除合规规则包错误时的错误信息
        /// </summary>
        [JsonProperty("error_message", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 合规规则包参数。
        /// </summary>
        [JsonProperty("vars_structure", NullValueHandling = NullValueHandling.Ignore)]
        public List<VarsStructure> VarsStructure { get; set; }

        /// <summary>
        /// 创建者
        /// </summary>
        [JsonProperty("created_by", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedBy { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConformancePack {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  stackId: ").Append(StackId).Append("\n");
            sb.Append("  stackName: ").Append(StackName).Append("\n");
            sb.Append("  deploymentId: ").Append(DeploymentId).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  templateKey: ").Append(TemplateKey).Append("\n");
            sb.Append("  templateUri: ").Append(TemplateUri).Append("\n");
            sb.Append("  agencyName: ").Append(AgencyName).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  errorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  varsStructure: ").Append(VarsStructure).Append("\n");
            sb.Append("  createdBy: ").Append(CreatedBy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConformancePack);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConformancePack input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.StackId != input.StackId || (this.StackId != null && !this.StackId.Equals(input.StackId))) return false;
            if (this.StackName != input.StackName || (this.StackName != null && !this.StackName.Equals(input.StackName))) return false;
            if (this.DeploymentId != input.DeploymentId || (this.DeploymentId != null && !this.DeploymentId.Equals(input.DeploymentId))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.TemplateKey != input.TemplateKey || (this.TemplateKey != null && !this.TemplateKey.Equals(input.TemplateKey))) return false;
            if (this.TemplateUri != input.TemplateUri || (this.TemplateUri != null && !this.TemplateUri.Equals(input.TemplateUri))) return false;
            if (this.AgencyName != input.AgencyName || (this.AgencyName != null && !this.AgencyName.Equals(input.AgencyName))) return false;
            if (this.Status != input.Status) return false;
            if (this.ErrorMessage != input.ErrorMessage || (this.ErrorMessage != null && !this.ErrorMessage.Equals(input.ErrorMessage))) return false;
            if (this.VarsStructure != input.VarsStructure || (this.VarsStructure != null && input.VarsStructure != null && !this.VarsStructure.SequenceEqual(input.VarsStructure))) return false;
            if (this.CreatedBy != input.CreatedBy || (this.CreatedBy != null && !this.CreatedBy.Equals(input.CreatedBy))) return false;

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
                if (this.StackId != null) hashCode = hashCode * 59 + this.StackId.GetHashCode();
                if (this.StackName != null) hashCode = hashCode * 59 + this.StackName.GetHashCode();
                if (this.DeploymentId != null) hashCode = hashCode * 59 + this.DeploymentId.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.TemplateKey != null) hashCode = hashCode * 59 + this.TemplateKey.GetHashCode();
                if (this.TemplateUri != null) hashCode = hashCode * 59 + this.TemplateUri.GetHashCode();
                if (this.AgencyName != null) hashCode = hashCode * 59 + this.AgencyName.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ErrorMessage != null) hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                if (this.VarsStructure != null) hashCode = hashCode * 59 + this.VarsStructure.GetHashCode();
                if (this.CreatedBy != null) hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                return hashCode;
            }
        }
    }
}
