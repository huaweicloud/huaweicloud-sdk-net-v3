using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 数据库信息。
    /// </summary>
    public class GaussDBforOpenGaussListDatabase 
    {

        /// <summary>
        /// 数据库名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 数据库所属用户。
        /// </summary>
        [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
        public string Owner { get; set; }

        /// <summary>
        /// 数据库使用的字符集，例如UTF8。
        /// </summary>
        [JsonProperty("character_set", NullValueHandling = NullValueHandling.Ignore)]
        public string CharacterSet { get; set; }

        /// <summary>
        /// 数据库排序集，例如en_US.UTF-8等。
        /// </summary>
        [JsonProperty("collate_set", NullValueHandling = NullValueHandling.Ignore)]
        public string CollateSet { get; set; }

        /// <summary>
        /// 数据库大小（单位：MB）。
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public string Size { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GaussDBforOpenGaussListDatabase {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  owner: ").Append(Owner).Append("\n");
            sb.Append("  characterSet: ").Append(CharacterSet).Append("\n");
            sb.Append("  collateSet: ").Append(CollateSet).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GaussDBforOpenGaussListDatabase);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GaussDBforOpenGaussListDatabase input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && 
                (
                    this.CharacterSet == input.CharacterSet ||
                    (this.CharacterSet != null &&
                    this.CharacterSet.Equals(input.CharacterSet))
                ) && 
                (
                    this.CollateSet == input.CollateSet ||
                    (this.CollateSet != null &&
                    this.CollateSet.Equals(input.CollateSet))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.CharacterSet != null)
                    hashCode = hashCode * 59 + this.CharacterSet.GetHashCode();
                if (this.CollateSet != null)
                    hashCode = hashCode * 59 + this.CollateSet.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                return hashCode;
            }
        }
    }
}
