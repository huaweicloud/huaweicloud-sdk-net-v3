using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowDomainRoleAssignmentsRequest 
    {

        /// <summary>
        /// 待查询账号ID。
        /// </summary>
        [SDKProperty("domain_id", IsQuery = true)]
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 策略ID。
        /// </summary>
        [SDKProperty("role_id", IsQuery = true)]
        [JsonProperty("role_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RoleId { get; set; }

        /// <summary>
        /// 授权主体,取值范围：user、group、agency。该参数与subject.user_id、subject.group_id、subject.agency_id只能选择一个。
        /// </summary>
        [SDKProperty("subject", IsQuery = true)]
        [JsonProperty("subject", NullValueHandling = NullValueHandling.Ignore)]
        public string Subject { get; set; }

        /// <summary>
        /// 授权的IAM用户ID。
        /// </summary>
        [SDKProperty("subject.user_id", IsQuery = true)]
        [JsonProperty("subject.user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubjectUserId { get; set; }

        /// <summary>
        /// 授权的用户组ID。
        /// </summary>
        [SDKProperty("subject.group_id", IsQuery = true)]
        [JsonProperty("subject.group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubjectGroupId { get; set; }

        /// <summary>
        /// 授权的委托ID。
        /// </summary>
        [SDKProperty("subject.agency_id", IsQuery = true)]
        [JsonProperty("subject.agency_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubjectAgencyId { get; set; }

        /// <summary>
        /// 授权范围，取值范围：project、domain、enterprise_project。该参数与scope.project_id、scope.domain_id、scope.enterprise_projects_id只能选择一个。 &gt; - 如需查看全局服务授权记录，scope取值domain或填写scope.domain_id。 &gt; - 如需查看基于所有资源的授权记录，scope取值为domain，且is_inherited取值为true &gt; - 如需查看基于项目的授权记录，scope取值为project或填写scope.project_id。 &gt; - 如需查看基于企业项目的授权记录，scope取值为enterprise_project或填写scope.enterprise_project_id。
        /// </summary>
        [SDKProperty("scope", IsQuery = true)]
        [JsonProperty("scope", NullValueHandling = NullValueHandling.Ignore)]
        public string Scope { get; set; }

        /// <summary>
        /// 授权的项目ID。
        /// </summary>
        [SDKProperty("scope.project_id", IsQuery = true)]
        [JsonProperty("scope.project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScopeProjectId { get; set; }

        /// <summary>
        /// 待查询账号ID。
        /// </summary>
        [SDKProperty("scope.domain_id", IsQuery = true)]
        [JsonProperty("scope.domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScopeDomainId { get; set; }

        /// <summary>
        /// 授权的企业项目ID。
        /// </summary>
        [SDKProperty("scope.enterprise_projects_id", IsQuery = true)]
        [JsonProperty("scope.enterprise_projects_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScopeEnterpriseProjectsId { get; set; }

        /// <summary>
        /// 是否包含基于所有项目授权的记录，默认为false。当参数scope&#x3D;domain或者scope.domain_id存在时生效。true：查询基于所有项目授权的记录。 false：查询基于全局服务授权的记录。
        /// </summary>
        [SDKProperty("is_inherited", IsQuery = true)]
        [JsonProperty("is_inherited", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsInherited { get; set; }

        /// <summary>
        /// 是否包含基于IAM用户所属用户组授权的记录，默认为true。当参数subject&#x3D;user或者subject.user_id存在时生效。true：查询基于IAM用户授权、IAM用户所属用户组授权的记录。 false：仅查询基于IAM用户授权的记录。
        /// </summary>
        [SDKProperty("include_group", IsQuery = true)]
        [JsonProperty("include_group", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeGroup { get; set; }

        /// <summary>
        /// 分页查询时数据的页数，查询值最小为1。需要与per_page同时存在。
        /// </summary>
        [SDKProperty("page", IsQuery = true)]
        [JsonProperty("page", NullValueHandling = NullValueHandling.Ignore)]
        public string Page { get; set; }

        /// <summary>
        /// 分页查询时每页的数据个数，取值范围为[1,50]。需要与page同时存在。
        /// </summary>
        [SDKProperty("per_page", IsQuery = true)]
        [JsonProperty("per_page", NullValueHandling = NullValueHandling.Ignore)]
        public string PerPage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDomainRoleAssignmentsRequest {\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  roleId: ").Append(RoleId).Append("\n");
            sb.Append("  subject: ").Append(Subject).Append("\n");
            sb.Append("  subjectUserId: ").Append(SubjectUserId).Append("\n");
            sb.Append("  subjectGroupId: ").Append(SubjectGroupId).Append("\n");
            sb.Append("  subjectAgencyId: ").Append(SubjectAgencyId).Append("\n");
            sb.Append("  scope: ").Append(Scope).Append("\n");
            sb.Append("  scopeProjectId: ").Append(ScopeProjectId).Append("\n");
            sb.Append("  scopeDomainId: ").Append(ScopeDomainId).Append("\n");
            sb.Append("  scopeEnterpriseProjectsId: ").Append(ScopeEnterpriseProjectsId).Append("\n");
            sb.Append("  isInherited: ").Append(IsInherited).Append("\n");
            sb.Append("  includeGroup: ").Append(IncludeGroup).Append("\n");
            sb.Append("  page: ").Append(Page).Append("\n");
            sb.Append("  perPage: ").Append(PerPage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDomainRoleAssignmentsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDomainRoleAssignmentsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DomainId == input.DomainId ||
                    (this.DomainId != null &&
                    this.DomainId.Equals(input.DomainId))
                ) && 
                (
                    this.RoleId == input.RoleId ||
                    (this.RoleId != null &&
                    this.RoleId.Equals(input.RoleId))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.SubjectUserId == input.SubjectUserId ||
                    (this.SubjectUserId != null &&
                    this.SubjectUserId.Equals(input.SubjectUserId))
                ) && 
                (
                    this.SubjectGroupId == input.SubjectGroupId ||
                    (this.SubjectGroupId != null &&
                    this.SubjectGroupId.Equals(input.SubjectGroupId))
                ) && 
                (
                    this.SubjectAgencyId == input.SubjectAgencyId ||
                    (this.SubjectAgencyId != null &&
                    this.SubjectAgencyId.Equals(input.SubjectAgencyId))
                ) && 
                (
                    this.Scope == input.Scope ||
                    (this.Scope != null &&
                    this.Scope.Equals(input.Scope))
                ) && 
                (
                    this.ScopeProjectId == input.ScopeProjectId ||
                    (this.ScopeProjectId != null &&
                    this.ScopeProjectId.Equals(input.ScopeProjectId))
                ) && 
                (
                    this.ScopeDomainId == input.ScopeDomainId ||
                    (this.ScopeDomainId != null &&
                    this.ScopeDomainId.Equals(input.ScopeDomainId))
                ) && 
                (
                    this.ScopeEnterpriseProjectsId == input.ScopeEnterpriseProjectsId ||
                    (this.ScopeEnterpriseProjectsId != null &&
                    this.ScopeEnterpriseProjectsId.Equals(input.ScopeEnterpriseProjectsId))
                ) && 
                (
                    this.IsInherited == input.IsInherited ||
                    (this.IsInherited != null &&
                    this.IsInherited.Equals(input.IsInherited))
                ) && 
                (
                    this.IncludeGroup == input.IncludeGroup ||
                    (this.IncludeGroup != null &&
                    this.IncludeGroup.Equals(input.IncludeGroup))
                ) && 
                (
                    this.Page == input.Page ||
                    (this.Page != null &&
                    this.Page.Equals(input.Page))
                ) && 
                (
                    this.PerPage == input.PerPage ||
                    (this.PerPage != null &&
                    this.PerPage.Equals(input.PerPage))
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
                if (this.DomainId != null)
                    hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.RoleId != null)
                    hashCode = hashCode * 59 + this.RoleId.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.SubjectUserId != null)
                    hashCode = hashCode * 59 + this.SubjectUserId.GetHashCode();
                if (this.SubjectGroupId != null)
                    hashCode = hashCode * 59 + this.SubjectGroupId.GetHashCode();
                if (this.SubjectAgencyId != null)
                    hashCode = hashCode * 59 + this.SubjectAgencyId.GetHashCode();
                if (this.Scope != null)
                    hashCode = hashCode * 59 + this.Scope.GetHashCode();
                if (this.ScopeProjectId != null)
                    hashCode = hashCode * 59 + this.ScopeProjectId.GetHashCode();
                if (this.ScopeDomainId != null)
                    hashCode = hashCode * 59 + this.ScopeDomainId.GetHashCode();
                if (this.ScopeEnterpriseProjectsId != null)
                    hashCode = hashCode * 59 + this.ScopeEnterpriseProjectsId.GetHashCode();
                if (this.IsInherited != null)
                    hashCode = hashCode * 59 + this.IsInherited.GetHashCode();
                if (this.IncludeGroup != null)
                    hashCode = hashCode * 59 + this.IncludeGroup.GetHashCode();
                if (this.Page != null)
                    hashCode = hashCode * 59 + this.Page.GetHashCode();
                if (this.PerPage != null)
                    hashCode = hashCode * 59 + this.PerPage.GetHashCode();
                return hashCode;
            }
        }
    }
}
