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
    /// 更新七层转发策略的请求参数。
    /// </summary>
    public class UpdateL7PolicyOption 
    {

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
        /// 参数解释：转发策略名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 参数解释：转发到的listener的ID。  约束限制： - 当action为REDIRECT_TO_LISTENER时不能更新为空或null。 - 只支持protocol为HTTPS/TERMINATED_HTTPS的listener。 - 不能指定为其他loadbalancer下的listener。 - 当action为REDIRECT_TO_POOL时，创建或更新时不能传入该参数。
        /// </summary>
        [JsonProperty("redirect_listener_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RedirectListenerId { get; set; }

        /// <summary>
        /// 参数解释：转发到pool的ID。  约束限制： - 指定的pool不能是任何listener的default_pool。不能是其他listener的l7policy使用的pool。 - 当action为REDIRECT_TO_POOL时生效，但不能更新为空或null。 - 当action为REDIRECT_TO_LISTENER时，传入会报错。
        /// </summary>
        [JsonProperty("redirect_pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RedirectPoolId { get; set; }

        /// <summary>
        /// 参数解释：转发到多个主机组列表。一个policy最多配置5个pool。
        /// </summary>
        [JsonProperty("redirect_pools_config", NullValueHandling = NullValueHandling.Ignore)]
        public List<UpdateRedirectPoolsConfig> RedirectPoolsConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("redirect_pools_sticky_session_config", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateRedirectPoolsStickySessionConfig RedirectPoolsStickySessionConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("redirect_url_config", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateRedirectUrlConfig RedirectUrlConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("fixed_response_config", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateFixtedResponseConfig FixedResponseConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("redirect_pools_extend_config", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateRedirectPoolsExtendConfig RedirectPoolsExtendConfig { get; set; }

        /// <summary>
        /// 参数解释：转发策略关联的转发规则对象。  约束限制： - rules列表中最多含有10个rule规则 （若rule中包含conditions字段，一条condition算一个规则）， 且列表中type为HOST_NAME，PATH，METHOD，SOURCE_IP的rule不能重复，至多指定一条。 - 仅支持全量替换。
        /// </summary>
        [JsonProperty("rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<CreateRuleOption> Rules { get; set; }

        /// <summary>
        /// 参数解释：转发策略的优先级。数字越小表示优先级越高。  约束限制： - 同一个监听器下不同转发策略之间不允许重复的优先级数值。 - 当关联的监听器的高级转发策略功能（enhance_l7policy_enable）开启后才会生效，未开启传入该字段会报错。 - 当关联的监听器的高级转发策略功能（enhance_l7policy_enable）未开启，按原有policy的排序逻辑，自动排序。 不同域名优先级独立。相同域名下，按path的compare_type排序， 精确&gt;前缀&gt;正则，匹配类型相同时，path的长度越长优先级越高。 若policy下只有域名rule，没有路径rule，默认path为前缀匹配/。 [- 共享型负载均衡器下的转发策略不支持该字段。](tag:hws,hws_hk,ocb,ctc,g42,tm,cmcc,hk_g42,hws_ocb,hk_vdf,fcs,dt,hk_tm)  取值范围： - 当action为REDIRECT_TO_LISTENER时，支持指定为0-10000。 - 其它action取值，支持指定为1-10000。  默认取值： - 若关联的监听器的高级转发策略功能（enhance_l7policy_enable）未开启，且不传入该字段，则新创建的转发策略的优先级的值为1。 - 当action为REDIRECT_TO_LISTENER时，则新创建的转发策略的优先级的值为0。 - 其它action取值，新创建的转发策略的优先级的值为同一监听器下已有转发策略的优先级的最大值+1。   + 若监听器下没有转发策略，则新建的转发策略的优先级为1。   + 若当前已有转发策略的优先级的最大值是10000，则新创建的转发策略会因超出取值范围10000而失败。此时可通过传入指定priority，或调整原有policy的优先级来避免错误。  [不支持该字段，请勿使用。](tag:hcso_dt)  [荷兰region不支持该字段，请勿使用。](tag:dt,dt_test)
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateL7PolicyOption {\n");
            sb.Append("  adminStateUp: ").Append(AdminStateUp).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  redirectListenerId: ").Append(RedirectListenerId).Append("\n");
            sb.Append("  redirectPoolId: ").Append(RedirectPoolId).Append("\n");
            sb.Append("  redirectPoolsConfig: ").Append(RedirectPoolsConfig).Append("\n");
            sb.Append("  redirectPoolsStickySessionConfig: ").Append(RedirectPoolsStickySessionConfig).Append("\n");
            sb.Append("  redirectUrlConfig: ").Append(RedirectUrlConfig).Append("\n");
            sb.Append("  fixedResponseConfig: ").Append(FixedResponseConfig).Append("\n");
            sb.Append("  redirectPoolsExtendConfig: ").Append(RedirectPoolsExtendConfig).Append("\n");
            sb.Append("  rules: ").Append(Rules).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateL7PolicyOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateL7PolicyOption input)
        {
            if (input == null) return false;
            if (this.AdminStateUp != input.AdminStateUp || (this.AdminStateUp != null && !this.AdminStateUp.Equals(input.AdminStateUp))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.RedirectListenerId != input.RedirectListenerId || (this.RedirectListenerId != null && !this.RedirectListenerId.Equals(input.RedirectListenerId))) return false;
            if (this.RedirectPoolId != input.RedirectPoolId || (this.RedirectPoolId != null && !this.RedirectPoolId.Equals(input.RedirectPoolId))) return false;
            if (this.RedirectPoolsConfig != input.RedirectPoolsConfig || (this.RedirectPoolsConfig != null && input.RedirectPoolsConfig != null && !this.RedirectPoolsConfig.SequenceEqual(input.RedirectPoolsConfig))) return false;
            if (this.RedirectPoolsStickySessionConfig != input.RedirectPoolsStickySessionConfig || (this.RedirectPoolsStickySessionConfig != null && !this.RedirectPoolsStickySessionConfig.Equals(input.RedirectPoolsStickySessionConfig))) return false;
            if (this.RedirectUrlConfig != input.RedirectUrlConfig || (this.RedirectUrlConfig != null && !this.RedirectUrlConfig.Equals(input.RedirectUrlConfig))) return false;
            if (this.FixedResponseConfig != input.FixedResponseConfig || (this.FixedResponseConfig != null && !this.FixedResponseConfig.Equals(input.FixedResponseConfig))) return false;
            if (this.RedirectPoolsExtendConfig != input.RedirectPoolsExtendConfig || (this.RedirectPoolsExtendConfig != null && !this.RedirectPoolsExtendConfig.Equals(input.RedirectPoolsExtendConfig))) return false;
            if (this.Rules != input.Rules || (this.Rules != null && input.Rules != null && !this.Rules.SequenceEqual(input.Rules))) return false;
            if (this.Priority != input.Priority || (this.Priority != null && !this.Priority.Equals(input.Priority))) return false;

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
                if (this.AdminStateUp != null) hashCode = hashCode * 59 + this.AdminStateUp.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.RedirectListenerId != null) hashCode = hashCode * 59 + this.RedirectListenerId.GetHashCode();
                if (this.RedirectPoolId != null) hashCode = hashCode * 59 + this.RedirectPoolId.GetHashCode();
                if (this.RedirectPoolsConfig != null) hashCode = hashCode * 59 + this.RedirectPoolsConfig.GetHashCode();
                if (this.RedirectPoolsStickySessionConfig != null) hashCode = hashCode * 59 + this.RedirectPoolsStickySessionConfig.GetHashCode();
                if (this.RedirectUrlConfig != null) hashCode = hashCode * 59 + this.RedirectUrlConfig.GetHashCode();
                if (this.FixedResponseConfig != null) hashCode = hashCode * 59 + this.FixedResponseConfig.GetHashCode();
                if (this.RedirectPoolsExtendConfig != null) hashCode = hashCode * 59 + this.RedirectPoolsExtendConfig.GetHashCode();
                if (this.Rules != null) hashCode = hashCode * 59 + this.Rules.GetHashCode();
                if (this.Priority != null) hashCode = hashCode * 59 + this.Priority.GetHashCode();
                return hashCode;
            }
        }
    }
}
