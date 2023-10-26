using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V2.Model
{
    /// <summary>
    /// 应用命名部分。 nameType取值cmdLine时args格式为[\&quot;start\&quot;,\&quot;end\&quot;],表示抽取命令行中start、end之间的字符。 nameType取值cmdLine时args格式为 [\&quot;aa\&quot;],表示抽取环境变量名为aa对应的环境变量值。 nameType取值str时,args格式为[\&quot;fix\&quot;],表示服务名称最后拼接固定文字fix。 nameType取值cmdLineHash时,args格式为[\&quot;0001\&quot;],value格式为[\&quot;ser\&quot;],表示当启动命令是0001时,应用名称为ser。
    /// </summary>
    public class ApplicationNameRule 
    {

        /// <summary>
        /// 取值类型。 从cmdLineHash、cmdLine、env、str里面选取。
        /// </summary>
        [JsonProperty("nameType", NullValueHandling = NullValueHandling.Ignore)]
        public string NameType { get; set; }

        /// <summary>
        /// 输入值。
        /// </summary>
        [JsonProperty("args", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Args { get; set; }

        /// <summary>
        /// 服务名(仅nameType为cmdLineHash时填写)。
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Value { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationNameRule {\n");
            sb.Append("  nameType: ").Append(NameType).Append("\n");
            sb.Append("  args: ").Append(Args).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ApplicationNameRule);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ApplicationNameRule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NameType == input.NameType ||
                    (this.NameType != null &&
                    this.NameType.Equals(input.NameType))
                ) && 
                (
                    this.Args == input.Args ||
                    this.Args != null &&
                    input.Args != null &&
                    this.Args.SequenceEqual(input.Args)
                ) && 
                (
                    this.Value == input.Value ||
                    this.Value != null &&
                    input.Value != null &&
                    this.Value.SequenceEqual(input.Value)
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
                if (this.NameType != null)
                    hashCode = hashCode * 59 + this.NameType.GetHashCode();
                if (this.Args != null)
                    hashCode = hashCode * 59 + this.Args.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }
    }
}
