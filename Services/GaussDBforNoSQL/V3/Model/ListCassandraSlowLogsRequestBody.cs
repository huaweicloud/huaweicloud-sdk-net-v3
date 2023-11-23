using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ListCassandraSlowLogsRequestBody 
    {

        /// <summary>
        /// 开始时间，格式为“yyyy-mm-ddThh:mm:ssZ”。 其中，T指某个时间的开始；Z指时区偏移量，例如北京时间偏移显示为+0800。注：开始时间不得早于当前时间30天。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 结束时间，格式为“yyyy-mm-ddThh:mm:ssZ”。 其中，T指某个时间的开始；Z指时区偏移量，例如北京时间偏移显示为+0800。注：结束时间不能晚于当前时间。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 表示每次查询的日志条数，最大限制100条。
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 日志单行序列号，第一次查询时不需要此参数，下一次查询时需要使用，可从上一次查询的返回信息中获取。 说明：当次查询从line_num的下一条日志开始查询，不包含当前line_num日志。
        /// </summary>
        [JsonProperty("line_num", NullValueHandling = NullValueHandling.Ignore)]
        public string LineNum { get; set; }

        /// <summary>
        /// 语句类型，取空值，表示查询所有语句类型。 取值：select
        /// </summary>
        [JsonProperty("operate_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OperateType { get; set; }

        /// <summary>
        /// 节点ID，取空值，表示查询实例下所有允许查询的节点。 具体取值请参考查询实例列表和详情接口\&quot;ListInstances\&quot;中nodes字段数据结构说明的“id”。
        /// </summary>
        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; }

        /// <summary>
        /// 根据多个关键字搜索日志全文，表示同时匹配所有关键字。 - 最多支持10个关键字。 - 每个关键字最大长度不超过512个字符。
        /// </summary>
        [JsonProperty("keywords", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Keywords { get; set; }

        /// <summary>
        /// 根据多个键空间关键字模糊搜索日志，表示匹配至少一个关键字。 - 只支持关键字前缀模糊搜索，最多支持10个关键字。 - 每个关键字最大长度不超过48个字符。
        /// </summary>
        [JsonProperty("keyspace_keywords", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> KeyspaceKeywords { get; set; }

        /// <summary>
        /// 根据多个数据库表名关键字模糊搜索日志，表示匹配至少一个关键字。 - 只支持关键字前缀模糊搜索，最多支持10个关键字。 - 每个关键字最大长度不超过48个字符。
        /// </summary>
        [JsonProperty("table_keywords", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TableKeywords { get; set; }

        /// <summary>
        /// 支持根据最大执行时间范围查找日志。单位：ms
        /// </summary>
        [JsonProperty("max_cost_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxCostTime { get; set; }

        /// <summary>
        /// 支持根据最小执行时间范围查找日志。单位：ms
        /// </summary>
        [JsonProperty("min_cost_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinCostTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListCassandraSlowLogsRequestBody {\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  lineNum: ").Append(LineNum).Append("\n");
            sb.Append("  operateType: ").Append(OperateType).Append("\n");
            sb.Append("  nodeId: ").Append(NodeId).Append("\n");
            sb.Append("  keywords: ").Append(Keywords).Append("\n");
            sb.Append("  keyspaceKeywords: ").Append(KeyspaceKeywords).Append("\n");
            sb.Append("  tableKeywords: ").Append(TableKeywords).Append("\n");
            sb.Append("  maxCostTime: ").Append(MaxCostTime).Append("\n");
            sb.Append("  minCostTime: ").Append(MinCostTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListCassandraSlowLogsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListCassandraSlowLogsRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.LineNum == input.LineNum ||
                    (this.LineNum != null &&
                    this.LineNum.Equals(input.LineNum))
                ) && 
                (
                    this.OperateType == input.OperateType ||
                    (this.OperateType != null &&
                    this.OperateType.Equals(input.OperateType))
                ) && 
                (
                    this.NodeId == input.NodeId ||
                    (this.NodeId != null &&
                    this.NodeId.Equals(input.NodeId))
                ) && 
                (
                    this.Keywords == input.Keywords ||
                    this.Keywords != null &&
                    input.Keywords != null &&
                    this.Keywords.SequenceEqual(input.Keywords)
                ) && 
                (
                    this.KeyspaceKeywords == input.KeyspaceKeywords ||
                    this.KeyspaceKeywords != null &&
                    input.KeyspaceKeywords != null &&
                    this.KeyspaceKeywords.SequenceEqual(input.KeyspaceKeywords)
                ) && 
                (
                    this.TableKeywords == input.TableKeywords ||
                    this.TableKeywords != null &&
                    input.TableKeywords != null &&
                    this.TableKeywords.SequenceEqual(input.TableKeywords)
                ) && 
                (
                    this.MaxCostTime == input.MaxCostTime ||
                    (this.MaxCostTime != null &&
                    this.MaxCostTime.Equals(input.MaxCostTime))
                ) && 
                (
                    this.MinCostTime == input.MinCostTime ||
                    (this.MinCostTime != null &&
                    this.MinCostTime.Equals(input.MinCostTime))
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
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.LineNum != null)
                    hashCode = hashCode * 59 + this.LineNum.GetHashCode();
                if (this.OperateType != null)
                    hashCode = hashCode * 59 + this.OperateType.GetHashCode();
                if (this.NodeId != null)
                    hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                if (this.Keywords != null)
                    hashCode = hashCode * 59 + this.Keywords.GetHashCode();
                if (this.KeyspaceKeywords != null)
                    hashCode = hashCode * 59 + this.KeyspaceKeywords.GetHashCode();
                if (this.TableKeywords != null)
                    hashCode = hashCode * 59 + this.TableKeywords.GetHashCode();
                if (this.MaxCostTime != null)
                    hashCode = hashCode * 59 + this.MaxCostTime.GetHashCode();
                if (this.MinCostTime != null)
                    hashCode = hashCode * 59 + this.MinCostTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
