using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsBuild.V3.Model
{
    /// <summary>
    /// 结果
    /// </summary>
    public class ShowKeystorePermissionResponseBodyResult 
    {

        /// <summary>
        /// 总数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// 权限结集合
        /// </summary>
        [JsonProperty("permission_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<AddKeystorePermissionResponseBody> PermissionList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowKeystorePermissionResponseBodyResult {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  permissionList: ").Append(PermissionList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowKeystorePermissionResponseBodyResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowKeystorePermissionResponseBodyResult input)
        {
            if (input == null) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.PermissionList != input.PermissionList || (this.PermissionList != null && input.PermissionList != null && !this.PermissionList.SequenceEqual(input.PermissionList))) return false;

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
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.PermissionList != null) hashCode = hashCode * 59 + this.PermissionList.GetHashCode();
                return hashCode;
            }
        }
    }
}
