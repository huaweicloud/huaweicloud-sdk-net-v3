using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// 用户自己修改个人信息。
    /// </summary>
    public class ModMemberDTO 
    {

        /// <summary>
        /// 名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 英文名称。
        /// </summary>
        [JsonProperty("englishName", NullValueHandling = NullValueHandling.Ignore)]
        public string EnglishName { get; set; }

        /// <summary>
        /// 签名。
        /// </summary>
        [JsonProperty("signature", NullValueHandling = NullValueHandling.Ignore)]
        public string Signature { get; set; }

        /// <summary>
        /// 职位。
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// 备注。
        /// </summary>
        [JsonProperty("desc", NullValueHandling = NullValueHandling.Ignore)]
        public string Desc { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModMemberDTO {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  englishName: ").Append(EnglishName).Append("\n");
            sb.Append("  signature: ").Append(Signature).Append("\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  desc: ").Append(Desc).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModMemberDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModMemberDTO input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.EnglishName != input.EnglishName || (this.EnglishName != null && !this.EnglishName.Equals(input.EnglishName))) return false;
            if (this.Signature != input.Signature || (this.Signature != null && !this.Signature.Equals(input.Signature))) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;
            if (this.Desc != input.Desc || (this.Desc != null && !this.Desc.Equals(input.Desc))) return false;

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
                if (this.EnglishName != null) hashCode = hashCode * 59 + this.EnglishName.GetHashCode();
                if (this.Signature != null) hashCode = hashCode * 59 + this.Signature.GetHashCode();
                if (this.Title != null) hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Desc != null) hashCode = hashCode * 59 + this.Desc.GetHashCode();
                return hashCode;
            }
        }
    }
}
