using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// AI助手订阅用户请求，支持添加或删除用户、用户组、项目的订阅。
    /// </summary>
    public class SubscribeAiAssistantReq 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("add", NullValueHandling = NullValueHandling.Ignore)]
        public SubscribeOperationReq Add { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("delete", NullValueHandling = NullValueHandling.Ignore)]
        public SubscribeOperationReq Delete { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscribeAiAssistantReq {\n");
            sb.Append("  add: ").Append(Add).Append("\n");
            sb.Append("  delete: ").Append(Delete).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SubscribeAiAssistantReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SubscribeAiAssistantReq input)
        {
            if (input == null) return false;
            if (this.Add != input.Add || (this.Add != null && !this.Add.Equals(input.Add))) return false;
            if (this.Delete != input.Delete || (this.Delete != null && !this.Delete.Equals(input.Delete))) return false;

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
                if (this.Add != null) hashCode = hashCode * 59 + this.Add.GetHashCode();
                if (this.Delete != null) hashCode = hashCode * 59 + this.Delete.GetHashCode();
                return hashCode;
            }
        }
    }
}
