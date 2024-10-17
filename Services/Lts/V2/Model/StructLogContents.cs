using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// 参数集
    /// </summary>
    public class StructLogContents 
    {

        /// <summary>
        /// 日志原数据。
        /// </summary>
        [JsonProperty("log_content", NullValueHandling = NullValueHandling.Ignore)]
        public string LogContent { get; set; }

        /// <summary>
        /// 日志单行序列号。
        /// </summary>
        [JsonProperty("line_num", NullValueHandling = NullValueHandling.Ignore)]
        public string LineNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StructLogContents {\n");
            sb.Append("  logContent: ").Append(LogContent).Append("\n");
            sb.Append("  lineNum: ").Append(LineNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StructLogContents);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StructLogContents input)
        {
            if (input == null) return false;
            if (this.LogContent != input.LogContent || (this.LogContent != null && !this.LogContent.Equals(input.LogContent))) return false;
            if (this.LineNum != input.LineNum || (this.LineNum != null && !this.LineNum.Equals(input.LineNum))) return false;

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
                if (this.LogContent != null) hashCode = hashCode * 59 + this.LogContent.GetHashCode();
                if (this.LineNum != null) hashCode = hashCode * 59 + this.LineNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
