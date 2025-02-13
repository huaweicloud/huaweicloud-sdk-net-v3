using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Mpc.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AdditionalManifests 
    {

        /// <summary>
        /// 定制的索引后缀名 
        /// </summary>
        [JsonProperty("manifest_name_modifier", NullValueHandling = NullValueHandling.Ignore)]
        public string ManifestNameModifier { get; set; }

        /// <summary>
        /// 选择的流名称
        /// </summary>
        [JsonProperty("selected_outputs", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SelectedOutputs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdditionalManifests {\n");
            sb.Append("  manifestNameModifier: ").Append(ManifestNameModifier).Append("\n");
            sb.Append("  selectedOutputs: ").Append(SelectedOutputs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AdditionalManifests);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AdditionalManifests input)
        {
            if (input == null) return false;
            if (this.ManifestNameModifier != input.ManifestNameModifier || (this.ManifestNameModifier != null && !this.ManifestNameModifier.Equals(input.ManifestNameModifier))) return false;
            if (this.SelectedOutputs != input.SelectedOutputs || (this.SelectedOutputs != null && input.SelectedOutputs != null && !this.SelectedOutputs.SequenceEqual(input.SelectedOutputs))) return false;

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
                if (this.ManifestNameModifier != null) hashCode = hashCode * 59 + this.ManifestNameModifier.GetHashCode();
                if (this.SelectedOutputs != null) hashCode = hashCode * 59 + this.SelectedOutputs.GetHashCode();
                return hashCode;
            }
        }
    }
}
