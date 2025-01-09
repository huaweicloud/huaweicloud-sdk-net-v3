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
    /// 
    /// </summary>
    public class I18n 
    {

        /// <summary>
        /// 可用分区中文名称。
        /// </summary>
        [JsonProperty("zh_cn", NullValueHandling = NullValueHandling.Ignore)]
        public string ZhCn { get; set; }

        /// <summary>
        /// 可用分区英语名称。
        /// </summary>
        [JsonProperty("en_us", NullValueHandling = NullValueHandling.Ignore)]
        public string EnUs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class I18n {\n");
            sb.Append("  zhCn: ").Append(ZhCn).Append("\n");
            sb.Append("  enUs: ").Append(EnUs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as I18n);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(I18n input)
        {
            if (input == null) return false;
            if (this.ZhCn != input.ZhCn || (this.ZhCn != null && !this.ZhCn.Equals(input.ZhCn))) return false;
            if (this.EnUs != input.EnUs || (this.EnUs != null && !this.EnUs.Equals(input.EnUs))) return false;

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
                if (this.ZhCn != null) hashCode = hashCode * 59 + this.ZhCn.GetHashCode();
                if (this.EnUs != null) hashCode = hashCode * 59 + this.EnUs.GetHashCode();
                return hashCode;
            }
        }
    }
}
