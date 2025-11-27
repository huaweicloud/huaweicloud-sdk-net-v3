using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// **参数解释**：规格指标信息。
    /// </summary>
    public class FlavorInfo 
    {

        /// <summary>
        /// **参数解释**：最大并发连接数。单位：个。  **取值范围**：不涉及
        /// </summary>
        [JsonProperty("connection", NullValueHandling = NullValueHandling.Ignore)]
        public int? Connection { get; set; }

        /// <summary>
        /// **参数解释**：每秒新建连接数。单位：个。  **取值范围**：不涉及
        /// </summary>
        [JsonProperty("cps", NullValueHandling = NullValueHandling.Ignore)]
        public int? Cps { get; set; }

        /// <summary>
        /// **参数解释**：tls最大并发连接数。单位：个。  **取值范围**：不涉及
        /// </summary>
        [JsonProperty("tls_connection", NullValueHandling = NullValueHandling.Ignore)]
        public int? TlsConnection { get; set; }

        /// <summary>
        /// **参数解释**：tls每秒新建连接数。单位：个。  **取值范围**：不涉及
        /// </summary>
        [JsonProperty("tls_cps", NullValueHandling = NullValueHandling.Ignore)]
        public int? TlsCps { get; set; }

        /// <summary>
        /// **参数解释**：每秒查询速率。单位：个。仅7层LB有该指标。  **取值范围**：不涉及
        /// </summary>
        [JsonProperty("qps", NullValueHandling = NullValueHandling.Ignore)]
        public int? Qps { get; set; }

        /// <summary>
        /// **参数解释**：带宽。单位：Kbit/s。  **取值范围**：不涉及
        /// </summary>
        [JsonProperty("bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// **参数解释**：当前flavor对应的lcu数量。单位：个。  **取值范围**：不涉及  &gt; LCU是用来衡量独享型ELB处理性能综合指标，LCU值越大，性能越好。
        /// </summary>
        [JsonProperty("lcu", NullValueHandling = NullValueHandling.Ignore)]
        public int? Lcu { get; set; }

        /// <summary>
        /// **参数解释**：https新建连接数，仅7层LB有该指标。单位：个。  **取值范围**：不涉及
        /// </summary>
        [JsonProperty("https_cps", NullValueHandling = NullValueHandling.Ignore)]
        public int? HttpsCps { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlavorInfo {\n");
            sb.Append("  connection: ").Append(Connection).Append("\n");
            sb.Append("  cps: ").Append(Cps).Append("\n");
            sb.Append("  tlsConnection: ").Append(TlsConnection).Append("\n");
            sb.Append("  tlsCps: ").Append(TlsCps).Append("\n");
            sb.Append("  qps: ").Append(Qps).Append("\n");
            sb.Append("  bandwidth: ").Append(Bandwidth).Append("\n");
            sb.Append("  lcu: ").Append(Lcu).Append("\n");
            sb.Append("  httpsCps: ").Append(HttpsCps).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FlavorInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FlavorInfo input)
        {
            if (input == null) return false;
            if (this.Connection != input.Connection || (this.Connection != null && !this.Connection.Equals(input.Connection))) return false;
            if (this.Cps != input.Cps || (this.Cps != null && !this.Cps.Equals(input.Cps))) return false;
            if (this.TlsConnection != input.TlsConnection || (this.TlsConnection != null && !this.TlsConnection.Equals(input.TlsConnection))) return false;
            if (this.TlsCps != input.TlsCps || (this.TlsCps != null && !this.TlsCps.Equals(input.TlsCps))) return false;
            if (this.Qps != input.Qps || (this.Qps != null && !this.Qps.Equals(input.Qps))) return false;
            if (this.Bandwidth != input.Bandwidth || (this.Bandwidth != null && !this.Bandwidth.Equals(input.Bandwidth))) return false;
            if (this.Lcu != input.Lcu || (this.Lcu != null && !this.Lcu.Equals(input.Lcu))) return false;
            if (this.HttpsCps != input.HttpsCps || (this.HttpsCps != null && !this.HttpsCps.Equals(input.HttpsCps))) return false;

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
                if (this.Connection != null) hashCode = hashCode * 59 + this.Connection.GetHashCode();
                if (this.Cps != null) hashCode = hashCode * 59 + this.Cps.GetHashCode();
                if (this.TlsConnection != null) hashCode = hashCode * 59 + this.TlsConnection.GetHashCode();
                if (this.TlsCps != null) hashCode = hashCode * 59 + this.TlsCps.GetHashCode();
                if (this.Qps != null) hashCode = hashCode * 59 + this.Qps.GetHashCode();
                if (this.Bandwidth != null) hashCode = hashCode * 59 + this.Bandwidth.GetHashCode();
                if (this.Lcu != null) hashCode = hashCode * 59 + this.Lcu.GetHashCode();
                if (this.HttpsCps != null) hashCode = hashCode * 59 + this.HttpsCps.GetHashCode();
                return hashCode;
            }
        }
    }
}
