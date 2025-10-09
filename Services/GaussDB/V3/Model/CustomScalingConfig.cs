using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// **参数描述**:  自定义扩容策略。  **约束限制**：  不涉及。
    /// </summary>
    public class CustomScalingConfig 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("enlarge_scene", NullValueHandling = NullValueHandling.Ignore)]
        public ScalingScene EnlargeScene { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomScalingConfig {\n");
            sb.Append("  enlargeScene: ").Append(EnlargeScene).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CustomScalingConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CustomScalingConfig input)
        {
            if (input == null) return false;
            if (this.EnlargeScene != input.EnlargeScene || (this.EnlargeScene != null && !this.EnlargeScene.Equals(input.EnlargeScene))) return false;

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
                if (this.EnlargeScene != null) hashCode = hashCode * 59 + this.EnlargeScene.GetHashCode();
                return hashCode;
            }
        }
    }
}
