using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Mpc.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class MbTaskParameter 
    {

        /// <summary>
        /// 具体状态描述，FAILED时可用于分析问题。 
        /// </summary>
        [JsonProperty("status_description", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusDescription { get; set; }

        /// <summary>
        /// 输出文件名称。 
        /// </summary>
        [JsonProperty("output_filename", NullValueHandling = NullValueHandling.Ignore)]
        public string OutputFilename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public MetaData Metadata { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MbTaskParameter {\n");
            sb.Append("  statusDescription: ").Append(StatusDescription).Append("\n");
            sb.Append("  outputFilename: ").Append(OutputFilename).Append("\n");
            sb.Append("  metadata: ").Append(Metadata).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MbTaskParameter);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MbTaskParameter input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StatusDescription == input.StatusDescription ||
                    (this.StatusDescription != null &&
                    this.StatusDescription.Equals(input.StatusDescription))
                ) && 
                (
                    this.OutputFilename == input.OutputFilename ||
                    (this.OutputFilename != null &&
                    this.OutputFilename.Equals(input.OutputFilename))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
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
                if (this.StatusDescription != null)
                    hashCode = hashCode * 59 + this.StatusDescription.GetHashCode();
                if (this.OutputFilename != null)
                    hashCode = hashCode * 59 + this.OutputFilename.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                return hashCode;
            }
        }
    }
}
