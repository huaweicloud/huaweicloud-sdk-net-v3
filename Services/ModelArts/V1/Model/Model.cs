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
    /// 模型信息
    /// </summary>
    public class Model 
    {

        /// <summary>
        /// **参数解释**：模型名称。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**：模型OBS路径。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// **参数解释**：量化数据类型。 **取值范围**：- w8A8 - fp16
        /// </summary>
        [JsonProperty("quant_type", NullValueHandling = NullValueHandling.Ignore)]
        public string QuantType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Model {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  quantType: ").Append(QuantType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Model);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Model input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Url != input.Url || (this.Url != null && !this.Url.Equals(input.Url))) return false;
            if (this.QuantType != input.QuantType || (this.QuantType != null && !this.QuantType.Equals(input.QuantType))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Url != null) hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.QuantType != null) hashCode = hashCode * 59 + this.QuantType.GetHashCode();
                return hashCode;
            }
        }
    }
}
