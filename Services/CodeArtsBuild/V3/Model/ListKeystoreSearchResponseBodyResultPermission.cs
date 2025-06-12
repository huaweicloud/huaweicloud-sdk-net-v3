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
    /// 权限
    /// </summary>
    public class ListKeystoreSearchResponseBodyResultPermission 
    {

        /// <summary>
        /// 文件ID
        /// </summary>
        [JsonProperty("keystore_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KeystoreId { get; set; }

        /// <summary>
        /// 是否有设置权限
        /// </summary>
        [JsonProperty("setting", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Setting { get; set; }

        /// <summary>
        /// 是否有删除权限
        /// </summary>
        [JsonProperty("delete", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Delete { get; set; }

        /// <summary>
        /// 是否有修改权限
        /// </summary>
        [JsonProperty("modify", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Modify { get; set; }

        /// <summary>
        /// 是否有使用权限
        /// </summary>
        [JsonProperty("usage", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Usage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListKeystoreSearchResponseBodyResultPermission {\n");
            sb.Append("  keystoreId: ").Append(KeystoreId).Append("\n");
            sb.Append("  setting: ").Append(Setting).Append("\n");
            sb.Append("  delete: ").Append(Delete).Append("\n");
            sb.Append("  modify: ").Append(Modify).Append("\n");
            sb.Append("  usage: ").Append(Usage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListKeystoreSearchResponseBodyResultPermission);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListKeystoreSearchResponseBodyResultPermission input)
        {
            if (input == null) return false;
            if (this.KeystoreId != input.KeystoreId || (this.KeystoreId != null && !this.KeystoreId.Equals(input.KeystoreId))) return false;
            if (this.Setting != input.Setting || (this.Setting != null && !this.Setting.Equals(input.Setting))) return false;
            if (this.Delete != input.Delete || (this.Delete != null && !this.Delete.Equals(input.Delete))) return false;
            if (this.Modify != input.Modify || (this.Modify != null && !this.Modify.Equals(input.Modify))) return false;
            if (this.Usage != input.Usage || (this.Usage != null && !this.Usage.Equals(input.Usage))) return false;

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
                if (this.KeystoreId != null) hashCode = hashCode * 59 + this.KeystoreId.GetHashCode();
                if (this.Setting != null) hashCode = hashCode * 59 + this.Setting.GetHashCode();
                if (this.Delete != null) hashCode = hashCode * 59 + this.Delete.GetHashCode();
                if (this.Modify != null) hashCode = hashCode * 59 + this.Modify.GetHashCode();
                if (this.Usage != null) hashCode = hashCode * 59 + this.Usage.GetHashCode();
                return hashCode;
            }
        }
    }
}
