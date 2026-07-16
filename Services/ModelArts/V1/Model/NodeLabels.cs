using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// **参数解释**：节点的标签信息。
    /// </summary>
    public class NodeLabels 
    {

        /// <summary>
        /// **参数解释**：节点所在的集群名称。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("os.modelarts.node/cluster", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsNodeCluster { get; set; }

        /// <summary>
        /// **参数解释**：节点绑定的逻辑池。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("os.modelarts.node/elastic.quota", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsNodeElasticQuota { get; set; }

        /// <summary>
        /// **参数解释**：节点所在的节点池id。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("os.modelarts.node/nodepool", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsNodeNodepool { get; set; }

        /// <summary>
        /// **参数解释**：批量创建批次标识。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("os.modelarts.node/batch.uid", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsNodeBatchUid { get; set; }

        /// <summary>
        /// **参数解释**：批量创建批次名称。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("os.modelarts.node/batch.name", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsNodeBatchName { get; set; }

        /// <summary>
        /// **参数解释**：批量创建批次类型。 **取值范围**：可选值如下：   - hyperinstance：超节点。
        /// </summary>
        [JsonProperty("os.modelarts.node/batch.type", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsNodeBatchType { get; set; }

        /// <summary>
        /// **参数解释**：批量创建的节点个数。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("os.modelarts.node/batch.count", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsNodeBatchCount { get; set; }

        /// <summary>
        /// **参数解释**：节点的资源id。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("os.modelarts/resource.id", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsResourceId { get; set; }

        /// <summary>
        /// **参数解释**：节点的租户id，记录节点创建在哪个租户账号下。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("os.modelarts/tenant.domain.id", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsTenantDomainId { get; set; }

        /// <summary>
        /// **参数解释**：节点的项目id，记录节点创建在租户账号下哪个项目中。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("os.modelarts/tenant.project.id", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsTenantProjectId { get; set; }

        /// <summary>
        /// **参数解释**：节点计费状态。 **取值范围**：可选值如下： - 0：正常状态。 - 1：冻结状态。 - 2：删除状态或者终止状态。
        /// </summary>
        [JsonProperty("os.modelarts/billing.status", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsBillingStatus { get; set; }

        /// <summary>
        /// **参数解释**：标识该节点是否被整柜作业独占。当被某个整柜作业独占时，该标签存在，标签的值为独占的训练作业ID。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("os.modelarts.node/volcano.scheduler.cabinet-exclusive", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsNodeVolcanoSchedulerCabinetExclusive { get; set; }

        /// <summary>
        /// **参数解释**：节点所在tor交换机ip。多个tor交换机ip之间以中划线-分隔。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("cce.kubectl.kubernetes.io/cabinet", NullValueHandling = NullValueHandling.Ignore)]
        public string CceKubectlKubernetesIoCabinet { get; set; }

        /// <summary>
        /// **参数解释**：节点底层资源的实例ID，如超节点的ECS实例ID。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("os.modelarts.node/underlying.instance.id", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsNodeUnderlyingInstanceId { get; set; }

        /// <summary>
        /// **参数解释**：节点是否启用高可用冗余。 **取值范围**：   - true：开启   - false：未开启
        /// </summary>
        [JsonProperty("os.modelarts.node/ha.redundant.enabled", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsNodeHaRedundantEnabled { get; set; }

        /// <summary>
        /// **参数解释**：节点所在的节点池名称,最小长度为2，最大长度为50的小写字母、中划线-、数字组成，由小写字母开头，不能 以-，-default结尾。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("os.modelarts.node/nodepoolname", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsNodeNodepoolname { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeLabels {\n");
            sb.Append("  osModelartsNodeCluster: ").Append(OsModelartsNodeCluster).Append("\n");
            sb.Append("  osModelartsNodeElasticQuota: ").Append(OsModelartsNodeElasticQuota).Append("\n");
            sb.Append("  osModelartsNodeNodepool: ").Append(OsModelartsNodeNodepool).Append("\n");
            sb.Append("  osModelartsNodeBatchUid: ").Append(OsModelartsNodeBatchUid).Append("\n");
            sb.Append("  osModelartsNodeBatchName: ").Append(OsModelartsNodeBatchName).Append("\n");
            sb.Append("  osModelartsNodeBatchType: ").Append(OsModelartsNodeBatchType).Append("\n");
            sb.Append("  osModelartsNodeBatchCount: ").Append(OsModelartsNodeBatchCount).Append("\n");
            sb.Append("  osModelartsResourceId: ").Append(OsModelartsResourceId).Append("\n");
            sb.Append("  osModelartsTenantDomainId: ").Append(OsModelartsTenantDomainId).Append("\n");
            sb.Append("  osModelartsTenantProjectId: ").Append(OsModelartsTenantProjectId).Append("\n");
            sb.Append("  osModelartsBillingStatus: ").Append(OsModelartsBillingStatus).Append("\n");
            sb.Append("  osModelartsNodeVolcanoSchedulerCabinetExclusive: ").Append(OsModelartsNodeVolcanoSchedulerCabinetExclusive).Append("\n");
            sb.Append("  cceKubectlKubernetesIoCabinet: ").Append(CceKubectlKubernetesIoCabinet).Append("\n");
            sb.Append("  osModelartsNodeUnderlyingInstanceId: ").Append(OsModelartsNodeUnderlyingInstanceId).Append("\n");
            sb.Append("  osModelartsNodeHaRedundantEnabled: ").Append(OsModelartsNodeHaRedundantEnabled).Append("\n");
            sb.Append("  osModelartsNodeNodepoolname: ").Append(OsModelartsNodeNodepoolname).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodeLabels);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodeLabels input)
        {
            if (input == null) return false;
            if (this.OsModelartsNodeCluster != input.OsModelartsNodeCluster || (this.OsModelartsNodeCluster != null && !this.OsModelartsNodeCluster.Equals(input.OsModelartsNodeCluster))) return false;
            if (this.OsModelartsNodeElasticQuota != input.OsModelartsNodeElasticQuota || (this.OsModelartsNodeElasticQuota != null && !this.OsModelartsNodeElasticQuota.Equals(input.OsModelartsNodeElasticQuota))) return false;
            if (this.OsModelartsNodeNodepool != input.OsModelartsNodeNodepool || (this.OsModelartsNodeNodepool != null && !this.OsModelartsNodeNodepool.Equals(input.OsModelartsNodeNodepool))) return false;
            if (this.OsModelartsNodeBatchUid != input.OsModelartsNodeBatchUid || (this.OsModelartsNodeBatchUid != null && !this.OsModelartsNodeBatchUid.Equals(input.OsModelartsNodeBatchUid))) return false;
            if (this.OsModelartsNodeBatchName != input.OsModelartsNodeBatchName || (this.OsModelartsNodeBatchName != null && !this.OsModelartsNodeBatchName.Equals(input.OsModelartsNodeBatchName))) return false;
            if (this.OsModelartsNodeBatchType != input.OsModelartsNodeBatchType || (this.OsModelartsNodeBatchType != null && !this.OsModelartsNodeBatchType.Equals(input.OsModelartsNodeBatchType))) return false;
            if (this.OsModelartsNodeBatchCount != input.OsModelartsNodeBatchCount || (this.OsModelartsNodeBatchCount != null && !this.OsModelartsNodeBatchCount.Equals(input.OsModelartsNodeBatchCount))) return false;
            if (this.OsModelartsResourceId != input.OsModelartsResourceId || (this.OsModelartsResourceId != null && !this.OsModelartsResourceId.Equals(input.OsModelartsResourceId))) return false;
            if (this.OsModelartsTenantDomainId != input.OsModelartsTenantDomainId || (this.OsModelartsTenantDomainId != null && !this.OsModelartsTenantDomainId.Equals(input.OsModelartsTenantDomainId))) return false;
            if (this.OsModelartsTenantProjectId != input.OsModelartsTenantProjectId || (this.OsModelartsTenantProjectId != null && !this.OsModelartsTenantProjectId.Equals(input.OsModelartsTenantProjectId))) return false;
            if (this.OsModelartsBillingStatus != input.OsModelartsBillingStatus || (this.OsModelartsBillingStatus != null && !this.OsModelartsBillingStatus.Equals(input.OsModelartsBillingStatus))) return false;
            if (this.OsModelartsNodeVolcanoSchedulerCabinetExclusive != input.OsModelartsNodeVolcanoSchedulerCabinetExclusive || (this.OsModelartsNodeVolcanoSchedulerCabinetExclusive != null && !this.OsModelartsNodeVolcanoSchedulerCabinetExclusive.Equals(input.OsModelartsNodeVolcanoSchedulerCabinetExclusive))) return false;
            if (this.CceKubectlKubernetesIoCabinet != input.CceKubectlKubernetesIoCabinet || (this.CceKubectlKubernetesIoCabinet != null && !this.CceKubectlKubernetesIoCabinet.Equals(input.CceKubectlKubernetesIoCabinet))) return false;
            if (this.OsModelartsNodeUnderlyingInstanceId != input.OsModelartsNodeUnderlyingInstanceId || (this.OsModelartsNodeUnderlyingInstanceId != null && !this.OsModelartsNodeUnderlyingInstanceId.Equals(input.OsModelartsNodeUnderlyingInstanceId))) return false;
            if (this.OsModelartsNodeHaRedundantEnabled != input.OsModelartsNodeHaRedundantEnabled || (this.OsModelartsNodeHaRedundantEnabled != null && !this.OsModelartsNodeHaRedundantEnabled.Equals(input.OsModelartsNodeHaRedundantEnabled))) return false;
            if (this.OsModelartsNodeNodepoolname != input.OsModelartsNodeNodepoolname || (this.OsModelartsNodeNodepoolname != null && !this.OsModelartsNodeNodepoolname.Equals(input.OsModelartsNodeNodepoolname))) return false;

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
                if (this.OsModelartsNodeCluster != null) hashCode = hashCode * 59 + this.OsModelartsNodeCluster.GetHashCode();
                if (this.OsModelartsNodeElasticQuota != null) hashCode = hashCode * 59 + this.OsModelartsNodeElasticQuota.GetHashCode();
                if (this.OsModelartsNodeNodepool != null) hashCode = hashCode * 59 + this.OsModelartsNodeNodepool.GetHashCode();
                if (this.OsModelartsNodeBatchUid != null) hashCode = hashCode * 59 + this.OsModelartsNodeBatchUid.GetHashCode();
                if (this.OsModelartsNodeBatchName != null) hashCode = hashCode * 59 + this.OsModelartsNodeBatchName.GetHashCode();
                if (this.OsModelartsNodeBatchType != null) hashCode = hashCode * 59 + this.OsModelartsNodeBatchType.GetHashCode();
                if (this.OsModelartsNodeBatchCount != null) hashCode = hashCode * 59 + this.OsModelartsNodeBatchCount.GetHashCode();
                if (this.OsModelartsResourceId != null) hashCode = hashCode * 59 + this.OsModelartsResourceId.GetHashCode();
                if (this.OsModelartsTenantDomainId != null) hashCode = hashCode * 59 + this.OsModelartsTenantDomainId.GetHashCode();
                if (this.OsModelartsTenantProjectId != null) hashCode = hashCode * 59 + this.OsModelartsTenantProjectId.GetHashCode();
                if (this.OsModelartsBillingStatus != null) hashCode = hashCode * 59 + this.OsModelartsBillingStatus.GetHashCode();
                if (this.OsModelartsNodeVolcanoSchedulerCabinetExclusive != null) hashCode = hashCode * 59 + this.OsModelartsNodeVolcanoSchedulerCabinetExclusive.GetHashCode();
                if (this.CceKubectlKubernetesIoCabinet != null) hashCode = hashCode * 59 + this.CceKubectlKubernetesIoCabinet.GetHashCode();
                if (this.OsModelartsNodeUnderlyingInstanceId != null) hashCode = hashCode * 59 + this.OsModelartsNodeUnderlyingInstanceId.GetHashCode();
                if (this.OsModelartsNodeHaRedundantEnabled != null) hashCode = hashCode * 59 + this.OsModelartsNodeHaRedundantEnabled.GetHashCode();
                if (this.OsModelartsNodeNodepoolname != null) hashCode = hashCode * 59 + this.OsModelartsNodeNodepoolname.GetHashCode();
                return hashCode;
            }
        }
    }
}
