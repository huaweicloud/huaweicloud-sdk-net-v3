using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class MappingRules 
    {

        /// <summary>
        /// 表示联邦用户在本系统中的用户信息。 user：联邦用户在本系统中的用户名称。group：联邦用户在本系统中所属用户组。 
        /// </summary>
        [JsonProperty("local", NullValueHandling = NullValueHandling.Ignore)]
        public List<Dictionary<string, RulesLocalAdditional>> Local { get; set; }

        /// <summary>
        /// 表示联邦用户在IdP中的用户信息。由断言属性及运算符组成的表达式，取值由断言决定。
        /// </summary>
        [JsonProperty("remote", NullValueHandling = NullValueHandling.Ignore)]
        public List<RulesRemote> Remote { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MappingRules {\n");
            sb.Append("  local: ").Append(Local).Append("\n");
            sb.Append("  remote: ").Append(Remote).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MappingRules);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MappingRules input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Local == input.Local ||
                    this.Local != null &&
                    input.Local != null &&
                    this.Local.SequenceEqual(input.Local)
                ) && 
                (
                    this.Remote == input.Remote ||
                    this.Remote != null &&
                    input.Remote != null &&
                    this.Remote.SequenceEqual(input.Remote)
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
                if (this.Local != null)
                    hashCode = hashCode * 59 + this.Local.GetHashCode();
                if (this.Remote != null)
                    hashCode = hashCode * 59 + this.Remote.GetHashCode();
                return hashCode;
            }
        }
    }
}
