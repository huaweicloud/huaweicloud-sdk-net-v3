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
    public class ListSampleResponse : SdkResponse
    {

        /// <summary>
        /// 时间序列对象列表。
        /// </summary>
        [JsonProperty("samples", NullValueHandling = NullValueHandling.Ignore)]
        public List<SampleDataValue> Samples { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSampleResponse {\n");
            sb.Append("  samples: ").Append(Samples).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSampleResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSampleResponse input)
        {
            if (input == null) return false;
            if (this.Samples != input.Samples || (this.Samples != null && input.Samples != null && !this.Samples.SequenceEqual(input.Samples))) return false;

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
                if (this.Samples != null) hashCode = hashCode * 59 + this.Samples.GetHashCode();
                return hashCode;
            }
        }
    }
}
