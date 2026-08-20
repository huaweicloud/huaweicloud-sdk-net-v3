using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsPipeline.V2.Model
{
    /// <summary>
    /// UI控件配置
    /// </summary>
    public class ExtensionParameterDisplaySettings 
    {

        /// <summary>
        /// 控件类型，如 Select/CodeText/Radio/SingleLineText/Hidden
        /// </summary>
        [JsonProperty("DevCloud.ControlType", NullValueHandling = NullValueHandling.Ignore)]
        public string DevCloudControlType { get; set; }

        /// <summary>
        /// 默认选中值。可能为字符串，也可能为对象(如 {displayName, value})。
        /// </summary>
        [JsonProperty("DevCloud.ControlType.Default", NullValueHandling = NullValueHandling.Ignore)]
        public string DevCloudControlTypeDefault { get; set; }

        /// <summary>
        /// 下拉选项(Select类型)。
        /// </summary>
        [JsonProperty("DevCloud.ControlType.Select", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DevCloudControlTypeSelect { get; set; }

        /// <summary>
        /// 单选选项(Radio类型)。
        /// </summary>
        [JsonProperty("DevCloud.ControlType.Radio", NullValueHandling = NullValueHandling.Ignore)]
        public List<ExtensionRadioOption> DevCloudControlTypeRadio { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtensionParameterDisplaySettings {\n");
            sb.Append("  devCloudControlType: ").Append(DevCloudControlType).Append("\n");
            sb.Append("  devCloudControlTypeDefault: ").Append(DevCloudControlTypeDefault).Append("\n");
            sb.Append("  devCloudControlTypeSelect: ").Append(DevCloudControlTypeSelect).Append("\n");
            sb.Append("  devCloudControlTypeRadio: ").Append(DevCloudControlTypeRadio).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExtensionParameterDisplaySettings);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExtensionParameterDisplaySettings input)
        {
            if (input == null) return false;
            if (this.DevCloudControlType != input.DevCloudControlType || (this.DevCloudControlType != null && !this.DevCloudControlType.Equals(input.DevCloudControlType))) return false;
            if (this.DevCloudControlTypeDefault != input.DevCloudControlTypeDefault || (this.DevCloudControlTypeDefault != null && !this.DevCloudControlTypeDefault.Equals(input.DevCloudControlTypeDefault))) return false;
            if (this.DevCloudControlTypeSelect != input.DevCloudControlTypeSelect || (this.DevCloudControlTypeSelect != null && input.DevCloudControlTypeSelect != null && !this.DevCloudControlTypeSelect.SequenceEqual(input.DevCloudControlTypeSelect))) return false;
            if (this.DevCloudControlTypeRadio != input.DevCloudControlTypeRadio || (this.DevCloudControlTypeRadio != null && input.DevCloudControlTypeRadio != null && !this.DevCloudControlTypeRadio.SequenceEqual(input.DevCloudControlTypeRadio))) return false;

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
                if (this.DevCloudControlType != null) hashCode = hashCode * 59 + this.DevCloudControlType.GetHashCode();
                if (this.DevCloudControlTypeDefault != null) hashCode = hashCode * 59 + this.DevCloudControlTypeDefault.GetHashCode();
                if (this.DevCloudControlTypeSelect != null) hashCode = hashCode * 59 + this.DevCloudControlTypeSelect.GetHashCode();
                if (this.DevCloudControlTypeRadio != null) hashCode = hashCode * 59 + this.DevCloudControlTypeRadio.GetHashCode();
                return hashCode;
            }
        }
    }
}
