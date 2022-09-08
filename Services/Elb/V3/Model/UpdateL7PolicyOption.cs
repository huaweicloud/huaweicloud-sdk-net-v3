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
        /// 转发策略的管理状态，默认为true。  不支持该字段，请勿使用。
        /// </summary>
        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        /// <summary>
        /// 转发策略描述信息。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 转发策略名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 转发到的listener的ID。  使用说明： - 当action为REDIRECT_TO_LISTENER时不能更新为空或null。 - 只支持protocol为HTTPS/TERMINATED_HTTPS的listener。 - 不能指定为其他loadbalancer下的listener。 - 当action为REDIRECT_TO_POOL时，创建或更新时不能传入该参数。
        /// </summary>
        [JsonProperty("redirect_listener_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RedirectListenerId { get; set; }

        /// <summary>
        /// 转发到pool的ID。  使用说明： - 指定的pool不能是listener的default_pool。不能是其他listener的l7policy使用的pool。 - 当action为REDIRECT_TO_POOL时为必选字段，不能更新为空或null。当action为REDIRECT_TO_LISTENER时，不可指定。
        /// </summary>
        [JsonProperty("redirect_pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RedirectPoolId { get; set; }

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
        /// 转发策略关联的转发规则对象。详细参考表 l7rule字段说明。rules列表中最多含有10个rule规则（若rule中包含conditions字段，一条condition算一个规则），且列表中type为HOST_NAME，PATH，METHOD，SOURCE_IP的rule不能重复，至多指定一条。
        /// </summary>
        [JsonProperty("rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<CreateRuleOption> Rules { get; set; }

        /// <summary>
        /// 转发策略的优先级。共享型实例该字段无意义。当监听器的高级转发策略功能（enhance_l7policy_enable）开启后才会生效，未开启传入该字段会报错。共享型负载均衡器下的转发策略不支持该字段。  数字越小表示优先级越高，同一监听器下不允许重复。  当action为REDIRECT_TO_LISTENER时，仅支持指定为0，优先级最高。 当关联的listener没有开启enhance_l7policy_enable，按原有policy的排序逻辑，自动排序。各域名之间优先级独立，相同域名下，按path的compare_type排序，精确&gt;前缀&gt;正则，匹配类型相同时，path的长度越长优先级越高。若policy下只有域名rule，没有路径rule，默认path为前缀匹配/。 当关联的listener开启了enhance_l7policy_enable，且不传该字段，则新创建的转发策略的优先级的值为：同一监听器下已有转发策略的优先级的最大值+1。因此，若当前已有转发策略的优先级的最大值是10000，新创建会因超出取值范围10000而失败。此时可通过传入指定priority，或调整原有policy的优先级来避免错误。若监听器下没有转发策略，则新建的转发策略的优先级为1。 [ 不支持该字段，请勿使用。](tag:hcso_dt)
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; }

        /// <summary>
        /// 转发到的后端主机组的配置。当action为REDIRECT_TO_POOL时生效。 使用说明： - 当action为REDIRECT_TO_POOL时redirect_pool_id和redirect_pools_config必须指定一个，两个都指定时按redirect_pools_config生效。 - 当action为REDIRECT_TO_LISTENER时，不可指定。 只支持全量覆盖。
        /// </summary>
        [JsonProperty("redirect_pools_config", NullValueHandling = NullValueHandling.Ignore)]
        public List<CreateRedirectPoolsConfig> RedirectPoolsConfig { get; set; }


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
            sb.Append("  redirectUrlConfig: ").Append(RedirectUrlConfig).Append("\n");
            sb.Append("  fixedResponseConfig: ").Append(FixedResponseConfig).Append("\n");
            sb.Append("  rules: ").Append(Rules).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("  redirectPoolsConfig: ").Append(RedirectPoolsConfig).Append("\n");
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
            if (input == null)
                return false;

            return 
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.RedirectListenerId == input.RedirectListenerId ||
                    (this.RedirectListenerId != null &&
                    this.RedirectListenerId.Equals(input.RedirectListenerId))
                ) && 
                (
                    this.RedirectPoolId == input.RedirectPoolId ||
                    (this.RedirectPoolId != null &&
                    this.RedirectPoolId.Equals(input.RedirectPoolId))
                ) && 
                (
                    this.RedirectUrlConfig == input.RedirectUrlConfig ||
                    (this.RedirectUrlConfig != null &&
                    this.RedirectUrlConfig.Equals(input.RedirectUrlConfig))
                ) && 
                (
                    this.FixedResponseConfig == input.FixedResponseConfig ||
                    (this.FixedResponseConfig != null &&
                    this.FixedResponseConfig.Equals(input.FixedResponseConfig))
                ) && 
                (
                    this.Rules == input.Rules ||
                    this.Rules != null &&
                    input.Rules != null &&
                    this.Rules.SequenceEqual(input.Rules)
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
                ) && 
                (
                    this.RedirectPoolsConfig == input.RedirectPoolsConfig ||
                    this.RedirectPoolsConfig != null &&
                    input.RedirectPoolsConfig != null &&
                    this.RedirectPoolsConfig.SequenceEqual(input.RedirectPoolsConfig)
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
                if (this.AdminStateUp != null)
                    hashCode = hashCode * 59 + this.AdminStateUp.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.RedirectListenerId != null)
                    hashCode = hashCode * 59 + this.RedirectListenerId.GetHashCode();
                if (this.RedirectPoolId != null)
                    hashCode = hashCode * 59 + this.RedirectPoolId.GetHashCode();
                if (this.RedirectUrlConfig != null)
                    hashCode = hashCode * 59 + this.RedirectUrlConfig.GetHashCode();
                if (this.FixedResponseConfig != null)
                    hashCode = hashCode * 59 + this.FixedResponseConfig.GetHashCode();
                if (this.Rules != null)
                    hashCode = hashCode * 59 + this.Rules.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.RedirectPoolsConfig != null)
                    hashCode = hashCode * 59 + this.RedirectPoolsConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
