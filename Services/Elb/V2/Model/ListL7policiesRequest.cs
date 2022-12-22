using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListL7policiesRequest 
    {

        /// <summary>
        /// 分页查询中每页的转发策略个数
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 分页查询的起始的资源id，表示上一页最后一条查询记录的转发策略的id。不指定时表示查询第一页。
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 分页的顺序，true表示从后往前分页，false表示从前往后分页，默认为false。
        /// </summary>
        [SDKProperty("page_reverse", IsQuery = true)]
        [JsonProperty("page_reverse", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PageReverse { get; set; }

        /// <summary>
        /// 转发策略ID。
        /// </summary>
        [SDKProperty("id", IsQuery = true)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 转发策略名称。
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 转发策略的描述信息。
        /// </summary>
        [SDKProperty("description", IsQuery = true)]
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 转发策略的管理状态；取值范围： true/false。该字段为预留字段，暂未启用。默认为true。
        /// </summary>
        [SDKProperty("admin_state_up", IsQuery = true)]
        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        /// <summary>
        /// 转发策略所在的监听器ID。
        /// </summary>
        [SDKProperty("listener_id", IsQuery = true)]
        [JsonProperty("listener_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ListenerId { get; set; }

        /// <summary>
        /// 转发策略的匹配动作。 取值范围：REDIRECT_TO_POOL：将匹配的流量转发到redirect_pool_id指定的后端云服务器组上；REDIRECT_TO_LISTENER：将listener_id指定的HTTP监听器的流量重定向到redirect_listener_id指定的TERMINATED_HTTPS监听器上。
        /// </summary>
        [SDKProperty("action", IsQuery = true)]
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }

        /// <summary>
        /// 流量匹配后转发到后端云服务器组的ID。
        /// </summary>
        [SDKProperty("redirect_pool_id", IsQuery = true)]
        [JsonProperty("redirect_pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RedirectPoolId { get; set; }

        /// <summary>
        /// 流量匹配后转发到的监听器的ID。
        /// </summary>
        [SDKProperty("redirect_listener_id", IsQuery = true)]
        [JsonProperty("redirect_listener_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RedirectListenerId { get; set; }

        /// <summary>
        /// 转发策略重定向到的url。该字段为预留字段，暂未启用。
        /// </summary>
        [SDKProperty("redirect_url", IsQuery = true)]
        [JsonProperty("redirect_url", NullValueHandling = NullValueHandling.Ignore)]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// 转发优先级，从1递增，最高100。默认值：100；该字段为预留字段，暂未启用。
        /// </summary>
        [SDKProperty("position", IsQuery = true)]
        [JsonProperty("position", NullValueHandling = NullValueHandling.Ignore)]
        public int? Position { get; set; }

        /// <summary>
        /// 转发策略的配置状态，可以为ACTIVE、PENDING_CREATE 或者ERROR。默认值：ACTIVE；该字段为预留字段，暂未启用。
        /// </summary>
        [SDKProperty("provisioning_status", IsQuery = true)]
        [JsonProperty("provisioning_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ProvisioningStatus { get; set; }

        /// <summary>
        /// 企业项目ID。  传入all_granted_eps表示查询所有有权限的企业项目资源；\&quot;0\&quot;表示查询默认企业项目资源；或者指定的企业项目ID下的资源。
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 是否显示所有的rule信息。取值范围：false表示不显示（跟以前一样只显示ID）；true表示显示。
        /// </summary>
        [SDKProperty("display_all_rules", IsQuery = true)]
        [JsonProperty("display_all_rules", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DisplayAllRules { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListL7policiesRequest {\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  pageReverse: ").Append(PageReverse).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  adminStateUp: ").Append(AdminStateUp).Append("\n");
            sb.Append("  listenerId: ").Append(ListenerId).Append("\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  redirectPoolId: ").Append(RedirectPoolId).Append("\n");
            sb.Append("  redirectListenerId: ").Append(RedirectListenerId).Append("\n");
            sb.Append("  redirectUrl: ").Append(RedirectUrl).Append("\n");
            sb.Append("  position: ").Append(Position).Append("\n");
            sb.Append("  provisioningStatus: ").Append(ProvisioningStatus).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  displayAllRules: ").Append(DisplayAllRules).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListL7policiesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListL7policiesRequest input)
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
                    this.Marker == input.Marker ||
                    (this.Marker != null &&
                    this.Marker.Equals(input.Marker))
                ) && 
                (
                    this.PageReverse == input.PageReverse ||
                    (this.PageReverse != null &&
                    this.PageReverse.Equals(input.PageReverse))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.AdminStateUp == input.AdminStateUp ||
                    (this.AdminStateUp != null &&
                    this.AdminStateUp.Equals(input.AdminStateUp))
                ) && 
                (
                    this.ListenerId == input.ListenerId ||
                    (this.ListenerId != null &&
                    this.ListenerId.Equals(input.ListenerId))
                ) && 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.RedirectPoolId == input.RedirectPoolId ||
                    (this.RedirectPoolId != null &&
                    this.RedirectPoolId.Equals(input.RedirectPoolId))
                ) && 
                (
                    this.RedirectListenerId == input.RedirectListenerId ||
                    (this.RedirectListenerId != null &&
                    this.RedirectListenerId.Equals(input.RedirectListenerId))
                ) && 
                (
                    this.RedirectUrl == input.RedirectUrl ||
                    (this.RedirectUrl != null &&
                    this.RedirectUrl.Equals(input.RedirectUrl))
                ) && 
                (
                    this.Position == input.Position ||
                    (this.Position != null &&
                    this.Position.Equals(input.Position))
                ) && 
                (
                    this.ProvisioningStatus == input.ProvisioningStatus ||
                    (this.ProvisioningStatus != null &&
                    this.ProvisioningStatus.Equals(input.ProvisioningStatus))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.DisplayAllRules == input.DisplayAllRules ||
                    (this.DisplayAllRules != null &&
                    this.DisplayAllRules.Equals(input.DisplayAllRules))
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
                if (this.Marker != null)
                    hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.PageReverse != null)
                    hashCode = hashCode * 59 + this.PageReverse.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.AdminStateUp != null)
                    hashCode = hashCode * 59 + this.AdminStateUp.GetHashCode();
                if (this.ListenerId != null)
                    hashCode = hashCode * 59 + this.ListenerId.GetHashCode();
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.RedirectPoolId != null)
                    hashCode = hashCode * 59 + this.RedirectPoolId.GetHashCode();
                if (this.RedirectListenerId != null)
                    hashCode = hashCode * 59 + this.RedirectListenerId.GetHashCode();
                if (this.RedirectUrl != null)
                    hashCode = hashCode * 59 + this.RedirectUrl.GetHashCode();
                if (this.Position != null)
                    hashCode = hashCode * 59 + this.Position.GetHashCode();
                if (this.ProvisioningStatus != null)
                    hashCode = hashCode * 59 + this.ProvisioningStatus.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.DisplayAllRules != null)
                    hashCode = hashCode * 59 + this.DisplayAllRules.GetHashCode();
                return hashCode;
            }
        }
    }
}
