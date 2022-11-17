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
    /// 更新函数调用链请求体
    /// </summary>
    public class UpdateTracingRequestBody 
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
            sb.Append("class UpdateTracingRequestBody {\n");
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
            return this.Equals(input as UpdateTracingRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateTracingRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TracingAk == input.TracingAk ||
                    (this.TracingAk != null &&
                    this.TracingAk.Equals(input.TracingAk))
                ) && 
                (
                    this.TracingSk == input.TracingSk ||
                    (this.TracingSk != null &&
                    this.TracingSk.Equals(input.TracingSk))
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
                if (this.TracingAk != null)
                    hashCode = hashCode * 59 + this.TracingAk.GetHashCode();
                if (this.TracingSk != null)
                    hashCode = hashCode * 59 + this.TracingSk.GetHashCode();
                return hashCode;
            }
        }
    }
}
