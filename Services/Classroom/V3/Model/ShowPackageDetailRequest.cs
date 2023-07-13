using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Classroom.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowPackageDetailRequest 
    {

        /// <summary>
        /// 需查询的习题库id
        /// </summary>
        [SDKProperty("package_id", IsPath = true)]
        [JsonProperty("package_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PackageId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowPackageDetailRequest {\n");
            sb.Append("  packageId: ").Append(PackageId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowPackageDetailRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowPackageDetailRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PackageId == input.PackageId ||
                    (this.PackageId != null &&
                    this.PackageId.Equals(input.PackageId))
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
                if (this.PackageId != null)
                    hashCode = hashCode * 59 + this.PackageId.GetHashCode();
                return hashCode;
            }
        }
    }
}
