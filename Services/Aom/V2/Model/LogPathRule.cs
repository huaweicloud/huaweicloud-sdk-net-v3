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
    /// 日志路径配置规则。 当cmdLineHash为固定字符串时,指定日志路径或者日志文件。否则只采集进程当前打开的以.log和.trace结尾的文件。nameType取值cmdLineHash时,args格式为[\&quot;00001\&quot;],value格式为[\&quot;/xxx/xx.log\&quot;],表示当启动命令是00001时,日志路径为/xxx/xx.log。
    /// </summary>
    public class LogPathRule 
    {

        /// <summary>
        /// 命令行。
        /// </summary>
        [JsonProperty("args", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Args { get; set; }

        /// <summary>
        /// 取值类型。 cmdLineHash
        /// </summary>
        [JsonProperty("nameType", NullValueHandling = NullValueHandling.Ignore)]
        public string NameType { get; set; }

        /// <summary>
        /// 日志路径。
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Value { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LogPathRule {\n");
            sb.Append("  args: ").Append(Args).Append("\n");
            sb.Append("  nameType: ").Append(NameType).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LogPathRule);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LogPathRule input)
        {
            if (input == null) return false;
            if (this.Args != input.Args || (this.Args != null && input.Args != null && !this.Args.SequenceEqual(input.Args))) return false;
            if (this.NameType != input.NameType || (this.NameType != null && !this.NameType.Equals(input.NameType))) return false;
            if (this.Value != input.Value || (this.Value != null && input.Value != null && !this.Value.SequenceEqual(input.Value))) return false;

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
                if (this.Args != null) hashCode = hashCode * 59 + this.Args.GetHashCode();
                if (this.NameType != null) hashCode = hashCode * 59 + this.NameType.GetHashCode();
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }
    }
}
