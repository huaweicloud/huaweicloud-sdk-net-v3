using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class CreateRedislogRequest 
    {
        /// <summary>
        /// 日期偏移量，表示从过去的n天开始查询，例如：传入0则表示查询今天的日志，传入7则表示查询过去7天的日志。当前支持0，1，3，7。
        /// </summary>
        /// <value>日期偏移量，表示从过去的n天开始查询，例如：传入0则表示查询今天的日志，传入7则表示查询过去7天的日志。当前支持0，1，3，7。</value>
        [JsonConverter(typeof(EnumClassConverter<QueryTimeEnum>))]
        public class QueryTimeEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            public static readonly QueryTimeEnum NUMBER_0 = new QueryTimeEnum(0);

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly QueryTimeEnum NUMBER_1 = new QueryTimeEnum(1);

            /// <summary>
            /// Enum NUMBER_3 for value: 3
            /// </summary>
            public static readonly QueryTimeEnum NUMBER_3 = new QueryTimeEnum(3);

            /// <summary>
            /// Enum NUMBER_7 for value: 7
            /// </summary>
            public static readonly QueryTimeEnum NUMBER_7 = new QueryTimeEnum(7);

            private static readonly Dictionary<int?, QueryTimeEnum> StaticFields =
            new Dictionary<int?, QueryTimeEnum>()
            {
                { 0, NUMBER_0 },
                { 1, NUMBER_1 },
                { 3, NUMBER_3 },
                { 7, NUMBER_7 },
            };

            private int? _value;

            public QueryTimeEnum()
            {

            }

            public QueryTimeEnum(int? value)
            {
                _value = value;
            }

            public static QueryTimeEnum FromValue(int? value)
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

            public int? GetValue()
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

                if (this.Equals(obj as QueryTimeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(QueryTimeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(QueryTimeEnum a, QueryTimeEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(QueryTimeEnum a, QueryTimeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 实例ID。
        /// </summary>
        [SDKProperty("instance_id", IsPath = true)]
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 日期偏移量，表示从过去的n天开始查询，例如：传入0则表示查询今天的日志，传入7则表示查询过去7天的日志。当前支持0，1，3，7。
        /// </summary>
        [SDKProperty("query_time", IsQuery = true)]
        [JsonProperty("query_time", NullValueHandling = NullValueHandling.Ignore)]
        public QueryTimeEnum QueryTime { get; set; }
        /// <summary>
        /// 返回日志的类型，当前仅支持Redis运行日志，类型为run
        /// </summary>
        [SDKProperty("log_type", IsQuery = true)]
        [JsonProperty("log_type", NullValueHandling = NullValueHandling.Ignore)]
        public string LogType { get; set; }

        /// <summary>
        /// 副本ID，可以从分片与副本中查询对应节点的副本ID
        /// </summary>
        [SDKProperty("replication_id", IsQuery = true)]
        [JsonProperty("replication_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ReplicationId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateRedislogRequest {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  queryTime: ").Append(QueryTime).Append("\n");
            sb.Append("  logType: ").Append(LogType).Append("\n");
            sb.Append("  replicationId: ").Append(ReplicationId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateRedislogRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateRedislogRequest input)
        {
            if (input == null) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.QueryTime != input.QueryTime) return false;
            if (this.LogType != input.LogType || (this.LogType != null && !this.LogType.Equals(input.LogType))) return false;
            if (this.ReplicationId != input.ReplicationId || (this.ReplicationId != null && !this.ReplicationId.Equals(input.ReplicationId))) return false;

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
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                hashCode = hashCode * 59 + this.QueryTime.GetHashCode();
                if (this.LogType != null) hashCode = hashCode * 59 + this.LogType.GetHashCode();
                if (this.ReplicationId != null) hashCode = hashCode * 59 + this.ReplicationId.GetHashCode();
                return hashCode;
            }
        }
    }
}
