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
    /// **参数解释**：Modelarts内置操作系统。
    /// </summary>
    public class AffinityOS 
    {

        /// <summary>
        /// **参数解释**：操作系统名称。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**：操作系统镜像id, 裸金属规格该字段不为空。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("imageId", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageId { get; set; }

        /// <summary>
        /// **参数解释**：是否优选。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("preferred", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Preferred { get; set; }

        /// <summary>
        /// **参数解释**：操作系统是否即将停止服务, end of service。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("eos", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Eos { get; set; }

        /// <summary>
        /// **参数解释**：操作系统是否下线。 **取值范围**：不涉及
        /// </summary>
        [JsonProperty("offline", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Offline { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AffinityOS {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  imageId: ").Append(ImageId).Append("\n");
            sb.Append("  preferred: ").Append(Preferred).Append("\n");
            sb.Append("  eos: ").Append(Eos).Append("\n");
            sb.Append("  offline: ").Append(Offline).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AffinityOS);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AffinityOS input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ImageId != input.ImageId || (this.ImageId != null && !this.ImageId.Equals(input.ImageId))) return false;
            if (this.Preferred != input.Preferred || (this.Preferred != null && !this.Preferred.Equals(input.Preferred))) return false;
            if (this.Eos != input.Eos || (this.Eos != null && !this.Eos.Equals(input.Eos))) return false;
            if (this.Offline != input.Offline || (this.Offline != null && !this.Offline.Equals(input.Offline))) return false;

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
                if (this.ImageId != null) hashCode = hashCode * 59 + this.ImageId.GetHashCode();
                if (this.Preferred != null) hashCode = hashCode * 59 + this.Preferred.GetHashCode();
                if (this.Eos != null) hashCode = hashCode * 59 + this.Eos.GetHashCode();
                if (this.Offline != null) hashCode = hashCode * 59 + this.Offline.GetHashCode();
                return hashCode;
            }
        }
    }
}
