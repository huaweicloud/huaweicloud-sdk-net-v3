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
    /// 查询上下文日志请求体。
    /// </summary>
    public class ListLogContextRequestBody 
    {

        /// <summary>
        /// 日志单行序列号，字段值需要从日志结果中获取，纳秒级时间戳。
        /// </summary>
        [JsonProperty("line_num", NullValueHandling = NullValueHandling.Ignore)]
        public string LineNum { get; set; }

        /// <summary>
        /// 自定义时间特性时间字段，字段值需要从日志结果中获取，毫秒级时间戳。若已开启云端结构化自定义时间功能，需要使用该字段和line_num字段共同进行上下文查询。
        /// </summary>
        [JsonProperty("__time__", NullValueHandling = NullValueHandling.Ignore)]
        public string Time { get; set; }

        /// <summary>
        /// 指定起始日志往前（上文）的日志条数，取值范围 [0, 500] ，默认值100
        /// </summary>
        [JsonProperty("backwards_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? BackwardsSize { get; set; }

        /// <summary>
        /// 指定起始日志往后（下文）的日志条数，取值范围 [0, 500] ，默认值100
        /// </summary>
        [JsonProperty("forwards_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? ForwardsSize { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListLogContextRequestBody {\n");
            sb.Append("  lineNum: ").Append(LineNum).Append("\n");
            sb.Append("  time: ").Append(Time).Append("\n");
            sb.Append("  backwardsSize: ").Append(BackwardsSize).Append("\n");
            sb.Append("  forwardsSize: ").Append(ForwardsSize).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListLogContextRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListLogContextRequestBody input)
        {
            if (input == null) return false;
            if (this.LineNum != input.LineNum || (this.LineNum != null && !this.LineNum.Equals(input.LineNum))) return false;
            if (this.Time != input.Time || (this.Time != null && !this.Time.Equals(input.Time))) return false;
            if (this.BackwardsSize != input.BackwardsSize || (this.BackwardsSize != null && !this.BackwardsSize.Equals(input.BackwardsSize))) return false;
            if (this.ForwardsSize != input.ForwardsSize || (this.ForwardsSize != null && !this.ForwardsSize.Equals(input.ForwardsSize))) return false;

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
                if (this.LineNum != null) hashCode = hashCode * 59 + this.LineNum.GetHashCode();
                if (this.Time != null) hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.BackwardsSize != null) hashCode = hashCode * 59 + this.BackwardsSize.GetHashCode();
                if (this.ForwardsSize != null) hashCode = hashCode * 59 + this.ForwardsSize.GetHashCode();
                return hashCode;
            }
        }
    }
}
