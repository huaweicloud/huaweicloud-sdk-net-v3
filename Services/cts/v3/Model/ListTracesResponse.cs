using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.cts.v3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListTracesResponse : SdkResponse
    {

        /// <summary>
        /// 本次查询事件列表返回事件数组。
        /// </summary>
        [JsonProperty("traces", NullValueHandling = NullValueHandling.Ignore)]
        public List<Traces> Traces { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("meta_data", NullValueHandling = NullValueHandling.Ignore)]
        public MetaData MetaData { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTracesResponse {\n");
            sb.Append("  traces: ").Append(Traces).Append("\n");
            sb.Append("  metaData: ").Append(MetaData).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTracesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTracesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Traces == input.Traces ||
                    this.Traces != null &&
                    input.Traces != null &&
                    this.Traces.SequenceEqual(input.Traces)
                ) && 
                (
                    this.MetaData == input.MetaData ||
                    (this.MetaData != null &&
                    this.MetaData.Equals(input.MetaData))
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
                if (this.Traces != null)
                    hashCode = hashCode * 59 + this.Traces.GetHashCode();
                if (this.MetaData != null)
                    hashCode = hashCode * 59 + this.MetaData.GetHashCode();
                return hashCode;
            }
        }
    }
}
