using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cpcs.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowVmMonitorRequest 
    {
        /// <summary>
        /// 所属空间，分别从不同的来源获取监控数据，有：ECS，DHSM
        /// </summary>
        /// <value>所属空间，分别从不同的来源获取监控数据，有：ECS，DHSM</value>
        [JsonConverter(typeof(EnumClassConverter<NamespaceEnum>))]
        public class NamespaceEnum
        {
            /// <summary>
            /// Enum ECS for value: ECS
            /// </summary>
            public static readonly NamespaceEnum ECS = new NamespaceEnum("ECS");

            /// <summary>
            /// Enum DHSM for value: DHSM
            /// </summary>
            public static readonly NamespaceEnum DHSM = new NamespaceEnum("DHSM");

            private static readonly Dictionary<string, NamespaceEnum> StaticFields =
            new Dictionary<string, NamespaceEnum>()
            {
                { "ECS", ECS },
                { "DHSM", DHSM },
            };

            private string _value;

            public NamespaceEnum()
            {

            }

            public NamespaceEnum(string value)
            {
                _value = value;
            }

            public static NamespaceEnum FromValue(string value)
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

                if (this.Equals(obj as NamespaceEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(NamespaceEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(NamespaceEnum a, NamespaceEnum b)
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

            public static bool operator !=(NamespaceEnum a, NamespaceEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 指标名称，有：mem_util，cpu_uttl，network_outgoing_bytes_rate_inband
        /// </summary>
        /// <value>指标名称，有：mem_util，cpu_uttl，network_outgoing_bytes_rate_inband</value>
        [JsonConverter(typeof(EnumClassConverter<MetricNameEnum>))]
        public class MetricNameEnum
        {
            /// <summary>
            /// Enum MEM_UTIL for value: mem_util
            /// </summary>
            public static readonly MetricNameEnum MEM_UTIL = new MetricNameEnum("mem_util");

            /// <summary>
            /// Enum CPU_UTTL for value: cpu_uttl
            /// </summary>
            public static readonly MetricNameEnum CPU_UTTL = new MetricNameEnum("cpu_uttl");

            /// <summary>
            /// Enum NETWORK_OUTGOING_BYTES_RATE_INBAND for value: network_outgoing_bytes_rate_inband
            /// </summary>
            public static readonly MetricNameEnum NETWORK_OUTGOING_BYTES_RATE_INBAND = new MetricNameEnum("network_outgoing_bytes_rate_inband");

            private static readonly Dictionary<string, MetricNameEnum> StaticFields =
            new Dictionary<string, MetricNameEnum>()
            {
                { "mem_util", MEM_UTIL },
                { "cpu_uttl", CPU_UTTL },
                { "network_outgoing_bytes_rate_inband", NETWORK_OUTGOING_BYTES_RATE_INBAND },
            };

            private string _value;

            public MetricNameEnum()
            {

            }

            public MetricNameEnum(string value)
            {
                _value = value;
            }

            public static MetricNameEnum FromValue(string value)
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

                if (this.Equals(obj as MetricNameEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(MetricNameEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(MetricNameEnum a, MetricNameEnum b)
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

            public static bool operator !=(MetricNameEnum a, MetricNameEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 所属空间，分别从不同的来源获取监控数据，有：ECS，DHSM
        /// </summary>
        [SDKProperty("namespace", IsQuery = true)]
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public NamespaceEnum Namespace { get; set; }
        /// <summary>
        /// 指标名称，有：mem_util，cpu_uttl，network_outgoing_bytes_rate_inband
        /// </summary>
        [SDKProperty("metric_name", IsQuery = true)]
        [JsonProperty("metric_name", NullValueHandling = NullValueHandling.Ignore)]
        public MetricNameEnum MetricName { get; set; }
        /// <summary>
        /// 实例id，默认空字符串，默认查询所有实例。
        /// </summary>
        [SDKProperty("instance_id", IsQuery = true)]
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 虚拟机id
        /// </summary>
        [SDKProperty("vsm_id", IsQuery = true)]
        [JsonProperty("vsm_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VsmId { get; set; }

        /// <summary>
        /// 查询时间范围的起始时间，毫秒时间戳，默认0，默认查询从三天前。
        /// </summary>
        [SDKProperty("from", IsQuery = true)]
        [JsonProperty("from", NullValueHandling = NullValueHandling.Ignore)]
        public long? From { get; set; }

        /// <summary>
        /// 查询时间范围的终止时间，毫秒时间戳，默认0，默认查询到当前时间。
        /// </summary>
        [SDKProperty("to", IsQuery = true)]
        [JsonProperty("to", NullValueHandling = NullValueHandling.Ignore)]
        public long? To { get; set; }

        /// <summary>
        /// 统计数据周期，默认0，默认周期为5分钟
        /// </summary>
        [SDKProperty("period", IsQuery = true)]
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public int? Period { get; set; }

        /// <summary>
        /// 统计值类型，默认min，默认查询最小值
        /// </summary>
        [SDKProperty("filter", IsQuery = true)]
        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public string Filter { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowVmMonitorRequest {\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  metricName: ").Append(MetricName).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  vsmId: ").Append(VsmId).Append("\n");
            sb.Append("  from: ").Append(From).Append("\n");
            sb.Append("  to: ").Append(To).Append("\n");
            sb.Append("  period: ").Append(Period).Append("\n");
            sb.Append("  filter: ").Append(Filter).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowVmMonitorRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowVmMonitorRequest input)
        {
            if (input == null) return false;
            if (this.Namespace != input.Namespace) return false;
            if (this.MetricName != input.MetricName) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.VsmId != input.VsmId || (this.VsmId != null && !this.VsmId.Equals(input.VsmId))) return false;
            if (this.From != input.From || (this.From != null && !this.From.Equals(input.From))) return false;
            if (this.To != input.To || (this.To != null && !this.To.Equals(input.To))) return false;
            if (this.Period != input.Period || (this.Period != null && !this.Period.Equals(input.Period))) return false;
            if (this.Filter != input.Filter || (this.Filter != null && !this.Filter.Equals(input.Filter))) return false;

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
                hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                hashCode = hashCode * 59 + this.MetricName.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.VsmId != null) hashCode = hashCode * 59 + this.VsmId.GetHashCode();
                if (this.From != null) hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.To != null) hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.Period != null) hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.Filter != null) hashCode = hashCode * 59 + this.Filter.GetHashCode();
                return hashCode;
            }
        }
    }
}
