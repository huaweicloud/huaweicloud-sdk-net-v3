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
    /// **参数解释**：操作系统镜像信息。
    /// </summary>
    public class Os 
    {

        /// <summary>
        /// **参数解释**：操作系统名称和版本，如EulorOS 2.5。指定私有镜像时可不指定。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**：操作系统镜像id。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("imageId", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageId { get; set; }

        /// <summary>
        /// **参数解释**：操作系统镜像类型。设置私有镜像时必须指定。默认为预置镜像，无需指定该字段。 **取值范围**：可选值如下： - private：私有镜像 - \&quot;\&quot;：不指定类型即预置镜像。
        /// </summary>
        [JsonProperty("imageType", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageType { get; set; }

        /// <summary>
        /// **参数解释**：操作系统镜像自动匹配配置。当配置该参数时将会自动选择最优镜像，同时该参数会自动清空。 **取值范围**：操作系统名称和版本，如EulorOS 2.5。
        /// </summary>
        [JsonProperty("autoMatch", NullValueHandling = NullValueHandling.Ignore)]
        public string AutoMatch { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Os {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  imageId: ").Append(ImageId).Append("\n");
            sb.Append("  imageType: ").Append(ImageType).Append("\n");
            sb.Append("  autoMatch: ").Append(AutoMatch).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Os);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Os input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ImageId != input.ImageId || (this.ImageId != null && !this.ImageId.Equals(input.ImageId))) return false;
            if (this.ImageType != input.ImageType || (this.ImageType != null && !this.ImageType.Equals(input.ImageType))) return false;
            if (this.AutoMatch != input.AutoMatch || (this.AutoMatch != null && !this.AutoMatch.Equals(input.AutoMatch))) return false;

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
                if (this.ImageType != null) hashCode = hashCode * 59 + this.ImageType.GetHashCode();
                if (this.AutoMatch != null) hashCode = hashCode * 59 + this.AutoMatch.GetHashCode();
                return hashCode;
            }
        }
    }
}
