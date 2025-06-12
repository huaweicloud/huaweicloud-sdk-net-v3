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
    /// 素材元数据。
    /// </summary>
    public class MaterialAssetMeta 
    {

        /// <summary>
        /// 可替换的素材组件列表。
        /// </summary>
        [JsonProperty("components", NullValueHandling = NullValueHandling.Ignore)]
        public List<MaterialComponentInfo> Components { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MaterialAssetMeta {\n");
            sb.Append("  components: ").Append(Components).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MaterialAssetMeta);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MaterialAssetMeta input)
        {
            if (input == null) return false;
            if (this.Components != input.Components || (this.Components != null && input.Components != null && !this.Components.SequenceEqual(input.Components))) return false;

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
                if (this.Components != null) hashCode = hashCode * 59 + this.Components.GetHashCode();
                return hashCode;
            }
        }
    }
}
