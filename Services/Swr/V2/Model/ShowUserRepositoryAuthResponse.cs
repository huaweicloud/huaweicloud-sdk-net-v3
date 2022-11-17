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
    /// Response Object
    /// </summary>
    public class ShowUserRepositoryAuthResponse : SdkResponse
    {

        /// <summary>
        /// id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// 组织名称。小写字母开头，后面跟小写字母、数字、小数点、下划线或中划线（其中下划线最多允许连续两个，小数点、下划线、中划线不能直接相连），小写字母或数字结尾，1-64个字符。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("self_auth", NullValueHandling = NullValueHandling.Ignore)]
        public UserAuth SelfAuth { get; set; }

        /// <summary>
        /// 其他用户的权限
        /// </summary>
        [JsonProperty("others_auths", NullValueHandling = NullValueHandling.Ignore)]
        public List<UserAuth> OthersAuths { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowUserRepositoryAuthResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  selfAuth: ").Append(SelfAuth).Append("\n");
            sb.Append("  othersAuths: ").Append(OthersAuths).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowUserRepositoryAuthResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowUserRepositoryAuthResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.SelfAuth == input.SelfAuth ||
                    (this.SelfAuth != null &&
                    this.SelfAuth.Equals(input.SelfAuth))
                ) && 
                (
                    this.OthersAuths == input.OthersAuths ||
                    this.OthersAuths != null &&
                    input.OthersAuths != null &&
                    this.OthersAuths.SequenceEqual(input.OthersAuths)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SelfAuth != null)
                    hashCode = hashCode * 59 + this.SelfAuth.GetHashCode();
                if (this.OthersAuths != null)
                    hashCode = hashCode * 59 + this.OthersAuths.GetHashCode();
                return hashCode;
            }
        }
    }
}
