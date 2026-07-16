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
    /// 插件占用的资源量。
    /// </summary>
    public class PluginResources 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("involvedObject", NullValueHandling = NullValueHandling.Ignore)]
        public ObjectReference InvolvedObject { get; set; }

        /// <summary>
        /// **参数解释**： 资源对象的副本数。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("replicas", NullValueHandling = NullValueHandling.Ignore)]
        public int? Replicas { get; set; }

        /// <summary>
        /// **参数解释**： 申请的资源限制。
        /// </summary>
        [JsonProperty("limits", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Limits { get; set; }

        /// <summary>
        /// **参数解释**： 申请的资源需求。
        /// </summary>
        [JsonProperty("requests", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Requests { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PluginResources {\n");
            sb.Append("  involvedObject: ").Append(InvolvedObject).Append("\n");
            sb.Append("  replicas: ").Append(Replicas).Append("\n");
            sb.Append("  limits: ").Append(Limits).Append("\n");
            sb.Append("  requests: ").Append(Requests).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PluginResources);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PluginResources input)
        {
            if (input == null) return false;
            if (this.InvolvedObject != input.InvolvedObject || (this.InvolvedObject != null && !this.InvolvedObject.Equals(input.InvolvedObject))) return false;
            if (this.Replicas != input.Replicas || (this.Replicas != null && !this.Replicas.Equals(input.Replicas))) return false;
            if (this.Limits != input.Limits || (this.Limits != null && input.Limits != null && !this.Limits.SequenceEqual(input.Limits))) return false;
            if (this.Requests != input.Requests || (this.Requests != null && input.Requests != null && !this.Requests.SequenceEqual(input.Requests))) return false;

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
                if (this.InvolvedObject != null) hashCode = hashCode * 59 + this.InvolvedObject.GetHashCode();
                if (this.Replicas != null) hashCode = hashCode * 59 + this.Replicas.GetHashCode();
                if (this.Limits != null) hashCode = hashCode * 59 + this.Limits.GetHashCode();
                if (this.Requests != null) hashCode = hashCode * 59 + this.Requests.GetHashCode();
                return hashCode;
            }
        }
    }
}
