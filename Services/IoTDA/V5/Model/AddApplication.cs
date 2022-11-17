using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// 创建资源空间结构体。
    /// </summary>
    public class AddApplication 
    {

        /// <summary>
        /// **参数说明**：资源空间名称。 **取值范围**：长度不超过64，允许中文、字母、数字、下划线（_）、连接符（-）等一些特殊字符的组合。
        /// </summary>
        [JsonProperty("app_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AppName { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddApplication {\n");
            sb.Append("  appName: ").Append(AppName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddApplication);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddApplication input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AppName == input.AppName ||
                    (this.AppName != null &&
                    this.AppName.Equals(input.AppName))
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
                if (this.AppName != null)
                    hashCode = hashCode * 59 + this.AppName.GetHashCode();
                return hashCode;
            }
        }
    }
}
