using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.FunctionGraph.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowTracingResponse : SdkResponse
    {

        /// <summary>
        /// apm的ak
        /// </summary>
        [JsonProperty("tracing_ak", NullValueHandling = NullValueHandling.Ignore)]
        public string TracingAk { get; set; }

        /// <summary>
        /// apm的sk
        /// </summary>
        [JsonProperty("tracing_sk", NullValueHandling = NullValueHandling.Ignore)]
        public string TracingSk { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowTracingResponse {\n");
            sb.Append("  tracingAk: ").Append(TracingAk).Append("\n");
            sb.Append("  tracingSk: ").Append(TracingSk).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowTracingResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowTracingResponse input)
        {
            if (input == null) return false;
            if (this.TracingAk != input.TracingAk || (this.TracingAk != null && !this.TracingAk.Equals(input.TracingAk))) return false;
            if (this.TracingSk != input.TracingSk || (this.TracingSk != null && !this.TracingSk.Equals(input.TracingSk))) return false;

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
                if (this.TracingAk != null) hashCode = hashCode * 59 + this.TracingAk.GetHashCode();
                if (this.TracingSk != null) hashCode = hashCode * 59 + this.TracingSk.GetHashCode();
                return hashCode;
            }
        }
    }
}
