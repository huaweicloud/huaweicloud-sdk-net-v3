using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kms.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListSecretStageResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("stage", NullValueHandling = NullValueHandling.Ignore)]
        public Stage Stage { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSecretStageResponse {\n");
            sb.Append("  stage: ").Append(Stage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSecretStageResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSecretStageResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Stage == input.Stage ||
                    (this.Stage != null &&
                    this.Stage.Equals(input.Stage))
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
                if (this.Stage != null)
                    hashCode = hashCode * 59 + this.Stage.GetHashCode();
                return hashCode;
            }
        }
    }
}
