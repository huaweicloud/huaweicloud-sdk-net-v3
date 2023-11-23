using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dds.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowKillOpRuleRuleListRequest 
    {

        /// <summary>
        /// 实例ID，可以调用“[查询实例列表和详情](x-wc://file&#x3D;zh-cn_topic_0000001369935045.xml)”接口获取。如果未申请实例，可以调用“[创建实例](x-wc://file&#x3D;zh-cn_topic_0000001369734929.xml)”接口创建。
        /// </summary>
        [SDKProperty("instance_id", IsPath = true)]
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Sql语句操作类型。  - insert，表示插入语句。  - update，表示更新语句。  - query，表示查询语句。  - command，表示命令语句。  - remove，表示删除语句。  - getmore，表示获取更多数据语句。
        /// </summary>
        [SDKProperty("operation_types", IsQuery = true)]
        [JsonProperty("operation_types", NullValueHandling = NullValueHandling.Ignore)]
        public string OperationTypes { get; set; }

        /// <summary>
        /// 表命名空间。取值格式：库名.表名。 - 可为空，表示不做限制。 - 单独库名，表示对某个库下的所有集合生效。 - 库名.表名，表示对具体库下的具体的集合生效。
        /// </summary>
        [SDKProperty("namespaces", IsQuery = true)]
        [JsonProperty("namespaces", NullValueHandling = NullValueHandling.Ignore)]
        public string Namespaces { get; set; }

        /// <summary>
        /// killOp规则状态。  - ENABLED，规则生效中。 - DISABLED，规则禁用中。
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 执行计划。 默认值空，表示不做限制。  - COLLSCAN。 - SORT_KEY_GENERATOR。 - SKIP。 - LIMIT。 - GEO_NEAR_2DSPHERE。 - GEO_NEAR_2D。 - AGGREGATE。 - OR。
        /// </summary>
        [SDKProperty("plan_summary", IsQuery = true)]
        [JsonProperty("plan_summary", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanSummary { get; set; }

        /// <summary>
        /// 索引位置，偏移量。  从第一条数据偏移offset条数据后开始查询，默认为0（偏移0条数据，表示从第一条数据开始查询）。 取值必须为数字，不能为负数。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 查询个数上限值。 - 取值范围: 1~100。 - 不传该参数时，默认查询前100条信息。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowKillOpRuleRuleListRequest {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  operationTypes: ").Append(OperationTypes).Append("\n");
            sb.Append("  namespaces: ").Append(Namespaces).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  planSummary: ").Append(PlanSummary).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowKillOpRuleRuleListRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowKillOpRuleRuleListRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.OperationTypes == input.OperationTypes ||
                    (this.OperationTypes != null &&
                    this.OperationTypes.Equals(input.OperationTypes))
                ) && 
                (
                    this.Namespaces == input.Namespaces ||
                    (this.Namespaces != null &&
                    this.Namespaces.Equals(input.Namespaces))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.PlanSummary == input.PlanSummary ||
                    (this.PlanSummary != null &&
                    this.PlanSummary.Equals(input.PlanSummary))
                ) && 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
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
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.OperationTypes != null)
                    hashCode = hashCode * 59 + this.OperationTypes.GetHashCode();
                if (this.Namespaces != null)
                    hashCode = hashCode * 59 + this.Namespaces.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.PlanSummary != null)
                    hashCode = hashCode * 59 + this.PlanSummary.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
