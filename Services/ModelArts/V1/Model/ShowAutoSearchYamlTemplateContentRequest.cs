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
    /// Request Object
    /// </summary>
    public class ShowAutoSearchYamlTemplateContentRequest 
    {

        /// <summary>
        /// 搜索算法类型。
        /// </summary>
        [SDKProperty("algorithm_type", IsPath = true)]
        [JsonProperty("algorithm_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AlgorithmType { get; set; }

        /// <summary>
        /// 搜索算法名称。
        /// </summary>
        [SDKProperty("algorithm_name", IsPath = true)]
        [JsonProperty("algorithm_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AlgorithmName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAutoSearchYamlTemplateContentRequest {\n");
            sb.Append("  algorithmType: ").Append(AlgorithmType).Append("\n");
            sb.Append("  algorithmName: ").Append(AlgorithmName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAutoSearchYamlTemplateContentRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAutoSearchYamlTemplateContentRequest input)
        {
            if (input == null) return false;
            if (this.AlgorithmType != input.AlgorithmType || (this.AlgorithmType != null && !this.AlgorithmType.Equals(input.AlgorithmType))) return false;
            if (this.AlgorithmName != input.AlgorithmName || (this.AlgorithmName != null && !this.AlgorithmName.Equals(input.AlgorithmName))) return false;

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
                if (this.AlgorithmType != null) hashCode = hashCode * 59 + this.AlgorithmType.GetHashCode();
                if (this.AlgorithmName != null) hashCode = hashCode * 59 + this.AlgorithmName.GetHashCode();
                return hashCode;
            }
        }
    }
}
