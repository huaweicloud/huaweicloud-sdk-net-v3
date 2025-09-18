using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CbcFreezeInfo 
    {

        /// <summary>
        /// 在冻结/解冻等操作下，云服务需要达到的主要效果：  - 1：（实现/去除）冻结可释放。（资源冻结后，客户可以手动删除/释放云资源和云资源上数据。）  - 2：（实现/去除）冻结不可释放。（资源冻结后，客户不能手动删除/释放云资源以及云资源上数据，相当于云服务被贴了封条，不能改变数据和资源。对应解冻后，就可以删除和修改客户数据了。）  - 3：（实现/去除）冻结后不可续费。（资源冻结后，资源不能发起续费操作；解冻后，才可以发起续费操作。）  - effect字段和上面status字段(1冻结、0解冻)配合使用，表示在发起冻结/解冻命令下，云服务达到的冻结效果。  - 为空时，默认为effect&#x3D;1（云服务需要能兼容处理，默认当做effect&#x3D;1）。  - 注：云服务是根据status和effect在真实限制云服务的操作/API等。不是使用下文的scene字段去做云服务操作/API的限制。下文的scene字段，主要用于Console页面的tips、API错误码等客户体验使用。
        /// </summary>
        [JsonProperty("effect", NullValueHandling = NullValueHandling.Ignore)]
        public int? Effect { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("scene", NullValueHandling = NullValueHandling.Ignore)]
        public CbcFreezeScene? Scene { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CbcFreezeInfo {\n");
            sb.Append("  effect: ").Append(Effect).Append("\n");
            sb.Append("  scene: ").Append(Scene).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CbcFreezeInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CbcFreezeInfo input)
        {
            if (input == null) return false;
            if (this.Effect != input.Effect || (this.Effect != null && !this.Effect.Equals(input.Effect))) return false;
            if (this.Scene != input.Scene || (this.Scene != null && !this.Scene.Equals(input.Scene))) return false;

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
                if (this.Effect != null) hashCode = hashCode * 59 + this.Effect.GetHashCode();
                if (this.Scene != null) hashCode = hashCode * 59 + this.Scene.GetHashCode();
                return hashCode;
            }
        }
    }
}
