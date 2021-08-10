using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vod.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowPreheatingAssetResponse : SdkResponse
    {

        /// <summary>
        /// 预热任务数组 
        /// </summary>
        [JsonProperty("preheating_results", NullValueHandling = NullValueHandling.Ignore)]
        public List<PreheatingResult> PreheatingResults { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowPreheatingAssetResponse {\n");
            sb.Append("  preheatingResults: ").Append(PreheatingResults).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowPreheatingAssetResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowPreheatingAssetResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PreheatingResults == input.PreheatingResults ||
                    this.PreheatingResults != null &&
                    input.PreheatingResults != null &&
                    this.PreheatingResults.SequenceEqual(input.PreheatingResults)
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
                if (this.PreheatingResults != null)
                    hashCode = hashCode * 59 + this.PreheatingResults.GetHashCode();
                return hashCode;
            }
        }
    }
}
