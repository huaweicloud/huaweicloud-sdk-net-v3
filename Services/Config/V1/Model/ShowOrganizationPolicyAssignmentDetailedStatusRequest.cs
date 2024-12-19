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
    /// Request Object
    /// </summary>
    public class ShowOrganizationPolicyAssignmentDetailedStatusRequest 
    {
        /// <summary>
        /// 成员帐号规则部署状态，区分大小写。
        /// </summary>
        /// <value>成员帐号规则部署状态，区分大小写。</value>
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
            /// Enum DELETE_SUCCESSFUL for value: DELETE_SUCCESSFUL
            /// </summary>
            public static readonly StatusEnum DELETE_SUCCESSFUL = new StatusEnum("DELETE_SUCCESSFUL");

            /// <summary>
            /// Enum DELETE_IN_PROGRESS for value: DELETE_IN_PROGRESS
            /// </summary>
            public static readonly StatusEnum DELETE_IN_PROGRESS = new StatusEnum("DELETE_IN_PROGRESS");

            /// <summary>
            /// Enum DELETE_FAILED for value: DELETE_FAILED
            /// </summary>
            public static readonly StatusEnum DELETE_FAILED = new StatusEnum("DELETE_FAILED");

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
                { "DELETE_SUCCESSFUL", DELETE_SUCCESSFUL },
                { "DELETE_IN_PROGRESS", DELETE_IN_PROGRESS },
                { "DELETE_FAILED", DELETE_FAILED },
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
        /// 组织ID。
        /// </summary>
        [SDKProperty("organization_id", IsPath = true)]
        [JsonProperty("organization_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// 组织合规规则名称。
        /// </summary>
        [SDKProperty("organization_policy_assignment_name", IsQuery = true)]
        [JsonProperty("organization_policy_assignment_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganizationPolicyAssignmentName { get; set; }

        /// <summary>
        /// 组织合规规则ID
        /// </summary>
        [SDKProperty("organization_policy_assignment_id", IsQuery = true)]
        [JsonProperty("organization_policy_assignment_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganizationPolicyAssignmentId { get; set; }

        /// <summary>
        /// 成员帐号规则部署状态，区分大小写。
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 最大的返回数量
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 分页参数，通过上一个请求中返回的marker信息作为输入，获取当前页
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowOrganizationPolicyAssignmentDetailedStatusRequest {\n");
            sb.Append("  organizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  organizationPolicyAssignmentName: ").Append(OrganizationPolicyAssignmentName).Append("\n");
            sb.Append("  organizationPolicyAssignmentId: ").Append(OrganizationPolicyAssignmentId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowOrganizationPolicyAssignmentDetailedStatusRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowOrganizationPolicyAssignmentDetailedStatusRequest input)
        {
            if (input == null) return false;
            if (this.OrganizationId != input.OrganizationId || (this.OrganizationId != null && !this.OrganizationId.Equals(input.OrganizationId))) return false;
            if (this.OrganizationPolicyAssignmentName != input.OrganizationPolicyAssignmentName || (this.OrganizationPolicyAssignmentName != null && !this.OrganizationPolicyAssignmentName.Equals(input.OrganizationPolicyAssignmentName))) return false;
            if (this.OrganizationPolicyAssignmentId != input.OrganizationPolicyAssignmentId || (this.OrganizationPolicyAssignmentId != null && !this.OrganizationPolicyAssignmentId.Equals(input.OrganizationPolicyAssignmentId))) return false;
            if (this.Status != input.Status) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Marker != input.Marker || (this.Marker != null && !this.Marker.Equals(input.Marker))) return false;

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
                if (this.OrganizationId != null) hashCode = hashCode * 59 + this.OrganizationId.GetHashCode();
                if (this.OrganizationPolicyAssignmentName != null) hashCode = hashCode * 59 + this.OrganizationPolicyAssignmentName.GetHashCode();
                if (this.OrganizationPolicyAssignmentId != null) hashCode = hashCode * 59 + this.OrganizationPolicyAssignmentId.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Marker != null) hashCode = hashCode * 59 + this.Marker.GetHashCode();
                return hashCode;
            }
        }
    }
}
