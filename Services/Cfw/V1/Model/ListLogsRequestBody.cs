using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// **参数解释**： 查询条件 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
    /// </summary>
    public class ListLogsRequestBody 
    {
        /// <summary>
        /// **参数解释**： 日志类型 **约束限制**： 不涉及 **取值范围**： internet为南北向日志、nat为nat场景日志，vpc为东西向日志，vgw为vgw场景日志 **默认取值**： 不涉及
        /// </summary>
        /// <value>**参数解释**： 日志类型 **约束限制**： 不涉及 **取值范围**： internet为南北向日志、nat为nat场景日志，vpc为东西向日志，vgw为vgw场景日志 **默认取值**： 不涉及</value>
        [JsonConverter(typeof(EnumClassConverter<LogTypeEnum>))]
        public class LogTypeEnum
        {
            /// <summary>
            /// Enum INTERNET for value: internet
            /// </summary>
            public static readonly LogTypeEnum INTERNET = new LogTypeEnum("internet");

            /// <summary>
            /// Enum NAT for value: nat
            /// </summary>
            public static readonly LogTypeEnum NAT = new LogTypeEnum("nat");

            /// <summary>
            /// Enum VPC for value: vpc
            /// </summary>
            public static readonly LogTypeEnum VPC = new LogTypeEnum("vpc");

            /// <summary>
            /// Enum VGW for value: vgw
            /// </summary>
            public static readonly LogTypeEnum VGW = new LogTypeEnum("vgw");

            private static readonly Dictionary<string, LogTypeEnum> StaticFields =
            new Dictionary<string, LogTypeEnum>()
            {
                { "internet", INTERNET },
                { "nat", NAT },
                { "vpc", VPC },
                { "vgw", VGW },
            };

            private string _value;

            public LogTypeEnum()
            {

            }

            public LogTypeEnum(string value)
            {
                _value = value;
            }

            public static LogTypeEnum FromValue(string value)
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

                if (this.Equals(obj as LogTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(LogTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(LogTypeEnum a, LogTypeEnum b)
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

            public static bool operator !=(LogTypeEnum a, LogTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**： 日志类型 **约束限制**： 不涉及 **取值范围**： attack为攻击日志、acl 访问控制日志，flow 流量日志，url url日志 **默认取值**： 不涉及
        /// </summary>
        /// <value>**参数解释**： 日志类型 **约束限制**： 不涉及 **取值范围**： attack为攻击日志、acl 访问控制日志，flow 流量日志，url url日志 **默认取值**： 不涉及</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum ATTACK for value: attack
            /// </summary>
            public static readonly TypeEnum ATTACK = new TypeEnum("attack");

            /// <summary>
            /// Enum ACL for value: acl
            /// </summary>
            public static readonly TypeEnum ACL = new TypeEnum("acl");

            /// <summary>
            /// Enum FLOW for value: flow
            /// </summary>
            public static readonly TypeEnum FLOW = new TypeEnum("flow");

            /// <summary>
            /// Enum URL for value: url
            /// </summary>
            public static readonly TypeEnum URL = new TypeEnum("url");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "attack", ATTACK },
                { "acl", ACL },
                { "flow", FLOW },
                { "url", URL },
            };

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
            }

            public static TypeEnum FromValue(string value)
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

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： 过滤条件 **约束限制**： 不涉及 **取值范围**： 1-1024 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("filters", NullValueHandling = NullValueHandling.Ignore)]
        public List<Filter> Filters { get; set; }

        /// <summary>
        /// **参数解释**： 每页显示个数 **约束限制**： 不涉及 **取值范围**： 1-1024 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// **参数解释**： 偏移量 **约束限制**： 第一页为空，其他页不为空 **取值范围**： 相对于上一页的偏移量 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// **参数解释**： 文档ID **约束限制**： 第一页为空，其他页不为空 **取值范围**： 上一次查询最后一条数据的log_id **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("log_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogId { get; set; }

        /// <summary>
        /// **参数解释**： 下个日期 **约束限制**： 第一页为空，其他页不为空 **取值范围**： 查询流量日志时为上一次查询最后一条数据的end_time 查询访问控制日志时为上一次查询最后一条数据的hit_time 查询访问控制日志时为上一次查询最后一条数据的event_time 查询URL日志时为上一次查询最后一条数据的hit_time **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("next_date", NullValueHandling = NullValueHandling.Ignore)]
        public long? NextDate { get; set; }

        /// <summary>
        /// **参数解释**： 开始时间 **约束限制**： 不涉及 **取值范围**： 毫秒级时间戳 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartTime { get; set; }

        /// <summary>
        /// **参数解释**： 结束时间 **约束限制**： 不涉及 **取值范围**： 毫秒级时间戳 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndTime { get; set; }

        /// <summary>
        /// **参数解释**： 日志类型 **约束限制**： 不涉及 **取值范围**： internet为南北向日志、nat为nat场景日志，vpc为东西向日志，vgw为vgw场景日志 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("log_type", NullValueHandling = NullValueHandling.Ignore)]
        public LogTypeEnum LogType { get; set; }
        /// <summary>
        /// **参数解释**： 日志类型 **约束限制**： 不涉及 **取值范围**： attack为攻击日志、acl 访问控制日志，flow 流量日志，url url日志 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListLogsRequestBody {\n");
            sb.Append("  filters: ").Append(Filters).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  logId: ").Append(LogId).Append("\n");
            sb.Append("  nextDate: ").Append(NextDate).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  logType: ").Append(LogType).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListLogsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListLogsRequestBody input)
        {
            if (input == null) return false;
            if (this.Filters != input.Filters || (this.Filters != null && input.Filters != null && !this.Filters.SequenceEqual(input.Filters))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.LogId != input.LogId || (this.LogId != null && !this.LogId.Equals(input.LogId))) return false;
            if (this.NextDate != input.NextDate || (this.NextDate != null && !this.NextDate.Equals(input.NextDate))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.LogType != input.LogType) return false;
            if (this.Type != input.Type) return false;

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
                if (this.Filters != null) hashCode = hashCode * 59 + this.Filters.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.LogId != null) hashCode = hashCode * 59 + this.LogId.GetHashCode();
                if (this.NextDate != null) hashCode = hashCode * 59 + this.NextDate.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                hashCode = hashCode * 59 + this.LogType.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
