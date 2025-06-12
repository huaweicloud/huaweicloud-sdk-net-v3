using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 安抚话术意图信息。
    /// </summary>
    public class PacifyWordsIntentInfo 
    {

        /// <summary>
        /// 意图名称
        /// </summary>
        [JsonProperty("intent", NullValueHandling = NullValueHandling.Ignore)]
        public string Intent { get; set; }

        /// <summary>
        /// 意图中文描述
        /// </summary>
        [JsonProperty("desc_cn", NullValueHandling = NullValueHandling.Ignore)]
        public string DescCn { get; set; }

        /// <summary>
        /// 意图英文描述
        /// </summary>
        [JsonProperty("desc_en", NullValueHandling = NullValueHandling.Ignore)]
        public string DescEn { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PacifyWordsIntentInfo {\n");
            sb.Append("  intent: ").Append(Intent).Append("\n");
            sb.Append("  descCn: ").Append(DescCn).Append("\n");
            sb.Append("  descEn: ").Append(DescEn).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PacifyWordsIntentInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PacifyWordsIntentInfo input)
        {
            if (input == null) return false;
            if (this.Intent != input.Intent || (this.Intent != null && !this.Intent.Equals(input.Intent))) return false;
            if (this.DescCn != input.DescCn || (this.DescCn != null && !this.DescCn.Equals(input.DescCn))) return false;
            if (this.DescEn != input.DescEn || (this.DescEn != null && !this.DescEn.Equals(input.DescEn))) return false;

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
                if (this.Intent != null) hashCode = hashCode * 59 + this.Intent.GetHashCode();
                if (this.DescCn != null) hashCode = hashCode * 59 + this.DescCn.GetHashCode();
                if (this.DescEn != null) hashCode = hashCode * 59 + this.DescEn.GetHashCode();
                return hashCode;
            }
        }
    }
}
