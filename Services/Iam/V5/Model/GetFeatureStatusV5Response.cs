using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class GetFeatureStatusV5Response : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("feature_status", NullValueHandling = NullValueHandling.Ignore)]
        public FeatureStatus? FeatureStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetFeatureStatusV5Response {\n");
            sb.Append("  featureStatus: ").Append(FeatureStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetFeatureStatusV5Response);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GetFeatureStatusV5Response input)
        {
            if (input == null) return false;
            if (this.FeatureStatus != input.FeatureStatus || (this.FeatureStatus != null && !this.FeatureStatus.Equals(input.FeatureStatus))) return false;

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
                if (this.FeatureStatus != null) hashCode = hashCode * 59 + this.FeatureStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
