using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Image.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class VideoCoverAnalysisConfigCommon 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("inference", NullValueHandling = NullValueHandling.Ignore)]
        public VideoCoverAnalysisinference Inference { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VideoCoverAnalysisConfigCommon {\n");
            sb.Append("  inference: ").Append(Inference).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VideoCoverAnalysisConfigCommon);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VideoCoverAnalysisConfigCommon input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Inference == input.Inference ||
                    (this.Inference != null &&
                    this.Inference.Equals(input.Inference))
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
                if (this.Inference != null)
                    hashCode = hashCode * 59 + this.Inference.GetHashCode();
                return hashCode;
            }
        }
    }
}
