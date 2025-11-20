using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aad.V2.Model
{
    /// <summary>
    /// cipher
    /// </summary>
    public class CipherInfo 
    {

        /// <summary>
        /// 套件名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 对应的加密算法
        /// </summary>
        [JsonProperty("algo", NullValueHandling = NullValueHandling.Ignore)]
        public string Algo { get; set; }

        /// <summary>
        /// 中文描述
        /// </summary>
        [JsonProperty("desc_cn", NullValueHandling = NullValueHandling.Ignore)]
        public string DescCn { get; set; }

        /// <summary>
        /// 英文描述
        /// </summary>
        [JsonProperty("desc_en", NullValueHandling = NullValueHandling.Ignore)]
        public string DescEn { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CipherInfo {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  algo: ").Append(Algo).Append("\n");
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
            return this.Equals(input as CipherInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CipherInfo input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Algo != input.Algo || (this.Algo != null && !this.Algo.Equals(input.Algo))) return false;
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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Algo != null) hashCode = hashCode * 59 + this.Algo.GetHashCode();
                if (this.DescCn != null) hashCode = hashCode * 59 + this.DescCn.GetHashCode();
                if (this.DescEn != null) hashCode = hashCode * 59 + this.DescEn.GetHashCode();
                return hashCode;
            }
        }
    }
}
