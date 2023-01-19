using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DomainNameEntity 
    {

        /// <summary>
        /// 实例历史域名。
        /// </summary>
        [JsonProperty("domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainName { get; set; }

        /// <summary>
        /// 是否只读域名 - true：是 - false：否 
        /// </summary>
        [JsonProperty("is_readonly", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsReadonly { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainNameEntity {\n");
            sb.Append("  domainName: ").Append(DomainName).Append("\n");
            sb.Append("  isReadonly: ").Append(IsReadonly).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DomainNameEntity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DomainNameEntity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DomainName == input.DomainName ||
                    (this.DomainName != null &&
                    this.DomainName.Equals(input.DomainName))
                ) && 
                (
                    this.IsReadonly == input.IsReadonly ||
                    (this.IsReadonly != null &&
                    this.IsReadonly.Equals(input.IsReadonly))
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
                if (this.DomainName != null)
                    hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.IsReadonly != null)
                    hashCode = hashCode * 59 + this.IsReadonly.GetHashCode();
                return hashCode;
            }
        }
    }
}
