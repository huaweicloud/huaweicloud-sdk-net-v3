using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class CreateSecretRequest 
    {

        /// <summary>
        /// 项目名称，缺省值默认为区域名称，例如：cn-north-1。 
        /// </summary>
        [SDKProperty("projectname", IsQuery = true)]
        [JsonProperty("projectname", NullValueHandling = NullValueHandling.Ignore)]
        public string Projectname { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSecretRequest {\n");
            sb.Append("  projectname: ").Append(Projectname).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateSecretRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateSecretRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Projectname == input.Projectname ||
                    (this.Projectname != null &&
                    this.Projectname.Equals(input.Projectname))
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
                if (this.Projectname != null)
                    hashCode = hashCode * 59 + this.Projectname.GetHashCode();
                return hashCode;
            }
        }
    }
}
