using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DiffConfigurationRequest 
    {

        /// <summary>
        /// 需要进行比较的参数模板ID。
        /// </summary>
        [JsonProperty("source_configuration_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceConfigurationId { get; set; }

        /// <summary>
        /// 需要进行比较的参数模板ID。
        /// </summary>
        [JsonProperty("target_configuration_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetConfigurationId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DiffConfigurationRequest {\n");
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
            return this.Equals(input as DiffConfigurationRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DiffConfigurationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SourceConfigurationId == input.SourceConfigurationId ||
                    (this.SourceConfigurationId != null &&
                    this.SourceConfigurationId.Equals(input.SourceConfigurationId))
                ) && 
                (
                    this.TargetConfigurationId == input.TargetConfigurationId ||
                    (this.TargetConfigurationId != null &&
                    this.TargetConfigurationId.Equals(input.TargetConfigurationId))
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
                if (this.TargetConfigurationId != null)
                    hashCode = hashCode * 59 + this.TargetConfigurationId.GetHashCode();
                return hashCode;
            }
        }
    }
}
