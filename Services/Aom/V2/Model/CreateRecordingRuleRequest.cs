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
    /// Request Object
    /// </summary>
    public class CreateRecordingRuleRequest 
    {

        /// <summary>
        /// prometheus实例id。
        /// </summary>
        [SDKProperty("prometheus_instance", IsPath = true)]
        [JsonProperty("prometheus_instance", NullValueHandling = NullValueHandling.Ignore)]
        public string PrometheusInstance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public RecordingRuleRequest Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateRecordingRuleRequest {\n");
            sb.Append("  prometheusInstance: ").Append(PrometheusInstance).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateRecordingRuleRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateRecordingRuleRequest input)
        {
            if (input == null) return false;
            if (this.PrometheusInstance != input.PrometheusInstance || (this.PrometheusInstance != null && !this.PrometheusInstance.Equals(input.PrometheusInstance))) return false;
            if (this.Body != input.Body || (this.Body != null && !this.Body.Equals(input.Body))) return false;

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
                if (this.PrometheusInstance != null) hashCode = hashCode * 59 + this.PrometheusInstance.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
