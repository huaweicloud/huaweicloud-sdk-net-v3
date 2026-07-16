using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 资源池描述信息更新参数。
    /// </summary>
    public class PoolSpecUpdate 
    {

        /// <summary>
        /// **参数解释**：更新启用的作业类型。 **约束限制**：不涉及。 **取值范围**：可选值如下： - Train：训练作业 - Infer：推理作业 - Notebook：Notebook作业 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("scope", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Scope { get; set; }

        /// <summary>
        /// **参数解释**：更新的资源规格列表。
        /// </summary>
        [JsonProperty("resources", NullValueHandling = NullValueHandling.Ignore)]
        public List<PoolSpecUpdateResources> Resources { get; set; }

        /// <summary>
        /// **参数解释**：资源池支持的作业规格信息列表。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("jobFlavors", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> JobFlavors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("driver", NullValueHandling = NullValueHandling.Ignore)]
        public PoolDriver Driver { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoolSpecUpdate {\n");
            sb.Append("  scope: ").Append(Scope).Append("\n");
            sb.Append("  resources: ").Append(Resources).Append("\n");
            sb.Append("  jobFlavors: ").Append(JobFlavors).Append("\n");
            sb.Append("  driver: ").Append(Driver).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoolSpecUpdate);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoolSpecUpdate input)
        {
            if (input == null) return false;
            if (this.Scope != input.Scope || (this.Scope != null && input.Scope != null && !this.Scope.SequenceEqual(input.Scope))) return false;
            if (this.Resources != input.Resources || (this.Resources != null && input.Resources != null && !this.Resources.SequenceEqual(input.Resources))) return false;
            if (this.JobFlavors != input.JobFlavors || (this.JobFlavors != null && input.JobFlavors != null && !this.JobFlavors.SequenceEqual(input.JobFlavors))) return false;
            if (this.Driver != input.Driver || (this.Driver != null && !this.Driver.Equals(input.Driver))) return false;

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
                if (this.Scope != null) hashCode = hashCode * 59 + this.Scope.GetHashCode();
                if (this.Resources != null) hashCode = hashCode * 59 + this.Resources.GetHashCode();
                if (this.JobFlavors != null) hashCode = hashCode * 59 + this.JobFlavors.GetHashCode();
                if (this.Driver != null) hashCode = hashCode * 59 + this.Driver.GetHashCode();
                return hashCode;
            }
        }
    }
}
