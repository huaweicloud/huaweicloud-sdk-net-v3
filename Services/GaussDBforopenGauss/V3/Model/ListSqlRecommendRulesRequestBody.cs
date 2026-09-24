using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ListSqlRecommendRulesRequestBody 
    {
        /// <summary>
        /// **参数解释**: 推荐类型。 **约束限制**: 不涉及。 **取值范围**: - all：全部 - exec_count：执行次数 - avg_exec_time：平均执行时间 - max_exec_time：最大执行时间  **默认取值**: all
        /// </summary>
        /// <value>**参数解释**: 推荐类型。 **约束限制**: 不涉及。 **取值范围**: - all：全部 - exec_count：执行次数 - avg_exec_time：平均执行时间 - max_exec_time：最大执行时间  **默认取值**: all</value>
        [JsonConverter(typeof(EnumClassConverter<RecommendTypeEnum>))]
        public class RecommendTypeEnum
        {
            /// <summary>
            /// Enum ALL for value: all
            /// </summary>
            public static readonly RecommendTypeEnum ALL = new RecommendTypeEnum("all");

            /// <summary>
            /// Enum EXEC_COUNT for value: exec_count
            /// </summary>
            public static readonly RecommendTypeEnum EXEC_COUNT = new RecommendTypeEnum("exec_count");

            /// <summary>
            /// Enum AVG_EXEC_TIME for value: avg_exec_time
            /// </summary>
            public static readonly RecommendTypeEnum AVG_EXEC_TIME = new RecommendTypeEnum("avg_exec_time");

            /// <summary>
            /// Enum MAX_EXEC_TIME for value: max_exec_time
            /// </summary>
            public static readonly RecommendTypeEnum MAX_EXEC_TIME = new RecommendTypeEnum("max_exec_time");

            private static readonly Dictionary<string, RecommendTypeEnum> StaticFields =
            new Dictionary<string, RecommendTypeEnum>()
            {
                { "all", ALL },
                { "exec_count", EXEC_COUNT },
                { "avg_exec_time", AVG_EXEC_TIME },
                { "max_exec_time", MAX_EXEC_TIME },
            };

            private string _value;

            public RecommendTypeEnum()
            {

            }

            public RecommendTypeEnum(string value)
            {
                _value = value;
            }

            public static RecommendTypeEnum FromValue(string value)
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

                if (this.Equals(obj as RecommendTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RecommendTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RecommendTypeEnum a, RecommendTypeEnum b)
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

            public static bool operator !=(RecommendTypeEnum a, RecommendTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**: 推荐类型。 **约束限制**: 不涉及。 **取值范围**: - all：全部 - exec_count：执行次数 - avg_exec_time：平均执行时间 - max_exec_time：最大执行时间  **默认取值**: all
        /// </summary>
        [JsonProperty("recommend_type", NullValueHandling = NullValueHandling.Ignore)]
        public RecommendTypeEnum RecommendType { get; set; }
        /// <summary>
        /// **参数解释**: 推荐规则返回条数。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("recommend_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? RecommendCount { get; set; }

        /// <summary>
        /// **参数解释**: 是否使用紧急通道。 **约束限制**: 不涉及。 **取值范围**: - true：开启紧急通道 - false：关闭紧急通道  **默认取值**: false
        /// </summary>
        [JsonProperty("use_ops_tunnel", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseOpsTunnel { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSqlRecommendRulesRequestBody {\n");
            sb.Append("  recommendType: ").Append(RecommendType).Append("\n");
            sb.Append("  recommendCount: ").Append(RecommendCount).Append("\n");
            sb.Append("  useOpsTunnel: ").Append(UseOpsTunnel).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSqlRecommendRulesRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSqlRecommendRulesRequestBody input)
        {
            if (input == null) return false;
            if (this.RecommendType != input.RecommendType) return false;
            if (this.RecommendCount != input.RecommendCount || (this.RecommendCount != null && !this.RecommendCount.Equals(input.RecommendCount))) return false;
            if (this.UseOpsTunnel != input.UseOpsTunnel || (this.UseOpsTunnel != null && !this.UseOpsTunnel.Equals(input.UseOpsTunnel))) return false;

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
                hashCode = hashCode * 59 + this.RecommendType.GetHashCode();
                if (this.RecommendCount != null) hashCode = hashCode * 59 + this.RecommendCount.GetHashCode();
                if (this.UseOpsTunnel != null) hashCode = hashCode * 59 + this.UseOpsTunnel.GetHashCode();
                return hashCode;
            }
        }
    }
}
