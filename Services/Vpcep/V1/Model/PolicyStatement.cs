using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpcep.V1.Model
{
    /// <summary>
    /// policy
    /// </summary>
    public class PolicyStatement 
    {

        /// <summary>
        /// 允许或拒绝，控制访问权限
        /// </summary>
        [JsonProperty("Effect", NullValueHandling = NullValueHandling.Ignore)]
        public string Effect { get; set; }

        /// <summary>
        /// obs访问权限
        /// </summary>
        [JsonProperty("Action", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Action { get; set; }

        /// <summary>
        /// obs对象
        /// </summary>
        [JsonProperty("Resource", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Resource { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PolicyStatement {\n");
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
            return this.Equals(input as PolicyStatement);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PolicyStatement input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Effect == input.Effect ||
                    (this.Effect != null &&
                    this.Effect.Equals(input.Effect))
                ) && 
                (
                    this.Action == input.Action ||
                    this.Action != null &&
                    input.Action != null &&
                    this.Action.SequenceEqual(input.Action)
                ) && 
                (
                    this.Resource == input.Resource ||
                    this.Resource != null &&
                    input.Resource != null &&
                    this.Resource.SequenceEqual(input.Resource)
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
                if (this.Effect != null)
                    hashCode = hashCode * 59 + this.Effect.GetHashCode();
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Resource != null)
                    hashCode = hashCode * 59 + this.Resource.GetHashCode();
                return hashCode;
            }
        }
    }
}
