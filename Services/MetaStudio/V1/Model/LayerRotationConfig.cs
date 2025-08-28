using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 图层旋转配置。
    /// </summary>
    public class LayerRotationConfig 
    {

        /// <summary>
        /// **参数解释**： 旋转角度。 **取值范围**： 角度范围0-360度。 **默认取值**： 0度。 **约束限制**： 以素材中心点旋转。 视频素材不支持旋转
        /// </summary>
        [JsonProperty("angle", NullValueHandling = NullValueHandling.Ignore)]
        public int? Angle { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LayerRotationConfig {\n");
            sb.Append("  angle: ").Append(Angle).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LayerRotationConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LayerRotationConfig input)
        {
            if (input == null) return false;
            if (this.Angle != input.Angle || (this.Angle != null && !this.Angle.Equals(input.Angle))) return false;

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
                if (this.Angle != null) hashCode = hashCode * 59 + this.Angle.GetHashCode();
                return hashCode;
            }
        }
    }
}
