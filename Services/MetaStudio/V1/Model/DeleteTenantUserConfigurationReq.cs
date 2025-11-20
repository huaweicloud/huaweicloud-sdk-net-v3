using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 删除租户个性化配置请求
    /// </summary>
    public class DeleteTenantUserConfigurationReq 
    {

        /// <summary>
        /// 我的收藏列表
        /// </summary>
        [JsonProperty("my_collections", NullValueHandling = NullValueHandling.Ignore)]
        public List<CollectionInfo> MyCollections { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteTenantUserConfigurationReq {\n");
            sb.Append("  myCollections: ").Append(MyCollections).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteTenantUserConfigurationReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteTenantUserConfigurationReq input)
        {
            if (input == null) return false;
            if (this.MyCollections != input.MyCollections || (this.MyCollections != null && input.MyCollections != null && !this.MyCollections.SequenceEqual(input.MyCollections))) return false;

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
                if (this.MyCollections != null) hashCode = hashCode * 59 + this.MyCollections.GetHashCode();
                return hashCode;
            }
        }
    }
}
