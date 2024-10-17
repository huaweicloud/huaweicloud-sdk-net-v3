using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsDeploy.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CheckWhetherHostGroupCanBeCreatedResponse : SdkResponse
    {

        /// <summary>
        /// 是否有创建主机集群权限，true 有权限 false 无权限
        /// </summary>
        [JsonProperty("can_created", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanCreated { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckWhetherHostGroupCanBeCreatedResponse {\n");
            sb.Append("  canCreated: ").Append(CanCreated).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckWhetherHostGroupCanBeCreatedResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CheckWhetherHostGroupCanBeCreatedResponse input)
        {
            if (input == null) return false;
            if (this.CanCreated != input.CanCreated || (this.CanCreated != null && !this.CanCreated.Equals(input.CanCreated))) return false;

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
                if (this.CanCreated != null) hashCode = hashCode * 59 + this.CanCreated.GetHashCode();
                return hashCode;
            }
        }
    }
}
