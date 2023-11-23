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
    public class ListPromInstanceResponse : SdkResponse
    {

        /// <summary>
        /// 普罗实例列表名称
        /// </summary>
        [JsonProperty("prometheus", NullValueHandling = NullValueHandling.Ignore)]
        public List<PromInstanceEpsModel> Prometheus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPromInstanceResponse {\n");
            sb.Append("  prometheus: ").Append(Prometheus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListPromInstanceResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPromInstanceResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Prometheus == input.Prometheus ||
                    this.Prometheus != null &&
                    input.Prometheus != null &&
                    this.Prometheus.SequenceEqual(input.Prometheus)
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
                if (this.Prometheus != null)
                    hashCode = hashCode * 59 + this.Prometheus.GetHashCode();
                return hashCode;
            }
        }
    }
}
