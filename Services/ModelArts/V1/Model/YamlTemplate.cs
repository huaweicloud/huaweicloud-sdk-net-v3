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
    /// 自动化搜索作业yaml模板。
    /// </summary>
    public class YamlTemplate 
    {

        /// <summary>
        /// AutoSearch算法类型，英文描述。
        /// </summary>
        [JsonProperty("algorithm_type_en", NullValueHandling = NullValueHandling.Ignore)]
        public string AlgorithmTypeEn { get; set; }

        /// <summary>
        /// AutoSearch算法类型[，中文描述](tag:hc,hk)。
        /// </summary>
        [JsonProperty("algorithm_type_zh", NullValueHandling = NullValueHandling.Ignore)]
        public string AlgorithmTypeZh { get; set; }

        /// <summary>
        /// 该算法类型下所有算法的名称。
        /// </summary>
        [JsonProperty("algorithm_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AlgorithmNames { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class YamlTemplate {\n");
            sb.Append("  algorithmTypeEn: ").Append(AlgorithmTypeEn).Append("\n");
            sb.Append("  algorithmTypeZh: ").Append(AlgorithmTypeZh).Append("\n");
            sb.Append("  algorithmNames: ").Append(AlgorithmNames).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as YamlTemplate);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(YamlTemplate input)
        {
            if (input == null) return false;
            if (this.AlgorithmTypeEn != input.AlgorithmTypeEn || (this.AlgorithmTypeEn != null && !this.AlgorithmTypeEn.Equals(input.AlgorithmTypeEn))) return false;
            if (this.AlgorithmTypeZh != input.AlgorithmTypeZh || (this.AlgorithmTypeZh != null && !this.AlgorithmTypeZh.Equals(input.AlgorithmTypeZh))) return false;
            if (this.AlgorithmNames != input.AlgorithmNames || (this.AlgorithmNames != null && input.AlgorithmNames != null && !this.AlgorithmNames.SequenceEqual(input.AlgorithmNames))) return false;

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
                if (this.AlgorithmTypeEn != null) hashCode = hashCode * 59 + this.AlgorithmTypeEn.GetHashCode();
                if (this.AlgorithmTypeZh != null) hashCode = hashCode * 59 + this.AlgorithmTypeZh.GetHashCode();
                if (this.AlgorithmNames != null) hashCode = hashCode * 59 + this.AlgorithmNames.GetHashCode();
                return hashCode;
            }
        }
    }
}
