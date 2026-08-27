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
    /// 算力卡信息，包含类型、卡数、单卡显存等
    /// </summary>
    public class ResourceFlavorXpu 
    {

        /// <summary>
        /// **参数解释**：卡类型。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释**：芯片数量。reseverd for backwards compatibility **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public string Size { get; set; }

        /// <summary>
        /// **参数解释**：单卡显存大小。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("memory", NullValueHandling = NullValueHandling.Ignore)]
        public string Memory { get; set; }

        /// <summary>
        /// **参数解释**：卡数量。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("card", NullValueHandling = NullValueHandling.Ignore)]
        public string Card { get; set; }

        /// <summary>
        /// **参数解释**：芯片数量。值同size字段一致。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("chip", NullValueHandling = NullValueHandling.Ignore)]
        public string Chip { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceFlavorXpu {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  memory: ").Append(Memory).Append("\n");
            sb.Append("  card: ").Append(Card).Append("\n");
            sb.Append("  chip: ").Append(Chip).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResourceFlavorXpu);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResourceFlavorXpu input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Size != input.Size || (this.Size != null && !this.Size.Equals(input.Size))) return false;
            if (this.Memory != input.Memory || (this.Memory != null && !this.Memory.Equals(input.Memory))) return false;
            if (this.Card != input.Card || (this.Card != null && !this.Card.Equals(input.Card))) return false;
            if (this.Chip != input.Chip || (this.Chip != null && !this.Chip.Equals(input.Chip))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Size != null) hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Memory != null) hashCode = hashCode * 59 + this.Memory.GetHashCode();
                if (this.Card != null) hashCode = hashCode * 59 + this.Card.GetHashCode();
                if (this.Chip != null) hashCode = hashCode * 59 + this.Chip.GetHashCode();
                return hashCode;
            }
        }
    }
}
