using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsPipeline.V2.Model
{
    /// <summary>
    /// CodeCheck任务语言参数
    /// </summary>
    public class ParamTypeLimits 
    {

        /// <summary>
        /// 是否废弃
        /// </summary>
        [JsonProperty("disable", NullValueHandling = NullValueHandling.Ignore)]
        public string Disable { get; set; }

        /// <summary>
        /// 语言名字
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 语言展示名字
        /// </summary>
        [JsonProperty("displayname", NullValueHandling = NullValueHandling.Ignore)]
        public string Displayname { get; set; }

        /// <summary>
        /// 策略ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 扫描语言
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParamTypeLimits {\n");
            sb.Append("  disable: ").Append(Disable).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  displayname: ").Append(Displayname).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ParamTypeLimits);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ParamTypeLimits input)
        {
            if (input == null) return false;
            if (this.Disable != input.Disable || (this.Disable != null && !this.Disable.Equals(input.Disable))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Displayname != input.Displayname || (this.Displayname != null && !this.Displayname.Equals(input.Displayname))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Language != input.Language || (this.Language != null && !this.Language.Equals(input.Language))) return false;

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
                if (this.Disable != null) hashCode = hashCode * 59 + this.Disable.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Displayname != null) hashCode = hashCode * 59 + this.Displayname.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Language != null) hashCode = hashCode * 59 + this.Language.GetHashCode();
                return hashCode;
            }
        }
    }
}
