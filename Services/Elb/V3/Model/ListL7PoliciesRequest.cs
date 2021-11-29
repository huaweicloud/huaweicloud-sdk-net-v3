using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListL7PoliciesRequest 
    {

        /// <summary>
        /// 上一页最后一条记录的ID。  使用说明： - 必须与limit一起使用。 - 不指定时表示查询第一页。 - 该字段不允许为空或无效的ID。
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 每页返回的个数。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 分页的顺序，true表示从后往前分页，false表示从前往后分页，默认为false。  使用说明： - 必须与limit一起使用。
        /// </summary>
        [SDKProperty("page_reverse", IsQuery = true)]
        [JsonProperty("page_reverse", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PageReverse { get; set; }

        /// <summary>
        /// 企业项目ID。不传时查询default企业项目\&quot;0\&quot;下的资源，鉴权按照default企业项目鉴权；如果传值，则传已存在的企业项目ID或all_granted_eps（表示查询所有企业项目）进行查询。 支持多值查询，查询条件格式：*enterprise_project_id&#x3D;xxx&amp;enterprise_project_id&#x3D;xxx*。  [不支持该字段，请勿使用。](tag:otc,otc_test,dt,dt_test)
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EnterpriseProjectId { get; set; }

        /// <summary>
        /// 转发策略ID。  支持多值查询，查询条件格式：*id&#x3D;xxx&amp;id&#x3D;xxx*。
        /// </summary>
        [SDKProperty("id", IsQuery = true)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Id { get; set; }

        /// <summary>
        /// 转发策略名称。  支持多值查询，查询条件格式：**name&#x3D;xxx&amp;name&#x3D;xxx**。
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Name { get; set; }

        /// <summary>
        /// 转发策略额描述信息。  支持多值查询，查询条件格式：*description&#x3D;xxx&amp;description&#x3D;xxx*。
        /// </summary>
        [SDKProperty("description", IsQuery = true)]
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Description { get; set; }

        /// <summary>
        /// 转发策略的管理状态，默认为true。  不支持该字段，请勿使用。
        /// </summary>
        [SDKProperty("admin_state_up", IsQuery = true)]
        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        /// <summary>
        /// 转发策略所属的监听器ID。  支持多值查询，查询条件格式：*******listener_id&#x3D;xxx&amp;listener_id&#x3D;xxx*******。
        /// </summary>
        [SDKProperty("listener_id", IsQuery = true)]
        [JsonProperty("listener_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ListenerId { get; set; }

        /// <summary>
        /// 转发策略的优先级。  支持多值查询，查询条件格式：****position&#x3D;xxx&amp;position&#x3D;xxx****。  不支持该字段，请勿使用。
        /// </summary>
        [SDKProperty("position", IsQuery = true)]
        [JsonProperty("position", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> Position { get; set; }

        /// <summary>
        /// 转发策略的转发动作。取值：  - REDIRECT_TO_POOL：转发到后端云服务器组。 - REDIRECT_TO_LISTENER：重定向到监听器。 - REDIRECT_TO_URL：重定向到URL。 - FIXED_RESPONSE：返回固定响应体。  支持多值查询，查询条件格式：*****action&#x3D;xxx&amp;action&#x3D;xxx*****。
        /// </summary>
        [SDKProperty("action", IsQuery = true)]
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Action { get; set; }

        /// <summary>
        /// 转发到的url。必须满足格式: protocol://host:port/path?query。  支持多值查询，查询条件格式：****redirect_url&#x3D;xxx&amp;redirect_url&#x3D;xxx****。  不支持该字段，请勿使用。
        /// </summary>
        [SDKProperty("redirect_url", IsQuery = true)]
        [JsonProperty("redirect_url", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RedirectUrl { get; set; }

        /// <summary>
        /// 转发到pool的ID。  支持多值查询，查询条件格式：***redirect_pool_id&#x3D;xxx&amp;redirect_pool_id&#x3D;xxx***。
        /// </summary>
        [SDKProperty("redirect_pool_id", IsQuery = true)]
        [JsonProperty("redirect_pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RedirectPoolId { get; set; }

        /// <summary>
        /// 转发到的listener的ID。  支持多值查询，查询条件格式：**redirect_listener_id&#x3D;xxx&amp;redirect_listener_id&#x3D;xxx**。
        /// </summary>
        [SDKProperty("redirect_listener_id", IsQuery = true)]
        [JsonProperty("redirect_listener_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RedirectListenerId { get; set; }

        /// <summary>
        /// 转发策略的配置状态。  取值范围：  - ACTIVE： 默认值，表示正常。 - ERROR： 表示当前策略与同一监听器下的其他策略存在相同的规则配置。  支持多值查询，查询条件格式：*provisioning_status&#x3D;xxx&amp;provisioning_status&#x3D;xxx*。
        /// </summary>
        [SDKProperty("provisioning_status", IsQuery = true)]
        [JsonProperty("provisioning_status", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ProvisioningStatus { get; set; }

        /// <summary>
        /// 是否显示转发策略下的rule详细信息。取值： - true：显示policy下面的rule的详细信息。 - false：只显示policy下面的rule的id信息
        /// </summary>
        [SDKProperty("display_all_rules", IsQuery = true)]
        [JsonProperty("display_all_rules", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DisplayAllRules { get; set; }

        /// <summary>
        /// 转发策略的优先级。数值越小，优先级越高。  支持多值查询，查询条件格式：*priority&#x3D;xxx&amp;priority&#x3D;xxx*。   [不支持该字段，请勿使用。](tag:otc,otc_test,dt,dt_test)
        /// </summary>
        [SDKProperty("priority", IsQuery = true)]
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> Priority { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListL7PoliciesRequest {\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  pageReverse: ").Append(PageReverse).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  adminStateUp: ").Append(AdminStateUp).Append("\n");
            sb.Append("  listenerId: ").Append(ListenerId).Append("\n");
            sb.Append("  position: ").Append(Position).Append("\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  redirectUrl: ").Append(RedirectUrl).Append("\n");
            sb.Append("  redirectPoolId: ").Append(RedirectPoolId).Append("\n");
            sb.Append("  redirectListenerId: ").Append(RedirectListenerId).Append("\n");
            sb.Append("  provisioningStatus: ").Append(ProvisioningStatus).Append("\n");
            sb.Append("  displayAllRules: ").Append(DisplayAllRules).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListL7PoliciesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListL7PoliciesRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Marker == input.Marker ||
                    (this.Marker != null &&
                    this.Marker.Equals(input.Marker))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.PageReverse == input.PageReverse ||
                    (this.PageReverse != null &&
                    this.PageReverse.Equals(input.PageReverse))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    this.EnterpriseProjectId != null &&
                    input.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.SequenceEqual(input.EnterpriseProjectId)
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id != null &&
                    input.Id != null &&
                    this.Id.SequenceEqual(input.Id)
                ) && 
                (
                    this.Name == input.Name ||
                    this.Name != null &&
                    input.Name != null &&
                    this.Name.SequenceEqual(input.Name)
                ) && 
                (
                    this.Description == input.Description ||
                    this.Description != null &&
                    input.Description != null &&
                    this.Description.SequenceEqual(input.Description)
                ) && 
                (
                    this.AdminStateUp == input.AdminStateUp ||
                    (this.AdminStateUp != null &&
                    this.AdminStateUp.Equals(input.AdminStateUp))
                ) && 
                (
                    this.ListenerId == input.ListenerId ||
                    this.ListenerId != null &&
                    input.ListenerId != null &&
                    this.ListenerId.SequenceEqual(input.ListenerId)
                ) && 
                (
                    this.Position == input.Position ||
                    this.Position != null &&
                    input.Position != null &&
                    this.Position.SequenceEqual(input.Position)
                ) && 
                (
                    this.Action == input.Action ||
                    this.Action != null &&
                    input.Action != null &&
                    this.Action.SequenceEqual(input.Action)
                ) && 
                (
                    this.RedirectUrl == input.RedirectUrl ||
                    this.RedirectUrl != null &&
                    input.RedirectUrl != null &&
                    this.RedirectUrl.SequenceEqual(input.RedirectUrl)
                ) && 
                (
                    this.RedirectPoolId == input.RedirectPoolId ||
                    this.RedirectPoolId != null &&
                    input.RedirectPoolId != null &&
                    this.RedirectPoolId.SequenceEqual(input.RedirectPoolId)
                ) && 
                (
                    this.RedirectListenerId == input.RedirectListenerId ||
                    this.RedirectListenerId != null &&
                    input.RedirectListenerId != null &&
                    this.RedirectListenerId.SequenceEqual(input.RedirectListenerId)
                ) && 
                (
                    this.ProvisioningStatus == input.ProvisioningStatus ||
                    this.ProvisioningStatus != null &&
                    input.ProvisioningStatus != null &&
                    this.ProvisioningStatus.SequenceEqual(input.ProvisioningStatus)
                ) && 
                (
                    this.DisplayAllRules == input.DisplayAllRules ||
                    (this.DisplayAllRules != null &&
                    this.DisplayAllRules.Equals(input.DisplayAllRules))
                ) && 
                (
                    this.Priority == input.Priority ||
                    this.Priority != null &&
                    input.Priority != null &&
                    this.Priority.SequenceEqual(input.Priority)
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
                if (this.Marker != null)
                    hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.PageReverse != null)
                    hashCode = hashCode * 59 + this.PageReverse.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
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
                if (this.Position != null)
                    hashCode = hashCode * 59 + this.Position.GetHashCode();
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.RedirectUrl != null)
                    hashCode = hashCode * 59 + this.RedirectUrl.GetHashCode();
                if (this.RedirectPoolId != null)
                    hashCode = hashCode * 59 + this.RedirectPoolId.GetHashCode();
                if (this.RedirectListenerId != null)
                    hashCode = hashCode * 59 + this.RedirectListenerId.GetHashCode();
                if (this.ProvisioningStatus != null)
                    hashCode = hashCode * 59 + this.ProvisioningStatus.GetHashCode();
                if (this.DisplayAllRules != null)
                    hashCode = hashCode * 59 + this.DisplayAllRules.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                return hashCode;
            }
        }
    }
}
