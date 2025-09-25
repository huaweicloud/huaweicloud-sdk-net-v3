using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RepoListHook 
    {

        /// <summary>
        /// hook列表
        /// </summary>
        [JsonProperty("hooks", NullValueHandling = NullValueHandling.Ignore)]
        public List<RepoHook> Hooks { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RepoListHook {\n");
            sb.Append("  hooks: ").Append(Hooks).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RepoListHook);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RepoListHook input)
        {
            if (input == null) return false;
            if (this.Hooks != input.Hooks || (this.Hooks != null && input.Hooks != null && !this.Hooks.SequenceEqual(input.Hooks))) return false;

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
                if (this.Hooks != null) hashCode = hashCode * 59 + this.Hooks.GetHashCode();
                return hashCode;
            }
        }
    }
}
