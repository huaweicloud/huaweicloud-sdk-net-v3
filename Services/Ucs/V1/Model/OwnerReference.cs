using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ucs.V1.Model
{
    /// <summary>
    /// 用于在Kubernetes中标识一个拥有者对象，它提供了足够的信息来识别和关联资源之间的所有权关系
    /// </summary>
    public class OwnerReference 
    {

        /// <summary>
        /// 标识引用对象的API版本
        /// </summary>
        [JsonProperty("apiVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// 引用对象的类型
        /// </summary>
        [JsonProperty("kind", NullValueHandling = NullValueHandling.Ignore)]
        public string Kind { get; set; }

        /// <summary>
        /// 引用对象的名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 引用对象的uid
        /// </summary>
        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uid { get; set; }

        /// <summary>
        /// 如果为true，表示该引用指向管理该资源的控制器
        /// </summary>
        [JsonProperty("controller", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Controller { get; set; }

        /// <summary>
        /// 当为true且拥有者有名为\&quot;foregroundDeletion\&quot;的finalizer 时，会阻止拥有者被删除，直到这个引用被移除
        /// </summary>
        [JsonProperty("blockOwnerDeletion", NullValueHandling = NullValueHandling.Ignore)]
        public bool? BlockOwnerDeletion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OwnerReference {\n");
            sb.Append("  apiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("  kind: ").Append(Kind).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  uid: ").Append(Uid).Append("\n");
            sb.Append("  controller: ").Append(Controller).Append("\n");
            sb.Append("  blockOwnerDeletion: ").Append(BlockOwnerDeletion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OwnerReference);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OwnerReference input)
        {
            if (input == null) return false;
            if (this.ApiVersion != input.ApiVersion || (this.ApiVersion != null && !this.ApiVersion.Equals(input.ApiVersion))) return false;
            if (this.Kind != input.Kind || (this.Kind != null && !this.Kind.Equals(input.Kind))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Uid != input.Uid || (this.Uid != null && !this.Uid.Equals(input.Uid))) return false;
            if (this.Controller != input.Controller || (this.Controller != null && !this.Controller.Equals(input.Controller))) return false;
            if (this.BlockOwnerDeletion != input.BlockOwnerDeletion || (this.BlockOwnerDeletion != null && !this.BlockOwnerDeletion.Equals(input.BlockOwnerDeletion))) return false;

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
                if (this.ApiVersion != null) hashCode = hashCode * 59 + this.ApiVersion.GetHashCode();
                if (this.Kind != null) hashCode = hashCode * 59 + this.Kind.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Uid != null) hashCode = hashCode * 59 + this.Uid.GetHashCode();
                if (this.Controller != null) hashCode = hashCode * 59 + this.Controller.GetHashCode();
                if (this.BlockOwnerDeletion != null) hashCode = hashCode * 59 + this.BlockOwnerDeletion.GetHashCode();
                return hashCode;
            }
        }
    }
}
