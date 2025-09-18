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
    public class ListMongodbSlowLogsRequestBody 
    {
        /// <summary>
        /// 语句类型，取空值，表示查询所有语句类型。
        /// </summary>
        /// <value>语句类型，取空值，表示查询所有语句类型。</value>
        [JsonConverter(typeof(EnumClassConverter<OperateTypeEnum>))]
        public class OperateTypeEnum
        {
            /// <summary>
            /// Enum INSERT for value: insert
            /// </summary>
            public static readonly OperateTypeEnum INSERT = new OperateTypeEnum("insert");

            /// <summary>
            /// Enum QUERY for value: query
            /// </summary>
            public static readonly OperateTypeEnum QUERY = new OperateTypeEnum("query");

            /// <summary>
            /// Enum UPDATE for value: update
            /// </summary>
            public static readonly OperateTypeEnum UPDATE = new OperateTypeEnum("update");

            /// <summary>
            /// Enum REMOVE for value: remove
            /// </summary>
            public static readonly OperateTypeEnum REMOVE = new OperateTypeEnum("remove");

            /// <summary>
            /// Enum GETMORE for value: getmore
            /// </summary>
            public static readonly OperateTypeEnum GETMORE = new OperateTypeEnum("getmore");

            /// <summary>
            /// Enum COMMAND for value: command
            /// </summary>
            public static readonly OperateTypeEnum COMMAND = new OperateTypeEnum("command");

            /// <summary>
            /// Enum KILLCURSORS for value: killcursors
            /// </summary>
            public static readonly OperateTypeEnum KILLCURSORS = new OperateTypeEnum("killcursors");

            private static readonly Dictionary<string, OperateTypeEnum> StaticFields =
            new Dictionary<string, OperateTypeEnum>()
            {
                { "insert", INSERT },
                { "query", QUERY },
                { "update", UPDATE },
                { "remove", REMOVE },
                { "getmore", GETMORE },
                { "command", COMMAND },
                { "killcursors", KILLCURSORS },
            };

            private string _value;

            public OperateTypeEnum()
            {

            }

            public OperateTypeEnum(string value)
            {
                _value = value;
            }

            public static OperateTypeEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as OperateTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OperateTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OperateTypeEnum a, OperateTypeEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(OperateTypeEnum a, OperateTypeEnum b)
            {
                return !(a == b);
            }
        }


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
        /// 语句类型，取空值，表示查询所有语句类型。
        /// </summary>
        [JsonProperty("operate_type", NullValueHandling = NullValueHandling.Ignore)]
        public OperateTypeEnum OperateType { get; set; }
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
        /// 根据多个数据库库名关键字模糊搜索日志，表示匹配至少一个关键字。 - 只支持关键字前缀模糊搜索，最多支持10个关键字。 - 每个关键字最大长度不超过64个字符。
        /// </summary>
        [JsonProperty("database_keywords", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DatabaseKeywords { get; set; }

        /// <summary>
        /// 根据多个数据库集合名称关键字模糊搜索日志，表示匹配至少一个关键字。 - 只支持关键字前缀模糊搜索，最多支持10个关键字。 - 每个关键字最大长度不超过128个字符。
        /// </summary>
        [JsonProperty("collection_keywords", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CollectionKeywords { get; set; }

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
            sb.Append("class ListMongodbSlowLogsRequestBody {\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  lineNum: ").Append(LineNum).Append("\n");
            sb.Append("  operateType: ").Append(OperateType).Append("\n");
            sb.Append("  nodeId: ").Append(NodeId).Append("\n");
            sb.Append("  keywords: ").Append(Keywords).Append("\n");
            sb.Append("  databaseKeywords: ").Append(DatabaseKeywords).Append("\n");
            sb.Append("  collectionKeywords: ").Append(CollectionKeywords).Append("\n");
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
            return this.Equals(input as ListMongodbSlowLogsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListMongodbSlowLogsRequestBody input)
        {
            if (input == null) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.LineNum != input.LineNum || (this.LineNum != null && !this.LineNum.Equals(input.LineNum))) return false;
            if (this.OperateType != input.OperateType) return false;
            if (this.NodeId != input.NodeId || (this.NodeId != null && !this.NodeId.Equals(input.NodeId))) return false;
            if (this.Keywords != input.Keywords || (this.Keywords != null && input.Keywords != null && !this.Keywords.SequenceEqual(input.Keywords))) return false;
            if (this.DatabaseKeywords != input.DatabaseKeywords || (this.DatabaseKeywords != null && input.DatabaseKeywords != null && !this.DatabaseKeywords.SequenceEqual(input.DatabaseKeywords))) return false;
            if (this.CollectionKeywords != input.CollectionKeywords || (this.CollectionKeywords != null && input.CollectionKeywords != null && !this.CollectionKeywords.SequenceEqual(input.CollectionKeywords))) return false;
            if (this.MaxCostTime != input.MaxCostTime || (this.MaxCostTime != null && !this.MaxCostTime.Equals(input.MaxCostTime))) return false;
            if (this.MinCostTime != input.MinCostTime || (this.MinCostTime != null && !this.MinCostTime.Equals(input.MinCostTime))) return false;

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
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.LineNum != null) hashCode = hashCode * 59 + this.LineNum.GetHashCode();
                hashCode = hashCode * 59 + this.OperateType.GetHashCode();
                if (this.NodeId != null) hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                if (this.Keywords != null) hashCode = hashCode * 59 + this.Keywords.GetHashCode();
                if (this.DatabaseKeywords != null) hashCode = hashCode * 59 + this.DatabaseKeywords.GetHashCode();
                if (this.CollectionKeywords != null) hashCode = hashCode * 59 + this.CollectionKeywords.GetHashCode();
                if (this.MaxCostTime != null) hashCode = hashCode * 59 + this.MaxCostTime.GetHashCode();
                if (this.MinCostTime != null) hashCode = hashCode * 59 + this.MinCostTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
