using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CheckStarrocksParamsRequestBody 
    {

        /// <summary>
        /// 需要进行比较的源参数模板ID。通过ListStarrocksInstanceInfo接口获得。
        /// </summary>
        [JsonProperty("source_configuration_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceConfigurationId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckStarrocksParamsRequestBody {\n");
            sb.Append("  sourceConfigurationId: ").Append(SourceConfigurationId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckStarrocksParamsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CheckStarrocksParamsRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SourceConfigurationId == input.SourceConfigurationId ||
                    (this.SourceConfigurationId != null &&
                    this.SourceConfigurationId.Equals(input.SourceConfigurationId))
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
                if (this.SourceConfigurationId != null)
                    hashCode = hashCode * 59 + this.SourceConfigurationId.GetHashCode();
                return hashCode;
            }
        }
    }
}
