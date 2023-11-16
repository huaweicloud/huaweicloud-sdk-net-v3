using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aad.V1.Model
{
    /// <summary>
    /// ip绑定请求体
    /// </summary>
    public class IpBindingBody 
    {

        /// <summary>
        /// 防护包id
        /// </summary>
        [JsonProperty("package_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PackageId { get; set; }

        /// <summary>
        /// 防护ip的id列表
        /// </summary>
        [JsonProperty("id_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> IdList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IpBindingBody {\n");
            sb.Append("  packageId: ").Append(PackageId).Append("\n");
            sb.Append("  idList: ").Append(IdList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IpBindingBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IpBindingBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PackageId == input.PackageId ||
                    (this.PackageId != null &&
                    this.PackageId.Equals(input.PackageId))
                ) && 
                (
                    this.IdList == input.IdList ||
                    this.IdList != null &&
                    input.IdList != null &&
                    this.IdList.SequenceEqual(input.IdList)
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
                if (this.IdList != null)
                    hashCode = hashCode * 59 + this.IdList.GetHashCode();
                return hashCode;
            }
        }
    }
}
