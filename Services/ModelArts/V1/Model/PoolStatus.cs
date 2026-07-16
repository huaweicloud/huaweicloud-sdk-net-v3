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
    /// 资源池状态信息。
    /// </summary>
    public class PoolStatus 
    {

        /// <summary>
        /// **参数解释**：资源池的状态。 **取值范围**：可选值如下： - Creating：资源池在创建中。 - Running：资源池在运行中。 - Abnormal：资源池异常。 - Deleting：资源池在删除中。 - Error：资源池错误。
        /// </summary>
        [JsonProperty("phase", NullValueHandling = NullValueHandling.Ignore)]
        public string Phase { get; set; }

        /// <summary>
        /// **参数解释**：资源池当前状态的提示信息。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("resources", NullValueHandling = NullValueHandling.Ignore)]
        public PoolStatusResources Resources { get; set; }

        /// <summary>
        /// **参数解释**：资源池当前支持的业务类型的状态信息。
        /// </summary>
        [JsonProperty("scope", NullValueHandling = NullValueHandling.Ignore)]
        public List<PoolStatusScope> Scope { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("driver", NullValueHandling = NullValueHandling.Ignore)]
        public PoolStatusDriver Driver { get; set; }

        /// <summary>
        /// **参数解释**：资源池所属父资源池的ID。物理池为空。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("parent", NullValueHandling = NullValueHandling.Ignore)]
        public string Parent { get; set; }

        /// <summary>
        /// **参数解释**：资源池根资源池的ID。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("root", NullValueHandling = NullValueHandling.Ignore)]
        public string Root { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("clusters", NullValueHandling = NullValueHandling.Ignore)]
        public PoolStatusClusters Clusters { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoolStatus {\n");
            sb.Append("  phase: ").Append(Phase).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("  resources: ").Append(Resources).Append("\n");
            sb.Append("  scope: ").Append(Scope).Append("\n");
            sb.Append("  driver: ").Append(Driver).Append("\n");
            sb.Append("  parent: ").Append(Parent).Append("\n");
            sb.Append("  root: ").Append(Root).Append("\n");
            sb.Append("  clusters: ").Append(Clusters).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoolStatus);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoolStatus input)
        {
            if (input == null) return false;
            if (this.Phase != input.Phase || (this.Phase != null && !this.Phase.Equals(input.Phase))) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;
            if (this.Resources != input.Resources || (this.Resources != null && !this.Resources.Equals(input.Resources))) return false;
            if (this.Scope != input.Scope || (this.Scope != null && input.Scope != null && !this.Scope.SequenceEqual(input.Scope))) return false;
            if (this.Driver != input.Driver || (this.Driver != null && !this.Driver.Equals(input.Driver))) return false;
            if (this.Parent != input.Parent || (this.Parent != null && !this.Parent.Equals(input.Parent))) return false;
            if (this.Root != input.Root || (this.Root != null && !this.Root.Equals(input.Root))) return false;
            if (this.Clusters != input.Clusters || (this.Clusters != null && !this.Clusters.Equals(input.Clusters))) return false;

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
                if (this.Phase != null) hashCode = hashCode * 59 + this.Phase.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Resources != null) hashCode = hashCode * 59 + this.Resources.GetHashCode();
                if (this.Scope != null) hashCode = hashCode * 59 + this.Scope.GetHashCode();
                if (this.Driver != null) hashCode = hashCode * 59 + this.Driver.GetHashCode();
                if (this.Parent != null) hashCode = hashCode * 59 + this.Parent.GetHashCode();
                if (this.Root != null) hashCode = hashCode * 59 + this.Root.GetHashCode();
                if (this.Clusters != null) hashCode = hashCode * 59 + this.Clusters.GetHashCode();
                return hashCode;
            }
        }
    }
}
