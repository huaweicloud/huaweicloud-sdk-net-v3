using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateRepoTagRequestBody 
    {

        /// <summary>
        /// 源镜像版本名称
        /// </summary>
        [JsonProperty("source_tag", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceTag { get; set; }

        /// <summary>
        /// 目标镜像版本名称
        /// </summary>
        [JsonProperty("destination_tag", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationTag { get; set; }

        /// <summary>
        /// 是否覆盖
        /// </summary>
        [JsonProperty("override", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Override { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateRepoTagRequestBody {\n");
            sb.Append("  sourceTag: ").Append(SourceTag).Append("\n");
            sb.Append("  destinationTag: ").Append(DestinationTag).Append("\n");
            sb.Append("  Override: ").Append(Override).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateRepoTagRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateRepoTagRequestBody input)
        {
            if (input == null) return false;
            if (this.SourceTag != input.SourceTag || (this.SourceTag != null && !this.SourceTag.Equals(input.SourceTag))) return false;
            if (this.DestinationTag != input.DestinationTag || (this.DestinationTag != null && !this.DestinationTag.Equals(input.DestinationTag))) return false;
            if (this.Override != input.Override || (this.Override != null && !this.Override.Equals(input.Override))) return false;

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
                if (this.SourceTag != null) hashCode = hashCode * 59 + this.SourceTag.GetHashCode();
                if (this.DestinationTag != null) hashCode = hashCode * 59 + this.DestinationTag.GetHashCode();
                if (this.Override != null) hashCode = hashCode * 59 + this.Override.GetHashCode();
                return hashCode;
            }
        }
    }
}
