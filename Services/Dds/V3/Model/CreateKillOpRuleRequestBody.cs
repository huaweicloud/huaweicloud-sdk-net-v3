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
    /// 
    /// </summary>
    public class CreateKillOpRuleRequestBody 
    {

        /// <summary>
        /// Sql语句操作类型。 最多支持同时选择6种语句类型。同时选择多种类型时，匹配任意一种类型时规则生效。 - insert，表示插入语句。  - update，表示更新语句。  - query，表示查询语句。  - command，表示命令语句。  - remove，表示删除语句。  - getmore，表示获取更多数据语句。
        /// </summary>
        [JsonProperty("operation_types", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> OperationTypes { get; set; }

        /// <summary>
        /// 表命名空间。取值格式：库名.表名。同时配置多组信息时，匹配任意一组信息时规则生效。 - 目前仅支持配置一组信息 - 可为空，表示不做限制。 - 单独库名，表示对某个库下的所有集合生效。 - 库名.表名，表示对具体库下的具体的集合生效。
        /// </summary>
        [JsonProperty("namespaces", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Namespaces { get; set; }

        /// <summary>
        /// 客户端连接IP。只支持IPV4。可为空，表示不做限制。最多支持配置5个IP。同时配置多个IP时，匹配任意一个IP时规则生效。
        /// </summary>
        [JsonProperty("client_ips", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ClientIps { get; set; }

        /// <summary>
        /// 执行计划。 默认值空，表示不做限制。  - COLLSCAN。 - SORT_KEY_GENERATOR。 - SKIP。 - LIMIT。 - GEO_NEAR_2DSPHERE。 - GEO_NEAR_2D。 - AGGREGATE。 - OR。
        /// </summary>
        [JsonProperty("plan_summary", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanSummary { get; set; }

        /// <summary>
        /// 最大并发数。 取值： 不能为负数，可为空，默认为0，表示不做限制， 最小值为1， 最大值为100000。secs_running和max_concurrency不可同时为0。
        /// </summary>
        [JsonProperty("max_concurrency", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxConcurrency { get; set; }

        /// <summary>
        /// 单条操作最大运行时长。可为空，默认为0，表示不做限制。单位：s。最小值为2， 最大值为86400。secs_running和max_concurrency不可同时为0。
        /// </summary>
        [JsonProperty("secs_running", NullValueHandling = NullValueHandling.Ignore)]
        public int? SecsRunning { get; set; }

        /// <summary>
        /// 节点类型。  - mongos_shard，表示同时在mongos和shard节点生效。 - mongos，表示只在集群mongos节点生效。 - shard，表示只在集群shard节点生效。 - replica，表示只在副本集节点生效。
        /// </summary>
        [JsonProperty("node_type", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateKillOpRuleRequestBody {\n");
            sb.Append("  operationTypes: ").Append(OperationTypes).Append("\n");
            sb.Append("  namespaces: ").Append(Namespaces).Append("\n");
            sb.Append("  clientIps: ").Append(ClientIps).Append("\n");
            sb.Append("  planSummary: ").Append(PlanSummary).Append("\n");
            sb.Append("  maxConcurrency: ").Append(MaxConcurrency).Append("\n");
            sb.Append("  secsRunning: ").Append(SecsRunning).Append("\n");
            sb.Append("  nodeType: ").Append(NodeType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateKillOpRuleRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateKillOpRuleRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OperationTypes == input.OperationTypes ||
                    this.OperationTypes != null &&
                    input.OperationTypes != null &&
                    this.OperationTypes.SequenceEqual(input.OperationTypes)
                ) && 
                (
                    this.Namespaces == input.Namespaces ||
                    this.Namespaces != null &&
                    input.Namespaces != null &&
                    this.Namespaces.SequenceEqual(input.Namespaces)
                ) && 
                (
                    this.ClientIps == input.ClientIps ||
                    this.ClientIps != null &&
                    input.ClientIps != null &&
                    this.ClientIps.SequenceEqual(input.ClientIps)
                ) && 
                (
                    this.PlanSummary == input.PlanSummary ||
                    (this.PlanSummary != null &&
                    this.PlanSummary.Equals(input.PlanSummary))
                ) && 
                (
                    this.MaxConcurrency == input.MaxConcurrency ||
                    (this.MaxConcurrency != null &&
                    this.MaxConcurrency.Equals(input.MaxConcurrency))
                ) && 
                (
                    this.SecsRunning == input.SecsRunning ||
                    (this.SecsRunning != null &&
                    this.SecsRunning.Equals(input.SecsRunning))
                ) && 
                (
                    this.NodeType == input.NodeType ||
                    (this.NodeType != null &&
                    this.NodeType.Equals(input.NodeType))
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
                if (this.OperationTypes != null)
                    hashCode = hashCode * 59 + this.OperationTypes.GetHashCode();
                if (this.Namespaces != null)
                    hashCode = hashCode * 59 + this.Namespaces.GetHashCode();
                if (this.ClientIps != null)
                    hashCode = hashCode * 59 + this.ClientIps.GetHashCode();
                if (this.PlanSummary != null)
                    hashCode = hashCode * 59 + this.PlanSummary.GetHashCode();
                if (this.MaxConcurrency != null)
                    hashCode = hashCode * 59 + this.MaxConcurrency.GetHashCode();
                if (this.SecsRunning != null)
                    hashCode = hashCode * 59 + this.SecsRunning.GetHashCode();
                if (this.NodeType != null)
                    hashCode = hashCode * 59 + this.NodeType.GetHashCode();
                return hashCode;
            }
        }
    }
}
