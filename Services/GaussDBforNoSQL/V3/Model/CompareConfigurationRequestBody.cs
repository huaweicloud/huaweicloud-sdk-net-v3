using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CompareConfigurationRequestBody 
    {

        /// <summary>
        /// 需要进行比较的源参数模板ID。
        /// </summary>
        [JsonProperty("source_configuration_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceConfigurationId { get; set; }

        /// <summary>
        /// 需要进行比较的目标参数模板ID。
        /// </summary>
        [JsonProperty("target_configuration_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetConfigurationId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompareConfigurationRequestBody {\n");
            sb.Append("  sourceConfigurationId: ").Append(SourceConfigurationId).Append("\n");
            sb.Append("  targetConfigurationId: ").Append(TargetConfigurationId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CompareConfigurationRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CompareConfigurationRequestBody input)
        {
            if (input == null) return false;
            if (this.SourceConfigurationId != input.SourceConfigurationId || (this.SourceConfigurationId != null && !this.SourceConfigurationId.Equals(input.SourceConfigurationId))) return false;
            if (this.TargetConfigurationId != input.TargetConfigurationId || (this.TargetConfigurationId != null && !this.TargetConfigurationId.Equals(input.TargetConfigurationId))) return false;

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
                if (this.SourceConfigurationId != null) hashCode = hashCode * 59 + this.SourceConfigurationId.GetHashCode();
                if (this.TargetConfigurationId != null) hashCode = hashCode * 59 + this.TargetConfigurationId.GetHashCode();
                return hashCode;
            }
        }
    }
}
