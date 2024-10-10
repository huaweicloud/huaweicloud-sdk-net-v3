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
    /// policy对象。
    /// </summary>
    public class L7Policy 
    {

        /// <summary>
        /// 参数解释：转发策略的转发动作。  约束限制： - REDIRECT_TO_LISTENER的优先级最高，配置了以后，该监听器下的其他policy会失效。 - 当action为REDIRECT_TO_POOL时， 只支持创建在PROTOCOL为HTTP、HTTPS、TERMINATED_HTTPS的listener上。 - 当action为REDIRECT_TO_LISTENER时，只支持创建在PROTOCOL为HTTP的listener上。  取值范围： - REDIRECT_TO_POOL：转发到后端服务器组； - REDIRECT_TO_LISTENER：重定向到监听器； - REDIRECT_TO_URL：重定向到URL； - FIXED_RESPONSE：返回固定响应体。  [不支持REDIRECT_TO_URL和FIXED_RESPONSE](tag:hcso_dt)
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }

        /// <summary>
        /// 参数解释：转发策略的管理状态。  约束限制：只支持设置为true。
        /// </summary>
        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        /// <summary>
        /// 参数解释：转发策略描述信息。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 参数解释：转发策略ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 参数解释：转发策略所属的监听器ID。
        /// </summary>
        [JsonProperty("listener_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ListenerId { get; set; }

        /// <summary>
        /// 参数解释：转发策略名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 参数解释：转发策略的优先级，不支持更新。  不支持该字段，请勿使用。
        /// </summary>
        [JsonProperty("position", NullValueHandling = NullValueHandling.Ignore)]
        public int? Position { get; set; }

        /// <summary>
        /// 参数解释：转发策略的优先级。数字越小表示优先级越高。  约束限制： - 同一个监听器下不同转发策略之间不允许重复的优先级数值。 - 当关联的监听器的高级转发策略功能（enhance_l7policy_enable）开启后才会生效，未开启传入该字段会报错。 - 当关联的监听器的高级转发策略功能（enhance_l7policy_enable）未开启，按原有policy的排序逻辑，自动排序。 不同域名优先级独立。相同域名下，按path的compare_type排序， 精确&gt;前缀&gt;正则，匹配类型相同时，path的长度越长优先级越高。 若policy下只有域名rule，没有路径rule，默认path为前缀匹配/。 [- 共享型负载均衡器下的转发策略不支持该字段。](tag:hws,hws_hk,ocb,ctc,g42,tm,cmcc,hk_g42,hws_ocb,hk_vdf,fcs,dt,hk_tm)  取值范围： - 当action为REDIRECT_TO_LISTENER时，支持指定为0-10000。 - 其它action取值，支持指定为1-10000。  默认取值： - 若关联的监听器的高级转发策略功能（enhance_l7policy_enable）未开启，且不传入该字段，则新创建的转发策略的优先级的值为1。 - 当action为REDIRECT_TO_LISTENER时，则新创建的转发策略的优先级的值为0。 - 其它action取值，新创建的转发策略的优先级的值为同一监听器下已有转发策略的优先级的最大值+1。   + 若监听器下没有转发策略，则新建的转发策略的优先级为1。   + 若当前已有转发策略的优先级的最大值是10000，则新创建的转发策略会因超出取值范围10000而失败。此时可通过传入指定priority，或调整原有policy的优先级来避免错误。  [不支持该字段，请勿使用。](tag:hcso_dt)  [荷兰region不支持该字段，请勿使用。](tag:dt,dt_test)
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; }

        /// <summary>
        /// 参数解释：转发策略所在的项目ID。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 参数解释：转发策略的配置状态。  取值范围： - ACTIVE: 默认值，表示正常。 [- ERROR: 表示当前策略与同一监听器下的其他策略存在相同的规则配置。 ](tag:hws,hws_hk,ocb,ctc,hcs,g42,tm,cmcc,hk_g42,hws_ocb,hk_vdf,fcs)
        /// </summary>
        [JsonProperty("provisioning_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ProvisioningStatus { get; set; }

        /// <summary>
        /// 参数解释：转发到pool的ID。  约束限制：当action为REDIRECT_TO_POOL时生效。
        /// </summary>
        [JsonProperty("redirect_pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RedirectPoolId { get; set; }

        /// <summary>
        /// 参数解释：转发到的listener的ID。  约束限制： - 当action为REDIRECT_TO_LISTENER时必选。 - 只支持protocol为HTTPS/TERMINATED_HTTPS的listener。 - 不能指定为其他loadbalancer下的listener。 - 当action为REDIRECT_TO_POOL时，创建或更新时不能传入该参数。
        /// </summary>
        [JsonProperty("redirect_listener_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RedirectListenerId { get; set; }

        /// <summary>
        /// 参数解释：转发到的url。  取值范围：必须满足格式: protocol://host:port/path?query。  不支持该字段，请勿使用。
        /// </summary>
        [JsonProperty("redirect_url", NullValueHandling = NullValueHandling.Ignore)]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// 参数解释：转发策略关联的转发规则列表。
        /// </summary>
        [JsonProperty("rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<RuleRef> Rules { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("redirect_url_config", NullValueHandling = NullValueHandling.Ignore)]
        public RedirectUrlConfig RedirectUrlConfig { get; set; }

        /// <summary>
        /// 参数解释：转发到多个主机组列表。  约束限制：一个policy最多配置5个pool。
        /// </summary>
        [JsonProperty("redirect_pools_config", NullValueHandling = NullValueHandling.Ignore)]
        public List<RedirectPoolsConfig> RedirectPoolsConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("redirect_pools_sticky_session_config", NullValueHandling = NullValueHandling.Ignore)]
        public RedirectPoolsStickySessionConfig RedirectPoolsStickySessionConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("redirect_pools_extend_config", NullValueHandling = NullValueHandling.Ignore)]
        public RedirectPoolsExtendConfig RedirectPoolsExtendConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("fixed_response_config", NullValueHandling = NullValueHandling.Ignore)]
        public FixtedResponseConfig FixedResponseConfig { get; set; }

        /// <summary>
        /// 参数解释：创建时间。  取值范围：格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;，UTC时区。  [注意：独享型实例的历史数据以及共享型实例下的资源，不返回该字段。 ](tag:hws,hws_hk,ocb,ctc,g42,tm,cmcc,hk_g42,hws_ocb,hk_vdf,fcs,dt,hk_tm)
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 参数解释：更新时间。  取值范围：格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;，UTC时区。  [注意：独享型实例的历史数据以及共享型实例下的资源，不返回该字段。 ](tag:hws,hws_hk,ocb,ctc,g42,tm,cmcc,hk_g42,hws_ocb,hk_vdf,fcs,dt,hk_tm)
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class L7Policy {\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  adminStateUp: ").Append(AdminStateUp).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  listenerId: ").Append(ListenerId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  position: ").Append(Position).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  provisioningStatus: ").Append(ProvisioningStatus).Append("\n");
            sb.Append("  redirectPoolId: ").Append(RedirectPoolId).Append("\n");
            sb.Append("  redirectListenerId: ").Append(RedirectListenerId).Append("\n");
            sb.Append("  redirectUrl: ").Append(RedirectUrl).Append("\n");
            sb.Append("  rules: ").Append(Rules).Append("\n");
            sb.Append("  redirectUrlConfig: ").Append(RedirectUrlConfig).Append("\n");
            sb.Append("  redirectPoolsConfig: ").Append(RedirectPoolsConfig).Append("\n");
            sb.Append("  redirectPoolsStickySessionConfig: ").Append(RedirectPoolsStickySessionConfig).Append("\n");
            sb.Append("  redirectPoolsExtendConfig: ").Append(RedirectPoolsExtendConfig).Append("\n");
            sb.Append("  fixedResponseConfig: ").Append(FixedResponseConfig).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as L7Policy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(L7Policy input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.AdminStateUp == input.AdminStateUp ||
                    (this.AdminStateUp != null &&
                    this.AdminStateUp.Equals(input.AdminStateUp))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ListenerId == input.ListenerId ||
                    (this.ListenerId != null &&
                    this.ListenerId.Equals(input.ListenerId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Position == input.Position ||
                    (this.Position != null &&
                    this.Position.Equals(input.Position))
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.ProvisioningStatus == input.ProvisioningStatus ||
                    (this.ProvisioningStatus != null &&
                    this.ProvisioningStatus.Equals(input.ProvisioningStatus))
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
                    this.Rules == input.Rules ||
                    this.Rules != null &&
                    input.Rules != null &&
                    this.Rules.SequenceEqual(input.Rules)
                ) && 
                (
                    this.RedirectUrlConfig == input.RedirectUrlConfig ||
                    (this.RedirectUrlConfig != null &&
                    this.RedirectUrlConfig.Equals(input.RedirectUrlConfig))
                ) && 
                (
                    this.RedirectPoolsConfig == input.RedirectPoolsConfig ||
                    this.RedirectPoolsConfig != null &&
                    input.RedirectPoolsConfig != null &&
                    this.RedirectPoolsConfig.SequenceEqual(input.RedirectPoolsConfig)
                ) && 
                (
                    this.RedirectPoolsStickySessionConfig == input.RedirectPoolsStickySessionConfig ||
                    (this.RedirectPoolsStickySessionConfig != null &&
                    this.RedirectPoolsStickySessionConfig.Equals(input.RedirectPoolsStickySessionConfig))
                ) && 
                (
                    this.RedirectPoolsExtendConfig == input.RedirectPoolsExtendConfig ||
                    (this.RedirectPoolsExtendConfig != null &&
                    this.RedirectPoolsExtendConfig.Equals(input.RedirectPoolsExtendConfig))
                ) && 
                (
                    this.FixedResponseConfig == input.FixedResponseConfig ||
                    (this.FixedResponseConfig != null &&
                    this.FixedResponseConfig.Equals(input.FixedResponseConfig))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.AdminStateUp != null)
                    hashCode = hashCode * 59 + this.AdminStateUp.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ListenerId != null)
                    hashCode = hashCode * 59 + this.ListenerId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Position != null)
                    hashCode = hashCode * 59 + this.Position.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ProvisioningStatus != null)
                    hashCode = hashCode * 59 + this.ProvisioningStatus.GetHashCode();
                if (this.RedirectPoolId != null)
                    hashCode = hashCode * 59 + this.RedirectPoolId.GetHashCode();
                if (this.RedirectListenerId != null)
                    hashCode = hashCode * 59 + this.RedirectListenerId.GetHashCode();
                if (this.RedirectUrl != null)
                    hashCode = hashCode * 59 + this.RedirectUrl.GetHashCode();
                if (this.Rules != null)
                    hashCode = hashCode * 59 + this.Rules.GetHashCode();
                if (this.RedirectUrlConfig != null)
                    hashCode = hashCode * 59 + this.RedirectUrlConfig.GetHashCode();
                if (this.RedirectPoolsConfig != null)
                    hashCode = hashCode * 59 + this.RedirectPoolsConfig.GetHashCode();
                if (this.RedirectPoolsStickySessionConfig != null)
                    hashCode = hashCode * 59 + this.RedirectPoolsStickySessionConfig.GetHashCode();
                if (this.RedirectPoolsExtendConfig != null)
                    hashCode = hashCode * 59 + this.RedirectPoolsExtendConfig.GetHashCode();
                if (this.FixedResponseConfig != null)
                    hashCode = hashCode * 59 + this.FixedResponseConfig.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
