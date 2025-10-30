using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CloudPond.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Strategy 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public OperationStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("scene", NullValueHandling = NullValueHandling.Ignore)]
        public Scene? Scene { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("effect", NullValueHandling = NullValueHandling.Ignore)]
        public Effect? Effect { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Strategy {\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  scene: ").Append(Scene).Append("\n");
            sb.Append("  effect: ").Append(Effect).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Strategy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Strategy input)
        {
            if (input == null) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Scene != input.Scene || (this.Scene != null && !this.Scene.Equals(input.Scene))) return false;
            if (this.Effect != input.Effect || (this.Effect != null && !this.Effect.Equals(input.Effect))) return false;

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
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Scene != null) hashCode = hashCode * 59 + this.Scene.GetHashCode();
                if (this.Effect != null) hashCode = hashCode * 59 + this.Effect.GetHashCode();
                return hashCode;
            }
        }
    }
}
