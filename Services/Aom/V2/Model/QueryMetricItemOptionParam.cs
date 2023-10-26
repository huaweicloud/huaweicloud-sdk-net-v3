using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V2.Model
{
    /// <summary>
    /// 参数项。
    /// </summary>
    public class QueryMetricItemOptionParam 
    {
        /// <summary>
        /// 指标命名空间。 取值范围 PAAS.CONTAINER：组件指标、实例指标、进程指标和容器指标的命名空间， PAAS.NODE： 主机指标、网络指标、磁盘指标和文件系统指标的命名空间， PAAS.SLA：SLA指标的命名空间， PAAS.AGGR：集群指标的命名空间， CUSTOMMETRICS：默认的自定义指标的命名空间。
        /// </summary>
        /// <value>指标命名空间。 取值范围 PAAS.CONTAINER：组件指标、实例指标、进程指标和容器指标的命名空间， PAAS.NODE： 主机指标、网络指标、磁盘指标和文件系统指标的命名空间， PAAS.SLA：SLA指标的命名空间， PAAS.AGGR：集群指标的命名空间， CUSTOMMETRICS：默认的自定义指标的命名空间。</value>
        [JsonConverter(typeof(EnumClassConverter<NamespaceEnum>))]
        public class NamespaceEnum
        {
            /// <summary>
            /// Enum PAAS_CONTAINER for value: PAAS.CONTAINER
            /// </summary>
            public static readonly NamespaceEnum PAAS_CONTAINER = new NamespaceEnum("PAAS.CONTAINER");

            /// <summary>
            /// Enum PAAS_NODE for value: PAAS.NODE
            /// </summary>
            public static readonly NamespaceEnum PAAS_NODE = new NamespaceEnum("PAAS.NODE");

            /// <summary>
            /// Enum PAAS_SLA for value: PAAS.SLA
            /// </summary>
            public static readonly NamespaceEnum PAAS_SLA = new NamespaceEnum("PAAS.SLA");

            /// <summary>
            /// Enum PAAS_AGGR for value: PAAS.AGGR
            /// </summary>
            public static readonly NamespaceEnum PAAS_AGGR = new NamespaceEnum("PAAS.AGGR");

            /// <summary>
            /// Enum CUSTOMMETRICS for value: CUSTOMMETRICS
            /// </summary>
            public static readonly NamespaceEnum CUSTOMMETRICS = new NamespaceEnum("CUSTOMMETRICS");

            private static readonly Dictionary<string, NamespaceEnum> StaticFields =
            new Dictionary<string, NamespaceEnum>()
            {
                { "PAAS.CONTAINER", PAAS_CONTAINER },
                { "PAAS.NODE", PAAS_NODE },
                { "PAAS.SLA", PAAS_SLA },
                { "PAAS.AGGR", PAAS_AGGR },
                { "CUSTOMMETRICS", CUSTOMMETRICS },
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
        /// 指标维度列表。
        /// </summary>
        [JsonProperty("dimensions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Dimension> Dimensions { get; set; }

        /// <summary>
        /// 指标名称。名称长度取值范围为1~255个字符。 取值范围：AOM提供的基础指标，cpuUsage、cpuCoreUsed等。 cpuUage：cpu使用率； cpuCoreUsed：cpu内核占用； 用户上报的自定义指标名称。
        /// </summary>
        [JsonProperty("metricName", NullValueHandling = NullValueHandling.Ignore)]
        public string MetricName { get; set; }

        /// <summary>
        /// 指标命名空间。 取值范围 PAAS.CONTAINER：组件指标、实例指标、进程指标和容器指标的命名空间， PAAS.NODE： 主机指标、网络指标、磁盘指标和文件系统指标的命名空间， PAAS.SLA：SLA指标的命名空间， PAAS.AGGR：集群指标的命名空间， CUSTOMMETRICS：默认的自定义指标的命名空间。
        /// </summary>
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public NamespaceEnum Namespace { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryMetricItemOptionParam {\n");
            sb.Append("  dimensions: ").Append(Dimensions).Append("\n");
            sb.Append("  metricName: ").Append(MetricName).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryMetricItemOptionParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryMetricItemOptionParam input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Dimensions == input.Dimensions ||
                    this.Dimensions != null &&
                    input.Dimensions != null &&
                    this.Dimensions.SequenceEqual(input.Dimensions)
                ) && 
                (
                    this.MetricName == input.MetricName ||
                    (this.MetricName != null &&
                    this.MetricName.Equals(input.MetricName))
                ) && 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
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
                if (this.Dimensions != null)
                    hashCode = hashCode * 59 + this.Dimensions.GetHashCode();
                if (this.MetricName != null)
                    hashCode = hashCode * 59 + this.MetricName.GetHashCode();
                if (this.Namespace != null)
                    hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                return hashCode;
            }
        }
    }
}
