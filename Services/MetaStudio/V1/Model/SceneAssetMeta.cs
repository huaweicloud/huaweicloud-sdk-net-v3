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
    /// 场景元数据。
    /// </summary>
    public class SceneAssetMeta 
    {

        /// <summary>
        /// 可操作组件列表（如屏幕，灯光，摄像机）。
        /// </summary>
        [JsonProperty("components", NullValueHandling = NullValueHandling.Ignore)]
        public List<SceneComponentInfo> Components { get; set; }

        /// <summary>
        /// 默认场景设置（机位，初始人位置）。
        /// </summary>
        [JsonProperty("default_configs", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, SceneComponentInfo> DefaultConfigs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SceneAssetMeta {\n");
            sb.Append("  components: ").Append(Components).Append("\n");
            sb.Append("  defaultConfigs: ").Append(DefaultConfigs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SceneAssetMeta);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SceneAssetMeta input)
        {
            if (input == null) return false;
            if (this.Components != input.Components || (this.Components != null && input.Components != null && !this.Components.SequenceEqual(input.Components))) return false;
            if (this.DefaultConfigs != input.DefaultConfigs || (this.DefaultConfigs != null && input.DefaultConfigs != null && !this.DefaultConfigs.SequenceEqual(input.DefaultConfigs))) return false;

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
                if (this.DefaultConfigs != null) hashCode = hashCode * 59 + this.DefaultConfigs.GetHashCode();
                return hashCode;
            }
        }
    }
}
