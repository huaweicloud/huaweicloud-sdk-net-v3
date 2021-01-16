using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Trigger 
    {

        /// <summary>
        /// 触发动作，update
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }

        /// <summary>
        /// 应用类型，deployments、statefulsets
        /// </summary>
        [JsonProperty("app_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AppType { get; set; }

        /// <summary>
        /// 应用名
        /// </summary>
        [JsonProperty("application", NullValueHandling = NullValueHandling.Ignore)]
        public string Application { get; set; }

        /// <summary>
        /// 集群ID（cci时为空）
        /// </summary>
        [JsonProperty("cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterId { get; set; }

        /// <summary>
        /// 集群名（cci时为空）
        /// </summary>
        [JsonProperty("cluster_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterName { get; set; }

        /// <summary>
        /// 应用名所在的namespace
        /// </summary>
        [JsonProperty("cluster_ns", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterNs { get; set; }

        /// <summary>
        /// 触发条件，type为all时为.*,type为tag时为tag名,type为regular时为正则表达式
        /// </summary>
        [JsonProperty("condition", NullValueHandling = NullValueHandling.Ignore)]
        public string Condition { get; set; }

        /// <summary>
        /// 需更新的container名，默认为所有container
        /// </summary>
        [JsonProperty("container", NullValueHandling = NullValueHandling.Ignore)]
        public string Container { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [JsonProperty("creator_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatorName { get; set; }

        /// <summary>
        /// 是否生效
        /// </summary>
        [JsonProperty("enable", NullValueHandling = NullValueHandling.Ignore)]
        public string Enable { get; set; }

        /// <summary>
        /// 触发器名
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 触发器历史
        /// </summary>
        [JsonProperty("trigger_history", NullValueHandling = NullValueHandling.Ignore)]
        public List<TriggerHistorys> TriggerHistory { get; set; }

        /// <summary>
        /// 触发器类型，cce、cci
        /// </summary>
        [JsonProperty("trigger_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string TriggerMode { get; set; }

        /// <summary>
        /// 触发条件，all、tag、regular
        /// </summary>
        [JsonProperty("trigger_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TriggerType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Trigger {\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  appType: ").Append(AppType).Append("\n");
            sb.Append("  application: ").Append(Application).Append("\n");
            sb.Append("  clusterId: ").Append(ClusterId).Append("\n");
            sb.Append("  clusterName: ").Append(ClusterName).Append("\n");
            sb.Append("  clusterNs: ").Append(ClusterNs).Append("\n");
            sb.Append("  condition: ").Append(Condition).Append("\n");
            sb.Append("  container: ").Append(Container).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  creatorName: ").Append(CreatorName).Append("\n");
            sb.Append("  enable: ").Append(Enable).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  triggerHistory: ").Append(TriggerHistory).Append("\n");
            sb.Append("  triggerMode: ").Append(TriggerMode).Append("\n");
            sb.Append("  triggerType: ").Append(TriggerType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Trigger);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Trigger input)
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
                    this.AppType == input.AppType ||
                    (this.AppType != null &&
                    this.AppType.Equals(input.AppType))
                ) && 
                (
                    this.Application == input.Application ||
                    (this.Application != null &&
                    this.Application.Equals(input.Application))
                ) && 
                (
                    this.ClusterId == input.ClusterId ||
                    (this.ClusterId != null &&
                    this.ClusterId.Equals(input.ClusterId))
                ) && 
                (
                    this.ClusterName == input.ClusterName ||
                    (this.ClusterName != null &&
                    this.ClusterName.Equals(input.ClusterName))
                ) && 
                (
                    this.ClusterNs == input.ClusterNs ||
                    (this.ClusterNs != null &&
                    this.ClusterNs.Equals(input.ClusterNs))
                ) && 
                (
                    this.Condition == input.Condition ||
                    (this.Condition != null &&
                    this.Condition.Equals(input.Condition))
                ) && 
                (
                    this.Container == input.Container ||
                    (this.Container != null &&
                    this.Container.Equals(input.Container))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.CreatorName == input.CreatorName ||
                    (this.CreatorName != null &&
                    this.CreatorName.Equals(input.CreatorName))
                ) && 
                (
                    this.Enable == input.Enable ||
                    (this.Enable != null &&
                    this.Enable.Equals(input.Enable))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.TriggerHistory == input.TriggerHistory ||
                    this.TriggerHistory != null &&
                    input.TriggerHistory != null &&
                    this.TriggerHistory.SequenceEqual(input.TriggerHistory)
                ) && 
                (
                    this.TriggerMode == input.TriggerMode ||
                    (this.TriggerMode != null &&
                    this.TriggerMode.Equals(input.TriggerMode))
                ) && 
                (
                    this.TriggerType == input.TriggerType ||
                    (this.TriggerType != null &&
                    this.TriggerType.Equals(input.TriggerType))
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
                if (this.AppType != null)
                    hashCode = hashCode * 59 + this.AppType.GetHashCode();
                if (this.Application != null)
                    hashCode = hashCode * 59 + this.Application.GetHashCode();
                if (this.ClusterId != null)
                    hashCode = hashCode * 59 + this.ClusterId.GetHashCode();
                if (this.ClusterName != null)
                    hashCode = hashCode * 59 + this.ClusterName.GetHashCode();
                if (this.ClusterNs != null)
                    hashCode = hashCode * 59 + this.ClusterNs.GetHashCode();
                if (this.Condition != null)
                    hashCode = hashCode * 59 + this.Condition.GetHashCode();
                if (this.Container != null)
                    hashCode = hashCode * 59 + this.Container.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.CreatorName != null)
                    hashCode = hashCode * 59 + this.CreatorName.GetHashCode();
                if (this.Enable != null)
                    hashCode = hashCode * 59 + this.Enable.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.TriggerHistory != null)
                    hashCode = hashCode * 59 + this.TriggerHistory.GetHashCode();
                if (this.TriggerMode != null)
                    hashCode = hashCode * 59 + this.TriggerMode.GetHashCode();
                if (this.TriggerType != null)
                    hashCode = hashCode * 59 + this.TriggerType.GetHashCode();
                return hashCode;
            }
        }
    }
}
