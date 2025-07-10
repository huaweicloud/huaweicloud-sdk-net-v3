using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rgc.V1.Model
{
    /// <summary>
    /// 更新账号的基本信息。
    /// </summary>
    public class UpdateManagedAccountRequestBody 
    {

        /// <summary>
        /// 父注册OU ID。
        /// </summary>
        [JsonProperty("parent_organizational_unit_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentOrganizationalUnitId { get; set; }

        /// <summary>
        /// 父注册OU名称。
        /// </summary>
        [JsonProperty("parent_organizational_unit_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentOrganizationalUnitName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("blueprint", NullValueHandling = NullValueHandling.Ignore)]
        public Blueprint Blueprint { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateManagedAccountRequestBody {\n");
            sb.Append("  parentOrganizationalUnitId: ").Append(ParentOrganizationalUnitId).Append("\n");
            sb.Append("  parentOrganizationalUnitName: ").Append(ParentOrganizationalUnitName).Append("\n");
            sb.Append("  blueprint: ").Append(Blueprint).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateManagedAccountRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateManagedAccountRequestBody input)
        {
            if (input == null) return false;
            if (this.ParentOrganizationalUnitId != input.ParentOrganizationalUnitId || (this.ParentOrganizationalUnitId != null && !this.ParentOrganizationalUnitId.Equals(input.ParentOrganizationalUnitId))) return false;
            if (this.ParentOrganizationalUnitName != input.ParentOrganizationalUnitName || (this.ParentOrganizationalUnitName != null && !this.ParentOrganizationalUnitName.Equals(input.ParentOrganizationalUnitName))) return false;
            if (this.Blueprint != input.Blueprint || (this.Blueprint != null && !this.Blueprint.Equals(input.Blueprint))) return false;

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
                if (this.ParentOrganizationalUnitId != null) hashCode = hashCode * 59 + this.ParentOrganizationalUnitId.GetHashCode();
                if (this.ParentOrganizationalUnitName != null) hashCode = hashCode * 59 + this.ParentOrganizationalUnitName.GetHashCode();
                if (this.Blueprint != null) hashCode = hashCode * 59 + this.Blueprint.GetHashCode();
                return hashCode;
            }
        }
    }
}
