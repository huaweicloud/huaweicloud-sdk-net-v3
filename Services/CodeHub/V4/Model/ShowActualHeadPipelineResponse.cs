using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V4.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowActualHeadPipelineResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public PipelineDetailDto Data { get; set; }

        /// <summary>
        /// 最新的commit是否有对应的流水线
        /// </summary>
        [JsonProperty("is_valid", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsValid { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowActualHeadPipelineResponse {\n");
            sb.Append("  data: ").Append(Data).Append("\n");
            sb.Append("  isValid: ").Append(IsValid).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowActualHeadPipelineResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowActualHeadPipelineResponse input)
        {
            if (input == null) return false;
            if (this.Data != input.Data || (this.Data != null && !this.Data.Equals(input.Data))) return false;
            if (this.IsValid != input.IsValid || (this.IsValid != null && !this.IsValid.Equals(input.IsValid))) return false;

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
                if (this.Data != null) hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.IsValid != null) hashCode = hashCode * 59 + this.IsValid.GetHashCode();
                return hashCode;
            }
        }
    }
}
