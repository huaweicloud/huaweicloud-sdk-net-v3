using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsCheck.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class LogInfo 
    {

        /// <summary>
        /// 日志标题
        /// </summary>
        [JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// 日志内容
        /// </summary>
        [JsonProperty("log", NullValueHandling = NullValueHandling.Ignore)]
        public string Log { get; set; }

        /// <summary>
        /// 日志级别
        /// </summary>
        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public string Level { get; set; }

        /// <summary>
        /// 日志分析
        /// </summary>
        [JsonProperty("analysis", NullValueHandling = NullValueHandling.Ignore)]
        public string Analysis { get; set; }

        /// <summary>
        /// 常见问题解答
        /// </summary>
        [JsonProperty("faq", NullValueHandling = NullValueHandling.Ignore)]
        public string Faq { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LogInfo {\n");
            sb.Append("  displayName: ").Append(DisplayName).Append("\n");
            sb.Append("  log: ").Append(Log).Append("\n");
            sb.Append("  level: ").Append(Level).Append("\n");
            sb.Append("  analysis: ").Append(Analysis).Append("\n");
            sb.Append("  faq: ").Append(Faq).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LogInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LogInfo input)
        {
            if (input == null) return false;
            if (this.DisplayName != input.DisplayName || (this.DisplayName != null && !this.DisplayName.Equals(input.DisplayName))) return false;
            if (this.Log != input.Log || (this.Log != null && !this.Log.Equals(input.Log))) return false;
            if (this.Level != input.Level || (this.Level != null && !this.Level.Equals(input.Level))) return false;
            if (this.Analysis != input.Analysis || (this.Analysis != null && !this.Analysis.Equals(input.Analysis))) return false;
            if (this.Faq != input.Faq || (this.Faq != null && !this.Faq.Equals(input.Faq))) return false;

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
                if (this.DisplayName != null) hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Log != null) hashCode = hashCode * 59 + this.Log.GetHashCode();
                if (this.Level != null) hashCode = hashCode * 59 + this.Level.GetHashCode();
                if (this.Analysis != null) hashCode = hashCode * 59 + this.Analysis.GetHashCode();
                if (this.Faq != null) hashCode = hashCode * 59 + this.Faq.GetHashCode();
                return hashCode;
            }
        }
    }
}
