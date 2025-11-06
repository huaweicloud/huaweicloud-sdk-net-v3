using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsRepo.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AddDeployKeyRequestBody 
    {

        /// <summary>
        /// 部署使用的SSH密钥的来源
        /// </summary>
        [JsonProperty("application", NullValueHandling = NullValueHandling.Ignore)]
        public string Application { get; set; }

        /// <summary>
        /// 部署使用的SSH密钥是否可以推送代码
        /// </summary>
        [JsonProperty("can_push", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanPush { get; set; }

        /// <summary>
        /// 部署使用的SSH密钥
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        /// <summary>
        /// 部署使用的SSH密钥名称
        /// </summary>
        [JsonProperty("key_title", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyTitle { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddDeployKeyRequestBody {\n");
            sb.Append("  application: ").Append(Application).Append("\n");
            sb.Append("  canPush: ").Append(CanPush).Append("\n");
            sb.Append("  key: ").Append(Key).Append("\n");
            sb.Append("  keyTitle: ").Append(KeyTitle).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddDeployKeyRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddDeployKeyRequestBody input)
        {
            if (input == null) return false;
            if (this.Application != input.Application || (this.Application != null && !this.Application.Equals(input.Application))) return false;
            if (this.CanPush != input.CanPush || (this.CanPush != null && !this.CanPush.Equals(input.CanPush))) return false;
            if (this.Key != input.Key || (this.Key != null && !this.Key.Equals(input.Key))) return false;
            if (this.KeyTitle != input.KeyTitle || (this.KeyTitle != null && !this.KeyTitle.Equals(input.KeyTitle))) return false;

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
                if (this.Application != null) hashCode = hashCode * 59 + this.Application.GetHashCode();
                if (this.CanPush != null) hashCode = hashCode * 59 + this.CanPush.GetHashCode();
                if (this.Key != null) hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.KeyTitle != null) hashCode = hashCode * 59 + this.KeyTitle.GetHashCode();
                return hashCode;
            }
        }
    }
}
