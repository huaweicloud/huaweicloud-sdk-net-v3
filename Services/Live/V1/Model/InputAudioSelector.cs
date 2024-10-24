using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// 音频选择器
    /// </summary>
    public class InputAudioSelector 
    {

        /// <summary>
        /// 音频选择器的名称。仅支持大小写字母、数字、中划线和下划线。  同一个频道中每个选择器的名称需要唯一。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("selector_settings", NullValueHandling = NullValueHandling.Ignore)]
        public AudioSelectorSettings SelectorSettings { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InputAudioSelector {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  selectorSettings: ").Append(SelectorSettings).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InputAudioSelector);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InputAudioSelector input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.SelectorSettings != input.SelectorSettings || (this.SelectorSettings != null && !this.SelectorSettings.Equals(input.SelectorSettings))) return false;

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
                if (this.SelectorSettings != null) hashCode = hashCode * 59 + this.SelectorSettings.GetHashCode();
                return hashCode;
            }
        }
    }
}
