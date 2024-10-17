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
    /// Response Object
    /// </summary>
    public class CreatePromInstanceResponse : SdkResponse
    {

        /// <summary>
        /// Prometheus实例名称列表。
        /// </summary>
        [JsonProperty("prometheus", NullValueHandling = NullValueHandling.Ignore)]
        public List<PromInstanceEpsCreateModel> Prometheus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatePromInstanceResponse {\n");
            sb.Append("  prometheus: ").Append(Prometheus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreatePromInstanceResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreatePromInstanceResponse input)
        {
            if (input == null) return false;
            if (this.Prometheus != input.Prometheus || (this.Prometheus != null && input.Prometheus != null && !this.Prometheus.SequenceEqual(input.Prometheus))) return false;

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
                if (this.Prometheus != null) hashCode = hashCode * 59 + this.Prometheus.GetHashCode();
                return hashCode;
            }
        }
    }
}
