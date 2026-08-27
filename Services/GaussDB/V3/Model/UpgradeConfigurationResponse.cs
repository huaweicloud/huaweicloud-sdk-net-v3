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
    /// Response Object
    /// </summary>
    public class UpgradeConfigurationResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：  参数模板名称。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**：  差异参数列表。
        /// </summary>
        [JsonProperty("diff_parameters", NullValueHandling = NullValueHandling.Ignore)]
        public List<GroupParameterDiffInfo> DiffParameters { get; set; }

        /// <summary>
        /// **参数解释**：  执行更新操作被跳过的参数名称列表（原值与目标值相同）。
        /// </summary>
        [JsonProperty("skipped_parameter_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SkippedParameterNames { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpgradeConfigurationResponse {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  diffParameters: ").Append(DiffParameters).Append("\n");
            sb.Append("  skippedParameterNames: ").Append(SkippedParameterNames).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpgradeConfigurationResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpgradeConfigurationResponse input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.DiffParameters != input.DiffParameters || (this.DiffParameters != null && input.DiffParameters != null && !this.DiffParameters.SequenceEqual(input.DiffParameters))) return false;
            if (this.SkippedParameterNames != input.SkippedParameterNames || (this.SkippedParameterNames != null && input.SkippedParameterNames != null && !this.SkippedParameterNames.SequenceEqual(input.SkippedParameterNames))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.DiffParameters != null) hashCode = hashCode * 59 + this.DiffParameters.GetHashCode();
                if (this.SkippedParameterNames != null) hashCode = hashCode * 59 + this.SkippedParameterNames.GetHashCode();
                return hashCode;
            }
        }
    }
}
