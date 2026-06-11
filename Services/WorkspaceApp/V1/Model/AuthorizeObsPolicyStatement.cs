using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// OBS桶存放的策略内容。
    /// </summary>
    public class AuthorizeObsPolicyStatement 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("effect", NullValueHandling = NullValueHandling.Ignore)]
        public PolicyEffectEnum? Effect { get; set; }

        /// <summary>
        /// 可以进行操作的权限合集。
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Action { get; set; }

        /// <summary>
        /// 允许访问的资源。
        /// </summary>
        [JsonProperty("resource", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Resource { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthorizeObsPolicyStatement {\n");
            sb.Append("  effect: ").Append(Effect).Append("\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  resource: ").Append(Resource).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AuthorizeObsPolicyStatement);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AuthorizeObsPolicyStatement input)
        {
            if (input == null) return false;
            if (this.Effect != input.Effect || (this.Effect != null && !this.Effect.Equals(input.Effect))) return false;
            if (this.Action != input.Action || (this.Action != null && input.Action != null && !this.Action.SequenceEqual(input.Action))) return false;
            if (this.Resource != input.Resource || (this.Resource != null && input.Resource != null && !this.Resource.SequenceEqual(input.Resource))) return false;

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
                if (this.Effect != null) hashCode = hashCode * 59 + this.Effect.GetHashCode();
                if (this.Action != null) hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Resource != null) hashCode = hashCode * 59 + this.Resource.GetHashCode();
                return hashCode;
            }
        }
    }
}
