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
    /// 数据库用户信息。
    /// </summary>
    public class GaussDBforOpenGaussUserForList 
    {

        /// <summary>
        /// 帐号名。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("attributes", NullValueHandling = NullValueHandling.Ignore)]
        public GaussDBforOpenGaussUserForListAttributes Attributes { get; set; }

        /// <summary>
        /// 用户的默认权限。
        /// </summary>
        [JsonProperty("memberof", NullValueHandling = NullValueHandling.Ignore)]
        public string Memberof { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GaussDBforOpenGaussUserForList {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  attributes: ").Append(Attributes).Append("\n");
            sb.Append("  memberof: ").Append(Memberof).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GaussDBforOpenGaussUserForList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GaussDBforOpenGaussUserForList input)
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
                    this.Attributes == input.Attributes ||
                    (this.Attributes != null &&
                    this.Attributes.Equals(input.Attributes))
                ) && 
                (
                    this.Memberof == input.Memberof ||
                    (this.Memberof != null &&
                    this.Memberof.Equals(input.Memberof))
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
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                if (this.Memberof != null)
                    hashCode = hashCode * 59 + this.Memberof.GetHashCode();
                return hashCode;
            }
        }
    }
}
