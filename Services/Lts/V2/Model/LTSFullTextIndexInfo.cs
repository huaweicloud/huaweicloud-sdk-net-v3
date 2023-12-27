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
    /// 
    /// </summary>
    public class LTSFullTextIndexInfo 
    {

        /// <summary>
        /// 是否开启全文索引
        /// </summary>
        [JsonProperty("enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable { get; set; }

        /// <summary>
        /// 是否大小写敏感
        /// </summary>
        [JsonProperty("caseSensitive", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CaseSensitive { get; set; }

        /// <summary>
        /// 是否包含中文
        /// </summary>
        [JsonProperty("includeChinese", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeChinese { get; set; }

        /// <summary>
        /// 自定义分词符
        /// </summary>
        [JsonProperty("tokenizer", NullValueHandling = NullValueHandling.Ignore)]
        public string Tokenizer { get; set; }

        /// <summary>
        /// 特殊分词符
        /// </summary>
        [JsonProperty("ascii", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Ascii { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LTSFullTextIndexInfo {\n");
            sb.Append("  enable: ").Append(Enable).Append("\n");
            sb.Append("  caseSensitive: ").Append(CaseSensitive).Append("\n");
            sb.Append("  includeChinese: ").Append(IncludeChinese).Append("\n");
            sb.Append("  tokenizer: ").Append(Tokenizer).Append("\n");
            sb.Append("  ascii: ").Append(Ascii).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LTSFullTextIndexInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LTSFullTextIndexInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Enable == input.Enable ||
                    (this.Enable != null &&
                    this.Enable.Equals(input.Enable))
                ) && 
                (
                    this.CaseSensitive == input.CaseSensitive ||
                    (this.CaseSensitive != null &&
                    this.CaseSensitive.Equals(input.CaseSensitive))
                ) && 
                (
                    this.IncludeChinese == input.IncludeChinese ||
                    (this.IncludeChinese != null &&
                    this.IncludeChinese.Equals(input.IncludeChinese))
                ) && 
                (
                    this.Tokenizer == input.Tokenizer ||
                    (this.Tokenizer != null &&
                    this.Tokenizer.Equals(input.Tokenizer))
                ) && 
                (
                    this.Ascii == input.Ascii ||
                    this.Ascii != null &&
                    input.Ascii != null &&
                    this.Ascii.SequenceEqual(input.Ascii)
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
                if (this.Enable != null)
                    hashCode = hashCode * 59 + this.Enable.GetHashCode();
                if (this.CaseSensitive != null)
                    hashCode = hashCode * 59 + this.CaseSensitive.GetHashCode();
                if (this.IncludeChinese != null)
                    hashCode = hashCode * 59 + this.IncludeChinese.GetHashCode();
                if (this.Tokenizer != null)
                    hashCode = hashCode * 59 + this.Tokenizer.GetHashCode();
                if (this.Ascii != null)
                    hashCode = hashCode * 59 + this.Ascii.GetHashCode();
                return hashCode;
            }
        }
    }
}
