using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 产品规则信息,进程名称、产品名称、发布者的各项都需要匹配，为空或者*表示任意匹配。 例如： 发布者：* 产品名称：Huawei 进程名称：* 只要产品名称是Huawei的就可以认为是匹配的。
    /// </summary>
    public class ProductRule 
    {

        /// <summary>
        /// 识别条件。
        /// </summary>
        [JsonProperty("identify_condition", NullValueHandling = NullValueHandling.Ignore)]
        public string IdentifyCondition { get; set; }

        /// <summary>
        /// 发布者名称： 1. 名称允许可见字符或空格，不可为全空格。 2. 长度0~1024个字符。 3. 为空或者*号表示任意匹配。
        /// </summary>
        [JsonProperty("publisher", NullValueHandling = NullValueHandling.Ignore)]
        public string Publisher { get; set; }

        /// <summary>
        /// 产品名称： 1. 名称允许可见字符或空格，不可为全空格。 2. 长度0~128个字符。 3. 为空或者*号表示任意匹配。
        /// </summary>
        [JsonProperty("product_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductName { get; set; }

        /// <summary>
        /// 进程名称： 1. 名称允许可见字符或空格，不可为全空格。 2. 长度0~128个字符。 3. 为空或者*号表示任意匹配。
        /// </summary>
        [JsonProperty("process_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProcessName { get; set; }

        /// <summary>
        /// 操作系统类型，仅内置规则存在该字段。 1. 名称允许可见字符或空格，不可为全空格。 2. 长度0~128个字符。
        /// </summary>
        [JsonProperty("support_os", NullValueHandling = NullValueHandling.Ignore)]
        public string SupportOs { get; set; }

        /// <summary>
        /// 版本号： 1. 名称允许可见字符或空格，不可为全空格。 2. 长度0~128个字符。 3. 为空或者*号表示任意匹配。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 产品版本号： 1. 允许可见字符。 2. 长度0~128个字符。
        /// </summary>
        [JsonProperty("product_version", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductVersion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductRule {\n");
            sb.Append("  identifyCondition: ").Append(IdentifyCondition).Append("\n");
            sb.Append("  publisher: ").Append(Publisher).Append("\n");
            sb.Append("  productName: ").Append(ProductName).Append("\n");
            sb.Append("  processName: ").Append(ProcessName).Append("\n");
            sb.Append("  supportOs: ").Append(SupportOs).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  productVersion: ").Append(ProductVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProductRule);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProductRule input)
        {
            if (input == null) return false;
            if (this.IdentifyCondition != input.IdentifyCondition || (this.IdentifyCondition != null && !this.IdentifyCondition.Equals(input.IdentifyCondition))) return false;
            if (this.Publisher != input.Publisher || (this.Publisher != null && !this.Publisher.Equals(input.Publisher))) return false;
            if (this.ProductName != input.ProductName || (this.ProductName != null && !this.ProductName.Equals(input.ProductName))) return false;
            if (this.ProcessName != input.ProcessName || (this.ProcessName != null && !this.ProcessName.Equals(input.ProcessName))) return false;
            if (this.SupportOs != input.SupportOs || (this.SupportOs != null && !this.SupportOs.Equals(input.SupportOs))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.ProductVersion != input.ProductVersion || (this.ProductVersion != null && !this.ProductVersion.Equals(input.ProductVersion))) return false;

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
                if (this.IdentifyCondition != null) hashCode = hashCode * 59 + this.IdentifyCondition.GetHashCode();
                if (this.Publisher != null) hashCode = hashCode * 59 + this.Publisher.GetHashCode();
                if (this.ProductName != null) hashCode = hashCode * 59 + this.ProductName.GetHashCode();
                if (this.ProcessName != null) hashCode = hashCode * 59 + this.ProcessName.GetHashCode();
                if (this.SupportOs != null) hashCode = hashCode * 59 + this.SupportOs.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.ProductVersion != null) hashCode = hashCode * 59 + this.ProductVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
