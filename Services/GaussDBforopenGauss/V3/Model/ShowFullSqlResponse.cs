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
    /// Response Object
    /// </summary>
    public class ShowFullSqlResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**: 链路详情。
        /// </summary>
        [JsonProperty("trace_statistics", NullValueHandling = NullValueHandling.Ignore)]
        public Object TraceStatistics { get; set; }

        /// <summary>
        /// **参数解释**: 组件上SQL执行记录列表。
        /// </summary>
        [JsonProperty("components", NullValueHandling = NullValueHandling.Ignore)]
        public List<FullSqlComponetResult> Components { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowFullSqlResponse {\n");
            sb.Append("  traceStatistics: ").Append(TraceStatistics).Append("\n");
            sb.Append("  components: ").Append(Components).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowFullSqlResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowFullSqlResponse input)
        {
            if (input == null) return false;
            if (this.TraceStatistics != input.TraceStatistics || (this.TraceStatistics != null && !this.TraceStatistics.Equals(input.TraceStatistics))) return false;
            if (this.Components != input.Components || (this.Components != null && input.Components != null && !this.Components.SequenceEqual(input.Components))) return false;

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
                if (this.TraceStatistics != null) hashCode = hashCode * 59 + this.TraceStatistics.GetHashCode();
                if (this.Components != null) hashCode = hashCode * 59 + this.Components.GetHashCode();
                return hashCode;
            }
        }
    }
}
