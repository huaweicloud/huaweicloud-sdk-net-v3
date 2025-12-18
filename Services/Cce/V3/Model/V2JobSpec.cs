using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class V2JobSpec 
    {

        /// <summary>
        /// **参数解释**： Job 类型 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释**： 集群ID **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("clusteruid", NullValueHandling = NullValueHandling.Ignore)]
        public string Clusteruid { get; set; }

        /// <summary>
        /// **参数解释**： 资源ID **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("resourceid", NullValueHandling = NullValueHandling.Ignore)]
        public string Resourceid { get; set; }

        /// <summary>
        /// **参数解释**： 资源名称 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("resourcename", NullValueHandling = NullValueHandling.Ignore)]
        public string Resourcename { get; set; }

        /// <summary>
        /// **参数解释**： Job的扩容参数 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("extendparam", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Extendparam { get; set; }

        /// <summary>
        /// **参数解释**： 子Job详情列表 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("subjobs", NullValueHandling = NullValueHandling.Ignore)]
        public List<V2Job> Subjobs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V2JobSpec {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  clusteruid: ").Append(Clusteruid).Append("\n");
            sb.Append("  resourceid: ").Append(Resourceid).Append("\n");
            sb.Append("  resourcename: ").Append(Resourcename).Append("\n");
            sb.Append("  extendparam: ").Append(Extendparam).Append("\n");
            sb.Append("  subjobs: ").Append(Subjobs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as V2JobSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(V2JobSpec input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Clusteruid != input.Clusteruid || (this.Clusteruid != null && !this.Clusteruid.Equals(input.Clusteruid))) return false;
            if (this.Resourceid != input.Resourceid || (this.Resourceid != null && !this.Resourceid.Equals(input.Resourceid))) return false;
            if (this.Resourcename != input.Resourcename || (this.Resourcename != null && !this.Resourcename.Equals(input.Resourcename))) return false;
            if (this.Extendparam != input.Extendparam || (this.Extendparam != null && input.Extendparam != null && !this.Extendparam.SequenceEqual(input.Extendparam))) return false;
            if (this.Subjobs != input.Subjobs || (this.Subjobs != null && input.Subjobs != null && !this.Subjobs.SequenceEqual(input.Subjobs))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Clusteruid != null) hashCode = hashCode * 59 + this.Clusteruid.GetHashCode();
                if (this.Resourceid != null) hashCode = hashCode * 59 + this.Resourceid.GetHashCode();
                if (this.Resourcename != null) hashCode = hashCode * 59 + this.Resourcename.GetHashCode();
                if (this.Extendparam != null) hashCode = hashCode * 59 + this.Extendparam.GetHashCode();
                if (this.Subjobs != null) hashCode = hashCode * 59 + this.Subjobs.GetHashCode();
                return hashCode;
            }
        }
    }
}
