using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 指标采集配置。
    /// </summary>
    public class Metrics 
    {

        /// <summary>
        /// **参数解释：** 指标采集地址，支持IP地址、域名或localhost。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("endpoint", NullValueHandling = NullValueHandling.Ignore)]
        public string Endpoint { get; set; }

        /// <summary>
        /// **参数解释：** 指标采集路径。 **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }

        /// <summary>
        /// **参数解释：** 指标采集端口。 **取值范围：** 1~65535。
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public string Port { get; set; }

        /// <summary>
        /// **参数解释：** 指标采集协议。 **取值范围：** - HTTP。 - HTTPS。
        /// </summary>
        [JsonProperty("scheme", NullValueHandling = NullValueHandling.Ignore)]
        public string Scheme { get; set; }

        /// <summary>
        /// **参数解释：** 指标来源类型。 **取值范围：** - CONTAINER表示容器内。 - OTHERS表示外部其他地址。 **约束限制：** 不涉及。 **默认取值：** CONTAINER。
        /// </summary>
        [JsonProperty("metrics_source", NullValueHandling = NullValueHandling.Ignore)]
        public string MetricsSource { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Metrics {\n");
            sb.Append("  endpoint: ").Append(Endpoint).Append("\n");
            sb.Append("  path: ").Append(Path).Append("\n");
            sb.Append("  port: ").Append(Port).Append("\n");
            sb.Append("  scheme: ").Append(Scheme).Append("\n");
            sb.Append("  metricsSource: ").Append(MetricsSource).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Metrics);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Metrics input)
        {
            if (input == null) return false;
            if (this.Endpoint != input.Endpoint || (this.Endpoint != null && !this.Endpoint.Equals(input.Endpoint))) return false;
            if (this.Path != input.Path || (this.Path != null && !this.Path.Equals(input.Path))) return false;
            if (this.Port != input.Port || (this.Port != null && !this.Port.Equals(input.Port))) return false;
            if (this.Scheme != input.Scheme || (this.Scheme != null && !this.Scheme.Equals(input.Scheme))) return false;
            if (this.MetricsSource != input.MetricsSource || (this.MetricsSource != null && !this.MetricsSource.Equals(input.MetricsSource))) return false;

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
                if (this.Endpoint != null) hashCode = hashCode * 59 + this.Endpoint.GetHashCode();
                if (this.Path != null) hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.Port != null) hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.Scheme != null) hashCode = hashCode * 59 + this.Scheme.GetHashCode();
                if (this.MetricsSource != null) hashCode = hashCode * 59 + this.MetricsSource.GetHashCode();
                return hashCode;
            }
        }
    }
}
