using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kms.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListTrustedKeySpaceResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("page_info", NullValueHandling = NullValueHandling.Ignore)]
        public ListAccessPointResponseBodyPageInfo PageInfo { get; set; }

        /// <summary>
        /// **参数解释：** 密钥空间列表 **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("keyspaces", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListTrustedKeySpaceResponseBodyKeyspaces> Keyspaces { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTrustedKeySpaceResponse {\n");
            sb.Append("  pageInfo: ").Append(PageInfo).Append("\n");
            sb.Append("  keyspaces: ").Append(Keyspaces).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTrustedKeySpaceResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTrustedKeySpaceResponse input)
        {
            if (input == null) return false;
            if (this.PageInfo != input.PageInfo || (this.PageInfo != null && !this.PageInfo.Equals(input.PageInfo))) return false;
            if (this.Keyspaces != input.Keyspaces || (this.Keyspaces != null && input.Keyspaces != null && !this.Keyspaces.SequenceEqual(input.Keyspaces))) return false;

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
                if (this.PageInfo != null) hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                if (this.Keyspaces != null) hashCode = hashCode * 59 + this.Keyspaces.GetHashCode();
                return hashCode;
            }
        }
    }
}
