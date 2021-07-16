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
    /// 诊断项
    /// </summary>
    public class DiagnosisItem 
    {
        /// <summary>
        /// 诊断项名称
        /// </summary>
        /// <value>诊断项名称</value>
        [JsonConverter(typeof(EnumClassConverter<NameEnum>))]
        public class NameEnum
        {
            /// <summary>
            /// Enum CONNECTION_NUM for value: connection_num
            /// </summary>
            public static readonly NameEnum CONNECTION_NUM = new NameEnum("connection_num");

            /// <summary>
            /// Enum RX_CONTROLLED for value: rx_controlled
            /// </summary>
            public static readonly NameEnum RX_CONTROLLED = new NameEnum("rx_controlled");

            /// <summary>
            /// Enum PERSISTENCE for value: persistence
            /// </summary>
            public static readonly NameEnum PERSISTENCE = new NameEnum("persistence");

            /// <summary>
            /// Enum CENTRALIZED_EXPIRATION for value: centralized_expiration
            /// </summary>
            public static readonly NameEnum CENTRALIZED_EXPIRATION = new NameEnum("centralized_expiration");

            /// <summary>
            /// Enum INNER_MEMORY_FRAGMENTATION for value: inner_memory_fragmentation
            /// </summary>
            public static readonly NameEnum INNER_MEMORY_FRAGMENTATION = new NameEnum("inner_memory_fragmentation");

            /// <summary>
            /// Enum TIME_CONSUMING_COMMANDS for value: time_consuming_commands
            /// </summary>
            public static readonly NameEnum TIME_CONSUMING_COMMANDS = new NameEnum("time_consuming_commands");

            /// <summary>
            /// Enum HIT_RATIO for value: hit_ratio
            /// </summary>
            public static readonly NameEnum HIT_RATIO = new NameEnum("hit_ratio");

            /// <summary>
            /// Enum MEMORY_USAGE for value: memory_usage
            /// </summary>
            public static readonly NameEnum MEMORY_USAGE = new NameEnum("memory_usage");

            /// <summary>
            /// Enum CPU_USAGE for value: cpu_usage
            /// </summary>
            public static readonly NameEnum CPU_USAGE = new NameEnum("cpu_usage");

            private static readonly Dictionary<string, NameEnum> StaticFields =
            new Dictionary<string, NameEnum>()
            {
                { "connection_num", CONNECTION_NUM },
                { "rx_controlled", RX_CONTROLLED },
                { "persistence", PERSISTENCE },
                { "centralized_expiration", CENTRALIZED_EXPIRATION },
                { "inner_memory_fragmentation", INNER_MEMORY_FRAGMENTATION },
                { "time_consuming_commands", TIME_CONSUMING_COMMANDS },
                { "hit_ratio", HIT_RATIO },
                { "memory_usage", MEMORY_USAGE },
                { "cpu_usage", CPU_USAGE },
            };

            private string Value;

            public NameEnum(string value)
            {
                Value = value;
            }

            public static NameEnum FromValue(string value)
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as NameEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(NameEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(NameEnum a, NameEnum b)
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

            public static bool operator !=(NameEnum a, NameEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 诊断结果
        /// </summary>
        /// <value>诊断结果</value>
        [JsonConverter(typeof(EnumClassConverter<ResultEnum>))]
        public class ResultEnum
        {
            /// <summary>
            /// Enum FAILED for value: failed
            /// </summary>
            public static readonly ResultEnum FAILED = new ResultEnum("failed");

            /// <summary>
            /// Enum ABNORMAL for value: abnormal
            /// </summary>
            public static readonly ResultEnum ABNORMAL = new ResultEnum("abnormal");

            /// <summary>
            /// Enum NORMAL for value: normal
            /// </summary>
            public static readonly ResultEnum NORMAL = new ResultEnum("normal");

            private static readonly Dictionary<string, ResultEnum> StaticFields =
            new Dictionary<string, ResultEnum>()
            {
                { "failed", FAILED },
                { "abnormal", ABNORMAL },
                { "normal", NORMAL },
            };

            private string Value;

            public ResultEnum(string value)
            {
                Value = value;
            }

            public static ResultEnum FromValue(string value)
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as ResultEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ResultEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(ResultEnum a, ResultEnum b)
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

            public static bool operator !=(ResultEnum a, ResultEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 诊断项名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public NameEnum Name { get; set; }
        /// <summary>
        /// 原因ID列表
        /// </summary>
        [JsonProperty("cause_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<ConclusionItem> CauseIds { get; set; }

        /// <summary>
        /// 影响ID列表
        /// </summary>
        [JsonProperty("impact_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<ConclusionItem> ImpactIds { get; set; }

        /// <summary>
        /// 建议ID列表
        /// </summary>
        [JsonProperty("advice_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<ConclusionItem> AdviceIds { get; set; }

        /// <summary>
        /// 诊断结果
        /// </summary>
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public ResultEnum Result { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DiagnosisItem {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  causeIds: ").Append(CauseIds).Append("\n");
            sb.Append("  impactIds: ").Append(ImpactIds).Append("\n");
            sb.Append("  adviceIds: ").Append(AdviceIds).Append("\n");
            sb.Append("  result: ").Append(Result).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DiagnosisItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DiagnosisItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.CauseIds == input.CauseIds ||
                    this.CauseIds != null &&
                    input.CauseIds != null &&
                    this.CauseIds.SequenceEqual(input.CauseIds)
                ) && 
                (
                    this.ImpactIds == input.ImpactIds ||
                    this.ImpactIds != null &&
                    input.ImpactIds != null &&
                    this.ImpactIds.SequenceEqual(input.ImpactIds)
                ) && 
                (
                    this.AdviceIds == input.AdviceIds ||
                    this.AdviceIds != null &&
                    input.AdviceIds != null &&
                    this.AdviceIds.SequenceEqual(input.AdviceIds)
                ) && 
                (
                    this.Result == input.Result ||
                    (this.Result != null &&
                    this.Result.Equals(input.Result))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.CauseIds != null)
                    hashCode = hashCode * 59 + this.CauseIds.GetHashCode();
                if (this.ImpactIds != null)
                    hashCode = hashCode * 59 + this.ImpactIds.GetHashCode();
                if (this.AdviceIds != null)
                    hashCode = hashCode * 59 + this.AdviceIds.GetHashCode();
                if (this.Result != null)
                    hashCode = hashCode * 59 + this.Result.GetHashCode();
                return hashCode;
            }
        }
    }
}
