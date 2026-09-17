using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// **参数解释：** 集群升级动作定义，包含目标版本、升级策略、插件配置等。 **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及
    /// </summary>
    public class ClusterUpgradeAction 
    {

        /// <summary>
        /// **参数解释：** 插件配置列表，CCE会在集群升级过程中按照配置对插件进行升级 **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("addons", NullValueHandling = NullValueHandling.Ignore)]
        public List<UpgradeAddonConfig> Addons { get; set; }

        /// <summary>
        /// **参数解释：** 节点池内节点升级顺序配置。key表示节点池ID，默认节点池取值为\&quot;DefaultPool\&quot; **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("nodeOrder", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, List<NodePriority>> NodeOrder { get; set; }

        /// <summary>
        /// **参数解释：** 节点池升级顺序配置，key/value对格式。key表示节点池ID，默认节点池取值为\&quot;DefaultPool\&quot;，value表示对应节点池的优先级，默认值为0，优先级最低，数值越大优先级越高 **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("nodePoolOrder", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, int?> NodePoolOrder { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("strategy", NullValueHandling = NullValueHandling.Ignore)]
        public UpgradeStrategy Strategy { get; set; }

        /// <summary>
        /// **参数解释：** 升级的目标集群版本，例如\&quot;v1.23\&quot; **约束限制：** 只能升级到高版本，不允许填写等于或低于当前集群版本的值 **取值范围：** CCE支持的集群版本 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("targetVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetVersion { get; set; }

        /// <summary>
        /// **参数解释：** 是否在集群升级流程中跳过升级前检查。 **约束限制：** 不涉及 **取值范围：** - false：表示在集群升级流程中会执行升级前检查。 - true：表示在集群升级流程中跳过升级前检查。  **默认取值：** false
        /// </summary>
        [JsonProperty("isOnlyUpgrade", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsOnlyUpgrade { get; set; }

        /// <summary>
        /// **参数解释：** 指定集群使用的委托。该委托用于生成集群中组件使用的临时访问凭证，在集群中自动创建其他相关云服务的资源时会使用该委托权限。 当不传时，集群将优先继承原有配置，若原先未配置，则自动选择使用CCE的默认委托CCEAutoClusterAgency；当传空时，自动选择使用CCE的默认委托CCEAutoClusterAgency。  [ &gt; 关于CCE系统委托的说明详情参见[系统委托说明](https://support.huaweicloud.com/usermanual-cce/cce_10_0556.html)](tag:hws) [ &gt; 关于CCE系统委托的说明详情参见[系统委托说明](https://support.huaweicloud.com/intl/zh-cn/usermanual-cce/cce_10_0556.html)](tag:hws_hk)  **约束限制：** 仅v1.28.15-r90、v1.29.15-r50、v1.30.14-r50、v1.31.14-r10、v1.32.9-r10、v1.33.7-r10、v1.34.3-r0及以上版本集群支持该参数 **取值范围：** 不涉及 **默认取值：** 空
        /// </summary>
        [JsonProperty("agencyName", NullValueHandling = NullValueHandling.Ignore)]
        public string AgencyName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClusterUpgradeAction {\n");
            sb.Append("  addons: ").Append(Addons).Append("\n");
            sb.Append("  nodeOrder: ").Append(NodeOrder).Append("\n");
            sb.Append("  nodePoolOrder: ").Append(NodePoolOrder).Append("\n");
            sb.Append("  strategy: ").Append(Strategy).Append("\n");
            sb.Append("  targetVersion: ").Append(TargetVersion).Append("\n");
            sb.Append("  isOnlyUpgrade: ").Append(IsOnlyUpgrade).Append("\n");
            sb.Append("  agencyName: ").Append(AgencyName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClusterUpgradeAction);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ClusterUpgradeAction input)
        {
            if (input == null) return false;
            if (this.Addons != input.Addons || (this.Addons != null && input.Addons != null && !this.Addons.SequenceEqual(input.Addons))) return false;
            if (this.NodeOrder != input.NodeOrder || (this.NodeOrder != null && input.NodeOrder != null && !this.NodeOrder.SequenceEqual(input.NodeOrder))) return false;
            if (this.NodePoolOrder != input.NodePoolOrder || (this.NodePoolOrder != null && input.NodePoolOrder != null && !this.NodePoolOrder.SequenceEqual(input.NodePoolOrder))) return false;
            if (this.Strategy != input.Strategy || (this.Strategy != null && !this.Strategy.Equals(input.Strategy))) return false;
            if (this.TargetVersion != input.TargetVersion || (this.TargetVersion != null && !this.TargetVersion.Equals(input.TargetVersion))) return false;
            if (this.IsOnlyUpgrade != input.IsOnlyUpgrade || (this.IsOnlyUpgrade != null && !this.IsOnlyUpgrade.Equals(input.IsOnlyUpgrade))) return false;
            if (this.AgencyName != input.AgencyName || (this.AgencyName != null && !this.AgencyName.Equals(input.AgencyName))) return false;

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
                if (this.Addons != null) hashCode = hashCode * 59 + this.Addons.GetHashCode();
                if (this.NodeOrder != null) hashCode = hashCode * 59 + this.NodeOrder.GetHashCode();
                if (this.NodePoolOrder != null) hashCode = hashCode * 59 + this.NodePoolOrder.GetHashCode();
                if (this.Strategy != null) hashCode = hashCode * 59 + this.Strategy.GetHashCode();
                if (this.TargetVersion != null) hashCode = hashCode * 59 + this.TargetVersion.GetHashCode();
                if (this.IsOnlyUpgrade != null) hashCode = hashCode * 59 + this.IsOnlyUpgrade.GetHashCode();
                if (this.AgencyName != null) hashCode = hashCode * 59 + this.AgencyName.GetHashCode();
                return hashCode;
            }
        }
    }
}
