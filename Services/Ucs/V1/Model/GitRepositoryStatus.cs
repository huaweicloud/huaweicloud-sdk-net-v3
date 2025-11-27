using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ucs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class GitRepositoryStatus 
    {

        /// <summary>
        /// 控制器上次处理的GitRepository版本号
        /// </summary>
        [JsonProperty("observedGeneration", NullValueHandling = NullValueHandling.Ignore)]
        public int? ObservedGeneration { get; set; }

        /// <summary>
        /// GitRepository当前的条件集合，用于表示对象的不同状态
        /// </summary>
        [JsonProperty("conditions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Object> Conditions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("artifact", NullValueHandling = NullValueHandling.Ignore)]
        public Artifact Artifact { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GitRepositoryStatus {\n");
            sb.Append("  observedGeneration: ").Append(ObservedGeneration).Append("\n");
            sb.Append("  conditions: ").Append(Conditions).Append("\n");
            sb.Append("  artifact: ").Append(Artifact).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GitRepositoryStatus);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GitRepositoryStatus input)
        {
            if (input == null) return false;
            if (this.ObservedGeneration != input.ObservedGeneration || (this.ObservedGeneration != null && !this.ObservedGeneration.Equals(input.ObservedGeneration))) return false;
            if (this.Conditions != input.Conditions || (this.Conditions != null && input.Conditions != null && !this.Conditions.SequenceEqual(input.Conditions))) return false;
            if (this.Artifact != input.Artifact || (this.Artifact != null && !this.Artifact.Equals(input.Artifact))) return false;

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
                if (this.ObservedGeneration != null) hashCode = hashCode * 59 + this.ObservedGeneration.GetHashCode();
                if (this.Conditions != null) hashCode = hashCode * 59 + this.Conditions.GetHashCode();
                if (this.Artifact != null) hashCode = hashCode * 59 + this.Artifact.GetHashCode();
                return hashCode;
            }
        }
    }
}
