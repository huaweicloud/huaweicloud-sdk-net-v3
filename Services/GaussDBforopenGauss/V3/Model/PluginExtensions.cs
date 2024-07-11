using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PluginExtensions 
    {

        /// <summary>
        /// 拓展名称
        /// </summary>
        [JsonProperty("extension_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtensionName { get; set; }

        /// <summary>
        /// 拓展状态。on表示开启，off表示关闭。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PluginExtensions {\n");
            sb.Append("  extensionName: ").Append(ExtensionName).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PluginExtensions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PluginExtensions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExtensionName == input.ExtensionName ||
                    (this.ExtensionName != null &&
                    this.ExtensionName.Equals(input.ExtensionName))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ExtensionName != null)
                    hashCode = hashCode * 59 + this.ExtensionName.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
